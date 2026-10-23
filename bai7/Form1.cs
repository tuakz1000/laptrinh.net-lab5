using System;
using System.Windows.Forms;

namespace bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmTimKiem())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    MessageBox.Show("Kết quả tìm kiếm: " + frm.TuKhoa,
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
