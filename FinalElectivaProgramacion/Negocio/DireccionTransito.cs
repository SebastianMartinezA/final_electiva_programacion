using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class DireccionTransito
    {
        private List<Infraccion> infracciones;
        private List<Incidente> incidentes;
        private List<Pago> pagos;
        private List<Vehiculo> vehiculos;

        public List<Infraccion> Infracciones { get => infracciones; set => infracciones = value; }
        public List<Incidente> Incidentes { get => incidentes; set => incidentes = value; }
        public List<Pago> Pagos { get => pagos; set => pagos = value; }
        public List<Vehiculo> Vehiculos { get => vehiculos; set => vehiculos = value; }

        public DireccionTransito()
        {
            setListsData();
        }

        private void setListsData()
        {
            infracciones = new List<Infraccion>();
            incidentes = new List<Incidente>();
            pagos = new List<Pago>();
            vehiculos = new List<Vehiculo>();
        }

        public void agregarInfraccion(Infraccion inf)
        {
            this.infracciones.Add(inf);
        }

        public void removerInfraccion(Infraccion inf)
        {
            this.infracciones.Remove(inf);
            foreach (var a in Incidentes.ToList()) // Pensar, removemos los incidentes/incidentes si borramos la infraccion?
            {
                if (a.Infraccion == inf)
                {
                    Incidentes.Remove(a);
                }
            }
        }

        public void agregarIncidente(Incidente inc)
        {
            this.Incidentes.Add(inc);
        }

        public void removerIncidente(Incidente inc)
        {
            this.Incidentes.Remove(inc);
        }

        public void agregarVehiculo(Vehiculo v)
        {
            this.vehiculos.Add(v);
        }
    }
}
