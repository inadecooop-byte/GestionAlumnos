using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GestionAlumnos.VISTAS;
using Newtonsoft.Json.Linq;

namespace GestionAlumnos.VISTAS
{
    public partial class AlumnosAltas : Form
    {
        public AlumnosAltas()
        {
            InitializeComponent();
        }


        // ======================================
        // Elegir foto
        // ======================================

        private void pictureBox_Foto_Click(object sender, EventArgs e)
        {
            var foto = new OpenFileDialog();
            foto.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif";
            if (foto.ShowDialog() == DialogResult.OK)
            {
                pictureBox_Foto.Image = Image.FromFile(foto.FileName);
            }
        }


        // ======================================
        // Cancelo el alta
        // ======================================
        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Matricular_Click(object sender, EventArgs e)
        {
            AlumnosMatricular matricular = new AlumnosMatricular(0);
            matricular.ShowDialog();
        }


        // ==================================================================
        // Obtener la ciudad correspondiente al código postal introducido utilizando la API de Zippopotam
        // ==================================================================
        public static string PedirCiudad(string codigoPostal)
        {
           
                // le paso a la url el código postal introducido por el usuario,
                // y la API me devuelve un JSON con la información de la ciudad correspondiente
                string url = $"https://api.zippopotam.us/es/{codigoPostal}";

                // creo un nuevo cliente HTTP para hacer la petición a la API,
                // y obtengo la respuesta en formato JSON
                using HttpClient client = new();

                var response = client.GetStringAsync(url).Result; // síncrono
                JObject json = JObject.Parse(response);

                // Me devuelve el nombre de la ciudad correspondiente al código postal introducido por el usuario
                // en una sola linea. Si el código postal no es válido, la API devolverá un error y se lanzará una
                // excepción que se puede manejar en el método que llama a esta función.
                return json["places"][0]["place name"].ToString();
           
        }



        // ==================================================================
        // Si salgo del textbox del código postal, se obtiene la ciudad correspondiente
        // ==================================================================
        private void ObtenerCiudad(object sender, EventArgs e)
        {
            textBox_Provincia.Text = PedirCiudad(textBox_CodigoP.Text);

        }


        // ===================================================================
        // Si pulso la tecla enter en el textbox del código postal, se obtiene la ciudad correspondiente
        // ===================================================================
        private void textBox_CodigoP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Evita el sonido "beep" del sistema
                e.Handled = true;
                e.SuppressKeyPress = true;

                ObtenerCiudad(sender, e);
            }
        }



        private void AlumnosAltas_Load(object sender, EventArgs e)
        {

        }
    }
}
