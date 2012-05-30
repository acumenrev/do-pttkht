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
    public class NguoiBanBLL
    {
        #region Fields

        DAL.DataService dal;
        private SqlDataAdapter m_da;
        private SqlCommand m_cmd;
        private DataTable m_dt;
        private SqlConnection m_conn;

        #endregion

        #region Constructor

        public NguoiBanBLL()
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
        public void Insert(string maNguoiBan, string hoTen, string diaChi, string email, string phone)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("NguoiBan_Insert", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaNguoiBan", SqlDbType.Char).Value = maNguoiBan;
                m_cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = hoTen;
                m_cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = diaChi;
                m_cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = diaChi;
                m_cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = phone;
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
        public void Update(string maNguoiBan, string hoTen, string diaChi, string email, string phone)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("NguoiBan_Update", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaNguoiBan", SqlDbType.Char).Value = maNguoiBan;
                m_cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = hoTen;
                m_cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = diaChi;
                m_cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = diaChi;
                m_cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = phone;
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
        public void Delete(string maNguoiBan)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("NguoiBan_Delete", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaNguoiBan", SqlDbType.Char).Value = maNguoiBan;
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
            m_da = dal.CreateAdapter("NguoiBan_Select", m_conn);
            m_da.Fill(m_dt);
            return m_dt;
        }

        public DataTable SelectMaHo()
        {
            m_da = dal.CreateAdapter("NguoiBan_SelectMaHo", m_conn);
            m_da.Fill(m_dt);
            return m_dt;
        }

        /// <summary>
        /// Tìm địa chỉ
        /// </summary>
        /// <param name="diaChi">Địa chỉ</param>
        /// <returns></returns>
        public DataTable SearchDiaChi(string diaChi)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("NguoiBan_SearchDiaChi", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.NVarChar).Value = diaChi;
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm họ tên
        /// </summary>
        /// <param name="hoTen">Họ tên</param>
        /// <returns></returns>
        public DataTable SearchHoTen(string hoTen)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("NguoiBan_SearchHoTen", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            //Tham số
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.NVarChar).Value = hoTen;
            /// Thuc thi cau truy van
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm mã người bán
        /// </summary>
        /// <param name="maNguoiBan">Mã người bán</param>
        /// <returns></returns>
        public DataTable SearchMaNB(string maNguoiBan)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("NguoiBan_SearchMaNB", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            //Tham số
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.Char).Value = maNguoiBan;
            /// Thuc thi cau truy van
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm phone
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public DataTable SearchPhone(string phone)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("NguoiBan_Phone", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            //Tham số
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.NVarChar).Value = phone;
            /// Thuc thi cau truy van
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        #endregion
    }
}
