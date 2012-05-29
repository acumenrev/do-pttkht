using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Ribbon;
using DevComponents.DotNetBar;


namespace QLDIAOC
{
    public partial class Form1 : DevComponents.DotNetBar.Office2007RibbonForm
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Form Main Menu

        private void btnThongTinChuongTrinh_Click(object sender, EventArgs e)
        {
            frmThongTinChuongTrinh frm = new frmThongTinChuongTrinh();
            frm.ShowDialog();
        }

        private void btnThoatCT_Click(object sender, EventArgs e)
        {
            string msg = "Bạn có chắc muốn thoát không ?";
            if (MessageBox.Show(msg, "", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        #endregion
       
        #region Form Hệ thống

        private void btnThietLapCSDL_Click(object sender, EventArgs e)
        {
            FormHeThong.frmCauHinhLaiCSDL frm = new FormHeThong.frmCauHinhLaiCSDL();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnQuyDinh_Click(object sender, EventArgs e)
        {
            FormHeThong.frmQuyDinh frm = new FormHeThong.frmQuyDinh();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnThongTinNguoiSuDung_Click(object sender, EventArgs e)
        {
            FormHeThong.frmThongTinNguoiSuDung frm = new FormHeThong.frmThongTinNguoiSuDung();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnSaoLuuDuLieu_Click(object sender, EventArgs e)
        {

        }

        private void btnPhucHoiDuLieu_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Form cơ sở dữ liệu

        private void btnDiaOc_Click(object sender, EventArgs e)
        {
            FormCSDL.frmDiaOc frm = new FormCSDL.frmDiaOc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnGiayTo_Click(object sender, EventArgs e)
        {
            FormCSDL.frmGiayTo frm = new FormCSDL.frmGiayTo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnNguoiBan_Click(object sender, EventArgs e)
        {
            FormCSDL.frmNguoiBan frm = new FormCSDL.frmNguoiBan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnBao_Click(object sender, EventArgs e)
        {
            FormCSDL.frmBao frm = new FormCSDL.frmBao();
            frm.MdiParent = this;
            frm.Show();
        }

        #endregion

        #region Form Phiếu đăng ký

        private void btnPhieuDangKy_Click(object sender, EventArgs e)
        {
            FormLapPhieu.frmPhieuDangKy frm = new FormLapPhieu.frmPhieuDangKy();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPhieuGiaHan_Click(object sender, EventArgs e)
        {
            FormLapPhieu.frmPhieuGiaHan frm = new FormLapPhieu.frmPhieuGiaHan();
            frm.MdiParent = this;
            frm.Show();
        }

        #endregion

        #region Form Báo cáo

        private void btnKHSuDungDV_Click(object sender, EventArgs e)
        {
            FormBaoCao.frmKHSuDungDV frm = new FormBaoCao.frmKHSuDungDV();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            FormBaoCao.frmThongKeDoanhThu frm = new FormBaoCao.frmThongKeDoanhThu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDiaOcTheoKH_Click(object sender, EventArgs e)
        {
            FormBaoCao.frmDiaOcTheoTungKhachHang frm = new FormBaoCao.frmDiaOcTheoTungKhachHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnTheoLoaiQC_Click(object sender, EventArgs e)
        {
            FormBaoCao.frmTheoTungLoaiQuangCao frm = new FormBaoCao.frmTheoTungLoaiQuangCao();
            frm.MdiParent = this;
            frm.Show();
        }

        #endregion

        #region Methods

        private void cmdChuDe_Executed(object sender, EventArgs e)
        {
            ICommandSource source = sender as ICommandSource;
            if (source.CommandParameter is string)
            {
                eStyle style = (eStyle)Enum.Parse(typeof(eStyle), source.CommandParameter.ToString());

                StyleManager.ChangeStyle(style, Color.Empty);
                if (style == eStyle.Office2007Blue || style == eStyle.Office2007Black ||
                    style == eStyle.Office2007Silver)
                {
                    btnStartButton.BackstageTabEnabled = false;
                }
                else
                {
                    btnStartButton.BackstageTabEnabled = true;
                }
            }
        }

        #endregion
    }
}
