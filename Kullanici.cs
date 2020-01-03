using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SaglikOcagiSistem
{
    class Kullanici : Veritabani
    {
        public static string tckontrol = "";
        public static string usernamekontrol = "";
        private static int _KullaniciSayisi;
        private static string _KullaniciKodu;
        public static string KullaniciKodu
        {
            get 
            {
                Veritabani.Ac();
                SqlCommand cmd = new SqlCommand("Sayi", Veritabani.baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                _KullaniciSayisi = Convert.ToInt32(cmd.ExecuteScalar());
                Veritabani.Kapa();
                if (_KullaniciSayisi <= 9)
                    _KullaniciKodu = "0000" + (_KullaniciSayisi + 1).ToString();
                if (_KullaniciSayisi <= 99 && _KullaniciSayisi >= 10)
                    _KullaniciKodu = "000" + (_KullaniciSayisi + 1).ToString();
                if (_KullaniciSayisi <= 999 && _KullaniciSayisi >= 100)
                    _KullaniciKodu = "00" + (_KullaniciSayisi + 1).ToString();
                if (_KullaniciSayisi <= 9999 && _KullaniciSayisi >= 1000)
                    _KullaniciKodu = "0" + (_KullaniciSayisi + 1).ToString();
                if (_KullaniciSayisi <= 9999 && _KullaniciSayisi >= 10000)
                    _KullaniciKodu = (_KullaniciSayisi + 1).ToString();
                return _KullaniciKodu; 
            }
        }
        private static string _KullaniciAd;
        private static string _KullaniciSoyad;
        private static string _KullaniciSifre;
        private static string _KullaniciYetki;
        private static string _KullaniciEvTel;
        private static string _KullaniciCepTel;
        private static string _KullaniciAdres;
        private static string _KullaniciUnvan;
        private static DateTime _KullaniciIseBaslama;
        private static string _KullaniciMaas;
        private static string _KullaniciDogumYeri;
        private static string _KullaniciAnneAdi;
        private static string _KullaniciBabaAdi;
        private static string _KullaniciCinsiyet;
        private static string _KullaniciKanGrubu;
        private static string _KullaniciMedeniHal;
        private static DateTime _KullaniciDogumTarihi;
        private static string _KullaniciTCKimlik;
        private static string _KullaniciUserame;
        private static string _KullaniciPoliklinik;


        public static void KullaniciGetirCombo(ComboBox combo)
        {
            combo.Focus();
            combo.Items.Clear();
            Veritabani.Ac();
            SqlCommand cmd = new SqlCommand("KullaniciGetir", Veritabani.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@KULLANICI_AD", DBNull.Value);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //_KullaniciSayisi++;
                combo.Items.Add(dr["USERNAME"].ToString());
            }
            Veritabani.Kapa();
        }
        private static bool KullaniciUsername(string text)
        {
            bool durum = false;
            Veritabani.Ac();
            SqlCommand cmd = new SqlCommand("KullaniciAraUsername", Veritabani.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USERNAME", text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                durum = true;
            }
            return durum;
            Veritabani.Kapa();
        }
        public static bool KullaniciAra(string text)
        {
            bool durum = false;
            Veritabani.Ac();
            SqlCommand cmd = new SqlCommand("KullaniciGetir", Veritabani.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@KULLANICI_AD", text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                    _KullaniciKodu = dr["K_KODU"].ToString();
                    _KullaniciAd = dr["AD"].ToString();
                    _KullaniciSoyad = dr["SOYAD"].ToString();
                    _KullaniciSifre = dr["SIFRE"].ToString();
                    _KullaniciYetki = dr["YETKİ"].ToString();
                    _KullaniciEvTel = dr["EV_TEL"].ToString();
                    _KullaniciCepTel = dr["CEP_TEL"].ToString();
                    _KullaniciAdres = dr["ADRES"].ToString();
                    _KullaniciUnvan = dr["UNVAN"].ToString();
                    _KullaniciIseBaslama = Convert.ToDateTime(dr["ISE_BASLAMA"].ToString()).Date;
                    _KullaniciMaas = dr["MAAS"].ToString();
                    _KullaniciDogumYeri = dr["DOGUM_YERI"].ToString();
                    _KullaniciAnneAdi = dr["ANNE_ADI"].ToString();
                    _KullaniciBabaAdi = dr["BABA_ADI"].ToString();
                    _KullaniciCinsiyet = dr["CINSIYET"].ToString();
                    _KullaniciKanGrubu = dr["KAN_GRUBU"].ToString();
                    _KullaniciMedeniHal = dr["MEDENI_HAL"].ToString();
                    _KullaniciDogumTarihi = Convert.ToDateTime(dr["DOGUM_TARIHI"].ToString());
                    _KullaniciTCKimlik = dr["TCKIMLIK_NO"].ToString();
                    _KullaniciUserame = dr["USERNAME"].ToString();
                _KullaniciPoliklinik =dr["POLIKLINIK_ID"].ToString() +" - "+ dr["POLIKLINIK_AD"].ToString();
                    durum = true;
            }
            return durum;
            Veritabani.Kapa();
        }
        public static void FormDuzenlemeKontrol(bool durum,Form form)
        {
            if (durum)
            {
                FormAc.aktifForm = null;
                FormAc.Open(new FormKullaniciDuzenleme());
                ((FormKullaniciDuzenleme)(FormAc.aktifForm)).txtKullaniciKod.Text = _KullaniciKodu;
                ((FormKullaniciDuzenleme)(FormAc.aktifForm)).txtTCKimlik.Text = _KullaniciTCKimlik;
                ((FormKullaniciDuzenleme)(FormAc.aktifForm)).cmbDogumYeri.Text = _KullaniciDogumYeri;
                ((FormKullaniciDuzenleme)(FormAc.aktifForm)).txtAnneAdi.Text = _KullaniciAnneAdi;
                ((FormKullaniciDuzenleme)(FormAc.aktifForm)).txtBabaAdi.Text = _KullaniciBabaAdi;
                ((FormKullaniciDuzenleme)(FormAc.aktifForm)).txtTelefonNo.Text = _KullaniciEvTel;
                ((FormKullaniciDuzenleme)(FormAc.aktifForm)).txtGsmNo.Text = _KullaniciCepTel;
                if (_KullaniciYetki == "EVET")
                    ((FormKullaniciDuzenleme)(FormAc.aktifForm)).chckSecim.Checked = true;
                else
                    ((FormKullaniciDuzenleme)(FormAc.aktifForm)).chckSecim.Checked = false;
                ((FormKullaniciDuzenleme)(FormAc.aktifForm)).cmbUnvan.Text = _KullaniciUnvan;
                ((FormKullaniciDuzenleme)(FormAc.aktifForm)).txtAdi.Text = _KullaniciAd;
                ((FormKullaniciDuzenleme)(FormAc.aktifForm)).txtSoyadi.Text = _KullaniciSoyad;
                ((FormKullaniciDuzenleme)(FormAc.aktifForm)).txtMaas.Text = _KullaniciMaas;
                ((FormKullaniciDuzenleme)(FormAc.aktifForm)).txtIseBaslangicTarihi.Value = _KullaniciIseBaslama;
                ((FormKullaniciDuzenleme)(FormAc.aktifForm)).txtDogumTarihi.Value = _KullaniciDogumTarihi;
                ((FormKullaniciDuzenleme)(FormAc.aktifForm)).cmbCinsiyet.Text = _KullaniciCinsiyet;
                ((FormKullaniciDuzenleme)(FormAc.aktifForm)).cmbKanGrubu.Text = _KullaniciKanGrubu;
                ((FormKullaniciDuzenleme)(FormAc.aktifForm)).cmbMedeniHal.Text = _KullaniciMedeniHal;
                ((FormKullaniciDuzenleme)(FormAc.aktifForm)).txtAdres.Text = _KullaniciAdres;
                ((FormKullaniciDuzenleme)(FormAc.aktifForm)).txtKullaniciAdi.Text = _KullaniciUserame;
                ((FormKullaniciDuzenleme)(FormAc.aktifForm)).txtSifre.Text = _KullaniciSifre;
                if(_KullaniciUnvan == "Doktor")
                {
                    ((FormKullaniciDuzenleme)(FormAc.aktifForm)).cmbPoliklinik.Visible = true;
                    ((FormKullaniciDuzenleme)(FormAc.aktifForm)).label20.Visible = true;
                    ((FormKullaniciDuzenleme)(FormAc.aktifForm)).cmbPoliklinik.Text = _KullaniciPoliklinik.ToString();
                }
                tckontrol = _KullaniciTCKimlik;
                usernamekontrol = _KullaniciUserame;
            }
            else
            {
                DialogResult result = MessageBox.Show("Böyle bir kullanıcı yok! Oluşturmak ister misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    FormAc.aktifForm = null;
                    FormAc.Open(new FormKullaniciDuzenleme());
                    ((FormKullaniciDuzenleme)(FormAc.aktifForm)).txtKullaniciKod.Text = KullaniciKodu;
                    ((FormKullaniciDuzenleme)(FormAc.aktifForm)).btnGuncelle.Text = "Kaydet";
                    ((FormKullaniciDuzenleme)(FormAc.aktifForm)).btnSil.Visible = true;
                    
                }
            }
        }
        private static bool KullaniciTcAra(string text)
        {
            bool durum = false;
            Veritabani.Ac();
            SqlCommand cmd = new SqlCommand("KullaniciAraTC", Veritabani.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@KULLANICI_TCKIMLIKNO", text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                durum = true;
            }
            return durum;
            Veritabani.Kapa();
        }
        public static void KullaniciEkle(FormKullaniciDuzenleme form)
        {
            if(form.txtKullaniciAdi.Text !="" && form.txtAdi.Text !="" && form.txtSoyadi.Text != ""&& form.txtSifre.Text !="" && form.txtTCKimlik.Text != null)
            {
                if (KullaniciTcAra(form.txtTCKimlik.Text) && KullaniciUsername(form.txtKullaniciAdi.Text))
                {
                    if (!KullaniciAra(form.txtKullaniciAdi.Text))
                    {
                        Veritabani.Ac();
                        SqlCommand cmd = new SqlCommand("KullaniciEkle", Veritabani.baglanti);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@KULLANICI_KODU", form.txtKullaniciKod.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_ADI", form.txtAdi.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_SOYADI", form.txtSoyadi.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_SIFRE", form.txtSifre.Text);
                        if (form.chckSecim.Checked)
                            cmd.Parameters.AddWithValue("@KULLANICI_YETKI", "EVET");
                        else
                            cmd.Parameters.AddWithValue("@KULLANICI_YETKI", "HAYIR");
                        cmd.Parameters.AddWithValue("@KULLANICI_EVTEL", form.txtTelefonNo.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_CEPTEL", form.txtGsmNo.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_ADRES", form.txtAdres.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_UNVAN", form.cmbUnvan.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_ISEBASLAMATARIHI", form.txtIseBaslangicTarihi.Value.Date);
                        cmd.Parameters.AddWithValue("@KULLANICI_MAAS", form.txtMaas.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_DOGUMYERİ", form.cmbDogumYeri.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_ANNEADI", form.txtAnneAdi.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_BABAADI", form.txtBabaAdi.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_CINSIYET", form.cmbCinsiyet.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_KANGRUBU", form.cmbKanGrubu.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_MEDENIHAL", form.cmbMedeniHal.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_DOGUMTARIHI", form.txtDogumTarihi.Value.Date);
                        cmd.Parameters.AddWithValue("@KULLANICI_TCKIMLIK", form.txtTCKimlik.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_USERNAME", form.txtKullaniciAdi.Text);
                        if (form.cmbPoliklinik.Visible == true)
                            cmd.Parameters.AddWithValue("@POLIKLINIK_ID", Convert.ToInt32(form.cmbPoliklinik.Text.Split('-')[0].Trim()));
                        else
                            cmd.Parameters.AddWithValue("@POLIKLINIK_ID", DBNull.Value);
                        int count = cmd.ExecuteNonQuery();
                        if (count == 1)
                        {
                            MessageBox.Show("Ekleme İşlemi Başarılı!");
                            ((FormKullaniciDuzenleme)(FormAc.aktifForm)).btnGuncelle.Text = "Güncelle";
                            ((FormKullaniciDuzenleme)(FormAc.aktifForm)).btnSil.Visible = true;
                        }

                        else
                            MessageBox.Show("Ekleme İşlemi Başarısız!");
                        Veritabani.Kapa();
                    }
                    else
                        MessageBox.Show("Aynı Kullanıcı Adıyla Daha önce kayıt olunmuş!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Aynı TC Kimlik Numarasından ve Usernameden Yanlız Bir kayıt olabilir!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Kontrol.Mesaj("Kontrol et!", form.txtTCKimlik);
                Kontrol.Mesaj("Kontrol et!", form.txtAdi);
                Kontrol.Mesaj("Kontrol et!", form.txtSoyadi);
                Kontrol.Mesaj("Kontrol et!", form.txtKullaniciAdi);
                Kontrol.Mesaj("Kontrol et!", form.txtSifre);
            }
            
        }
        public static void KullaniciGuncelle(FormKullaniciDuzenleme form)
        {
            if (form.txtKullaniciAdi.Text != "" && form.txtAdi.Text != "" && form.txtSoyadi.Text != "" && form.txtSifre.Text != "" && form.txtTCKimlik.Text != "")
            {
                if (tckontrol != form.txtTCKimlik.Text && usernamekontrol != form.txtKullaniciAdi.Text)
                {
                    if (!KullaniciTcAra(form.txtTCKimlik.Text) && !KullaniciUsername(form.txtKullaniciAdi.Text))
                    {
                        Veritabani.Ac();
                        SqlCommand cmd = new SqlCommand("KullaniciGuncelle", Veritabani.baglanti);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@KULLANICI_KODU", form.txtKullaniciKod.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_ADI", form.txtAdi.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_SOYADI", form.txtSoyadi.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_SIFRE", form.txtSifre.Text);
                        if (form.chckSecim.Checked)
                            cmd.Parameters.AddWithValue("@KULLANICI_YETKI", "EVET");
                        else
                            cmd.Parameters.AddWithValue("@KULLANICI_YETKI", "HAYIR");
                        cmd.Parameters.AddWithValue("@KULLANICI_EVTEL", form.txtTelefonNo.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_CEPTEL", form.txtGsmNo.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_ADRES", form.txtAdres.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_UNVAN", form.cmbUnvan.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_ISEBASLAMATARIHI", form.txtIseBaslangicTarihi.Value.Date);
                        cmd.Parameters.AddWithValue("@KULLANICI_MAAS", form.txtMaas.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_DOGUMYERİ", form.cmbDogumYeri.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_ANNEADI", form.txtAnneAdi.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_BABAADI", form.txtBabaAdi.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_CINSIYET", form.cmbCinsiyet.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_KANGRUBU", form.cmbKanGrubu.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_MEDENIHAL", form.cmbMedeniHal.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_DOGUMTARIHI", form.txtDogumTarihi.Value.Date);
                        cmd.Parameters.AddWithValue("@KULLANICI_TCKIMLIK", form.txtTCKimlik.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_USERNAME", form.txtKullaniciAdi.Text);
                        if (form.cmbPoliklinik.Visible == true)
                            cmd.Parameters.AddWithValue("@POLIKLINIK_ID", Convert.ToInt32(form.cmbPoliklinik.Text.Split('-')[0].Trim()));
                        else
                            cmd.Parameters.AddWithValue("@POLIKLINIK_ID", DBNull.Value);
                        int count = cmd.ExecuteNonQuery();
                        if (count == 1)
                        {
                            MessageBox.Show("Güncelleme İşlemi Başarılı!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tckontrol = form.txtTCKimlik.Text;
                            usernamekontrol = form.txtKullaniciAdi.Text;
                        }
                        else
                            MessageBox.Show("Güncelleme İşlemi Başarısız!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Veritabani.Kapa();
                    }
                    else
                        MessageBox.Show("Aynı TC Kimlik Numarasından ve Usernameden Yanlız Bir kayıt olabilir!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if(tckontrol == form.txtTCKimlik.Text && usernamekontrol != form.txtKullaniciAdi.Text){
                    if (!KullaniciUsername(form.txtKullaniciAdi.Text))
                    {
                        Veritabani.Ac();
                        SqlCommand cmd = new SqlCommand("KullaniciGuncelle", Veritabani.baglanti);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@KULLANICI_KODU", form.txtKullaniciKod.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_ADI", form.txtAdi.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_SOYADI", form.txtSoyadi.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_SIFRE", form.txtSifre.Text);
                        if (form.chckSecim.Checked)
                            cmd.Parameters.AddWithValue("@KULLANICI_YETKI", "EVET");
                        else
                            cmd.Parameters.AddWithValue("@KULLANICI_YETKI", "HAYIR");
                        cmd.Parameters.AddWithValue("@KULLANICI_EVTEL", form.txtTelefonNo.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_CEPTEL", form.txtGsmNo.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_ADRES", form.txtAdres.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_UNVAN", form.cmbUnvan.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_ISEBASLAMATARIHI", form.txtIseBaslangicTarihi.Value.Date);
                        cmd.Parameters.AddWithValue("@KULLANICI_MAAS", form.txtMaas.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_DOGUMYERİ", form.cmbDogumYeri.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_ANNEADI", form.txtAnneAdi.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_BABAADI", form.txtBabaAdi.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_CINSIYET", form.cmbCinsiyet.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_KANGRUBU", form.cmbKanGrubu.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_MEDENIHAL", form.cmbMedeniHal.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_DOGUMTARIHI", form.txtDogumTarihi.Value.Date);
                        cmd.Parameters.AddWithValue("@KULLANICI_TCKIMLIK", form.txtTCKimlik.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_USERNAME", form.txtKullaniciAdi.Text);
                        if (form.cmbPoliklinik.Visible == true)
                            cmd.Parameters.AddWithValue("@POLIKLINIK_ID", Convert.ToInt32(form.cmbPoliklinik.Text.Split('-')[0].Trim()));
                        else
                            cmd.Parameters.AddWithValue("@POLIKLINIK_ID", DBNull.Value);
                        int count = cmd.ExecuteNonQuery();
                        if (count == 1)
                        {
                            MessageBox.Show("Güncelleme İşlemi Başarılı!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tckontrol = form.txtTCKimlik.Text;
                            usernamekontrol = form.txtKullaniciAdi.Text;
                        }
                        else
                            MessageBox.Show("Güncelleme İşlemi Başarısız!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Veritabani.Kapa();
                    }
                    else
                        MessageBox.Show("Aynı kullanıcı adından 1 kayıt olabilir!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (tckontrol != form.txtTCKimlik.Text && usernamekontrol == form.txtKullaniciAdi.Text)
                {
                    if (!KullaniciTcAra(form.txtTCKimlik.Text)){
                        Veritabani.Ac();
                        SqlCommand cmd = new SqlCommand("KullaniciGuncelle", Veritabani.baglanti);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@KULLANICI_KODU", form.txtKullaniciKod.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_ADI", form.txtAdi.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_SOYADI", form.txtSoyadi.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_SIFRE", form.txtSifre.Text);
                        if (form.chckSecim.Checked)
                            cmd.Parameters.AddWithValue("@KULLANICI_YETKI", "EVET");
                        else
                            cmd.Parameters.AddWithValue("@KULLANICI_YETKI", "HAYIR");
                        cmd.Parameters.AddWithValue("@KULLANICI_EVTEL", form.txtTelefonNo.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_CEPTEL", form.txtGsmNo.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_ADRES", form.txtAdres.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_UNVAN", form.cmbUnvan.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_ISEBASLAMATARIHI", form.txtIseBaslangicTarihi.Value.Date);
                        cmd.Parameters.AddWithValue("@KULLANICI_MAAS", form.txtMaas.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_DOGUMYERİ", form.cmbDogumYeri.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_ANNEADI", form.txtAnneAdi.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_BABAADI", form.txtBabaAdi.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_CINSIYET", form.cmbCinsiyet.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_KANGRUBU", form.cmbKanGrubu.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_MEDENIHAL", form.cmbMedeniHal.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_DOGUMTARIHI", form.txtDogumTarihi.Value.Date);
                        cmd.Parameters.AddWithValue("@KULLANICI_TCKIMLIK", form.txtTCKimlik.Text);
                        cmd.Parameters.AddWithValue("@KULLANICI_USERNAME", form.txtKullaniciAdi.Text);
                        if (form.cmbPoliklinik.Visible == true)
                            cmd.Parameters.AddWithValue("@POLIKLINIK_ID", Convert.ToInt32(form.cmbPoliklinik.Text.Split('-')[0].Trim()));
                        else
                            cmd.Parameters.AddWithValue("@POLIKLINIK_ID", DBNull.Value);
                        int count = cmd.ExecuteNonQuery();
                        if (count == 1)
                        {
                            MessageBox.Show("Güncelleme İşlemi Başarılı!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tckontrol = form.txtTCKimlik.Text;
                            usernamekontrol = form.txtKullaniciAdi.Text;
                        }
                        else
                            MessageBox.Show("Güncelleme İşlemi Başarısız!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Veritabani.Kapa();
                    }
                    else
                        MessageBox.Show("Aynı Tcden 1 kayıt olabilir!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            else
            {
                Kontrol.Mesaj("Kontrol et!", form.txtTCKimlik);
                Kontrol.Mesaj("Kontrol et!", form.txtAdi);
                Kontrol.Mesaj("Kontrol et!", form.txtSoyadi);
                Kontrol.Mesaj("Kontrol et!", form.txtKullaniciAdi);
                Kontrol.Mesaj("Kontrol et!", form.txtSifre);
            }

        }
        public static void KullaniciSil(FormKullaniciDuzenleme form)
        {
            DialogResult dialogResult = MessageBox.Show("Silmek İstediğinizden Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dialogResult == DialogResult.Yes)
            {
                Veritabani.Ac();
                SqlCommand cmd = new SqlCommand("KullaniciSil", Veritabani.baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@KULLANICI_KODU", form.txtKullaniciKod.Text);
                int count = cmd.ExecuteNonQuery();

                if (count == 1)
                {
                    MessageBox.Show("Silme İşlemi Başarılı!");
                    
                }
                else
                    MessageBox.Show("Silme İşlemi Başarısız!");
            }
            form.Close();
            Veritabani.Kapa();
        }
    }
}
