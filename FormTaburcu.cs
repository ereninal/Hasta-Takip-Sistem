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
    public partial class FormTaburcu : Form
    {
       
        public FormTaburcu()
        {
            
            InitializeComponent();
        }

        private void FormTaburcu_Load(object sender, EventArgs e)
        {
           
        }
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Hasta.HastaTaburcuEt(this);
        }
    }
}
