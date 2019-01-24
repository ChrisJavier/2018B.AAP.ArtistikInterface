namespace Aplicaciones_En_Ambientes_Porpietarios
{
    partial class Turismo2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Turismo2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevaRutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoRecorridoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.consultarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaRutaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(123, 623);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevaRutaToolStripMenuItem
            // 
            this.nuevaRutaToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.nuevaRutaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoRecorridoToolStripMenuItem1,
            this.consultarCitaToolStripMenuItem,
            this.modificarCitaToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.nuevaRutaToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.nuevaRutaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevaRutaToolStripMenuItem.Name = "nuevaRutaToolStripMenuItem";
            this.nuevaRutaToolStripMenuItem.Size = new System.Drawing.Size(116, 27);
            this.nuevaRutaToolStripMenuItem.Text = "Agenda";
            this.nuevaRutaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nuevoRecorridoToolStripMenuItem1
            // 
            this.nuevoRecorridoToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.nuevoRecorridoToolStripMenuItem1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.nuevoRecorridoToolStripMenuItem1.Name = "nuevoRecorridoToolStripMenuItem1";
            this.nuevoRecorridoToolStripMenuItem1.Size = new System.Drawing.Size(180, 28);
            this.nuevoRecorridoToolStripMenuItem1.Text = "Nuevo Cita";
            this.nuevoRecorridoToolStripMenuItem1.Click += new System.EventHandler(this.nuevoRecorridoToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(92, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 600);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 563);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // consultarCitaToolStripMenuItem
            // 
            this.consultarCitaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.consultarCitaToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.consultarCitaToolStripMenuItem.Name = "consultarCitaToolStripMenuItem";
            this.consultarCitaToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.consultarCitaToolStripMenuItem.Text = "Consultar Cita";
            this.consultarCitaToolStripMenuItem.Click += new System.EventHandler(this.consultarCitaToolStripMenuItem_Click);
            // 
            // modificarCitaToolStripMenuItem
            // 
            this.modificarCitaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modificarCitaToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.modificarCitaToolStripMenuItem.Name = "modificarCitaToolStripMenuItem";
            this.modificarCitaToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.modificarCitaToolStripMenuItem.Text = "Modificar Cita";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eliminarToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.eliminarToolStripMenuItem.Text = "Eliminar Cita";
            // 
            // Turismo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1105, 623);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Turismo2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turismo2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevaRutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoRecorridoToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem consultarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}