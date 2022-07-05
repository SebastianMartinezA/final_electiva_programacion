using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Negocio;
using PdfSharp.Drawing;
using PdfSharp.Drawing.BarCodes;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Incidente inc = (Incidente)Session["Incidente"];
            if (inc == null)
            {
                loadEmpty();
            }
            else
            {
                loadIncidente(inc);
            }
        }

        private void loadEmpty()
        {
            LabelDescripcion.Text = "Patente no encontrada";
            LabelMonto.Visible = false;
            LabelFecha.Visible = false;
            LabelPatente.Visible = false;
        }

        private void loadIncidente(Incidente inc)
        {
            LabelPatente.Text = inc.Vehiculo.Patente;
            LabelFecha.Text = inc.Fecha.ToShortTimeString();
            LabelDescripcion.Text = inc.Infraccion.Descripcion;
            ButtonPagar.Visible = true;
            LabelMonto.Text = "$ " + inc.Infraccion.calcularImporte(inc.Fecha);
        }

        protected void ButtonPagar_Click(object sender, EventArgs e)
        {
            DireccionTransito dt = (DireccionTransito)Session["dt"];
            Incidente inc = (Incidente)Session["Incidente"];
            double monto = inc.Infraccion.calcularImporte(inc.Fecha);

            DateTime creationDate = DateTime.Now;
            string name = inc.Id + creationDate.ToString("ddMMyyyyHHmm");

            PdfDocument doc = new PdfDocument();
            doc.Options.ColorMode = PdfColorMode.Undefined;
            doc.Info.Title = "Orden de pago - " + name;

            if (name.Length % 2 != 0)
            {
                name = "0" + name;
            }

            doc.Info.CreationDate = creationDate;

            PdfPage page = doc.AddPage();
            page.Width = XUnit.FromMillimeter(210);
            page.Height = XUnit.FromMillimeter(297);

            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Arial", 20);

            gfx.DrawString("Orden de pago - " + name, font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.TopCenter);
            gfx.DrawString("Monto: $" + monto, font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.BottomCenter);

            BarCode BarCode39 = new Code2of5Interleaved(name); 
            BarCode39.TextLocation = new PdfSharp.Drawing.BarCodes.TextLocation();
            BarCode39.TextLocation = TextLocation.BelowEmbedded;
            BarCode39.StartChar = Convert.ToChar("*");
            BarCode39.EndChar = Convert.ToChar("*");
            BarCode39.Direction = PdfSharp.Drawing.BarCodes.CodeDirection.LeftToRight;
            XFont fontBARCODE = new XFont("Arial", 14, XFontStyle.Regular);
            XSize BARCODE_SIZE = new XSize(Convert.ToDouble(297), Convert.ToDouble(66));
            BarCode39.Size = BARCODE_SIZE;
            gfx.DrawBarCode(BarCode39, XBrushes.Black, fontBARCODE, new XPoint(Convert.ToDouble(150), Convert.ToDouble(495)));

            // Define a rotation transformation at the center of the page
            gfx.TranslateTransform(page.Width / 2, page.Height / 4);
            gfx.RotateTransform(-Math.Atan(page.Height / page.Width) * 180 / Math.PI);
            gfx.TranslateTransform(-page.Width / 2, -page.Height / 2);



            MemoryStream stream = new MemoryStream();
            doc.Save(stream, false);
            Response.Clear();
            Response.ContentType = "application/pdf";
            //Response.AddHeader("content-length", stream.Length.ToString());
            Response.AddHeader("content-disposition", "attachment;filename=cupon-" + name + ".pdf");
            Response.BinaryWrite(stream.ToArray());
            Response.Flush();
            stream.Close();
            Response.End();
        }

        private void generarPDF()
        {

        }
    }
}