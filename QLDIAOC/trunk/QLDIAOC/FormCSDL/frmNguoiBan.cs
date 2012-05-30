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
    public partial class frmNguoiBan : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields

        private const int WM_NCLBUTTONDBLCLK = 0xA3;
        DAL.DataService m_dal;
        BLL.NguoiBanBLL m_bll;

        #endregion

        #region Constructor

        public frmNguoiBan()
        {
            InitializeComponent();
            m_dal = new DataService();
            m_bll = new NguoiBanBLL();
        }

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

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            ClearDataGridView();
            if (txtTim.Text.Trim() != "")
            {
                switch (cbbTimTheo.Text)
                {
                    case "Địa chỉ":
                        dgvKetQua.DataSource = m_bll.SearchDiaChi(txtTim.Text);
                        break;
                    case "Họ tên":
                        dgvKetQua.DataSource = m_bll.SearchHoTen(txtTim.Text);
                        break;
                    case "Mã người bán":
                        dgvKetQua.DataSource = m_bll.SearchMaNB(txtTim.Text);
                        break;
                    case "Phone":
                        dgvKetQua.DataSource = m_bll.SearchPhone(txtTim.Text);
                        break;
                }
            }
            else
            {
                dgvKetQua.DataSource = m_bll.Select();
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
            txtMaNguoiBan.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtHoTen.Text = "";
            txtPhone.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text.Trim() != "" &&
                txtEmail.Text.Trim() != "" &&
                txtHoTen.Text.Trim() != "" &&
                txtMaNguoiBan.Text.Trim() != "" &&
                txtPhone.Text.Trim() != "")
            {
                m_bll.Insert(txtMaNguoiBan.Text, txtHoTen.Text, txtDiaChi.Text, txtEmail.Text, txtPhone.Text);
                frmNguoiBan_Load(sender, e);
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập vào những dữ liệu cần thiết", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNguoiBan.Text.Trim() != "")
            {
                m_bll.Delete(txtMaNguoiBan.Text);
                frmNguoiBan_Load(sender, e);
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập vào những dữ liệu cần thiết", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            if (txtDiaChi.Text.Trim() != "" &&
                txtEmail.Text.Trim() != "" &&
                txtHoTen.Text.Trim() != "" &&
                txtMaNguoiBan.Text.Trim() != "" &&
                txtPhone.Text.Trim() != "")
            {
                m_bll.Update(txtMaNguoiBan.Text, txtHoTen.Text, txtDiaChi.Text, txtEmail.Text, txtPhone.Text);
                frmNguoiBan_Load(sender, e);
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập vào những dữ liệu cần thiết", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmNguoiBan_Load(object sender, EventArgs e)
        {
            ClearDataGridView();
            ClearInput();
            dgvKetQua.DataSource = m_bll.Select();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            ClearInput();
            string str = "";

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
                str = "NB" + so.ToString();
            }
            else
            {
                if (dgvKetQua.RowCount - 1 == 0)
                {
                    str = "NB1";
                }
                else
                {
                    if (dgvKetQua.RowCount - 1 == 1)
                    {
                        str = "NB2";
                    }
                }
            }
            txtMaNguoiBan.Text = str;
        }

        private void dgvKetQua_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvKetQua.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dgvKetQua.SelectedRows[0];
                    txtMaNguoiBan.Text = r.Cells[0].Value.ToString();
                    txtHoTen.Text = r.Cells[1].Value.ToString();
                    txtDiaChi.Text = r.Cells[2].Value.ToString();
                    txtEmail.Text = r.Cells[3].Value.ToString();
                    txtPhone.Text = r.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}