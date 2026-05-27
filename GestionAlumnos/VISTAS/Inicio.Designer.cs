namespace GestionAlumnos
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            alumnosToolStripMenuItem = new ToolStripMenuItem();
            OpcionAltas = new ToolStripMenuItem();
            bajasToolStripMenuItem = new ToolStripMenuItem();
            modificacionesToolStripMenuItem = new ToolStripMenuItem();
            cursosToolStripMenuItem = new ToolStripMenuItem();
            altasToolStripMenuItem1 = new ToolStripMenuItem();
            bajasToolStripMenuItem1 = new ToolStripMenuItem();
            modificacionesToolStripMenuItem1 = new ToolStripMenuItem();
            inscripcionesToolStripMenuItem = new ToolStripMenuItem();
            verToolStripMenuItem = new ToolStripMenuItem();
            alumnosToolStripMenuItem1 = new ToolStripMenuItem();
            cursosToolStripMenuItem1 = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            panelContenedor = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { alumnosToolStripMenuItem, cursosToolStripMenuItem, inscripcionesToolStripMenuItem, verToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(845, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // alumnosToolStripMenuItem
            // 
            alumnosToolStripMenuItem.BackColor = SystemColors.ButtonFace;
            alumnosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpcionAltas, bajasToolStripMenuItem, modificacionesToolStripMenuItem });
            alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            alumnosToolStripMenuItem.Size = new Size(67, 19);
            alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // OpcionAltas
            // 
            OpcionAltas.Name = "OpcionAltas";
            OpcionAltas.Size = new Size(180, 22);
            OpcionAltas.Text = "Altas";
            OpcionAltas.Click += OpcionAltas_Click;
            // 
            // bajasToolStripMenuItem
            // 
            bajasToolStripMenuItem.Name = "bajasToolStripMenuItem";
            bajasToolStripMenuItem.Size = new Size(180, 22);
            bajasToolStripMenuItem.Text = "Bajas";
            bajasToolStripMenuItem.Click += OpcionBajas_Click;
            // 
            // modificacionesToolStripMenuItem
            // 
            modificacionesToolStripMenuItem.Name = "modificacionesToolStripMenuItem";
            modificacionesToolStripMenuItem.Size = new Size(180, 22);
            modificacionesToolStripMenuItem.Text = "Modificaciones";
            // 
            // cursosToolStripMenuItem
            // 
            cursosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altasToolStripMenuItem1, bajasToolStripMenuItem1, modificacionesToolStripMenuItem1 });
            cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            cursosToolStripMenuItem.Size = new Size(55, 19);
            cursosToolStripMenuItem.Text = "Cursos";
            // 
            // altasToolStripMenuItem1
            // 
            altasToolStripMenuItem1.Name = "altasToolStripMenuItem1";
            altasToolStripMenuItem1.Size = new Size(155, 22);
            altasToolStripMenuItem1.Text = "Altas";
            // 
            // bajasToolStripMenuItem1
            // 
            bajasToolStripMenuItem1.Name = "bajasToolStripMenuItem1";
            bajasToolStripMenuItem1.Size = new Size(155, 22);
            bajasToolStripMenuItem1.Text = "Bajas";
            // 
            // modificacionesToolStripMenuItem1
            // 
            modificacionesToolStripMenuItem1.Name = "modificacionesToolStripMenuItem1";
            modificacionesToolStripMenuItem1.Size = new Size(155, 22);
            modificacionesToolStripMenuItem1.Text = "Modificaciones";
            // 
            // inscripcionesToolStripMenuItem
            // 
            inscripcionesToolStripMenuItem.Name = "inscripcionesToolStripMenuItem";
            inscripcionesToolStripMenuItem.Size = new Size(92, 19);
            inscripcionesToolStripMenuItem.Text = "Matriculacion";
            inscripcionesToolStripMenuItem.Click += inscripcionesToolStripMenuItem_Click;
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alumnosToolStripMenuItem1, cursosToolStripMenuItem1, acercaDeToolStripMenuItem });
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(35, 19);
            verToolStripMenuItem.Text = "Ver";
            // 
            // alumnosToolStripMenuItem1
            // 
            alumnosToolStripMenuItem1.Name = "alumnosToolStripMenuItem1";
            alumnosToolStripMenuItem1.Size = new Size(129, 22);
            alumnosToolStripMenuItem1.Text = "Alumnos";
            // 
            // cursosToolStripMenuItem1
            // 
            cursosToolStripMenuItem1.Name = "cursosToolStripMenuItem1";
            cursosToolStripMenuItem1.Size = new Size(129, 22);
            cursosToolStripMenuItem1.Text = "Cursos";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(129, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de ";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.Control;
            panelContenedor.BackgroundImage = Properties.Resources.FONDO_INICIO;
            panelContenedor.BackgroundImageLayout = ImageLayout.Center;
            panelContenedor.Dock = DockStyle.Top;
            panelContenedor.ForeColor = SystemColors.ActiveCaptionText;
            panelContenedor.Location = new Point(0, 25);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(845, 521);
            panelContenedor.TabIndex = 2;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 561);
            Controls.Add(panelContenedor);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10F);
            MainMenuStrip = menuStrip1;
            Name = "Inicio";
            Text = "Gestion de Alumnos";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem alumnosToolStripMenuItem;
        private ToolStripMenuItem OpcionAltas;
        private ToolStripMenuItem bajasToolStripMenuItem;
        private ToolStripMenuItem modificacionesToolStripMenuItem;
        private ToolStripMenuItem cursosToolStripMenuItem;
        private ToolStripMenuItem altasToolStripMenuItem1;
        private ToolStripMenuItem bajasToolStripMenuItem1;
        private ToolStripMenuItem modificacionesToolStripMenuItem1;
        private ToolStripMenuItem inscripcionesToolStripMenuItem;
        private Panel panelContenedor;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem alumnosToolStripMenuItem1;
        private ToolStripMenuItem cursosToolStripMenuItem1;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}
