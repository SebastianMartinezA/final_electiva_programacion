using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Pago
    {
        private int id;
        private DateTime fecha;
        private Suceso suceso;
        private double monto;

        public Pago(int id, DateTime fecha, Suceso suceso, double monto)
        {
            this.id = id;
            this.fecha = fecha;
            this.suceso = suceso;
            this.monto = monto;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Suceso Suceso { get => suceso; set => suceso = value; }
        public double Monto { get => monto; set => monto = value; }
    }
}
