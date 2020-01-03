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
    public partial class FormGenelRapor : Form
    {
        public FormGenelRapor()
        {
            InitializeComponent();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            if (dtBaslangic.Value.Date > dtBitis.Value.Date)
            {
                Kontrol.Mesaj("Başlangıç Tarihi Bitiş Tarihinden Küçük Olamaz!", dtBaslangic);
                dtBaslangic.Focus();
            }
            else
                Arama.GenelHastaArama(this);
        }

        private void dtBsalangic_Leave(object sender, EventArgs e)
        {
           
                
        }

        private void dtBitis_Leave(object sender, EventArgs e)
        {
            if (dtBaslangic.Value.Date > dtBitis.Value.Date)
            {
                Kontrol.Mesaj("Başlangıç Tarihi Bitiş Tarihinden Küçük Olamaz!", dtBaslangic);
                dtBaslangic.Focus();
            }
        }
    }
}
