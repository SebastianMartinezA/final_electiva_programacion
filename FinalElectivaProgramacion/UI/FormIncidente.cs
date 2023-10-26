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
            this.comboBoxInfraccion.SelectedIndex = 0;
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

            Vehiculo vehi;

            bool found = vehiculos.Any(v => v.Patente == patente);
            if (!found)
            {
                vehi = new Vehiculo(patente);
                vehiculos.Add(vehi);
            } else
            {
                vehi = vehiculos.First(v => v.Patente == patente);
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
            this.buttonConf.Enabled = false;
        }

        public void prepararMostrar()
        {
            this.buttonConf.Visible = false;
            this.buttonCancel.Visible = true;
            this.dateTimePickerIncidente.Enabled = false;
            this.comboBoxInfraccion.Enabled = false;
            this.textBoxPatente.Enabled = false;
        }

        private void textBoxPatente_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxPatente, String.Empty);
        }

        private void textBoxPatente_Validating(object sender, CancelEventArgs e)
        {
            string patente = textBoxPatente.Text;

            string errorMsg;
            if (!validPatente(patente, out errorMsg))
            {
                e.Cancel = true;
                textBoxPatente.Focus();

                this.errorProvider.SetError(textBoxPatente, errorMsg);
            }
        }

        private bool validPatente(string patente, out string errorMessage)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(patente, "(^[A-Z]{3}[0-9]{3}$)|(^[A-Z]{2}[0-9]{3}[A-Z]{2}$)")) //Patente nueva y vieja
            {
                errorMessage = "";
                return true;
            }

            errorMessage = "Patente erronea. Debe ser formato ABC123 o AB123CD.";
            return false;
        }



        private void checkInputs()
        {
            string a;
            if (validPatente(textBoxPatente.Text, out a))
            {
                buttonConf.Enabled = true;
            }
            else
            {
                buttonConf.Enabled = false;
            }
        }

        private void textBoxPatente_TextChanged(object sender, EventArgs e)
        {
            checkInputs();
        }
    }
}
