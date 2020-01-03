using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaglikOcagiSistem
{
    public partial class FormHastaBilgileri : Form
    {
        public FormHastaBilgileri()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (btnKaydet.Text == "Kaydet")
                Hasta.HastaEkle(this);
            else
                Hasta.HastaGuncelle(this);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            
            Kontrol.FormTemizle(this);
            txtDosyaAdı.Text = Hasta.KullaniciKodu;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHastaBilgileri_Load(object sender, EventArgs e)
        {
            txtDogumTarihi.MaxDate = DateTime.Now;
            txtDogumTarihi.Value = DateTime.Now;
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            Kontrol.TextboxSadeceHarf(e);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Kontrol.TextboxSadeceHarf(e);
        }

        private void txtBabaAdı_KeyPress(object sender, KeyPressEventArgs e)
        {
            Kontrol.TextboxSadeceHarf(e);
        }

        private void txtAnneAdı_KeyPress(object sender, KeyPressEventArgs e)
        {
            Kontrol.TextboxSadeceHarf(e);
        }

        private void txtKurumAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            Kontrol.TextboxSadeceHarf(e);
        }

        private void txtYakinKurum_KeyPress(object sender, KeyPressEventArgs e)
        {
            Kontrol.TextboxSadeceHarf(e);
        }

        private void txtTcKimlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            Kontrol.TextboxSadeceRakam(e);
        }

        private void txtTelefonNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Kontrol.TextboxSadeceRakam(e);
        }

        private void txtYakınTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            Kontrol.TextboxSadeceRakam(e);
        }

        private void txtKurumSicilNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Kontrol.TextboxSadeceRakam(e);
        }

        private void txtYakinSicilNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Kontrol.TextboxSadeceRakam(e);
        }

        private void txtTcKimlik_Leave(object sender, EventArgs e)
        {
            Kontrol.TcKimlikKontrol(txtTcKimlik);
        }
    }
}
