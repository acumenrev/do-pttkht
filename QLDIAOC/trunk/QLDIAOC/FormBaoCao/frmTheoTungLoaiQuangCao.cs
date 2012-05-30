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

namespace QLDIAOC.FormBaoCao
{
    public partial class frmTheoTungLoaiQuangCao : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields

        private const int WM_NCLBUTTONDBLCLK = 0xA3;
        DAL.DataService m_dal;
        BLL.QCBaoBLL m_qcBaoBLL;
        BLL.QCBangBLL m_qcBangBLL;
        BLL.QCToBuomBLL m_qcToBuomBLL;
        

        #endregion

        #region Constructor

        public frmTheoTungLoaiQuangCao()
        {
            InitializeComponent();
            m_dal = new DataService();
            m_qcBangBLL = new QCBangBLL();
            m_qcBaoBLL = new QCBaoBLL();
            m_qcToBuomBLL = new QCToBuomBLL();
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

        #endregion

       

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            ClearDataGridView(dgvBang);
            ClearDataGridView(dgvBao);
            ClearDataGridView(dgvToBuom);
            int ngayCuoiCungCuaThang = 0;
            DateTime dtTu;
            DateTime dtDen;
            switch (dtpThang.Value.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    ngayCuoiCungCuaThang = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    ngayCuoiCungCuaThang = 30;
                    break;
                case 2:
                    if (TinhNamNhuan(dtpThang.Value.Year) == true)
                    {
                        ngayCuoiCungCuaThang = 29;
                    }
                    else
                    {
                        ngayCuoiCungCuaThang = 28;
                    }
                    break;
            }
            dtTu = new DateTime(dtpThang.Value.Year, dtpThang.Value.Month, 1);
            dtDen = new DateTime(dtpThang.Value.Year, dtpThang.Value.Month, ngayCuoiCungCuaThang);
            dgvBang.DataSource = m_qcBangBLL.SelectMaPDK(dtTu, dtDen);
            dgvBao.DataSource = m_qcBaoBLL.SelectMaPDK(dtTu, dtDen);
            dgvToBuom.DataSource = m_qcToBuomBLL.SelectMaPDK(dtTu, dtDen);
        }

        private bool TinhNamNhuan(int nam)
        {
            if (nam % 4 != 0)
            {
                return false;
            }
            if (nam % 100 == 0)
            {
                return (nam % 400 == 0);
            }
            return true;
        }

        private void ClearDataGridView(DataGridView dgvKetQua)
        {
            int rowCount = dgvKetQua.RowCount - 1;
            for (int i = 0; i < rowCount; i++)
            {
                dgvKetQua.Rows.Remove(dgvKetQua.CurrentRow);
            }
        }
    }
}