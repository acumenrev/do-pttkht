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
    class ThamSoBLL
    {
        #region Fields

        DAL.DataService dal;
        private SqlDataAdapter m_da;
        private SqlCommand m_cmd;
        private DataTable m_dt;
        private SqlConnection m_conn;

        #endregion

        #region Constructor

        public ThamSoBLL()
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
        public void Update(string tenThamSo, string giaTri, string ghiChu)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("ThamSo_Update", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@TenTham", SqlDbType.NVarChar).Value = tenThamSo;
                m_cmd.Parameters.Add("@GiaTri", SqlDbType.NVarChar).Value = giaTri;
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
        /// Truy vấn các record
        /// </summary>
        /// <returns></returns>
        public DataTable Select()
        {
            // truy vấn tới bảng dữ liệu
            m_da = dal.CreateAdapter("ThamSo_Select", m_conn);
            m_da.Fill(m_dt);
            return m_dt;
        }

        #endregion
    }
}
