using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1_2_3_4_5_
{
    public partial class Form1 : Form
    {
        private SinhVien _sv;
        public Form1()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            cboKhoa.Items.Add("Công nghệ thông tin");
            cboKhoa.Items.Add("Công nghệ kỹ thuật ô tô");
            cboKhoa.Items.Add("Kinh tế");
            cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            if (cboKhoa.Items.Count > 0) cboKhoa.SelectedIndex = 0;
            radNam.Checked = true;
            lblXemTruoc.Text = "";
            lblTrangThai.Text = "Kiểm tra điểm";
            dtpNgaySinh_ValueChanged(null, null);
        }

        private bool ValidateInput()
        {
            errorProvider1.Clear();
            bool valid = true;
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                errorProvider1.SetError(txtMaSV, "Nhập mã sinh viên");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(txtHoTen, "Nhập họ tên");
                valid = false;
            }
            double diem;
            if (!double.TryParse(txtDiemTB.Text, out diem) || diem < 0 || diem > 10)
            {
                errorProvider1.SetError(txtDiemTB, "Điểm phải từ 0 đến 10");
                valid = false;
            }
            return valid;
        }

        private void txtDiemTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '.' && !txtDiemTB.Text.Contains(".")) return;
            e.Handled = true;
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            double diem;
            bool hopLe = double.TryParse(txtDiemTB.Text, out diem)
                && diem >= 0 && diem <= 10;
            lblXemTruoc.Text = txtMaSV.Text + " - " + txtHoTen.Text;
            lblTrangThai.Text = hopLe ? "Dữ liệu điểm hợp lệ" : "Kiểm tra điểm";
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            string thongTin = string.Format(
                "Mã: {0}\nHọ tên: {1}\nNgày sinh: {2:dd/MM/yyyy}\nKhoa: {3}\nGiới tính: {4}",
                txtMaSV.Text, txtHoTen.Text, dtpNgaySinh.Value,
                cboKhoa.Text, gioiTinh);
            MessageBox.Show(thongTin, "Thông tin sinh viên");
        }

        private int TinhTuoi(DateTime ngaySinh)
        {
            int tuoi = DateTime.Today.Year - ngaySinh.Year;
            if (ngaySinh.Date > DateTime.Today.AddYears(-tuoi)) tuoi--;
            return tuoi;
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            lblTuoi.Text = "Tuổi: " + TinhTuoi(dtpNgaySinh.Value);
        }

        private void btnSoThich_Click(object sender, EventArgs e)
        {
            List<string> ds = new List<string>();
            if (chkDocSach.Checked) ds.Add("Đọc sách");
            if (chkTheThao.Checked) ds.Add("Thể thao");
            if (chkLapTrinh.Checked) ds.Add("Lập trình");
            lblSoThichKQ.Text = ds.Count == 0 ? "Chưa chọn" : string.Join(", ", ds);
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picAnh.SizeMode = PictureBoxSizeMode.Zoom;
                    picAnh.ImageLocation = dlg.FileName;
                    txtDuongDanAnh.Text = dlg.FileName;
                }
            }
        }

        private void picAnh_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            double diem = double.Parse(txtDiemTB.Text);
            _sv = new SinhVien(txtMaSV.Text.Trim(), txtHoTen.Text.Trim(),
                dtpNgaySinh.Value, diem);
            MessageBox.Show("Đã lưu sinh viên.", "Thông báo");
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (_sv == null)
            {
                if (!ValidateInput()) return;
                double diem = double.Parse(txtDiemTB.Text);
                _sv = new SinhVien(txtMaSV.Text.Trim(), txtHoTen.Text.Trim(),
                    dtpNgaySinh.Value, diem);
            }
            using (frmChiTietSinhVien frm = new frmChiTietSinhVien(_sv))
            {
                frm.ShowDialog(this);
            }
        }
    }
}
