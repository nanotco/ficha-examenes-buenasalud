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
    public partial class Paciente : Form
        
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Paciente()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Principal frm = new Principal();
            frm.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            login frm = new login();
            this.Close();
            frm.Close();
            Application.Exit();
        }

        public void llenarCmbCiudad()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select nombre From Ciudad", con);
            ds.Tables.Clear();
            da.Fill(ds, "Ciudad");
            cmbCiudad.DataSource = ds.Tables[0];
            cmbCiudad.DisplayMember = "nombre";
        }

        public void llenarCmbRegion()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select nombre From Region", con);
            ds.Tables.Clear();
            da.Fill(ds, "Region");
            cmbRegion.DataSource = ds.Tables[0];
            cmbRegion.DisplayMember = "nombre";
        }

        private void btnRegistrarCiudad_Click(object sender, EventArgs e)
        {
            if (txtNuevaCiudad.Text == "")
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
                cmd.CommandText = ("SELECT * FROM Ciudad WHERE nombre ='" + txtNuevaCiudad.Text + "'");

                dr = cmd.ExecuteReader();//select
                if (dr.HasRows)//Para saber si encontró datos
                {
                    MessageBox.Show("Ya existe Ciudad");// Mensaje de aviso
                }
                else //Sino encontró nada procede a realizar insert
                {
                    con.Close();//Cerrar la conexión                                  
                    con.Open();//Abrir la conexión

                    cmd.CommandText = "INSERT INTO Ciudad (nombre) VALUES ('" + txtNuevaCiudad.Text + "')";

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

                pnlCiudad.Visible = false;
                btnRegistrar.Enabled = true;
                btnModificar.Enabled = true;
                llenarCmbCiudad();
                cmbCiudad.SelectedIndex = -1;
            }
        }

        private void btnCiudad_Click(object sender, EventArgs e)
        {
            pnlCiudad.Visible = true;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void Paciente_Load(object sender, EventArgs e)
        {
           
            //Conexion BD
            con.ConnectionString = @"Data Source=LENOVO;Initial Catalog=Buena_Salud;User ID=sa; Password=superuser";
            llenarCmbCiudad();
            cmbCiudad.SelectedIndex = -1;
            llenarCmbRegion();
            cmbRegion.SelectedIndex = -1;
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if ((txtRun.Text == "") || (txtNombre.Text == "") || (txtDireccion.Text == "") || (txtApellido.Text == ""))
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
                cmd.CommandText = ("SELECT * FROM Paciente WHERE rut ='" + txtRun.Text + "-" + "' + '" + txtDV.Text + "'");
                
                dr = cmd.ExecuteReader();//select
                if (dr.HasRows)//Para saber si encontró datos
                {
                    MessageBox.Show("Ya existe Paciente");// Mensaje de aviso
                }
                else //Sino encontró nada procede a realizar insert
                {
                    con.Close();//Cerrar la conexión                                  
                    con.Open();//Abrir la conexión
                    cmd.CommandText = "INSERT INTO Paciente (" +
                                      "rut," +
                                      "nombre," +
                                      "apellido," +
                                      "direccion," +
                                      "region," +
                                      "ciudad," +                                      
                                      "telefono," +
                                      "email" +
                                      ") VALUES (" +
                                      "'" + txtRun.Text + "-" + "' + '" + txtDV.Text + "'," +
                                      "'" + txtNombre.Text + "'," +
                                      "'" + txtApellido.Text + "'," +
                                      "'" + txtDireccion.Text + "'," +
                                      "'" + cmbRegion.Text + "'," +
                                      "'" + cmbCiudad.Text + "'," +                                      
                                      "'" + txtTelefono.Text + "'," +
                                      "'" + txtEmail.Text + "');";
                    
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

        private void btnBusc_Click(object sender, EventArgs e)
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
                    cmbRegion.Text = dr["region"].ToString();
                    cmbCiudad.Text = dr["ciudad"].ToString();                    
                    txtTelefono.Text = dr["telefono"].ToString();
                    txtEmail.Text = dr["email"].ToString();
                }
                else //Sino encontró nada procede a realizar insert
                {
                    MessageBox.Show("No se encontró datos");
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

        private void txtRun_KeyPress(object sender, KeyPressEventArgs e)
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtDV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRun_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlCiudad.Visible = false;
            btnRegistrar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if ((txtRun.Text == "") || (txtNombre.Text == "") || (txtDireccion.Text == "") || (txtApellido.Text == ""))
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
                cmd.CommandText = ("SELECT * FROM Paciente WHERE rut ='" + txtRun.Text + "' + '" + txtDV.Text + "' " +
                                              "AND nombre ='" + txtNombre.Text + "' " +
                                              "AND direccion ='" + txtDireccion.Text + "' " +
                                              "AND region ='" + cmbRegion.Text + "' " +
                                              "AND ciudad ='" + cmbCiudad.Text + "' " +                                              
                                              "AND telefono ='" + txtTelefono.Text + "' " +
                                              "AND email ='" + txtEmail.Text + "'");

                dr = cmd.ExecuteReader();//select
                if (dr.HasRows)//Para saber si encontró datos
                {
                    MessageBox.Show("No ha modificado datos");// Mensaje de aviso
                }
                else //Sino encontró nada procede a realizar insert
                {
                    con.Close();//Cerrar la conexión                                  
                    con.Open();//Abrir la conexión

                    cmd.CommandText = "UPDATE Paciente SET rut= " +
                                              "'" + txtRun.Text + "' + '" + txtDV.Text + "'," +
                                              "nombre='" + txtNombre.Text + "', " +
                                              "direccion='" + txtDireccion.Text + "', " +
                                              "region='" + cmbRegion.Text + "', " +
                                              "ciudad='" + cmbCiudad.Text + "', " +                                              
                                              "telefono='" + txtTelefono.Text + "', " +
                                              "email='" + txtEmail.Text + "' " +
                                              " WHERE rut= " +
                                              "'" + txtRun.Text + "' + '" + txtDV.Text + "';";

                    int NFilas = cmd.ExecuteNonQuery();
                    if (NFilas > 0)
                    {
                        MessageBox.Show("Registro exitoso");
                    }
                    else
                    {
                        MessageBox.Show("No puede cambiar el rut, registre nuevamente en caso de ser necesario");
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

        private void btnNuevaConsulta_Click(object sender, EventArgs e)
        {
            cmbCiudad.SelectedIndex = -1;
            cmbRegion.SelectedIndex = -1;
            txtApellido.Clear();
            txtDireccion.Clear();
            txtDV.Clear();
            txtEmail.Clear();
            txtNombre.Clear();
            txtNuevaCiudad.Clear();
            txtRun.Clear();
            txtTelefono.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cmbCiudad.SelectedIndex = -1;            
            cmbRegion.SelectedIndex = -1;
            txtApellido.Clear();
            txtDireccion.Clear();
            txtDV.Clear();
            txtEmail.Clear();
            txtNombre.Clear();
            txtNuevaCiudad.Clear();            
            txtRun.Clear();
            txtTelefono.Clear();
        }
        
        
    }
}
