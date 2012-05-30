namespace QLDIAOC.FormBaoCao
{
    partial class frmThongKeDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeDoanhThu));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
            this.btnLapBaoCao = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dgvBao = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvBang = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvToBuom = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDoanhThuToBuom = new System.Windows.Forms.TextBox();
            this.txtDoanhThuBang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDoanhThuBao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToBuom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê tháng";
            // 
            // dtpThang
            // 
            this.dtpThang.CustomFormat = "MM/yyyy";
            this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThang.Location = new System.Drawing.Point(101, 28);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.Size = new System.Drawing.Size(67, 20);
            this.dtpThang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng doanh thu";
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Location = new System.Drawing.Point(101, 302);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.ReadOnly = true;
            this.txtTongDoanhThu.Size = new System.Drawing.Size(100, 20);
            this.txtTongDoanhThu.TabIndex = 4;
            // 
            // btnLapBaoCao
            // 
            this.btnLapBaoCao.Location = new System.Drawing.Point(12, 338);
            this.btnLapBaoCao.Name = "btnLapBaoCao";
            this.btnLapBaoCao.Size = new System.Drawing.Size(75, 23);
            this.btnLapBaoCao.TabIndex = 5;
            this.btnLapBaoCao.Text = "Lập báo cáo";
            this.btnLapBaoCao.UseVisualStyleBackColor = true;
            this.btnLapBaoCao.Click += new System.EventHandler(this.btnLapBaoCao_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(101, 338);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // dgvBao
            // 
            this.dgvBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBao.Location = new System.Drawing.Point(594, 86);
            this.dgvBao.MultiSelect = false;
            this.dgvBao.Name = "dgvBao";
            this.dgvBao.ReadOnly = true;
            this.dgvBao.Size = new System.Drawing.Size(256, 150);
            this.dgvBao.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(624, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quảng cáo trên báo";
            // 
            // dgvBang
            // 
            this.dgvBang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBang.Location = new System.Drawing.Point(305, 86);
            this.dgvBang.MultiSelect = false;
            this.dgvBang.Name = "dgvBang";
            this.dgvBang.ReadOnly = true;
            this.dgvBang.Size = new System.Drawing.Size(256, 150);
            this.dgvBang.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quảng cáo trên bảng";
            // 
            // dgvToBuom
            // 
            this.dgvToBuom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToBuom.Location = new System.Drawing.Point(12, 86);
            this.dgvToBuom.MultiSelect = false;
            this.dgvToBuom.Name = "dgvToBuom";
            this.dgvToBuom.ReadOnly = true;
            this.dgvToBuom.Size = new System.Drawing.Size(256, 150);
            this.dgvToBuom.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quảng cáo trên tờ bướm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Doanh thu quảng cáo\r\ntrên tờ bướm";
            // 
            // txtDoanhThuToBuom
            // 
            this.txtDoanhThuToBuom.Location = new System.Drawing.Point(129, 253);
            this.txtDoanhThuToBuom.Name = "txtDoanhThuToBuom";
            this.txtDoanhThuToBuom.ReadOnly = true;
            this.txtDoanhThuToBuom.Size = new System.Drawing.Size(100, 20);
            this.txtDoanhThuToBuom.TabIndex = 15;
            // 
            // txtDoanhThuBang
            // 
            this.txtDoanhThuBang.Location = new System.Drawing.Point(419, 253);
            this.txtDoanhThuBang.Name = "txtDoanhThuBang";
            this.txtDoanhThuBang.ReadOnly = true;
            this.txtDoanhThuBang.Size = new System.Drawing.Size(100, 20);
            this.txtDoanhThuBang.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Doanh thu quảng cáo\r\ntrên bảng";
            // 
            // txtDoanhThuBao
            // 
            this.txtDoanhThuBao.Location = new System.Drawing.Point(708, 253);
            this.txtDoanhThuBao.Name = "txtDoanhThuBao";
            this.txtDoanhThuBao.ReadOnly = true;
            this.txtDoanhThuBao.Size = new System.Drawing.Size(100, 20);
            this.txtDoanhThuBao.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(591, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "Doanh thu quảng cáo\r\ntrên báo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(207, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "VND";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(235, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "VND";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(525, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "VND";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(814, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "VND";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(174, 28);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 24;
            this.btnTim.Text = "Tim";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // frmThongKeDoanhThu
            // 
            this.ClientSize = new System.Drawing.Size(872, 373);
            this.ControlBox = false;
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDoanhThuBao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDoanhThuBang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDoanhThuToBuom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvBao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvBang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvToBuom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLapBaoCao);
            this.Controls.Add(this.txtTongDoanhThu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpThang);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThongKeDoanhThu";
            this.Text = "Thống kê doanh thu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToBuom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongDoanhThu;
        private System.Windows.Forms.Button btnLapBaoCao;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvBao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvBang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvToBuom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDoanhThuToBuom;
        private System.Windows.Forms.TextBox txtDoanhThuBang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDoanhThuBao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTim;
    }
}