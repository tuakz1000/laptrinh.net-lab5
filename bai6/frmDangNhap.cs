using System;
using System.Windows.Forms;

namespace bai6
{
    public partial class frmDangNhap : Form
    {
        private const string TaiKhoan = "admin";
        private const string MatKhau = "123";
        private const int SoLanChoPhep = 3;
        private const int GiayKhoa = 30;

        private int _soLanSai;
        private int _giayConLai;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == TaiKhoan && txtMatKhau.Text == MatKhau)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _soLanSai++;
            int conLai = SoLanChoPhep - _soLanSai;
            if (conLai > 0)
            {
                lblThongBao.Text = "Sai tài khoản/mật khẩu. Còn " + conLai + " lần thử.";
                return;
            }

            // Đã sai đủ 3 lần -> khóa nút trong 30 giây
            KhoaDangNhap();
        }

        private void KhoaDangNhap()
        {
            btnDangNhap.Enabled = false;
            _giayConLai = GiayKhoa;
            lblThongBao.Text = "Đã sai " + SoLanChoPhep +
                " lần. Nút đăng nhập bị khóa " + _giayConLai + " giây.";
            TimerKhoa.Start();
        }

        private void TimerKhoa_Tick(object sender, EventArgs e)
        {
            _giayConLai--;
            if (_giayConLai > 0)
            {
                lblThongBao.Text = "Đã sai " + SoLanChoPhep +
                    " lần. Nút đăng nhập bị khóa " + _giayConLai + " giây.";
                return;
            }
            TimerKhoa.Stop();
            btnDangNhap.Enabled = true;
            _soLanSai = 0;
            lblThongBao.Text = "Đã hết thời gian khóa. Vui lòng thử lại.";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
