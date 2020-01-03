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
    class Poliklinik : Veritabani
    {
        private static string poliklinik = "";
        private static string _PoliklinikAd ="";
        private static string _Aciklama = "";
        private static string _Durum = "";
        private static int _sayi=0;
        public static int sayi { get => _sayi; }
        public static string eski;//eski ada göre güncelleme yapıyorum
        public static void PoliklinikGetir(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            Veritabani.Ac();
            SqlCommand cmd = new SqlCommand("PoliklinikGetir", Veritabani.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@POLIKLINIK_AD", DBNull.Value);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                    comboBox.Items.Add(dr["POLIKLINIK_AD"].ToString());
                    _sayi++;
            }
            Veritabani.Kapa();
        }
        public static void PoliklinikGetirAktif(ComboBox cmb)
        {
            cmb.Items.Clear();
            Veritabani.Ac();
            SqlCommand cmd = new SqlCommand("PoliklinikGetirAktif", Veritabani.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@POLIKLINIK_AD", DBNull.Value);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb.Items.Add(dr["POLIKLINIK_AD"].ToString());
            }
            Veritabani.Kapa();
        }
        public static bool PoliklinikAra(string text)
        {
            bool durum = false;
            Veritabani.Ac();
            SqlCommand cmd = new SqlCommand("PoliklinikGetir", Veritabani.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@POLIKLINIK_AD", text);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                if (dr["POLIKLINIK_AD"].ToString() == text)
                {
                    _PoliklinikAd = dr["POLIKLINIK_AD"].ToString();
                    _Durum = dr["DURUM"].ToString();
                    _Aciklama = dr["ACIKLAMA"].ToString();
                    
                    durum = true;
                }
            }
            return durum;
        }
        public static void FormDuzenlemeKontrol(bool durum,Form form)
        {
            if (durum)
            {
               FormAc.aktifForm = null;
                FormAc.Open(new FormPoliklinikDuzenleme());
                ((FormPoliklinikDuzenleme)(FormAc.aktifForm)).txtPoliklinikAd.Text = _PoliklinikAd;
                ((FormPoliklinikDuzenleme)(FormAc.aktifForm)).txtAciklama.Text = _Aciklama;

                poliklinik = _PoliklinikAd;
                if (_Durum == "AKTİF")
                    ((FormPoliklinikDuzenleme)(FormAc.aktifForm)).chckSecim.Checked = true;
                else
                    ((FormPoliklinikDuzenleme)(FormAc.aktifForm)).chckSecim.Checked = false;
                ((FormPoliklinikDuzenleme)(FormAc.aktifForm)).btnGuncelle.Text = "GÜNCELLE";
                FormAc.Close((FormPoliklinikTanıtma)form);
            }
            else
            {
                DialogResult result = MessageBox.Show("Böyle bir poliklinik yok! Oluşturmak ister misiniz?", "Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (result == DialogResult.No) { }
                else
                {
                    FormAc.aktifForm = null;
                    FormAc.Open(new FormPoliklinikDuzenleme());
                    //((FrmPoliklinikDuzenleme)(FormAc.aktifForm)).txtPoliklinikAd.Enabled = false;
                    ((FormPoliklinikDuzenleme)(FormAc.aktifForm)).btnGuncelle.Text = "KAYDET";
                    ((FormPoliklinikDuzenleme)(FormAc.aktifForm)).btnSil.Visible = true;
                    FormAc.Close((FormPoliklinikTanıtma)form);
                }
            }
        }
        public static void PoliklinikEkle(string ad,string durum,string aciklama)
        {
            Veritabani.Ac();
            SqlCommand cmd = new SqlCommand("PoliklinikEkle", Veritabani.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@POLIKLINIK_ID", DBNull.Value);
            cmd.Parameters.AddWithValue("@POLIKLINIK_AD", ad);
            cmd.Parameters.AddWithValue("@DURUM", durum);
            cmd.Parameters.AddWithValue("@ACIKLAMA", aciklama);
            cmd.ExecuteNonQuery();
            Veritabani.Kapa();
        }
        public  static void PoliklinikGuncelle(string adYeni,string adEski,string durum, string aciklama)
        {
            if(poliklinik != adYeni)
            {
                if (!PoliklinikAra(adYeni))
                {
                    Veritabani.Ac();
                    SqlCommand cmd = new SqlCommand("PoliklinikGuncelle", Veritabani.baglanti);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@POLIKLINIK_ADESKI", adEski);
                    cmd.Parameters.AddWithValue("@POLIKLINIK_AD", adYeni);
                    cmd.Parameters.AddWithValue("@DURUM", durum);
                    cmd.Parameters.AddWithValue("@ACIKLAMA", aciklama);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Güncelleme Başarılı!","Mesaj",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    Veritabani.Kapa();
                }
                else
                {
                    MessageBox.Show("Aynı poliklinik adıyla poliklinik mevcut!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        public static void PoliklinikSil(string ad)
        {
            DialogResult result = MessageBox.Show("Silmek İstediğinizden Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                Veritabani.Ac();
                SqlCommand cmd = new SqlCommand("PoliklinikSil", Veritabani.baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@POLIKLINIK_AD", ad);
                cmd.ExecuteNonQuery();
                Veritabani.Kapa();
            }
        }
    }
}
