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
    public partial class FormLogin : Form
    {
        public FormLogin(FormAna frmAna)
        {
            InitializeComponent();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = "";txtSifre.Text = "";
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            Kontrol.TextboxKontrol(txtKullaniciAdi);
            Kontrol.UsernameKontrol(txtKullaniciAdi);
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(Kontrol.KullaniciKontrol(txtKullaniciAdi.Text, txtSifre.Text) == "EVET")
            {
                Admin a = new Admin(txtKullaniciAdi.Text);
                FormAc.FrmAna.menuStripAna.Enabled = true;
                FormAc.FrmAna.referanslarToolStripMenuItem.Visible = true;
                FormAc.aktifForm.Close();
            }
            else if(Kontrol.KullaniciKontrol(txtKullaniciAdi.Text, txtSifre.Text) == "HAYIR")
            {
                Admin a = new Admin(txtKullaniciAdi.Text);
                FormAc.FrmAna.menuStripAna.Enabled = true;
                FormAc.aktifForm.Close();
            }
            else if(Kontrol.KullaniciKontrol(txtKullaniciAdi.Text, txtSifre.Text) == "")
                MessageBox.Show("Yanlış kullanıcı ad ve/veya şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                if (Kontrol.KullaniciKontrol(txtKullaniciAdi.Text, txtSifre.Text) == "EVET")
                {
                    Admin a = new Admin(txtKullaniciAdi.Text);
                    FormAc.FrmAna.menuStripAna.Enabled = true;
                    FormAc.FrmAna.referanslarToolStripMenuItem.Visible = true;
                    FormAc.aktifForm.Close();
                }
                else if(Kontrol.KullaniciKontrol(txtKullaniciAdi.Text, txtSifre.Text) == "HAYIR")
                {
                    Admin a = new Admin(txtKullaniciAdi.Text);
                    FormAc.FrmAna.menuStripAna.Enabled = true;
                    FormAc.aktifForm.Close();
                }
                else if(Kontrol.KullaniciKontrol(txtKullaniciAdi.Text, txtSifre.Text) == "")
                    MessageBox.Show("Yanlış kullanıcı ad ve/veya şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
