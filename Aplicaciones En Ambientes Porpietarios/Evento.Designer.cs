namespace Aplicaciones_En_Ambientes_Porpietarios
{
    partial class Evento
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Evento));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarAlCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProfesoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(816, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.profesoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarAlCursoToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.buscarProfesoreToolStripMenuItem,
            this.eliminarEventoToolStripMenuItem});
            this.profesoresToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(86, 32);
            this.profesoresToolStripMenuItem.Text = "Eventos";
            // 
            // asignarAlCursoToolStripMenuItem
            // 
            this.asignarAlCursoToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.asignarAlCursoToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.asignarAlCursoToolStripMenuItem.Name = "asignarAlCursoToolStripMenuItem";
            this.asignarAlCursoToolStripMenuItem.Size = new System.Drawing.Size(324, 32);
            this.asignarAlCursoToolStripMenuItem.Text = "Registrar Evento";
            this.asignarAlCursoToolStripMenuItem.Click += new System.EventHandler(this.asignarAlCursoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.modificarToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(324, 32);
            this.modificarToolStripMenuItem.Text = "Modificar Información Evento";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // buscarProfesoreToolStripMenuItem
            // 
            this.buscarProfesoreToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.buscarProfesoreToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.buscarProfesoreToolStripMenuItem.Name = "buscarProfesoreToolStripMenuItem";
            this.buscarProfesoreToolStripMenuItem.Size = new System.Drawing.Size(324, 32);
            this.buscarProfesoreToolStripMenuItem.Text = "Buscar Evento";
            this.buscarProfesoreToolStripMenuItem.Click += new System.EventHandler(this.buscarProfesoreToolStripMenuItem_Click);
            // 
            // eliminarEventoToolStripMenuItem
            // 
            this.eliminarEventoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eliminarEventoToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.eliminarEventoToolStripMenuItem.Name = "eliminarEventoToolStripMenuItem";
            this.eliminarEventoToolStripMenuItem.Size = new System.Drawing.Size(324, 32);
            this.eliminarEventoToolStripMenuItem.Text = "Eliminar Evento";
            this.eliminarEventoToolStripMenuItem.Click += new System.EventHandler(this.eliminarEventoToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(756, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Ir a Menú Principal");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 414);
            this.panel1.TabIndex = 2;
            // 
            // Evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Evento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarAlCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem buscarProfesoreToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarEventoToolStripMenuItem;
    }
}