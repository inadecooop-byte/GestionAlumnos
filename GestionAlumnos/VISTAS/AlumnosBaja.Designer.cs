namespace GestionAlumnos.VISTAS
{
    partial class AlumnosBaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_Buscar = new Button();
            textBox_APELLIDOS = new TextBox();
            label_APELLIDOS = new Label();
            textBox_NOMBRE = new TextBox();
            label_NOMBRE = new Label();
            textBox_ID = new TextBox();
            label_ID = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox_Provincia = new TextBox();
            textBox_CodigoP = new TextBox();
            textBox_Direccion = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label_CodP = new Label();
            label1 = new Label();
            label_Direccion = new Label();
            label4 = new Label();
            pictureBox_Foto = new PictureBox();
            panel_Baja = new Panel();
            button_Eliminar = new Button();
            button_Cancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Foto).BeginInit();
            panel_Baja.SuspendLayout();
            SuspendLayout();
            // 
            // button_Buscar
            // 
            button_Buscar.Location = new Point(25, 64);
            button_Buscar.Name = "button_Buscar";
            button_Buscar.Size = new Size(704, 28);
            button_Buscar.TabIndex = 19;
            button_Buscar.Text = "BUSCAR";
            button_Buscar.UseVisualStyleBackColor = true;
            button_Buscar.Click += button_Buscar_Click;
            // 
            // textBox_APELLIDOS
            // 
            textBox_APELLIDOS.Location = new Point(475, 21);
            textBox_APELLIDOS.Name = "textBox_APELLIDOS";
            textBox_APELLIDOS.Size = new Size(251, 23);
            textBox_APELLIDOS.TabIndex = 16;
            // 
            // label_APELLIDOS
            // 
            label_APELLIDOS.AutoSize = true;
            label_APELLIDOS.Location = new Point(404, 24);
            label_APELLIDOS.Name = "label_APELLIDOS";
            label_APELLIDOS.Size = new Size(66, 15);
            label_APELLIDOS.TabIndex = 13;
            label_APELLIDOS.Text = "APELLIDOS";
            // 
            // textBox_NOMBRE
            // 
            textBox_NOMBRE.Location = new Point(201, 21);
            textBox_NOMBRE.Name = "textBox_NOMBRE";
            textBox_NOMBRE.Size = new Size(179, 23);
            textBox_NOMBRE.TabIndex = 17;
            // 
            // label_NOMBRE
            // 
            label_NOMBRE.AutoSize = true;
            label_NOMBRE.Location = new Point(132, 25);
            label_NOMBRE.Name = "label_NOMBRE";
            label_NOMBRE.Size = new Size(56, 15);
            label_NOMBRE.TabIndex = 14;
            label_NOMBRE.Text = "NOMBRE";
            // 
            // textBox_ID
            // 
            textBox_ID.Enabled = false;
            textBox_ID.Location = new Point(53, 21);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(61, 23);
            textBox_ID.TabIndex = 18;
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Location = new Point(27, 25);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(18, 15);
            label_ID.TabIndex = 15;
            label_ID.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(274, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 23);
            textBox1.TabIndex = 27;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(274, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 23);
            textBox2.TabIndex = 28;
            // 
            // textBox_Provincia
            // 
            textBox_Provincia.Location = new Point(462, 195);
            textBox_Provincia.Name = "textBox_Provincia";
            textBox_Provincia.Size = new Size(225, 23);
            textBox_Provincia.TabIndex = 29;
            // 
            // textBox_CodigoP
            // 
            textBox_CodigoP.Location = new Point(274, 195);
            textBox_CodigoP.Name = "textBox_CodigoP";
            textBox_CodigoP.Size = new Size(77, 23);
            textBox_CodigoP.TabIndex = 30;
            // 
            // textBox_Direccion
            // 
            textBox_Direccion.Location = new Point(274, 162);
            textBox_Direccion.Name = "textBox_Direccion";
            textBox_Direccion.Size = new Size(413, 23);
            textBox_Direccion.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(157, 115);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 21;
            label2.Text = "Apellidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(381, 198);
            label3.Name = "label3";
            label3.Size = new Size(64, 19);
            label3.TabIndex = 22;
            label3.Text = "Provincia";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(274, 38);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(58, 23);
            textBox3.TabIndex = 32;
            // 
            // label_CodP
            // 
            label_CodP.AutoSize = true;
            label_CodP.Font = new Font("Segoe UI", 10F);
            label_CodP.Location = new Point(157, 198);
            label_CodP.Name = "label_CodP";
            label_CodP.Size = new Size(68, 19);
            label_CodP.TabIndex = 23;
            label_CodP.Text = "Código P.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(157, 84);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 24;
            label1.Text = "Nombre";
            // 
            // label_Direccion
            // 
            label_Direccion.AutoSize = true;
            label_Direccion.Font = new Font("Segoe UI", 10F);
            label_Direccion.Location = new Point(157, 165);
            label_Direccion.Name = "label_Direccion";
            label_Direccion.Size = new Size(65, 19);
            label_Direccion.TabIndex = 25;
            label_Direccion.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(157, 38);
            label4.Name = "label4";
            label4.Size = new Size(23, 19);
            label4.TabIndex = 26;
            label4.Text = "ID";
            // 
            // pictureBox_Foto
            // 
            pictureBox_Foto.Image = Properties.Resources.VACIA;
            pictureBox_Foto.Location = new Point(22, 33);
            pictureBox_Foto.Name = "pictureBox_Foto";
            pictureBox_Foto.Size = new Size(114, 152);
            pictureBox_Foto.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_Foto.TabIndex = 20;
            pictureBox_Foto.TabStop = false;
            // 
            // panel_Baja
            // 
            panel_Baja.Controls.Add(button_Eliminar);
            panel_Baja.Controls.Add(button_Cancelar);
            panel_Baja.Controls.Add(textBox1);
            panel_Baja.Controls.Add(textBox2);
            panel_Baja.Controls.Add(textBox_Provincia);
            panel_Baja.Controls.Add(textBox_CodigoP);
            panel_Baja.Controls.Add(textBox_Direccion);
            panel_Baja.Controls.Add(label2);
            panel_Baja.Controls.Add(label3);
            panel_Baja.Controls.Add(textBox3);
            panel_Baja.Controls.Add(label_CodP);
            panel_Baja.Controls.Add(label1);
            panel_Baja.Controls.Add(label_Direccion);
            panel_Baja.Controls.Add(label4);
            panel_Baja.Controls.Add(pictureBox_Foto);
            panel_Baja.Location = new Point(27, 114);
            panel_Baja.Name = "panel_Baja";
            panel_Baja.Size = new Size(704, 311);
            panel_Baja.TabIndex = 33;
            panel_Baja.Visible = false;
            // 
            // button_Eliminar
            // 
            button_Eliminar.AutoSize = true;
            button_Eliminar.Location = new Point(429, 270);
            button_Eliminar.Name = "button_Eliminar";
            button_Eliminar.Size = new Size(121, 29);
            button_Eliminar.TabIndex = 35;
            button_Eliminar.Text = "ELIMINAR";
            button_Eliminar.UseVisualStyleBackColor = true;
            // 
            // button_Cancelar
            // 
            button_Cancelar.AutoSize = true;
            button_Cancelar.Location = new Point(566, 270);
            button_Cancelar.Name = "button_Cancelar";
            button_Cancelar.Size = new Size(121, 29);
            button_Cancelar.TabIndex = 34;
            button_Cancelar.Text = "CANCELAR";
            button_Cancelar.UseVisualStyleBackColor = true;
            button_Cancelar.Click += button_Cancelar_Click;
            // 
            // AlumnosBaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 450);
            Controls.Add(panel_Baja);
            Controls.Add(button_Buscar);
            Controls.Add(textBox_APELLIDOS);
            Controls.Add(label_APELLIDOS);
            Controls.Add(textBox_NOMBRE);
            Controls.Add(label_NOMBRE);
            Controls.Add(textBox_ID);
            Controls.Add(label_ID);
            Name = "AlumnosBaja";
            Text = "BAJAS";
            ((System.ComponentModel.ISupportInitialize)pictureBox_Foto).EndInit();
            panel_Baja.ResumeLayout(false);
            panel_Baja.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Buscar;
        private TextBox textBox_APELLIDOS;
        private Label label_APELLIDOS;
        private TextBox textBox_NOMBRE;
        private Label label_NOMBRE;
        private TextBox textBox_ID;
        private Label label_ID;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox_Provincia;
        private TextBox textBox_CodigoP;
        private TextBox textBox_Direccion;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label label_CodP;
        private Label label1;
        private Label label_Direccion;
        private Label label4;
        private PictureBox pictureBox_Foto;
        private Panel panel_Baja;
        private Button button_Cancelar;
        private Button button_Eliminar;
    }
}