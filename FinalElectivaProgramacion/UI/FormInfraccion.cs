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
    public partial class FormInfraccion : Form
    {
        private Infraccion inf;

        public Infraccion Inf { get => inf; set => inf = value; }

        public FormInfraccion()
        {
            InitializeComponent();
        }

        public FormInfraccion(Infraccion a)
        {
            InitializeComponent();
            this.inf = a;
            this.comboBoxTipo.SelectedIndex = comboBoxTipo.FindString(inf.isGrave() ? "Grave" : "Leve");
            this.textBoxDesc.Text = inf.Descripcion;
            this.textBoxMonto.Text = inf.Importe.ToString();
            this.listBoxIncidentes.DataSource = inf.Incidentes;
        }

        private void buttonConf_Click(object sender, EventArgs e)
        {
            string desc = this.textBoxDesc.Text;
            string tipo = this.comboBoxTipo.Text;
            double monto = double.Parse(this.textBoxMonto.Text);

            if (tipo == "Grave")
            {
                inf = new InfraccionGrave(0, desc, monto, tipo);
            }
            else
            {
                inf = new InfraccionLeve(0, desc, monto, tipo);
            }

            inf.Id = inf.agregarInfraccionDb(desc, monto, tipo);

            this.Close();
        }
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            this.inf.Descripcion = this.textBoxDesc.Text;
            this.inf.Importe = double.Parse(this.textBoxMonto.Text);

            inf.modificarInfraccionDb();

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void prepararCrear()
        {
            this.comboBoxTipo.Enabled = true;
            this.buttonModificar.Visible = false;
            this.buttonConf.Visible = true;
            this.listBoxIncidentes.Visible = false;
            this.labelIncidentes.Visible = false;
        }

        public void prepararModificar()
        {
            this.comboBoxTipo.Enabled = false;
            this.buttonModificar.Visible = true;
            this.buttonConf.Visible = false;
            this.listBoxIncidentes.Visible = false;
            this.labelIncidentes.Visible = false;
        }

        public void prepararMostrar()
        {
            this.buttonCancel.Visible = true;
            this.buttonModificar.Visible = false;
            this.buttonConf.Visible = false;
            this.comboBoxTipo.Enabled = false;
            this.textBoxDesc.Enabled = false;
            this.textBoxMonto.Enabled = false;
            this.listBoxIncidentes.Visible = true;
            this.labelIncidentes.Visible = true;
            this.Size = new Size(700, 461);
            this.buttonCancel.Text = "Cerrar";
        }

        private void listBoxIncidentes_Format(object sender, ListControlConvertEventArgs e)
        {
            string desc = ((Incidente)e.ListItem).Infraccion.Descripcion;
            string fecha = ((Incidente)e.ListItem).Fecha.ToString("dd/MM/yy HH:mm");
            string patente = ((Incidente)e.ListItem).Vehiculo.Patente;

            e.Value = fecha + " | Patente: " + patente;
        }
    }
}
