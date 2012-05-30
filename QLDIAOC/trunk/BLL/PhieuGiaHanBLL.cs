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
    public class PhieuGiaHanBLL
    {
         #region Fields

        DAL.DataService dal;
        private SqlDataAdapter m_da;
        private SqlCommand m_cmd;
        private DataTable m_dt;
        private SqlConnection m_conn;

        #endregion

        #region Constructor

        public PhieuGiaHanBLL()
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
        /// Cập nhật record
        /// </summary>
        public void Update(string maPDK, decimal tien, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("DO_Update", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaPhieuDangKy", SqlDbType.Char).Value = maPDK;
                m_cmd.Parameters.Add("@Tien", SqlDbType.Decimal).Value = tien;
                m_cmd.Parameters.Add("@NgayBatDau", SqlDbType.DateTime).Value = ngayBatDau;
                m_cmd.Parameters.Add("@NgayKetThuc", SqlDbType.DateTime).Value = ngayKetThuc;
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
            m_da = dal.CreateAdapter("PhieuGiaHan_Select", m_conn);
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
            m_cmd = new SqlCommand("DO_SearchMaDO", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            //Tham số
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.Char).Value = maDO;
            /// Thuc thi cau truy van
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }



        #endregion
    }
}
