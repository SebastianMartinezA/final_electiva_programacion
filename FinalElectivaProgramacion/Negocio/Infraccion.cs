using Datos;

namespace Negocio
{
    public abstract class Infraccion
    {
        private int id;
        private string descripcion;
        private double importe;
        private InfraccionDatos infDb;
        List<Suceso> sucesos;

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Importe { get => importe; set => importe = value; }
        public List<Suceso> Sucesos { get => sucesos; }

        public Infraccion(int id, string descripcion, double importe)
        {
            this.infDb = new InfraccionDatos();

            this.id = id;
            this.descripcion = descripcion;
            this.importe = importe;
            this.sucesos = new List<Suceso>();
        }

        public virtual bool isGrave()
        {
            return false;
        }

        public int agregarInfraccionDb(string desc, double monto)
        {
            return infDb.agregar(desc, monto);
        }

        public int modificarInfraccionDb()
        {
            return infDb.modificar(this.Id, this.Descripcion, this.Importe);
        }

        public void eliminarInfraccionDb()
        {
            infDb.eliminar(this.Id);
        }

        public void agregarSuceso(Suceso suc)
        {
            this.sucesos.Add(suc);
        }
    }
}