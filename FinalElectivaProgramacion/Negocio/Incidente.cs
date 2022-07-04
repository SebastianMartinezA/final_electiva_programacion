using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class Incidente
    {
        private int id;
        private DateTime fecha;
        private Infraccion infraccion;
        private Vehiculo vehiculo;
        private IncidenteDatos incDb;

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Infraccion Infraccion { get => infraccion; set => infraccion = value; }
        public Vehiculo Vehiculo { get => vehiculo; set => vehiculo = value; }

        public Incidente(int id, DateTime fecha, Infraccion infraccion, Vehiculo vehiculo)
        {
            this.incDb = new IncidenteDatos();

            this.id = id;
            this.fecha = fecha;
            this.infraccion = infraccion;
            this.vehiculo = vehiculo;
        }


        public void eliminar()
        {
            vehiculo.removerIncidente(this);
            infraccion.removerIncidente(this);
        }

        public void eliminarDb()
        {
            incDb.eliminar(this.id);
        }

        public int agregarDb(DateTime fecha, int idInfraccion, string patente)
        {
            return incDb.agregar(fecha, idInfraccion, patente);
        }

        // verificarVencimiento retorna false si ya esta vencido y true si aún no.
        public bool verificarVencimiento()
        {
            DateTime vencimiento = this.fecha.AddDays(30);
            TimeSpan ts = vencimiento.Subtract(DateTime.Now);
            int dias = Convert.ToInt32(ts.TotalDays);

            return dias >= 0 && dias <= 30;
        }
    }
}
