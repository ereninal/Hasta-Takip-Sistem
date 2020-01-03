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
    public partial class FormKullaniciTanitma : Form
    {
        public FormKullaniciTanitma()
        {
            InitializeComponent();
        }

        private void cmbKullanicilar_Enter(object sender, EventArgs e)
        {
            //MessageBox.Show("çalıştı");
            cmbKullanicilar.Items.Clear();
            Kullanici.KullaniciGetirCombo(cmbKullanicilar);
        }

        private void EnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                if(Kullanici.KullaniciAra(cmbKullanicilar.Text))
                    Kullanici.FormDuzenlemeKontrol(true, this);
                else
                    Kullanici.FormDuzenlemeKontrol(false, this);
            }
            if (e.KeyChar == (char)27)
            {
                DialogResult result = MessageBox.Show("Kapatmak İStediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    this.Close();
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            //Kullanici.FormDuzenlemeKontrol(false, this);
            FormAc.aktifForm = null;
            FormAc.Open(new FormKullaniciDuzenleme());
            ((FormKullaniciDuzenleme)(FormAc.aktifForm)).txtKullaniciKod.Text =Kullanici.KullaniciKodu;
            ((FormKullaniciDuzenleme)(FormAc.aktifForm)).btnGuncelle.Text = "Kaydet";
            ((FormKullaniciDuzenleme)(FormAc.aktifForm)).btnSil.Visible = false;
        }

        private void FormKullaniciTanitma_Load(object sender, EventArgs e)
        {
            /*cmbKullanicilar.Items.Clear();
            Kullanici.KullaniciGetirCombo(cmbKullanicilar);*/
        }

        private void cmbKullanicilar_DropDown(object sender, EventArgs e)
        {
            cmbKullanicilar.SelectedItem = 1;
            cmbKullanicilar.Items.Clear();
            Kullanici.KullaniciGetirCombo(cmbKullanicilar);
        }
    }
}
