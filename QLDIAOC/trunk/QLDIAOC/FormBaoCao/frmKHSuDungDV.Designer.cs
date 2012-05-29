namespace QLDIAOC.FormBaoCao
{
    partial class frmKHSuDungDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKHSuDungDV));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpKHSuDungDV = new System.Windows.Forms.DateTimePicker();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liệt kê khách hàng sử dụng dịch vụ trong tháng";
            // 
            // dtpKHSuDungDV
            // 
            this.dtpKHSuDungDV.CustomFormat = "MM/yyyy";
            this.dtpKHSuDungDV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKHSuDungDV.Location = new System.Drawing.Point(253, 18);
            this.dtpKHSuDungDV.Name = "dtpKHSuDungDV";
            this.dtpKHSuDungDV.Size = new System.Drawing.Size(61, 20);
            this.dtpKHSuDungDV.TabIndex = 1;
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(15, 44);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.Size = new System.Drawing.Size(531, 208);
            this.dgvKetQua.TabIndex = 2;
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInPhieu.Location = new System.Drawing.Point(15, 279);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(75, 23);
            this.btnInPhieu.TabIndex = 3;
            this.btnInPhieu.Text = "In phiếu";
            this.btnInPhieu.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDong.Location = new System.Drawing.Point(96, 279);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmKHSuDungDV
            // 
            this.ClientSize = new System.Drawing.Size(558, 314);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnInPhieu);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.dtpKHSuDungDV);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKHSuDungDV";
            this.Text = "Khách hàng sử dụng dịch vụ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpKHSuDungDV;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Button btnInPhieu;
        private System.Windows.Forms.Button btnDong;
    }
}