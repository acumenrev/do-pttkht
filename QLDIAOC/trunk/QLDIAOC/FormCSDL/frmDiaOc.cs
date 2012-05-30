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
    public partial class frmDiaOc : DevComponents.DotNetBar.Office2007Form
    {

        #region Fields

        DAL.DataService m_dal;
        BLL.DiaOcBLL m_bll;

        #endregion

        #region Constructor


        public frmDiaOc()
        {
            InitializeComponent();
            m_dal = new DataService();
            m_bll = new DiaOcBLL();
        }

        #endregion

        #region Methods


        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtXayNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoTang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDatDai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDatRong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNhaDai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNhaRong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmDiaOc_Load(object sender, EventArgs e)
        {
            lbTu.Visible = false;
            lbDen.Visible = false;
            txtTu.Visible = false;
            txtDen.Visible = false;
            btnTim.Visible = false;
            txtTim.Visible = false;
            ClearDataGridView();
            ClearInput();
            dgvKetQua.DataSource = m_bll.Select();
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
                str = "DO" + so.ToString();
            }
            else
            {
                if (dgvKetQua.RowCount - 1 == 0)
                {
                    str = "DO1";
                }
                else
                {
                    if (dgvKetQua.RowCount - 1 == 1)
                    {
                        str = "DO2";
                    }
                }
            }
            txtMaDiaOc.Text = str;
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
            txtMaDiaOc.Text = "";
            txtDuong.Text = "";
            txtDienTichSuDung.Text = "";
            txtDienTichKhuonVien.Text = "";
            txtDienTichKhuonVien.Text = "";
            txtDen.Text = "";
            txtGiaBan.Text = "";
            txtHuongNha.Text = "";
            txtMaDiaOc.Text = "";
            txtPhuong.Text = "";
            txtQuan.Text = "";
            txtSoNha.Text = "";
            txtSoTang.Text = "";
            txtTu.Text = "";
            txtViTri.Text = "";
            txtXayNam.Text = "";
            cbbLoaiNen.Text = "";
            cbbLoaiNha.Text = "";
            cbbMaNguoiBan.Text = "";
            cbbTimTheo.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaDiaOc.Text.Trim() != "" &&
                txtDienTichKhuonVien.Text.Trim() != "" &&
                txtDienTichSuDung.Text.Trim() != "" &&
                txtDuong.Text.Trim() != "" &&
                txtGiaBan.Text.Trim() != "" &&
                txtHuongNha.Text.Trim() != "" &&
                txtPhuong.Text.Trim() != "" &&
                txtQuan.Text.Trim() != "" &&
                txtSoNha.Text.Trim() != "" &&
                txtSoTang.Text.Trim() != "" &&
                txtViTri.Text.Trim() != "" &&
                txtXayNam.Text.Trim() != "" &&
                cbbLoaiNen.Text.Trim() != "" &&
                cbbLoaiNha.Text.Trim() != "" &&
                cbbMaNguoiBan.Text.Trim() != "")
            {
                string daBan = "";
                if (cbDaBan.Checked == true)
                {
                    daBan = "Đã bán";
                }
                else
                {
                    daBan = "Chưa bán";
                }
                m_bll.Insert(txtMaDiaOc.Text,
                            txtSoNha.Text,
                            txtDuong.Text,
                            txtPhuong.Text,
                            txtQuan.Text,
                            cbbMaNguoiBan.Text,
                            txtHuongNha.Text,
                            txtMoTaChiTiet.Text,
                            int.Parse(txtXayNam.Text),
                            txtViTri.Text,
                            int.Parse(txtSoTang.Text),
                            cbbLoaiNha.Text,
                            cbbLoaiNen.Text,
                            float.Parse(txtDienTichKhuonVien.Text),
                            float.Parse(txtDienTichSuDung.Text),
                            daBan,
                            decimal.Parse(txtGiaBan.Text));
                frmDiaOc_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập vào những dữ liệu cần thiết", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDiaOc.Text.Trim() != "")
            {
                m_bll.Delete(txtMaDiaOc.Text);
                frmDiaOc_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập vào những dữ liệu cần thiết", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaDiaOc.Text.Trim() != "" &&
                txtDienTichKhuonVien.Text.Trim() != "" &&
                txtDienTichSuDung.Text.Trim() != "" &&
                txtDuong.Text.Trim() != "" &&
                txtGiaBan.Text.Trim() != "" &&
                txtHuongNha.Text.Trim() != "" &&
                txtPhuong.Text.Trim() != "" &&
                txtQuan.Text.Trim() != "" &&
                txtSoNha.Text.Trim() != "" &&
                txtSoTang.Text.Trim() != "" &&
                txtViTri.Text.Trim() != "" &&
                txtXayNam.Text.Trim() != "" &&
                cbbLoaiNen.Text.Trim() != "" &&
                cbbLoaiNha.Text.Trim() != "" &&
                cbbMaNguoiBan.Text.Trim() != "")
            {
                string daBan = "";
                if (cbDaBan.Checked == true)
                {
                    daBan = "Đã bán";
                }
                else
                {
                    daBan = "Chưa bán";
                }
                m_bll.Update(txtMaDiaOc.Text,
                            txtSoNha.Text,
                            txtDuong.Text,
                            txtPhuong.Text,
                            txtQuan.Text,
                            cbbMaNguoiBan.Text,
                            txtHuongNha.Text,
                            "",
                            int.Parse(txtXayNam.Text),
                            txtViTri.Text,
                            int.Parse(txtSoTang.Text),
                            cbbLoaiNha.Text,
                            cbbLoaiNen.Text,
                            float.Parse(txtDienTichKhuonVien.Text),
                            float.Parse(txtDienTichSuDung.Text),
                            daBan,
                            decimal.Parse(txtGiaBan.Text));
                frmDiaOc_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập vào những dữ liệu cần thiết", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            ClearDataGridView();
            if (txtTim.Text.Trim() != "")
            {
                switch (cbbTimTheo.Text)
                {
                    case "Số nhà":
                        dgvKetQua.DataSource = m_bll.SearchSoNha(txtTim.Text);
                        break;
                    case "Đường":
                        dgvKetQua.DataSource = m_bll.SearchDuong(txtTim.Text);
                        break;
                    case "Phường":
                        dgvKetQua.DataSource = m_bll.SearchPhuong(txtTim.Text);
                        break;
                    case "Quận":
                        dgvKetQua.DataSource = m_bll.SearchQuan(txtTim.Text);
                        break;
                    case "Hướng nhà":
                        dgvKetQua.DataSource = m_bll.SearchHuongNha(txtTim.Text);
                        break;
                    case "Loại nền":
                        dgvKetQua.DataSource = m_bll.SearchLoaiNen(txtTim.Text);
                        break;
                    case "Loại nhà":
                        dgvKetQua.DataSource = m_bll.SearchLoaiNha(txtTim.Text);
                        break;
                    case "Mã địa ốc":
                        dgvKetQua.DataSource = m_bll.SearchMaDO(txtTim.Text);
                        break;
                    case "Mã người bán":
                        dgvKetQua.DataSource = m_bll.SearchMaNB(txtTim.Text);
                        break;
                    case "Vị trí":
                        dgvKetQua.DataSource = m_bll.SearchViTri(txtTim.Text);
                        break;
                }
            }
            else
            {
                dgvKetQua.DataSource = m_bll.Select();
            }
        }

        private void cbbTimTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbTimTheo.Text)
            {
                case "Số nhà":
                case "Đường":
                case "Phường":
                case "Quận":
                case "Hướng nhà":
                case "Loại nền":
                case "Loại nhà":
                case "Mã địa ốc":
                case "Mã người bán":
                case "Vị trí":
                    lbDen.Visible = false;
                    lbTu.Visible = false;
                    txtTu.Visible = false;
                    txtDen.Visible = false;
                    txtTim.Visible = true;
                    btnTim.Visible = false;
                    break;
                case "Xây năm":
                case "Số tầng":
                    lbDen.Visible = true;
                    lbTu.Visible = true;
                    txtTu.Visible = true;
                    txtDen.Visible = true;
                    txtTim.Visible = false;
                    btnTim.Visible = true;
                    break;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            switch (cbbTimTheo.Text)
            {
                case "Xây năm":
                    dgvKetQua.DataSource = m_bll.SearchXayNam(int.Parse(txtTu.Text), int.Parse(txtDen.Text));
                    break;
                case "Số tầng":
                    dgvKetQua.DataSource = m_bll.SearchSoTang(int.Parse(txtTu.Text), int.Parse(txtDen.Text));
                    break;
            }
        }

        private void dgvKetQua_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvKetQua.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dgvKetQua.SelectedRows[0];
                    txtMaDiaOc.Text = r.Cells[0].Value.ToString();
                    txtSoNha.Text = r.Cells[1].Value.ToString();
                    txtDuong.Text = r.Cells[2].Value.ToString();
                    txtPhuong.Text = r.Cells[3].Value.ToString();
                    txtQuan.Text = r.Cells[4].Value.ToString();
                    cbbMaNguoiBan.Text = r.Cells[5].Value.ToString();
                    txtHuongNha.Text = r.Cells[6].Value.ToString();
                    txtXayNam.Text = r.Cells[6].Value.ToString();
                    txtViTri.Text = r.Cells[7].Value.ToString();
                    txtSoTang.Text = r.Cells[8].Value.ToString();
                    cbbLoaiNha.Text = r.Cells[9].Value.ToString();
                    cbbLoaiNen.Text = r.Cells[10].Value.ToString();
                    txtDienTichKhuonVien.Text = r.Cells[11].Value.ToString();
                    txtDienTichSuDung.Text = r.Cells[12].Value.ToString();
                    txtMoTaChiTiet.Text = r.Cells[13].Value.ToString();
                    string str = r.Cells[14].Value.ToString();
                    if (str == "Đã bán")
                    {
                        cbDaBan.Checked = true;
                    }
                    else
                    {
                        cbDaBan.Checked = false;
                    }
                    txtGiaBan.Text = r.Cells[15].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDienTichSuDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}