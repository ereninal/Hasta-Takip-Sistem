namespace SaglikOcagiSistem
{
    partial class FormDosyaBul
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelGenel = new System.Windows.Forms.Panel();
            this.btnBul = new System.Windows.Forms.Button();
            this.panelAdSoyad = new System.Windows.Forms.Panel();
            this.panelDiger = new System.Windows.Forms.Panel();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.chckSecimAdSoyad = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.cmbSecim = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelGenel.SuspendLayout();
            this.panelAdSoyad.SuspendLayout();
            this.panelDiger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama Kriteri :";
            // 
            // panelGenel
            // 
            this.panelGenel.Controls.Add(this.btnBul);
            this.panelGenel.Controls.Add(this.panelAdSoyad);
            this.panelGenel.Controls.Add(this.cmbSecim);
            this.panelGenel.Controls.Add(this.label1);
            this.panelGenel.Location = new System.Drawing.Point(0, 1);
            this.panelGenel.Name = "panelGenel";
            this.panelGenel.Size = new System.Drawing.Size(821, 49);
            this.panelGenel.TabIndex = 1;
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBul.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBul.Location = new System.Drawing.Point(718, 4);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(100, 42);
            this.btnBul.TabIndex = 3;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // panelAdSoyad
            // 
            this.panelAdSoyad.Controls.Add(this.panelDiger);
            this.panelAdSoyad.Controls.Add(this.label3);
            this.panelAdSoyad.Controls.Add(this.txtSoyad);
            this.panelAdSoyad.Controls.Add(this.chckSecimAdSoyad);
            this.panelAdSoyad.Controls.Add(this.label2);
            this.panelAdSoyad.Controls.Add(this.txtAd);
            this.panelAdSoyad.Location = new System.Drawing.Point(274, 3);
            this.panelAdSoyad.Name = "panelAdSoyad";
            this.panelAdSoyad.Size = new System.Drawing.Size(437, 43);
            this.panelAdSoyad.TabIndex = 2;
            // 
            // panelDiger
            // 
            this.panelDiger.Controls.Add(this.txtAra);
            this.panelDiger.Location = new System.Drawing.Point(0, 0);
            this.panelDiger.Name = "panelDiger";
            this.panelDiger.Size = new System.Drawing.Size(437, 43);
            this.panelDiger.TabIndex = 7;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(4, 9);
            this.txtAra.MaxLength = 20;
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(418, 24);
            this.txtAra.TabIndex = 0;
            this.txtAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAra_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soyadı :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(309, 9);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 24);
            this.txtSoyad.TabIndex = 5;
            // 
            // chckSecimAdSoyad
            // 
            this.chckSecimAdSoyad.AutoSize = true;
            this.chckSecimAdSoyad.Location = new System.Drawing.Point(187, 11);
            this.chckSecimAdSoyad.Name = "chckSecimAdSoyad";
            this.chckSecimAdSoyad.Size = new System.Drawing.Size(44, 22);
            this.chckSecimAdSoyad.TabIndex = 4;
            this.chckSecimAdSoyad.Text = "Ve";
            this.chckSecimAdSoyad.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adı :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(59, 9);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 24);
            this.txtAd.TabIndex = 0;
            // 
            // cmbSecim
            // 
            this.cmbSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSecim.FormattingEnabled = true;
            this.cmbSecim.Items.AddRange(new object[] {
            "Hasta Adı Soyadı",
            "Kimlik No",
            "Kurum Sicil No",
            "Dosya No"});
            this.cmbSecim.Location = new System.Drawing.Point(113, 12);
            this.cmbSecim.Name = "cmbSecim";
            this.cmbSecim.Size = new System.Drawing.Size(155, 26);
            this.cmbSecim.TabIndex = 1;
            this.cmbSecim.SelectedIndexChanged += new System.EventHandler(this.cmbSecim_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(821, 409);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // FormDosyaBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 462);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelGenel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDosyaBul";
            this.Text = "Dosya Bul";
            this.panelGenel.ResumeLayout(false);
            this.panelGenel.PerformLayout();
            this.panelAdSoyad.ResumeLayout(false);
            this.panelAdSoyad.PerformLayout();
            this.panelDiger.ResumeLayout(false);
            this.panelDiger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelGenel;
        private System.Windows.Forms.Panel panelDiger;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Panel panelAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSecim;
        public System.Windows.Forms.TextBox txtAra;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox txtSoyad;
        public System.Windows.Forms.CheckBox chckSecimAdSoyad;
        public System.Windows.Forms.TextBox txtAd;
    }
}