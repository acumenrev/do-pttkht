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

namespace QLDIAOC.FormHeThong
{
    public partial class frmQuyDinh : DevComponents.DotNetBar.Office2007Form
    {

        #region Constructor

        public frmQuyDinh()
        {
            InitializeComponent();
            m_dal = new DataService();
            m_bll = new ThamSoBLL();
        }

        #endregion

        #region Fields

        private const int WM_NCLBUTTONDBLCLK = 0xA3;
        DAL.DataService m_dal;
        BLL.ThamSoBLL m_bll;

        #endregion

        #region Methods

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        #endregion    

        private void frmQuyDinh_Load(object sender, EventArgs e)
        {
            int rowCount = dgvBangThamSo.Rows.Count - 1;
            for (int i = 0; i < rowCount; i++)
            {
                dgvBangThamSo.Rows.Remove(dgvBangThamSo.CurrentRow);
            }
            dgvBangThamSo.DataSource = m_bll.Select();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTenThamSo.Text.Trim() != "")
            {
                m_bll.Update(txtTenThamSo.Text, txtGiaTri.Text, txtGhiChu.Text);
                ClearDataGridView();
                frmQuyDinh_Load(sender, e);
                ClearInput();
                MessageBox.Show("Cập nhật thành công");

            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên tham số cần sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenThamSo.Focus();
            }
        }

        private void ClearDataGridView()
        {
            int rowCount = dgvBangThamSo.RowCount - 1;
            for (int i = 0; i < rowCount; i++)
            {
                dgvBangThamSo.Rows.Remove(dgvBangThamSo.CurrentRow);
            }
        }

        private void ClearInput()
        {
            txtGhiChu.Text = "";
            txtGiaTri.Text = "";
            txtTenThamSo.Text = "";
        }

        private void dgvBangThamSo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvBangThamSo.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dgvBangThamSo.SelectedRows[0];
                    txtTenThamSo.Text = r.Cells[0].Value.ToString();
                    txtGiaTri.Text = r.Cells[1].Value.ToString();
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