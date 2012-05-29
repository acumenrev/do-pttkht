namespace QLDIAOC
{
    partial class frmServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServer));
            this.btnPhucHoiCSDL = new DevComponents.DotNetBar.ButtonX();
            this.columnHeader1 = new DevComponents.AdvTree.ColumnHeader();
            this.cbbCSDL = new System.Windows.Forms.ComboBox();
            this.cbbServer = new System.Windows.Forms.ComboBox();
            this.columnHeader2 = new DevComponents.AdvTree.ColumnHeader();
            this.cbbQuyen = new System.Windows.Forms.ComboBox();
            this.btnHuyBo = new DevComponents.DotNetBar.ButtonX();
            this.btnKetNoi = new DevComponents.DotNetBar.ButtonX();
            this.btnKiemTraKetNoi = new DevComponents.DotNetBar.ButtonX();
            this.txtMatKhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenTaiKhoan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ofdPhucHoiCSDL = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPhucHoiCSDL
            // 
            this.btnPhucHoiCSDL.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPhucHoiCSDL.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPhucHoiCSDL.Location = new System.Drawing.Point(35, 193);
            this.btnPhucHoiCSDL.Name = "btnPhucHoiCSDL";
            this.btnPhucHoiCSDL.Size = new System.Drawing.Size(124, 23);
            this.btnPhucHoiCSDL.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPhucHoiCSDL.TabIndex = 30;
            this.btnPhucHoiCSDL.Text = "Phục hồi cơ sở dữ liệu";
            this.btnPhucHoiCSDL.Click += new System.EventHandler(this.btnPhucHoiCSDL_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "Xác thực bằng Windows";
            this.columnHeader1.Width.Absolute = 150;
            // 
            // cbbCSDL
            // 
            this.cbbCSDL.FormattingEnabled = true;
            this.cbbCSDL.Location = new System.Drawing.Point(103, 80);
            this.cbbCSDL.Name = "cbbCSDL";
            this.cbbCSDL.Size = new System.Drawing.Size(186, 21);
            this.cbbCSDL.TabIndex = 29;
            this.cbbCSDL.SelectedIndexChanged += new System.EventHandler(this.cbbCSDL_SelectedIndexChanged);
            // 
            // cbbServer
            // 
            this.cbbServer.FormattingEnabled = true;
            this.cbbServer.Location = new System.Drawing.Point(103, 9);
            this.cbbServer.Name = "cbbServer";
            this.cbbServer.Size = new System.Drawing.Size(186, 21);
            this.cbbServer.TabIndex = 28;
            this.cbbServer.SelectedIndexChanged += new System.EventHandler(this.cbbServer_SelectedIndexChanged);
            this.cbbServer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbServer_KeyDown);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "Xác thực bằng Server";
            this.columnHeader2.Width.Absolute = 150;
            // 
            // cbbQuyen
            // 
            this.cbbQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbQuyen.FormattingEnabled = true;
            this.cbbQuyen.Items.AddRange(new object[] {
            "Xác thực bằng Windows",
            "Xác thực bằng Server"});
            this.cbbQuyen.Location = new System.Drawing.Point(103, 47);
            this.cbbQuyen.Name = "cbbQuyen";
            this.cbbQuyen.Size = new System.Drawing.Size(186, 21);
            this.cbbQuyen.TabIndex = 27;
            this.cbbQuyen.SelectedIndexChanged += new System.EventHandler(this.cbbQuyen_SelectedIndexChanged);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuyBo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuyBo.Location = new System.Drawing.Point(165, 222);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(124, 23);
            this.btnHuyBo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuyBo.TabIndex = 26;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnKetNoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnKetNoi.Location = new System.Drawing.Point(35, 222);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(124, 23);
            this.btnKetNoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnKetNoi.TabIndex = 25;
            this.btnKetNoi.Text = "Kết nối";
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // btnKiemTraKetNoi
            // 
            this.btnKiemTraKetNoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnKiemTraKetNoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnKiemTraKetNoi.Location = new System.Drawing.Point(165, 193);
            this.btnKiemTraKetNoi.Name = "btnKiemTraKetNoi";
            this.btnKiemTraKetNoi.Size = new System.Drawing.Size(124, 23);
            this.btnKiemTraKetNoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnKiemTraKetNoi.TabIndex = 24;
            this.btnKiemTraKetNoi.Text = "Kiểm tra kết nối";
            this.btnKiemTraKetNoi.Click += new System.EventHandler(this.btnKiemTraKetNoi_Click);
            // 
            // txtMatKhau
            // 
            // 
            // 
            // 
            this.txtMatKhau.Border.Class = "TextBoxBorder";
            this.txtMatKhau.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMatKhau.Location = new System.Drawing.Point(103, 138);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(186, 20);
            this.txtMatKhau.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mật khẩu";
            // 
            // txtTenTaiKhoan
            // 
            // 
            // 
            // 
            this.txtTenTaiKhoan.Border.Class = "TextBoxBorder";
            this.txtTenTaiKhoan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(103, 112);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(186, 20);
            this.txtTenTaiKhoan.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tên tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cơ sở dữ liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Xác thực:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Server:";
            // 
            // frmServer
            // 
            this.ClientSize = new System.Drawing.Size(303, 263);
            this.Controls.Add(this.btnPhucHoiCSDL);
            this.Controls.Add(this.cbbCSDL);
            this.Controls.Add(this.cbbServer);
            this.Controls.Add(this.cbbQuyen);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnKetNoi);
            this.Controls.Add(this.btnKiemTraKetNoi);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình cơ sở dữ liệu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServer_FormClosing);
            this.Load += new System.EventHandler(this.frmServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnPhucHoiCSDL;
        private DevComponents.AdvTree.ColumnHeader columnHeader1;
        private System.Windows.Forms.ComboBox cbbCSDL;
        private System.Windows.Forms.ComboBox cbbServer;
        private DevComponents.AdvTree.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox cbbQuyen;
        private DevComponents.DotNetBar.ButtonX btnHuyBo;
        private DevComponents.DotNetBar.ButtonX btnKetNoi;
        private DevComponents.DotNetBar.ButtonX btnKiemTraKetNoi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMatKhau;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenTaiKhoan;
        private System.Windows.Forms.OpenFileDialog ofdPhucHoiCSDL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}