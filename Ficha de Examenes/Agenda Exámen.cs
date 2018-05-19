using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Ficha_de_Examenes
{
    public partial class Agenda_Exámen : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public Agenda_Exámen()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            login frm = new login();
            this.Close();
            frm.Close();
            Application.Exit();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Principal frm = new Principal();
            frm.Show();
            this.Close();
        }

        public void llenarCmbMedico()
        {
            DataSet ds = new DataSet();
            //Concatena nombre y apellido
            SqlDataAdapter da = new SqlDataAdapter("Select (nombre + \' \' + apellido) as Name_Full From Medico", con);
            ds.Tables.Clear();
            da.Fill(ds, "Medico");
            cmbMedico.DataSource = ds.Tables[0];
            cmbMedico.DisplayMember = "Name_Full";
        }

        public void llenarCmbExamen()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select nombre From Examen", con);
            ds.Tables.Clear();
            da.Fill(ds, "Examen");
            cmbExamen.DataSource = ds.Tables[0];
            cmbExamen.DisplayMember = "nombre";
        }

        private void Agenda_Exámen_Load(object sender, EventArgs e)
        {
            SetMyCustomFormat();
            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());//cadena conexion del App.config
            //Conexion BD            
            con.ConnectionString = @"Data Source=LENOVO;Initial Catalog=Buena_Salud;User ID=sa; Password=superuser";
            llenarCmbExamen();
            llenarCmbMedico();
            cmbExamen.SelectedIndex = -1;
            cmbMedico.SelectedIndex = -1;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if ((txtRun.Text == "") || (cmbMedico.Text == "") || (mtbHora.Text == "") || (txtFecha.Text == ""))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }
            try
            {
                SqlDataReader dr = null;//Para hacer consultas             
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                con.Open();
                
                //Consultar si existe en BD
                cmd.CommandText = ("SELECT * FROM Agenda WHERE examen = " +
                                             "'" + cmbExamen.Text + "'" +
                                             "AND  rutPaciente = " +
                                             "'" + txtRun.Text + "-" + "' + '" + txtDV.Text + "'" +
                                             "AND  medico = " +
                                             "'" + cmbMedico.Text + "'" +                                             
                                             "AND  fecha = " +
                                             "'" + txtFecha.Text + "'");
                
                dr = cmd.ExecuteReader();//select
                if (dr.HasRows)//Para saber si encontró datos
                {
                    MessageBox.Show("Ya existe exámen agendado para el Paciente");// Mensaje de aviso
                }
                else //Sino encontró nada procede a realizar insert
                {
                    con.Close();//Cerrar la conexión                                  
                    con.Open();//Abrir la conexión
                    cmd.CommandText = "INSERT INTO Agenda (" +
                                      "rutPaciente," +
                                      "examen," +
                                      "paciente," +
                                      "medico," +
                                      "hora," +
                                      "fecha," +
                                      "comentario" +                                      
                                      ") VALUES (" +
                                      "'" + txtRun.Text + "-" + "' + '" + txtDV.Text + "'," +
                                      "'" + cmbExamen.Text + "'," +
                                      "'" + txtNombre.Text + " " + "' + '" + txtApellido.Text + "'," +
                                      "'" + cmbMedico.Text + "'," +
                                      "'" + mtbHora.Text + "'," +
                                      "'" + txtFecha.Text + "'," +
                                      "'" + txtComentario.Text + "');";
                                     
                    int NFilas = cmd.ExecuteNonQuery();
                    if (NFilas > 0)
                    {
                        MessageBox.Show("Registro exitoso");
                    }
                    else
                    {
                        MessageBox.Show("No se registró");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close(); //Cerrar la conexión
            }
        }

        private void clFecha_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Muestra fecha selecciona del calendario en el textbox
            this.txtFecha.Text =
              clFecha.SelectionRange.Start.Date.ToShortDateString();            
        }

        private void cmbExamen_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader dr = null;//Para hacer consultas             
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                con.Open();

                //Consultar si existe en BD
                cmd.CommandText = ("SELECT * FROM Paciente WHERE rut ='" + txtRun.Text + "' + '" + txtDV.Text + "'");

                dr = cmd.ExecuteReader();//select
                if (dr.HasRows)//Para saber si encontró datos
                {
                    dr.Read();
                    txtNombre.Text = dr["nombre"].ToString();
                    txtApellido.Text = dr["apellido"].ToString();
                    txtDireccion.Text = dr["direccion"].ToString();
                    txtRegion.Text = dr["region"].ToString();
                    txtCiudad.Text = dr["ciudad"].ToString();
                    txtTelefono.Text = dr["telefono"].ToString();
                    txtEmail.Text = dr["email"].ToString();
                }
                else //Sino encontró nada procede a realizar insert
                {

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close(); //Cerrar la conexión
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            mtbHora.Format = DateTimePickerFormat.Custom;
            mtbHora.CustomFormat = "HH:mm";
        }
        private void mtbHora_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        /* INICIO Función de calcula el dígito verificador del RUT */
        public void digitoVerificador(int rut)
        {
            int Digito;
            int Contador;
            int Multiplo;
            int Acumulador;
            string RutDigito;

            Contador = 2;
            Acumulador = 0;

            while (rut != 0)
            {
                Multiplo = (rut % 10) * Contador;
                Acumulador = Acumulador + Multiplo;
                rut = rut / 10;
                Contador = Contador + 1;

                if (Contador == 8)
                {
                    Contador = 2;
                }

            }

            Digito = 11 - (Acumulador % 11);
            RutDigito = Digito.ToString().Trim();

            if (Digito == 10)
            {
                RutDigito = "K";
            }
            if (Digito == 11)
            {
                RutDigito = "0";
            }

            //return (RutDigito);
            this.txtDV.Text = RutDigito;
        }
        /* FIN Función de calcula el dígito verificador del RUT */


        //INI Función para la Validación de sólo números en controles TextBox
        private void validaNum(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
               
             
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader dr = null;//Para hacer consultas             
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                con.Open();

                //Consultar si existe en BD
                cmd.CommandText = ("SELECT * FROM Paciente WHERE rut ='" + txtRun.Text + "-" + "' + '" + txtDV.Text + "'");

                dr = cmd.ExecuteReader();//select
                if (dr.HasRows)//Para saber si encontró datos
                {
                    dr.Read();
                    txtNombre.Text = dr["nombre"].ToString();
                    txtApellido.Text = dr["apellido"].ToString();
                    txtDireccion.Text = dr["direccion"].ToString();
                    txtRegion.Text = dr["region"].ToString();
                    txtCiudad.Text = dr["ciudad"].ToString();
                    txtTelefono.Text = dr["telefono"].ToString();
                    txtEmail.Text = dr["email"].ToString();
                }
                else //Sino encontró nada procede a realizar insert
                {
                    MessageBox.Show("No se encontró datos");// Mensaje de aviso
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close(); //Cerrar la conexión
            }
        }

        private void btnNuevaConsulta_Click(object sender, EventArgs e)
        {
            txtRun.Clear();
            txtDV.Clear();
            txtApellido.Clear();
            txtCiudad.Clear();
            txtComentario.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            txtFecha.Clear();
            txtRegion.Clear();
            txtTelefono.Clear();
            txtNombre.Clear();
            cmbExamen.SelectedIndex = -1;
            cmbMedico.SelectedIndex = -1;
        }

        private void txtRun_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validaNum(e);
        }

        private void txtRun_Leave(object sender, EventArgs e)
        {
            try
            {
                if (this.txtRun.Text == "")
                {
                    this.txtRun.Focus();
                    this.txtRun.Text = "?";
                }
                else if (this.txtRun.Text == "?")
                {
                    this.txtRun.Focus();
                }
                else
                {
                    int rut = Convert.ToInt32(this.txtRun.Text);
                    digitoVerificador(rut);

                    //Habilitación de controles
                    this.btnBusc.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error al ingresar datos.\n" +
                                "Por favor, intente nuevamente.\n" +
                                "---------\n" +
                                "Error: " + ex.Message, "Error de Datos");

                this.txtRun.Clear();
                this.txtDV.Clear();

                this.txtRun.Focus();
            }
        }

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            Paciente frm = new Paciente();
            frm.Show();
            this.Close();
        }

        private void lblComentario_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtRun.Clear();
            txtDV.Clear();
            txtApellido.Clear();
            txtCiudad.Clear();
            txtComentario.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            txtFecha.Clear();
            txtRegion.Clear();
            txtTelefono.Clear();
            txtNombre.Clear();
            cmbExamen.SelectedIndex = -1;
            cmbMedico.SelectedIndex = -1;
        }
    }
}
