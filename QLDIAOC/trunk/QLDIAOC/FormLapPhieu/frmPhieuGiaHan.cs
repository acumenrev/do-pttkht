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

namespace QLDIAOC.FormLapPhieu
{
    public partial class frmPhieuGiaHan : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields

        private const int WM_NCLBUTTONDBLCLK = 0xA3;
        DAL.DataService m_dal;
        BLL.PhieuGiaHanBLL m_bll;
        BLL.ThamSoBLL m_thamSo;
        #endregion

        #region Constructor

        public frmPhieuGiaHan()
        {
            InitializeComponent();
            m_dal = new DataService();
            m_bll = new PhieuGiaHanBLL();
        }

        #endregion

        #region Methods

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaPDK.Text.Trim() != "" && txtGiaTien.Text.Trim() != "")
            {
                if (dtpDen.Value <= dtpTu.Value)
                {
                    MessageBox.Show("Xin xem lại giá trị ngày không hợp lý về tính logic", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    m_bll.Update(txtMaPDK.Text, decimal.Parse(txtGiaTien.Text), dtpTu.Value, dtpDen.Value);
                }
               
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            ClearDataGridView();
            if (txtTim.Text.Trim() != "")
            {
                dgvKetQua.DataSource = m_bll.SearchMaDO(txtTim.Text);
            }
            else
            {
                dgvKetQua.DataSource = m_bll.Select();
            }
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
                    txtPhone.Text = r.Cells[3].Value.ToString();
                    txtMaPDK.Text = r.Cells[4].Value.ToString();
                    dtpTu.Value = DateTime.Parse(r.Cells[6].Value.ToString());
                    dtpDen.Value = DateTime.Now;
                    decimal tien = decimal.Parse(r.Cells[7].Value.ToString());
                    tien = (decimal.Parse(txtHeSo.Text) * tien) / 100;
                    txtGiaTien.Text = tien.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            txtDiaChi.Text = "";
            txtGiaTien.Text = "";
            txtHoTen.Text = "";
            txtMaNguoiBan.Text = "";
            txtMaPDK.Text = "";
            txtPhone.Text = "";
        }
    }
}