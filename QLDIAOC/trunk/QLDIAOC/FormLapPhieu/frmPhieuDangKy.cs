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


namespace QLDIAOC.FormLapPhieu
{
    public partial class frmPhieuDangKy : DevComponents.DotNetBar.Office2007Form
    {

        #region Fields

        DAL.DataService m_dal;
        BLL.PhieuDangKyBLL m_PDKBLL;
        BLL.QCBangBLL m_QCBangBLL;
        BLL.QCBaoBLL m_QCBaoBLL;
        BLL.QCToBuomBLL m_QCToBuomBLL;
        bool m_qcBang;
        bool m_qcToBuom;
        bool m_qcBao;

        #endregion

        #region Constructor

        public frmPhieuDangKy()
        {
            InitializeComponent();
            m_dal = new DataService();
            m_PDKBLL = new PhieuDangKyBLL();
            m_QCBangBLL = new QCBangBLL();
            m_QCBaoBLL = new QCBaoBLL();
            m_QCToBuomBLL = new QCToBuomBLL();
            m_qcBang = m_qcToBuom = m_qcBao = false;
        }

        #endregion

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGiaTienBao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuongToBuom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaTienToBuom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuongBang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaTienBang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmPhieuDangKy_Load(object sender, EventArgs e)
        {

            // Group qc bang
            txtMaQCBang.Enabled = false;
            cbbLoaiBang.Enabled = false;
            txtMoTa.Enabled = false;
            txtKichThuoc.Enabled = false;
            txtSoLuongBang.Enabled = false;
            txtGiaTienBang.Enabled = false;
            btnTaoMoiQCBang.Enabled = false;
            // Group qc to buom
            txtMaQCToBuom.Enabled = false;
            txtSoLuongToBuom.Enabled = false;
            txtGiaTienToBuom.Enabled = false;
            btnTaoMoiQCToBuom.Enabled = false;
            //Group qc bao
            txtMaQCBao.Enabled = false;
            txtGiaTienBao.Enabled = false;
            cbbTenBao.Enabled = false;
            dtpNgayBatDauPhatHanh.Enabled = false;
            txtTongTien.Enabled = false;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void cbBang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbToBuom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbQCBao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTaoMoiMaPDK_Click(object sender, EventArgs e)
        {

        }

        private void btnTaoMoiQCBang_Click(object sender, EventArgs e)
        {

        }

        private void btnTaoMoiQCToBuom_Click(object sender, EventArgs e)
        {

        }

        private void btnTaoMoiQCBao_Click(object sender, EventArgs e)
        {

        }

        private void ClearDataGridView()
        {

        }

        private void ClearInputBang()
        {
            txtMaQCBang.Text = "";
            cbbLoaiBang.Text = "";
            txtMoTa.Text = "";
            txtKichThuoc.Text = "";
            txtSoLuongBang.Text = "";
            txtGiaTienBang.Text = "";
        }

        private void ClearInputBao()
        {
            txtMaQCBao.Text = "";
            txtSoLuongToBuom.Text = "";
            txtGiaTienBao.Text = "";
        }

        private void ClearInputToBuom()
        {
            txtMaQCToBuom.Text = "";
            cbbTenBao.Text = "";
            dtpNgayBatDauPhatHanh.Value = DateTime.Now;
            txtGiaTienToBuom.Text = "";
        }
    }
}