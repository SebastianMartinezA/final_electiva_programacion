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
        private Incidente incidente;
        private double monto;

        public Pago(int id, DateTime fecha, Incidente incidente, double monto)
        {
            this.id = id;
            this.fecha = fecha;
            this.incidente = incidente;
            this.monto = monto;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Incidente Incidente { get => incidente; set => incidente = value; }
        public double Monto { get => monto; set => monto = value; }
    }
}
