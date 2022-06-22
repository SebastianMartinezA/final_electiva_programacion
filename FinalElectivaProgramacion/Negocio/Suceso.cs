using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Suceso
    {
        private int id;
        private DateTime fecha;
        private Infraccion infraccion;
        private Vehiculo vehiculo;

        public Suceso(int id, DateTime fecha, Infraccion infraccion, Vehiculo vehiculo)
        {
            this.id = id;
            this.fecha = fecha;
            this.infraccion = infraccion;
            this.vehiculo = vehiculo;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Infraccion Infraccion { get => infraccion; set => infraccion = value; }
        public Vehiculo Vehiculo { get => vehiculo; set => vehiculo = value; }
    }
}
