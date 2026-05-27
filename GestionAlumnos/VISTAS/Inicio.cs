namespace GestionAlumnos
{
    using VISTAS;

    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }




        public void OpcionAltas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new AlumnosAltas());
        }


        public void OpcionBajas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new AlumnosBaja());
        }


        private void AbrirFormulario(Form formulario)
        {
            panelContenedor.Controls.Clear();

            // this.StartPosition = FormStartPosition.CenterParent;

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            // formulario.Dock = DockStyle.Fill;
            formulario.Dock = DockStyle.None;

            panelContenedor.Controls.Add(formulario);

            // Centrar
            formulario.Location = new Point(
                (panelContenedor.Width - formulario.Width) / 2,
                (panelContenedor.Height - formulario.Height) / 2
            );

            formulario.Show();
        }

        private void inscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new AlumnosMatricular(1));
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
        }
    }
}
