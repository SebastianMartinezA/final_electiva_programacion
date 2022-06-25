using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Negocio;

namespace Negocio
{
    public class Vehiculo
    {
        private string patente;
        List<Suceso> sucesos;
        List<Pago> pagos;

        public Vehiculo(string patente)
        {
            this.patente = patente;
            this.sucesos = new List<Suceso>();
            this.pagos = new List<Pago>();
        }

        public string Patente { get => patente; set => patente = value; }
        public List<Suceso> Sucesos { get => sucesos; set => sucesos = value; }
        public List<Pago> Pagos { get => pagos; }

        public void agregarSuceso(Suceso inc)
        {
            this.sucesos.Add(inc);
        }

        public void agregarPago(Pago pago)
        {
            this.pagos.Add(pago);
        }

        public void removerSuceso(Suceso inc)
        {
            this.sucesos.Remove(inc);
        }
    }
}
