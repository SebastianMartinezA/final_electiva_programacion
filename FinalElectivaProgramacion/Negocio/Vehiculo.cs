using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Vehiculo
    {
        private string patente;
        List<Suceso> sucesos;
        List<Pago> pagos;

        public Vehiculo(string patente, List<Suceso> sucesos, List<Pago> pagos)
        {
            this.patente = patente;
            this.sucesos = sucesos;
            this.pagos = pagos;
        }

        public string Patente { get => patente; set => patente = value; }
        public List<Suceso> Sucesos { get => sucesos; set => sucesos = value; }
        public List<Pago> Pagos { get => pagos; }
    }
}
