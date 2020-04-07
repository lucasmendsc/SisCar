namespace UI
{
    partial class frmLembretes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLembretes));
            this.tabControlLembretes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkLembrar = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btFECHAR = new System.Windows.Forms.Button();
            this.btEXCLUIR = new System.Windows.Forms.Button();
            this.btGRAVAR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCOD_LEMBRETE = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lembreteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCONSULTA = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtHora = new System.Windows.Forms.DateTimePicker();
            this.tabControlLembretes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lembreteBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlLembretes
            // 
            this.tabControlLembretes.Controls.Add(this.tabPage1);
            this.tabControlLembretes.Controls.Add(this.tabPage2);
            this.tabControlLembretes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlLembretes.Location = new System.Drawing.Point(0, 0);
            this.tabControlLembretes.Name = "tabControlLembretes";
            this.tabControlLembretes.SelectedIndex = 0;
            this.tabControlLembretes.Size = new System.Drawing.Size(442, 267);
            this.tabControlLembretes.TabIndex = 2;
            this.tabControlLembretes.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkLembrar);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(434, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // chkLembrar
            // 
            this.chkLembrar.AutoSize = true;
            this.chkLembrar.Location = new System.Drawing.Point(378, 67);
            this.chkLembrar.Name = "chkLembrar";
            this.chkLembrar.Size = new System.Drawing.Size(15, 14);
            this.chkLembrar.TabIndex = 18;
            this.chkLembrar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(310, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Lembrar";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.richTextBox1.Location = new System.Drawing.Point(6, 84);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(419, 107);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.btFECHAR);
            this.panel2.Controls.Add(this.btEXCLUIR);
            this.panel2.Controls.Add(this.btGRAVAR);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 197);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(6);
            this.panel2.Size = new System.Drawing.Size(428, 41);
            this.panel2.TabIndex = 15;
            this.panel2.TabStop = true;
            // 
            // btFECHAR
            // 
            this.btFECHAR.Dock = System.Windows.Forms.DockStyle.Right;
            this.btFECHAR.Image = ((System.Drawing.Image)(resources.GetObject("btFECHAR.Image")));
            this.btFECHAR.Location = new System.Drawing.Point(347, 6);
            this.btFECHAR.Name = "btFECHAR";
            this.btFECHAR.Size = new System.Drawing.Size(75, 29);
            this.btFECHAR.TabIndex = 2;
            this.btFECHAR.Text = "&Fechar";
            this.btFECHAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btFECHAR.UseVisualStyleBackColor = true;
            this.btFECHAR.Click += new System.EventHandler(this.btFECHAR_Click);
            // 
            // btEXCLUIR
            // 
            this.btEXCLUIR.Dock = System.Windows.Forms.DockStyle.Left;
            this.btEXCLUIR.Enabled = false;
            this.btEXCLUIR.Image = ((System.Drawing.Image)(resources.GetObject("btEXCLUIR.Image")));
            this.btEXCLUIR.Location = new System.Drawing.Point(81, 6);
            this.btEXCLUIR.Name = "btEXCLUIR";
            this.btEXCLUIR.Size = new System.Drawing.Size(75, 29);
            this.btEXCLUIR.TabIndex = 1;
            this.btEXCLUIR.Text = "&Excluir";
            this.btEXCLUIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEXCLUIR.UseVisualStyleBackColor = true;
            this.btEXCLUIR.Click += new System.EventHandler(this.btEXCLUIR_Click);
            // 
            // btGRAVAR
            // 
            this.btGRAVAR.Dock = System.Windows.Forms.DockStyle.Left;
            this.btGRAVAR.Image = ((System.Drawing.Image)(resources.GetObject("btGRAVAR.Image")));
            this.btGRAVAR.Location = new System.Drawing.Point(6, 6);
            this.btGRAVAR.Name = "btGRAVAR";
            this.btGRAVAR.Size = new System.Drawing.Size(75, 29);
            this.btGRAVAR.TabIndex = 0;
            this.btGRAVAR.Text = "&Gravar";
            this.btGRAVAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btGRAVAR.UseVisualStyleBackColor = true;
            this.btGRAVAR.Click += new System.EventHandler(this.btGRAVAR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lembrete";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtHora);
            this.panel1.Controls.Add(this.txtCOD_LEMBRETE);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 52);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(343, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Data";
            // 
            // txtCOD_LEMBRETE
            // 
            this.txtCOD_LEMBRETE.Enabled = false;
            this.txtCOD_LEMBRETE.Location = new System.Drawing.Point(5, 22);
            this.txtCOD_LEMBRETE.Mask = "00000";
            this.txtCOD_LEMBRETE.Name = "txtCOD_LEMBRETE";
            this.txtCOD_LEMBRETE.PromptChar = ' ';
            this.txtCOD_LEMBRETE.Size = new System.Drawing.Size(100, 20);
            this.txtCOD_LEMBRETE.TabIndex = 2;
            this.txtCOD_LEMBRETE.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(434, 241);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.descricaoDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.Status});
            this.dataGridView1.DataSource = this.lembreteBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 48);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(428, 190);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 30;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.Width = 250;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Ativo";
            this.Status.Name = "Status";
            this.Status.Width = 56;
            // 
            // lembreteBindingSource
            // 
            this.lembreteBindingSource.DataSource = typeof(Models.Lembrete);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtCONSULTA);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(428, 45);
            this.panel3.TabIndex = 0;
            // 
            // txtCONSULTA
            // 
            this.txtCONSULTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCONSULTA.Location = new System.Drawing.Point(173, 12);
            this.txtCONSULTA.Name = "txtCONSULTA";
            this.txtCONSULTA.Size = new System.Drawing.Size(250, 20);
            this.txtCONSULTA.TabIndex = 1;
            this.txtCONSULTA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCONSULTA_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Digite a descrição para consulta:";
            // 
            // dtHora
            // 
            this.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHora.Location = new System.Drawing.Point(342, 22);
            this.dtHora.Name = "dtHora";
            this.dtHora.Size = new System.Drawing.Size(79, 20);
            this.dtHora.TabIndex = 18;
            // 
            // frmLembretes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(442, 267);
            this.Controls.Add(this.tabControlLembretes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLembretes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lembretes";
            this.Load += new System.EventHandler(this.frmLembretes_Load);
            this.tabControlLembretes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lembreteBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlLembretes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btFECHAR;
        private System.Windows.Forms.Button btEXCLUIR;
        private System.Windows.Forms.Button btGRAVAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtCOD_LEMBRETE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCONSULTA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkLembrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource lembreteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DateTimePicker dtHora;
    }
}