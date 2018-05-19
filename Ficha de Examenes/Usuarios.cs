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
    public partial class Usuarios : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
               
        public Usuarios()
        {
            InitializeComponent();
        }

        public void llenarCmbUsuarios()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select usuario From Usuarios", con);
            ds.Tables.Clear();
            da.Fill(ds, "Usuarios");
            cmbUsuario.DataSource = ds.Tables[0];
            cmbUsuario.DisplayMember = "usuario";
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

        private void Usuarios_Load(object sender, EventArgs e)
        {
                        
            //Conexion BD
            con.ConnectionString = @"Data Source=LENOVO;Initial Catalog=Buena_Salud;User ID=sa; Password=superuser";
            llenarCmbUsuarios();
            cmbUsuario.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "") || (txtClave.Text == "") || (txtConfirmarClave.Text == ""))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }
            if ((txtClave.Text !=txtConfirmarClave.Text))
            {
                MessageBox.Show("No coincide clave. Intente de nuevo");
                return;                         
            }
            try
            {                
                SqlDataReader dr = null;//Para hacer consultas             
                SqlCommand cmd = new SqlCommand();
                
                cmd.Connection = con;
                con.Open();

                //Consultar si existe en BD
                cmd.CommandText = ("SELECT usuario,clave FROM Usuarios WHERE usuario ='" + txtUsuario.Text + "'");
                     
                dr = cmd.ExecuteReader();//select
                if (dr.HasRows)//Para saber si encontró datos
                {
                MessageBox.Show("Ya existe usuario");// Mensaje de aviso
                }
                else //Sino encontró nada procede a realizar insert
                {
                con.Close();//Cerrar la conexión                                  
                con.Open();//Abrir la conexión

                cmd.CommandText = "INSERT INTO Usuarios (usuario,clave) VALUES ('" + txtUsuario.Text + "','" + txtClave.Text + "');";
                    
                int NFilas = cmd.ExecuteNonQuery();                
                if (NFilas > 0)
                {
                    MessageBox.Show("Registro exitoso");
                    llenarCmbUsuarios();
                    cmbUsuario.SelectedIndex = -1;
                    txtUsuario.Clear();
                    txtClave.Clear();
                    txtConfirmarClave.Clear();
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if ((txtAdmClave.Text == "") || (txtAdmConfirmarClave.Text == ""))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }
            if ((txtAdmClave.Text != txtAdmConfirmarClave.Text))
            {
                MessageBox.Show("No coincide clave. Intente de nuevo");
                return;                
            }
            try
            {
                SqlDataReader dr = null;//Para hacer consultas             
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                con.Open();

                //Consultar si existe en BD
                
                cmd.CommandText = ("SELECT * FROM Usuarios WHERE usuario ='" + cmbUsuario.Text + "' " +
                                             "AND clave ='" + txtAdmClave.Text + "'");
                
                dr = cmd.ExecuteReader();//select
                if (dr.HasRows)//Para saber si encontró datos
                {
                    MessageBox.Show("No ha modificado datos");// Mensaje de aviso
                }
                else //Sino encontró nada procede a realizar insert
                {
                    con.Close();//Cerrar la conexión                                  
                    con.Open();//Abrir la conexión

                    cmd.CommandText = "UPDATE Usuarios SET clave= " +
                                              "'" + txtAdmClave.Text + "' " +                                              
                                              " WHERE usuario= " +
                                              "'" + cmbUsuario.Text + "';";

                    int NFilas = cmd.ExecuteNonQuery();
                    if (NFilas > 0)
                    {
                        MessageBox.Show("Registro exitoso");                        
                        txtAdmClave.Clear();
                        txtAdmConfirmarClave.Clear();                        
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                con.Open();                

                
                    con.Close();//Cerrar la conexión                                  
                    con.Open();//Abrir la conexión

                    cmd.CommandText = ("DELETE FROM Usuarios WHERE usuario ='" + cmbUsuario.Text + "'");

                    int NFilas = cmd.ExecuteNonQuery();
                    if (NFilas > 0)
                    {
                        MessageBox.Show("Registro eliminado");
                        llenarCmbUsuarios();
                        cmbUsuario.SelectedIndex = -1;
                        txtAdmClave.Clear();
                        txtAdmConfirmarClave.Clear();                        
                    }
                    else
                    {
                        MessageBox.Show("No se eliminó");
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
    }
}