using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace SaglikOcagiSistem
{
    public class Rapor
    {
        public static string _HastaTcKimlik;
        public static string _HastaAd;
        public static string _HastaSoyad;
        public static DateTime _HastaDogumTarihi;
        public static string _HastaBabaAdi;
        public static string _HastaAnneAdi;
        public static int _HastaToplamFiyat;
        public static string _HastaKanGrubu;
        public static string _poliklinik;
        public static string _sirano;
        public static string _islem;
        public static string _saat;
        public static string _doktorkodu;
        public static string _miktar;
        public static string _birimfiyat;
        public static DateTime _tarih = DateTime.Now.Date;
        public static string _doktoradi;
        public static string _doktorsoyadi;
        public static string _doktorunvan;
        
        public static void BaskiOnizleme(FormHastaIslemleri frm,FormBaskiOnizleme frm1)
        {
            Veritabani.Ac();
            
            SqlCommand cmd = new SqlCommand("HastaGetir", Veritabani.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@HASTA_DOSYA_NO", frm.txtDosyaAdi.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            _HastaAd = dr["AD"].ToString();
            _HastaSoyad = dr["SOYAD"].ToString();
            _HastaTcKimlik = dr["TCKIMLIK_NO"].ToString();
            _HastaAnneAdi = dr["ANNE_ADI"].ToString();
            _HastaBabaAdi = dr["BABA_ADI"].ToString();
            _HastaDogumTarihi =(Convert.ToDateTime(dr["DOGUM_TARIHI"]));
            _HastaKanGrubu = dr["KAN_GRUBU"].ToString();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("Ad", typeof(string));
            dt.Columns.Add("Soyad", typeof(string));
            dt.Columns.Add("TC Kimlik", typeof(string));
            dt.Columns.Add("Anne Adı", typeof(string));
            dt.Columns.Add("Baba Adı", typeof(string));
            dt.Columns.Add("Tarih", typeof(string));
            dt.Columns.Add("Doğum Tarihi", typeof(string));
            dt.Columns.Add("Kan Grubu", typeof(string));
            dt.Columns.Add("Poliklinik", typeof(string));
            dt.Columns.Add("Sıra No", typeof(string));
            dt.Columns.Add("Saat", typeof(string));
            dt.Columns.Add("Yapılan İşlem", typeof(string));
            dt.Columns.Add("Doktor Adı ve Soyadı", typeof(string));
            dt.Columns.Add("Miktar", typeof(string));
            dt.Columns.Add("Birim Fiyat", typeof(string));
            dt.Columns.Add("Toplam Tutar", typeof(string));
            foreach  (DataGridViewRow item  in frm.datagridSevk.Rows)
            {
                dt.Rows.Add(_HastaAd, _HastaSoyad, _HastaTcKimlik, _HastaAnneAdi, _HastaBabaAdi,
                   _tarih.ToShortDateString(), _HastaDogumTarihi.ToShortDateString(), _HastaKanGrubu,
                   item.Cells[1].Value.ToString(),
                   Admin.admin,
                   item.Cells[3].Value.ToString(),
                   item.Cells[4].Value.ToString(),
                   item.Cells[5].Value.ToString(),
                   item.Cells[6].Value.ToString(),
                   item.Cells[7].Value.ToString(),
                   frm.lblFİyat.Text);
            }
            ds.Tables.Add(dt);
            ds.WriteXmlSchema("Rapor.xml");
            BaskiOnizleme1 rapor = new BaskiOnizleme1();
            rapor.SetDataSource(ds);
            frm1.RaporGoster.ReportSource = rapor;
            frm1.Show();
            Veritabani.Kapa();
        }
    }
}
