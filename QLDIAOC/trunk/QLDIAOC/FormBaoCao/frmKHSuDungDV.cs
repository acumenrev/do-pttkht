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
    public partial class frmKHSuDungDV : DevComponents.DotNetBar.Office2007Form
    {

        #region Fields

        private const int WM_NCLBUTTONDBLCLK = 0xA3;
        DAL.DataService m_dal;
        BLL.PhieuDangKyBLL m_bll;

        #endregion

        #region Constructor

        public frmKHSuDungDV()
        {
            InitializeComponent();
            m_dal = new DataService();
            m_bll = new PhieuDangKyBLL();
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

        private void frmKHSuDungDV_Load(object sender, EventArgs e)
        {

        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {

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

        private void btnTim_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            int ngayCuoiCungCuaThang = 0;
            DateTime dtTu;
            DateTime dtDen;
            switch (dtpKHSuDungDV.Value.Month)
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
                    if (TinhNamNhuan(dtpKHSuDungDV.Value.Year) == true)
                    {
                        ngayCuoiCungCuaThang = 29;
                    }
                    else
                    {
                        ngayCuoiCungCuaThang = 28;
                    }
                    break;
            }
            dtTu = new DateTime(dtpKHSuDungDV.Value.Year, dtpKHSuDungDV.Value.Month, 1);
            dtDen = new DateTime(dtpKHSuDungDV.Value.Year, dtpKHSuDungDV.Value.Month, ngayCuoiCungCuaThang);
            dgvKetQua.DataSource = m_bll.SelectMaNguoiBan(dtTu, dtDen);
        }

        private void ClearDataGridView()
        {
            int rowCount = dgvKetQua.RowCount - 1;
            for (int i = 0; i < rowCount; i++)
            {
                dgvKetQua.Rows.Remove(dgvKetQua.CurrentRow);
            }
        }

        #endregion
    }
}