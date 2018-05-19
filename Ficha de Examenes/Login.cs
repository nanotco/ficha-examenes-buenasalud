using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Ficha_de_Examenes
{
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public login()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            try
            {
                string usuario = null;
                string clave =null;
                SqlDataReader dr = null;//Para hacer consultas             
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                con.Open();
                
                //Consultar si existe en BD
                cmd.CommandText = ("SELECT * FROM Usuarios WHERE usuario ='" + txtUsuario.Text +"'");

                dr = cmd.ExecuteReader();//select
                if (dr.HasRows)//Para saber si encontró datos
                {
                    dr.Read();
                    usuario = dr["usuario"].ToString();
                    clave = dr["clave"].ToString();
                    
                }
                if (txtUsuario.Text == usuario && txtClave.Text == clave)
                {
                    Principal frm = new Principal();
                    frm.Show();
                    this.Hide();
                    txtUsuario.Clear();
                    txtClave.Clear();
                    
                }
                else 
                {
                    //MessageBox.Show("Usuario o clave incorrecto. Intente nuevamente");
                    txtUsuario.Clear();
                    txtClave.Clear();
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
            Principal frm2 = new Principal();
            frm2.Show();
            this.Hide();
            txtUsuario.Clear();
            txtClave.Clear();
                        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
              

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
               
        private void login_Load(object sender, EventArgs e)
        {
            try
            {
                txtUsuario.Focus();
                //Conexion BD
                con.ConnectionString = @"Data Source=LENOVO;Initial Catalog=Buena_Salud;User ID=sa; Password=superuser";
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
        
    }
}
