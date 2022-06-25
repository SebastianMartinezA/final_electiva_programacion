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
            this.listBoxIncidentes.DataSource = inf.Sucesos;
        }

        private void buttonConf_Click(object sender, EventArgs e)
        {
            string desc = this.textBoxDesc.Text;
            string tipo = this.comboBoxTipo.Text;
            double monto = double.Parse(this.textBoxMonto.Text);

            int id = 0;
            //id = inf.agregarInfraccionDb(desc, monto);

            if (comboBoxTipo.Text == "Grave")
            {
                inf = new InfraccionGrave(id, desc, monto);
            }
            else
            {
                inf = new InfraccionLeve(id, desc, monto);
            }

            this.Close();
        }
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            this.inf.Descripcion = this.textBoxDesc.Text;
            this.inf.Importe = double.Parse(this.textBoxMonto.Text);

            //inf.modificarInfraccionDb();

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
            this.labelSucesos.Visible = false;
        }

        public void prepararModificar()
        {
            this.comboBoxTipo.Enabled = false;
            this.buttonModificar.Visible = true;
            this.buttonConf.Visible = false;
            this.listBoxIncidentes.Visible = false;
            this.labelSucesos.Visible = false;
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
            this.labelSucesos.Visible = true;
            this.Size = new Size(700, 461);
            this.buttonCancel.Text = "Cerrar";
        }

        private void listBoxIncidentes_Format(object sender, ListControlConvertEventArgs e)
        {
            string desc = ((Suceso)e.ListItem).Infraccion.Descripcion;
            string fecha = ((Suceso)e.ListItem).Fecha.ToString("dd/MM/yy HH:mm");
            string patente = ((Suceso)e.ListItem).Vehiculo.Patente;

            e.Value = fecha + " | Patente: " + patente;
        }
    }
}
