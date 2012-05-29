namespace QLDIAOC
{
    partial class frmThongTinChuongTrinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinChuongTrinh));
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtPhienBan = new System.Windows.Forms.TextBox();
            this.txtTenChuongTrinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Location = new System.Drawing.Point(106, 215);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(106, 105);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ReadOnly = true;
            this.txtGhiChu.Size = new System.Drawing.Size(224, 93);
            this.txtGhiChu.TabIndex = 14;
            this.txtGhiChu.Text = "Đồ án môn học Phân tích thiết kế hệ thống\r\nThực hiện:\r\n- 09520319 - Võ Minh Trí\r\n" +
    "- 09520326 - Trịnh Hồng Trường\r\n";
            // 
            // txtPhienBan
            // 
            this.txtPhienBan.Location = new System.Drawing.Point(106, 58);
            this.txtPhienBan.Name = "txtPhienBan";
            this.txtPhienBan.ReadOnly = true;
            this.txtPhienBan.Size = new System.Drawing.Size(100, 20);
            this.txtPhienBan.TabIndex = 13;
            this.txtPhienBan.Text = "1.0";
            // 
            // txtTenChuongTrinh
            // 
            this.txtTenChuongTrinh.Location = new System.Drawing.Point(106, 19);
            this.txtTenChuongTrinh.Name = "txtTenChuongTrinh";
            this.txtTenChuongTrinh.ReadOnly = true;
            this.txtTenChuongTrinh.Size = new System.Drawing.Size(100, 20);
            this.txtTenChuongTrinh.TabIndex = 12;
            this.txtTenChuongTrinh.Text = "Quản lý địa ốc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ghi chú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Phiên bản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên chương trình";
            // 
            // picBoxIcon
            // 
            this.picBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("picBoxIcon.Image")));
            this.picBoxIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxIcon.InitialImage")));
            this.picBoxIcon.Location = new System.Drawing.Point(265, 22);
            this.picBoxIcon.Name = "picBoxIcon";
            this.picBoxIcon.Size = new System.Drawing.Size(51, 56);
            this.picBoxIcon.TabIndex = 8;
            this.picBoxIcon.TabStop = false;
            // 
            // frmThongTinChuongTrinh
            // 
            this.ClientSize = new System.Drawing.Size(345, 274);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtPhienBan);
            this.Controls.Add(this.txtTenChuongTrinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxIcon);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThongTinChuongTrinh";
            this.Text = "Thông tin chương trình";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnThoat;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtPhienBan;
        private System.Windows.Forms.TextBox txtTenChuongTrinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxIcon;
    }
}