using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using BLL;
using DAL;

namespace QLDIAOC.FormCSDL
{
    public partial class frmGiayTo : DevComponents.DotNetBar.Office2007Form
    {
        #region Constructor

        public frmGiayTo()
        {
            InitializeComponent();
            m_bll = new GiayToBLL();
            m_dal = new DataService();
        }

        #endregion

        #region Fields

        private const int WM_NCLBUTTONDBLCLK = 0xA3;
        BLL.GiayToBLL m_bll;
        DAL.DataService m_dal;

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

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            ClearDataGridView();
            if (txtTim.Text.Trim() != "")
            {

                dgvKetQua.DataSource = m_bll.SearchTenGiayTo(txtTim.Text);
            }
            else
            {
                dgvKetQua.DataSource = m_bll.Select();
            }
        }

        private void frmGiayTo_Load(object sender, EventArgs e)
        {
            ClearInput();
            ClearDataGridView();
            dgvKetQua.DataSource = m_bll.Select();
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
            txtGhiChu.Text = "";
            txtMaGiayTo.Text = "";
            txtTenGiayTo.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaGiayTo.Text.Trim() != "" &&
                txtTenGiayTo.Text.Trim() != "")
            {
                m_bll.Insert(txtMaGiayTo.Text, txtTenGiayTo.Text, txtGhiChu.Text);
                frmGiayTo_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập vào những dữ liệu cần thiết", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaGiayTo.Text.Trim() != "")
            {
                m_bll.Delete(txtMaGiayTo.Text);
                frmGiayTo_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập vào những dữ liệu cần thiết", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaGiayTo.Text.Trim() != "" &&
                txtTenGiayTo.Text.Trim() != "")
            {
                m_bll.Update(txtMaGiayTo.Text, txtTenGiayTo.Text, txtGhiChu.Text);
                frmGiayTo_Load(sender, e);
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
                str = "GT" + so.ToString();
            }
            else
            {
                if (dgvKetQua.RowCount - 1 == 0)
                {
                    str = "GT1";
                }
                else
                {
                    if (dgvKetQua.RowCount - 1 == 1)
                    {
                        str = "GT2";
                    }
                }
            }
            txtMaGiayTo.Text = str;
        }

        #endregion    

        private void dgvKetQua_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvKetQua.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dgvKetQua.SelectedRows[0];
                    txtMaGiayTo.Text = r.Cells[0].Value.ToString();
                    txtTenGiayTo.Text = r.Cells[1].Value.ToString();
                    txtGhiChu.Text = r.Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}