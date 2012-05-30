using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DAL;
using BLL;
namespace QLDIAOC.FormCSDL
{
    public partial class frmBao : DevComponents.DotNetBar.Office2007Form
    {
        #region Constructor

        public frmBao()
        {
            InitializeComponent();
            m_dal = new DataService();
            m_bll = new BaoBLL();
        }

        #endregion

        #region Fields

        private const int WM_NCLBUTTONDBLCLK = 0xA3;
        DAL.DataService m_dal;
        BLL.BaoBLL m_bll;

        #endregion

        #region Methods

        // Ngan khong cho phong to cua so khi bam doi chuot vao title bar
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCLBUTTONDBLCLK:
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                    return;
            }

            base.WndProc(ref m);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void txtGiaCoHinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaKhongHinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            ClearDataGridView();
            if (txtTim.Text.Trim() == "")
            {
                dgvKetQua.DataSource = m_bll.Select();
            }
            else
            {
                switch(cbbTimTheo.Text)
                {
                    case "Tên báo":
                        dgvKetQua.DataSource = m_bll.SearchTenBao(txtTenBao.Text);
                        break;
                    case "Ngày phát hành":
                        dgvKetQua.DataSource = m_bll.SearchNgayPhatHanh(txtNgayPhatHanh.Text);
                        break;
                }
            }
        }

        private void ClearDataGridView()
        {
            int rowCount = dgvKetQua.RowCount - 1;
            for (int i = 0; i < rowCount; i++)
            {
                dgvKetQua.Rows.Remove(dgvKetQua.CurrentRow);
            }
        }

        private void ClearInput()
        {
            txtGiaCoHinh.Text = "";
            txtGiaKhongHinh.Text = "";
            txtMaBao.Text = "";
            txtNgayPhatHanh.Text = "";
            txtTenBao.Text = "";
            txtTim.Text = "";
        }

        private void frmBao_Load(object sender, EventArgs e)
        {
            txtTim.Visible = false;
            txtTu.Visible = false;
            txtDen.Visible = false;
            btnTim.Visible = false;
            lbTu.Visible = false;
            lbDen.Visible = false;
            ClearDataGridView();
            ClearInput();
            dgvKetQua.DataSource = m_bll.Select();
        }

        private void cbbTimTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbbTimTheo.Text)
            {
                case "Tên báo":
                case "Ngày phát hành":
                    txtTu.Visible = false;
                    txtDen.Visible = false;
                    txtTim.Visible = true;
                    lbTu.Visible = false;
                    lbDen.Visible = false;
                    btnTim.Visible = false;
                    break;
                case "Giá có hình":
                case "Giá không hình":
                    txtTu.Visible = true;
                    txtDen.Visible = true;
                    txtTim.Visible = false;
                    btnTim.Visible = true;
                    lbDen.Visible = true;
                    lbTu.Visible = true;
                    break;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            switch(cbbTimTheo.Text)
            {
                case "Giá có hình":
                    dgvKetQua.DataSource = m_bll.SearchGiaCoHinh(decimal.Parse(txtTu.Text), decimal.Parse(txtDen.Text));
                    break;
                case "Giá không hình":
                    dgvKetQua.DataSource = m_bll.SearchGiaKhongHinh(decimal.Parse(txtTu.Text), decimal.Parse(txtDen.Text));
                    break;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaBao.Text.Trim() != "" && txtTenBao.Text.Trim() != "" &&
                txtGiaKhongHinh.Text.Trim() != "" && txtGiaKhongHinh.Text.Trim() != "" &&
                txtNgayPhatHanh.Text.Trim() != "")
            {
                m_bll.Insert(txtMaBao.Text, txtTenBao.Text, txtNgayPhatHanh.Text, decimal.Parse(txtGiaCoHinh.Text), decimal.Parse(txtGiaKhongHinh.Text));
                frmBao_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập vào những dữ liệu cần thiết", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaBao.Text.Trim() != "")
            {
                m_bll.Delete(txtMaBao.Text);
                frmBao_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã báo cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaBao.Text.Trim() != "" && txtTenBao.Text.Trim() != "" &&
                txtGiaKhongHinh.Text.Trim() != "" && txtGiaKhongHinh.Text.Trim() != "" &&
                txtNgayPhatHanh.Text.Trim() != "")
            {
                m_bll.Update(txtMaBao.Text, txtTenBao.Text, txtNgayPhatHanh.Text, decimal.Parse(txtGiaCoHinh.Text), decimal.Parse(txtGiaKhongHinh.Text));
                frmBao_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập vào những dữ liệu cần thiết", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            ClearInput();
            string str = "";
            // mã bắt đầu cho vật tư phụ tùng
            if (dgvKetQua.RowCount - 1 > 1)
            {
                int rowCount = dgvKetQua.RowCount - 1;
                string temp = dgvKetQua.Rows[rowCount - 1].Cells[0].Value.ToString().Trim();
                char[] arr = temp.ToCharArray();
                int pos = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (Char.IsDigit(arr[i]))
                    {
                        pos = i;
                        break;
                    }
                }
                string tempSo = temp.Substring(pos, arr.Length - pos);
                int so = int.Parse(tempSo) + 1;
                str = "MB" + so.ToString();
            }
            else
            {
                if (dgvKetQua.RowCount - 1 == 0)
                {
                    str = "MB1";
                }
                else
                {
                    if (dgvKetQua.RowCount - 1 == 1)
                    {
                        str = "MB2";
                    }
                }
            }
            txtMaBao.Text = str;
        }

        private void dgvKetQua_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvKetQua.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dgvKetQua.SelectedRows[0];
                    txtMaBao.Text = r.Cells[0].Value.ToString();
                    txtTenBao.Text = r.Cells[1].Value.ToString();
                    txtNgayPhatHanh.Text = r.Cells[2].Value.ToString();
                    txtGiaCoHinh.Text = r.Cells[3].Value.ToString();
                    txtGiaKhongHinh.Text = r.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}