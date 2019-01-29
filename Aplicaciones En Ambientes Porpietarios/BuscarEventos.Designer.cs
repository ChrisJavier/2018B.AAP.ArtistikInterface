namespace Aplicaciones_En_Ambientes_Porpietarios
{
    partial class BuscarEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarEventos));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoB = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pBoxReturn = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pBoxLimpiar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLimpiar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(205, 67);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(315, 30);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.MouseEnter += new System.EventHandler(this.txtSearch_MouseEnter);
            this.txtSearch.MouseLeave += new System.EventHandler(this.txtSearch_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(526, 66);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 31);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 73;
            this.pictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox5, "Buscar");
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            this.pictureBox5.MouseHover += new System.EventHandler(this.pictureBox5_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblSearch);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbTipoB);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 114);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de Evento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 75;
            this.label1.Text = "Buscar por:";
            // 
            // cmbTipoB
            // 
            this.cmbTipoB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoB.FormattingEnabled = true;
            this.cmbTipoB.Items.AddRange(new object[] {
            "Código",
            "Tipo",
            "Hora de Inicio",
            "Hora de Finalización",
            "Coordinador",
            "Equipo de Trabajo",
            "Cliente"});
            this.cmbTipoB.Location = new System.Drawing.Point(6, 66);
            this.cmbTipoB.Name = "cmbTipoB";
            this.cmbTipoB.Size = new System.Drawing.Size(166, 31);
            this.cmbTipoB.TabIndex = 74;
            this.cmbTipoB.MouseEnter += new System.EventHandler(this.cmbTipoB_MouseEnter);
            this.cmbTipoB.MouseLeave += new System.EventHandler(this.cmbTipoB_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 190);
            this.dataGridView1.TabIndex = 75;
            // 
            // pBoxReturn
            // 
            this.pBoxReturn.BackColor = System.Drawing.Color.Transparent;
            this.pBoxReturn.Image = ((System.Drawing.Image)(resources.GetObject("pBoxReturn.Image")));
            this.pBoxReturn.Location = new System.Drawing.Point(632, 25);
            this.pBoxReturn.Name = "pBoxReturn";
            this.pBoxReturn.Size = new System.Drawing.Size(49, 42);
            this.pBoxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxReturn.TabIndex = 76;
            this.pBoxReturn.TabStop = false;
            this.toolTip1.SetToolTip(this.pBoxReturn, "Regresar");
            this.pBoxReturn.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pBoxReturn.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.pBoxReturn.MouseHover += new System.EventHandler(this.pictureBox4_MouseHover);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.DarkRed;
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(6, 66);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(173, 23);
            this.lblTipo.TabIndex = 94;
            this.lblTipo.Text = "Error, Escoja una opción";
            this.lblTipo.Visible = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.DarkRed;
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(358, 67);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(162, 23);
            this.lblSearch.TabIndex = 96;
            this.lblSearch.Text = "Error, Ingrese un valor";
            this.lblSearch.Visible = false;
            // 
            // pBoxLimpiar
            // 
            this.pBoxLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.pBoxLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("pBoxLimpiar.Image")));
            this.pBoxLimpiar.Location = new System.Drawing.Point(632, 73);
            this.pBoxLimpiar.Name = "pBoxLimpiar";
            this.pBoxLimpiar.Size = new System.Drawing.Size(49, 49);
            this.pBoxLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxLimpiar.TabIndex = 77;
            this.pBoxLimpiar.TabStop = false;
            this.toolTip1.SetToolTip(this.pBoxLimpiar, "Limpiar");
            this.pBoxLimpiar.Click += new System.EventHandler(this.pBoxLimpiar_Click);
            this.pBoxLimpiar.MouseLeave += new System.EventHandler(this.pBoxLimpiar_MouseLeave);
            this.pBoxLimpiar.MouseHover += new System.EventHandler(this.pBoxLimpiar_MouseHover);
            // 
            // BuscarEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(693, 402);
            this.Controls.Add(this.pBoxLimpiar);
            this.Controls.Add(this.pBoxReturn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BuscarCurso";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLimpiar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pBoxReturn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoB;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.PictureBox pBoxLimpiar;
    }
}