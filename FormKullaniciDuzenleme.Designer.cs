namespace SaglikOcagiSistem
{
    partial class FormKullaniciDuzenleme
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
            this.txtKullaniciKod = new System.Windows.Forms.TextBox();
            this.txtTCKimlik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBabaAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnneAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGsmNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIseBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbUnvan = new System.Windows.Forms.ComboBox();
            this.txtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.cmbMedeniHal = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbKanGrubu = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.chckSecim = new System.Windows.Forms.CheckBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.cmbDogumYeri = new System.Windows.Forms.ComboBox();
            this.cmbPoliklinik = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Kodu :";
            // 
            // txtKullaniciKod
            // 
            this.txtKullaniciKod.Enabled = false;
            this.txtKullaniciKod.Location = new System.Drawing.Point(143, 7);
            this.txtKullaniciKod.MaxLength = 5;
            this.txtKullaniciKod.Name = "txtKullaniciKod";
            this.txtKullaniciKod.Size = new System.Drawing.Size(171, 22);
            this.txtKullaniciKod.TabIndex = 1;
            // 
            // txtTCKimlik
            // 
            this.txtTCKimlik.Location = new System.Drawing.Point(143, 35);
            this.txtTCKimlik.MaxLength = 11;
            this.txtTCKimlik.Name = "txtTCKimlik";
            this.txtTCKimlik.Size = new System.Drawing.Size(171, 22);
            this.txtTCKimlik.TabIndex = 1;
            this.txtTCKimlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTCKimlik_KeyPress);
            this.txtTCKimlik.Leave += new System.EventHandler(this.txtTCKimlik_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "TC Kimlik Numarası :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Doğum Yeri :";
            // 
            // txtBabaAdi
            // 
            this.txtBabaAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBabaAdi.Location = new System.Drawing.Point(143, 91);
            this.txtBabaAdi.MaxLength = 15;
            this.txtBabaAdi.Name = "txtBabaAdi";
            this.txtBabaAdi.Size = new System.Drawing.Size(171, 22);
            this.txtBabaAdi.TabIndex = 3;
            this.txtBabaAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBabaAdi_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Baba Adı :";
            // 
            // txtAnneAdi
            // 
            this.txtAnneAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAnneAdi.Location = new System.Drawing.Point(143, 119);
            this.txtAnneAdi.MaxLength = 15;
            this.txtAnneAdi.Name = "txtAnneAdi";
            this.txtAnneAdi.Size = new System.Drawing.Size(171, 22);
            this.txtAnneAdi.TabIndex = 4;
            this.txtAnneAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnneAdi_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Anne Adı :";
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(143, 147);
            this.txtTelefonNo.MaxLength = 11;
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(171, 22);
            this.txtTelefonNo.TabIndex = 5;
            this.txtTelefonNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonNo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefon No :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Unvanı :";
            // 
            // txtAdi
            // 
            this.txtAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAdi.Location = new System.Drawing.Point(459, 37);
            this.txtAdi.MaxLength = 15;
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(203, 22);
            this.txtAdi.TabIndex = 9;
            this.txtAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdi_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Adı :";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSoyadi.Location = new System.Drawing.Point(459, 65);
            this.txtSoyadi.MaxLength = 15;
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(203, 22);
            this.txtSoyadi.TabIndex = 10;
            this.txtSoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyadi_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Soyadı :";
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(459, 93);
            this.txtMaas.MaxLength = 7;
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(203, 22);
            this.txtMaas.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(405, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Maaş :";
            // 
            // txtGsmNo
            // 
            this.txtGsmNo.Location = new System.Drawing.Point(143, 175);
            this.txtGsmNo.MaxLength = 11;
            this.txtGsmNo.Name = "txtGsmNo";
            this.txtGsmNo.Size = new System.Drawing.Size(171, 22);
            this.txtGsmNo.TabIndex = 6;
            this.txtGsmNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGsmNo_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(89, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Gsm  :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(364, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "İşe Başlama :";
            // 
            // txtIseBaslangicTarihi
            // 
            this.txtIseBaslangicTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtIseBaslangicTarihi.Location = new System.Drawing.Point(459, 121);
            this.txtIseBaslangicTarihi.MaxDate = new System.DateTime(2020, 1, 31, 0, 0, 0, 0);
            this.txtIseBaslangicTarihi.MinDate = new System.DateTime(2019, 12, 1, 0, 0, 0, 0);
            this.txtIseBaslangicTarihi.Name = "txtIseBaslangicTarihi";
            this.txtIseBaslangicTarihi.Size = new System.Drawing.Size(203, 22);
            this.txtIseBaslangicTarihi.TabIndex = 12;
            this.txtIseBaslangicTarihi.Value = new System.DateTime(2019, 12, 26, 0, 0, 0, 0);
            // 
            // cmbUnvan
            // 
            this.cmbUnvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnvan.FormattingEnabled = true;
            this.cmbUnvan.Items.AddRange(new object[] {
            "Başhekim",
            "Doktor",
            "Hemşire",
            "Sağlık Memuru",
            "Memur",
            "Hizmetli"});
            this.cmbUnvan.Location = new System.Drawing.Point(459, 7);
            this.cmbUnvan.Name = "cmbUnvan";
            this.cmbUnvan.Size = new System.Drawing.Size(203, 24);
            this.cmbUnvan.TabIndex = 8;
            this.cmbUnvan.SelectedIndexChanged += new System.EventHandler(this.cmbUnvan_SelectedIndexChanged);
            // 
            // txtDogumTarihi
            // 
            this.txtDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDogumTarihi.Location = new System.Drawing.Point(459, 149);
            this.txtDogumTarihi.MaxDate = new System.DateTime(2020, 12, 26, 0, 0, 0, 0);
            this.txtDogumTarihi.MinDate = new System.DateTime(1980, 12, 31, 0, 0, 0, 0);
            this.txtDogumTarihi.Name = "txtDogumTarihi";
            this.txtDogumTarihi.Size = new System.Drawing.Size(203, 22);
            this.txtDogumTarihi.TabIndex = 13;
            this.txtDogumTarihi.Value = new System.DateTime(1980, 12, 31, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(358, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Doğum Tarihi :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(392, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "Cinsiyet :";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(459, 177);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(203, 24);
            this.cmbCinsiyet.TabIndex = 14;
            // 
            // cmbMedeniHal
            // 
            this.cmbMedeniHal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedeniHal.FormattingEnabled = true;
            this.cmbMedeniHal.Items.AddRange(new object[] {
            "Evli",
            "Bekar"});
            this.cmbMedeniHal.Location = new System.Drawing.Point(459, 237);
            this.cmbMedeniHal.Name = "cmbMedeniHal";
            this.cmbMedeniHal.Size = new System.Drawing.Size(203, 24);
            this.cmbMedeniHal.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(370, 245);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 16);
            this.label15.TabIndex = 29;
            this.label15.Text = "Medeni Hal :";
            // 
            // cmbKanGrubu
            // 
            this.cmbKanGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKanGrubu.FormattingEnabled = true;
            this.cmbKanGrubu.Items.AddRange(new object[] {
            "AB Rh+",
            "AB Rh-",
            "A Rh+",
            "A Rh-",
            "B Rh+",
            "B Rh-",
            "O Rh+",
            "O Rh-"});
            this.cmbKanGrubu.Location = new System.Drawing.Point(459, 207);
            this.cmbKanGrubu.Name = "cmbKanGrubu";
            this.cmbKanGrubu.Size = new System.Drawing.Size(203, 24);
            this.cmbKanGrubu.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(377, 215);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 16);
            this.label16.TabIndex = 31;
            this.label16.Text = "Kan Grubu :";
            // 
            // chckSecim
            // 
            this.chckSecim.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chckSecim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckSecim.Location = new System.Drawing.Point(143, 209);
            this.chckSecim.Name = "chckSecim";
            this.chckSecim.Size = new System.Drawing.Size(171, 22);
            this.chckSecim.TabIndex = 7;
            this.chckSecim.Text = "Yetkili Kullanıcı ";
            this.chckSecim.UseVisualStyleBackColor = true;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(143, 276);
            this.txtAdres.MaxLength = 255;
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAdres.Size = new System.Drawing.Size(519, 75);
            this.txtAdres.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(84, 276);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 16);
            this.label17.TabIndex = 35;
            this.label17.Text = "Adres :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.txtKullaniciAdi);
            this.panel1.Controls.Add(this.label18);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(143, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 41);
            this.panel1.TabIndex = 36;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(338, 9);
            this.txtSifre.MaxLength = 15;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(171, 22);
            this.txtSifre.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(297, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 16);
            this.label19.TabIndex = 39;
            this.label19.Text = "Şifre :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(91, 9);
            this.txtKullaniciAdi.MaxLength = 50;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(200, 22);
            this.txtKullaniciAdi.TabIndex = 18;
            this.txtKullaniciAdi.Leave += new System.EventHandler(this.txtKullaniciAdi_Leave);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 16);
            this.label18.TabIndex = 37;
            this.label18.Text = "Kullanıcı Adı :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnCikis);
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.btnGuncelle);
            this.panel2.Controls.Add(this.btnTemizle);
            this.panel2.Location = new System.Drawing.Point(-3, 408);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 77);
            this.panel2.TabIndex = 37;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(551, 10);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(102, 55);
            this.btnCikis.TabIndex = 23;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(219, 10);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(102, 55);
            this.btnSil.TabIndex = 21;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(111, 10);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(102, 55);
            this.btnGuncelle.TabIndex = 20;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(3, 10);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(102, 55);
            this.btnTemizle.TabIndex = 22;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // cmbDogumYeri
            // 
            this.cmbDogumYeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDogumYeri.FormattingEnabled = true;
            this.cmbDogumYeri.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce",
            ""});
            this.cmbDogumYeri.Location = new System.Drawing.Point(143, 61);
            this.cmbDogumYeri.Name = "cmbDogumYeri";
            this.cmbDogumYeri.Size = new System.Drawing.Size(173, 24);
            this.cmbDogumYeri.TabIndex = 2;
            // 
            // cmbPoliklinik
            // 
            this.cmbPoliklinik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPoliklinik.FormattingEnabled = true;
            this.cmbPoliklinik.Location = new System.Drawing.Point(143, 237);
            this.cmbPoliklinik.Name = "cmbPoliklinik";
            this.cmbPoliklinik.Size = new System.Drawing.Size(171, 24);
            this.cmbPoliklinik.TabIndex = 39;
            this.cmbPoliklinik.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(64, 245);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 16);
            this.label20.TabIndex = 40;
            this.label20.Text = "Poliklinik :";
            this.label20.Visible = false;
            // 
            // FormKullaniciDuzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 487);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cmbPoliklinik);
            this.Controls.Add(this.cmbDogumYeri);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.chckSecim);
            this.Controls.Add(this.cmbKanGrubu);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbMedeniHal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDogumTarihi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbUnvan);
            this.Controls.Add(this.txtIseBaslangicTarihi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtGsmNo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelefonNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAnneAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBabaAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTCKimlik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKullaniciKod);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormKullaniciDuzenleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Düzenleme";
            this.Load += new System.EventHandler(this.FormKullaniciDuzenleme_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCikis;
        public System.Windows.Forms.TextBox txtKullaniciKod;
        public System.Windows.Forms.TextBox txtTCKimlik;
        public System.Windows.Forms.TextBox txtBabaAdi;
        public System.Windows.Forms.TextBox txtAnneAdi;
        public System.Windows.Forms.TextBox txtTelefonNo;
        public System.Windows.Forms.TextBox txtAdi;
        public System.Windows.Forms.TextBox txtSoyadi;
        public System.Windows.Forms.TextBox txtMaas;
        public System.Windows.Forms.TextBox txtGsmNo;
        public System.Windows.Forms.DateTimePicker txtIseBaslangicTarihi;
        public System.Windows.Forms.ComboBox cmbUnvan;
        public System.Windows.Forms.DateTimePicker txtDogumTarihi;
        public System.Windows.Forms.ComboBox cmbCinsiyet;
        public System.Windows.Forms.ComboBox cmbKanGrubu;
        public System.Windows.Forms.CheckBox chckSecim;
        public System.Windows.Forms.TextBox txtAdres;
        public System.Windows.Forms.TextBox txtSifre;
        public System.Windows.Forms.TextBox txtKullaniciAdi;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnGuncelle;
        public System.Windows.Forms.Button btnTemizle;
        public System.Windows.Forms.ComboBox cmbDogumYeri;
        public System.Windows.Forms.ComboBox cmbMedeniHal;
        public System.Windows.Forms.ComboBox cmbPoliklinik;
        public System.Windows.Forms.Label label20;
    }
}