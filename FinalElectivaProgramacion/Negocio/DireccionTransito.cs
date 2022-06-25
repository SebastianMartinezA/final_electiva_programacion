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
        private List<Suceso> sucesos;
        private List<Pago> pagos;
        private List<Vehiculo> vehiculos;

        public List<Infraccion> Infracciones { get => infracciones; set => infracciones = value; }
        public List<Suceso> Sucesos { get => sucesos; set => sucesos = value; }
        public List<Pago> Pagos { get => pagos; set => pagos = value; }
        public List<Vehiculo> Vehiculos { get => vehiculos; set => vehiculos = value; }

        public DireccionTransito()
        {
            setListsData();
        }

        private void setListsData()
        {
            infracciones = new List<Infraccion>();
            sucesos = new List<Suceso>();
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
            foreach (var a in Sucesos.ToList()) // Pensar, removemos los incidentes/sucesos si borramos la infraccion?
            {
                if (a.Infraccion == inf)
                {
                    Sucesos.Remove(a);
                }
            }
        }

        public void agregarSuceso(Suceso inc)
        {
            this.Sucesos.Add(inc);
        }

        public void removerSuceso(Suceso inc)
        {
            this.Sucesos.Remove(inc);
        }

        public void agregarVehiculo(Vehiculo v)
        {
            this.vehiculos.Add(v);
        }
    }
}
