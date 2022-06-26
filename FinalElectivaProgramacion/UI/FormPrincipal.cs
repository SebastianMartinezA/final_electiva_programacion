using Negocio;

namespace UI
{
    public partial class FormPrincipal : Form
    {
        private DireccionTransito dt;

        public FormPrincipal()
        {
            InitializeComponent();
            dt = new DireccionTransito();
            listBoxInfraccion.DataSource = dt.Infracciones;
            listBoxInfraccion.ClearSelected();
            listBoxIncidente.DataSource = dt.Incidentes;
            listBoxIncidente.ClearSelected();
        }

        private void buttonCrearInfraccion_Click(object sender, EventArgs e)
        {
            FormInfraccion fi = new FormInfraccion();
            fi.prepararCrear();
            fi.ShowDialog();

            Infraccion inf = fi.Inf;
            if (inf != null)
            {
                dt.agregarInfraccion(inf);
                MessageBox.Show("Infraccion creada satisfactoriamente.");
                listBoxInfraccion.DataSource = null;
                listBoxInfraccion.DataSource = dt.Infracciones;
                listBoxInfraccion.ClearSelected();

            }
        }

        private void buttonModifInfraccion_Click(object sender, EventArgs e)
        {
            Infraccion a = (Infraccion)listBoxInfraccion.SelectedItem;
            if (a == null)
                MessageBox.Show("No hay infraccion seleccionada para modificar.");
            else
            {
                FormInfraccion fi = new FormInfraccion(a);
                fi.prepararModificar();
                fi.ShowDialog();

                listBoxInfraccion.DataSource = null;
                listBoxInfraccion.DataSource = dt.Infracciones;
                listBoxInfraccion.ClearSelected();
            }
        }

        private void buttonElimInfraccion_Click(object sender, EventArgs e)
        {
            Infraccion a = (Infraccion)listBoxInfraccion.SelectedItem;
            if (a == null)
                MessageBox.Show("No hay infraccion seleccionada para eliminar.");
            else
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar la infraccion seleccionada?", "Eliminar infraccion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    a.eliminarInfraccionDb();
                    dt.removerInfraccion(a);
                }
                listBoxInfraccion.DataSource = null;
                listBoxInfraccion.DataSource = dt.Infracciones;
                listBoxInfraccion.ClearSelected();

                listBoxIncidente.DataSource = null;
                listBoxIncidente.DataSource = dt.Incidentes;
                listBoxIncidente.ClearSelected();
            }
        }

        private void buttonMostrarInfraccion_Click(object sender, EventArgs e)
        {
            Infraccion a = (Infraccion)listBoxInfraccion.SelectedItem;
            if (a == null)
                MessageBox.Show("No hay infraccion seleccionada para mostrar.");
            else
            {
                FormInfraccion fi = new FormInfraccion(a);
                fi.prepararMostrar();
                fi.ShowDialog();
            }
        }

        private void buttonCrearIncidente_Click(object sender, EventArgs e)
        {
            if (dt.Infracciones.Count == 0)
            {
                MessageBox.Show("No hay infracciones creadas. Primero debe crear por lo menos una infraccion.");
            }
            else
            {
                FormIncidente fi = new FormIncidente(dt.Infracciones, dt.Vehiculos);
                fi.prepararCrear();
                fi.ShowDialog();

                Incidente inc = fi.Inc;
                if (inc != null)
                {
                    dt.agregarIncidente(inc);
                    MessageBox.Show("Incidente creado satisfactoriamente.");
                    listBoxIncidente.DataSource = null;
                    listBoxIncidente.DataSource = dt.Incidentes;
                    listBoxIncidente.ClearSelected();

                }
            }
        }

        private void buttonElimIncidente_Click(object sender, EventArgs e)
        {
            Incidente a = (Incidente)listBoxIncidente.SelectedItem;
            if (a == null)
                MessageBox.Show("No hay incidente seleccionado para eliminar.");
            else
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar el incidente seleccionado?", "Eliminar incidente", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //a.eliminarIncidenteDb();
                    a.eliminar();
                    dt.removerIncidente(a);
                }

                listBoxIncidente.DataSource = null;
                listBoxIncidente.DataSource = dt.Incidentes;
                listBoxIncidente.ClearSelected();
            }
        }

        private void buttonMostrarIncidente_Click(object sender, EventArgs e)
        {
            Incidente i = (Incidente)listBoxIncidente.SelectedItem;
            if (i == null)
                MessageBox.Show("No hay infraccion seleccionada para mostrar.");
            else
            {
                FormIncidente fi = new FormIncidente(i, dt.Infracciones);
                fi.prepararMostrar();
                fi.ShowDialog();
            }
        }

        private void listBoxInfraccion_Format(object sender, ListControlConvertEventArgs e)
        {
            string desc = ((Infraccion)e.ListItem).Descripcion;
            string monto = ((Infraccion)e.ListItem).Importe.ToString();

            e.Value = "Infraccion: " + desc + " | Monto: $" + monto;
        }

        private void listBoxIncidente_Format(object sender, ListControlConvertEventArgs e)
        {
            string desc = ((Incidente)e.ListItem).Infraccion.Descripcion;
            string fecha = ((Incidente)e.ListItem).Fecha.ToString("dd/MM/yy HH:mm");
            string patente = ((Incidente)e.ListItem).Vehiculo.Patente;

            e.Value = fecha + " | Patente: " + patente + " | " + desc;
        }

        private void textBoxBuscarInc_TextChanged(object sender, EventArgs e)
        {
            listBoxIncidente.DataSource = null;
            foreach (Incidente a in dt.Incidentes.ToList())
            {
                listBoxIncidente.Items.Add(a);
            }
            if (string.IsNullOrEmpty(textBoxBuscarInc.Text) == false)
            {
                listBoxIncidente.Items.Clear();
                foreach (Incidente a in dt.Incidentes.ToList())
                {
                    if (a.Vehiculo.Patente.StartsWith(textBoxBuscarInc.Text))
                    {
                        listBoxIncidente.Items.Add(a);
                    }
                }
            }
            else if (textBoxBuscarInc.Text == "")
            {
                listBoxIncidente.DataSource = dt.Incidentes;
            }
        }
    }
}