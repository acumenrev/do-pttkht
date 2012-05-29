using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;
using System.Xml;

namespace QLDIAOC.FormHeThong
{
    public partial class frmThongTinNguoiSuDung : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields

        // Biến hệ thống chỉ về sự kiến double click thanh title bar
        private const int WM_NCLBUTTONDBLCLK = 0xA3;
        private XmlTextReader m_reader;
        private XmlTextWriter m_writer;
        string m_myDocumentsPath;
        string m_tempPath;
        string m_filePath;

        #endregion

        #region Constructor

        public frmThongTinNguoiSuDung()
        {
            InitializeComponent();
            m_myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            m_tempPath = Path.Combine(m_myDocumentsPath, "QuanLyDiaOc");
            m_filePath = m_tempPath + "\\CustomerInfo.xml";
            ReadFile(m_filePath);
        }

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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFile(m_filePath);
                MessageBox.Show("Quá trình ghi file thành công", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Quá trình ghi file không thành công", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WriteFile(string filePath)
        {

            m_writer = new XmlTextWriter(filePath, Encoding.Unicode);
            // xác định khoảng cách thụt dòng giữa nút cha và nút con
            m_writer.Formatting = Formatting.Indented;
            m_writer.Indentation = 6;
            // Bắt đầu thao tác ghi file XML
            m_writer.WriteStartDocument();

            m_writer.WriteStartElement("", "Info", "");

            m_writer.WriteStartElement("", "GaraName", "");
            m_writer.WriteString(txtTenGara.Text);
            m_writer.WriteEndElement();

            m_writer.WriteStartElement("", "Address", "");
            m_writer.WriteString(txtDiaChi.Text);
            m_writer.WriteEndElement();

            m_writer.WriteStartElement("", "Number", "");
            m_writer.WriteString(txtSDT.Text);
            m_writer.WriteEndElement();

            m_writer.WriteStartElement("", "Email", "");
            m_writer.WriteString(txtEmail.Text);
            m_writer.WriteEndElement();

            m_writer.WriteStartElement("", "Website", "");
            m_writer.WriteString(txtWebsite.Text);
            m_writer.WriteEndElement();

            m_writer.WriteEndElement();

            m_writer.WriteEndDocument();
            //Xóa dữ liệu tạm
            m_writer.Flush();
            // Đóng các kết nối đang được thực thi
            m_writer.Close();
        }

        private void ReadFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                m_reader = new XmlTextReader(filePath);
                while (m_reader.Read())
                {
                    if (m_reader.NodeType == XmlNodeType.Element)
                    {
                        if (m_reader.LocalName.Equals("GaraName"))
                        {
                            txtTenGara.Text = m_reader.ReadString();
                        }

                        if (m_reader.LocalName.Equals("Address"))
                        {
                            txtDiaChi.Text = m_reader.ReadString();
                        }

                        if (m_reader.LocalName.Equals("Number"))
                        {
                            txtSDT.Text = m_reader.ReadString();
                        }

                        if (m_reader.LocalName.Equals("Email"))
                        {
                            txtEmail.Text = m_reader.ReadString();
                        }

                        if (m_reader.LocalName.Equals("Website"))
                        {
                            txtWebsite.Text = m_reader.ReadString();
                        }
                    }
                }
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}