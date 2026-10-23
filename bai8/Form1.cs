using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChonKhoa_Click(object sender, EventArgs e)
        {
            List<string> danhSach = new List<string>
            {
                "Công nghệ thông tin",
                "Kinh tế",
                "Ngoại ngữ",
                "Điện - Điện tử",
                "Cơ khí"
            };

            using (var frm = new frmChonKhoa(danhSach))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    MessageBox.Show("Khoa được chọn: " + frm.KhoaDaChon,
                        "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
