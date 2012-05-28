using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Xml;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace DAL
{
    public class DataService
    {
        #region Fields

        private string m_connectString;
        private string m_server;
        private string m_database;
        private string m_username;
        private string m_password;

        #endregion

        #region Constructor

        public DataService()
        {
            ReadFile();
            m_connectString = GetConnectString();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Lay duong dan den server
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetConnect()
        {
            return new SqlConnection(m_connectString);
        }
        /// <summary>
        /// Lay chuoi ket noi den server
        /// </summary>
        /// <returns></returns>
        public string GetConnectString()
        {
            string str = "";
            if (m_username.Trim() == "" && m_password.Trim() == "")
            {
                str = "Data Source=" + m_server + ";Initial Catalog=" + m_database + ";Integrated Security=true;";
            }
            else
            {
                if (m_username.Trim() != "" && m_password.Trim() != "")
                {
                    str = "Data Source=" + m_server + ";Initial Catalog=" + m_database + ";User Id=" + m_username + ";Password=" + m_password + ";";
                }
            }
            return str;
        }

        /// <summary>
        /// Kiem tra ket noi
        /// </summary>
        /// <param name="connectString"></param>
        /// <returns></returns>
        public bool TestConnection(string connectString)
        {
            try
            {
                SqlConnection connect = new SqlConnection(connectString);
                connect.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Lay thong tin thiet lap server
        /// </summary>
        private void ReadFile()
        {
            // lay duong dan thu muc MyDocument
            string myDocumentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string tempPath = Path.Combine(myDocumentPath, "QuanLyDiaOc");
            // lay duong dan file QLDOConfig.xml trong thu muc
            //  MyDocuments\QuanLyDiaOc
            string pathWithFile = tempPath + "\\QLDOConfig.xml";
            XmlTextReader reader = new XmlTextReader(pathWithFile);
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.LocalName.Equals("Server"))
                    {
                        m_server = reader.ReadString();
                    }

                    if (reader.LocalName.Equals("Database"))
                    {
                        m_database = reader.ReadString();
                    }

                    if (reader.LocalName.Equals("Username"))
                    {
                        m_username = reader.ReadString();
                    }

                    if (reader.LocalName.Equals("Password"))
                    {
                        m_password = reader.ReadString();
                    }
                }
            }
            reader.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lenhSP"></param>
        /// <returns></returns>
        public SqlDataAdapter CreateAdapter(string lenhSP, SqlConnection conn)
        {
            SqlDataAdapter da = new SqlDataAdapter(lenhSP, conn);
            return da;
        }

        /// <summary>
        /// Mở kết nối
        /// </summary>
        /// <param name="conn"></param>
        public void OpenConnection(SqlConnection conn)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        /// <summary>
        ///  Đóng kết nối
        /// </summary>
        /// <param name="conn"></param>
        public void CloseConnection(SqlConnection conn)
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }
        #endregion
    }
}
