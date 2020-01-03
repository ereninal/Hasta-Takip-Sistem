using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace SaglikOcagiSistem
{
    class FormAc
    {
        private FormAna frmAna;
        private static Form _aktifForm;

        public static FormAna FrmAna;
        public static Form aktifForm { get => _aktifForm; set => _aktifForm = value; }
        public FormAc() { }
        public FormAc(FormAna frmAna)
        {
            this.frmAna = frmAna;
            FrmAna = frmAna;
        }
        public static void Open(Form form)
        {
            if (_aktifForm != null)
                _aktifForm.Close();
            _aktifForm = form;
            _aktifForm.MdiParent = FrmAna;
            _aktifForm.Show();
        }
        public static void Close(Form form)
        {
            form.Hide();
        }
    }
}
