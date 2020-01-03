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
    public partial class FormKullaniciDuzenleme : Form
    {
        public FormKullaniciDuzenleme()
        {
            InitializeComponent();
        }
        //FormKullaniciDuzenleme kullaniciDuzenle;
        private void txtTCKimlik_Leave(object sender, EventArgs e)
        {
                Kontrol.TextboxKontrol(txtTCKimlik);
                if (!Kontrol.TcKimlikKontrol(txtTCKimlik))
                {
                    txtTCKimlik.Focus();
                }
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (btnGuncelle.Text == "Kaydet")
                Kullanici.KullaniciEkle(this);
            else
                Kullanici.KullaniciGuncelle(this);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Kullanici.KullaniciSil(this);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Kontrol.FormTemizle(this);
        }

        private void FormKullaniciDuzenleme_Load(object sender, EventArgs e)
        {
            Hasta.AktifPoliklinikGetir(cmbPoliklinik);
            txtIseBaslangicTarihi.MaxDate = DateTime.Now;
            txtDogumTarihi.MaxDate = DateTime.Now;
            
        }

        private void cmbUnvan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbUnvan.SelectedItem.ToString() == "Doktor")
            {
                cmbPoliklinik.Visible = true;
                label20.Visible = true;
            }
            else
            {
                cmbPoliklinik.Visible = false;
                label20.Visible = false;
            }
                
        }

        private void txtBabaAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            Kontrol.TextboxSadeceHarf(e);
            //txtBabaAdi.Text.ToUpper();
        }

        private void txtAnneAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            Kontrol.TextboxSadeceHarf(e);
            
        }

        private void txtAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            Kontrol.TextboxSadeceHarf(e);
        }

        private void txtSoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            Kontrol.TextboxSadeceHarf(e);
        }

        private void txtTCKimlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            Kontrol.TextboxSadeceRakam(e);
        }

        private void txtTelefonNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Kontrol.TextboxSadeceRakam(e);
        }

        private void txtGsmNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Kontrol.TextboxSadeceRakam(e);
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            Kontrol.UsernameKontrol(txtKullaniciAdi);
        }
    }
}
