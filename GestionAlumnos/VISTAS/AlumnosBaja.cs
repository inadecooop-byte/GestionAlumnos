using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionAlumnos.VISTAS
{
    public partial class AlumnosBaja : Form
    {
        public AlumnosBaja()
        {
            InitializeComponent();
            
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            // Implementation for buscar button click
            panel_Baja.Visible = true;
        }

       private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
