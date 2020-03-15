namespace UI
{
    partial class frmCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixa));
            this.dataGridLanc = new System.Windows.Forms.DataGridView();
            this.btAbrirCaixa = new System.Windows.Forms.Button();
            this.btEntrada = new System.Windows.Forms.Button();
            this.btImprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbOperador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDataCaixa = new System.Windows.Forms.Label();
            this.btFecharCaixa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.lbSituacaoA = new System.Windows.Forms.Label();
            this.lbSituacaoF = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSaldoInicial = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLanc)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridLanc
            // 
            this.dataGridLanc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLanc.Location = new System.Drawing.Point(12, 78);
            this.dataGridLanc.Name = "dataGridLanc";
            this.dataGridLanc.Size = new System.Drawing.Size(645, 299);
            this.dataGridLanc.TabIndex = 0;
            this.dataGridLanc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridLanc.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridLanc_CellFormatting);
            // 
            // btAbrirCaixa
            // 
            this.btAbrirCaixa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAbrirCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbrirCaixa.Image = ((System.Drawing.Image)(resources.GetObject("btAbrirCaixa.Image")));
            this.btAbrirCaixa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAbrirCaixa.Location = new System.Drawing.Point(712, 78);
            this.btAbrirCaixa.Name = "btAbrirCaixa";
            this.btAbrirCaixa.Size = new System.Drawing.Size(75, 71);
            this.btAbrirCaixa.TabIndex = 1;
            this.btAbrirCaixa.Text = "&ABRIR CAIXA";
            this.btAbrirCaixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAbrirCaixa.UseVisualStyleBackColor = false;
            this.btAbrirCaixa.Click += new System.EventHandler(this.btAbrirCaixa_Click);
            // 
            // btEntrada
            // 
            this.btEntrada.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEntrada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btEntrada.Image")));
            this.btEntrada.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEntrada.Location = new System.Drawing.Point(712, 155);
            this.btEntrada.Name = "btEntrada";
            this.btEntrada.Size = new System.Drawing.Size(75, 71);
            this.btEntrada.TabIndex = 2;
            this.btEntrada.Text = "INCLUIR";
            this.btEntrada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEntrada.UseVisualStyleBackColor = false;
            this.btEntrada.Click += new System.EventHandler(this.btEntrada_Click);
            // 
            // btImprimir
            // 
            this.btImprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btImprimir.Image")));
            this.btImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btImprimir.Location = new System.Drawing.Point(713, 310);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(75, 71);
            this.btImprimir.TabIndex = 3;
            this.btImprimir.Text = "RELATÓRIOS";
            this.btImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btImprimir.UseVisualStyleBackColor = false;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Operador:";
            // 
            // lbOperador
            // 
            this.lbOperador.BackColor = System.Drawing.Color.Transparent;
            this.lbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperador.Location = new System.Drawing.Point(121, 35);
            this.lbOperador.Name = "lbOperador";
            this.lbOperador.Size = new System.Drawing.Size(273, 25);
            this.lbOperador.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "DATA:";
            // 
            // lbDataCaixa
            // 
            this.lbDataCaixa.BackColor = System.Drawing.Color.Transparent;
            this.lbDataCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataCaixa.ForeColor = System.Drawing.Color.Navy;
            this.lbDataCaixa.Location = new System.Drawing.Point(75, 412);
            this.lbDataCaixa.Name = "lbDataCaixa";
            this.lbDataCaixa.Size = new System.Drawing.Size(133, 23);
            this.lbDataCaixa.TabIndex = 7;
            // 
            // btFecharCaixa
            // 
            this.btFecharCaixa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btFecharCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFecharCaixa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btFecharCaixa.Image = ((System.Drawing.Image)(resources.GetObject("btFecharCaixa.Image")));
            this.btFecharCaixa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btFecharCaixa.Location = new System.Drawing.Point(712, 232);
            this.btFecharCaixa.Name = "btFecharCaixa";
            this.btFecharCaixa.Size = new System.Drawing.Size(75, 72);
            this.btFecharCaixa.TabIndex = 8;
            this.btFecharCaixa.Text = "FECHAR CAIXA";
            this.btFecharCaixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btFecharCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btFecharCaixa.UseVisualStyleBackColor = false;
            this.btFecharCaixa.Click += new System.EventHandler(this.btFecharCaixa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(488, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "SALDO ATUAL:  R$";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbSaldo
            // 
            this.lbSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lbSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaldo.ForeColor = System.Drawing.Color.Navy;
            this.lbSaldo.Location = new System.Drawing.Point(653, 412);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(141, 23);
            this.lbSaldo.TabIndex = 10;
            // 
            // lbSituacaoA
            // 
            this.lbSituacaoA.AutoSize = true;
            this.lbSituacaoA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbSituacaoA.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSituacaoA.ForeColor = System.Drawing.Color.Green;
            this.lbSituacaoA.Location = new System.Drawing.Point(630, 24);
            this.lbSituacaoA.Name = "lbSituacaoA";
            this.lbSituacaoA.Size = new System.Drawing.Size(154, 37);
            this.lbSituacaoA.TabIndex = 11;
            this.lbSituacaoA.Text = "ABERTO";
            this.lbSituacaoA.Visible = false;
            // 
            // lbSituacaoF
            // 
            this.lbSituacaoF.AutoSize = true;
            this.lbSituacaoF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbSituacaoF.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSituacaoF.ForeColor = System.Drawing.Color.Maroon;
            this.lbSituacaoF.Location = new System.Drawing.Point(606, 23);
            this.lbSituacaoF.Name = "lbSituacaoF";
            this.lbSituacaoF.Size = new System.Drawing.Size(182, 37);
            this.lbSituacaoF.TabIndex = 12;
            this.lbSituacaoF.Text = "FECHADO";
            this.lbSituacaoF.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "SALDO INICIAL R$";
            // 
            // lbSaldoInicial
            // 
            this.lbSaldoInicial.BackColor = System.Drawing.Color.Transparent;
            this.lbSaldoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaldoInicial.ForeColor = System.Drawing.Color.Navy;
            this.lbSaldoInicial.Location = new System.Drawing.Point(376, 412);
            this.lbSaldoInicial.Name = "lbSaldoInicial";
            this.lbSaldoInicial.Size = new System.Drawing.Size(100, 23);
            this.lbSaldoInicial.TabIndex = 14;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSaldoInicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSituacaoF);
            this.Controls.Add(this.lbSituacaoA);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btFecharCaixa);
            this.Controls.Add(this.lbDataCaixa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbOperador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.btEntrada);
            this.Controls.Add(this.btAbrirCaixa);
            this.Controls.Add(this.dataGridLanc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de caixa";
            this.Load += new System.EventHandler(this.frmCaixa_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmCaixa_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLanc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridLanc;
        private System.Windows.Forms.Button btAbrirCaixa;
        private System.Windows.Forms.Button btEntrada;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbOperador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDataCaixa;
        private System.Windows.Forms.Button btFecharCaixa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.Label lbSituacaoA;
        private System.Windows.Forms.Label lbSituacaoF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSaldoInicial;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}