using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public abstract class Infraccion
    {
        private int id;
        private string descripcion;
        private double importe;
        private string tipo;
        List<Incidente> incidentes;
        private InfraccionDatos infDb;

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Importe { get => importe; set => importe = value; }
        public List<Incidente> Incidentes { get => incidentes; }

        public Infraccion(int id, string descripcion, double importe, string tipo)
        {
            this.infDb = new InfraccionDatos();

            this.id = id;
            this.descripcion = descripcion;
            this.importe = importe;
            this.tipo = tipo;
            this.incidentes = new List<Incidente>();
        }

        public abstract double calcularImporte(DateTime suceso);

        public virtual bool isGrave()
        {
            return false;
        }

        public int agregarInfraccionDb(string desc, double monto, string tipo)
        {
            return infDb.agregar(desc, monto, tipo);
        }

        public int modificarInfraccionDb()
        {
            return infDb.modificar(this.Id, this.Descripcion, this.Importe);
        }
        public void eliminarInfraccionDb()
        {
            foreach (var inc in incidentes)
            {
                inc.eliminarDb();
            }

            infDb.eliminar(this.Id);
        }

        public void agregarIncidente(Incidente suc)
        {
            this.incidentes.Add(suc);
        }

        public void removerIncidente(Incidente suc)
        {
            this.incidentes.Remove(suc);
        }
    }
}
