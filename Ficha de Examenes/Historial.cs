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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.Data.SqlClient;


namespace Ficha_de_Examenes
{
    public partial class Historial : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Historial()
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //(SELECT * FROM detalle_pago  WHERE rutResidente = RutResidentePago and anioPago='" & cmbAnio.Text & "'and MesPago = '" & cmbMes.Text & "')"
            try
            {
                //Consulta mediante un DataSet        
                SqlCommand cmd = new SqlCommand("Select * from Agenda", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvResultados.DataSource = ds.Tables[0];
                con.Close();
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

        private void Historial_Load(object sender, EventArgs e)
        {
            //Conexion BD
            con.ConnectionString = @"Data Source=LENOVO;Initial Catalog=Buena_Salud;User ID=sa; Password=superuser";
            rbtPaciente.Checked = true;
            
        }

        private void rbtNumero_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Consulta mediante un DataSet        
                SqlCommand cmd = new SqlCommand("Select * from Agenda", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvResultados.DataSource = ds.Tables[0];
                con.Close();
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

       

        private void btnCrearReporte_Click(object sender, EventArgs e)
        {
            if (dgvResultados.RowCount == 0)
            {
                MessageBox.Show("No Hay Datos Para Realizar Un Reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {   //ESCOJE LA RUTA DONDE GUARDAREMOS EL PDF
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string filename = save.FileName;
                    DateTime hora = DateTime.Now;
                    string fcha_ttal = Convert.ToDateTime(hora).Day + "/" + Convert.ToDateTime(hora).Month + "/" + Convert.ToDateTime(hora).Year;
                    Document doc = new Document(PageSize.LETTER, 10, 10, 10, 10);
                    iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(@"C:\Users\hernan\Documents\Iconos\BS_logo.png"); png.Alignment = iTextSharp.text.Image.ALIGN_RIGHT;
                    png.ScaleToFit(75f, 75f);//escalar imagen en el PDF

                    Chunk encab = new Chunk("Reporte Historial  ", FontFactory.GetFont("COURIER", 12));
                    //Chunk encab = new Chunk("Reporte de Paciente " + cmbPaciente.Text + " ", FontFactory.GetFont("COURIER", 12));
                    Chunk ap = new Chunk("Fecha " + fcha_ttal + " ", FontFactory.GetFont("COURIER", 12));
                    Chunk nada = new Chunk(" ", FontFactory.GetFont("COURIER", 12));

                    try
                    {
                        FileStream file = new FileStream(filename, FileMode.OpenOrCreate);
                        PdfWriter writer = PdfWriter.GetInstance(doc, file);
                        writer.ViewerPreferences = PdfWriter.PageModeUseThumbs;
                        writer.ViewerPreferences = PdfWriter.PageLayoutOneColumn;
                        doc.Open();

                        doc.Add(png);
                        doc.Add(new Paragraph(encab));
                        doc.Add(new Paragraph(ap));
                        doc.Add(new Paragraph(nada));
                        GenerarDocumentos(doc);

                        Process.Start(filename);
                        doc.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        //Inicio Función que genera el documento Pdf
        public void GenerarDocumentos(Document document)
        {
            //se crea un objeto PdfTable con el numero de columnas del dataGridView 
            PdfPTable datatable = new PdfPTable(dgvResultados.ColumnCount);
            //asignamos algunas propiedades para el diseño del pdf 
            datatable.DefaultCell.Padding = 1;
            float[] headerwidths = GetTamañoColumnas(dgvResultados);

            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 1;

            datatable.DefaultCell.BackgroundColor = iTextSharp.text.BaseColor.WHITE;//DEFINIMOS EL COLOR DE LAS CELDAS EN EL PDF
            datatable.DefaultCell.BorderColor = iTextSharp.text.BaseColor.BLACK;//DEFINIMOS EL COLOR DE LOS BORDES
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA);//LA FUENTE DE NUESTRO TEXTO

            Phrase objP = new Phrase("A", fuente);

            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            //SE GENERA EL ENCABEZADO DE LA TABLA EN EL PDF 

            for (int i = 0; i < dgvResultados.ColumnCount; i++)
            {
                objP = new Phrase(dgvResultados.Columns[i].HeaderText, fuente);
                datatable.HorizontalAlignment = Element.ALIGN_CENTER;

                datatable.AddCell(objP);

            }
            datatable.HeaderRows = 1;

            datatable.DefaultCell.BorderWidth = 1;

            //SE GENERA EL CUERPO DEL PDF
            for (int i = 0; i < dgvResultados.RowCount; i++)
            {
                for (int j = 0; j < dgvResultados.ColumnCount; j++)
                {
                    objP = new Phrase(dgvResultados[j, i].Value.ToString(), fuente);
                    datatable.AddCell(objP);
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }
        //Final Función que genera el documento Pdf



        //Inicio Función que obtiene los tamaños de las columnas del datagridview
        public float[] GetTamañoColumnas(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];//ESTE ARRAY GUARDA EL NUMERO DE COLUMNAS DEL GRIDVIEW
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;//VAYA ASIGNANDO A UNA POSICION DEL VECTOR EL ANCHO DE CADA COLUMNA

            }
            return values;
        }

        private void btnNuevaConsulta_Click(object sender, EventArgs e)
        {
                   
            dgvResultados.DataSource = null;
                       
        }

        private void rbtExamen_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Consulta mediante un DataSet        
                SqlCommand cmd = new SqlCommand("Select * from Examen", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvResultados.DataSource = ds.Tables[0];
                con.Close();
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

        private void rbtPaciente_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Consulta mediante un DataSet        
                SqlCommand cmd = new SqlCommand("Select * from Paciente", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvResultados.DataSource = ds.Tables[0];
                con.Close();
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

        private void rbtMedicos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Consulta mediante un DataSet        
                SqlCommand cmd = new SqlCommand("Select * from Medico", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvResultados.DataSource = ds.Tables[0];
                con.Close();
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

        private void rbtResultados_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Consulta mediante un DataSet        
                SqlCommand cmd = new SqlCommand("Select * from Resultado", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvResultados.DataSource = ds.Tables[0];
                con.Close();
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Consulta mediante un DataSet        
                SqlCommand cmd = new SqlCommand("Select * from Toma_Examen", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvResultados.DataSource = ds.Tables[0];
                con.Close();
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
