using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Allenvios : Form
    {

        CN_envios objetoCN = new CN_envios();
        public Allenvios()
        {
            InitializeComponent();
        }

        private void Allenvios_Load(object sender, EventArgs e)
        {
            MostrarEnv();
        }

        private void MostrarEnv()
        {

            dgvEnvios.DataSource = objetoCN.MostrarEnvios();
        }

        private void dgvEnvios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnpdf_Click(object sender, EventArgs e)
        {

            
        }

        private void btnpdf_Click_1(object sender, EventArgs e)
        {
            try
            {
                Document doc = new Document(PageSize.LETTER);


                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\ezequ\Desktop\Datos.pdf", FileMode.Create));
                doc.AddTitle("Boleta");
                doc.AddCreator("Ezequiel del Castillo");

                doc.Open();

                doc.Add(new Paragraph("Todos los envios"));
                doc.Add(Chunk.NEWLINE);
                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);


                PdfPTable tabladata = new PdfPTable(dgvEnvios.Columns.Count);

                for (int j = 0; j < dgvEnvios.Columns.Count; j++)
                {


                    tabladata.AddCell(new Phrase(dgvEnvios.Columns[j].HeaderText));
                }

                tabladata.HeaderRows = 1;


                for (int i = 0; i < dgvEnvios.Rows.Count; i++)
                {

                    for (int k = 0; k < dgvEnvios.Columns.Count; k++)
                    {
                        if (dgvEnvios[k, i].Value != null)
                        {

                            tabladata.AddCell(new Phrase(dgvEnvios[k, i].Value.ToString()));

                        }
                    }
                }

                doc.Add(tabladata);
                doc.Close();
                MessageBox.Show("Se ha creado el pdf");
            }

            catch
            {

                MessageBox.Show("Error al exportar");
            }
        }
    }
}
