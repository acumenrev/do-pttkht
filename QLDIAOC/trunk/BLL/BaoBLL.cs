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
    public class BaoBLL
    {
        #region Fields

        DAL.DataService dal;
        private SqlDataAdapter m_da;
        private SqlCommand m_cmd;
        private DataTable m_dt;
        private SqlConnection m_conn;

        #endregion

        #region Constructor

        public BaoBLL()
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
        /// <param name="hieuXe">Hiệu xe</param>
        /// <param name="ghiChu">Ghi chú</param>
        public void Insert(string maBao, string tenBao, string ngayPhatHanh, decimal giaCoHinh, decimal giaKhongHinh)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("Bao_Insert", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaBao", SqlDbType.Char).Value = maBao;
                m_cmd.Parameters.Add("@TenBao", SqlDbType.NVarChar).Value = tenBao;
                m_cmd.Parameters.Add("@NgayPhatHanh", SqlDbType.NVarChar).Value = ngayPhatHanh;
                m_cmd.Parameters.Add("@GiaCoHinh", SqlDbType.Decimal).Value = giaCoHinh;
                m_cmd.Parameters.Add("@GiaKhongHinh", SqlDbType.Decimal).Value = giaKhongHinh;
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
        /// <param name="hieuXe">Hiệu xe</param>
        /// <param name="ghiChu">Ghi chú</param>
        public void Update(string maBao, string tenBao, string ngayPhatHanh, decimal giaCoHinh, decimal giaKhongHinh)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("Bao_Update", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaBao", SqlDbType.Char).Value = maBao;
                m_cmd.Parameters.Add("@TenBao", SqlDbType.NVarChar).Value = tenBao;
                m_cmd.Parameters.Add("@NgayPhatHanh", SqlDbType.NVarChar).Value = ngayPhatHanh;
                m_cmd.Parameters.Add("@GiaCoHinh", SqlDbType.Decimal).Value = giaCoHinh;
                m_cmd.Parameters.Add("@GiaKhongHinh", SqlDbType.Decimal).Value = giaKhongHinh;
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
        /// <param name="hieuXe">Hiệu xe</param>
        public void Delete(string maBao)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("Bao_Delete", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
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
            m_da = dal.CreateAdapter("Bao_Select", m_conn);
            m_da.Fill(m_dt);
            return m_dt;
        }

        /// <summary>
        /// Tìm tên báo
        /// </summary>
        /// <param name="tenBao">Tên báo</param>
        /// <returns></returns>
        public DataTable SearchTenBao(string tenBao)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("Bao_SearchTenBao", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.NVarChar).Value = tenBao;
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm ngày phát hành
        /// </summary>
        /// <param name="ngayPhatHanh">Ngày phát hành</param>
        /// <returns></returns>
        public DataTable SearchNgayPhatHanh(string ngayPhatHanh)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("Bao_SearchNgayPhatHanh", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.NVarChar).Value = ngayPhatHanh;
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm giá có hình
        /// </summary>
        /// <param name="tu">Giá trị nhỏ nhất</param>
        /// <param name="den"><Giá trị lớn nhất/param>
        /// <returns></returns>
        public DataTable SearchGiaCoHinh(decimal tu, decimal den)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("Bao_SearchGiaCoHinh", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            // Tham số
            m_cmd.Parameters.Add("@Tu", SqlDbType.Decimal).Value = tu;
            m_cmd.Parameters.Add("@Den", SqlDbType.Decimal).Value = den;
            /// Thuc thi cau truy van
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm giá không hình
        /// </summary>
        /// <param name="tu">Giá trị nhỏ nhất</param>
        /// <param name="den">Giá trị lớn nhất</param>
        /// <returns></returns>
        public DataTable SearchGiaKhongHinh(decimal tu, decimal den)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("Bao_SearchGiaKhongHinh", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            // Tham số
            m_cmd.Parameters.Add("@Tu", SqlDbType.Decimal).Value = tu;
            m_cmd.Parameters.Add("@Den", SqlDbType.Decimal).Value = den;
            /// Thuc thi cau truy van
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }
        #endregion
    }
}
