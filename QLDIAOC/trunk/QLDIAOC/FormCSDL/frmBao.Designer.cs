﻿namespace QLDIAOC.FormCSDL
{
    partial class frmBao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBao));
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.cbbTimTheo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaBao = new System.Windows.Forms.TextBox();
            this.txtTenBao = new System.Windows.Forms.TextBox();
            this.txtNgayPhatHanh = new System.Windows.Forms.TextBox();
            this.txtGiaCoHinh = new System.Windows.Forms.TextBox();
            this.txtGiaKhongHinh = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.lbTu = new System.Windows.Forms.Label();
            this.lbDen = new System.Windows.Forms.Label();
            this.txtTu = new System.Windows.Forms.TextBox();
            this.txtDen = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(15, 32);
            this.dgvKetQua.MultiSelect = false;
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQua.Size = new System.Drawing.Size(409, 209);
            this.dgvKetQua.TabIndex = 7;
            this.dgvKetQua.SelectionChanged += new System.EventHandler(this.dgvKetQua_SelectionChanged);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(180, 6);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(244, 20);
            this.txtTim.TabIndex = 6;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // cbbTimTheo
            // 
            this.cbbTimTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimTheo.FormattingEnabled = true;
            this.cbbTimTheo.Items.AddRange(new object[] {
            "Tên báo",
            "Ngày phát hành",
            "Giá có hình",
            "Giá không hình"});
            this.cbbTimTheo.Location = new System.Drawing.Point(53, 6);
            this.cbbTimTheo.Name = "cbbTimTheo";
            this.cbbTimTheo.Size = new System.Drawing.Size(121, 21);
            this.cbbTimTheo.TabIndex = 5;
            this.cbbTimTheo.SelectedIndexChanged += new System.EventHandler(this.cbbTimTheo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã báo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên báo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày phát hành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Giá có \r\nhình";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Giá không\r\nhình";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(255, 365);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(174, 365);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(93, 365);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaBao
            // 
            this.txtMaBao.Location = new System.Drawing.Point(93, 254);
            this.txtMaBao.Name = "txtMaBao";
            this.txtMaBao.Size = new System.Drawing.Size(100, 20);
            this.txtMaBao.TabIndex = 20;
            // 
            // txtTenBao
            // 
            this.txtTenBao.Location = new System.Drawing.Point(265, 254);
            this.txtTenBao.Name = "txtTenBao";
            this.txtTenBao.Size = new System.Drawing.Size(100, 20);
            this.txtTenBao.TabIndex = 21;
            // 
            // txtNgayPhatHanh
            // 
            this.txtNgayPhatHanh.Location = new System.Drawing.Point(93, 290);
            this.txtNgayPhatHanh.Name = "txtNgayPhatHanh";
            this.txtNgayPhatHanh.Size = new System.Drawing.Size(100, 20);
            this.txtNgayPhatHanh.TabIndex = 22;
            // 
            // txtGiaCoHinh
            // 
            this.txtGiaCoHinh.Location = new System.Drawing.Point(265, 290);
            this.txtGiaCoHinh.Name = "txtGiaCoHinh";
            this.txtGiaCoHinh.Size = new System.Drawing.Size(100, 20);
            this.txtGiaCoHinh.TabIndex = 23;
            this.txtGiaCoHinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaCoHinh_KeyPress);
            // 
            // txtGiaKhongHinh
            // 
            this.txtGiaKhongHinh.Location = new System.Drawing.Point(93, 333);
            this.txtGiaKhongHinh.Name = "txtGiaKhongHinh";
            this.txtGiaKhongHinh.Size = new System.Drawing.Size(100, 20);
            this.txtGiaKhongHinh.TabIndex = 24;
            this.txtGiaKhongHinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaKhongHinh_KeyPress);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(336, 365);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 25;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // lbTu
            // 
            this.lbTu.AutoSize = true;
            this.lbTu.Location = new System.Drawing.Point(200, 9);
            this.lbTu.Name = "lbTu";
            this.lbTu.Size = new System.Drawing.Size(20, 13);
            this.lbTu.TabIndex = 26;
            this.lbTu.Text = "Từ";
            // 
            // lbDen
            // 
            this.lbDen.AutoSize = true;
            this.lbDen.Location = new System.Drawing.Point(294, 9);
            this.lbDen.Name = "lbDen";
            this.lbDen.Size = new System.Drawing.Size(27, 13);
            this.lbDen.TabIndex = 27;
            this.lbDen.Text = "Đến";
            // 
            // txtTu
            // 
            this.txtTu.Location = new System.Drawing.Point(230, 6);
            this.txtTu.Name = "txtTu";
            this.txtTu.Size = new System.Drawing.Size(49, 20);
            this.txtTu.TabIndex = 28;
            // 
            // txtDen
            // 
            this.txtDen.Location = new System.Drawing.Point(327, 7);
            this.txtDen.Name = "txtDen";
            this.txtDen.Size = new System.Drawing.Size(49, 20);
            this.txtDen.TabIndex = 29;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(382, 7);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(42, 23);
            this.btnTim.TabIndex = 30;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(265, 331);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoi.TabIndex = 31;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "VNĐ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "VNĐ";
            // 
            // frmBao
            // 
            this.ClientSize = new System.Drawing.Size(438, 400);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtDen);
            this.Controls.Add(this.txtTu);
            this.Controls.Add(this.lbDen);
            this.Controls.Add(this.lbTu);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.txtGiaKhongHinh);
            this.Controls.Add(this.txtGiaCoHinh);
            this.Controls.Add(this.txtNgayPhatHanh);
            this.Controls.Add(this.txtTenBao);
            this.Controls.Add(this.txtMaBao);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.cbbTimTheo);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBao";
            this.Text = "Báo";
            this.Load += new System.EventHandler(this.frmBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.ComboBox cbbTimTheo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaBao;
        private System.Windows.Forms.TextBox txtTenBao;
        private System.Windows.Forms.TextBox txtNgayPhatHanh;
        private System.Windows.Forms.TextBox txtGiaCoHinh;
        private System.Windows.Forms.TextBox txtGiaKhongHinh;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label lbTu;
        private System.Windows.Forms.Label lbDen;
        private System.Windows.Forms.TextBox txtTu;
        private System.Windows.Forms.TextBox txtDen;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}