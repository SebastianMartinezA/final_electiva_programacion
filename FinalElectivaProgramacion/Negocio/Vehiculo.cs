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
        List<Incidente> sucesos;
        List<Pago> pagos;

        public Vehiculo(string patente, List<Incidente> sucesos, List<Pago> pagos)
        {
            this.patente = patente;
            this.sucesos = sucesos;
            this.pagos = pagos;
        }

        public string Patente { get => patente; set => patente = value; }
        public List<Incidente> Sucesos { get => sucesos; set => sucesos = value; }
        public List<Pago> Pagos { get => pagos; }
    }
}
