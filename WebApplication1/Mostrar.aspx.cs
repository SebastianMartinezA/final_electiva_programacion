using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Negocio;

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
            if (inc.Infraccion.isGrave())
            {
                InfraccionGrave ig = (InfraccionGrave)inc.Infraccion;
                LabelMonto.Text = "$ " + ig.calcularImporte(inc.Fecha);
            }
            else
            {
                InfraccionLeve ig = (InfraccionLeve)inc.Infraccion;
                LabelMonto.Text = "$ " + ig.calcularImporte(inc.Fecha);
            }

        }

        protected void ButtonPagar_Click(object sender, EventArgs e)
        {

        }
    }
}