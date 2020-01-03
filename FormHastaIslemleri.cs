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
    public partial class FormHastaIslemleri : Form
    {
        public FormHastaIslemleri()
        {
            InitializeComponent();
            
        }
        BaskiOnizleme1 cr = new BaskiOnizleme1();
        
        private void Textbox_Cikis(object sender, EventArgs e)
        {
            if(txtDosyaAdi.Text != "")
            {
                string text = txtDosyaAdi.Text.ToString();
                int count = txtDosyaAdi.TextLength;
                txtDosyaAdi.Clear();
                //MessageBox.Show(count.ToString());
                for (int i = 0; i < txtDosyaAdi.MaxLength - count; i++)
                {
                    txtDosyaAdi.Text += "0";
                }
                txtDosyaAdi.Text += text;
                Hasta.HastaBilgiGetir(this, txtDosyaAdi.Text);
                Hasta.OncekiIslemGetir(this);
            }
           
        }

        private void FrmHastaIslemleri_Load(object sender, EventArgs e)
        {
            Hasta.AktifPoliklinikGetir(cmbPoliklinik);
            Hasta.IslemGetir(this);
            dateSevk.MinDate = DateTime.Now;
            dateSevk.Value = DateTime.Now;

            
        }

        private void btnGit_Click(object sender, EventArgs e)
        {
            datagridSevk.Rows.Clear();
            Hasta._HastaToplamFiyat = 0;
            if (cmbOncekiIslem.SelectedItem != null)
                Hasta.DatadridviewDoldur(cmbOncekiIslem.SelectedItem.ToString(), txtDosyaAdi.Text, this);
            else
                Kontrol.Mesaj("Önce Tarih Seçin", cmbOncekiIslem);
        }

        private void btnBaski_Click(object sender, EventArgs e)
        {
           
            if (datagridSevk.SelectedRows.Count < 0)
                MessageBox.Show("Lütfen Seçim yapın.");
            else
            {
                Rapor.BaskiOnizleme(this,new FormBaskiOnizleme());
                //MessageBox.Show(Rapor._doktoradi);
            }
            

        }

        private void btnHastaBilgileri_Click(object sender, EventArgs e)
        {
            Hasta.FormHastaBilgileri( new FormHastaBilgileri());
            ((FormHastaBilgileri)(FormAc.aktifForm)).btnKaydet.Text = "Güncelle";
        }

        private void cmbIslem_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hasta.IslemGetir(this);
        }

        private void cmbPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hasta.DoktorGetir(this);
            Hasta.PoliklinikSira(this);
        }

        private void cmbDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hasta.PoliklinikSira(this);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Hasta.SevkEkle(this);
            cmbOncekiIslem.Items.Clear();
        }
        private void dateSevk_ValueChanged(object sender, EventArgs e)
        {
            Hasta.PoliklinikSira(this);
        }
        private void btnTaburcu_Click(object sender, EventArgs e)
        {
            Hasta.FormTaburcuKontrol(new FormTaburcu(), this);
        }
        private void cmbOncekiIslem_DropDown(object sender, EventArgs e)
        {
            //Hasta.IslemGetir(cmbIslem);
            Hasta.OncekiIslemGetir(this);
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            
            FormAc.Open(new FormDosyaBul(this));
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            FormAc.Open(new FormHastaBilgileri());
            ((FormHastaBilgileri)(FormAc.aktifForm)).txtDosyaAdı.Text = Hasta.KullaniciKodu;
            ((FormHastaBilgileri)(FormAc.aktifForm)).btnYeni.Visible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSecSil_Click(object sender, EventArgs e)
        {
            if (datagridSevk.SelectedRows.Count < 1)
                MessageBox.Show("Önce silinecek satır seçin.");
            else
            {
                Hasta.HastaSevkSil(this);
            }
        }
    }
}
