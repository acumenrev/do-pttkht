using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.Sql;
using System.Xml;
using DAL;
using BLL;
using DevComponents.DotNetBar;


namespace QLDIAOC
{
    public partial class frmServer : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields

        private const int WM_NCLBUTTONDBLCLK = 0xA3;
        XmlTextWriter m_writer;
        public static string m_myDocumentsPath;
        public static string m_path;
        public static string m_pathWithFile;
        private XmlTextReader m_reader;
        DataService dal;
        SqlConnection m_conn;
        SqlCommand m_cmd;
        private string m_connString;

        #endregion

        #region Methods

        // Ngan khong cho phong to cua so khi bam doi chuot vao title bar
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCLBUTTONDBLCLK:
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                    return;
            }

            base.WndProc(ref m);
        }

        public frmServer()
        {
            InitializeComponent();
            // lay duong dan cua thu muc My documents
            m_myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            m_path = Path.Combine(m_myDocumentsPath, "QuanLyDiaOc");
            m_pathWithFile = m_path + "\\QLDOConfig.xml";
            ReadFile(m_pathWithFile);
            m_cmd = new SqlCommand();
        }

        private void cbbServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Quyền Windows
            if (cbbQuyen.SelectedIndex == 0)
            {
                cbbCSDL.Items.Clear();
                SqlConnection con = new SqlConnection("Data Source=" + cbbServer.Text + ";Initial Catalog=" + cbbCSDL.Text + ";Integrated Security=true;");
                //Cau lenh SP_DATABASES cho phep liet ke het cac database co tren server
                SqlCommand cmd = new SqlCommand("SP_DATABASES", con);
                SqlDataReader reader;
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cbbCSDL.Items.Add(reader[0].ToString());

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                    con.Dispose();
                    cmd.Dispose();
                }
            }

            if (cbbServer.SelectedIndex == 1)
            {
                try
                {
                    cbbCSDL.Items.Clear();
                    SqlConnection con = new SqlConnection("Data Source=" + cbbServer.Text + ";Initial Catalog=" + cbbCSDL.Text + ";User Id=" + txtTenTaiKhoan.Text + ";Password=" + txtMatKhau.Text + ";");
                    SqlCommand cmd = new SqlCommand("SP_DATABASES", con);
                    SqlDataReader reader;
                    try
                    {
                        con.Open();
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            cbbCSDL.Items.Add(reader[0].ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                        con.Dispose();
                        cmd.Dispose();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbbQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbQuyen.SelectedIndex == 0)
            {
                txtMatKhau.Enabled = false;
                txtTenTaiKhoan.Enabled = false;
            }
            else
            {
                txtMatKhau.Enabled = true;
                txtTenTaiKhoan.Enabled = true;
            }
        }

        private void cbbCSDL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPhucHoiCSDL_Click(object sender, EventArgs e)
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
                    m_conn = new SqlConnection(GetConnectString());
                    if (DialogResult.Yes == msgBox)
                    {
                        // thiết lập thông số cho SqlCommand
                        if (m_conn.State != ConnectionState.Open)
                        {
                            m_conn.Open();
                        }
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
                if (m_conn.State != ConnectionState.Closed)
                {
                    m_conn.Close();
                }
            }
        }

        private void btnKiemTraKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbQuyen.SelectedIndex == 0)
                {
                    SqlConnection con = new SqlConnection("Data Source=" + cbbServer.Text + ";Initial Catalog=" + cbbCSDL.Text + ";Integrated Security=true");
                    try
                    {
                        con.Open();
                        MessageBox.Show("Kết nối thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();

                        }
                        con.Dispose();
                    }
                }
                if (cbbQuyen.SelectedIndex == 1)
                {
                    SqlConnection con = new SqlConnection("Data Source=" + cbbServer.Text + ";Initial Catalog=" + cbbCSDL.Text + ";User id=" + txtTenTaiKhoan.Text + ";Password=" + txtMatKhau.Text);
                    try
                    {
                        con.Open();

                        MessageBox.Show("Kết nối thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                        con.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            string strThongDiep = "Bạn có chắc chắn với những thông số bạn đã thiết lập ?";

            DialogResult msgThongDiep = MessageBox.Show(strThongDiep, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == msgThongDiep)
            {
                WriteFile();
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void frmServer_Load(object sender, EventArgs e)
        {
            cbbQuyen.SelectedIndex = 0;
            string myServer = Environment.MachineName;
            DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
            for (int i = 0; i < servers.Rows.Count; i++)
            {
                if (myServer == servers.Rows[i]["ServerName"].ToString())
                {
                    // lay ten server va instance cua server do
                    cbbServer.Items.Add(servers.Rows[i]["ServerName"] + "\\" +
                        servers.Rows[i]["InstanceName"]);
                }
                else
                {
                    // chi lay ten server1
                    cbbServer.Items.Add(servers.Rows[i]["ServerName"]);
                }
            }
        }

        private void frmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        // kiem tra thu muc da ton tai chua
        private bool IsFolderExists(string path)
        {
            try
            {
                return System.IO.Directory.Exists(path);
            }
            catch
            {
                return false;
            }
        }

        // kiem tra tap tin da ton tai chua
        private bool IsFileExist(string path)
        {
            try
            {
                return System.IO.File.Exists(path);
            }
            catch
            {
                return false;
            }
        }

        // ghi tap tin xml de luu cau hinh server
        private void WriteFile()
        {
            // neu thu muc chua ton tai thi tao thu muc voi duong dan path
            if (!IsFolderExists(m_path))
            {
                Directory.CreateDirectory(m_path);
            }

            m_writer = new XmlTextWriter(m_pathWithFile, null);
            // xac dinh khoang cach thut dong giua node cha va node con
            m_writer.Formatting = Formatting.Indented;
            m_writer.Indentation = 6;

            m_writer.WriteStartDocument();

            m_writer.WriteStartElement("", "Configuration", "");

            m_writer.WriteStartElement("", "Server", "");
            m_writer.WriteString(cbbServer.Text);
            m_writer.WriteEndElement();

            m_writer.WriteStartElement("", "Database", "");
            m_writer.WriteString(cbbCSDL.Text);
            m_writer.WriteEndElement();

            m_writer.WriteStartElement("", "Username", "");
            m_writer.WriteString(txtTenTaiKhoan.Text);
            m_writer.WriteEndElement();

            m_writer.WriteStartElement("", "Password", "");
            m_writer.WriteString(txtMatKhau.Text);
            m_writer.WriteEndElement();

            m_writer.WriteEndElement();

            m_writer.WriteEndDocument();

            m_writer.Flush();
            m_writer.Close();
        }

        private void ReadFile(string filePath)
        {
            m_reader = new XmlTextReader(filePath);
            if (File.Exists(filePath))
            {
                if (IsFileExist(filePath))
                {
                    while (m_reader.Read())
                    {
                        if (m_reader.NodeType == XmlNodeType.Element)
                        {
                            if (m_reader.LocalName.Equals("Server"))
                            {
                                cbbServer.Text = m_reader.ReadString();
                            }

                            if (m_reader.LocalName.Equals("Database"))
                            {
                                cbbCSDL.Text = m_reader.ReadString();
                            }

                            if (m_reader.LocalName.Equals("Username"))
                            {
                                txtTenTaiKhoan.Text = m_reader.ReadString();
                            }

                            if (m_reader.LocalName.Equals("Password"))
                            {
                                txtMatKhau.Text = m_reader.ReadString();
                            }
                        }
                    }
                }

                m_reader.Close();
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

        private void cbbServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbbServer_SelectedIndexChanged(sender, e);
            }
        }

        public string GetConnectString()
        {
            string str = "";
            if (txtTenTaiKhoan.Text.Trim() == "" && txtMatKhau.Text.Trim() == "")
            {
                str = "Data Source=" + cbbServer.Text + ";Initial Catalog=" +
                    cbbCSDL.Text + ";Integrated Security=true;";
            }
            else
            {
                if (txtTenTaiKhoan.Text.Trim() != "" && txtMatKhau.Text.Trim() != "")
                {
                    str = "Data Source=" + cbbServer.Text + ";Initial Catalog=" +
                         cbbCSDL.Text + ";User Id=" +
                         txtTenTaiKhoan.Text + ";Password=" + txtMatKhau.Text + ";";
                }
            }
            return str;
        }

        #endregion
    }
}