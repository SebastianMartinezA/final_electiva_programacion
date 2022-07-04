using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class InfraccionLeve : Infraccion
    {
        private static int Descuento20Dias;
        private static int Descuento10Dias;

        public InfraccionLeve(int id, string descripcion, double importe, string tipo) : base(id, descripcion, importe, tipo)
        {

        }

        private static int GetDescuento20Dias()
        {
            return Descuento20Dias;
        }

        public static void SetDescuento20Dias(int desc)
        {
            Descuento20Dias = desc;
        }

        private static int GetDescuento10Dias()
        {
            return Descuento10Dias;
        }

        public static void SetDescuento10Dias(int desc)
        {
            Descuento10Dias = desc;
        }

        // Las infracciones leves tienen un 25 % de descuento si se pagan 20 días antes de su vencimiento y un 15% si se pagan 10 días antes.
        public override double calcularImporte(DateTime suceso)
        {
            DateTime vencimiento = suceso.AddDays(30);
            TimeSpan ts = vencimiento.Subtract(DateTime.Now);
            int dias = Convert.ToInt32(ts.TotalDays);

            double monto = this.Importe;

            if (dias >= 20)
            {
                monto = monto * (100 - GetDescuento20Dias()) / 100;
            }

            if (dias >= 10)
            {
                monto = monto * (100 - GetDescuento10Dias()) / 100;
            }

            return monto;
        }
    }
}
