using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;
using DevComponents.DotNetBar.Rendering;
using BLL;
using DAL;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Xml;



namespace QLDIAOC
{
    public partial class Form1 : DevComponents.DotNetBar.Office2007RibbonForm
    {

        #region Fields

        DataService dal;
        SqlCommand m_cmd;
        SqlConnection m_conn;
        XmlReader m_reader;
        string m_server;
        public static string m_myDocumentsPath;
        public static string m_path;
        public static string m_pathWithFile;

        #endregion

        #region Constructor

        public Form1()
        {
            InitializeComponent();
            dal = new DataService();
            m_conn = dal.GetConnect();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            m_myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            m_path = Path.Combine(m_myDocumentsPath, "QuanLyDiaOc");

            m_pathWithFile = m_path + "\\QLDOConfig.xml";
            ReadFile(m_pathWithFile);
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
            try
            {
                MessageBox.Show("Bạn không được lưu trên ổ đĩa được dùng để cài     Windows.\nBấm OK để tiếp tục.",
                                "Lưu ý",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                sfdSaoLuuCSDL.Filter = " Tập tin lưu trữ (*.bak)|*.bak| Tất cả (*.*) | *.*";
                sfdSaoLuuCSDL.Title = "Chọn đường dẫn để lưu tập tin";
                sfdSaoLuuCSDL.FileName = "";
                sfdSaoLuuCSDL.DefaultExt = "*.bak";

                if (sfdSaoLuuCSDL.ShowDialog() == DialogResult.OK)
                {
                    dal.OpenConnection(m_conn);
                    m_cmd = new SqlCommand("BackupCSDL", m_conn);
                    m_cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    m_cmd.Parameters.Add("@TenDB", SqlDbType.VarChar).Value = m_server;
                    m_cmd.Parameters.Add("@DuongDan", SqlDbType.VarChar).Value = sfdSaoLuuCSDL.FileName;

                    m_cmd.ExecuteNonQuery();

                    MessageBox.Show("Đã sao lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dal.CloseConnection(m_conn);
            }
        }

        private void btnPhucHoiDuLieu_Click(object sender, EventArgs e)
        {
            try
            {
                ofdPhucHoiCSDL.Filter = " Tập tin lưu trữ (*.bak)|*.bak| Tất cả (*.*) | *.*";
                ofdPhucHoiCSDL.Title = "Chọn đường dẫn tập tin cần phục hồi";
                ofdPhucHoiCSDL.DefaultExt = "*.bak";
                ofdPhucHoiCSDL.FileName = "";
                if (ofdPhucHoiCSDL.ShowDialog() == DialogResult.OK)
                {
                    string thongBao = "Cơ sở dữ liệu mới sẽ có tên trùng với tên file .bak.\n" +
                                      "mà bạn vừa mới chọn. Bạn có muốn tiếp tục không ?";
                    DialogResult msgBox = MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DialogResult.Yes == msgBox)
                    {
                        // thiết lập thông số cho SqlCommand
                        dal.OpenConnection(m_conn);
                        m_cmd = new SqlCommand("RestoreCSDL", m_conn);
                        m_cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        // các đối số
                        m_cmd.Parameters.Add("@TenDB", SqlDbType.VarChar).Value = LayTenDatabase(ofdPhucHoiCSDL.FileName);
                        m_cmd.Parameters.Add("@DuongDan", SqlDbType.VarChar).Value = ofdPhucHoiCSDL.FileName;
                        m_cmd.ExecuteNonQuery();
                        MessageBox.Show("Đã phục hồi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dal.CloseConnection(m_conn);
            }
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

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

        /// <summary>
        /// Lấy tên CSDL
        /// </summary>
        private string LayTenDatabase(string path)
        {
            string tenDB = "";
            char[] arr = path.ToCharArray();
            int pos = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '\\')
                {
                    pos = i;
                }
            }
            int viTriBatDau = pos + 1;
            int viTriKetThuc = path.Length;
            int soLuong = viTriKetThuc - pos;
            int soLuongCanLay = soLuong - 5;
            tenDB = path.Substring(viTriBatDau, soLuongCanLay);
            return tenDB;
        }

        /// <summary>
        /// Đọc file XML
        /// </summary>
        /// <param name="filePath">Đường dẫn đến file</param>
        private void ReadFile(string filePath)
        {
            m_reader = new XmlTextReader(filePath);
            if (File.Exists(filePath))
            {
                if (File.Exists(filePath))
                {
                    while (m_reader.Read())
                    {
                        if (m_reader.NodeType == XmlNodeType.Element)
                        {
                            if (m_reader.LocalName.Equals("Database"))
                            {
                                m_server = m_reader.ReadString();
                            }
                        }
                    }
                }
                m_reader.Close();
            }
        }

        #endregion     
    }
}
