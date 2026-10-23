namespace bai10
{
    partial class frmGioiThieu
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
            this.components = new System.ComponentModel.Container();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(15, 15);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 15);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Chương trình quản lý sinh viên - Khoa";
            this.ClientSize = new System.Drawing.Size(350, 120);
            this.Controls.Add(this.lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGioiThieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Giới thiệu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbl;
    }
}
