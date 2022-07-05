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
            doc.Info.CreationDate = creationDate;

            PdfPage page = doc.AddPage();
            page.Width = XUnit.FromMillimeter(210);
            page.Height = XUnit.FromMillimeter(297);

            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Arial", 20);

            gfx.DrawString("Orden de pago - " + name, font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.TopCenter);
            gfx.DrawString("Monto: $" + monto, font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.BottomCenter);

            //Code2of5Interleaved bc25 = new Code2of5Interleaved();
            //bc25.Text = name;
            //bc25.Size = new XSize(90, 30);
            //bc25.TextLocation = TextLocation.Above;

            //gfx.DrawBarCode(bc25, XBrushes.DarkBlue, new XPoint(10, 10));

            //bc25.Direction = CodeDirection.RightToLeft;
            //gfx.DrawBarCode(bc25, XBrushes.DarkBlue, new XPoint(30, 10));

            //bc25.Direction = CodeDirection.TopToBottom;
            //gfx.DrawBarCode(bc25, XBrushes.DarkBlue, new XPoint(10, 30));

            //bc25.Direction = CodeDirection.BottomToTop;
            //gfx.DrawBarCode(bc25, XBrushes.Red, new XPoint(30, 30));
            //make sure the font is embedded



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