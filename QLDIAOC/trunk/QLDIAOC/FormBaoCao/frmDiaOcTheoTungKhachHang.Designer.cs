namespace QLDIAOC.FormBaoCao
{
    partial class frmDiaOcTheoTungKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiaOcTheoTungKhachHang));
            this.dgvNguoiBan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDiaOc = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLapBaoCao = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaOc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNguoiBan
            // 
            this.dgvNguoiBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoiBan.Location = new System.Drawing.Point(3, 47);
            this.dgvNguoiBan.MultiSelect = false;
            this.dgvNguoiBan.Name = "dgvNguoiBan";
            this.dgvNguoiBan.ReadOnly = true;
            this.dgvNguoiBan.Size = new System.Drawing.Size(152, 178);
            this.dgvNguoiBan.TabIndex = 0;
            this.dgvNguoiBan.SelectionChanged += new System.EventHandler(this.dgvNguoiBan_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Người bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa ốc";
            // 
            // dgvDiaOc
            // 
            this.dgvDiaOc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiaOc.Location = new System.Drawing.Point(223, 47);
            this.dgvDiaOc.MultiSelect = false;
            this.dgvDiaOc.Name = "dgvDiaOc";
            this.dgvDiaOc.ReadOnly = true;
            this.dgvDiaOc.Size = new System.Drawing.Size(349, 178);
            this.dgvDiaOc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "->";
            // 
            // btnLapBaoCao
            // 
            this.btnLapBaoCao.Location = new System.Drawing.Point(3, 251);
            this.btnLapBaoCao.Name = "btnLapBaoCao";
            this.btnLapBaoCao.Size = new System.Drawing.Size(75, 23);
            this.btnLapBaoCao.TabIndex = 5;
            this.btnLapBaoCao.Text = "Lập báo cáo";
            this.btnLapBaoCao.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(80, 251);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmDiaOcTheoTungKhachHang
            // 
            this.ClientSize = new System.Drawing.Size(574, 282);
            this.ControlBox = false;
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLapBaoCao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDiaOc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNguoiBan);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDiaOcTheoTungKhachHang";
            this.Text = "Thống kê địa ốc theo từng khách hàng";
            this.Load += new System.EventHandler(this.frmDiaOcTheoTungKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaOc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNguoiBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDiaOc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLapBaoCao;
        private System.Windows.Forms.Button btnDong;
    }
}