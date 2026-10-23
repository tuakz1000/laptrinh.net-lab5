using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace bai8
{
    public partial class frmChonKhoa : Form
    {
        public string KhoaDaChon { get; private set; }

        public frmChonKhoa(List<string> danhSachKhoa)
        {
            InitializeComponent();
            cboKhoa.Items.Clear();
            if (danhSachKhoa != null)
            {
                cboKhoa.Items.AddRange(danhSachKhoa.ToArray());
            }
            if (cboKhoa.Items.Count > 0)
            {
                cboKhoa.SelectedIndex = 0;
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (cboKhoa.SelectedItem != null)
            {
                KhoaDaChon = cboKhoa.SelectedItem.ToString();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            KhoaDaChon = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
