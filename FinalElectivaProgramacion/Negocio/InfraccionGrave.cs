using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class InfraccionGrave : Infraccion
    {
        private static int Descuento25Dias;

        public InfraccionGrave(int id, string descripcion, double importe, string tipo) : base(id, descripcion, importe, tipo)
        {

        }

        private static int GetDescuento25Dias()
        {
            return Descuento25Dias;
        }

        public static void SetDescuento25Dias(int desc)
        {
            Descuento25Dias = desc;
        }

        public override bool isGrave()
        {
            return true;
        }

        // Las infracciones graves sólo tienen un 20% de descuento si se pagan 25 días antes de su vencimiento.
        public override double calcularImporte(DateTime suceso)
        {
            DateTime vencimiento = suceso.AddDays(30);
            TimeSpan ts = vencimiento.Subtract(DateTime.Now);
            int dias = Convert.ToInt32(ts.TotalDays);

            double monto = this.Importe;
            if (dias >= 25)
            {
                monto = monto * (100 - GetDescuento25Dias()) / 100;
            }

            return monto;
        }
    }
}
