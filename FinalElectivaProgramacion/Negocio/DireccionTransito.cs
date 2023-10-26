using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace Negocio
{
    public class DireccionTransito
    {
        private List<Infraccion> infracciones;
        private List<Incidente> incidentes;
        private List<Pago> pagos;
        private List<Vehiculo> vehiculos;

        InfraccionDatos infDb;
        IncidenteDatos incDb;
        PagoDatos pagoDB;

        public List<Infraccion> Infracciones { get => infracciones; set => infracciones = value; }
        public List<Incidente> Incidentes { get => incidentes; set => incidentes = value; }
        public List<Pago> Pagos { get => pagos; set => pagos = value; }
        public List<Vehiculo> Vehiculos { get => vehiculos; set => vehiculos = value; }

        public DireccionTransito()
        {
            infDb = new InfraccionDatos();
            incDb = new IncidenteDatos();
            pagoDB = new PagoDatos();

            setListsData();
            vincular();
        }

        private void setListsData()
        {
            vehiculos = new List<Vehiculo>();
            infracciones = new List<Infraccion>(
                from dRow in infDb.mostrarInfracciones().Tables[0].AsEnumerable()
                select (getInfraccionData(dRow))
                     );
            incidentes = new List<Incidente>(
                from dRow in incDb.mostrarIncidentes().Tables[0].AsEnumerable()
                select (getIncidenteData(dRow))
                );

            pagos = new List<Pago>(
                from dRow in pagoDB.mostrarPagos().Tables[0].AsEnumerable()
                select (getPagoData(dRow))
                );
        }

        private void vincular()
        {
            // Vinculamos los incidentes a sus infracciones y vehiculos.
            foreach (var inc in incidentes)
            {
                inc.Infraccion.agregarIncidente(inc);
                inc.Vehiculo.agregarIncidente(inc);
            }

            // Vinculamos los pagos a sus vehiculos.
            foreach (var pago in pagos)
            {
                pago.Incidente.Vehiculo.agregarPago(pago);
            }
        }

        public void agregarInfraccion(Infraccion inf)
        {
            this.infracciones.Add(inf);
        }

        public void removerInfraccion(Infraccion inf)
        {
            this.infracciones.Remove(inf);

            // Removemos los incidentes vinculados a esa infraccion.
            foreach (var a in incidentes.Where(i => i.Infraccion == inf).ToArray())
            {
                incidentes.Remove(a);
                a.eliminar();
            }
        }

        private Infraccion getInfraccionData(DataRow dr) // Obtiene de la tabla los datos y crea un objeto.
        {
            Infraccion inf;
            var tipo = (string)dr["Tipo"];

            if (tipo == "LEVE")
            {
                inf = new InfraccionLeve((int)dr["ID"], (string)dr["Descripcion"], (double)dr["Importe"], tipo);
            }
            else
            {
                inf = new InfraccionGrave((int)dr["ID"], (string)dr["Descripcion"], (double)dr["Importe"], tipo);
            }

            return inf;
        }

        private Incidente getIncidenteData(DataRow dr) // Obtiene de la tabla los datos y crea un objeto.
        {
            var patente = (string)dr["Patente"];
            if (vehiculos.FirstOrDefault(v => v.Patente == patente) == null)
            {
                Vehiculo v = new Vehiculo((string)dr["Patente"]);
                vehiculos.Add(v);
            }

            Incidente inc = new Incidente((int)dr["ID"], (DateTime)dr["Fecha"], infracciones.First(i => i.Id == ((int)dr["idInfraccion"])),
                vehiculos.First(v => v.Patente == patente));

            return inc;
        }

        private Pago getPagoData(DataRow dr)
        {
            Pago pago = new Pago((int)dr["ID"], (DateTime)dr["Fecha"], incidentes.First(i => i.Id == ((int)dr["idIncidente"])), (double)dr["Monto"]);

            return pago;
        }

        public void agregarIncidente(Incidente inc)
        {
            this.Incidentes.Add(inc);
        }

        public void removerIncidente(Incidente inc)
        {
            this.Incidentes.Remove(inc);
        }

        public void agregarVehiculo(Vehiculo v)
        {
            this.vehiculos.Add(v);
        }

        public void agregarPago(Incidente inc, double monto)
        {
            Pago pago = new Pago(0, DateTime.Now, inc, monto);
            pago.Id = pago.agregarDb(pago.Fecha, pago.Incidente.Id, pago.Monto);
            pago.Incidente.Vehiculo.agregarPago(pago);
            pagos.Add(pago);
        }

        public bool tienePagoVinculado(Infraccion inf)
        {
            var incidentes = inf.Incidentes.Select(i => i.Id);
            return this.pagos.Any(p => incidentes.Contains(p.Incidente.Id));
        }

        public bool tienePagoVinculado(Incidente inc)
        {
            return this.pagos.Any(p => p.Incidente.Id == inc.Id);
        }

        public void generatePDF(int codPago, double monto)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            PdfDocument doc = new PdfDocument();

            PdfPage page = doc.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont font = new XFont("Arial", 20);

            gfx.DrawString("Cupón de pago - " + codPago, font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);

            gfx.DrawString("Monto: " + monto, font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);

            doc.Save("test");
        }
    }
}
