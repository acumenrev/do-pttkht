namespace QLDIAOC.FormCSDL
{
    partial class frmDiaOc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiaOc));
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.cbbTimTheo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.txtPhuong = new System.Windows.Forms.TextBox();
            this.txtDuong = new System.Windows.Forms.TextBox();
            this.txtSoNha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaDiaOc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHuongNha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtXayNam = new System.Windows.Forms.TextBox();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.txtSoTang = new System.Windows.Forms.TextBox();
            this.cbbLoaiNha = new System.Windows.Forms.ComboBox();
            this.cbbLoaiNen = new System.Windows.Forms.ComboBox();
            this.cbDaBan = new System.Windows.Forms.CheckBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtDienTichSuDung = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtDienTichKhuonVien = new System.Windows.Forms.TextBox();
            this.cbbMaNguoiBan = new System.Windows.Forms.ComboBox();
            this.nGUOIBANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDODataSet = new QLDIAOC.QLDODataSet();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtDen = new System.Windows.Forms.TextBox();
            this.txtTu = new System.Windows.Forms.TextBox();
            this.lbDen = new System.Windows.Forms.Label();
            this.lbTu = new System.Windows.Forms.Label();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMoTaChiTiet = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.qLDODataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nGUOIBANTableAdapter = new QLDIAOC.QLDODataSetTableAdapters.NGUOIBANTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIBANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDODataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(4, 32);
            this.dgvKetQua.MultiSelect = false;
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQua.Size = new System.Drawing.Size(579, 209);
            this.dgvKetQua.TabIndex = 7;
            this.dgvKetQua.SelectionChanged += new System.EventHandler(this.dgvKetQua_SelectionChanged);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(169, 6);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(414, 20);
            this.txtTim.TabIndex = 6;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // cbbTimTheo
            // 
            this.cbbTimTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimTheo.FormattingEnabled = true;
            this.cbbTimTheo.Items.AddRange(new object[] {
            "Số nhà",
            "Đường",
            "Phường",
            "Quận",
            "Hướng nhà",
            "Loại nền",
            "Loại nhà",
            "Mã địa ốc",
            "Mã người bán",
            "Mô tả chi tiết",
            "Vị trí",
            "Xây năm",
            "Số tầng"});
            this.cbbTimTheo.Location = new System.Drawing.Point(42, 6);
            this.cbbTimTheo.Name = "cbbTimTheo";
            this.cbbTimTheo.Size = new System.Drawing.Size(121, 21);
            this.cbbTimTheo.TabIndex = 5;
            this.cbbTimTheo.SelectedIndexChanged += new System.EventHandler(this.cbbTimTheo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã địa ốc:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.txtQuan);
            this.groupBox1.Controls.Add(this.txtPhuong);
            this.groupBox1.Controls.Add(this.txtDuong);
            this.groupBox1.Controls.Add(this.txtSoNha);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(237, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 124);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Địa chỉ";
            // 
            // txtQuan
            // 
            this.txtQuan.Location = new System.Drawing.Point(53, 89);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(100, 20);
            this.txtQuan.TabIndex = 7;
            // 
            // txtPhuong
            // 
            this.txtPhuong.Location = new System.Drawing.Point(53, 65);
            this.txtPhuong.Name = "txtPhuong";
            this.txtPhuong.Size = new System.Drawing.Size(100, 20);
            this.txtPhuong.TabIndex = 6;
            // 
            // txtDuong
            // 
            this.txtDuong.Location = new System.Drawing.Point(53, 41);
            this.txtDuong.Name = "txtDuong";
            this.txtDuong.Size = new System.Drawing.Size(224, 20);
            this.txtDuong.TabIndex = 5;
            // 
            // txtSoNha
            // 
            this.txtSoNha.Location = new System.Drawing.Point(53, 15);
            this.txtSoNha.Name = "txtSoNha";
            this.txtSoNha.Size = new System.Drawing.Size(100, 20);
            this.txtSoNha.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Quận";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Phường";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đường";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số nhà";
            // 
            // txtMaDiaOc
            // 
            this.txtMaDiaOc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaDiaOc.Location = new System.Drawing.Point(79, 254);
            this.txtMaDiaOc.Name = "txtMaDiaOc";
            this.txtMaDiaOc.Size = new System.Drawing.Size(100, 20);
            this.txtMaDiaOc.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mã người bán";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Hướng nhà đất";
            // 
            // txtHuongNha
            // 
            this.txtHuongNha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHuongNha.Location = new System.Drawing.Point(79, 305);
            this.txtHuongNha.Name = "txtHuongNha";
            this.txtHuongNha.Size = new System.Drawing.Size(100, 20);
            this.txtHuongNha.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nhà xây năm";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Vị trí";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 384);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Số tầng";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1, 409);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Loại nhà";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1, 434);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Loại nền";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1, 456);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Đã bán";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1, 481);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Giá bán";
            // 
            // txtXayNam
            // 
            this.txtXayNam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtXayNam.Location = new System.Drawing.Point(79, 329);
            this.txtXayNam.Name = "txtXayNam";
            this.txtXayNam.Size = new System.Drawing.Size(100, 20);
            this.txtXayNam.TabIndex = 22;
            this.txtXayNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXayNam_KeyPress);
            // 
            // txtViTri
            // 
            this.txtViTri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtViTri.Location = new System.Drawing.Point(79, 355);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(100, 20);
            this.txtViTri.TabIndex = 23;
            // 
            // txtSoTang
            // 
            this.txtSoTang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSoTang.Location = new System.Drawing.Point(79, 381);
            this.txtSoTang.Name = "txtSoTang";
            this.txtSoTang.Size = new System.Drawing.Size(100, 20);
            this.txtSoTang.TabIndex = 24;
            this.txtSoTang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTang_KeyPress);
            // 
            // cbbLoaiNha
            // 
            this.cbbLoaiNha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbLoaiNha.FormattingEnabled = true;
            this.cbbLoaiNha.Items.AddRange(new object[] {
            "Căn hộ",
            "Chung cư",
            "Biệt thự",
            "Nhà cấp 3",
            "Nhà cấp 4"});
            this.cbbLoaiNha.Location = new System.Drawing.Point(79, 407);
            this.cbbLoaiNha.Name = "cbbLoaiNha";
            this.cbbLoaiNha.Size = new System.Drawing.Size(100, 21);
            this.cbbLoaiNha.TabIndex = 25;
            // 
            // cbbLoaiNen
            // 
            this.cbbLoaiNen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbLoaiNen.FormattingEnabled = true;
            this.cbbLoaiNen.Items.AddRange(new object[] {
            "Nền đất",
            "Nền gạch",
            "Nền xi măng",
            "Nền gỗ"});
            this.cbbLoaiNen.Location = new System.Drawing.Point(79, 431);
            this.cbbLoaiNen.Name = "cbbLoaiNen";
            this.cbbLoaiNen.Size = new System.Drawing.Size(100, 21);
            this.cbbLoaiNen.TabIndex = 26;
            // 
            // cbDaBan
            // 
            this.cbDaBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDaBan.AutoSize = true;
            this.cbDaBan.Location = new System.Drawing.Point(79, 458);
            this.cbDaBan.Name = "cbDaBan";
            this.cbDaBan.Size = new System.Drawing.Size(15, 14);
            this.cbDaBan.TabIndex = 27;
            this.cbDaBan.UseVisualStyleBackColor = true;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGiaBan.Location = new System.Drawing.Point(79, 478);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(100, 20);
            this.txtGiaBan.TabIndex = 28;
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.txtDienTichSuDung);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.txtDienTichKhuonVien);
            this.groupBox2.Location = new System.Drawing.Point(236, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 70);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông số";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Diện tích sử dụng";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Diện tích khuôn viên";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(183, 41);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(21, 13);
            this.label27.TabIndex = 17;
            this.label27.Text = "m2";
            // 
            // txtDienTichSuDung
            // 
            this.txtDienTichSuDung.Location = new System.Drawing.Point(122, 38);
            this.txtDienTichSuDung.Name = "txtDienTichSuDung";
            this.txtDienTichSuDung.Size = new System.Drawing.Size(55, 20);
            this.txtDienTichSuDung.TabIndex = 16;
            this.txtDienTichSuDung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienTichSuDung_KeyPress);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(183, 15);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(21, 13);
            this.label24.TabIndex = 13;
            this.label24.Text = "m2";
            // 
            // txtDienTichKhuonVien
            // 
            this.txtDienTichKhuonVien.Location = new System.Drawing.Point(122, 12);
            this.txtDienTichKhuonVien.Name = "txtDienTichKhuonVien";
            this.txtDienTichKhuonVien.Size = new System.Drawing.Size(55, 20);
            this.txtDienTichKhuonVien.TabIndex = 9;
            this.txtDienTichKhuonVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDatRong_KeyPress);
            // 
            // cbbMaNguoiBan
            // 
            this.cbbMaNguoiBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbMaNguoiBan.DataSource = this.nGUOIBANBindingSource;
            this.cbbMaNguoiBan.DisplayMember = "MaNguoiBan";
            this.cbbMaNguoiBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaNguoiBan.FormattingEnabled = true;
            this.cbbMaNguoiBan.Location = new System.Drawing.Point(79, 278);
            this.cbbMaNguoiBan.Name = "cbbMaNguoiBan";
            this.cbbMaNguoiBan.Size = new System.Drawing.Size(100, 21);
            this.cbbMaNguoiBan.TabIndex = 30;
            this.cbbMaNguoiBan.ValueMember = "MaNguoiBan";
            // 
            // nGUOIBANBindingSource
            // 
            this.nGUOIBANBindingSource.DataMember = "NGUOIBAN";
            this.nGUOIBANBindingSource.DataSource = this.qLDODataSet;
            // 
            // qLDODataSet
            // 
            this.qLDODataSet.DataSetName = "QLDODataSet";
            this.qLDODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.Location = new System.Drawing.Point(241, 512);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Location = new System.Drawing.Point(160, 512);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.Location = new System.Drawing.Point(79, 512);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDong.Location = new System.Drawing.Point(322, 512);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 34;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(364, 7);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(42, 23);
            this.btnTim.TabIndex = 39;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtDen
            // 
            this.txtDen.Location = new System.Drawing.Point(309, 7);
            this.txtDen.Name = "txtDen";
            this.txtDen.Size = new System.Drawing.Size(49, 20);
            this.txtDen.TabIndex = 38;
            // 
            // txtTu
            // 
            this.txtTu.Location = new System.Drawing.Point(212, 6);
            this.txtTu.Name = "txtTu";
            this.txtTu.Size = new System.Drawing.Size(49, 20);
            this.txtTu.TabIndex = 37;
            // 
            // lbDen
            // 
            this.lbDen.AutoSize = true;
            this.lbDen.Location = new System.Drawing.Point(276, 9);
            this.lbDen.Name = "lbDen";
            this.lbDen.Size = new System.Drawing.Size(27, 13);
            this.lbDen.TabIndex = 36;
            this.lbDen.Text = "Đến";
            // 
            // lbTu
            // 
            this.lbTu.AutoSize = true;
            this.lbTu.Location = new System.Drawing.Point(182, 9);
            this.lbTu.Name = "lbTu";
            this.lbTu.Size = new System.Drawing.Size(20, 13);
            this.lbTu.TabIndex = 35;
            this.lbTu.Text = "Từ";
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTaoMoi.Location = new System.Drawing.Point(-2, 512);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoi.TabIndex = 40;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(243, 456);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 41;
            this.label18.Text = "Mô tả chi tiết";
            // 
            // txtMoTaChiTiet
            // 
            this.txtMoTaChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMoTaChiTiet.Location = new System.Drawing.Point(317, 456);
            this.txtMoTaChiTiet.Multiline = true;
            this.txtMoTaChiTiet.Name = "txtMoTaChiTiet";
            this.txtMoTaChiTiet.Size = new System.Drawing.Size(266, 50);
            this.txtMoTaChiTiet.TabIndex = 42;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(185, 481);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 13);
            this.label19.TabIndex = 43;
            this.label19.Text = "VNĐ";
            // 
            // qLDODataSetBindingSource
            // 
            this.qLDODataSetBindingSource.DataSource = this.qLDODataSet;
            this.qLDODataSetBindingSource.Position = 0;
            // 
            // nGUOIBANTableAdapter
            // 
            this.nGUOIBANTableAdapter.ClearBeforeFill = true;
            // 
            // frmDiaOc
            // 
            this.ClientSize = new System.Drawing.Size(594, 547);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtMoTaChiTiet);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtDen);
            this.Controls.Add(this.txtTu);
            this.Controls.Add(this.lbDen);
            this.Controls.Add(this.lbTu);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbbMaNguoiBan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.cbDaBan);
            this.Controls.Add(this.cbbLoaiNen);
            this.Controls.Add(this.cbbLoaiNha);
            this.Controls.Add(this.txtSoTang);
            this.Controls.Add(this.txtViTri);
            this.Controls.Add(this.txtXayNam);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHuongNha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaDiaOc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.cbbTimTheo);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDiaOc";
            this.Text = "Địa ốc";
            this.Load += new System.EventHandler(this.frmDiaOc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIBANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDODataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.ComboBox cbbTimTheo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.TextBox txtPhuong;
        private System.Windows.Forms.TextBox txtDuong;
        private System.Windows.Forms.TextBox txtSoNha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaDiaOc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHuongNha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtXayNam;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.TextBox txtSoTang;
        private System.Windows.Forms.ComboBox cbbLoaiNha;
        private System.Windows.Forms.ComboBox cbbLoaiNen;
        private System.Windows.Forms.CheckBox cbDaBan;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtDienTichKhuonVien;
        private System.Windows.Forms.ComboBox cbbMaNguoiBan;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtDienTichSuDung;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtDen;
        private System.Windows.Forms.TextBox txtTu;
        private System.Windows.Forms.Label lbDen;
        private System.Windows.Forms.Label lbTu;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMoTaChiTiet;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.BindingSource qLDODataSetBindingSource;
        private QLDODataSet qLDODataSet;
        private System.Windows.Forms.BindingSource nGUOIBANBindingSource;
        private QLDODataSetTableAdapters.NGUOIBANTableAdapter nGUOIBANTableAdapter;
    }
}