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
    public partial class FormAna : Form
    {
        FormAc FormAc;
        public FormAna()
        {
            InitializeComponent();
            FormAc = new FormAc(this);
        }
        private void FrmAna_Load(object sender, EventArgs e)
        {
            FormAc.Open(new FormLogin(this));
            
        }
        private void FrmAna_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void polikilinikTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc.Open(new FormPoliklinikTanıtma());
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc.Open(new FormGenelRapor());
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin a = new Admin("");
            FormAc.Open(new FormLogin(this));
            menuStripAna.Enabled = false;
            referanslarToolStripMenuItem.Visible = false;
        }

        private void kullanıcıTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc.Open(new FormKullaniciTanitma());
        }

        private void hastaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc.Open(new FormHastaIslemleri());
        }

        private void FormAna_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                FormAc.Open(new FormHastaIslemleri());


        }

        private void referanslarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
