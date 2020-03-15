namespace UI
{
    partial class frmSelecionaRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelecionaRelatorio));
            this.cbxRelatorios = new System.Windows.Forms.ComboBox();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDE = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btoOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxRelatorios
            // 
            this.cbxRelatorios.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbxRelatorios.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbxRelatorios.Items.AddRange(new object[] {
            "Lançamentos",
            "Entradas",
            "Saidas",
            "Gatos Veiculos"});
            this.cbxRelatorios.Location = new System.Drawing.Point(17, 61);
            this.cbxRelatorios.Name = "cbxRelatorios";
            this.cbxRelatorios.Size = new System.Drawing.Size(356, 27);
            this.cbxRelatorios.TabIndex = 1;
            // 
            // dtInicio
            // 
            this.dtInicio.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
            this.dtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(73, 135);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(103, 26);
            this.dtInicio.TabIndex = 2;
            // 
            // dtFim
            // 
            this.dtFim.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dtFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(237, 135);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(99, 26);
            this.dtFim.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecione o relatório";
            // 
            // lbDE
            // 
            this.lbDE.AutoSize = true;
            this.lbDE.BackColor = System.Drawing.Color.Transparent;
            this.lbDE.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbDE.Location = new System.Drawing.Point(13, 141);
            this.lbDE.Name = "lbDE";
            this.lbDE.Size = new System.Drawing.Size(27, 19);
            this.lbDE.TabIndex = 5;
            this.lbDE.Text = "De";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filtrar por periodo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label3.Location = new System.Drawing.Point(201, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "a";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 64);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancelar.Location = new System.Drawing.Point(295, 187);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(84, 71);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btoOk
            // 
            this.btoOk.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btoOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoOk.Image = ((System.Drawing.Image)(resources.GetObject("btoOk.Image")));
            this.btoOk.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btoOk.Location = new System.Drawing.Point(205, 187);
            this.btoOk.Name = "btoOk";
            this.btoOk.Size = new System.Drawing.Size(84, 71);
            this.btoOk.TabIndex = 13;
            this.btoOk.Text = "CONFIRMAR";
            this.btoOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btoOk.UseVisualStyleBackColor = false;
            this.btoOk.Click += new System.EventHandler(this.btoOk_Click);
            // 
            // frmSelecionaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(380, 263);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btoOk);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.cbxRelatorios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelecionaRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecione o relatório";
            this.Load += new System.EventHandler(this.frmSelecionaRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxRelatorios;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btoOk;
    }
}