using System;
using System.Drawing;
using System.Windows.Forms;

namespace bai1_2_3_4_5_
{
    public partial class frmChiTietSinhVien : Form
    {
        private readonly SinhVien _sinhVien;

        public frmChiTietSinhVien(SinhVien sinhVien)
        {
            InitializeComponent();
            _sinhVien = sinhVien;
        }

        private void frmChiTietSinhVien_Load(object sender, EventArgs e)
        {
            if (_sinhVien == null)
            {
                MessageBox.Show("Chưa có dữ liệu sinh viên.", "Thông báo");
                this.Close();
                return;
            }
            lblMa.Text = _sinhVien.MaSV;
            lblHoTen.Text = _sinhVien.HoTen;
            lblDiem.Text = _sinhVien.DiemTB.ToString("N2");
            lblMoTa.Text = _sinhVien.MoTa();
        }
    }
}
