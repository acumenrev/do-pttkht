using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using DAL;


namespace BLL
{
    class PhieuDangKyBLL
    {
        #region Fields

        DAL.DataService dal;
        private SqlDataAdapter m_da;
        private SqlCommand m_cmd;
        private DataTable m_dt;
        private SqlConnection m_conn;

        #endregion

        #region Constructor

        public PhieuDangKyBLL()
        {
            dal = new DataService();
            m_dt = new DataTable();
            m_cmd = new SqlCommand();
            m_da = new SqlDataAdapter();
            m_conn = dal.GetConnect();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Chèn thêm record
        /// </summary>
        public void Insert(string maPDK, string maNB, string maDO, DateTime ngayDK, DateTime ngayBatDau, DateTime ngayKetThuc, string noiDungQC, decimal soTien, string ghiChu)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("PDKQC_Insert", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaPhieuDangKy", SqlDbType.Char).Value = maPDK;
                m_cmd.Parameters.Add("@MaNguoiBan", SqlDbType.Char).Value = maNB;
                m_cmd.Parameters.Add("@MaDiaOcCB", SqlDbType.Char).Value = maDO;
                m_cmd.Parameters.Add("@NgayDangKy", SqlDbType.DateTime).Value = ngayDK;
                m_cmd.Parameters.Add("@NgayBatDau", SqlDbType.DateTime).Value = ngayBatDau;
                m_cmd.Parameters.Add("@NgayKetThuc", SqlDbType.DateTime).Value = ngayKetThuc;
                m_cmd.Parameters.Add("@NoiDungQC", SqlDbType.NVarChar).Value = noiDungQC;
                m_cmd.Parameters.Add("@SoTien", SqlDbType.Decimal).Value = soTien;
                m_cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = ghiChu;
                // thực thi câu truy vấn
                m_cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                // đóng kết nối và xóa dữ liệu tạm
                dal.CloseConnection(m_conn);
                m_dt.Dispose();
            }
        }

        /// <summary>
        /// Cập nhật record
        /// </summary>
        public void Update(string maPDK, string maNB, string maDO, DateTime ngayDK, DateTime ngayBatDau, DateTime ngayKetThuc, string noiDungQC, decimal soTien, string ghiChu)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("PDKQC_Update", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaPhieuDangKy", SqlDbType.Char).Value = maPDK;
                m_cmd.Parameters.Add("@MaNguoiBan", SqlDbType.Char).Value = maNB;
                m_cmd.Parameters.Add("@MaDiaOcCB", SqlDbType.Char).Value = maDO;
                m_cmd.Parameters.Add("@NgayDangKy", SqlDbType.DateTime).Value = ngayDK;
                m_cmd.Parameters.Add("@NgayBatDau", SqlDbType.DateTime).Value = ngayBatDau;
                m_cmd.Parameters.Add("@NgayKetThuc", SqlDbType.DateTime).Value = ngayKetThuc;
                m_cmd.Parameters.Add("@NoiDungQC", SqlDbType.NVarChar).Value = noiDungQC;
                m_cmd.Parameters.Add("@SoTien", SqlDbType.Decimal).Value = soTien;
                m_cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = ghiChu;
                // thực thi câu truy vấn
                m_cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                // đóng kết nối và xóa dữ liệu tạm
                dal.CloseConnection(m_conn);
                m_dt.Dispose();
            }
        }

        /// <summary>
        /// Xóa record
        /// </summary>
        public void Delete(string maPhieuDK)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("PDKQC_Delete", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaNguoiBan", SqlDbType.Char).Value = maPhieuDK;
                // thực thi câu truy vấn
                m_cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                // đóng kết nối và xóa dữ liệu tạm
                dal.CloseConnection(m_conn);
                m_dt.Dispose();
            }
        }

        /// <summary>
        /// Truy vấn các record
        /// </summary>
        /// <returns></returns>
        public DataTable Select()
        {
            // truy vấn tới bảng dữ liệu
            m_da = dal.CreateAdapter("PDKQC_Select", m_conn);
            m_da.Fill(m_dt);
            return m_dt;
        }

        /// <summary>
        /// Tìm mã địa ốc
        /// </summary>
        /// <param name="maDO"></param>
        /// <returns></returns>
        public DataTable SearchMaDO(string maDO)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("PDKQC_SearchMaDO", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            // Tham so
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.Char).Value = maDO;
            // Thuc thi cau truy van
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm mã người bán
        /// </summary>
        /// <param name="maNguoiBan"></param>
        /// <returns></returns>
        public DataTable SearchMaNB(string maNguoiBan)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("PDKQC_SearchMaNB", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            //Tham số
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.Char).Value = maNguoiBan;
            /// Thuc thi cau truy van
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm mã phiếu đăng ký
        /// </summary>
        /// <param name="maPDK"></param>
        /// <returns></returns>
        public DataTable SearchMaPDK(string maPDK)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("PDKQC_SearchMaPDK", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            //Tham số
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.Char).Value = maPDK;
            /// Thuc thi cau truy van
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }
        #endregion
    }
}
