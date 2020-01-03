namespace SaglikOcagiSistem
{
    partial class FormTaburcu
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
            this.txtDosyaNo = new System.Windows.Forms.TextBox();
            this.cmbOdeme = new System.Windows.Forms.ComboBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.dtSevk = new System.Windows.Forms.DateTimePicker();
            this.dtCikis = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtDosyaNo
            // 
            this.txtDosyaNo.Enabled = false;
            this.txtDosyaNo.Location = new System.Drawing.Point(77, 11);
            this.txtDosyaNo.MaxLength = 5;
            this.txtDosyaNo.Name = "txtDosyaNo";
            this.txtDosyaNo.Size = new System.Drawing.Size(178, 20);
            this.txtDosyaNo.TabIndex = 0;
            // 
            // cmbOdeme
            // 
            this.cmbOdeme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdeme.FormattingEnabled = true;
            this.cmbOdeme.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı - Tek Çekim",
            "Kredi Kartı - Taksit - 2",
            "Kredi Kartı - Taksit - 4",
            "Kredi Kartı - Taksit - 6"});
            this.cmbOdeme.Location = new System.Drawing.Point(77, 91);
            this.cmbOdeme.Name = "cmbOdeme";
            this.cmbOdeme.Size = new System.Drawing.Size(178, 21);
            this.cmbOdeme.TabIndex = 3;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Enabled = false;
            this.txtToplamTutar.Location = new System.Drawing.Point(77, 118);
            this.txtToplamTutar.MaxLength = 6;
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(178, 20);
            this.txtToplamTutar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dosya No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sevk Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Çıkış Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ödeme Şekli";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Toplam Tutar";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKaydet.Location = new System.Drawing.Point(180, 148);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVazgec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVazgec.Location = new System.Drawing.Point(4, 148);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(75, 23);
            this.btnVazgec.TabIndex = 7;
            this.btnVazgec.Text = " Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = false;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // dtSevk
            // 
            this.dtSevk.Enabled = false;
            this.dtSevk.Location = new System.Drawing.Point(77, 40);
            this.dtSevk.Name = "dtSevk";
            this.dtSevk.Size = new System.Drawing.Size(178, 20);
            this.dtSevk.TabIndex = 8;
            // 
            // dtCikis
            // 
            this.dtCikis.Enabled = false;
            this.dtCikis.Location = new System.Drawing.Point(77, 67);
            this.dtCikis.Name = "dtCikis";
            this.dtCikis.Size = new System.Drawing.Size(178, 20);
            this.dtCikis.TabIndex = 9;
            // 
            // FormTaburcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(267, 183);
            this.Controls.Add(this.dtCikis);
            this.Controls.Add(this.dtSevk);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.cmbOdeme);
            this.Controls.Add(this.txtDosyaNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTaburcu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormTaburcu";
            this.Load += new System.EventHandler(this.FormTaburcu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnVazgec;
        public System.Windows.Forms.TextBox txtDosyaNo;
        public System.Windows.Forms.ComboBox cmbOdeme;
        public System.Windows.Forms.TextBox txtToplamTutar;
        public System.Windows.Forms.DateTimePicker dtSevk;
        public System.Windows.Forms.DateTimePicker dtCikis;
    }
}