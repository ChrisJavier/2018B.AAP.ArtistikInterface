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
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.nombresClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aAP_2018DataSet = new Aplicaciones_En_Ambientes_Porpietarios.AAP_2018DataSet();
            this.cmbTipoa = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoB = new System.Windows.Forms.ComboBox();
            this.pBoxReturn = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pBoxLimpiar = new System.Windows.Forms.PictureBox();
            this.pBoxReturn1 = new System.Windows.Forms.PictureBox();
            this.nombresClienteTableAdapter = new Aplicaciones_En_Ambientes_Porpietarios.AAP_2018DataSetTableAdapters.NombresClienteTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gBoxDatos = new System.Windows.Forms.GroupBox();
            this.lblIdGrupo = new System.Windows.Forms.Label();
            this.lblIdcliente = new System.Windows.Forms.Label();
            this.lblCliente1 = new System.Windows.Forms.Label();
            this.lblEA = new System.Windows.Forms.Label();
            this.lblHDF = new System.Windows.Forms.Label();
            this.lblHDI = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblDate1 = new System.Windows.Forms.Label();
            this.lblTipo1 = new System.Windows.Forms.Label();
            this.lblCode1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dGVConsulta = new System.Windows.Forms.DataGridView();
            this.IDEVENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDGRUPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOEVENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCIONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nombresClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAP_2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxReturn1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(284, 66);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(242, 30);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Visible = false;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.MouseEnter += new System.EventHandler(this.txtSearch_MouseEnter);
            this.txtSearch.MouseLeave += new System.EventHandler(this.txtSearch_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(531, 66);
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
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Controls.Add(this.cmbTipoa);
            this.groupBox1.Controls.Add(this.lblSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbTipoB);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 114);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de Evento";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DataSource = this.nombresClienteBindingSource;
            this.cmbCliente.DisplayMember = "NOMBRES";
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(262, 66);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(264, 31);
            this.cmbCliente.TabIndex = 98;
            this.cmbCliente.ValueMember = "IDCLIENTE";
            this.cmbCliente.Visible = false;
            this.cmbCliente.MouseEnter += new System.EventHandler(this.cmbCliente_MouseEnter);
            this.cmbCliente.MouseLeave += new System.EventHandler(this.cmbCliente_MouseLeave);
            // 
            // nombresClienteBindingSource
            // 
            this.nombresClienteBindingSource.DataMember = "NombresCliente";
            this.nombresClienteBindingSource.DataSource = this.aAP_2018DataSet;
            // 
            // aAP_2018DataSet
            // 
            this.aAP_2018DataSet.DataSetName = "AAP_2018DataSet";
            this.aAP_2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbTipoa
            // 
            this.cmbTipoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoa.FormattingEnabled = true;
            this.cmbTipoa.Items.AddRange(new object[] {
            "Boda",
            "Bautizo",
            "Confirmación",
            "Graduación",
            "Primera Comunión",
            "Otros"});
            this.cmbTipoa.Location = new System.Drawing.Point(298, 66);
            this.cmbTipoa.Name = "cmbTipoa";
            this.cmbTipoa.Size = new System.Drawing.Size(228, 31);
            this.cmbTipoa.TabIndex = 97;
            this.cmbTipoa.Visible = false;
            this.cmbTipoa.MouseEnter += new System.EventHandler(this.cmbTipoa_MouseEnter);
            this.cmbTipoa.MouseLeave += new System.EventHandler(this.cmbTipoa_MouseLeave);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.DarkRed;
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(246, 40);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(162, 23);
            this.lblSearch.TabIndex = 96;
            this.lblSearch.Text = "Error, Ingrese un valor";
            this.lblSearch.Visible = false;
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
            "",
            "Código",
            "Tipo",
            "Cliente"});
            this.cmbTipoB.Location = new System.Drawing.Point(6, 66);
            this.cmbTipoB.Name = "cmbTipoB";
            this.cmbTipoB.Size = new System.Drawing.Size(181, 31);
            this.cmbTipoB.TabIndex = 74;
            this.cmbTipoB.SelectedIndexChanged += new System.EventHandler(this.cmbTipoB_SelectedIndexChanged);
            this.cmbTipoB.MouseEnter += new System.EventHandler(this.cmbTipoB_MouseEnter);
            this.cmbTipoB.MouseLeave += new System.EventHandler(this.cmbTipoB_MouseLeave);
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
            // pBoxReturn1
            // 
            this.pBoxReturn1.BackColor = System.Drawing.Color.Transparent;
            this.pBoxReturn1.Image = ((System.Drawing.Image)(resources.GetObject("pBoxReturn1.Image")));
            this.pBoxReturn1.Location = new System.Drawing.Point(312, 404);
            this.pBoxReturn1.Name = "pBoxReturn1";
            this.pBoxReturn1.Size = new System.Drawing.Size(49, 42);
            this.pBoxReturn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxReturn1.TabIndex = 82;
            this.pBoxReturn1.TabStop = false;
            this.toolTip1.SetToolTip(this.pBoxReturn1, "Regresar");
            this.pBoxReturn1.Click += new System.EventHandler(this.pBoxReturn1_Click_1);
            this.pBoxReturn1.MouseLeave += new System.EventHandler(this.pBoxReturn1_MouseLeave);
            this.pBoxReturn1.MouseHover += new System.EventHandler(this.pBoxReturn1_MouseHover);
            // 
            // nombresClienteTableAdapter
            // 
            this.nombresClienteTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pBoxReturn1);
            this.panel1.Controls.Add(this.gBoxDatos);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 465);
            this.panel1.TabIndex = 99;
            this.panel1.Visible = false;
            // 
            // gBoxDatos
            // 
            this.gBoxDatos.BackColor = System.Drawing.Color.Transparent;
            this.gBoxDatos.Controls.Add(this.lblIdGrupo);
            this.gBoxDatos.Controls.Add(this.lblIdcliente);
            this.gBoxDatos.Controls.Add(this.lblCliente1);
            this.gBoxDatos.Controls.Add(this.lblEA);
            this.gBoxDatos.Controls.Add(this.lblHDF);
            this.gBoxDatos.Controls.Add(this.lblHDI);
            this.gBoxDatos.Controls.Add(this.lblAddress1);
            this.gBoxDatos.Controls.Add(this.lblDate1);
            this.gBoxDatos.Controls.Add(this.lblTipo1);
            this.gBoxDatos.Controls.Add(this.lblCode1);
            this.gBoxDatos.Controls.Add(this.label9);
            this.gBoxDatos.Controls.Add(this.label8);
            this.gBoxDatos.Controls.Add(this.label7);
            this.gBoxDatos.Controls.Add(this.label6);
            this.gBoxDatos.Controls.Add(this.label5);
            this.gBoxDatos.Controls.Add(this.label4);
            this.gBoxDatos.Controls.Add(this.label3);
            this.gBoxDatos.Controls.Add(this.label2);
            this.gBoxDatos.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxDatos.Location = new System.Drawing.Point(34, 45);
            this.gBoxDatos.Name = "gBoxDatos";
            this.gBoxDatos.Size = new System.Drawing.Size(581, 341);
            this.gBoxDatos.TabIndex = 81;
            this.gBoxDatos.TabStop = false;
            this.gBoxDatos.Text = "Datos";
            // 
            // lblIdGrupo
            // 
            this.lblIdGrupo.AutoSize = true;
            this.lblIdGrupo.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdGrupo.Location = new System.Drawing.Point(273, 26);
            this.lblIdGrupo.Name = "lblIdGrupo";
            this.lblIdGrupo.Size = new System.Drawing.Size(0, 26);
            this.lblIdGrupo.TabIndex = 17;
            this.lblIdGrupo.Visible = false;
            // 
            // lblIdcliente
            // 
            this.lblIdcliente.AutoSize = true;
            this.lblIdcliente.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdcliente.Location = new System.Drawing.Point(251, 26);
            this.lblIdcliente.Name = "lblIdcliente";
            this.lblIdcliente.Size = new System.Drawing.Size(0, 26);
            this.lblIdcliente.TabIndex = 16;
            this.lblIdcliente.Visible = false;
            // 
            // lblCliente1
            // 
            this.lblCliente1.AutoSize = true;
            this.lblCliente1.Location = new System.Drawing.Point(141, 298);
            this.lblCliente1.Name = "lblCliente1";
            this.lblCliente1.Size = new System.Drawing.Size(0, 23);
            this.lblCliente1.TabIndex = 15;
            // 
            // lblEA
            // 
            this.lblEA.AutoSize = true;
            this.lblEA.Location = new System.Drawing.Point(174, 245);
            this.lblEA.Name = "lblEA";
            this.lblEA.Size = new System.Drawing.Size(0, 23);
            this.lblEA.TabIndex = 14;
            // 
            // lblHDF
            // 
            this.lblHDF.AutoSize = true;
            this.lblHDF.Location = new System.Drawing.Point(472, 185);
            this.lblHDF.Name = "lblHDF";
            this.lblHDF.Size = new System.Drawing.Size(0, 23);
            this.lblHDF.TabIndex = 13;
            // 
            // lblHDI
            // 
            this.lblHDI.AutoSize = true;
            this.lblHDI.Location = new System.Drawing.Point(174, 185);
            this.lblHDI.Name = "lblHDI";
            this.lblHDI.Size = new System.Drawing.Size(0, 23);
            this.lblHDI.TabIndex = 12;
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(128, 142);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(0, 23);
            this.lblAddress1.TabIndex = 11;
            // 
            // lblDate1
            // 
            this.lblDate1.AutoSize = true;
            this.lblDate1.Location = new System.Drawing.Point(129, 90);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Size = new System.Drawing.Size(0, 23);
            this.lblDate1.TabIndex = 10;
            // 
            // lblTipo1
            // 
            this.lblTipo1.AutoSize = true;
            this.lblTipo1.Location = new System.Drawing.Point(424, 45);
            this.lblTipo1.Name = "lblTipo1";
            this.lblTipo1.Size = new System.Drawing.Size(0, 23);
            this.lblTipo1.TabIndex = 9;
            // 
            // lblCode1
            // 
            this.lblCode1.AutoSize = true;
            this.lblCode1.Location = new System.Drawing.Point(129, 45);
            this.lblCode1.Name = "lblCode1";
            this.lblCode1.Size = new System.Drawing.Size(0, 23);
            this.lblCode1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 26);
            this.label9.TabIndex = 7;
            this.label9.Text = "Cliente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 26);
            this.label8.TabIndex = 6;
            this.label8.Text = "Equipo Asignado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(300, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 26);
            this.label7.TabIndex = 5;
            this.label7.Text = "Hora de Finalización:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Hora de Inicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código:";
            // 
            // dGVConsulta
            // 
            this.dGVConsulta.AllowUserToAddRows = false;
            this.dGVConsulta.AllowUserToDeleteRows = false;
            this.dGVConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEVENTO,
            this.IDCLIENTE,
            this.IDGRUPO,
            this.CODIGOEVENTO,
            this.TIPOE,
            this.FECHAE,
            this.DIRECCIONE,
            this.HDI,
            this.HDF});
            this.dGVConsulta.Location = new System.Drawing.Point(32, 151);
            this.dGVConsulta.Name = "dGVConsulta";
            this.dGVConsulta.ReadOnly = true;
            this.dGVConsulta.Size = new System.Drawing.Size(583, 207);
            this.dGVConsulta.TabIndex = 100;
            this.dGVConsulta.Visible = false;
            // 
            // IDEVENTO
            // 
            this.IDEVENTO.HeaderText = "IDEVENTO";
            this.IDEVENTO.Name = "IDEVENTO";
            this.IDEVENTO.ReadOnly = true;
            this.IDEVENTO.Visible = false;
            // 
            // IDCLIENTE
            // 
            this.IDCLIENTE.HeaderText = "IDCLIENTE";
            this.IDCLIENTE.Name = "IDCLIENTE";
            this.IDCLIENTE.ReadOnly = true;
            this.IDCLIENTE.Visible = false;
            // 
            // IDGRUPO
            // 
            this.IDGRUPO.HeaderText = "IDGRUPO";
            this.IDGRUPO.Name = "IDGRUPO";
            this.IDGRUPO.ReadOnly = true;
            this.IDGRUPO.Visible = false;
            // 
            // CODIGOEVENTO
            // 
            this.CODIGOEVENTO.HeaderText = "Código ";
            this.CODIGOEVENTO.Name = "CODIGOEVENTO";
            this.CODIGOEVENTO.ReadOnly = true;
            // 
            // TIPOE
            // 
            this.TIPOE.HeaderText = "Tipo";
            this.TIPOE.Name = "TIPOE";
            this.TIPOE.ReadOnly = true;
            // 
            // FECHAE
            // 
            this.FECHAE.HeaderText = "Fecha";
            this.FECHAE.Name = "FECHAE";
            this.FECHAE.ReadOnly = true;
            // 
            // DIRECCIONE
            // 
            this.DIRECCIONE.HeaderText = "Dirección";
            this.DIRECCIONE.Name = "DIRECCIONE";
            this.DIRECCIONE.ReadOnly = true;
            // 
            // HDI
            // 
            this.HDI.HeaderText = "Hora de Inicio";
            this.HDI.Name = "HDI";
            this.HDI.ReadOnly = true;
            // 
            // HDF
            // 
            this.HDF.HeaderText = "Hora de Finalización";
            this.HDF.Name = "HDF";
            this.HDF.ReadOnly = true;
            // 
            // BuscarEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(693, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dGVConsulta);
            this.Controls.Add(this.pBoxLimpiar);
            this.Controls.Add(this.pBoxReturn);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BuscarCurso";
            this.Load += new System.EventHandler(this.BuscarEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nombresClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAP_2018DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxReturn1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gBoxDatos.ResumeLayout(false);
            this.gBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pBoxReturn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoB;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.PictureBox pBoxLimpiar;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbTipoa;
        private AAP_2018DataSet aAP_2018DataSet;
        private System.Windows.Forms.BindingSource nombresClienteBindingSource;
        private AAP_2018DataSetTableAdapters.NombresClienteTableAdapter nombresClienteTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBoxReturn1;
        private System.Windows.Forms.GroupBox gBoxDatos;
        private System.Windows.Forms.Label lblIdGrupo;
        private System.Windows.Forms.Label lblIdcliente;
        private System.Windows.Forms.Label lblCliente1;
        private System.Windows.Forms.Label lblEA;
        private System.Windows.Forms.Label lblHDF;
        private System.Windows.Forms.Label lblHDI;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblDate1;
        private System.Windows.Forms.Label lblTipo1;
        private System.Windows.Forms.Label lblCode1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGVConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEVENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDGRUPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOEVENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCIONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDI;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDF;
    }
}