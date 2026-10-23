using System;
using System.Windows.Forms;

namespace bai10
{
    public partial class frmDashMain : Form
    {
        public frmDashMain()
        {
            InitializeComponent();
        }

        private void OpenChild(Form child)
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
            OpenChild(new frmSinhVien());
        }

        private void mnuKhoa_Click(object sender, EventArgs e)
        {
            OpenChild(new frmKhoa());
        }

        private void mnuGioiThieu_Click(object sender, EventArgs e)
        {
            using (var frm = new frmGioiThieu())
            {
                frm.ShowDialog(this);
            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tslThoiGian.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
