namespace bai1_2_3_4_5_
{
    partial class frmChiTietSinhVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMa = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblMa
            //
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(12, 12);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(100, 20);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã: ";
            //
            // lblHoTen
            //
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(12, 42);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(100, 20);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên: ";
            //
            // lblDiem
            //
            this.lblDiem.AutoSize = true;
            this.lblDiem.Location = new System.Drawing.Point(12, 72);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(100, 20);
            this.lblDiem.TabIndex = 2;
            this.lblDiem.Text = "Điểm: ";
            //
            // lblMoTa
            //
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(12, 102);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(100, 20);
            this.lblMoTa.TabIndex = 3;
            this.lblMoTa.Text = "Mô tả: ";
            //
            // frmChiTietSinhVien
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 160);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMa);
            this.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmChiTietSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết sinh viên";
            this.Load += new System.EventHandler(this.frmChiTietSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Label lblMoTa;
    }
}
