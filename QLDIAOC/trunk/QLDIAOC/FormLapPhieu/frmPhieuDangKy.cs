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
        BLL.NguoiBanBLL m_nguoiBanBLL;
        BLL.DiaOcBLL m_diaOcBLL;
        BLL.ThamSoBLL m_thamSoBLL;
        BLL.BaoBLL m_baoBLL;

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
            m_diaOcBLL = new DiaOcBLL();
            m_nguoiBanBLL = new NguoiBanBLL();
            m_thamSoBLL = new ThamSoBLL();
            m_baoBLL = new BaoBLL();
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
            try
            {
                // TODO: This line of code loads data into the 'qLDODataSet.BAO' table. You can move, or remove it, as needed.
                this.bAOTableAdapter.Fill(this.qLDODataSet.BAO);
                // TODO: This line of code loads data into the 'qLDODataSet.DIAOCCB' table. You can move, or remove it, as needed.
                this.dIAOCCBTableAdapter.Fill(this.qLDODataSet.DIAOCCB);
                // TODO: This line of code loads data into the 'qLDODataSet.NGUOIBAN' table. You can move, or remove it, as needed.
                this.nGUOIBANTableAdapter.Fill(this.qLDODataSet.NGUOIBAN);

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

                dgvKetQua.DataSource = m_PDKBLL.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            if (txtMaPhieuDangKy.Text.Trim() != "" &&
                cbbMaNB.Text.Trim() != "" &&
                cbbMaDiaOc.Text.Trim() != "" &&
                txtNoiDungQuangCao.Text.Trim() != "")
            {
                if (cbBang.Checked == false && cbToBuom.Checked == false && cbQCBao.Checked == false)
                {
                    MessageBox.Show("Bạn phải chọn ít nhất một loại dịch vụ quảng cáo thì mới có thể đăng ký", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    m_PDKBLL.Insert(txtMaPhieuDangKy.Text, cbbMaNB.Text, cbbMaDiaOc.Text, dtpNgayDK.Value, dtpNgayBatDau.Value, dtpNgayKetThuc.Value, txtNoiDungQuangCao.Text, 0, "");
                    // QC bao
                    if (cbQCBao.Checked == true)
                    {
                        // Kiem tra cac thong tin trong quang cao bao da dc nhap
                        if (txtMaQCBao.Text.Trim() != "" &&
                            cbbTenBao.Text.Trim() != "" &&
                            txtGiaTienBao.Text.Trim() != "")
                        {
                            DataGridView dgv = new DataGridView();
                            dgv.DataSource = m_baoBLL.SelectMaBao(cbbTenBao.Text);
                            string maBao = dgv.Rows[0].Cells[0].Value.ToString();
                            m_QCBaoBLL.Insert(txtMaQCBao.Text, txtMaPhieuDangKy.Text, maBao, dtpNgayBatDauPhatHanh.Value, decimal.Parse(txtGiaTienBao.Text));
                        }
                        else
                        {
                            MessageBox.Show("Bạn chưa cung cấp đầy đủ thông tin cần thiết", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    // QC To buom
                    if (txtGiaTienToBuom.Text.Trim() != "" &&
                        txtMaQCToBuom.Text.Trim() != "" &&
                        txtSoLuongToBuom.Text.Trim() != "")
                    {
                        m_QCToBuomBLL.Insert(txtMaQCToBuom.Text, txtMaPhieuDangKy.Text, int.Parse(txtSoLuongToBuom.Text), decimal.Parse(txtGiaTienToBuom.Text));
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa cung cấp đầy đủ thông tin cần thiết", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // QC Bang
                    if (txtMaQCBang.Text.Trim() != "" &&
                        cbbLoaiBang.Text.Trim() != "" &&
                        txtMoTa.Text.Trim() != "" &&
                        txtKichThuoc.Text.Trim() != "" &&
                        txtSoLuongBang.Text.Trim() != "" &&
                        txtGiaTienBang.Text.Trim() != "")
                    {
                        DataGridView dgvThamSo = new DataGridView();
                        dgvThamSo.DataSource = m_thamSoBLL.SelectGiaTri(cbbLoaiBang.Text);
                        decimal giaTienBang = decimal.Parse(dgvThamSo.Rows[0].Cells[0].Value.ToString());
                        m_QCBangBLL.Insert(txtMaQCBang.Text, txtMaPhieuDangKy.Text, cbbLoaiBang.Text, txtMoTa.Text, txtKichThuoc.Text, int.Parse(txtSoLuongBang.Text), giaTienBang);
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa cung cấp đầy đủ thông tin cần thiết", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPhieuDangKy.Text.Trim() != "")
            {
                // QC Bang
                if (cbBang.Checked == true)
                {
                    if (txtMaQCBang.Text.Trim() != "")
                    {
                        m_QCBangBLL.Delete(txtMaQCBang.Text, txtMaPhieuDangKy.Text);
                    }
                }
                // QC To Buom
                if (cbToBuom.Checked == true)
                {
                    if (txtMaQCToBuom.Text.Trim() != "")
                    {
                        m_QCToBuomBLL.Delete(txtMaQCToBuom.Text, txtMaPhieuDangKy.Text);
                    }
                }
                // QC Bao
                if (cbQCBao.Checked == true)
                {
                    if (txtMaQCBao.Text.Trim() != "")
                    {
                        DataGridView dgv = new DataGridView();
                        dgv.DataSource = m_baoBLL.SelectMaBao(cbbTenBao.Text);
                        string maBao = dgv.Rows[0].Cells[0].Value.ToString();
                        m_QCBaoBLL.Delete(txtMaQCBao.Text, txtMaPhieuDangKy.Text, maBao);
                    }
                }

                
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            if (txtMaPhieuDangKy.Text.Trim() != "" &&
                cbbMaNB.Text.Trim() != "" &&
                cbbMaDiaOc.Text.Trim() != "" &&
                txtNoiDungQuangCao.Text.Trim() != "")
            {
                if (cbBang.Checked == false && cbToBuom.Checked == false && cbQCBao.Checked == false)
                {
                    MessageBox.Show("Bạn phải chọn ít nhất một loại dịch vụ quảng cáo thì mới có thể đăng ký", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    m_PDKBLL.Update(txtMaPhieuDangKy.Text, cbbMaNB.Text, cbbMaDiaOc.Text, dtpNgayDK.Value, dtpNgayBatDau.Value, dtpNgayKetThuc.Value, txtNoiDungQuangCao.Text, 0, "");
                    // QC bao
                    if (cbQCBao.Checked == true)
                    {
                        // Kiem tra cac thong tin trong quang cao bao da dc nhap
                        if (txtMaQCBao.Text.Trim() != "" &&
                            cbbTenBao.Text.Trim() != "" &&
                            txtGiaTienBao.Text.Trim() != "")
                        {
                            DataGridView dgv = new DataGridView();
                            dgv.DataSource = m_baoBLL.SelectMaBao(cbbTenBao.Text);
                            string maBao = dgv.Rows[0].Cells[0].Value.ToString();
                            m_QCBaoBLL.Update(txtMaQCBao.Text, txtMaPhieuDangKy.Text, maBao, dtpNgayBatDauPhatHanh.Value, decimal.Parse(txtGiaTienBao.Text));
                        }
                        else
                        {
                            MessageBox.Show("Bạn chưa cung cấp đầy đủ thông tin cần thiết", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    // QC To buom
                    if (txtGiaTienToBuom.Text.Trim() != "" &&
                        txtMaQCToBuom.Text.Trim() != "" &&
                        txtSoLuongToBuom.Text.Trim() != "")
                    {
                        m_QCToBuomBLL.Update(txtMaQCToBuom.Text, txtMaPhieuDangKy.Text, int.Parse(txtSoLuongToBuom.Text), decimal.Parse(txtGiaTienToBuom.Text));
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa cung cấp đầy đủ thông tin cần thiết", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // QC Bang
                    if (txtMaQCBang.Text.Trim() != "" &&
                        cbbLoaiBang.Text.Trim() != "" &&
                        txtMoTa.Text.Trim() != "" &&
                        txtKichThuoc.Text.Trim() != "" &&
                        txtSoLuongBang.Text.Trim() != "" &&
                        txtGiaTienBang.Text.Trim() != "")
                    {
                        DataGridView dgvThamSo = new DataGridView();
                        dgvThamSo.DataSource = m_thamSoBLL.SelectGiaTri(cbbLoaiBang.Text);
                        decimal giaTienBang = decimal.Parse(dgvThamSo.Rows[0].Cells[0].Value.ToString());
                        m_QCBangBLL.Update(txtMaQCBang.Text, txtMaPhieuDangKy.Text, cbbLoaiBang.Text, txtMoTa.Text, txtKichThuoc.Text, int.Parse(txtSoLuongBang.Text), giaTienBang);
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa cung cấp đầy đủ thông tin cần thiết", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void cbBang_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBang.Checked == true)
            {
                // Xet enable
                txtMaQCBang.Enabled = true;
                cbbLoaiBang.Enabled = true;
                txtMoTa.Enabled = true;
                txtKichThuoc.Enabled = true;
                txtSoLuongBang.Enabled = true;
                txtGiaTienBang.Enabled = true;
                btnTaoMoiQCBang.Enabled = true;
            }
            else
            {
                txtMaQCBang.Enabled = false;
                cbbLoaiBang.Enabled = false;
                txtMoTa.Enabled = false;
                txtKichThuoc.Enabled = false;
                txtSoLuongBang.Enabled = false;
                txtGiaTienBang.Enabled = false;
                btnTaoMoiQCBang.Enabled = false;
            }
        }

        private void cbToBuom_CheckedChanged(object sender, EventArgs e)
        {
            if (cbToBuom.Checked == true)
            {
                txtMaQCToBuom.Enabled = true;
                txtSoLuongToBuom.Enabled = true;
                txtGiaTienToBuom.Enabled = true;
                btnTaoMoiQCToBuom.Enabled = true;
            }
            else
            {
                txtMaQCToBuom.Enabled = false;
                txtSoLuongToBuom.Enabled = false;
                txtGiaTienToBuom.Enabled = false;
                btnTaoMoiQCToBuom.Enabled = false;
            }
        }

        private void cbQCBao_CheckedChanged(object sender, EventArgs e)
        {
            if (cbQCBao.Checked == true)
            {
                txtMaQCBao.Enabled = true;
                txtGiaTienBao.Enabled = true;
                cbbTenBao.Enabled = true;
                dtpNgayBatDauPhatHanh.Enabled = true;
                txtTongTien.Enabled = true;
            }
            else
            {
                txtMaQCBao.Enabled = false;
                txtGiaTienBao.Enabled = false;
                cbbTenBao.Enabled = false;
                dtpNgayBatDauPhatHanh.Enabled = false;
                txtTongTien.Enabled = false;
            }
        }

        private void btnTaoMoiMaPDK_Click(object sender, EventArgs e)
        {
            ClearInputAll();
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
                str = "DK" + so.ToString();
            }
            else
            {
                if (dgvKetQua.RowCount - 1 == 0)
                {
                    str = "DK1";
                }
                else
                {
                    if (dgvKetQua.RowCount - 1 == 1)
                    {
                        str = "DK2";
                    }
                }
            }
            txtMaPhieuDangKy.Text = str;
        }

        private void btnTaoMoiQCBang_Click(object sender, EventArgs e)
        {
            ClearInputBang();
            string str = "";
            DataGridView dgv = new DataGridView();
            dgv.DataSource = m_QCBangBLL.Select();
            if (dgv.RowCount - 1 > 1)
            {
                int rowCount = dgv.RowCount - 1;
                string temp = dgv.Rows[rowCount - 1].Cells[0].Value.ToString().Trim();
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
                str = "BA" + so.ToString();
            }
            else
            {
                if (dgvKetQua.RowCount - 1 == 0)
                {
                    str = "BA1";
                }
                else
                {
                    if (dgvKetQua.RowCount - 1 == 1)
                    {
                        str = "BA2";
                    }
                }
            }
            txtMaQCBang.Text = str;
        }

        private void btnTaoMoiQCToBuom_Click(object sender, EventArgs e)
        {
            ClearInputToBuom();
            string str = "";
            DataGridView dgv = new DataGridView();
            dgv.DataSource = m_QCToBuomBLL.Select();
            if (dgv.RowCount - 1 > 1)
            {
                int rowCount = dgv.RowCount - 1;
                string temp = dgv.Rows[rowCount - 1].Cells[0].Value.ToString().Trim();
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
                str = "TB" + so.ToString();
            }
            else
            {
                if (dgvKetQua.RowCount - 1 == 0)
                {
                    str = "TB1";
                }
                else
                {
                    if (dgvKetQua.RowCount - 1 == 1)
                    {
                        str = "TB2";
                    }
                }
            }
            txtMaQCToBuom.Text = str;
        }

        private void btnTaoMoiQCBao_Click(object sender, EventArgs e)
        {
            ClearInputToBuom();
            string str = "";
            DataGridView dgv = new DataGridView();
            dgv.DataSource = m_QCBaoBLL.Select();
            if (dgv.RowCount - 1 > 1)
            {
                int rowCount = dgv.RowCount - 1;
                string temp = dgv.Rows[rowCount - 1].Cells[0].Value.ToString().Trim();
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
                str = "QB" + so.ToString();
            }
            else
            {
                if (dgvKetQua.RowCount - 1 == 0)
                {
                    str = "QB1";
                }
                else
                {
                    if (dgvKetQua.RowCount - 1 == 1)
                    {
                        str = "QB2";
                    }
                }
            }
            txtMaQCBao.Text = str;
        }

        private void ClearDataGridView()
        {
            int rowCount = dgvKetQua.RowCount - 1;
            for (int i = 0; i < rowCount; i++)
            {
                dgvKetQua.Rows.Remove(dgvKetQua.CurrentRow);
            }
        }

        private void ClearInputAll()
        {
            ClearInputBang();
            ClearInputBao();
            ClearInputToBuom();
            txtMaPhieuDangKy.Text = "";
            cbbMaNB.Text = "";
            cbbMaDiaOc.Text = "";
            dtpNgayDK.Value = DateTime.Now;
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
            txtNoiDungQuangCao.Text = "";
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

        private void dtpNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            dtpNgayKetThuc_ValueChanged(sender, e);
        }

        private void dtpNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgayKetThuc.Value < dtpNgayBatDau.Value)
            {
                MessageBox.Show("Giá trị ngày sai logic\nXin chọn lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgayKetThuc.Value = DateTime.Now;
                dtpNgayBatDau.Value = DateTime.Now;
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            ClearDataGridView();
            if (txtTim.Text.Trim() == "")
            {
                dgvKetQua.DataSource = m_PDKBLL.Select();
            }
            else
            {
                switch(cbbTimTheo.Text)
                {
                    case "Mã địa ốc":
                        dgvKetQua.DataSource = m_PDKBLL.SearchMaDO(txtTim.Text);
                        break;
                    case "Mã người bán":
                        dgvKetQua.DataSource = m_PDKBLL.SearchMaNB(txtTim.Text);
                        break;
                    case "Mã phiếu đăng ký":
                        dgvKetQua.DataSource = m_PDKBLL.SearchMaPDK(txtTim.Text);
                        break;
                }
            }
        }

        private void dgvKetQua_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvKetQua.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dgvKetQua.SelectedRows[0];
                    txtMaPhieuDangKy.Text = r.Cells[0].Value.ToString();
                    cbbMaNB.Text = r.Cells[1].Value.ToString();
                    cbbMaDiaOc.Text = r.Cells[2].Value.ToString();
                    dtpNgayDK.Value = DateTime.Parse(r.Cells[3].Value.ToString());
                    dtpNgayBatDau.Value = DateTime.Parse(r.Cells[4].Value.ToString());
                    dtpNgayKetThuc.Value = DateTime.Parse(r.Cells[5].Value.ToString());
                    txtNoiDungQuangCao.Text = r.Cells[6].Value.ToString();
                    txtTongTien.Text = r.Cells[7].Value.ToString();

                    DataGridView dgvToBuom = new DataGridView();
                    DataGridView dgvBao = new DataGridView();
                    DataGridView dgvBang = new DataGridView();

                    // To Buom
                    dgvToBuom.DataSource = m_QCToBuomBLL.SelectQC(txtMaPhieuDangKy.Text);
                    if (dgvToBuom.Rows[0].Cells[0].Value.ToString() != "")
                    {
                        txtMaQCToBuom.Text = dgvToBuom.Rows[0].Cells[0].Value.ToString();
                        txtSoLuongToBuom.Text = dgvToBuom.Rows[0].Cells[1].Value.ToString();
                        txtGiaTienToBuom.Text = dgvToBuom.Rows[0].Cells[1].Value.ToString();
                    }
                    // Bao
                    dgvBang.DataSource = m_QCBangBLL.SelectQC(txtMaPhieuDangKy.Text);
                    if (dgvBao.Rows[0].Cells[0].Value.ToString() != "")
                    {
                        txtMaQCBao.Text = dgvBao.Rows[0].Cells[0].Value.ToString();
                        // lay ten bao
                        DataTable dt = new DataTable();
                        dt = m_QCBaoBLL.SearchMaBao(dgvBao.Rows[0].Cells[1].Value.ToString());
                        cbbTenBao.Text = dt.Rows[0][1].ToString();
                       
                        dtpNgayBatDauPhatHanh.Value = DateTime.Parse(dgvBao.Rows[0].Cells[2].Value.ToString());
                        txtGiaTienBao.Text = dgvBao.Rows[0].Cells[3].Value.ToString();
                    }
                    // Bang
                    dgvBang.DataSource = m_QCBangBLL.SelectQC(txtMaPhieuDangKy.Text);
                    if (dgvBang.Rows[0].Cells[0].Value.ToString() != "")
                    {
                        txtMaQCBang.Text = dgvBang.Rows[0].Cells[0].Value.ToString();
                        cbbLoaiBang.Text = dgvBang.Rows[0].Cells[1].Value.ToString();
                        txtMoTa.Text = dgvBang.Rows[0].Cells[2].Value.ToString();
                        txtKichThuoc.Text = dgvBang.Rows[0].Cells[3].Value.ToString();
                        txtSoLuongBang.Text = dgvBang.Rows[0].Cells[4].Value.ToString();
                        txtGiaTienBang.Text = dgvBang.Rows[0].Cells[5].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbCoHinh_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCoHinh.Checked == true)
            {
                DataGridView dgvGiaCoHinh = new DataGridView();
                dgvGiaCoHinh.DataSource = m_baoBLL.SelectGiaCoHinh(cbbTenBao.Text);
                txtGiaTienBao.Text = dgvGiaCoHinh.Rows[0].Cells[0].Value.ToString();
            }
            else
            {
                DataGridView dgvGiaCoHinh = new DataGridView();
                dgvGiaCoHinh.DataSource = m_baoBLL.SelectGiaKhongHinh(cbbTenBao.Text);
                txtGiaTienBao.Text = dgvGiaCoHinh.Rows[0].Cells[0].Value.ToString();
            }
        }

        
    }
}