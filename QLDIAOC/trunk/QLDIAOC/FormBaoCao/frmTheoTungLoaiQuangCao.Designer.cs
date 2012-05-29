namespace QLDIAOC.FormBaoCao
{
    partial class frmTheoTungLoaiQuangCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTheoTungLoaiQuangCao));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvToBuom = new System.Windows.Forms.DataGridView();
            this.dgvBang = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBao = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToBuom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng";
            // 
            // dtpThang
            // 
            this.dtpThang.CustomFormat = "MM/yyyy";
            this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThang.Location = new System.Drawing.Point(56, 18);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.Size = new System.Drawing.Size(72, 20);
            this.dtpThang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quảng cáo trên tờ bướm";
            // 
            // dgvToBuom
            // 
            this.dgvToBuom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToBuom.Location = new System.Drawing.Point(18, 70);
            this.dgvToBuom.Name = "dgvToBuom";
            this.dgvToBuom.Size = new System.Drawing.Size(159, 150);
            this.dgvToBuom.TabIndex = 3;
            // 
            // dgvBang
            // 
            this.dgvBang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBang.Location = new System.Drawing.Point(239, 70);
            this.dgvBang.Name = "dgvBang";
            this.dgvBang.Size = new System.Drawing.Size(159, 150);
            this.dgvBang.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quảng cáo trên bảng";
            // 
            // dgvBao
            // 
            this.dgvBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBao.Location = new System.Drawing.Point(459, 70);
            this.dgvBao.Name = "dgvBao";
            this.dgvBao.Size = new System.Drawing.Size(159, 150);
            this.dgvBao.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quảng cáo trên báo";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(18, 246);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(75, 23);
            this.btnBaoCao.TabIndex = 8;
            this.btnBaoCao.Text = "Lập báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(102, 246);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // frmTheoTungLoaiQuangCao
            // 
            this.ClientSize = new System.Drawing.Size(630, 305);
            this.ControlBox = false;
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.dgvBao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvBang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvToBuom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpThang);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTheoTungLoaiQuangCao";
            this.Text = "Khách hàng theo từng loại quảng cáo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvToBuom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvToBuom;
        private System.Windows.Forms.DataGridView dgvBang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnDong;
    }
}