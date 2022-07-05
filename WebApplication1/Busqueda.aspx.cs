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
            ListBoxIncidentes.Visible = false;
            ButtonMostrar.Visible = false;
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
                    Session["Vehiculo"] = vehi;
                    ListBoxIncidentes.DataSource = vehi.Incidentes.Where(i => i.Fecha.AddDays(30) >= DateTime.Today).OrderByDescending(i => i.Fecha);
                    ListBoxIncidentes.DataBind();
                    ListBoxIncidentes.SelectedIndex = -1;
                    ListBoxIncidentes.Visible = true;
                    ButtonMostrar.Visible = true;
                }
            }
        }

        protected void ListBoxIncidentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonMostrar.Enabled = true;
        }

        protected void ButtonMostrar_Click(object sender, EventArgs e)
        {
            List<Incidente> incidentes = ((Vehiculo)Session["Vehiculo"]).Incidentes.Where(i => i.Fecha.AddDays(30) >= DateTime.Today).OrderByDescending(i => i.Fecha).ToList();

            if (ListBoxIncidentes.SelectedIndex > -1)
            {
                Session["Incidente"] = incidentes[ListBoxIncidentes.SelectedIndex];
                string url = "https://localhost:44394/Mostrar";
                string script = string.Format("window.open('{0}');", url);

                Page.ClientScript.RegisterStartupScript(this.GetType(),
                    "newPage" + UniqueID, script, true);
            }

            ListBoxIncidentes.ClearSelection();
        }
    }
}