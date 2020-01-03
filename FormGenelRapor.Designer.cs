namespace SaglikOcagiSistem
{
    partial class FormGenelRapor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.rbHepsi = new System.Windows.Forms.RadioButton();
            this.rbTaburcuOlmamıs = new System.Windows.Forms.RadioButton();
            this.rbTaburcuOlmus = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.raporDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raporDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dtBitis);
            this.panel1.Controls.Add(this.dtBaslangic);
            this.panel1.Controls.Add(this.btnYazdir);
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.btnSorgula);
            this.panel1.Controls.Add(this.rbHepsi);
            this.panel1.Controls.Add(this.rbTaburcuOlmamıs);
            this.panel1.Controls.Add(this.rbTaburcuOlmus);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 76);
            this.panel1.TabIndex = 25;
            // 
            // dtBitis
            // 
            this.dtBitis.CustomFormat = "dd.MM.yyyy";
            this.dtBitis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBitis.Location = new System.Drawing.Point(125, 38);
            this.dtBitis.Margin = new System.Windows.Forms.Padding(2);
            this.dtBitis.MaxDate = new System.DateTime(2020, 11, 4, 0, 0, 0, 0);
            this.dtBitis.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(149, 24);
            this.dtBitis.TabIndex = 39;
            this.dtBitis.Value = new System.DateTime(2020, 1, 2, 0, 0, 0, 0);
            this.dtBitis.Leave += new System.EventHandler(this.dtBitis_Leave);
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.CustomFormat = "dd.MM.yyyy";
            this.dtBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBaslangic.Location = new System.Drawing.Point(125, 4);
            this.dtBaslangic.Margin = new System.Windows.Forms.Padding(2);
            this.dtBaslangic.MaxDate = new System.DateTime(2020, 11, 4, 0, 0, 0, 0);
            this.dtBaslangic.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(149, 24);
            this.dtBaslangic.TabIndex = 38;
            this.dtBaslangic.Value = new System.DateTime(2020, 1, 2, 0, 0, 0, 0);
            this.dtBaslangic.Leave += new System.EventHandler(this.dtBsalangic_Leave);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.Location = new System.Drawing.Point(710, 9);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(92, 51);
            this.btnYazdir.TabIndex = 37;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(612, 9);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(92, 51);
            this.btnTemizle.TabIndex = 36;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // btnSorgula
            // 
            this.btnSorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSorgula.Location = new System.Drawing.Point(514, 10);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(92, 51);
            this.btnSorgula.TabIndex = 35;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // rbHepsi
            // 
            this.rbHepsi.AutoSize = true;
            this.rbHepsi.Location = new System.Drawing.Point(290, 48);
            this.rbHepsi.Name = "rbHepsi";
            this.rbHepsi.Size = new System.Drawing.Size(64, 22);
            this.rbHepsi.TabIndex = 34;
            this.rbHepsi.TabStop = true;
            this.rbHepsi.Text = "Hepsi";
            this.rbHepsi.UseVisualStyleBackColor = true;
            // 
            // rbTaburcuOlmamıs
            // 
            this.rbTaburcuOlmamıs.AutoSize = true;
            this.rbTaburcuOlmamıs.Location = new System.Drawing.Point(290, 26);
            this.rbTaburcuOlmamıs.Name = "rbTaburcuOlmamıs";
            this.rbTaburcuOlmamıs.Size = new System.Drawing.Size(144, 22);
            this.rbTaburcuOlmamıs.TabIndex = 33;
            this.rbTaburcuOlmamıs.TabStop = true;
            this.rbTaburcuOlmamıs.Text = "Taburcu Olmamış";
            this.rbTaburcuOlmamıs.UseVisualStyleBackColor = true;
            // 
            // rbTaburcuOlmus
            // 
            this.rbTaburcuOlmus.AutoSize = true;
            this.rbTaburcuOlmus.Location = new System.Drawing.Point(290, 3);
            this.rbTaburcuOlmus.Name = "rbTaburcuOlmus";
            this.rbTaburcuOlmus.Size = new System.Drawing.Size(128, 22);
            this.rbTaburcuOlmus.TabIndex = 32;
            this.rbTaburcuOlmus.TabStop = true;
            this.rbTaburcuOlmus.Text = "Taburcu Olmuş";
            this.rbTaburcuOlmus.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Bitiş Tarihi :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Başlangıç Tarihi :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // raporDataGrid
            // 
            this.raporDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raporDataGrid.Location = new System.Drawing.Point(0, 70);
            this.raporDataGrid.Name = "raporDataGrid";
            this.raporDataGrid.Size = new System.Drawing.Size(1142, 575);
            this.raporDataGrid.TabIndex = 27;
            // 
            // FormGenelRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 644);
            this.Controls.Add(this.raporDataGrid);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormGenelRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genel Rapor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raporDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DateTimePicker dtBitis;
        public System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSorgula;
        public System.Windows.Forms.DataGridView raporDataGrid;
        public System.Windows.Forms.RadioButton rbHepsi;
        public System.Windows.Forms.RadioButton rbTaburcuOlmamıs;
        public System.Windows.Forms.RadioButton rbTaburcuOlmus;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
    }
}