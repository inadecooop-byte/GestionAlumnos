namespace GestionAlumnos.VISTAS
{
    partial class AlumnosAltas
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
            pictureBox_Foto = new PictureBox();
            label_Nombre = new Label();
            label_Direccion = new Label();
            textBox_ID = new TextBox();
            textBox_Direccion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox_Nombre = new TextBox();
            textBox_Apellidos = new TextBox();
            label_CodP = new Label();
            textBox_CodigoP = new TextBox();
            label3 = new Label();
            textBox_Provincia = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox_Estudios = new ComboBox();
            comboBox_Situacion = new ComboBox();
            dateTimePicker_FechaNac = new DateTimePicker();
            button_Matricular = new Button();
            panel1 = new Panel();
            button_Aceptar = new Button();
            button_Cancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Foto).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_Foto
            // 
            pictureBox_Foto.Cursor = Cursors.Hand;
            pictureBox_Foto.Image = Properties.Resources.placeHolderFotoInsertar;
            pictureBox_Foto.Location = new Point(30, 23);
            pictureBox_Foto.Name = "pictureBox_Foto";
            pictureBox_Foto.Size = new Size(114, 152);
            pictureBox_Foto.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_Foto.TabIndex = 0;
            pictureBox_Foto.TabStop = false;
            pictureBox_Foto.Click += pictureBox_Foto_Click;
            // 
            // label_Nombre
            // 
            label_Nombre.AutoSize = true;
            label_Nombre.Font = new Font("Segoe UI", 10F);
            label_Nombre.Location = new Point(165, 28);
            label_Nombre.Name = "label_Nombre";
            label_Nombre.Size = new Size(23, 19);
            label_Nombre.TabIndex = 1;
            label_Nombre.Text = "ID";
            // 
            // label_Direccion
            // 
            label_Direccion.AutoSize = true;
            label_Direccion.Font = new Font("Segoe UI", 10F);
            label_Direccion.Location = new Point(165, 155);
            label_Direccion.Name = "label_Direccion";
            label_Direccion.Size = new Size(65, 19);
            label_Direccion.TabIndex = 1;
            label_Direccion.Text = "Dirección";
            // 
            // textBox_ID
            // 
            textBox_ID.Enabled = false;
            textBox_ID.Location = new Point(282, 28);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(58, 25);
            textBox_ID.TabIndex = 2;
            textBox_ID.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox_Direccion
            // 
            textBox_Direccion.Location = new Point(282, 152);
            textBox_Direccion.Name = "textBox_Direccion";
            textBox_Direccion.Size = new Size(413, 25);
            textBox_Direccion.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(165, 74);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(165, 105);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 1;
            label2.Text = "Apellidos";
            // 
            // textBox_Nombre
            // 
            textBox_Nombre.Location = new Point(282, 71);
            textBox_Nombre.Name = "textBox_Nombre";
            textBox_Nombre.Size = new Size(186, 25);
            textBox_Nombre.TabIndex = 2;
            // 
            // textBox_Apellidos
            // 
            textBox_Apellidos.Location = new Point(282, 102);
            textBox_Apellidos.Name = "textBox_Apellidos";
            textBox_Apellidos.Size = new Size(296, 25);
            textBox_Apellidos.TabIndex = 2;
            // 
            // label_CodP
            // 
            label_CodP.AutoSize = true;
            label_CodP.Font = new Font("Segoe UI", 10F);
            label_CodP.Location = new Point(165, 188);
            label_CodP.Name = "label_CodP";
            label_CodP.Size = new Size(68, 19);
            label_CodP.TabIndex = 1;
            label_CodP.Text = "Código P.";
            // 
            // textBox_CodigoP
            // 
            textBox_CodigoP.Location = new Point(282, 185);
            textBox_CodigoP.Name = "textBox_CodigoP";
            textBox_CodigoP.Size = new Size(77, 25);
            textBox_CodigoP.TabIndex = 2;
            textBox_CodigoP.KeyDown += textBox_CodigoP_KeyDown;
            textBox_CodigoP.Leave += ObtenerCiudad;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(389, 188);
            label3.Name = "label3";
            label3.Size = new Size(64, 19);
            label3.TabIndex = 1;
            label3.Text = "Provincia";
            // 
            // textBox_Provincia
            // 
            textBox_Provincia.Location = new Point(470, 185);
            textBox_Provincia.Name = "textBox_Provincia";
            textBox_Provincia.Size = new Size(225, 25);
            textBox_Provincia.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(165, 241);
            label4.Name = "label4";
            label4.Size = new Size(74, 19);
            label4.TabIndex = 1;
            label4.Text = "Fecha Nac.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(165, 295);
            label5.Name = "label5";
            label5.Size = new Size(60, 19);
            label5.TabIndex = 1;
            label5.Text = "Estudios";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(165, 326);
            label6.Name = "label6";
            label6.Size = new Size(93, 19);
            label6.TabIndex = 1;
            label6.Text = "Situacion Lab.";
            // 
            // comboBox_Estudios
            // 
            comboBox_Estudios.FormattingEnabled = true;
            comboBox_Estudios.Items.AddRange(new object[] { "Enseñanza básica", "Bachiller", "Formación profesional ", "Universidad" });
            comboBox_Estudios.Location = new Point(282, 292);
            comboBox_Estudios.Name = "comboBox_Estudios";
            comboBox_Estudios.Size = new Size(142, 25);
            comboBox_Estudios.TabIndex = 3;
            // 
            // comboBox_Situacion
            // 
            comboBox_Situacion.FormattingEnabled = true;
            comboBox_Situacion.Items.AddRange(new object[] { "En paro", "Estudiante", "Ocupado", "Autonomo" });
            comboBox_Situacion.Location = new Point(282, 323);
            comboBox_Situacion.Name = "comboBox_Situacion";
            comboBox_Situacion.Size = new Size(142, 25);
            comboBox_Situacion.TabIndex = 3;
            // 
            // dateTimePicker_FechaNac
            // 
            dateTimePicker_FechaNac.Format = DateTimePickerFormat.Short;
            dateTimePicker_FechaNac.Location = new Point(282, 238);
            dateTimePicker_FechaNac.MaxDate = new DateTime(2040, 5, 19, 0, 0, 0, 0);
            dateTimePicker_FechaNac.MinDate = new DateTime(1960, 1, 1, 0, 0, 0, 0);
            dateTimePicker_FechaNac.Name = "dateTimePicker_FechaNac";
            dateTimePicker_FechaNac.Size = new Size(109, 25);
            dateTimePicker_FechaNac.TabIndex = 4;
            dateTimePicker_FechaNac.Value = new DateTime(2026, 5, 19, 0, 0, 0, 0);
            // 
            // button_Matricular
            // 
            button_Matricular.AutoSize = true;
            button_Matricular.Location = new Point(164, 367);
            button_Matricular.Name = "button_Matricular";
            button_Matricular.Size = new Size(531, 29);
            button_Matricular.TabIndex = 5;
            button_Matricular.Text = "Matricular";
            button_Matricular.UseVisualStyleBackColor = true;
            button_Matricular.Click += button_Matricular_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button_Matricular);
            panel1.Controls.Add(dateTimePicker_FechaNac);
            panel1.Controls.Add(comboBox_Situacion);
            panel1.Controls.Add(comboBox_Estudios);
            panel1.Controls.Add(textBox_Apellidos);
            panel1.Controls.Add(textBox_Nombre);
            panel1.Controls.Add(textBox_Provincia);
            panel1.Controls.Add(textBox_CodigoP);
            panel1.Controls.Add(textBox_Direccion);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox_ID);
            panel1.Controls.Add(label_CodP);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label_Direccion);
            panel1.Controls.Add(label_Nombre);
            panel1.Controls.Add(pictureBox_Foto);
            panel1.Location = new Point(17, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 421);
            panel1.TabIndex = 6;
            // 
            // button_Aceptar
            // 
            button_Aceptar.AutoSize = true;
            button_Aceptar.Location = new Point(455, 451);
            button_Aceptar.Name = "button_Aceptar";
            button_Aceptar.Size = new Size(121, 29);
            button_Aceptar.TabIndex = 7;
            button_Aceptar.Text = "ACEPTAR";
            button_Aceptar.UseVisualStyleBackColor = true;
            // 
            // button_Cancelar
            // 
            button_Cancelar.AutoSize = true;
            button_Cancelar.Location = new Point(592, 451);
            button_Cancelar.Name = "button_Cancelar";
            button_Cancelar.Size = new Size(121, 29);
            button_Cancelar.TabIndex = 7;
            button_Cancelar.Text = "CANCELAR";
            button_Cancelar.UseVisualStyleBackColor = true;
            button_Cancelar.Click += button_Cancelar_Click;
            // 
            // AlumnosAltas
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 497);
            Controls.Add(button_Cancelar);
            Controls.Add(button_Aceptar);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "AlumnosAltas";
            Text = "AlumnosAltas";
            Load += AlumnosAltas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_Foto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion




        private PictureBox pictureBox_Foto;
        private Label label_Nombre;
        private Label label_Direccion;
        private TextBox textBox_ID;
        private TextBox textBox_Direccion;
        private Label label1;
        private Label label2;
        private TextBox textBox_Nombre;
        private TextBox textBox_Apellidos;
        private Label label_CodP;
        private TextBox textBox_CodigoP;
        private Label label3;
        private TextBox textBox_Provincia;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox_Estudios;
        private ComboBox comboBox_Situacion;
        private DateTimePicker dateTimePicker_FechaNac;
        private Button button_Matricular;
        private Panel panel1;
        private Button button_Aceptar;
        private Button button_Cancelar;
    }
}




