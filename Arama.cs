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
    class Arama
    {
        public static void IsımAra(FormDosyaBul frm)
        {
            Veritabani.Ac();
            SqlCommand cmd = new SqlCommand("IsımAra", Veritabani.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            if (frm.chckSecimAdSoyad.Checked)
            {
                cmd.Parameters.AddWithValue("@HASTA_AD", frm.txtAd.Text);
                cmd.Parameters.AddWithValue("@HASTA_SOYAD", frm.txtSoyad.Text);
            }
            else
            {
                cmd.Parameters.AddWithValue("@HASTA_AD", frm.txtAd.Text);
                cmd.Parameters.AddWithValue("@HASTA_SOYAD", DBNull.Value);
            }

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Dosya No");
            dt.Columns.Add("TCK No");
            dt.Columns.Add("Ad");
            dt.Columns.Add("Soyad");
            dt.Columns.Add("Doğum Yeri");
            dt.Columns.Add("Doğum Tarihi");
            dt.Columns.Add("Baba Ad");
            dt.Columns.Add("Anne Ad");
            dt.Columns.Add("Cinsiyet");
            dt.Columns.Add("Kan Grubu");
            dt.Columns.Add("Medeni Hal");
            dt.Columns.Add("Adres");
            dt.Columns.Add("Tel");
            dt.Columns.Add("Kurum Ad");
            dt.Columns.Add("Kurum Sicil No");
            dt.Columns.Add("Yakın Tel");
            dt.Columns.Add("Yakın Kurum Ad");
            dt.Columns.Add("Yakın Kurum Sicil No");
            while (dr.Read())
            {
                DataRow drow = dt.NewRow();
                drow["Dosya No"] = dr["DOSYA_NO"].ToString();
                drow["TCK No"] = dr["TCKIMLIK_NO"].ToString();
                drow["Ad"] = dr["AD"].ToString();
                drow["Soyad"] = dr["SOYAD"].ToString();
                drow["Doğum Yeri"] = dr["DOGUM_YERI"].ToString();
                drow["Doğum Tarihi"] = dr["DOGUM_TARIHI"].ToString();
                drow["Baba Ad"] = dr["BABA_ADI"].ToString();
                drow["Anne Ad"] = dr["ANNE_ADI"].ToString();
                drow["Cinsiyet"] = dr["CINSIYET"].ToString();
                drow["Kan Grubu"] = dr["KAN_GRUBU"].ToString();
                drow["Medeni Hal"] = dr["MEDENI_HAL"].ToString();
                drow["Adres"] = dr["ADRES"].ToString();
                drow["Tel"] = dr["TEL"].ToString();
                drow["Kurum Ad"] = dr["KURUM_ADI"].ToString();
                drow["Kurum Sicil No"] = dr["KURUM_SICIL_NO"].ToString();
                drow["Yakın Tel"] = dr["YAKIN_TEL"].ToString();
                drow["Yakın Kurum Ad"] = dr["YAKIN_KURUM_ADI"].ToString();
                drow["Yakın Kurum Sicil No"] = dr["YAKIN_KURUM_SICIL_NO"].ToString();
                dt.Rows.Add(drow);

            }
            frm.dataGridView1.DataSource = dt;

        }
        public static void TcAra(FormDosyaBul frm)
        {
            Veritabani.Ac();
            SqlCommand cmd = new SqlCommand("TCAra", Veritabani.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TC", frm.txtAra.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Dosya No");
            dt.Columns.Add("TCK No");
            dt.Columns.Add("Ad");
            dt.Columns.Add("Soyad");
            dt.Columns.Add("Doğum Yeri");
            dt.Columns.Add("Doğum Tarihi");
            dt.Columns.Add("Baba Ad");
            dt.Columns.Add("Anne Ad");
            dt.Columns.Add("Cinsiyet");
            dt.Columns.Add("Kan Grubu");
            dt.Columns.Add("Medeni Hal");
            dt.Columns.Add("Adres");
            dt.Columns.Add("Tel");
            dt.Columns.Add("Kurum Ad");
            dt.Columns.Add("Kurum Sicil No");
            dt.Columns.Add("Yakın Tel");
            dt.Columns.Add("Yakın Kurum Ad");
            dt.Columns.Add("Yakın Kurum Sicil No");
            while (dr.Read())
            {
                DataRow drow = dt.NewRow();
                drow["Dosya No"] = dr["DOSYA_NO"].ToString();
                drow["TCK No"] = dr["TCKIMLIK_NO"].ToString();
                drow["Ad"] = dr["AD"].ToString();
                drow["Soyad"] = dr["SOYAD"].ToString();
                drow["Doğum Yeri"] = dr["DOGUM_YERI"].ToString();
                drow["Doğum Tarihi"] = dr["DOGUM_TARIHI"].ToString();
                drow["Baba Ad"] = dr["BABA_ADI"].ToString();
                drow["Anne Ad"] = dr["ANNE_ADI"].ToString();
                drow["Cinsiyet"] = dr["CINSIYET"].ToString();
                drow["Kan Grubu"] = dr["KAN_GRUBU"].ToString();
                drow["Medeni Hal"] = dr["MEDENI_HAL"].ToString();
                drow["Adres"] = dr["ADRES"].ToString();
                drow["Tel"] = dr["TEL"].ToString();
                drow["Kurum Ad"] = dr["KURUM_ADI"].ToString();
                drow["Kurum Sicil No"] = dr["KURUM_SICIL_NO"].ToString();
                drow["Yakın Tel"] = dr["YAKIN_TEL"].ToString();
                drow["Yakın Kurum Ad"] = dr["YAKIN_KURUM_ADI"].ToString();
                drow["Yakın Kurum Sicil No"] = dr["YAKIN_KURUM_SICIL_NO"].ToString();
                dt.Rows.Add(drow);

            }
            frm.dataGridView1.DataSource = dt;
        }
        public static void DosyaNoAra(FormDosyaBul frm)
        {
            Veritabani.Ac();
            SqlCommand cmd = new SqlCommand("DosyaNoAra", Veritabani.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DOSYA_NO", frm.txtAra.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Dosya No");
            dt.Columns.Add("TCK No");
            dt.Columns.Add("Ad");
            dt.Columns.Add("Soyad");
            dt.Columns.Add("Doğum Yeri");
            dt.Columns.Add("Doğum Tarihi");
            dt.Columns.Add("Baba Ad");
            dt.Columns.Add("Anne Ad");
            dt.Columns.Add("Cinsiyet");
            dt.Columns.Add("Kan Grubu");
            dt.Columns.Add("Medeni Hal");
            dt.Columns.Add("Adres");
            dt.Columns.Add("Tel");
            dt.Columns.Add("Kurum Ad");
            dt.Columns.Add("Kurum Sicil No");
            dt.Columns.Add("Yakın Tel");
            dt.Columns.Add("Yakın Kurum Ad");
            dt.Columns.Add("Yakın Kurum Sicil No");
            while (dr.Read())
            {
                DataRow drow = dt.NewRow();
                drow["Dosya No"] = dr["DOSYA_NO"].ToString();
                drow["TCK No"] = dr["TCKIMLIK_NO"].ToString();
                drow["Ad"] = dr["AD"].ToString();
                drow["Soyad"] = dr["SOYAD"].ToString();
                drow["Doğum Yeri"] = dr["DOGUM_YERI"].ToString();
                drow["Doğum Tarihi"] = dr["DOGUM_TARIHI"].ToString();
                drow["Baba Ad"] = dr["BABA_ADI"].ToString();
                drow["Anne Ad"] = dr["ANNE_ADI"].ToString();
                drow["Cinsiyet"] = dr["CINSIYET"].ToString();
                drow["Kan Grubu"] = dr["KAN_GRUBU"].ToString();
                drow["Medeni Hal"] = dr["MEDENI_HAL"].ToString();
                drow["Adres"] = dr["ADRES"].ToString();
                drow["Tel"] = dr["TEL"].ToString();
                drow["Kurum Ad"] = dr["KURUM_ADI"].ToString();
                drow["Kurum Sicil No"] = dr["KURUM_SICIL_NO"].ToString();
                drow["Yakın Tel"] = dr["YAKIN_TEL"].ToString();
                drow["Yakın Kurum Ad"] = dr["YAKIN_KURUM_ADI"].ToString();
                drow["Yakın Kurum Sicil No"] = dr["YAKIN_KURUM_SICIL_NO"].ToString();
                dt.Rows.Add(drow);

            }
            frm.dataGridView1.DataSource = dt;
        }
        public static void SicilNoAra(FormDosyaBul frm)
        {
            Veritabani.Ac();
            SqlCommand cmd = new SqlCommand("KurumSicilNoAra", Veritabani.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SICIL_NO", frm.txtAra.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Dosya No");
            dt.Columns.Add("TCK No");
            dt.Columns.Add("Ad");
            dt.Columns.Add("Soyad");
            dt.Columns.Add("Doğum Yeri");
            dt.Columns.Add("Doğum Tarihi");
            dt.Columns.Add("Baba Ad");
            dt.Columns.Add("Anne Ad");
            dt.Columns.Add("Cinsiyet");
            dt.Columns.Add("Kan Grubu");
            dt.Columns.Add("Medeni Hal");
            dt.Columns.Add("Adres");
            dt.Columns.Add("Tel");
            dt.Columns.Add("Kurum Ad");
            dt.Columns.Add("Kurum Sicil No");
            dt.Columns.Add("Yakın Tel");
            dt.Columns.Add("Yakın Kurum Ad");
            dt.Columns.Add("Yakın Kurum Sicil No");
            while (dr.Read())
            {
                DataRow drow = dt.NewRow();
                drow["Dosya No"] = dr["DOSYA_NO"].ToString();
                drow["TCK No"] = dr["TCKIMLIK_NO"].ToString();
                drow["Ad"] = dr["AD"].ToString();
                drow["Soyad"] = dr["SOYAD"].ToString();
                drow["Doğum Yeri"] = dr["DOGUM_YERI"].ToString();
                drow["Doğum Tarihi"] = dr["DOGUM_TARIHI"].ToString();
                drow["Baba Ad"] = dr["BABA_ADI"].ToString();
                drow["Anne Ad"] = dr["ANNE_ADI"].ToString();
                drow["Cinsiyet"] = dr["CINSIYET"].ToString();
                drow["Kan Grubu"] = dr["KAN_GRUBU"].ToString();
                drow["Medeni Hal"] = dr["MEDENI_HAL"].ToString();
                drow["Adres"] = dr["ADRES"].ToString();
                drow["Tel"] = dr["TEL"].ToString();
                drow["Kurum Ad"] = dr["KURUM_ADI"].ToString();
                drow["Kurum Sicil No"] = dr["KURUM_SICIL_NO"].ToString();
                drow["Yakın Tel"] = dr["YAKIN_TEL"].ToString();
                drow["Yakın Kurum Ad"] = dr["YAKIN_KURUM_ADI"].ToString();
                drow["Yakın Kurum Sicil No"] = dr["YAKIN_KURUM_SICIL_NO"].ToString();
                dt.Rows.Add(drow);

            }
            frm.dataGridView1.DataSource = dt;
        }
        public static void DataVievTıklama(FormDosyaBul frm1,FormHastaIslemleri frm2)
        {
            DataGridViewRow r = frm1.dataGridView1.CurrentRow;
            if (frm1.dataGridView1.Rows.Count < 0 && frm1.dataGridView1.SelectedRows.Count < 0)
                Kontrol.Mesaj("Dikkat!", frm1.dataGridView1);
            else
            {
                frm2.txtDosyaAdi.Text = r.Cells[0].Value.ToString();
                Hasta.HastaBilgiGetir(frm2, frm2.txtDosyaAdi.Text);
                MessageBox.Show(r.Cells[0].Value.ToString());
                
            }
        }
        public static void GenelHastaArama(FormGenelRapor form)
        {
            DateTime dtBitis =form.dtBitis.Value.Date;
            DateTime dtBaslangic = form.dtBaslangic.Value.Date;
            Veritabani.Ac();
            SqlCommand cmd = new SqlCommand("GenelHastaArama", Veritabani.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BITIS_TARIH", form.dtBitis.Value.Date);
            cmd.Parameters.AddWithValue("@BASLANGİC_TARIH", form.dtBaslangic.Value.Date);
            if(form.rbTaburcuOlmus.Checked)
                cmd.Parameters.AddWithValue("@DURUM", "EVET");
            if (form.rbTaburcuOlmamıs.Checked)
                cmd.Parameters.AddWithValue("@DURUM", "HAYIR");
            if (form.rbHepsi.Checked)
                cmd.Parameters.AddWithValue("@DURUM",DBNull.Value);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Dosya No");
            dt.Columns.Add("Kimlik Numarası");
            dt.Columns.Add("Ad");
            dt.Columns.Add("Soyad");
            dt.Columns.Add("Doktor Ad ve Soyad");
            dt.Columns.Add("Sevk Tarihi");
            dt.Columns.Add("Poliklinik");
            dt.Columns.Add("Yapılan İşlem");
            dt.Columns.Add("Toplam Tutar");
            dt.Columns.Add("Taburcu");
            while (dr.Read())
            {
                DataRow drow = dt.NewRow();
                drow["Dosya No"] = dr["DOSYA_NO"].ToString();
                drow["Kimlik Numarası"] = dr["TCKIMLIK_NO"].ToString();
                drow["Ad"] = dr["HASTA_AD"].ToString();
                drow["Soyad"] = dr["HASTA_SOYAD"].ToString();
                drow["Doktor Ad ve Soyad"] = dr["DOKTOR_AD"].ToString()+ " "+ dr["DOKTOR_SOYAD"].ToString();
                drow["Sevk Tarihi"] = dr["SEVK_TARİHİ"].ToString();
                drow["Poliklinik"] = dr["POLIKLINIK_AD"].ToString();
                drow["Yapılan İşlem"] = dr["YAPILAN_ISLEM"].ToString();
                drow["Toplam Tutar"] = dr["TOPLAM_TUTAR"].ToString();
                drow["Taburcu"] = dr["TABURCU"].ToString();
                dt.Rows.Add(drow);
            }
            form.raporDataGrid.DataSource = dt;
            Veritabani.Kapa();
        }
    }
}
