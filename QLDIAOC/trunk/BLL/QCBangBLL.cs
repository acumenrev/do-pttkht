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
    public class QCBangBLL
    {
        #region Fields

        DAL.DataService dal;
        private SqlDataAdapter m_da;
        private SqlCommand m_cmd;
        private DataTable m_dt;
        private SqlConnection m_conn;

        #endregion

        #region Constructor

        public QCBangBLL()
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
        public void Insert(string maQCBang, string maPDK, string loaiBang, string moTa, string kichThuoc, int soLuongBang, decimal giaTien)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("QCBang_Insert", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaQCBang", SqlDbType.Char).Value = maQCBang;
                m_cmd.Parameters.Add("@MaPhieuDangKy", SqlDbType.Char).Value = maPDK;
                m_cmd.Parameters.Add("@LoaiBang", SqlDbType.NVarChar).Value = loaiBang;
                m_cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = moTa;
                m_cmd.Parameters.Add("@KichThuoc", SqlDbType.NVarChar).Value = kichThuoc;
                m_cmd.Parameters.Add("@SoLuongBang", SqlDbType.Int).Value = soLuongBang;
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
        public void Update(string maQCBang, string maPDK, string loaiBang, string moTa, string kichThuoc, int soLuongBang, decimal giaTien)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("QCBang_Update", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaQCBang", SqlDbType.Char).Value = maQCBang;
                m_cmd.Parameters.Add("@MaPhieuDangKy", SqlDbType.Char).Value = maPDK;
                m_cmd.Parameters.Add("@LoaiBang", SqlDbType.NVarChar).Value = loaiBang;
                m_cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = moTa;
                m_cmd.Parameters.Add("@KichThuoc", SqlDbType.NVarChar).Value = kichThuoc;
                m_cmd.Parameters.Add("@SoLuongBang", SqlDbType.Int).Value = soLuongBang;
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
        public void Delete(string maQCBang, string maPDK)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("QCBang_Delete", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaQCBang", SqlDbType.Char).Value = maQCBang;
                m_cmd.Parameters.Add("@MaPhieuDangKy", SqlDbType.Char).Value = maPDK;
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
            m_da = dal.CreateAdapter("QCBang_Select", m_conn);
            m_da.Fill(m_dt);
            return m_dt;
        }

        public DataTable SelectMaPDK(DateTime tu, DateTime den)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("QCBang_SelectMaPDK", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@Tu", SqlDbType.DateTime).Value = tu;
            m_cmd.Parameters.Add("@Den", SqlDbType.DateTime).Value = den;
            
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        public DataTable SelectQC(string maPDK)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("QCBang_SelectMaPDK", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@MaPDK", SqlDbType.Char).Value = maPDK;

            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }


        public DataTable SelectGiaTien(DateTime tu, DateTime den)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("QCBang_SelectGiaTien", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@Tu", SqlDbType.DateTime).Value = tu;
            m_cmd.Parameters.Add("@Den", SqlDbType.DateTime).Value = den;

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
            m_cmd = new SqlCommand("QCBang_SearchMaPDK", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.Char).Value = maPDK;
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm mã quảng cáo
        /// </summary>
        /// <param name="maQC"></param>
        /// <returns></returns>
        public DataTable SearchMaQC(string maQC)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("QCBang_SearchMaQC", m_conn);
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
