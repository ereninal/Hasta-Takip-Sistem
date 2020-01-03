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
    public partial class FormPoliklinikTanıtma : Form
    {
        public FormPoliklinikTanıtma()
        {
            InitializeComponent();
        }

        private void FrmPoliklinikTanıtma_Load(object sender, EventArgs e)
        {
            cmbPoliklinikAdi.Focus();
            
            //MessageBox.Show(Poliklinik.sayi.ToString());
        }

        private void cmbPoliklinikAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if(cmbPoliklinikAdi.Text!= ""){
                    Poliklinik.eski = cmbPoliklinikAdi.Text;//eski ada göre güncelleme yapmak için
                    if (cmbPoliklinikAdi.Text != null)
                    {
                        if (Poliklinik.PoliklinikAra(cmbPoliklinikAdi.Text.ToString()))
                        {
                            Poliklinik.FormDuzenlemeKontrol(true, this);
                            
                        }
                        else
                        {
                            Poliklinik.FormDuzenlemeKontrol(false, this);
                            ((FormPoliklinikDuzenleme)(FormAc.aktifForm)).txtPoliklinikAd.Text = cmbPoliklinikAdi.Text.ToUpper();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Boş Alan Olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            if (e.KeyChar == (char)27)
            {
                DialogResult result = MessageBox.Show("Kapatmak İStediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result==DialogResult.Yes)
                    this.Close();
            }
        }

        private void FrmPoliklinikTanıtma_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cmbPoliklinikAdi_Enter(object sender, EventArgs e)
        {
            //Poliklinik.PoliklinikGetir(cmbPoliklinikAdi);
        }

        private void cmbPoliklinikAdi_DropDown(object sender, EventArgs e)
        {
            if (chckSecim.Checked)
                Poliklinik.PoliklinikGetir(cmbPoliklinikAdi);
            else
                Poliklinik.PoliklinikGetirAktif(cmbPoliklinikAdi);
        }
    }
}
