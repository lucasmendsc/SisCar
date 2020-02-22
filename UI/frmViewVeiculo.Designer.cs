namespace UI
{
    partial class frmViewVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewVeiculo));
            this.txtRENAVAM = new System.Windows.Forms.MaskedTextBox();
            this.txtCOR = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbANO_MODELO = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbANO_FABRICACAO = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtOBSERVACOES = new System.Windows.Forms.TextBox();
            this.txtPLACA = new System.Windows.Forms.MaskedTextBox();
            this.txtVERSAO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCOD_MOV_VEICULOS = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btGravar = new System.Windows.Forms.Button();
            this.txtVALOR_ENTRADA = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtResp = new System.Windows.Forms.TextBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.cbMARCA = new System.Windows.Forms.Label();
            this.cbMODELO = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btApagar = new System.Windows.Forms.Button();
            this.lbCustos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRENAVAM
            // 
            this.txtRENAVAM.Location = new System.Drawing.Point(170, 195);
            this.txtRENAVAM.Mask = "0000000000";
            this.txtRENAVAM.Name = "txtRENAVAM";
            this.txtRENAVAM.PromptChar = ' ';
            this.txtRENAVAM.Size = new System.Drawing.Size(93, 20);
            this.txtRENAVAM.TabIndex = 11;
            // 
            // txtCOR
            // 
            this.txtCOR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCOR.Location = new System.Drawing.Point(351, 142);
            this.txtCOR.MaxLength = 20;
            this.txtCOR.Name = "txtCOR";
            this.txtCOR.Size = new System.Drawing.Size(141, 20);
            this.txtCOR.TabIndex = 69;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(348, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 79;
            this.label16.Text = "Cor";
            // 
            // cbANO_MODELO
            // 
            this.cbANO_MODELO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbANO_MODELO.FormattingEnabled = true;
            this.cbANO_MODELO.Items.AddRange(new object[] {
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980"});
            this.cbANO_MODELO.Location = new System.Drawing.Point(170, 142);
            this.cbANO_MODELO.Name = "cbANO_MODELO";
            this.cbANO_MODELO.Size = new System.Drawing.Size(93, 21);
            this.cbANO_MODELO.TabIndex = 68;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(167, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 78;
            this.label15.Text = "Ano Modelo";
            // 
            // cbANO_FABRICACAO
            // 
            this.cbANO_FABRICACAO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbANO_FABRICACAO.FormattingEnabled = true;
            this.cbANO_FABRICACAO.Items.AddRange(new object[] {
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980"});
            this.cbANO_FABRICACAO.Location = new System.Drawing.Point(13, 142);
            this.cbANO_FABRICACAO.Name = "cbANO_FABRICACAO";
            this.cbANO_FABRICACAO.Size = new System.Drawing.Size(93, 21);
            this.cbANO_FABRICACAO.TabIndex = 67;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(178, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 77;
            this.label14.Text = "Modelo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 76;
            this.label13.Text = "Marca";
            // 
            // txtOBSERVACOES
            // 
            this.txtOBSERVACOES.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOBSERVACOES.Location = new System.Drawing.Point(13, 250);
            this.txtOBSERVACOES.MaxLength = 500;
            this.txtOBSERVACOES.Multiline = true;
            this.txtOBSERVACOES.Name = "txtOBSERVACOES";
            this.txtOBSERVACOES.Size = new System.Drawing.Size(644, 72);
            this.txtOBSERVACOES.TabIndex = 72;
            this.txtOBSERVACOES.TextChanged += new System.EventHandler(this.txtOBSERVACOES_TextChanged);
            // 
            // txtPLACA
            // 
            this.txtPLACA.Location = new System.Drawing.Point(13, 195);
            this.txtPLACA.Mask = "AAA-9999";
            this.txtPLACA.Name = "txtPLACA";
            this.txtPLACA.PromptChar = ' ';
            this.txtPLACA.Size = new System.Drawing.Size(93, 20);
            this.txtPLACA.TabIndex = 70;
            // 
            // txtVERSAO
            // 
            this.txtVERSAO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVERSAO.Location = new System.Drawing.Point(351, 91);
            this.txtVERSAO.MaxLength = 20;
            this.txtVERSAO.Name = "txtVERSAO";
            this.txtVERSAO.Size = new System.Drawing.Size(261, 20);
            this.txtVERSAO.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Observações";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 74;
            this.label7.Text = "Placa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(167, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 73;
            this.label9.Text = "RENAVAM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Ano Fabricação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Versão";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtCOD_MOV_VEICULOS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 52);
            this.panel1.TabIndex = 61;
            // 
            // txtCOD_MOV_VEICULOS
            // 
            this.txtCOD_MOV_VEICULOS.Enabled = false;
            this.txtCOD_MOV_VEICULOS.Location = new System.Drawing.Point(16, 22);
            this.txtCOD_MOV_VEICULOS.Mask = "0000000";
            this.txtCOD_MOV_VEICULOS.Name = "txtCOD_MOV_VEICULOS";
            this.txtCOD_MOV_VEICULOS.PromptChar = ' ';
            this.txtCOD_MOV_VEICULOS.Size = new System.Drawing.Size(100, 20);
            this.txtCOD_MOV_VEICULOS.TabIndex = 2;
            this.txtCOD_MOV_VEICULOS.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // btGravar
            // 
            this.btGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGravar.ForeColor = System.Drawing.Color.Green;
            this.btGravar.Location = new System.Drawing.Point(381, 519);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(75, 23);
            this.btGravar.TabIndex = 88;
            this.btGravar.Text = "OK";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // txtVALOR_ENTRADA
            // 
            this.txtVALOR_ENTRADA.Location = new System.Drawing.Point(308, 195);
            this.txtVALOR_ENTRADA.Name = "txtVALOR_ENTRADA";
            this.txtVALOR_ENTRADA.Size = new System.Drawing.Size(111, 20);
            this.txtVALOR_ENTRADA.TabIndex = 91;
            this.txtVALOR_ENTRADA.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(308, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 92;
            this.label11.Text = "Valor Entrada";
            this.label11.Visible = false;
            // 
            // txtDesc
            // 
            this.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesc.Location = new System.Drawing.Point(9, 32);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(258, 20);
            this.txtDesc.TabIndex = 80;
            // 
            // txtResp
            // 
            this.txtResp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtResp.Location = new System.Drawing.Point(273, 32);
            this.txtResp.Name = "txtResp";
            this.txtResp.Size = new System.Drawing.Size(132, 20);
            this.txtResp.TabIndex = 81;
            this.txtResp.TextChanged += new System.EventHandler(this.txtResp_TextChanged);
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(413, 32);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(90, 20);
            this.dtData.TabIndex = 82;
            // 
            // txtValor
            // 
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Location = new System.Drawing.Point(509, 32);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(73, 20);
            this.txtValor.TabIndex = 83;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "Descrição";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(270, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 85;
            this.label6.Text = "Responsavel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(410, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 86;
            this.label8.Text = "Data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(506, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 87;
            this.label10.Text = "Valor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAdicionar);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.dtData);
            this.groupBox1.Controls.Add(this.txtResp);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Location = new System.Drawing.Point(12, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 158);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Custos adicionais";
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(588, 30);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(63, 23);
            this.btAdicionar.TabIndex = 89;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(642, 93);
            this.dataGridView1.TabIndex = 88;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(398, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 13);
            this.label12.TabIndex = 94;
            this.label12.Text = "Valor atual do veiculo:";
            this.label12.Visible = false;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor.Location = new System.Drawing.Point(536, 339);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(127, 13);
            this.lbValor.TabIndex = 95;
            this.lbValor.Text = "                              ";
            this.lbValor.Visible = false;
            // 
            // cbMARCA
            // 
            this.cbMARCA.AutoSize = true;
            this.cbMARCA.Location = new System.Drawing.Point(18, 94);
            this.cbMARCA.Name = "cbMARCA";
            this.cbMARCA.Size = new System.Drawing.Size(70, 13);
            this.cbMARCA.TabIndex = 96;
            this.cbMARCA.Text = "                     ";
            // 
            // cbMODELO
            // 
            this.cbMODELO.AutoSize = true;
            this.cbMODELO.Location = new System.Drawing.Point(185, 94);
            this.cbMODELO.Name = "cbMODELO";
            this.cbMODELO.Size = new System.Drawing.Size(79, 13);
            this.cbMODELO.TabIndex = 97;
            this.cbMODELO.Text = "                        ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(191, 339);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 13);
            this.label17.TabIndex = 98;
            this.label17.Text = "Total de custos:";
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(579, 519);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 90;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btApagar
            // 
            this.btApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApagar.ForeColor = System.Drawing.Color.Red;
            this.btApagar.Location = new System.Drawing.Point(479, 519);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(75, 23);
            this.btApagar.TabIndex = 89;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // lbCustos
            // 
            this.lbCustos.AutoSize = true;
            this.lbCustos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustos.Location = new System.Drawing.Point(294, 339);
            this.lbCustos.Name = "lbCustos";
            this.lbCustos.Size = new System.Drawing.Size(99, 13);
            this.lbCustos.TabIndex = 99;
            this.lbCustos.Text = "                       ";
            // 
            // frmViewVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 554);
            this.Controls.Add(this.lbCustos);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbMODELO);
            this.Controls.Add(this.cbMARCA);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtVALOR_ENTRADA);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.txtRENAVAM);
            this.Controls.Add(this.txtCOR);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbANO_MODELO);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbANO_FABRICACAO);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtOBSERVACOES);
            this.Controls.Add(this.txtPLACA);
            this.Controls.Add(this.txtVERSAO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewVeiculo";
            this.Text = "Veiculo";
            this.Load += new System.EventHandler(this.frmViewVeiculo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtRENAVAM;
        private System.Windows.Forms.TextBox txtCOR;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbANO_MODELO;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbANO_FABRICACAO;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtOBSERVACOES;
        private System.Windows.Forms.MaskedTextBox txtPLACA;
        private System.Windows.Forms.TextBox txtVERSAO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtCOD_MOV_VEICULOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.TextBox txtVALOR_ENTRADA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtResp;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Label cbMARCA;
        private System.Windows.Forms.Label cbMODELO;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Label lbCustos;
    }
}