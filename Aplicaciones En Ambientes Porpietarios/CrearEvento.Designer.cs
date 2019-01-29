namespace Aplicaciones_En_Ambientes_Porpietarios
{
    partial class CrearEvento
    {
        public static CrearEvento crearCursoInstance = null;
        public static CrearEvento Instance()
        {
            if (((crearCursoInstance == null) || (crearCursoInstance.IsDisposed == true)))
            {
                crearCursoInstance = new CrearEvento();
            }
            crearCursoInstance.BringToFront();
            return crearCursoInstance;
        }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearEvento));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dTPDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pBoxReturn = new System.Windows.Forms.PictureBox();
            this.pBoxLimpiar = new System.Windows.Forms.PictureBox();
            this.pBoxSave = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblEDTrabajo = new System.Windows.Forms.Label();
            this.lblHF = new System.Windows.Forms.Label();
            this.lblHI = new System.Windows.Forms.Label();
            this.lblAddresss = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblcode = new System.Windows.Forms.Label();
            this.txtCodeEvent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pBoxClient = new System.Windows.Forms.PictureBox();
            this.pBoxEDT = new System.Windows.Forms.PictureBox();
            this.cmbCli = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEDT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTPHI = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dTPHDF2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.aAP_2018DataSet1 = new Aplicaciones_En_Ambientes_Porpietarios.AAP_2018DataSet1();
            this.gRUPOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gRUPOTableAdapter = new Aplicaciones_En_Ambientes_Porpietarios.AAP_2018DataSet1TableAdapters.GRUPOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSave)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxEDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAP_2018DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRUPOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hora de Finalización:";
            // 
            // dTPDate
            // 
            this.dTPDate.CustomFormat = "yyyy-MM-dd";
            this.dTPDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPDate.Location = new System.Drawing.Point(122, 99);
            this.dTPDate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dTPDate.Name = "dTPDate";
            this.dTPDate.Size = new System.Drawing.Size(137, 30);
            this.dTPDate.TabIndex = 5;
            this.dTPDate.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dTPDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(9, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Dirección:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(9, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Hora de Inicio:";
            // 
            // pBoxReturn
            // 
            this.pBoxReturn.BackColor = System.Drawing.Color.Transparent;
            this.pBoxReturn.Image = ((System.Drawing.Image)(resources.GetObject("pBoxReturn.Image")));
            this.pBoxReturn.Location = new System.Drawing.Point(668, 420);
            this.pBoxReturn.Name = "pBoxReturn";
            this.pBoxReturn.Size = new System.Drawing.Size(73, 49);
            this.pBoxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxReturn.TabIndex = 69;
            this.pBoxReturn.TabStop = false;
            this.pBoxReturn.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pBoxReturn.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.pBoxReturn.MouseHover += new System.EventHandler(this.pictureBox4_MouseHover);
            // 
            // pBoxLimpiar
            // 
            this.pBoxLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.pBoxLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("pBoxLimpiar.Image")));
            this.pBoxLimpiar.Location = new System.Drawing.Point(372, 420);
            this.pBoxLimpiar.Name = "pBoxLimpiar";
            this.pBoxLimpiar.Size = new System.Drawing.Size(73, 49);
            this.pBoxLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxLimpiar.TabIndex = 68;
            this.pBoxLimpiar.TabStop = false;
            this.pBoxLimpiar.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pBoxLimpiar.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pBoxLimpiar.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // pBoxSave
            // 
            this.pBoxSave.BackColor = System.Drawing.Color.Transparent;
            this.pBoxSave.Image = ((System.Drawing.Image)(resources.GetObject("pBoxSave.Image")));
            this.pBoxSave.Location = new System.Drawing.Point(66, 420);
            this.pBoxSave.Name = "pBoxSave";
            this.pBoxSave.Size = new System.Drawing.Size(73, 49);
            this.pBoxSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxSave.TabIndex = 67;
            this.pBoxSave.TabStop = false;
            this.pBoxSave.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pBoxSave.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pBoxSave.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblClient);
            this.groupBox2.Controls.Add(this.lblEDTrabajo);
            this.groupBox2.Controls.Add(this.lblHF);
            this.groupBox2.Controls.Add(this.lblHI);
            this.groupBox2.Controls.Add(this.lblAddresss);
            this.groupBox2.Controls.Add(this.lblDate);
            this.groupBox2.Controls.Add(this.lblTipo);
            this.groupBox2.Controls.Add(this.lblcode);
            this.groupBox2.Controls.Add(this.txtCodeEvent);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pBoxClient);
            this.groupBox2.Controls.Add(this.pBoxEDT);
            this.groupBox2.Controls.Add(this.cmbCli);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbEDT);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTPHI);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.cmbTipo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dTPDate);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dTPHDF2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(68, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(673, 366);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            this.groupBox2.UseCompatibleTextRendering = true;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.BackColor = System.Drawing.Color.DarkRed;
            this.lblClient.ForeColor = System.Drawing.Color.White;
            this.lblClient.Location = new System.Drawing.Point(366, 310);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(173, 23);
            this.lblClient.TabIndex = 94;
            this.lblClient.Text = "Error, Escoja una opción";
            this.lblClient.Visible = false;
            // 
            // lblEDTrabajo
            // 
            this.lblEDTrabajo.AutoSize = true;
            this.lblEDTrabajo.BackColor = System.Drawing.Color.DarkRed;
            this.lblEDTrabajo.ForeColor = System.Drawing.Color.White;
            this.lblEDTrabajo.Location = new System.Drawing.Point(364, 265);
            this.lblEDTrabajo.Name = "lblEDTrabajo";
            this.lblEDTrabajo.Size = new System.Drawing.Size(173, 23);
            this.lblEDTrabajo.TabIndex = 99;
            this.lblEDTrabajo.Text = "Error, Escoja una opción";
            this.lblEDTrabajo.Visible = false;
            // 
            // lblHF
            // 
            this.lblHF.AutoSize = true;
            this.lblHF.BackColor = System.Drawing.Color.DarkRed;
            this.lblHF.ForeColor = System.Drawing.Color.White;
            this.lblHF.Location = new System.Drawing.Point(288, 212);
            this.lblHF.Name = "lblHF";
            this.lblHF.Size = new System.Drawing.Size(369, 23);
            this.lblHF.TabIndex = 97;
            this.lblHF.Text = "Error, Ingrese una hora entre las 7 hasta las 00 horas";
            this.lblHF.Visible = false;
            // 
            // lblHI
            // 
            this.lblHI.AutoSize = true;
            this.lblHI.BackColor = System.Drawing.Color.DarkRed;
            this.lblHI.ForeColor = System.Drawing.Color.White;
            this.lblHI.Location = new System.Drawing.Point(291, 178);
            this.lblHI.Name = "lblHI";
            this.lblHI.Size = new System.Drawing.Size(369, 23);
            this.lblHI.TabIndex = 96;
            this.lblHI.Text = "Error, Ingrese una hora entre las 6 hasta las 20 horas";
            this.lblHI.Visible = false;
            // 
            // lblAddresss
            // 
            this.lblAddresss.AutoSize = true;
            this.lblAddresss.BackColor = System.Drawing.Color.DarkRed;
            this.lblAddresss.ForeColor = System.Drawing.Color.White;
            this.lblAddresss.Location = new System.Drawing.Point(342, 138);
            this.lblAddresss.Name = "lblAddresss";
            this.lblAddresss.Size = new System.Drawing.Size(243, 23);
            this.lblAddresss.TabIndex = 95;
            this.lblAddresss.Text = "Error, Ingrese una dirección valida";
            this.lblAddresss.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.DarkRed;
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(261, 99);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(305, 23);
            this.lblDate.TabIndex = 94;
            this.lblDate.Text = "Error, Escoja una fecha posterior a la actual";
            this.lblDate.Visible = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.DarkRed;
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(300, 62);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(173, 23);
            this.lblTipo.TabIndex = 93;
            this.lblTipo.Text = "Error, Escoja una opción";
            this.lblTipo.Visible = false;
            // 
            // lblcode
            // 
            this.lblcode.AutoSize = true;
            this.lblcode.BackColor = System.Drawing.Color.DarkRed;
            this.lblcode.ForeColor = System.Drawing.Color.White;
            this.lblcode.Location = new System.Drawing.Point(298, 26);
            this.lblcode.Name = "lblcode";
            this.lblcode.Size = new System.Drawing.Size(237, 23);
            this.lblcode.TabIndex = 92;
            this.lblcode.Text = "Error, Ingrese el código del evento";
            this.lblcode.Visible = false;
            // 
            // txtCodeEvent
            // 
            this.txtCodeEvent.Location = new System.Drawing.Point(122, 26);
            this.txtCodeEvent.Name = "txtCodeEvent";
            this.txtCodeEvent.Size = new System.Drawing.Size(176, 30);
            this.txtCodeEvent.TabIndex = 91;
            this.txtCodeEvent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeEvent_KeyPress);
            this.txtCodeEvent.MouseEnter += new System.EventHandler(this.txtCodeEvent_MouseEnter);
            this.txtCodeEvent.MouseLeave += new System.EventHandler(this.txtCodeEvent_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(9, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 23);
            this.label5.TabIndex = 90;
            this.label5.Text = "Código:";
            // 
            // pBoxClient
            // 
            this.pBoxClient.BackColor = System.Drawing.Color.Transparent;
            this.pBoxClient.Image = ((System.Drawing.Image)(resources.GetObject("pBoxClient.Image")));
            this.pBoxClient.Location = new System.Drawing.Point(543, 309);
            this.pBoxClient.Name = "pBoxClient";
            this.pBoxClient.Size = new System.Drawing.Size(40, 32);
            this.pBoxClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxClient.TabIndex = 89;
            this.pBoxClient.TabStop = false;
            this.pBoxClient.MouseLeave += new System.EventHandler(this.pBoxClient_MouseLeave);
            this.pBoxClient.MouseHover += new System.EventHandler(this.pictureBox6_MouseHover_1);
            // 
            // pBoxEDT
            // 
            this.pBoxEDT.BackColor = System.Drawing.Color.Transparent;
            this.pBoxEDT.Image = ((System.Drawing.Image)(resources.GetObject("pBoxEDT.Image")));
            this.pBoxEDT.Location = new System.Drawing.Point(543, 262);
            this.pBoxEDT.Name = "pBoxEDT";
            this.pBoxEDT.Size = new System.Drawing.Size(40, 31);
            this.pBoxEDT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxEDT.TabIndex = 88;
            this.pBoxEDT.TabStop = false;
            this.pBoxEDT.MouseLeave += new System.EventHandler(this.pBoxEDT_MouseLeave);
            this.pBoxEDT.MouseHover += new System.EventHandler(this.pBoxEDT_MouseHover);
            // 
            // cmbCli
            // 
            this.cmbCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCli.FormattingEnabled = true;
            this.cmbCli.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmbCli.Location = new System.Drawing.Point(272, 310);
            this.cmbCli.Name = "cmbCli";
            this.cmbCli.Size = new System.Drawing.Size(268, 31);
            this.cmbCli.TabIndex = 87;
            this.cmbCli.MouseEnter += new System.EventHandler(this.cmbCli_MouseEnter);
            this.cmbCli.MouseLeave += new System.EventHandler(this.cmbCli_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 86;
            this.label4.Text = "Cliente:";
            // 
            // cmbEDT
            // 
            this.cmbEDT.DataSource = this.gRUPOBindingSource;
            this.cmbEDT.DisplayMember = "NOMBREG";
            this.cmbEDT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEDT.FormattingEnabled = true;
            this.cmbEDT.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmbEDT.Location = new System.Drawing.Point(272, 262);
            this.cmbEDT.Name = "cmbEDT";
            this.cmbEDT.Size = new System.Drawing.Size(265, 31);
            this.cmbEDT.TabIndex = 85;
            this.cmbEDT.ValueMember = "COORDINADORG";
            this.cmbEDT.MouseEnter += new System.EventHandler(this.cmbEDT_MouseEnter);
            this.cmbEDT.MouseLeave += new System.EventHandler(this.cmbEDT_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 84;
            this.label1.Text = "Equipo de Trabajo:";
            // 
            // dateTPHI
            // 
            this.dateTPHI.CustomFormat = "HH:mm ";
            this.dateTPHI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTPHI.Location = new System.Drawing.Point(172, 178);
            this.dateTPHI.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateTPHI.Name = "dateTPHI";
            this.dateTPHI.ShowUpDown = true;
            this.dateTPHI.Size = new System.Drawing.Size(119, 30);
            this.dateTPHI.TabIndex = 83;
            this.dateTPHI.Value = new System.DateTime(2019, 1, 1, 6, 0, 0, 0);
            this.dateTPHI.MouseEnter += new System.EventHandler(this.dateTPHI_MouseEnter);
            this.dateTPHI.MouseLeave += new System.EventHandler(this.dateTPHI_MouseLeave);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 138);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(419, 30);
            this.txtAddress.TabIndex = 79;
            this.txtAddress.MouseEnter += new System.EventHandler(this.textBox2_MouseEnter);
            this.txtAddress.MouseLeave += new System.EventHandler(this.txtAddress_MouseLeave);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Boda",
            "Bautizo",
            "Confirmación",
            "Primera Comunión",
            "Graduación",
            "Otros"});
            this.cmbTipo.Location = new System.Drawing.Point(121, 62);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(178, 31);
            this.cmbTipo.TabIndex = 76;
            this.cmbTipo.MouseEnter += new System.EventHandler(this.comboBox5_MouseEnter);
            this.cmbTipo.MouseLeave += new System.EventHandler(this.comboBox5_MouseLeave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 23);
            this.label10.TabIndex = 75;
            this.label10.Text = "Tipo:";
            // 
            // dTPHDF2
            // 
            this.dTPHDF2.CustomFormat = "HH:mm";
            this.dTPHDF2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPHDF2.Location = new System.Drawing.Point(172, 211);
            this.dTPHDF2.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dTPHDF2.Name = "dTPHDF2";
            this.dTPHDF2.ShowUpDown = true;
            this.dTPHDF2.Size = new System.Drawing.Size(116, 30);
            this.dTPHDF2.TabIndex = 100;
            this.dTPHDF2.Value = new System.DateTime(2019, 1, 1, 7, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(279, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 47);
            this.label8.TabIndex = 71;
            this.label8.Text = "Registro de Evento";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // aAP_2018DataSet1
            // 
            this.aAP_2018DataSet1.DataSetName = "AAP_2018DataSet1";
            this.aAP_2018DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gRUPOBindingSource
            // 
            this.gRUPOBindingSource.DataMember = "GRUPO";
            this.gRUPOBindingSource.DataSource = this.aAP_2018DataSet1;
            // 
            // gRUPOTableAdapter
            // 
            this.gRUPOTableAdapter.ClearBeforeFill = true;
            // 
            // CrearEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 495);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pBoxReturn);
            this.Controls.Add(this.pBoxLimpiar);
            this.Controls.Add(this.pBoxSave);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearCurso";
            this.Load += new System.EventHandler(this.CrearEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSave)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxEDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAP_2018DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRUPOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dTPDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pBoxReturn;
        private System.Windows.Forms.PictureBox pBoxLimpiar;
        private System.Windows.Forms.PictureBox pBoxSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmbEDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTPHI;
        private System.Windows.Forms.PictureBox pBoxClient;
        private System.Windows.Forms.PictureBox pBoxEDT;
        private System.Windows.Forms.ComboBox cmbCli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodeEvent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblcode;
        private System.Windows.Forms.Label lblAddresss;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblHI;
        private System.Windows.Forms.Label lblHF;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblEDTrabajo;
        private System.Windows.Forms.DateTimePicker dTPHDF2;
        private System.Windows.Forms.ToolTip toolTip1;
        private AAP_2018DataSet1 aAP_2018DataSet1;
        private System.Windows.Forms.BindingSource gRUPOBindingSource;
        private AAP_2018DataSet1TableAdapters.GRUPOTableAdapter gRUPOTableAdapter;
    }
}