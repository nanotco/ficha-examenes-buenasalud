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
    public partial class Listado_Pacientes : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public Listado_Pacientes()
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

        public void llenarCmbPaciente()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select rut From Paciente", con);
            ds.Tables.Clear();
            da.Fill(ds, "Paciente");
            cmbPaciente.DataSource = ds.Tables[0];
            cmbPaciente.DisplayMember = "rut";
        }

               
        
        private void Listado_Pacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bS_DataSet.Paciente' Puede moverla o quitarla según sea necesario.
            this.pacienteTableAdapter.Fill(this.bS_DataSet.Paciente);                        
            //Conexion BD
            con.ConnectionString = @"Data Source=LENOVO;Initial Catalog=Buena_Salud;User ID=sa; Password=superuser";
            llenarCmbPaciente();
            cmbPaciente.SelectedIndex = -1;
            
        }
        
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //Realiza consulta en DGV
            DataView dv = new DataView(bS_DataSet.Paciente);

            dv.RowFilter = String.Format("nombre like '%" + txtBuscar.Text + "%'");
            dgvResultados.DataSource = dv;
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
        //Final Función que obtiene los tamaños de las columnas del datagridview

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

                    Chunk encab = new Chunk("Reporte de Paciente  ", FontFactory.GetFont("COURIER", 12));
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

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Realiza consulta en DGV
            DataView dv = new DataView(bS_DataSet.Paciente);
            dv.RowFilter = String.Format("rut like '%" + cmbPaciente.Text + "%'");
            dgvResultados.DataSource = dv;
        }

        private void btnNuevaConsulta_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            cmbPaciente.SelectedIndex = -1;            
        }
        }
       
    }




