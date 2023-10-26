using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class Vehiculo
    {
        private string patente;
        List<Incidente> incidentes;
        List<Pago> pagos;

        public Vehiculo(string patente)
        {
            this.patente = patente;
            this.incidentes = new List<Incidente>();
            this.pagos = new List<Pago>();
        }

        public string Patente { get => patente; set => patente = value; }
        public List<Incidente> Incidentes { get => incidentes; set => incidentes = value; }
        public List<Pago> Pagos { get => pagos; }

        public void agregarIncidente(Incidente inc)
        {
            this.incidentes.Add(inc);
        }

        public void agregarPago(Pago pago)
        {
            this.pagos.Add(pago);
        }

        public void removerIncidente(Incidente inc)
        {
            this.incidentes.Remove(inc);
        }
    }
}
