namespace SaglikOcagiSistem
{
    partial class FormHastaBilgileri
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
            this.txtDosyaAdı = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTcKimlik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDogumYeri = new System.Windows.Forms.ComboBox();
            this.txtBabaAdı = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAnneAdı = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtKurumAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKurumSicilNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.cmbKanGrubu = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbMedeniHal = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtYakınTelefon = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtYakinSicilNo = new System.Windows.Forms.TextBox();
            this.txtYakinKurumSicilNo = new System.Windows.Forms.Label();
            this.txtYakinKurum = new System.Windows.Forms.TextBox();
            this.txtYakinKurumAdi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya Adı : ";
            // 
            // txtDosyaAdı
            // 
            this.txtDosyaAdı.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDosyaAdı.Enabled = false;
            this.txtDosyaAdı.Location = new System.Drawing.Point(108, 12);
            this.txtDosyaAdı.MaxLength = 5;
            this.txtDosyaAdı.Name = "txtDosyaAdı";
            this.txtDosyaAdı.Size = new System.Drawing.Size(156, 22);
            this.txtDosyaAdı.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAd.Location = new System.Drawing.Point(108, 42);
            this.txtAd.MaxLength = 10;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(156, 22);
            this.txtAd.TabIndex = 1;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adı : ";
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Location = new System.Drawing.Point(427, 11);
            this.txtTcKimlik.MaxLength = 11;
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.Size = new System.Drawing.Size(156, 22);
            this.txtTcKimlik.TabIndex = 0;
            this.txtTcKimlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTcKimlik_KeyPress);
            this.txtTcKimlik.Leave += new System.EventHandler(this.txtTcKimlik_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC Kimlik Numarası :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSoyad.Location = new System.Drawing.Point(427, 39);
            this.txtSoyad.MaxLength = 10;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(156, 22);
            this.txtSoyad.TabIndex = 2;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Soyadı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Doğum Yeri :";
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
            "Düzce"});
            this.cmbDogumYeri.Location = new System.Drawing.Point(108, 86);
            this.cmbDogumYeri.Name = "cmbDogumYeri";
            this.cmbDogumYeri.Size = new System.Drawing.Size(156, 24);
            this.cmbDogumYeri.TabIndex = 3;
            // 
            // txtBabaAdı
            // 
            this.txtBabaAdı.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBabaAdı.Location = new System.Drawing.Point(108, 116);
            this.txtBabaAdı.MaxLength = 10;
            this.txtBabaAdı.Name = "txtBabaAdı";
            this.txtBabaAdı.Size = new System.Drawing.Size(156, 22);
            this.txtBabaAdı.TabIndex = 5;
            this.txtBabaAdı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBabaAdı_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Baba Adı :";
            // 
            // txtAnneAdı
            // 
            this.txtAnneAdı.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAnneAdı.Location = new System.Drawing.Point(108, 144);
            this.txtAnneAdı.MaxLength = 10;
            this.txtAnneAdı.Name = "txtAnneAdı";
            this.txtAnneAdı.Size = new System.Drawing.Size(156, 22);
            this.txtAnneAdı.TabIndex = 6;
            this.txtAnneAdı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnneAdı_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Anne Adı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Adres :";
            // 
            // txtAdres
            // 
            this.txtAdres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdres.Location = new System.Drawing.Point(108, 172);
            this.txtAdres.MaxLength = 1000;
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(475, 92);
            this.txtAdres.TabIndex = 10;
            // 
            // txtKurumAdi
            // 
            this.txtKurumAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKurumAdi.Location = new System.Drawing.Point(108, 326);
            this.txtKurumAdi.MaxLength = 11;
            this.txtKurumAdi.Name = "txtKurumAdi";
            this.txtKurumAdi.Size = new System.Drawing.Size(152, 22);
            this.txtKurumAdi.TabIndex = 13;
            this.txtKurumAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKurumAdi_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Telefon No : ";
            // 
            // txtKurumSicilNo
            // 
            this.txtKurumSicilNo.Location = new System.Drawing.Point(108, 298);
            this.txtKurumSicilNo.MaxLength = 11;
            this.txtKurumSicilNo.Name = "txtKurumSicilNo";
            this.txtKurumSicilNo.Size = new System.Drawing.Size(152, 22);
            this.txtKurumSicilNo.TabIndex = 12;
            this.txtKurumSicilNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKurumSicilNo_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Kurum Sicil No :";
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(108, 270);
            this.txtTelefonNo.MaxLength = 11;
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(152, 22);
            this.txtTelefonNo.TabIndex = 13;
            this.txtTelefonNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonNo_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Kurum Adı :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.btnYeni);
            this.panel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel1.Location = new System.Drawing.Point(5, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 71);
            this.panel1.TabIndex = 22;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(471, 3);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCikis.Size = new System.Drawing.Size(105, 57);
            this.btnCikis.TabIndex = 19;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(5, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnKaydet.Size = new System.Drawing.Size(105, 57);
            this.btnKaydet.TabIndex = 17;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnYeni.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.Location = new System.Drawing.Point(116, 4);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(105, 57);
            this.btnYeni.TabIndex = 18;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(290, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Doğum Tarihi :";
            // 
            // txtDogumTarihi
            // 
            this.txtDogumTarihi.CustomFormat = "dd.MM.yyyy";
            this.txtDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDogumTarihi.Location = new System.Drawing.Point(387, 83);
            this.txtDogumTarihi.MaxDate = new System.DateTime(2019, 12, 18, 0, 0, 0, 0);
            this.txtDogumTarihi.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.txtDogumTarihi.Name = "txtDogumTarihi";
            this.txtDogumTarihi.Size = new System.Drawing.Size(196, 22);
            this.txtDogumTarihi.TabIndex = 4;
            this.txtDogumTarihi.Value = new System.DateTime(2019, 12, 18, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(324, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Cinsiyet :";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.AutoCompleteCustomSource.AddRange(new string[] {
            "Bay",
            "Bayan"});
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.IntegralHeight = false;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(387, 111);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(61, 24);
            this.cmbCinsiyet.TabIndex = 7;
            // 
            // cmbKanGrubu
            // 
            this.cmbKanGrubu.AutoCompleteCustomSource.AddRange(new string[] {
            "Bay",
            "Bayan"});
            this.cmbKanGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKanGrubu.FormattingEnabled = true;
            this.cmbKanGrubu.IntegralHeight = false;
            this.cmbKanGrubu.Items.AddRange(new object[] {
            "AB Rh+",
            "AB Rh-",
            "A Rh+",
            "A Rh-",
            "B Rh+",
            "B Rh-",
            "O Rh+",
            "O Rh-"});
            this.cmbKanGrubu.Location = new System.Drawing.Point(387, 141);
            this.cmbKanGrubu.Name = "cmbKanGrubu";
            this.cmbKanGrubu.Size = new System.Drawing.Size(61, 24);
            this.cmbKanGrubu.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(309, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "Kan Grubu :";
            // 
            // cmbMedeniHal
            // 
            this.cmbMedeniHal.AutoCompleteCustomSource.AddRange(new string[] {
            "Bay",
            "Bayan"});
            this.cmbMedeniHal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedeniHal.FormattingEnabled = true;
            this.cmbMedeniHal.IntegralHeight = false;
            this.cmbMedeniHal.Items.AddRange(new object[] {
            "Evli",
            "Bekar"});
            this.cmbMedeniHal.Location = new System.Drawing.Point(522, 124);
            this.cmbMedeniHal.Name = "cmbMedeniHal";
            this.cmbMedeniHal.Size = new System.Drawing.Size(61, 24);
            this.cmbMedeniHal.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(449, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Medeni Hal :";
            // 
            // txtYakınTelefon
            // 
            this.txtYakınTelefon.Location = new System.Drawing.Point(427, 270);
            this.txtYakınTelefon.MaxLength = 11;
            this.txtYakınTelefon.Name = "txtYakınTelefon";
            this.txtYakınTelefon.Size = new System.Drawing.Size(156, 22);
            this.txtYakınTelefon.TabIndex = 14;
            this.txtYakınTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYakınTelefon_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(303, 276);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 16);
            this.label16.TabIndex = 31;
            this.label16.Text = "Yakın Telefon No :";
            // 
            // txtYakinSicilNo
            // 
            this.txtYakinSicilNo.Location = new System.Drawing.Point(427, 298);
            this.txtYakinSicilNo.MaxLength = 11;
            this.txtYakinSicilNo.Name = "txtYakinSicilNo";
            this.txtYakinSicilNo.Size = new System.Drawing.Size(156, 22);
            this.txtYakinSicilNo.TabIndex = 15;
            this.txtYakinSicilNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYakinSicilNo_KeyPress);
            // 
            // txtYakinKurumSicilNo
            // 
            this.txtYakinKurumSicilNo.AutoSize = true;
            this.txtYakinKurumSicilNo.Location = new System.Drawing.Point(284, 304);
            this.txtYakinKurumSicilNo.Name = "txtYakinKurumSicilNo";
            this.txtYakinKurumSicilNo.Size = new System.Drawing.Size(137, 16);
            this.txtYakinKurumSicilNo.TabIndex = 33;
            this.txtYakinKurumSicilNo.Text = "Yakın Kurum Sicil No :";
            // 
            // txtYakinKurum
            // 
            this.txtYakinKurum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtYakinKurum.Location = new System.Drawing.Point(427, 326);
            this.txtYakinKurum.MaxLength = 11;
            this.txtYakinKurum.Name = "txtYakinKurum";
            this.txtYakinKurum.Size = new System.Drawing.Size(156, 22);
            this.txtYakinKurum.TabIndex = 16;
            this.txtYakinKurum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYakinKurum_KeyPress);
            // 
            // txtYakinKurumAdi
            // 
            this.txtYakinKurumAdi.AutoSize = true;
            this.txtYakinKurumAdi.Location = new System.Drawing.Point(284, 332);
            this.txtYakinKurumAdi.Name = "txtYakinKurumAdi";
            this.txtYakinKurumAdi.Size = new System.Drawing.Size(139, 16);
            this.txtYakinKurumAdi.TabIndex = 35;
            this.txtYakinKurumAdi.Text = "Yakın Kurum Sicil Adı :";
            // 
            // FormHastaBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(590, 429);
            this.Controls.Add(this.txtYakinKurum);
            this.Controls.Add(this.txtYakinKurumAdi);
            this.Controls.Add(this.txtYakinSicilNo);
            this.Controls.Add(this.txtYakinKurumSicilNo);
            this.Controls.Add(this.txtYakınTelefon);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbMedeniHal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbKanGrubu);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDogumTarihi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTelefonNo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtKurumSicilNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtKurumAdi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAnneAdı);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBabaAdı);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbDogumYeri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTcKimlik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDosyaAdı);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHastaBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<Hasta Bilgileri>";
            this.Load += new System.EventHandler(this.FormHastaBilgileri_Load);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label txtYakinKurumSicilNo;
        private System.Windows.Forms.Label txtYakinKurumAdi;
        public System.Windows.Forms.TextBox txtDosyaAdı;
        public System.Windows.Forms.TextBox txtAd;
        public System.Windows.Forms.TextBox txtTcKimlik;
        public System.Windows.Forms.TextBox txtSoyad;
        public System.Windows.Forms.ComboBox cmbDogumYeri;
        public System.Windows.Forms.TextBox txtBabaAdı;
        public System.Windows.Forms.TextBox txtAnneAdı;
        public System.Windows.Forms.TextBox txtAdres;
        public System.Windows.Forms.TextBox txtKurumAdi;
        public System.Windows.Forms.TextBox txtKurumSicilNo;
        public System.Windows.Forms.TextBox txtTelefonNo;
        public System.Windows.Forms.DateTimePicker txtDogumTarihi;
        public System.Windows.Forms.ComboBox cmbCinsiyet;
        public System.Windows.Forms.ComboBox cmbKanGrubu;
        public System.Windows.Forms.ComboBox cmbMedeniHal;
        public System.Windows.Forms.TextBox txtYakınTelefon;
        public System.Windows.Forms.TextBox txtYakinSicilNo;
        public System.Windows.Forms.TextBox txtYakinKurum;
        public System.Windows.Forms.Button btnKaydet;
        public System.Windows.Forms.Button btnYeni;
    }
}