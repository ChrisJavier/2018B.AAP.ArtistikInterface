namespace Aplicaciones_En_Ambientes_Porpietarios
{
    partial class EliminarEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarEvento));
            this.pBoxDelete = new System.Windows.Forms.PictureBox();
            this.pBoxReturn = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.pBoxSearch = new System.Windows.Forms.PictureBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pBoxLimpiar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLimpiar)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxDelete
            // 
            this.pBoxDelete.BackColor = System.Drawing.Color.Transparent;
            this.pBoxDelete.Image = ((System.Drawing.Image)(resources.GetObject("pBoxDelete.Image")));
            this.pBoxDelete.Location = new System.Drawing.Point(614, 136);
            this.pBoxDelete.Name = "pBoxDelete";
            this.pBoxDelete.Size = new System.Drawing.Size(49, 42);
            this.pBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxDelete.TabIndex = 86;
            this.pBoxDelete.TabStop = false;
            this.pBoxDelete.MouseLeave += new System.EventHandler(this.pBoxDelete_MouseLeave);
            this.pBoxDelete.MouseHover += new System.EventHandler(this.pBoxDelete_MouseHover);
            // 
            // pBoxReturn
            // 
            this.pBoxReturn.BackColor = System.Drawing.Color.Transparent;
            this.pBoxReturn.Image = ((System.Drawing.Image)(resources.GetObject("pBoxReturn.Image")));
            this.pBoxReturn.Location = new System.Drawing.Point(614, 21);
            this.pBoxReturn.Name = "pBoxReturn";
            this.pBoxReturn.Size = new System.Drawing.Size(49, 42);
            this.pBoxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxReturn.TabIndex = 85;
            this.pBoxReturn.TabStop = false;
            this.pBoxReturn.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pBoxReturn.MouseLeave += new System.EventHandler(this.pBoxReturn_MouseLeave);
            this.pBoxReturn.MouseHover += new System.EventHandler(this.pBoxReturn_MouseHover);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 192);
            this.dataGridView1.TabIndex = 84;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblSearch);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbTipo);
            this.groupBox1.Controls.Add(this.pBoxSearch);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 98);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminación de Evento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 76;
            this.label1.Text = "Buscar por:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Código"});
            this.cmbTipo.Location = new System.Drawing.Point(10, 58);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(181, 31);
            this.cmbTipo.TabIndex = 75;
            this.cmbTipo.MouseEnter += new System.EventHandler(this.cmbTipo_MouseEnter);
            this.cmbTipo.MouseLeave += new System.EventHandler(this.cmbTipo_MouseLeave);
            // 
            // pBoxSearch
            // 
            this.pBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.pBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pBoxSearch.Image")));
            this.pBoxSearch.Location = new System.Drawing.Point(538, 47);
            this.pBoxSearch.Name = "pBoxSearch";
            this.pBoxSearch.Size = new System.Drawing.Size(41, 42);
            this.pBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxSearch.TabIndex = 74;
            this.pBoxSearch.TabStop = false;
            this.pBoxSearch.MouseLeave += new System.EventHandler(this.pBoxSearch_MouseLeave);
            this.pBoxSearch.MouseHover += new System.EventHandler(this.pictureBox5_MouseHover);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(225, 58);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(307, 30);
            this.txtValor.TabIndex = 0;
            this.txtValor.MouseEnter += new System.EventHandler(this.txtValor_MouseEnter);
            this.txtValor.MouseLeave += new System.EventHandler(this.txtValor_MouseLeave);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.DarkRed;
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(6, 58);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(173, 23);
            this.lblTipo.TabIndex = 95;
            this.lblTipo.Text = "Error, Escoja una opción";
            this.lblTipo.Visible = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.DarkRed;
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(370, 58);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(162, 23);
            this.lblSearch.TabIndex = 97;
            this.lblSearch.Text = "Error, Ingrese un valor";
            this.lblSearch.Visible = false;
            // 
            // pBoxLimpiar
            // 
            this.pBoxLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.pBoxLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("pBoxLimpiar.Image")));
            this.pBoxLimpiar.Location = new System.Drawing.Point(614, 75);
            this.pBoxLimpiar.Name = "pBoxLimpiar";
            this.pBoxLimpiar.Size = new System.Drawing.Size(49, 42);
            this.pBoxLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxLimpiar.TabIndex = 87;
            this.pBoxLimpiar.TabStop = false;
            this.pBoxLimpiar.MouseLeave += new System.EventHandler(this.pBoxLimpiar_MouseLeave);
            this.pBoxLimpiar.MouseHover += new System.EventHandler(this.pBoxLimpiar_MouseHover);
            // 
            // EliminarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 413);
            this.Controls.Add(this.pBoxLimpiar);
            this.Controls.Add(this.pBoxDelete);
            this.Controls.Add(this.pBoxReturn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarEvento";
            this.Text = "EliminarEvento";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLimpiar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxDelete;
        private System.Windows.Forms.PictureBox pBoxReturn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.PictureBox pBoxSearch;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.PictureBox pBoxLimpiar;
    }
}