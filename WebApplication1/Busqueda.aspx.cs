using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Negocio;

namespace WebApplication1
{
    public partial class Busqueda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DireccionTransito dt = (DireccionTransito)Session["dt"];
            ButtonSiguiente.Enabled = true;
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            DireccionTransito dt = (DireccionTransito)Session["dt"];
            string patente = TextBoxPatente.Text;

            if (patente != null)
            {
                bool found = dt.Vehiculos.Any(v => v.Patente == patente);
                if (found)
                {
                    Vehiculo vehi = dt.Vehiculos.First(v => v.Patente == patente);
                    Session["vehi"] = vehi;
                    ListBoxIncidentes.DataSource = vehi.Incidentes.OrderByDescending(i => i.Fecha);
                    ListBoxIncidentes.DataBind();
                    ListBoxIncidentes.SelectedIndex = -1;
                }
            }
        }

        protected void ListBoxIncidentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonSiguiente.Enabled = true;
        }

        protected void ButtonSiguiente_Click(object sender, EventArgs e)
        {
            List<Incidente> incidentes = ((Vehiculo)Session["vehi"]).Incidentes.OrderByDescending(i => i.Fecha).ToList();

            Session["Incidente"] = incidentes[ListBoxIncidentes.SelectedIndex];

            string url = "https://localhost:44394//Mostrar";
            string script = string.Format("window.open('{0}');", url);

            Page.ClientScript.RegisterStartupScript(this.GetType(),
                "newPage" + UniqueID, script, true);
        }
    }
}