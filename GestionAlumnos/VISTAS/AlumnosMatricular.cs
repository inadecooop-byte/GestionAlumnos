using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionAlumnos.VISTAS
{
    public partial class AlumnosMatricular : Form
    {

        // parametros del formulario
        // 0 viene de altas alumnos
        // 1 viene de matricular alumnos

        private int opcion;

        public AlumnosMatricular(int opcionF)
        {
            InitializeComponent();

            // recojo la opcion para saber desde donde se
            // llama al formulario, si es desde altas alumnos
            // o desde matricular alumnos
            this.opcion = opcionF;
        }


        // ===========================================================
        // Llamo al formulario desde la opcion de matricular alumnos,
        // por lo que habilito el textBox_ID para introducir el ID del alumno a matricular
        // ===========================================================
        private void AlumnosMatricular_Load(object sender, EventArgs e)
        {
            if (opcion == 0)
            {
                textBox_ID.Enabled = false;
                textBox_NOMBRE.Enabled = false;
                textBox_APELLIDOS.Enabled = false;
                button_Buscar.Visible = false;
            }

            if (opcion == 1)
            {
                textBox_ID.Enabled = true;
                button_Buscar.Visible = true;
            }
        }

        private void button_CANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
