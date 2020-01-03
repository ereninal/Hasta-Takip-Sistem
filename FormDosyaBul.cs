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
    public partial class FormDosyaBul : Form
    {
        FormHastaIslemleri h;
        public FormDosyaBul(FormHastaIslemleri frm)
        {
            InitializeComponent();
            this.h = frm;
        }

        private void cmbSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSecim.SelectedIndex == 0)
            {
                panelAdSoyad.Visible = true;
                panelDiger.Visible = false;
            }
            else
            {
               // panelAdSoyad.Visible = false;
                panelDiger.Visible = true;
            }
        }
        private void btnBul_Click(object sender, EventArgs e)
        {
            if (cmbSecim.SelectedIndex == 0)
                Arama.IsımAra(this);
            if (cmbSecim.SelectedIndex == 1)
                Arama.TcAra(this);
            if (cmbSecim.SelectedIndex == 2)
                Arama.SicilNoAra(this);
            if (cmbSecim.SelectedIndex == 3)
                Arama.DosyaNoAra(this);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Arama.DataVievTıklama(this, h);
        }

        private void txtAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                if (cmbSecim.SelectedIndex == 1)
                    Arama.TcAra(this);
                if (cmbSecim.SelectedIndex == 2)
                    Arama.SicilNoAra(this);
                if (cmbSecim.SelectedIndex == 3)
                    Arama.DosyaNoAra(this);
            }
        }
    }
}
