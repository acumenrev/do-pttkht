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
    class QCBaoBLL
    {
        #region Fields

        DAL.DataService dal;
        private SqlDataAdapter m_da;
        private SqlCommand m_cmd;
        private DataTable m_dt;
        private SqlConnection m_conn;

        #endregion

        #region Constructor

        public QCBaoBLL()
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
        public void Insert(string maQCBao, string maPDK, string maBao, DateTime ngayBatDauPhatHanh, decimal giaTien)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("QCBao_Insert", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaQCBao", SqlDbType.Char).Value = maQCBao;
                m_cmd.Parameters.Add("@MaPhieuDangKy", SqlDbType.Char).Value = maPDK;
                m_cmd.Parameters.Add("@MaBao", SqlDbType.Char).Value = maBao;
                m_cmd.Parameters.Add("@NgayBatDauPhatHanh", SqlDbType.DateTime).Value = ngayBatDauPhatHanh;
                m_cmd.Parameters.Add("@GiaTien", SqlDbType.Decimal).Value = giaTien;
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
        public void Update(string maQCBao, string maPDK, string maBao, DateTime ngayBatDauPhatHanh, decimal giaTien)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("QCBao_Update", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaQCBao", SqlDbType.Char).Value = maQCBao;
                m_cmd.Parameters.Add("@MaPhieuDangKy", SqlDbType.Char).Value = maPDK;
                m_cmd.Parameters.Add("@MaBao", SqlDbType.Char).Value = maBao;
                m_cmd.Parameters.Add("@NgayBatDauPhatHanh", SqlDbType.DateTime).Value = ngayBatDauPhatHanh;
                m_cmd.Parameters.Add("@GiaTien", SqlDbType.Decimal).Value = giaTien;
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
        public void Delete(string maQCBao, string maPhieuDangKy, string maBao)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("QCBao_Delete", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaQCBao", SqlDbType.Char).Value = maQCBao;
                m_cmd.Parameters.Add("@MaPhieuDangKy", SqlDbType.Char).Value = maPhieuDangKy;
                m_cmd.Parameters.Add("@MaBao", SqlDbType.Char).Value = maBao;
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
            m_da = dal.CreateAdapter("QCBao_Select", m_conn);
            m_da.Fill(m_dt);
            return m_dt;
        }

        /// <summary>
        /// Tìm mã báo
        /// </summary>
        /// <param name="maBao"></param>
        /// <returns></returns>
        public DataTable SearchMaBao(string maBao)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("QCBao_SearchMaBao", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.Char).Value = maBao;
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
            m_cmd = new SqlCommand("QCBao_SearchMaPDK", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            //Tham số
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.Char).Value = maPDK ;
            /// Thuc thi cau truy van
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        
        public DataTable SearchMaQC(string maQC)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("QCBao_SearchMAQC", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            //Tham số
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.Char).Value = maQC;
            /// Thuc thi cau truy van
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }
        #endregion
    }
}
