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

namespace QLDIAOC.FormBaoCao
{
    public partial class frmDiaOcTheoTungKhachHang : DevComponents.DotNetBar.Office2007Form
    {

        #region Constructor

        public frmDiaOcTheoTungKhachHang()
        {
            InitializeComponent();
            m_dal = new DataService();
            m_diaOc = new DiaOcBLL();
            m_nguoiBan = new NguoiBanBLL();
        }

        #endregion

        #region Fields

        private const int WM_NCLBUTTONDBLCLK = 0xA3;
        DataService m_dal;
        BLL.NguoiBanBLL m_nguoiBan;
        BLL.DiaOcBLL m_diaOc;

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

        #endregion

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDiaOcTheoTungKhachHang_Load(object sender, EventArgs e)
        {
            dgvNguoiBan.DataSource = m_nguoiBan.SelectMaHo();
            string maNB = dgvNguoiBan.CurrentRow.Cells[0].Value.ToString();
            dgvDiaOc.DataSource = m_diaOc.SearchMaNB(maNB);
        }

        private void dgvNguoiBan_SelectionChanged(object sender, EventArgs e)
        {
            ClearDataGridViewDiaOc();
            string maNB = dgvNguoiBan.CurrentRow.Cells[0].Value.ToString();
            dgvDiaOc.DataSource = m_diaOc.SearchMaNB(maNB);
        }

        private void ClearDataGridViewDiaOc()
        {
            int rowCount = dgvDiaOc.RowCount - 1;
            for (int i = 0; i < rowCount; i++)
            {
                dgvDiaOc.Rows.Remove(dgvDiaOc.CurrentRow);
            }
        }
    }
}