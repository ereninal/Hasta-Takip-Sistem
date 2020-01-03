using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SaglikOcagiSistem
{
    class Hasta:Rapor
    {
        private static string _HastaTcKimlik;
        private static string _HastaDosyaNo;
        private static string _HastaAd;
        private static string _HastaSoyad;
        private static string _HastaDogumYeri;
        private static DateTime _HastaDogumTarihi;
        private static string _HastaBabaAdi;
        private static string _HastaAnneAdi;
        private static string _HastaCinsiyet;
        private static string _HastaKanGrubu;
        private static string _HastaMedeniHal;
        private static string _HastaAdres;
        private static string _HastaTelNo;
        private static string _HastaKurumSicilNo;
        private static string _HastaKurumAdi;
        private static string _HastaYakinTel;
        private static string _HastaYakinKurumSicilNo;
        private static string _HastaYakinKurumAdi;
        private static int _HastaToplamFiyat =0;
        private static string tckimlikno = "";//hasta işlemlerinde tc kontrolü için
        private static int _KullaniciSayisi;
        private static string _KullaniciKodu;
        public static string KullaniciKodu
        {
            get
            {
                Veritabani.Ac();
                SqlCommand cmd = new SqlCommand("HastaSayi", Veritabani.baglanti);
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
        public static void HastaBilgiGetir(FormHastaIslemleri frm, string dosya)
        {
            Veritabani.Ac();
            SqlCommand cmd = new SqlCommand("HastaGetir", Veritabani.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@HASTA_DOSYA_NO", dosya);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                
                _HastaTcKimlik = dr["TCKIMLIK_NO"].ToString();
                _HastaDosyaNo = dr["DOSYA_NO"].ToString();
                _HastaAd = dr["AD"].ToString();
                _HastaSoyad = dr["SOYAD"].ToString();
                _HastaDogumYeri = dr["DOGUM_YERI"].ToString();
                _HastaDogumTarihi = Convert.ToDateTime(dr["DOGUM_TARIHI"].ToString()).Date;
                _HastaBabaAdi = dr["BABA_ADI"].ToString();
                _HastaAnneAdi = dr["ANNE_ADI"].ToString();
                _HastaCinsiyet = dr["CINSIYET"].ToString();
                _HastaKanGrubu = dr["KAN_GRUBU"].ToString();
                _HastaMedeniHal = dr["MEDENI_HAL"].ToString();
                _HastaAdres = dr["ADRES"].ToString();
                _HastaTelNo = dr["TEL"].ToString();
                _HastaKurumSicilNo = dr["KURUM_SICIL_NO"].ToString();
                _HastaKurumAdi = dr["KURUM_ADI"].ToString();
                _HastaYakinTel = dr["YAKIN_TEL"].ToString();
                _HastaYakinKurumAdi = dr["YAKIN_KURUM_ADI"].ToString();
                _HastaYakinKurumSicilNo = dr["YAKIN_KURUM_SICIL_NO"].ToString();
                Rapor._HastaAd = dr["AD"].ToString();
                Rapor._HastaSoyad = dr["SOYAD"].ToString();
                Rapor._HastaAnneAdi = dr["ANNE_ADI"].ToString();
                Rapor._HastaBabaAdi =  dr["BABA_ADI"].ToString();
                Rapor._HastaDogumTarihi = Convert.ToDateTime(dr["DOGUM_TARIHI"].ToString()).Date;
                Rapor._HastaTcKimlik = _HastaTcKimlik = dr["TCKIMLIK_NO"].ToString();
                frm.txtHastaAdi.Text = dr["AD"].ToString();
                frm.txtHastaSoyAdi.Text = dr["SOYAD"].ToString();
                frm.txtKurumAdi.Text = dr["KURUM_ADI"].ToString();
                tckimlikno = _HastaTcKimlik;
            }
            else
                Kontrol.Mesaj("Bu dosya numarasına ait kayıt bulunamadı", frm.txtDosyaAdi);
            
            Veritabani.Kapa();
        }
        public static void OncekiIslemGetir(FormHastaIslemleri frm)
        {
            frm.cmbOncekiIslem.Items.Clear();
            if(frm.txtDosyaAdi.Text != "00000" && frm.txtDosyaAdi.Text != "")
            {
                Veritabani.Ac();
                SqlCommand cmd = new SqlCommand("OncekiIslemGetir", Veritabani.baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HASTA_DOSYA_NO", _HastaDosyaNo);
                cmd.Parameters.AddWithValue("@DURUM", "HAYIR");
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if(!frm.cmbOncekiIslem.Items.Contains(Convert.ToDateTime(dr["SEVK_TARİHİ"].ToString()).ToShortDateString()))
                        frm.cmbOncekiIslem.Items.Add(Convert.ToDateTime(dr["SEVK_TARİHİ"].ToString()).ToShortDateString());

                }
                Veritabani.Kapa();
            }
            
        }
        public static void DatadridviewDoldur(string tarih,string dosyano, FormHastaIslemleri frm)
        {
            _HastaToplamFiyat = 0;
            Veritabani.Ac();
            SqlCommand cmd = new SqlCommand("OncekiIslemlerTarihDosya", Veritabani.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@HASTA_DOSYA_NO", dosyano);
            cmd.Parameters.AddWithValue("@HASTA_TARIH",Convert.ToDateTime(tarih).Date);
            cmd.Parameters.AddWithValue("@DURUM","HAYIR");
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                frm.datagridSevk.Rows.Add(dr["SEVK_ID"].ToString(), dr["POLIKLINIK_AD"].ToString(), dr["SIRA"].ToString(),Convert.ToDateTime( dr["SAAT"].ToString()).ToShortTimeString(), dr["YAPILAN_ISLEM"].ToString(),
                    dr["AD"].ToString()+" "+dr["SOYAD"].ToString(), dr["MIKTAR"].ToString(), dr["BIRIM_FIYAT"].ToString());
                _HastaToplamFiyat += Convert.ToInt32(dr["MIKTAR"].ToString()) * Convert.ToInt32(dr["BIRIM_FIYAT"].ToString());
            }
            frm.lblFİyat.Text = (_HastaToplamFiyat.ToString()) +" TL";
            Veritabani.Kapa();
        }
        public static void FormHastaBilgileri(FormHastaBilgileri frm)
        {
            if (_HastaDosyaNo != null)
            {
                frm.txtDosyaAdı.Text = _HastaDosyaNo;
                frm.txtAd.Text = _HastaAd;
                frm.txtSoyad.Text = _HastaSoyad;
                frm.txtTcKimlik.Text = _HastaTcKimlik;
                frm.txtAnneAdı.Text = _HastaAnneAdi;
                frm.txtBabaAdı.Text = _HastaBabaAdi;
                frm.txtDogumTarihi.Value = _HastaDogumTarihi;
                frm.cmbDogumYeri.Text = _HastaDogumYeri;
                frm.cmbCinsiyet.Text = _HastaCinsiyet;
                frm.cmbKanGrubu.Text = _HastaKanGrubu;
                frm.cmbMedeniHal.Text = _HastaMedeniHal;
                frm.txtAdres.Text = _HastaAdres;
                frm.txtTelefonNo.Text = _HastaTelNo;
                frm.txtKurumAdi.Text = _HastaKurumAdi;
                frm.txtKurumSicilNo.Text = _HastaKurumSicilNo;
                frm.txtYakınTelefon.Text = _HastaYakinTel;
                frm.txtYakinKurum.Text = _HastaYakinKurumAdi;
                frm.txtYakinSicilNo.Text = _HastaYakinKurumSicilNo;
                FormAc.Open(frm);
            }
            else
            {
                Kontrol.Mesaj("Boş Geçilemez", frm.txtDosyaAdı);
                frm.txtDosyaAdı.Focus();
            }
                
        }
        public static void AktifPoliklinikGetir(ComboBox cmb)
        {
            Veritabani.Ac();
            cmb.Items.Clear();
            SqlCommand cmd = new SqlCommand("PoliklinikGetir", Veritabani.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@POLIKLINIK_AD", DBNull.Value);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["DURUM"].ToString() == "AKTİF") 
                    cmb.Items.Add(dr["POLIKLINIK_ID"]+" - "+dr["POLIKLINIK_AD"].ToString());
            }
            Veritabani.Kapa();
        }
        public static void IslemGetir(FormHastaIslemleri form)
        {
            if(form.cmbIslem.SelectedItem == null)
            {
                form.cmbIslem.Items.Clear();
                Veritabani.Ac();
                SqlCommand cmd = new SqlCommand("IslemGetir", Veritabani.baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ISLEM_AD", DBNull.Value);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    form.cmbIslem.Items.Add(dr["ISLEM_ADI"].ToString());
                Veritabani.Kapa();
            }
            else
            {
                Veritabani.Ac();
                SqlCommand cmd = new SqlCommand("IslemGetir", Veritabani.baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ISLEM_AD", form.cmbIslem.SelectedItem.ToString());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                   form.txtFiyat.Text =(dr["BIRIM_FIYAT"].ToString());
                Veritabani.Kapa();
            }

        }
        public static void DoktorGetir(FormHastaIslemleri form)
        {
            if(form.cmbPoliklinik.SelectedItem != null)
            {
                form.cmbDoktorlar.Items.Clear();
                Veritabani.Ac();
                SqlCommand cmd = new SqlCommand("DoktorGetirPoliklinik", Veritabani.baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@POLIKLINIK_ID", Convert.ToInt32(form.cmbPoliklinik.Text.Split('-')[0].Trim()));
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    form.cmbDoktorlar.Items.Add(dr["AD"] + " " + dr["SOYAD"]);
                
            }
        }
        public static void SevkEkle(FormHastaIslemleri frm)
        {
            if(frm.txtDosyaAdi.Text != "" && frm.dateSevk.Value.Date != null && frm.cmbIslem.SelectedItem != "" && frm.cmbPoliklinik.Text != "")
            {
                Veritabani.Ac();
                SqlCommand cmd = new SqlCommand("PoliklinikSiraYaz", Veritabani.baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DOKTOR_KOD", frm.txtDosyaAdi.Text);
                cmd.Parameters.AddWithValue("@TARIH", frm.dateSevk.Value.Date);
                cmd.Parameters.AddWithValue("@SIRA_NO", frm.txtSiraNo.Text);
                if(cmd.ExecuteNonQuery() == 1)
                {
  
                    SqlCommand cmd2 = new SqlCommand("SevkEkle", Veritabani.baglanti);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@POLIKLINIK_ADI", frm.cmbPoliklinik.Text.Split('-')[1].Trim());
                    cmd2.Parameters.AddWithValue("@SIRA", frm.txtSiraNo.Text);
                    cmd2.Parameters.AddWithValue("@YAPILAN_ISLEM", frm.cmbIslem.Text);
                    cmd2.Parameters.AddWithValue("@DOSYA_NO", frm.txtDosyaAdi.Text);
                    cmd2.Parameters.AddWithValue("@DOKTOR_AD", frm.cmbDoktorlar.Text.Split(' ')[0]);
                    cmd2.Parameters.AddWithValue("@DOKTOR_SOYAD", frm.cmbDoktorlar.Text.Split(' ')[1]);
                    cmd2.Parameters.AddWithValue("@MIKTAR", frm.numMiktar.Value.ToString());
                    cmd2.Parameters.AddWithValue("@BIRIM_FIYAT", frm.txtFiyat.Text.ToString());
                    cmd2.Parameters.AddWithValue("@TOPLAM_TUTAR", (Convert.ToInt32( frm.txtFiyat.Text) * Convert.ToInt32(frm.numMiktar.Value)).ToString());
                    cmd2.Parameters.AddWithValue("@TABURCU", "HAYIR");
                    cmd2.Parameters.AddWithValue("@SEVK_TARIH",frm.dateSevk.Value.Date);
                    cmd2.Parameters.AddWithValue("@SAAT", Convert.ToDateTime(DateTime.Now.ToShortTimeString()));
                    if(cmd2.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Sevk işlemi başarılı!","Mesaj",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        SiraArttir(frm);
                        frm.txtSiraNo.Text = ((Convert.ToInt32(frm.txtSiraNo.Text))+1).ToString();
                        DatadridviewDoldur(frm.dateSevk.Value.Date.ToShortDateString(), frm.txtDosyaAdi.Text, frm);
                    }
                }
                else
                    MessageBox.Show("Sevk işlemi başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Veritabani.Kapa();
            }
            else
            {
                Kontrol.Mesaj("Kontrol Et", frm.txtDosyaAdi);
                Kontrol.Mesaj("Kontrol Et", frm.dateSevk);
                Kontrol.Mesaj("Kontrol Et", frm.cmbIslem);
                Kontrol.Mesaj("Kontrol Et", frm.cmbPoliklinik);

            }
               
        }
        public static void PoliklinikSira(FormHastaIslemleri frm)
        {
            if(frm.cmbDoktorlar.Text != "" && frm.cmbPoliklinik.Text != null && frm.dateSevk.Value !=  null && frm.txtDosyaAdi.Text != null)
            {
                Veritabani.Ac();
                SqlCommand cmd = new SqlCommand("PoliklinikSiraGetir", Veritabani.baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DOKTOR_KOD", frm.txtDosyaAdi.Text);
                cmd.Parameters.AddWithValue("@TARIH", frm.dateSevk.Value.Date);
                cmd.Parameters.AddWithValue("@SIRA_NO", DBNull.Value);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                frm.txtSiraNo.Text = dr["SIRA_NO"].ToString();
                Veritabani.Kapa();
            }
        }
        private static void SiraArttir(FormHastaIslemleri frm)
        {
            SqlCommand cmd = new SqlCommand("PoliklinikSiraArttır", Veritabani.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DOKTOR_KOD", frm.txtDosyaAdi.Text);
            cmd.Parameters.AddWithValue("@TARIH", frm.dateSevk.Value.Date);
            cmd.Parameters.AddWithValue("@SIRA_NO", frm.txtSiraNo.Text);
            cmd.ExecuteNonQuery();
        }
        public static void FormTaburcuKontrol(FormTaburcu form,FormHastaIslemleri form1)
        {
            if(form1.datagridSevk.Rows.Count >=1 && form1.txtDosyaAdi.Text!="")
            {
                if(form1.cmbOncekiIslem.Text != "")
                {
                    form.txtDosyaNo.Text = _HastaDosyaNo;
                    form.dtCikis.Value = DateTime.Now;
                    form.dtSevk.Value = Convert.ToDateTime(form1.cmbOncekiIslem.Text).Date;
                    form.txtToplamTutar.Text = form1.lblFİyat.Text;
                    form.ShowDialog();
                }
                else
                {
                    form.txtDosyaNo.Text = _HastaDosyaNo;
                    form.dtCikis.Value = DateTime.Now;
                    form.dtSevk.Value = Convert.ToDateTime(form1.dateSevk.Value).Date;
                    form.txtToplamTutar.Text = form1.lblFİyat.Text;
                    form.ShowDialog();
                }
                
            }

            else
            {
                Kontrol.Mesaj("Kontrol ET!", form1.txtDosyaAdi);
            }
        }
        public static void HastaTaburcuEt(FormTaburcu form)
        {
            if(form.cmbOdeme.SelectedItem != null)
            {
                Veritabani.Ac();
                SqlCommand cmd = new SqlCommand("CikisEkle", Veritabani.baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DOSYA_NO", form.txtDosyaNo.Text);
                cmd.Parameters.AddWithValue("@SEVK_TARIHI", form.dtSevk.Value.Date);
                cmd.Parameters.AddWithValue("@CIKIS_SAATİ", DateTime.Now);
                cmd.Parameters.AddWithValue("@TOPLAM_TUTAR", form.txtToplamTutar.Text);
                cmd.Parameters.AddWithValue("@ODEME", form.cmbOdeme.Text);
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = new SqlCommand("SevkCikisGuncelle", Veritabani.baglanti);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@DURUM", "EVET");
                cmd1.Parameters.AddWithValue("@DOSYA_NO", form.txtDosyaNo.Text);
                cmd1.Parameters.AddWithValue("@SEVK_TARIH", form.dtSevk.Value.Date);
                cmd1.ExecuteNonQuery();
                Veritabani.Kapa();
                Hasta.DatadridviewDoldur(form.dtSevk.Value.ToShortDateString(), form.txtDosyaNo.Text, new FormHastaIslemleri());
                form.Close();
            }else
            {
                Kontrol.Mesaj("Ödeme Bilgisi Seçmediniz!", form.cmbOdeme);
            }
            
        }
        public static bool HastaAraTC(string tc)
        {
            bool durum = false;
            Veritabani.Ac();
            SqlCommand cmd = new SqlCommand("HastaAraTC", Veritabani.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TC", tc);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                durum = true;
            return durum;

        }
        public static void HastaEkle(FormHastaBilgileri form)
        {
            if(form.txtTcKimlik.Text !="" && form.txtAd.Text != "" && form.txtSoyad != null)
            {
                if (!HastaAraTC(form.txtTcKimlik.Text))
                {
                    Veritabani.Ac();
                    SqlCommand cmd = new SqlCommand("HastaEkle", Veritabani.baglanti);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TCKIMLIK_NO", form.txtTcKimlik.Text);
                    cmd.Parameters.AddWithValue("@DOSYA_NO", form.txtDosyaAdı.Text);
                    cmd.Parameters.AddWithValue("@AD", form.txtAd.Text);
                    cmd.Parameters.AddWithValue("@SOYAD", form.txtSoyad.Text);
                    cmd.Parameters.AddWithValue("@DOGUM_YERI", form.cmbDogumYeri.Text);
                    cmd.Parameters.AddWithValue("@DOGUM_TARIHI", form.txtDogumTarihi.Value.Date);
                    cmd.Parameters.AddWithValue("@BABA_AD", form.txtBabaAdı.Text);
                    cmd.Parameters.AddWithValue("@ANNE_AD", form.txtAnneAdı.Text);
                    cmd.Parameters.AddWithValue("@CINSIYET", form.cmbCinsiyet.Text);
                    cmd.Parameters.AddWithValue("@KAN_GRUBU", form.cmbKanGrubu.Text);
                    cmd.Parameters.AddWithValue("@MEDENI_HAL", form.cmbMedeniHal.Text);
                    cmd.Parameters.AddWithValue("@ADRES", form.txtAdres.Text);
                    cmd.Parameters.AddWithValue("@TEL", form.txtTelefonNo.Text);
                    cmd.Parameters.AddWithValue("@KURUM_SICIL_NO", form.txtKurumSicilNo.Text);
                    cmd.Parameters.AddWithValue("@KURUM_AD", form.txtKurumAdi.Text);
                    cmd.Parameters.AddWithValue("@YAKIN_TEL", form.txtYakınTelefon.Text);
                    cmd.Parameters.AddWithValue("@YAKIN_KURUM_SICIL_NO", form.txtYakinSicilNo.Text);
                    cmd.Parameters.AddWithValue("@YAKIN_KURUM_AD", form.txtKurumAdi.Text);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Ekleme Başarılı!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        form.btnKaydet.Text = "Güncelle";
                        tckimlikno = form.txtTcKimlik.Text;
                        
                    }
                    System.Threading.Thread.Sleep(2000);
                    //form.lblIslem.Visible = false;
                }
                else
                    MessageBox.Show("Aynı TC kimlik numarasına ait hasta mecvut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Kontrol.Mesaj("Kontrol Edin!", form.txtTcKimlik);
                Kontrol.Mesaj("Kontrol Edin!", form.txtAd);
                Kontrol.Mesaj("Kontrol Edin!", form.txtSoyad);
            }

        }
        public static void HastaGuncelle(FormHastaBilgileri form)
        {
            if (form.txtTcKimlik.Text != "" && form.txtAd.Text != "" && form.txtSoyad != null)
            {
                if(tckimlikno == form.txtTcKimlik.Text)
                {
                    Veritabani.Ac();
                    SqlCommand cmd = new SqlCommand("HastaGuncelle", Veritabani.baglanti);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TCKIMLIK_NO", form.txtTcKimlik.Text);
                    cmd.Parameters.AddWithValue("@DOSYA_NO", form.txtDosyaAdı.Text);
                    cmd.Parameters.AddWithValue("@AD", form.txtAd.Text);
                    cmd.Parameters.AddWithValue("@SOYAD", form.txtSoyad.Text);
                    cmd.Parameters.AddWithValue("@DOGUM_YERI", form.cmbDogumYeri.Text);
                    cmd.Parameters.AddWithValue("@DOGUM_TARIHI", form.txtDogumTarihi.Value.Date);
                    cmd.Parameters.AddWithValue("@BABA_AD", form.txtBabaAdı.Text);
                    cmd.Parameters.AddWithValue("@ANNE_AD", form.txtAnneAdı.Text);
                    cmd.Parameters.AddWithValue("@CINSIYET", form.cmbCinsiyet.Text);
                    cmd.Parameters.AddWithValue("@KAN_GRUBU", form.cmbKanGrubu.Text);
                    cmd.Parameters.AddWithValue("@MEDENI_HAL", form.cmbMedeniHal.Text);
                    cmd.Parameters.AddWithValue("@ADRES", form.txtAdres.Text);
                    cmd.Parameters.AddWithValue("@TEL", form.txtTelefonNo.Text);
                    cmd.Parameters.AddWithValue("@KURUM_SICIL_NO", form.txtKurumSicilNo.Text);
                    cmd.Parameters.AddWithValue("@KURUM_AD", form.txtKurumAdi.Text);
                    cmd.Parameters.AddWithValue("@YAKIN_TEL", form.txtYakınTelefon.Text);
                    cmd.Parameters.AddWithValue("@YAKIN_KURUM_SICIL_NO", form.txtYakinSicilNo.Text);
                    cmd.Parameters.AddWithValue("@YAKIN_KURUM_AD", form.txtKurumAdi.Text);
                    if (cmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("Güncelleme Başarılı!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    if (!HastaAraTC(form.txtTcKimlik.Text))
                    {
                        Veritabani.Ac();
                        SqlCommand cmd = new SqlCommand("HastaGuncelle", Veritabani.baglanti);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TCKIMLIK_NO", form.txtTcKimlik.Text);
                        cmd.Parameters.AddWithValue("@DOSYA_NO", form.txtDosyaAdı.Text);
                        cmd.Parameters.AddWithValue("@AD", form.txtAd.Text);
                        cmd.Parameters.AddWithValue("@SOYAD", form.txtSoyad.Text);
                        cmd.Parameters.AddWithValue("@DOGUM_YERI", form.cmbDogumYeri.Text);
                        cmd.Parameters.AddWithValue("@DOGUM_TARIHI", form.txtDogumTarihi.Value.Date);
                        cmd.Parameters.AddWithValue("@BABA_AD", form.txtBabaAdı.Text);
                        cmd.Parameters.AddWithValue("@ANNE_AD", form.txtAnneAdı.Text);
                        cmd.Parameters.AddWithValue("@CINSIYET", form.cmbCinsiyet.Text);
                        cmd.Parameters.AddWithValue("@KAN_GRUBU", form.cmbKanGrubu.Text);
                        cmd.Parameters.AddWithValue("@MEDENI_HAL", form.cmbMedeniHal.Text);
                        cmd.Parameters.AddWithValue("@ADRES", form.txtAdres.Text);
                        cmd.Parameters.AddWithValue("@TEL", form.txtTelefonNo.Text);
                        cmd.Parameters.AddWithValue("@KURUM_SICIL_NO", form.txtKurumSicilNo.Text);
                        cmd.Parameters.AddWithValue("@KURUM_AD", form.txtKurumAdi.Text);
                        cmd.Parameters.AddWithValue("@YAKIN_TEL", form.txtYakınTelefon.Text);
                        cmd.Parameters.AddWithValue("@YAKIN_KURUM_SICIL_NO", form.txtYakinSicilNo.Text);
                        cmd.Parameters.AddWithValue("@YAKIN_KURUM_AD", form.txtKurumAdi.Text);
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            tckimlikno = form.txtTcKimlik.Text;
                            MessageBox.Show("Güncelleme Başarılı!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                        MessageBox.Show("Aynı TC kimlik numarasına ait hasta mecvut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                Kontrol.Mesaj("Kontrol Edin!", form.txtTcKimlik);
                Kontrol.Mesaj("Kontrol Edin!", form.txtAd);
                Kontrol.Mesaj("Kontrol Edin!", form.txtSoyad);
            }
        }
        public static void HastaSevkSil(FormHastaIslemleri form)
        {
            DialogResult result = MessageBox.Show("Seçili satır silinecek devam edilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
            {
                Veritabani.Ac();
                SqlCommand cmd = new SqlCommand("SevkSil", Veritabani.baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SEVK_ID",Convert.ToInt32(form.datagridSevk.SelectedCells[0].Value.ToString()));
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Silme işlemi başarılı!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DatadridviewDoldur(form.dateSevk.Value.Date.ToShortDateString(), form.txtDosyaAdi.Text, form);
                }
                
            }
        }
    }
}
