using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using DAL;

namespace BLL
{
    public class BackUpRestoreBLL
    {
        #region Fields

        DataService dal;
        private SqlDataAdapter m_da;
        private SqlCommand m_cmd;
        private DataTable m_dt;
        private SqlConnection m_conn;

        #endregion

        #region Constructor & Methods

        public BackUpRestoreBLL()
        {
            dal = new DataService();
            m_da = new SqlDataAdapter();
            m_cmd = new SqlCommand();
            m_dt = new DataTable();
            m_conn = dal.GetConnect();
        }

        /// <summary>
        /// Lưu trữ cơ sở dữ liệu
        /// </summary>
        /// <param name="tenCSDL">Tên cơ sở dữ liệu</param>
        /// <param name="duongDan">Đường dẫn</param>
        public void BackupCSDL(string tenCSDL, string duongDan)
        {
            try
            {
                dal.OpenConnection(m_conn);
                m_cmd = new SqlCommand("BackupDB", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;

                m_cmd.Parameters.Add("@TenDB", SqlDbType.VarChar).Value = tenCSDL;
                m_cmd.Parameters.Add("@DuongDan", SqlDbType.VarChar).Value = duongDan;

                m_cmd.ExecuteNonQuery();
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

        /// <summary>
        /// Phục hồi cơ sở dữ liệu
        /// </summary>
        /// <param name="tenCSDL">Tên cơ sở dữ liệu</param>
        /// <param name="duongDan">Đường dẫn đến tập tin .bak</param>
        public void RestoreCSDL(string tenCSDL, string duongDan)
        {
            try
            {
                dal.OpenConnection(m_conn);
                m_cmd = new SqlCommand("RestoreDB", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;

                m_cmd.Parameters.Add("@TenDB", SqlDbType.VarChar).Value = tenCSDL;
                m_cmd.Parameters.Add("@DuongDan", SqlDbType.VarChar).Value = duongDan;

                m_cmd.ExecuteNonQuery();
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
    }
}
