namespace UI
{
    partial class frmLancamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLancamento));
            this.label1 = new System.Windows.Forms.Label();
            this.rbEntrada = new System.Windows.Forms.RadioButton();
            this.rbSaida = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btConcluir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtLanc = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.edtPlaca = new System.Windows.Forms.TextBox();
            this.chkLoja = new System.Windows.Forms.CheckBox();
            this.chkVeiculo = new System.Windows.Forms.CheckBox();
            this.lbResponsavel = new System.Windows.Forms.Label();
            this.edtResponsavel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo:";
            // 
            // rbEntrada
            // 
            this.rbEntrada.AutoSize = true;
            this.rbEntrada.Location = new System.Drawing.Point(78, 13);
            this.rbEntrada.Name = "rbEntrada";
            this.rbEntrada.Size = new System.Drawing.Size(62, 17);
            this.rbEntrada.TabIndex = 1;
            this.rbEntrada.TabStop = true;
            this.rbEntrada.Text = "Entrada";
            this.rbEntrada.UseVisualStyleBackColor = true;
            this.rbEntrada.CheckedChanged += new System.EventHandler(this.rbEntrada_CheckedChanged);
            // 
            // rbSaida
            // 
            this.rbSaida.AutoSize = true;
            this.rbSaida.Location = new System.Drawing.Point(156, 13);
            this.rbSaida.Name = "rbSaida";
            this.rbSaida.Size = new System.Drawing.Size(52, 17);
            this.rbSaida.TabIndex = 2;
            this.rbSaida.TabStop = true;
            this.rbSaida.Text = "Saida";
            this.rbSaida.UseVisualStyleBackColor = true;
            this.rbSaida.CheckedChanged += new System.EventHandler(this.rbSaida_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.Snow;
            this.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(96, 86);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(457, 23);
            this.txtDesc.TabIndex = 4;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.Snow;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(277, 130);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 8;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // btConcluir
            // 
            this.btConcluir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btConcluir.Image = ((System.Drawing.Image)(resources.GetObject("btConcluir.Image")));
            this.btConcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btConcluir.Location = new System.Drawing.Point(395, 188);
            this.btConcluir.Name = "btConcluir";
            this.btConcluir.Size = new System.Drawing.Size(75, 71);
            this.btConcluir.TabIndex = 9;
            this.btConcluir.Text = "CONCLUIR";
            this.btConcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btConcluir.UseVisualStyleBackColor = false;
            this.btConcluir.Click += new System.EventHandler(this.btConcluir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancelar.Location = new System.Drawing.Point(493, 188);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 71);
            this.btCancelar.TabIndex = 10;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 50);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // dtLanc
            // 
            this.dtLanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtLanc.Location = new System.Drawing.Point(65, 133);
            this.dtLanc.Name = "dtLanc";
            this.dtLanc.Size = new System.Drawing.Size(149, 23);
            this.dtLanc.TabIndex = 12;
            this.dtLanc.Text = "label5";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(14, 51);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(78, 17);
            this.lbCategoria.TabIndex = 13;
            this.lbCategoria.Text = "Categoria";
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaca.Location = new System.Drawing.Point(392, 133);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(48, 17);
            this.lbPlaca.TabIndex = 16;
            this.lbPlaca.Text = "Placa";
            this.lbPlaca.Click += new System.EventHandler(this.label6_Click);
            // 
            // edtPlaca
            // 
            this.edtPlaca.BackColor = System.Drawing.Color.Snow;
            this.edtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtPlaca.Location = new System.Drawing.Point(444, 130);
            this.edtPlaca.Name = "edtPlaca";
            this.edtPlaca.Size = new System.Drawing.Size(100, 23);
            this.edtPlaca.TabIndex = 17;
            // 
            // chkLoja
            // 
            this.chkLoja.AutoSize = true;
            this.chkLoja.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.chkLoja.Location = new System.Drawing.Point(98, 52);
            this.chkLoja.Name = "chkLoja";
            this.chkLoja.Size = new System.Drawing.Size(124, 20);
            this.chkLoja.TabIndex = 18;
            this.chkLoja.Text = "Lançamentos loja";
            this.chkLoja.UseVisualStyleBackColor = true;
            this.chkLoja.CheckedChanged += new System.EventHandler(this.chkLoja_CheckedChanged_1);
            // 
            // chkVeiculo
            // 
            this.chkVeiculo.AutoSize = true;
            this.chkVeiculo.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.chkVeiculo.Location = new System.Drawing.Point(228, 52);
            this.chkVeiculo.Name = "chkVeiculo";
            this.chkVeiculo.Size = new System.Drawing.Size(179, 20);
            this.chkVeiculo.TabIndex = 19;
            this.chkVeiculo.Text = "Lançamentos para veiculos";
            this.chkVeiculo.UseVisualStyleBackColor = true;
            this.chkVeiculo.CheckedChanged += new System.EventHandler(this.chkVeiculo_CheckedChanged_1);
            // 
            // lbResponsavel
            // 
            this.lbResponsavel.AutoSize = true;
            this.lbResponsavel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lbResponsavel.Location = new System.Drawing.Point(9, 178);
            this.lbResponsavel.Name = "lbResponsavel";
            this.lbResponsavel.Size = new System.Drawing.Size(84, 17);
            this.lbResponsavel.TabIndex = 20;
            this.lbResponsavel.Text = "Responsável";
            this.lbResponsavel.Visible = false;
            // 
            // edtResponsavel
            // 
            this.edtResponsavel.Location = new System.Drawing.Point(100, 178);
            this.edtResponsavel.Name = "edtResponsavel";
            this.edtResponsavel.Size = new System.Drawing.Size(150, 20);
            this.edtResponsavel.TabIndex = 21;
            this.edtResponsavel.Visible = false;
            // 
            // frmLancamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(577, 271);
            this.Controls.Add(this.edtResponsavel);
            this.Controls.Add(this.lbResponsavel);
            this.Controls.Add(this.chkVeiculo);
            this.Controls.Add(this.chkLoja);
            this.Controls.Add(this.edtPlaca);
            this.Controls.Add(this.lbPlaca);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.dtLanc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btConcluir);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbSaida);
            this.Controls.Add(this.rbEntrada);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLancamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lançamentos Caixa";
            this.Load += new System.EventHandler(this.frmLancamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbEntrada;
        private System.Windows.Forms.RadioButton rbSaida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btConcluir;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label dtLanc;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.TextBox edtPlaca;
        private System.Windows.Forms.CheckBox chkLoja;
        private System.Windows.Forms.CheckBox chkVeiculo;
        private System.Windows.Forms.Label lbResponsavel;
        private System.Windows.Forms.TextBox edtResponsavel;
    }
}