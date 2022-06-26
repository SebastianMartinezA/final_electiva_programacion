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
                //fi.prepararCrear();
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
    }
}