namespace UI
{
    partial class frmFecharCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFecharCaixa));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btConcluir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCaixa = new System.Windows.Forms.Label();
            this.lbSaldoTot = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSaldoFin = new System.Windows.Forms.Label();
            this.txtSangria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CAIXA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "SALDO CAIXA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "DATA";
            // 
            // btConcluir
            // 
            this.btConcluir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btConcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConcluir.Image = ((System.Drawing.Image)(resources.GetObject("btConcluir.Image")));
            this.btConcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btConcluir.Location = new System.Drawing.Point(154, 193);
            this.btConcluir.Name = "btConcluir";
            this.btConcluir.Size = new System.Drawing.Size(84, 71);
            this.btConcluir.TabIndex = 7;
            this.btConcluir.Text = "CONFIRMAR";
            this.btConcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btConcluir.UseVisualStyleBackColor = false;
            this.btConcluir.Click += new System.EventHandler(this.btConcluir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancelar.Location = new System.Drawing.Point(244, 193);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(84, 71);
            this.btCancelar.TabIndex = 8;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 50);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "SANGRIA";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbCaixa
            // 
            this.lbCaixa.AutoSize = true;
            this.lbCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCaixa.Location = new System.Drawing.Point(129, 30);
            this.lbCaixa.Name = "lbCaixa";
            this.lbCaixa.Size = new System.Drawing.Size(67, 20);
            this.lbCaixa.TabIndex = 16;
            this.lbCaixa.Text = "lbCaixa";
            // 
            // lbSaldoTot
            // 
            this.lbSaldoTot.AutoSize = true;
            this.lbSaldoTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaldoTot.Location = new System.Drawing.Point(129, 65);
            this.lbSaldoTot.Name = "lbSaldoTot";
            this.lbSaldoTot.Size = new System.Drawing.Size(95, 20);
            this.lbSaldoTot.TabIndex = 17;
            this.lbSaldoTot.Text = "lbSaldoTot";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(134, 166);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(62, 20);
            this.lbData.TabIndex = 18;
            this.lbData.Text = "lbData";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "SALDO";
            // 
            // lbSaldoFin
            // 
            this.lbSaldoFin.AutoSize = true;
            this.lbSaldoFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaldoFin.Location = new System.Drawing.Point(134, 133);
            this.lbSaldoFin.Name = "lbSaldoFin";
            this.lbSaldoFin.Size = new System.Drawing.Size(94, 20);
            this.lbSaldoFin.TabIndex = 20;
            this.lbSaldoFin.Text = "lbSaldoFin";
            // 
            // txtSangria
            // 
            this.txtSangria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSangria.Location = new System.Drawing.Point(133, 93);
            this.txtSangria.Name = "txtSangria";
            this.txtSangria.Size = new System.Drawing.Size(100, 26);
            this.txtSangria.TabIndex = 21;
            this.txtSangria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSangria_KeyDown);
            this.txtSangria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // frmFecharCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(340, 272);
            this.Controls.Add(this.txtSangria);
            this.Controls.Add(this.lbSaldoFin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbSaldoTot);
            this.Controls.Add(this.lbCaixa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btConcluir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFecharCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fechar Caixa";
            this.Load += new System.EventHandler(this.frmFecharCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btConcluir;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCaixa;
        private System.Windows.Forms.Label lbSaldoTot;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSaldoFin;
        private System.Windows.Forms.TextBox txtSangria;
    }
}