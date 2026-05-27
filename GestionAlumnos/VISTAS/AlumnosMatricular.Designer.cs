namespace GestionAlumnos.VISTAS
{
    partial class AlumnosMatricular
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
            textBox_APELLIDOS = new TextBox();
            label_APELLIDOS = new Label();
            textBox_NOMBRE = new TextBox();
            label_NOMBRE = new Label();
            textBox_ID = new TextBox();
            label_ID = new Label();
            dataGridView_CURSOS = new DataGridView();
            label1 = new Label();
            button_ACEPTAR = new Button();
            button_LIMPIAR = new Button();
            button_CANCELAR = new Button();
            button_Buscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_CURSOS).BeginInit();
            SuspendLayout();
            // 
            // textBox_APELLIDOS
            // 
            textBox_APELLIDOS.Location = new Point(499, 26);
            textBox_APELLIDOS.Name = "textBox_APELLIDOS";
            textBox_APELLIDOS.Size = new Size(251, 25);
            textBox_APELLIDOS.TabIndex = 7;
            // 
            // label_APELLIDOS
            // 
            label_APELLIDOS.AutoSize = true;
            label_APELLIDOS.Location = new Point(428, 29);
            label_APELLIDOS.Name = "label_APELLIDOS";
            label_APELLIDOS.Size = new Size(71, 17);
            label_APELLIDOS.TabIndex = 4;
            label_APELLIDOS.Text = "APELLIDOS";
            // 
            // textBox_NOMBRE
            // 
            textBox_NOMBRE.Location = new Point(225, 26);
            textBox_NOMBRE.Name = "textBox_NOMBRE";
            textBox_NOMBRE.Size = new Size(179, 25);
            textBox_NOMBRE.TabIndex = 8;
            // 
            // label_NOMBRE
            // 
            label_NOMBRE.AutoSize = true;
            label_NOMBRE.Location = new Point(156, 30);
            label_NOMBRE.Name = "label_NOMBRE";
            label_NOMBRE.Size = new Size(62, 17);
            label_NOMBRE.TabIndex = 5;
            label_NOMBRE.Text = "NOMBRE";
            // 
            // textBox_ID
            // 
            textBox_ID.Enabled = false;
            textBox_ID.Location = new Point(77, 26);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(61, 25);
            textBox_ID.TabIndex = 9;
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Location = new Point(51, 30);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(20, 17);
            label_ID.TabIndex = 6;
            label_ID.Text = "ID";
            // 
            // dataGridView_CURSOS
            // 
            dataGridView_CURSOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_CURSOS.Location = new Point(49, 166);
            dataGridView_CURSOS.Name = "dataGridView_CURSOS";
            dataGridView_CURSOS.Size = new Size(701, 245);
            dataGridView_CURSOS.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 135);
            label1.Name = "label1";
            label1.Size = new Size(137, 17);
            label1.TabIndex = 5;
            label1.Text = "CURSOS DISPONIBLES";
            // 
            // button_ACEPTAR
            // 
            button_ACEPTAR.AutoSize = true;
            button_ACEPTAR.Location = new Point(369, 439);
            button_ACEPTAR.Name = "button_ACEPTAR";
            button_ACEPTAR.Size = new Size(75, 28);
            button_ACEPTAR.TabIndex = 11;
            button_ACEPTAR.Text = "ACEPTAR";
            button_ACEPTAR.UseVisualStyleBackColor = true;
            // 
            // button_LIMPIAR
            // 
            button_LIMPIAR.AutoSize = true;
            button_LIMPIAR.Location = new Point(464, 439);
            button_LIMPIAR.Name = "button_LIMPIAR";
            button_LIMPIAR.Size = new Size(173, 28);
            button_LIMPIAR.TabIndex = 11;
            button_LIMPIAR.Text = "LIMPIAR SELECCIÓN";
            button_LIMPIAR.UseVisualStyleBackColor = true;
            // 
            // button_CANCELAR
            // 
            button_CANCELAR.AutoSize = true;
            button_CANCELAR.Location = new Point(657, 439);
            button_CANCELAR.Name = "button_CANCELAR";
            button_CANCELAR.Size = new Size(81, 28);
            button_CANCELAR.TabIndex = 11;
            button_CANCELAR.Text = "CANCELAR";
            button_CANCELAR.UseVisualStyleBackColor = true;
            button_CANCELAR.Click += button_CANCELAR_Click;
            // 
            // button_Buscar
            // 
            button_Buscar.Location = new Point(49, 69);
            button_Buscar.Name = "button_Buscar";
            button_Buscar.Size = new Size(704, 28);
            button_Buscar.TabIndex = 12;
            button_Buscar.Text = "BUSCAR";
            button_Buscar.UseVisualStyleBackColor = true;
            // 
            // AlumnosMatricular
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(button_Buscar);
            Controls.Add(button_LIMPIAR);
            Controls.Add(button_CANCELAR);
            Controls.Add(button_ACEPTAR);
            Controls.Add(dataGridView_CURSOS);
            Controls.Add(textBox_APELLIDOS);
            Controls.Add(label_APELLIDOS);
            Controls.Add(textBox_NOMBRE);
            Controls.Add(label1);
            Controls.Add(label_NOMBRE);
            Controls.Add(textBox_ID);
            Controls.Add(label_ID);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AlumnosMatricular";
            Text = "AlumnosMatricular";
            Load += AlumnosMatricular_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_CURSOS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_APELLIDOS;
        private Label label_APELLIDOS;
        private TextBox textBox_NOMBRE;
        private Label label_NOMBRE;
        private TextBox textBox_ID;
        private Label label_ID;
        private DataGridView dataGridView_CURSOS;
        private Label label1;
        private Button button_ACEPTAR;
        private Button button_LIMPIAR;
        private Button button_CANCELAR;
        private Button button_Buscar;
    }
}