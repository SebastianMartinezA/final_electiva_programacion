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

        public FormIncidente(Incidente i, List<Infraccion> infracciones)
        {
            InitializeComponent();
            this.inc = i;
            this.comboBoxInfraccion.DataSource = new[] { inc.Infraccion };
            this.textBoxPatente.Text = inc.Vehiculo.Patente;
            this.dateTimePickerIncidente.Value = inc.Fecha;
        }

        private void buttonConf_Click(object sender, EventArgs e)
        {
            DateTime fecha = this.dateTimePickerIncidente.Value;
            Infraccion inf = (Infraccion)this.comboBoxInfraccion.SelectedItem;
            string patente = textBoxPatente.Text;

            Vehiculo? vehi = vehiculos.FirstOrDefault(v => v.Patente == patente);
            if (vehi == null)
            {
                vehi = new Vehiculo(patente);
                vehiculos.Add(vehi);
            }

            inc = new Incidente(0, fecha, inf, vehi);
            inc.Id = inc.agregarDb(fecha, inf.Id, patente);

            vehi.agregarIncidente(inc);
            inf.agregarIncidente(inc);

            this.Close();
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

        public void prepararCrear()
        {
            this.buttonConf.Visible = true;
        }

        public void prepararMostrar()
        {
            this.buttonConf.Visible = false;
            this.buttonCancel.Visible = true;
            this.dateTimePickerIncidente.Enabled = false;
            this.comboBoxInfraccion.Enabled = false;
            this.textBoxPatente.Enabled = false;
        }
    }
}
