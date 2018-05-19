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
    public partial class Examen : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public Examen()
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

        private void grbDefExamen_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pnlTipoExamen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDefinir_Click(object sender, EventArgs e)
        {
            pnlTipoExamen.Visible = true;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnGuardarTipoEx_Click(object sender, EventArgs e)
        {
            if (txtTipoExamen.Text == "")
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
                cmd.CommandText = ("SELECT * FROM Tipo_examen WHERE tipo ='" + txtTipoExamen.Text + "'");
                
                dr = cmd.ExecuteReader();//select
                if (dr.HasRows)//Para saber si encontró datos
                {
                    MessageBox.Show("Ya existe Tipo de examen");// Mensaje de aviso
                }
                else //Sino encontró nada procede a realizar insert
                {
                    con.Close();//Cerrar la conexión                                  
                    con.Open();//Abrir la conexión

                    cmd.CommandText = "INSERT INTO Tipo_examen (tipo) VALUES ('" + txtTipoExamen.Text + "')";

                    int NFilas = cmd.ExecuteNonQuery();
                    if (NFilas > 0)
                    {
                        MessageBox.Show("Registro exitoso");
                        llenarCmbTipo_examen();
                        cmbTipoExamen.SelectedIndex = -1;
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
                pnlTipoExamen.Visible = false;
                btnGuardar.Enabled = true;
                btnModificar.Enabled = true;
               
            }
         }

        public void llenarCmbTipo_examen()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select tipo From Tipo_examen", con);
            ds.Tables.Clear();
            da.Fill(ds, "Tipo_examen");
            cmbTipoExamen.DataSource = ds.Tables[0];
            cmbTipoExamen.DisplayMember = "tipo";
        }
        
        private void Examen_Load(object sender, EventArgs e)
        {
            
            //Conexion BD
            con.ConnectionString = @"Data Source=LENOVO;Initial Catalog=Buena_Salud;User ID=sa; Password=superuser";
            llenarCmbTipo_examen();
            cmbTipoExamen.SelectedIndex = -1;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((txtPrecio.Text == "") || (txtNombre.Text == ""))
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
                //cmd.CommandText = ("SELECT * FROM Examen WHERE nombre ='" + txtNombre.Text + "'");
                cmd.CommandText = ("SELECT * FROM Examen WHERE nombre ='" + txtNombre.Text + "'" +
                                              "AND tipo ='" + cmbTipoExamen.Text + "' " +
                                              "AND precio ='" + txtPrecio.Text + "'" +
                                              "AND descripcion ='" + txtObservacion.Text + "'");
                                
                dr = cmd.ExecuteReader();//select
                if (dr.HasRows)//Para saber si encontró datos
                {
                    MessageBox.Show("Ya existe Exámen");// Mensaje de aviso
                }
                else //Sino encontró nada procede a realizar insert
                {
                    con.Close();//Cerrar la conexión                                  
                    con.Open();//Abrir la conexión
                    cmd.CommandText = "INSERT INTO Examen (" +
                                      "nombre," +
                                      "tipo," +
                                      "precio," +
                                      "descripcion" +                                      
                                      ") VALUES (" +                                      
                                      "'" + txtNombre.Text + "'," +
                                      "'" + cmbTipoExamen.Text + "'," +
                                      "'" + txtPrecio.Text + "'," +
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlTipoExamen.Visible = false;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if ((txtPrecio.Text == "") || (txtNombre.Text == ""))
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
                cmd.CommandText = ("SELECT * FROM Examen WHERE nombre ='" + txtNombre.Text + "' " +
                                             "AND tipo ='" + cmbTipoExamen.Text + "' " +
                                             "AND precio ='" + txtPrecio.Text + "' " +                                                                                 
                                             "AND descripcion ='" + txtObservacion.Text  + "'");                                         
                                                         
                dr = cmd.ExecuteReader();//select
                if (dr.HasRows)//Para saber si encontró datos
                {
                    MessageBox.Show("No ha modificado datos");// Mensaje de aviso
                }
                else //Sino encontró nada procede a realizar insert
                {
                    con.Close();//Cerrar la conexión                                  
                    con.Open();//Abrir la conexión

                    cmd.CommandText = "UPDATE Examen SET nombre= " +
                                              "'" + txtNombre.Text + "', " +
                                              "tipo='" + cmbTipoExamen.Text + "', " +                                              
                                              "precio='" + txtPrecio.Text + "', " +
                                              "descripcion='" + txtObservacion.Text + "' " +
                                              " WHERE nombre= " +
                                              "'" + txtNombre.Text + "';";

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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cmbTipoExamen.SelectedIndex = -1;
            txtNombre.Clear();
            txtObservacion.Clear();
            txtPrecio.Clear();
            txtTipoExamen.Clear();
        }
    }
}
