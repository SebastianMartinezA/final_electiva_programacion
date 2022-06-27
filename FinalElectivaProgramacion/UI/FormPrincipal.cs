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
            Infraccion inf = (Infraccion)listBoxInfraccion.SelectedItem;
            if (inf == null)
                MessageBox.Show("No hay infraccion seleccionada para eliminar.");
            else
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar la infraccion seleccionada?", "Eliminar infraccion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    inf.eliminarInfraccionDb();
                    dt.removerInfraccion(inf);

                    MessageBox.Show("Infraccion eliminada satisfactoriamente.");
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
            Incidente inc = (Incidente)listBoxIncidente.SelectedItem;
            if (inc == null)
                MessageBox.Show("No hay incidente seleccionado para eliminar.");
            else
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar el incidente seleccionado?", "Eliminar incidente", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    inc.eliminarDb();
                    inc.eliminar();
                    dt.removerIncidente(inc);

                    MessageBox.Show("Incidente eliminado satisfactoriamente.");
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
                MessageBox.Show("No hay incidente seleccionado para mostrar.");
            else
            {
                FormIncidente fi = new FormIncidente(i, dt.Infracciones);
                fi.prepararMostrar();
                fi.ShowDialog();
            }
        }

        private void buttonPagoIncidente_Click(object sender, EventArgs e)
        {
            Incidente inc = (Incidente)listBoxIncidente.SelectedItem;
            if (inc == null)
                MessageBox.Show("No hay incidente seleccionado para pagar.");
            else
            {
                double monto = inc.Infraccion.calcularImporte(inc.Fecha);
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea realizar el pago correspondiente a $" + monto + " para el incidente seleccionado ?", "Realizar Pago", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dt.agregarPago(inc, monto);
                    MessageBox.Show("Pago realizado satisfactoriamente.");
                }

                listBoxIncidente.ClearSelected();
                //dataGridViewPagos.DataSource = null;
                //dataGridViewPagos.DataSource = club.Pagos.Select(o => new { ID = o.Id, Monto = "$" + o.Monto, Socio = o.Soc.Nombre, Fecha = o.Fecha.ToShortDateString() }).ToList();
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
            string fecha = ((Incidente)e.ListItem).Fecha.ToString("dd/MM/yy");
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
        
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            int defaultDescGrave = 20;
            string desc = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un valor para el porcentaje de descuento para las infracciones graves que se paguen 25 dias antes de su vencimiento.", "Infraccion Grave", defaultDescGrave.ToString());
            if (desc.Length != 0)
            {
                defaultDescGrave = int.Parse(desc);
            }
            InfraccionGrave.SetDescuento25Dias(defaultDescGrave);

            int defaultDescLeve = 25;
            desc = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un valor para el porcentaje de descuento para las infracciones leves que se paguen 20 dias antes de su vencimiento", "Infraccion Leve", defaultDescLeve.ToString());
            if (desc.Length != 0)
            {
                defaultDescLeve = int.Parse(desc);
            }
            InfraccionLeve.SetDescuento20Dias(defaultDescLeve);

            int defaultDescLeve2 = 15;
            desc = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un valor para el porcentaje de descuento para las infracciones leves que se paguen 10 dias antes de su vencimiento", "Infraccion Leve", defaultDescLeve2.ToString());
            if (desc.Length != 0)
            {
                defaultDescLeve2 = int.Parse(desc);
            }
            InfraccionLeve.SetDescuento10Dias(defaultDescLeve2);
        }
    }
}