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

        public InfraccionLeve(int id, string descripcion, double importe) : base(id, descripcion, importe)
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
    }
}
