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
    public partial class FormPoliklinikDuzenleme : Form
    {
        
        public FormPoliklinikDuzenleme()
        {
            InitializeComponent();
            
        }
        
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(txtAciklama.Text != "" && txtPoliklinikAd.Text != "")
            {

                if (btnGuncelle.Text == "GÜNCELLE")
                {

                    if (chckSecim.Checked)
                        Poliklinik.PoliklinikGuncelle(txtPoliklinikAd.Text,Poliklinik.eski, "AKTİF", txtAciklama.Text);
                    else
                        Poliklinik.PoliklinikGuncelle(txtPoliklinikAd.Text, Poliklinik.eski, "PATİF", txtAciklama.Text);

                }
                else
                {
                    if (!Poliklinik.PoliklinikAra(txtPoliklinikAd.Text))
                    {
                        if (chckSecim.Checked)
                            Poliklinik.PoliklinikEkle(txtPoliklinikAd.Text, "AKTİF", txtAciklama.Text);
                        else
                            Poliklinik.PoliklinikEkle(txtPoliklinikAd.Text, "PATİF", txtAciklama.Text);
                    }
                    else
                    {
                        DialogResult dialog= MessageBox.Show("Eklemek İstediğiniz Poliklinik Zaten Var, Değiştirilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.Yes)
                        {
                            if (chckSecim.Checked)
                                Poliklinik.PoliklinikGuncelle(txtPoliklinikAd.Text, Poliklinik.eski, "AKTİF", txtAciklama.Text);
                            else
                                Poliklinik.PoliklinikGuncelle(txtPoliklinikAd.Text, Poliklinik.eski, "PATİF", txtAciklama.Text);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Boş Alan Olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtPoliklinikAd.Text != "")
            {
                if (Poliklinik.PoliklinikAra(txtPoliklinikAd.Text))
                {
                    Poliklinik.PoliklinikSil(txtPoliklinikAd.Text);
                }
                else
                    MessageBox.Show("Silmek İstediğiniz Poliklinik Mecvut Değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Poliklinik Adı Boş Girilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
