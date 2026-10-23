using System;
using System.Windows.Forms;

namespace bai1_2_3_4_5_
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void OpenChildForm(Form child)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == child.GetType())
                {
                    f.Activate();
                    child.Dispose();
                    return;
                }
            }
            child.MdiParent = this;
            child.Show();
        }

        private void mnuSinhVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1());
        }

        private void mnuChiTiet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChiTietSinhVien(null));
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
