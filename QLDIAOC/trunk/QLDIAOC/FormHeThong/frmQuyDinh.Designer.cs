namespace QLDIAOC.FormHeThong
{
    partial class frmQuyDinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuyDinh));
            this.dgvBangThamSo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenThamSo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangThamSo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBangThamSo
            // 
            this.dgvBangThamSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangThamSo.Location = new System.Drawing.Point(11, 13);
            this.dgvBangThamSo.MultiSelect = false;
            this.dgvBangThamSo.Name = "dgvBangThamSo";
            this.dgvBangThamSo.ReadOnly = true;
            this.dgvBangThamSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBangThamSo.Size = new System.Drawing.Size(417, 186);
            this.dgvBangThamSo.TabIndex = 0;
            this.dgvBangThamSo.SelectionChanged += new System.EventHandler(this.dgvBangThamSo_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên tham số";
            // 
            // txtTenThamSo
            // 
            this.txtTenThamSo.Location = new System.Drawing.Point(89, 211);
            this.txtTenThamSo.Name = "txtTenThamSo";
            this.txtTenThamSo.Size = new System.Drawing.Size(100, 20);
            this.txtTenThamSo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giá trị";
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(89, 241);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(100, 20);
            this.txtGiaTri.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(89, 273);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(339, 74);
            this.txtGhiChu.TabIndex = 6;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(89, 357);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 7;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(170, 357);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmQuyDinh
            // 
            this.ClientSize = new System.Drawing.Size(442, 392);
            this.ControlBox = false;
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGiaTri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenThamSo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBangThamSo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuyDinh";
            this.Text = "Quy định";
            this.Load += new System.EventHandler(this.frmQuyDinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangThamSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBangThamSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenThamSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnDong;
    }
}