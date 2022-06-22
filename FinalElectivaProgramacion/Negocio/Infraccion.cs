﻿namespace Negocio
{
    public abstract class Infraccion
    {
        private int id;
        private string descripcion;
        private double importe;
        List<Suceso> sucesos;

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Importe { get => importe; set => importe = value; }
        public List<Suceso> Sucesos { get => sucesos; }

        public Infraccion(int id, string descripcion, double importe)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.importe = importe;
            this.sucesos = new List<Suceso>();
        }

        public virtual bool isGrave()
        {
            return false;
        }
    }
}