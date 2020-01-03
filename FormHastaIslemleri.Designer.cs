namespace SaglikOcagiSistem
{
    partial class FormHastaIslemleri
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDosyaAdi = new System.Windows.Forms.TextBox();
            this.dateSevk = new System.Windows.Forms.DateTimePicker();
            this.btnBul = new System.Windows.Forms.Button();
            this.cmbOncekiIslem = new System.Windows.Forms.ComboBox();
            this.btnGit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHastaBilgileri = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKurumAdi = new System.Windows.Forms.TextBox();
            this.txtHastaSoyAdi = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEkle = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.numMiktar = new System.Windows.Forms.NumericUpDown();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cmbDoktorlar = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbIslem = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSiraNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbPoliklinik = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grpVeri = new System.Windows.Forms.GroupBox();
            this.datagridSevk = new System.Windows.Forms.DataGridView();
            this.lblFİyat = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnBaski = new System.Windows.Forms.Button();
            this.btnTaburcu = new System.Windows.Forms.Button();
            this.btnSecSil = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.sevkid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poliklinik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yapilanIslem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMiktar)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grpVeri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSevk)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya Kodu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sevk Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Önceki İşlemler :";
            // 
            // txtDosyaAdi
            // 
            this.txtDosyaAdi.Location = new System.Drawing.Point(128, 8);
            this.txtDosyaAdi.MaxLength = 5;
            this.txtDosyaAdi.Name = "txtDosyaAdi";
            this.txtDosyaAdi.Size = new System.Drawing.Size(126, 24);
            this.txtDosyaAdi.TabIndex = 3;
            this.txtDosyaAdi.Leave += new System.EventHandler(this.Textbox_Cikis);
            // 
            // dateSevk
            // 
            this.dateSevk.CustomFormat = "dd.MM.yyyy";
            this.dateSevk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateSevk.Location = new System.Drawing.Point(128, 41);
            this.dateSevk.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateSevk.MinDate = new System.DateTime(2019, 12, 16, 20, 17, 30, 0);
            this.dateSevk.Name = "dateSevk";
            this.dateSevk.Size = new System.Drawing.Size(200, 24);
            this.dateSevk.TabIndex = 4;
            this.dateSevk.Value = new System.DateTime(2019, 12, 16, 20, 17, 30, 0);
            this.dateSevk.ValueChanged += new System.EventHandler(this.dateSevk_ValueChanged);
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBul.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBul.Location = new System.Drawing.Point(261, 3);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(67, 29);
            this.btnBul.TabIndex = 5;
            this.btnBul.Text = "Bul";
            this.btnBul.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // cmbOncekiIslem
            // 
            this.cmbOncekiIslem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOncekiIslem.FormattingEnabled = true;
            this.cmbOncekiIslem.Location = new System.Drawing.Point(128, 70);
            this.cmbOncekiIslem.Name = "cmbOncekiIslem";
            this.cmbOncekiIslem.Size = new System.Drawing.Size(121, 26);
            this.cmbOncekiIslem.TabIndex = 6;
            this.cmbOncekiIslem.DropDown += new System.EventHandler(this.cmbOncekiIslem_DropDown);
            // 
            // btnGit
            // 
            this.btnGit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGit.Location = new System.Drawing.Point(261, 69);
            this.btnGit.Name = "btnGit";
            this.btnGit.Size = new System.Drawing.Size(67, 27);
            this.btnGit.TabIndex = 7;
            this.btnGit.Text = "Git";
            this.btnGit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGit.UseVisualStyleBackColor = false;
            this.btnGit.Click += new System.EventHandler(this.btnGit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hasta Adı : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Soyadı : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kurum Adı : ";
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Enabled = false;
            this.txtHastaAdi.Location = new System.Drawing.Point(450, 11);
            this.txtHastaAdi.MaxLength = 10;
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(179, 24);
            this.txtHastaAdi.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnHastaBilgileri);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtKurumAdi);
            this.panel1.Controls.Add(this.txtHastaSoyAdi);
            this.panel1.Controls.Add(this.txtHastaAdi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDosyaAdi);
            this.panel1.Controls.Add(this.btnGit);
            this.panel1.Controls.Add(this.dateSevk);
            this.panel1.Controls.Add(this.cmbOncekiIslem);
            this.panel1.Controls.Add(this.btnBul);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 113);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnHastaBilgileri
            // 
            this.btnHastaBilgileri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHastaBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaBilgileri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHastaBilgileri.Location = new System.Drawing.Point(677, 40);
            this.btnHastaBilgileri.Name = "btnHastaBilgileri";
            this.btnHastaBilgileri.Size = new System.Drawing.Size(223, 56);
            this.btnHastaBilgileri.TabIndex = 15;
            this.btnHastaBilgileri.Text = "Hasta Bilgileri";
            this.btnHastaBilgileri.UseVisualStyleBackColor = false;
            this.btnHastaBilgileri.Click += new System.EventHandler(this.btnHastaBilgileri_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(656, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sağlık Ocağı Hasta Takip Sistemi";
            // 
            // txtKurumAdi
            // 
            this.txtKurumAdi.Enabled = false;
            this.txtKurumAdi.Location = new System.Drawing.Point(450, 70);
            this.txtKurumAdi.MaxLength = 10;
            this.txtKurumAdi.Name = "txtKurumAdi";
            this.txtKurumAdi.Size = new System.Drawing.Size(179, 24);
            this.txtKurumAdi.TabIndex = 13;
            // 
            // txtHastaSoyAdi
            // 
            this.txtHastaSoyAdi.Enabled = false;
            this.txtHastaSoyAdi.Location = new System.Drawing.Point(450, 41);
            this.txtHastaSoyAdi.MaxLength = 10;
            this.txtHastaSoyAdi.Name = "txtHastaSoyAdi";
            this.txtHastaSoyAdi.Size = new System.Drawing.Size(179, 24);
            this.txtHastaSoyAdi.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.btnEkle);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 58);
            this.panel2.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEkle.Location = new System.Drawing.Point(776, 6);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(124, 44);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.txtFiyat);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Location = new System.Drawing.Point(639, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(111, 52);
            this.panel8.TabIndex = 13;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Enabled = false;
            this.txtFiyat.Location = new System.Drawing.Point(0, 18);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiyat.MaxLength = 10;
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(106, 24);
            this.txtFiyat.TabIndex = 8;
            this.txtFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(-3, -1);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Birim Fiyat";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.numMiktar);
            this.panel7.Location = new System.Drawing.Point(540, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(97, 52);
            this.panel7.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(0, -1);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 21);
            this.label13.TabIndex = 4;
            this.label13.Text = "Miktar";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numMiktar
            // 
            this.numMiktar.Location = new System.Drawing.Point(1, 19);
            this.numMiktar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMiktar.Name = "numMiktar";
            this.numMiktar.Size = new System.Drawing.Size(94, 24);
            this.numMiktar.TabIndex = 10;
            this.numMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMiktar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.cmbDoktorlar);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(375, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(162, 52);
            this.panel6.TabIndex = 5;
            // 
            // cmbDoktorlar
            // 
            this.cmbDoktorlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoktorlar.FormattingEnabled = true;
            this.cmbDoktorlar.Location = new System.Drawing.Point(-2, 19);
            this.cmbDoktorlar.Name = "cmbDoktorlar";
            this.cmbDoktorlar.Size = new System.Drawing.Size(159, 26);
            this.cmbDoktorlar.TabIndex = 9;
            this.cmbDoktorlar.SelectedIndexChanged += new System.EventHandler(this.cmbDoktorlar_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(40, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Doktor Ad";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.cmbIslem);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(236, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(137, 52);
            this.panel5.TabIndex = 4;
            // 
            // cmbIslem
            // 
            this.cmbIslem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslem.FormattingEnabled = true;
            this.cmbIslem.Location = new System.Drawing.Point(-2, 19);
            this.cmbIslem.Name = "cmbIslem";
            this.cmbIslem.Size = new System.Drawing.Size(135, 26);
            this.cmbIslem.TabIndex = 8;
            this.cmbIslem.SelectedIndexChanged += new System.EventHandler(this.cmbIslem_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Yapılan İşlem";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txtSiraNo);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(121, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(114, 52);
            this.panel4.TabIndex = 3;
            // 
            // txtSiraNo
            // 
            this.txtSiraNo.Enabled = false;
            this.txtSiraNo.Location = new System.Drawing.Point(0, 20);
            this.txtSiraNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSiraNo.MaxLength = 10;
            this.txtSiraNo.Name = "txtSiraNo";
            this.txtSiraNo.Size = new System.Drawing.Size(112, 24);
            this.txtSiraNo.TabIndex = 7;
            this.txtSiraNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(-1, 1);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Sıra No";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cmbPoliklinik);
            this.panel3.Controls.Add(this.label8);
            this.panel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(117, 52);
            this.panel3.TabIndex = 2;
            // 
            // cmbPoliklinik
            // 
            this.cmbPoliklinik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPoliklinik.FormattingEnabled = true;
            this.cmbPoliklinik.Location = new System.Drawing.Point(0, 19);
            this.cmbPoliklinik.Name = "cmbPoliklinik";
            this.cmbPoliklinik.Size = new System.Drawing.Size(111, 26);
            this.cmbPoliklinik.TabIndex = 6;
            this.cmbPoliklinik.SelectedIndexChanged += new System.EventHandler(this.cmbPoliklinik_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Poliklinik";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpVeri
            // 
            this.grpVeri.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpVeri.Controls.Add(this.datagridSevk);
            this.grpVeri.Controls.Add(this.lblFİyat);
            this.grpVeri.Controls.Add(this.label14);
            this.grpVeri.Location = new System.Drawing.Point(0, 171);
            this.grpVeri.Name = "grpVeri";
            this.grpVeri.Size = new System.Drawing.Size(922, 348);
            this.grpVeri.TabIndex = 3;
            this.grpVeri.TabStop = false;
            this.grpVeri.Text = "Yapılan Tahlil ve İşlemler";
            // 
            // datagridSevk
            // 
            this.datagridSevk.AllowUserToAddRows = false;
            this.datagridSevk.AllowUserToDeleteRows = false;
            this.datagridSevk.AllowUserToResizeColumns = false;
            this.datagridSevk.AllowUserToResizeRows = false;
            this.datagridSevk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridSevk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sevkid,
            this.poliklinik,
            this.sira,
            this.saat,
            this.yapilanIslem,
            this.drKod,
            this.miktar,
            this.birimFiyat});
            this.datagridSevk.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridSevk.Location = new System.Drawing.Point(5, 23);
            this.datagridSevk.Name = "datagridSevk";
            this.datagridSevk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridSevk.Size = new System.Drawing.Size(917, 292);
            this.datagridSevk.TabIndex = 18;
            // 
            // lblFİyat
            // 
            this.lblFİyat.BackColor = System.Drawing.Color.DarkBlue;
            this.lblFİyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFİyat.ForeColor = System.Drawing.Color.Red;
            this.lblFİyat.Location = new System.Drawing.Point(837, 309);
            this.lblFİyat.Name = "lblFİyat";
            this.lblFİyat.Size = new System.Drawing.Size(85, 38);
            this.lblFİyat.TabIndex = 17;
            this.lblFİyat.Text = "0 TL";
            this.lblFİyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.DarkBlue;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(707, 309);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 38);
            this.label14.TabIndex = 16;
            this.label14.Text = "Toplam Tutar :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel9.Controls.Add(this.btnCikis);
            this.panel9.Controls.Add(this.btnBaski);
            this.panel9.Controls.Add(this.btnTaburcu);
            this.panel9.Controls.Add(this.btnSecSil);
            this.panel9.Controls.Add(this.btnYeni);
            this.panel9.Location = new System.Drawing.Point(0, 515);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(922, 70);
            this.panel9.TabIndex = 4;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCikis.Location = new System.Drawing.Point(806, 3);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(113, 64);
            this.btnCikis.TabIndex = 21;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            // 
            // btnBaski
            // 
            this.btnBaski.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBaski.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaski.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnBaski.Location = new System.Drawing.Point(377, 6);
            this.btnBaski.Name = "btnBaski";
            this.btnBaski.Size = new System.Drawing.Size(113, 64);
            this.btnBaski.TabIndex = 20;
            this.btnBaski.Text = "BASKI\r\nÖNİZLEME\r\n";
            this.btnBaski.UseVisualStyleBackColor = false;
            this.btnBaski.Click += new System.EventHandler(this.btnBaski_Click);
            // 
            // btnTaburcu
            // 
            this.btnTaburcu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTaburcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTaburcu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTaburcu.Location = new System.Drawing.Point(241, 3);
            this.btnTaburcu.Name = "btnTaburcu";
            this.btnTaburcu.Size = new System.Drawing.Size(113, 64);
            this.btnTaburcu.TabIndex = 18;
            this.btnTaburcu.Text = "TABURCU";
            this.btnTaburcu.UseVisualStyleBackColor = false;
            this.btnTaburcu.Click += new System.EventHandler(this.btnTaburcu_Click);
            // 
            // btnSecSil
            // 
            this.btnSecSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSecSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSecSil.ForeColor = System.Drawing.Color.Red;
            this.btnSecSil.Location = new System.Drawing.Point(122, 3);
            this.btnSecSil.Name = "btnSecSil";
            this.btnSecSil.Size = new System.Drawing.Size(113, 64);
            this.btnSecSil.TabIndex = 17;
            this.btnSecSil.Text = "SEÇ-SİL";
            this.btnSecSil.UseVisualStyleBackColor = false;
            this.btnSecSil.Click += new System.EventHandler(this.btnSecSil_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.ForeColor = System.Drawing.SystemColors.Control;
            this.btnYeni.Location = new System.Drawing.Point(3, 3);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(113, 64);
            this.btnYeni.TabIndex = 16;
            this.btnYeni.Text = "YENİ";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // sevkid
            // 
            this.sevkid.HeaderText = "SEVK ID";
            this.sevkid.Name = "sevkid";
            // 
            // poliklinik
            // 
            this.poliklinik.HeaderText = "POLİKLİNİK";
            this.poliklinik.Name = "poliklinik";
            this.poliklinik.Width = 120;
            // 
            // sira
            // 
            this.sira.HeaderText = "SIRA NO";
            this.sira.Name = "sira";
            // 
            // saat
            // 
            this.saat.HeaderText = "SAAT";
            this.saat.Name = "saat";
            // 
            // yapilanIslem
            // 
            this.yapilanIslem.HeaderText = "YAPILAN İŞLEM";
            this.yapilanIslem.Name = "yapilanIslem";
            this.yapilanIslem.Width = 150;
            // 
            // drKod
            // 
            this.drKod.HeaderText = "DOKTOR ADI";
            this.drKod.MinimumWidth = 10;
            this.drKod.Name = "drKod";
            this.drKod.Width = 130;
            // 
            // miktar
            // 
            this.miktar.HeaderText = "MİKTAR";
            this.miktar.Name = "miktar";
            // 
            // birimFiyat
            // 
            this.birimFiyat.HeaderText = "BİRİM FİYATI";
            this.birimFiyat.Name = "birimFiyat";
            this.birimFiyat.Width = 74;
            // 
            // FormHastaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 583);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.grpVeri);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormHastaIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta işlemleri";
            this.Load += new System.EventHandler(this.FrmHastaIslemleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numMiktar)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.grpVeri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridSevk)).EndInit();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGit;
        private System.Windows.Forms.Button btnBul;
        public System.Windows.Forms.DateTimePicker dateSevk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHastaBilgileri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.ComboBox cmbIslem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ComboBox cmbPoliklinik;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpVeri;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnBaski;
        private System.Windows.Forms.Button btnTaburcu;
        private System.Windows.Forms.Button btnSecSil;
        private System.Windows.Forms.Button btnYeni;
        public System.Windows.Forms.ComboBox cmbOncekiIslem;
        public System.Windows.Forms.TextBox txtDosyaAdi;
        public System.Windows.Forms.TextBox txtHastaAdi;
        public System.Windows.Forms.TextBox txtKurumAdi;
        public System.Windows.Forms.TextBox txtHastaSoyAdi;
        public System.Windows.Forms.DataGridView datagridSevk;
        public System.Windows.Forms.Label lblFİyat;
        public System.Windows.Forms.TextBox txtFiyat;
        public System.Windows.Forms.ComboBox cmbDoktorlar;
        public System.Windows.Forms.TextBox txtSiraNo;
        public System.Windows.Forms.NumericUpDown numMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn sevkid;
        private System.Windows.Forms.DataGridViewTextBoxColumn poliklinik;
        private System.Windows.Forms.DataGridViewTextBoxColumn sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn yapilanIslem;
        private System.Windows.Forms.DataGridViewTextBoxColumn drKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimFiyat;
    }
}