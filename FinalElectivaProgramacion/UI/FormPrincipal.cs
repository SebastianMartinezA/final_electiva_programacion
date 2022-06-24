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

        }

        private void buttonModifInfraccion_Click(object sender, EventArgs e)
        {

        }

        private void buttonElimInfraccion_Click(object sender, EventArgs e)
        {

        }

        private void buttonMostrarInfraccion_Click(object sender, EventArgs e)
        {

        }
    }
}