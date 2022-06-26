using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocio;

namespace UI
{
    public partial class FormIncidente : Form
    {
        private Incidente inc;
        List<Vehiculo> vehiculos;

        public Incidente Inc { get => inc; set => inc = value; }

        public FormIncidente(List<Infraccion> infracciones, List<Vehiculo> vehiculos)
        {
            InitializeComponent();
            this.comboBoxInfraccion.DataSource = infracciones;
            this.vehiculos = vehiculos;

        }
        private void buttonConf_Click(object sender, EventArgs e)
        {
            DateTime fecha = this.dateTimePickerIncidente.Value;
            Infraccion inf = (Infraccion)this.comboBoxInfraccion.SelectedItem;
            string patente = textBoxPatente.Text;

            Vehiculo vehi;
            try
            {
                vehi = vehiculos.First(o => o.Patente == "patente");
            }
            catch
            {
                vehi = new Vehiculo(patente);
            }

            int id = 0;
            //id = inf.agregarInfraccionDb(desc, monto);

            inc = new Incidente(id, fecha, inf, vehi);
            vehi.agregarIncidente(inc);
            inf.agregarIncidente(inc);

            this.Close();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxInfraccion_Format(object sender, ListControlConvertEventArgs e)
        {
            string desc = ((Infraccion)e.ListItem).Descripcion;

            e.Value = "Infraccion: " + desc;
        }
    }
}
