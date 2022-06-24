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
        }

        public void agregarInfraccion(Infraccion inf)
        {
            this.infracciones.Add(inf);
        }

        public void removerInfraccion(Infraccion inf)
        {
            this.infracciones.Remove(inf);
        }

        public void agregarIncidente(Incidente inc)
        {
            this.incidentes.Add(inc);
        }

        public void removerIncidente(Incidente inc)
        {
            this.incidentes.Remove(inc);
        }

        public void agregarVehiculo(Vehiculo v)
        {
            this.vehiculos.Add(v);
        }
    }
}
