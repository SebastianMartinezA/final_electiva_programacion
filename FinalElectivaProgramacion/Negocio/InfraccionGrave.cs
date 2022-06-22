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

        public InfraccionGrave(int id, string descripcion, double importe) : base(id, descripcion, importe)
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
    }
}
