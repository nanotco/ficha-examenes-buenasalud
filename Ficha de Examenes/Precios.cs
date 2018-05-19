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
    public partial class Precios : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Precios()
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

        private void btnActuallizar_Click(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "")
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
                cmd.CommandText = ("SELECT * FROM Examen WHERE nombre = " +
                                                  "'" + cmbExamen.Text + "'" +
                                                  "AND  precio = " +
                                                  "'" + txtPrecio.Text + "'");

                dr = cmd.ExecuteReader();//select
                if (dr.HasRows)//Para saber si encontró datos
                {
                    MessageBox.Show("Ya existe Mismo Precio de Exámen");// Mensaje de aviso
                }
                else //Sino encontró nada procede a realizar insert
                {
                    con.Close();//Cerrar la conexión                                  
                    con.Open();//Abrir la conexión

                    cmd.CommandText = "UPDATE Examen SET precio= " +
                                              "'" + txtPrecio.Text + "' " +
                                              " WHERE nombre= " +
                                              "'" + cmbExamen.Text + "';";

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

        public void llenarCmbExamen()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select nombre From Examen", con);
            ds.Tables.Clear();
            da.Fill(ds, "Examen");
            cmbExamen.DataSource = ds.Tables[0];
            cmbExamen.DisplayMember = "nombre";
        }
        
        private void Precios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bS_DataSet.Examen' Puede moverla o quitarla según sea necesario.
            
            //Conexion BD
            con.ConnectionString = @"Data Source=LENOVO;Initial Catalog=Buena_Salud;User ID=sa; Password=superuser";
            llenarCmbExamen();
            cmbExamen.SelectedIndex = -1;
        }
        

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "")
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
                cmd.CommandText = ("SELECT * FROM Examen WHERE nombre = " +
                                                  "'" + cmbExamen.Text + "'" +
                                                  "AND  precio = " +
                                                  "'" + txtPrecio.Text + "'");

                dr = cmd.ExecuteReader();//select
                if (dr.HasRows)//Para saber si encontró datos
                {
                    MessageBox.Show("Ya existe precio");// Mensaje de aviso
                }
                else //Sino encontró nada procede a realizar insert
                {
                    con.Close();//Cerrar la conexión                                  
                    con.Open();//Abrir la conexión

                    cmd.CommandText = "UPDATE Examen SET precio= " +
                                              "'" + txtPrecio.Text + "' " +
                                              " WHERE nombre= " +
                                              "'" + cmbExamen.Text + "';";

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

        private void cmbExamen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    
        
        
    
