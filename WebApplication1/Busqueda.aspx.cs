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
            LabelImpagos.Visible = false;
            ListBoxIncidentes.Visible = false;
            LabelPagos.Visible = false;
            ListBoxIncidentesPagos.Visible = false;
            ButtonMostrarImpago.Visible = false;
            ButtonMostrarPagado.Visible = false;
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            DireccionTransito dt = (DireccionTransito)Session["dt"];
            string patente = TextBoxPatente.Text;

            if (patente != null && dt != null)
            {
                bool found = dt.Vehiculos.Any(v => v.Patente == patente);
                if (found)
                {
                    Vehiculo vehi = dt.Vehiculos.First(v => v.Patente == patente);
                    Session["Vehiculo"] = vehi;
                    ListBoxIncidentes.DataSource = vehi.Incidentes.Where(i => !i.tienePagoVinculado() && i.Fecha.AddDays(30) >= DateTime.Today).OrderByDescending(i => i.Fecha).ToList();
                    ListBoxIncidentes.DataBind();
                    ListBoxIncidentes.SelectedIndex = -1;
                    ListBoxIncidentes.Visible = true;
                    LabelImpagos.Visible = true;
                    ListBoxIncidentesPagos.DataSource = vehi.Pagos.Select(p => p.Incidente).OrderByDescending(i => i.Fecha);
                    ListBoxIncidentesPagos.DataBind();
                    ListBoxIncidentesPagos.SelectedIndex = -1;
                    ListBoxIncidentesPagos.Visible = true;
                    LabelPagos.Visible = true;

                    ButtonMostrarImpago.Visible = true;
                    ButtonMostrarPagado.Visible = true;
                }
            }
        }

        protected void ButtonMostrarImpago_Click(object sender, EventArgs e)
        {
            if (ListBoxIncidentes.SelectedIndex > -1)
            {
                List<Incidente> incidentesImpagos = ((Vehiculo)Session["Vehiculo"]).Incidentes.Where(i => !i.tienePagoVinculado() && i.Fecha.AddDays(30) >= DateTime.Today).OrderByDescending(i => i.Fecha).ToList();

                Session["Type"] = "impago";
                Session["Incidente"] = incidentesImpagos[ListBoxIncidentes.SelectedIndex];
                string url = "https://localhost:44394/Mostrar";
                string script = string.Format("window.open('{0}');", url);

                Page.ClientScript.RegisterStartupScript(this.GetType(),
                    "newPage" + UniqueID, script, true);
            }

            ListBoxIncidentes.SelectedIndex = -1;
        }

        protected void ButtonMostrarPagado_Click(object sender, EventArgs e)
        {
            if (ListBoxIncidentesPagos.SelectedIndex > -1)
            {
                List<Pago> incidentesPagos = ((Vehiculo)Session["Vehiculo"]).Pagos.OrderByDescending(p => p.Incidente.Fecha).ToList();
                Pago pago = incidentesPagos[ListBoxIncidentesPagos.SelectedIndex];

                Session["Type"] = "pago";
                Session["IncidentePago"] = pago.Incidente;
                Session["Monto"] = pago.Monto;

                string url = "https://localhost:44394/Mostrar";
                string script = string.Format("window.open('{0}');", url);

                Page.ClientScript.RegisterStartupScript(this.GetType(),
                    "newPage" + UniqueID, script, true);
            }

            ListBoxIncidentesPagos.SelectedIndex = -1;
        }
    }
}