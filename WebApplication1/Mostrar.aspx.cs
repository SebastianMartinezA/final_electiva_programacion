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
            string type = ((string)Session["Type"]);
            if (type == null)
            {
                loadEmpty();
            }
            else
            {
                switch (type)
                {
                    case "impago":
                        loadIncidenteImpago();
                        break;
                    case "pago":
                        loadIncidentePago();
                        break;
                }
            }
        }

        private void loadEmpty()
        {
            LabelDescripcion.Text = "Patente no encontrada";
            LabelMonto.Visible = false;
            LabelFecha.Visible = false;
            LabelPatente.Visible = false;
            ButtonPagar.Visible = false;
        }

        private void loadIncidenteImpago()
        {
            Page.Title = "Infracción Impaga";
            Incidente inc = (Incidente)Session["Incidente"];

            LabelPatente.Text = inc.Vehiculo.Patente;
            LabelFecha.Text = "Fecha del incidente: " + inc.Fecha.ToString("dd/MM/yyyy");
            LabelDescripcion.Text = "Descripción: " + inc.Infraccion.Descripcion;
            LabelMonto.Text = "Monto: $ " + inc.Infraccion.calcularImporte(inc.Fecha);
            ButtonPagar.Visible = true;
        }

        private void loadIncidentePago()
        {
            Page.Title = "Infracción Paga";
            Incidente inc = (Incidente)Session["IncidentePago"];

            LabelPatente.Text = inc.Vehiculo.Patente;
            LabelFecha.Text = "Fecha del incidente: " + inc.Fecha.ToString("dd/MM/yyyy");
            LabelDescripcion.Text = "Descripción: " + inc.Infraccion.Descripcion;
            LabelMonto.Text = "Monto: $ " + (double)Session["Monto"];
            ButtonPagar.Visible = false;
        }

        protected void ButtonPagar_Click(object sender, EventArgs e)
        {
            DireccionTransito dt = (DireccionTransito)Session["dt"];
            Incidente inc = (Incidente)Session["Incidente"];
            double monto = inc.Infraccion.calcularImporte(inc.Fecha);

            DateTime creationDate = DateTime.Now;
            string name = inc.Id + creationDate.ToString("ddMMyyyyHHmm");
            name = transformToBarCode(name);

            PdfDocument doc = new PdfDocument();
            doc.Options.ColorMode = PdfColorMode.Undefined;
            doc.Info.Title = "Orden de pago - " + name;
            doc.Info.Author = "Dirección de Tránsito";
            doc.Info.CreationDate = creationDate;

            PdfPage page = doc.AddPage();
            page.Width = XUnit.FromMillimeter(105);
            page.Height = XUnit.FromMillimeter(148.5);

            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Arial", 16);

            gfx.DrawString("Orden de pago - " + name, font, XBrushes.Black, new XPoint(30, 150));
            gfx.DrawString("Monto: $" + monto, font, XBrushes.Black, new XPoint(30, 175));

            // Codigo de barras
            BarCode bc39 = new Code2of5Interleaved(name);
            bc39.TextLocation = TextLocation.BelowEmbedded;
            bc39.StartChar = Convert.ToChar("*");
            bc39.EndChar = Convert.ToChar("*");
            bc39.Direction = CodeDirection.LeftToRight;
            bc39.Size = new XSize(Convert.ToDouble(255), Convert.ToDouble(60));
            XFont bcFont = new XFont("Arial", 12, XFontStyle.Regular);
            gfx.DrawBarCode(bc39, XBrushes.Black, bcFont, new XPoint(Convert.ToDouble(23), Convert.ToDouble(240)));

            // Transformacion
            gfx.TranslateTransform(page.Width / 4, page.Height / 2);
            gfx.RotateTransform(-Math.Atan(page.Height / page.Width) * 180 / Math.PI);
            gfx.TranslateTransform(-page.Width / 4, -page.Height / 2);

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

        // En esta funcion si es impar le agregamos un 0 adelante, debido al estandard 25 Interleaved.
        private string transformToBarCode(string s)
        {
            if (s.Length % 2 != 0)
            {
                s = "0" + s;
            }

            return s;
        }
    }
}