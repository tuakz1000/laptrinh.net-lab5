using System;
using System.Windows.Forms;

namespace bai7
{
    public partial class frmTimKiem : Form
    {
        public string TuKhoa { get; private set; }

        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TuKhoa = txtTuKhoa.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TuKhoa = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
