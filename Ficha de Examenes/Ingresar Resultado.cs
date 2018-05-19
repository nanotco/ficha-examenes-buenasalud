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

namespace Ficha_de_Examenes
{
    public partial class Ingresar_Resultado : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public Ingresar_Resultado()
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((txtRun.Text == "") || (txtObservacion.Text == "") || (cmbMedico.Text == "") || (cmbEstado.Text == "") || (txtPaciente.Text == ""))
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
                cmd.CommandText = ("SELECT * FROM Resultado WHERE rutPaciente = " +
                                             "'" + txtRun.Text + "-" + "' + '" + txtDV.Text + "'" +
                                             "AND  examen = " +
                                             "'" + cmbExamen.Text + "'");                             
                                                                                                     
                dr = cmd.ExecuteReader();//select
                if (dr.HasRows)//Para saber si encontró datos
                {
                    MessageBox.Show("Ya existe Resultado de Exámen");// Mensaje de aviso
                }
                else //Sino encontró nada procede a realizar insert
                {
                    con.Close();//Cerrar la conexión                                  
                    con.Open();//Abrir la conexión
                    cmd.CommandText = "INSERT INTO Resultado (" +
                                      "rutPaciente," +
                                      "examen," +
                                      "paciente," +
                                      "medico," +
                                      "estado," +                                      
                                      "resultado" +
                                      ") VALUES (" +
                                      "'" + txtRun.Text + "-" + "' + '" + txtDV.Text + "'," +
                                      "'" + cmbExamen.Text + "'," +
                                      "'" + txtPaciente.Text + "'," +
                                      "'" + cmbMedico.Text + "'," +
                                      "'" + cmbEstado.Text + "'," +                                      
                                      "'" + txtObservacion.Text + "');";
                                       
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

        private void Ingresar_Resultado_Load(object sender, EventArgs e)
        {
        
            //Conexion BD
            con.ConnectionString = @"Data Source=LENOVO;Initial Catalog=Buena_Salud;User ID=sa; Password=superuser";
            llenarCmbExamen();
            llenarCmbMedico();
            cmbExamen.SelectedIndex = -1;
            cmbMedico.SelectedIndex = -1;
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

        public void llenarCmbExamen()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select nombre From Examen", con);
            ds.Tables.Clear();
            da.Fill(ds, "Examen");
            cmbExamen.DataSource = ds.Tables[0];
            cmbExamen.DisplayMember = "nombre";
        }
        

        private void btnBusc_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader dr = null;//Para hacer consultas             
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                con.Open();

                //Consultar si existe en BD
                cmd.CommandText = ("SELECT * FROM Toma_Examen WHERE rutPaciente ='" + txtRun.Text + "-" + "' + '" + txtDV.Text + "'");

                dr = cmd.ExecuteReader();//select
                if (dr.HasRows)//Para saber si encontró datos
                {
                    dr.Read();
                    txtPaciente.Text = dr["paciente"].ToString();
                    txtFecha.Text = dr["fecha"].ToString();
                    txtHora.Text = dr["hora"].ToString();
                    cmbExamen.Text = dr["examen"].ToString();
                    txtComentario.Text = dr["observacion"].ToString();

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

        private void txtRun_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaNum(e);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtComentario.Clear();
            txtDV.Clear();
            txtFecha.Clear();
            txtHora.Clear();
            txtObservacion.Clear();
            txtPaciente.Clear();
            txtRun.Clear();
            cmbEstado.SelectedIndex = -1;
            cmbExamen.SelectedIndex = -1;
            cmbMedico.SelectedIndex = -1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            Paciente frm = new Paciente();
            frm.Show();
            this.Close();
        }

        private void btnNuevaConsulta_Click(object sender, EventArgs e)
        {
            txtComentario.Clear();
            txtDV.Clear();
            txtFecha.Clear();
            txtHora.Clear();
            txtObservacion.Clear();
            txtPaciente.Clear();
            txtRun.Clear();
            cmbEstado.SelectedIndex = -1;
            cmbExamen.SelectedIndex = -1;
            cmbMedico.SelectedIndex = -1;
        }
    }
}
