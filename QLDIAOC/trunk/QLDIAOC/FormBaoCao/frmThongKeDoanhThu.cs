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
    public partial class frmThongKeDoanhThu : DevComponents.DotNetBar.Office2007Form
    {

        #region Fields

        private const int WM_NCLBUTTONDBLCLK = 0xA3;
        DataService m_dal = new DataService();
        BLL.QCToBuomBLL m_qcToBuomBLL = new QCToBuomBLL();
        BLL.QCBaoBLL m_qcBaoBLL = new QCBaoBLL();
        BLL.QCBangBLL m_qcBangBLL = new QCBangBLL();

        #endregion

        #region Constructor

        public frmThongKeDoanhThu()
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

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void btnLapBaoCao_Click(object sender, EventArgs e)
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
            decimal giaTienBang = 0;
            decimal giaTienBao = 0;
            decimal giaTienToBuom = 0;
            decimal tongTien = 0;
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
            // Select du lieu lien quan
            dgvBang.DataSource = m_qcBangBLL.SelectGiaTien(dtTu, dtDen);
            dgvBao.DataSource = m_qcBaoBLL.SelectGiaTien(dtTu, dtDen);
            dgvToBuom.DataSource = m_qcToBuomBLL.SelectGiaTien(dtTu, dtDen);
            // Tinh gia tien cho moi loai quang cao
            giaTienBang = LayGiaTien(dgvBang);
            giaTienBao = LayGiaTien(dgvBao);
            giaTienToBuom = LayGiaTien(dgvToBuom);
            tongTien = giaTienBang + giaTienBao + giaTienToBuom;
            txtDoanhThuBang.Text = giaTienBang.ToString();
            txtDoanhThuBao.Text = giaTienBao.ToString();
            txtDoanhThuToBuom.Text = giaTienToBuom.ToString();
            txtTongDoanhThu.Text = tongTien.ToString();
            
        }

        private void ClearDataGridView(DataGridView dgvKetQua)
        {
            int rowCount = dgvKetQua.RowCount - 1;
            for (int i = 0; i < rowCount; i++)
            {
                dgvKetQua.Rows.Remove(dgvKetQua.CurrentRow);
            }
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
        
        private decimal LayGiaTien(DataGridView dgv)
        {
            decimal giaTien = 0;
            for (int i = 0; i < dgv.RowCount -1; i++)
            {
                decimal temp = decimal.Parse(dgv.Rows[i].Cells[2].Value.ToString());
                giaTien += temp;
            }
                return giaTien;
        }
        
    }
}