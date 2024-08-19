using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.IO;
using System.Reflection.Metadata;
using System.Windows.Forms;
using System.Xml.Linq;
namespace pdfdeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new PDF document
                PdfDocument document = new PdfDocument();
                document.Info.Title = "Generated PDF Document";

                // Create an empty page
                PdfPage page = document.AddPage();

                // Get an XGraphics object for drawing
                XGraphics gfx = XGraphics.FromPdfPage(page);

                // Create a font
                XFont font = new XFont("Verdana", 20);

                // Draw the header text
                gfx.DrawString("Do�um D�k�man�", font, XBrushes.Black,
                    new XRect(0, 0, page.Width, 50), XStringFormats.Center);

                // Draw the user-entered values
                XFont regularFont = new XFont("Verdana", 18);

                XBrush backgroundColor = XBrushes.LightGray;

                gfx.DrawRectangle(backgroundColor, 75, 85, txttc.TextLength * 10, 30);
                gfx.DrawString($"TC: {txttc.Text}", regularFont, XBrushes.Black,
                    new XRect(40, 90, page.Width - 80, 30), XStringFormats.TopLeft+);

                gfx.DrawRectangle(backgroundColor, 80, 135, txtad.TextLength * 10, 30);
                gfx.DrawString($"Ad�: {txtad.Text}", regularFont, XBrushes.Black,
                    new XRect(40, 140, page.Width - 80, 30), XStringFormats.TopLeft);

                gfx.DrawRectangle(backgroundColor, 80, 185, txtsoyad.TextLength * 10, 30);
                gfx.DrawString($"Soyad�: {txtsoyad.Text}", regularFont, XBrushes.Black,
                    new XRect(40, 190, page.Width - 80, 30), XStringFormats.TopLeft);

                gfx.DrawRectangle(backgroundColor, 80, 235, txttarih.TextLength * 10, 30);
                gfx.DrawString($"Do�um Tarihi: {txttarih.Text}", regularFont, XBrushes.Black,
                    new XRect(40, 240, page.Width - 80, 30), XStringFormats.TopLeft);

                gfx.DrawRectangle(backgroundColor, 80, 285, txtanne.TextLength * 10, 30);
                gfx.DrawString($"Anne Ad�: {txtanne.Text}", regularFont, XBrushes.Black,
                    new XRect(40, 290, page.Width - 80, 30), XStringFormats.TopLeft);

                gfx.DrawRectangle(backgroundColor, 80, 335, txtbaba.TextLength * 10, 30);
                gfx.DrawString($"Baba Ad�: {txtbaba.Text}", regularFont, XBrushes.Black,
                    new XRect(40, 340, page.Width - 80, 30), XStringFormats.TopLeft);
                // Save the document to a file
                //string outputPath = @"C:\Users\bayra\source\repos\pdfdeneme\deneme.pdf";
                string iconPath = @"C:\Users\bayra\OneDrive\Masa�st�\assstes\a.png"; // �konun dosya yolu

                // �konu y�kleyin
                XImage icon = XImage.FromFile(iconPath);

                // �konun boyutunu belirleyin
                double iconWidth = 75;
                double iconHeight = 75;

                // �konu sa� alt k��eye yerle�tirin
                double xPosition = page.Width - iconWidth - 40; // Sa�dan 20 piksel i�eri
                double yPosition = page.Height - iconHeight - 200; // Alttan 20 piksel yukar�

                gfx.DrawImage(icon, xPosition, yPosition, iconWidth, iconHeight);
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // PDF dosyas�n�n kaydedilece�i yolu belirler
                string outputPath = Path.Combine(desktopPath, "deneme.pdf");

                document.Save(outputPath);
                
                if (File.Exists(outputPath))
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = outputPath,
                        UseShellExecute = true // Use the default PDF viewer to open the file
                    });
                }
                else
                {
                    MessageBox.Show("PDF file was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: \n{ex}", "Error", MessageBoxButtons.OK);
            }
        }


    }
}
