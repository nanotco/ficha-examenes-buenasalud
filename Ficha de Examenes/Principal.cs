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
using System.Reflection;

namespace Ficha_de_Examenes
{
    public partial class Principal : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public Principal()
        {
            InitializeComponent();
            //Inicio Carga el groupbox acerca del software
            //this.Text = String.Format("Acerca de {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Versión {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
            //Fin Carga el groupbox acerca del software
        }

        //Inicio Obtiene datos del ensamblado del programa
        #region Descriptores de acceso de atributos de ensamblado

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
        //Final Obtiene datos del ensamblado del programa
                  
              

        private void gestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hospital  frm = new Hospital();
            frm.Show();
            this.Hide();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
            //Conexion BD
            con.ConnectionString = @"Data Source=LENOVO;Initial Catalog=Buena_Salud;User ID=sa; Password=superuser";
            Hospital();
            
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca_de  frm = new Acerca_de ();
            frm.Show();
            this.Hide();
        }

        private void definiciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Examen  frm = new Examen();
            frm.Show();
            this.Hide();
        }

        private void preciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Precios  frm = new Precios();
            frm.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login frm = new login();
            this.Close();
            frm.Close();
            Application.Exit();
        }

        private void sALIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            login frm = new login();
            this.Close();
            frm.Close();
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sstrFechayHora.Text = DateTime.Now.ToShortDateString().ToString() + " - " + DateTime.Now.ToLongTimeString().ToString(); 
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_Examenes frm = new Listado_Examenes();
            frm.Show();
            this.Hide();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paciente frm = new Paciente();
            frm.Show();
            this.Hide();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Médico frm = new Médico();
            frm.Show();
            this.Hide();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Agenda_Exámen frm = new Agenda_Exámen();
            frm.Show();
            this.Hide();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Consultar_Agenda frm = new Consultar_Agenda();
            frm.Show();
            this.Hide();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tomar_Exámen frm = new Tomar_Exámen();
            frm.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios frm = new Usuarios();
            frm.Show();
            this.Hide();
        }

        private void registrarResultadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingresar_Resultado frm = new Ingresar_Resultado();
            frm.Show();
            this.Hide();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resultado frm = new Resultado();
            frm.Show();
            this.Hide();
        }

        private void aRCHIVOToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Historial frm = new Historial();
            frm.Show();
            this.Hide();
        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void listadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Listado_Medicos frm = new Listado_Medicos();
            frm.Show();
            this.Hide();
        }

        private void listadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Listado_Pacientes frm = new Listado_Pacientes();
            frm.Show();
            this.Hide();
        }

        //Consulta Hospital carga al Load
        public void Hospital()
        {
            try
            {
                SqlDataReader dr = null;//Para hacer consultas             
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                con.Open();

                //Consultar si existe en BD
                cmd.CommandText = ("SELECT * FROM Hospital ");
                
                dr = cmd.ExecuteReader();//select
                if (dr.HasRows)//Para saber si encontró datos
                {

                    dr.Read();
                    txtNombre.Text = dr["nombre"].ToString();
                    txtCiudad.Text = dr["ciudad"].ToString();
                    txtDireccion.Text = dr["direccion"].ToString();
                    txtDirector.Text = dr["director"].ToString();
                    txtRut.Text = dr["rut"].ToString();
                    txtRegion.Text = dr["region"].ToString();
                    txtEmail.Text = dr["email"].ToString();
                    txttelefono.Text = dr["telefono"].ToString();

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

        private void mANUALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManualUsuario frm = new ManualUsuario();
            frm.Show();
            this.Hide();
        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManualUsuario frm = new ManualUsuario();
            frm.Show();
            this.Hide();
        }

        private void manualDeConfiguraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manual_Configuración frm = new Manual_Configuración();
            frm.Show();
            this.Hide();
        }

        private void manualDeInstalaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manual_Instalación frm = new Manual_Instalación();
            frm.Show();
            this.Hide();
        }
        
    }
}
