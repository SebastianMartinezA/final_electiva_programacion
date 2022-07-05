using System;
using System.Collections.Generic;
using System.Drawing;
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

            if (name.Length % 2 != 0)
            {
                name = "0" + name;
            }

            PdfDocument doc = new PdfDocument();
            doc.Options.ColorMode = PdfColorMode.Undefined;
            doc.Info.Title = "Orden de pago - " + name;
            doc.Info.Author = "Dirección de Tránsito";
            doc.Info.CreationDate = creationDate;

            PdfPage page = doc.AddPage();
            page.Size = PdfSharp.PageSize.A4;

            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Arial", 20);

            gfx.DrawString("Orden de pago - " + name, font, XBrushes.Black, new XPoint(143, 350));
            gfx.DrawString("Monto: $" + monto, font, XBrushes.Black, new XPoint(143, 375));

            // Codigo de barras
            BarCode bc39 = new Code2of5Interleaved(name);
            bc39.TextLocation = TextLocation.BelowEmbedded;
            bc39.StartChar = Convert.ToChar("*");
            bc39.EndChar = Convert.ToChar("*");
            bc39.Direction = CodeDirection.LeftToRight;
            bc39.Size = new XSize(Convert.ToDouble(297), Convert.ToDouble(66));
            XFont bcFont = new XFont("Arial", 15, XFontStyle.Regular);
            gfx.DrawBarCode(bc39, XBrushes.Black, bcFont, new XPoint(Convert.ToDouble(150), Convert.ToDouble(495)));

            // Transformacion
            gfx.TranslateTransform(page.Width / 2, page.Height / 4);
            gfx.RotateTransform(-Math.Atan(page.Height / page.Width) * 180 / Math.PI);
            gfx.TranslateTransform(-page.Width / 2, -page.Height / 2);

            MemoryStream stream = new MemoryStream();
            doc.Save(stream, false);
            Response.Clear();
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=orden-" + name + "-pago.pdf");
            Response.BinaryWrite(stream.ToArray());
            Response.Flush();
            stream.Close();
            Response.End();
        }
    }
}