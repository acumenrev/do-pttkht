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
    class DiaOcBLL
    {
        #region Fields

        DAL.DataService dal;
        private SqlDataAdapter m_da;
        private SqlCommand m_cmd;
        private DataTable m_dt;
        private SqlConnection m_conn;

        #endregion

        #region Constructor

        public DiaOcBLL()
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
        public void Insert(string maDiaOc, string soNha, string duong, string phuong, string quanHuyen, string maNguoiBan, string huongNha, string moTaChiTiet, int namXayNha, string viTri, int soTang, string loaiNha, string loaiNen, float datDai, float datRong, float nhaDai, float nhaRong, string daBan, decimal giaBan)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("DO_Insert", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaDiaOcCB", SqlDbType.Char).Value = maDiaOc;
                m_cmd.Parameters.Add("@SoNha", SqlDbType.NVarChar).Value = soNha;
                m_cmd.Parameters.Add("@Duong", SqlDbType.NVarChar).Value = duong;
                m_cmd.Parameters.Add("@Phuong", SqlDbType.NVarChar).Value = phuong;
                m_cmd.Parameters.Add("@Quan_Huyen", SqlDbType.NVarChar).Value = quanHuyen;
                m_cmd.Parameters.Add("@MaNguoiBan", SqlDbType.Char).Value = maNguoiBan;
                m_cmd.Parameters.Add("@HuongNhaDat", SqlDbType.NVarChar).Value = huongNha;
                m_cmd.Parameters.Add(@"MoTaChiTiet", SqlDbType.NVarChar).Value = moTaChiTiet;
                m_cmd.Parameters.Add("@NhaXayNam", SqlDbType.Int).Value = namXayNha;
                m_cmd.Parameters.Add("@ViTri", SqlDbType.NVarChar).Value = viTri;
                m_cmd.Parameters.Add("@SoTang", SqlDbType.Int).Value = soTang;
                m_cmd.Parameters.Add("@LoaiNha", SqlDbType.NVarChar).Value = loaiNha;
                m_cmd.Parameters.Add("@LoaiNen", SqlDbType.NVarChar).Value = loaiNen;
                m_cmd.Parameters.Add("@DatDai", SqlDbType.Float).Value = datDai;
                m_cmd.Parameters.Add("@DatRong", SqlDbType.Float).Value = datRong;
                m_cmd.Parameters.Add("@NhaDai", SqlDbType.Float).Value = nhaDai;
                m_cmd.Parameters.Add("@NhaRong", SqlDbType.Float).Value = nhaRong;
                m_cmd.Parameters.Add("@DaBan", SqlDbType.NVarChar).Value = daBan;
                m_cmd.Parameters.Add("@GiaBan", SqlDbType.Decimal).Value = giaBan;
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
        public void Update(string maDiaOc, string soNha, string duong, string phuong, string quanHuyen, string maNguoiBan, string huongNha, string moTaChiTiet, int namXayNha, string viTri, int soTang, string loaiNha, string loaiNen, float datDai, float datRong, float nhaDai, float nhaRong, string daBan, decimal giaBan)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("DO_Update", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaDiaOcCB", SqlDbType.Char).Value = maDiaOc;
                m_cmd.Parameters.Add("@SoNha", SqlDbType.NVarChar).Value = soNha;
                m_cmd.Parameters.Add("@Duong", SqlDbType.NVarChar).Value = duong;
                m_cmd.Parameters.Add("@Phuong", SqlDbType.NVarChar).Value = phuong;
                m_cmd.Parameters.Add("@Quan_Huyen", SqlDbType.NVarChar).Value = quanHuyen;
                m_cmd.Parameters.Add("@MaNguoiBan", SqlDbType.Char).Value = maNguoiBan;
                m_cmd.Parameters.Add("@HuongNhaDat", SqlDbType.NVarChar).Value = huongNha;
                m_cmd.Parameters.Add(@"MoTaChiTiet", SqlDbType.NVarChar).Value = moTaChiTiet;
                m_cmd.Parameters.Add("@NhaXayNam", SqlDbType.Int).Value = namXayNha;
                m_cmd.Parameters.Add("@ViTri", SqlDbType.NVarChar).Value = viTri;
                m_cmd.Parameters.Add("@SoTang", SqlDbType.Int).Value = soTang;
                m_cmd.Parameters.Add("@LoaiNha", SqlDbType.NVarChar).Value = loaiNha;
                m_cmd.Parameters.Add("@LoaiNen", SqlDbType.NVarChar).Value = loaiNen;
                m_cmd.Parameters.Add("@DatDai", SqlDbType.Float).Value = datDai;
                m_cmd.Parameters.Add("@DatRong", SqlDbType.Float).Value = datRong;
                m_cmd.Parameters.Add("@NhaDai", SqlDbType.Float).Value = nhaDai;
                m_cmd.Parameters.Add("@NhaRong", SqlDbType.Float).Value = nhaRong;
                m_cmd.Parameters.Add("@DaBan", SqlDbType.NVarChar).Value = daBan;
                m_cmd.Parameters.Add("@GiaBan", SqlDbType.Decimal).Value = giaBan;
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
        public void Delete(string maDiaOc)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("DO_Delete", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaDiaOcCB", SqlDbType.Char).Value = maDiaOc;
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
            m_da = dal.CreateAdapter("DO_Select", m_conn);
            m_da.Fill(m_dt);
            return m_dt;
        }

        /// <summary>
        /// Tìm tên đường
        /// </summary>
        /// <param name="duong"></param>
        /// <returns></returns>
        public DataTable SearchDuong(string duong)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("DO_SearchDuong", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            // Tham so
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.NVarChar).Value = duong;
            // Thuc thi cau truy van
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm hướng nhà
        /// </summary>
        /// <param name="huongNha"></param>
        /// <returns></returns>
        public DataTable SearchHuongNha(string huongNha)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("DO_SearchHuongNha", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            //Tham số
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.NVarChar).Value = huongNha;
            /// Thuc thi cau truy van
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm loại nền
        /// </summary>
        /// <param name="loaiNen"></param>
        /// <returns></returns>
        public DataTable SearchLoaiNen(string loaiNen)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("DO_SearchLoaiNen", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            //Tham số
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.NVarChar).Value = loaiNen;
            /// Thuc thi cau truy van
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm loai nhà
        /// </summary>
        /// <param name="loaiNha"></param>
        /// <returns></returns>
        public DataTable SearchLoaiNha(string loaiNha)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("DO_SearchLoaiNha", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            //Tham số
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.NVarChar).Value = loaiNha;
            /// Thuc thi cau truy van
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
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

        /// <summary>
        /// Tìm mã người bán
        /// </summary>
        /// <param name="maNB"></param>
        /// <returns></returns>
        public DataTable SearchMaNB(string maNB)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("DO_SearchMaDO", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            //Tham số
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.Char).Value = maNB;
            /// Thuc thi cau truy van
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm mô tả chi tiết
        /// </summary>
        /// <param name="moTaChiTiet"></param>
        /// <returns></returns>
        public DataTable SearchMoTaChiTiet(string moTaChiTiet)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("DO_SearchMotaChiTiet", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            //Tham số
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.NVarChar).Value = moTaChiTiet;
            /// Thuc thi cau truy van
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm phường
        /// </summary>
        /// <param name="phuong"></param>
        /// <returns></returns>
        public DataTable SearchPhuong(string phuong)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("DO_SearchPhuong", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            //Tham số
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.NVarChar).Value = phuong;
            /// Thuc thi cau truy van
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm quận
        /// </summary>
        /// <param name="quan"></param>
        /// <returns></returns>
        public DataTable SearchQuan(string quan)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("DO_SearchQuan", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            //Tham số
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.NVarChar).Value = quan;
            /// Thuc thi cau truy van
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm số nhà
        /// </summary>
        /// <param name="soNha"></param>
        /// <returns></returns>
        public DataTable SearchSoNha(string soNha)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("DO_SearchSoNha", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            //Tham số
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.NVarChar).Value = soNha;
            /// Thuc thi cau truy van
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm số tầng
        /// </summary>
        /// <param name="soTang"></param>
        /// <returns></returns>
        public DataTable SearchSoTang(int soTang)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("DO_SearchSoNha", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            //Tham số
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.Int).Value = soTang;
            /// Thuc thi cau truy van
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm vị trí
        /// </summary>
        /// <param name="viTri"></param>
        /// <returns></returns>
        public DataTable SearchViTri(string viTri)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("DO_SearchViTri", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            //Tham số
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.NVarChar).Value = viTri;
            /// Thuc thi cau truy van
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        public DataTable SearchXayNam(int xayNam)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("DO_SearchXayNam", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            //Tham số
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.Int).Value = xayNam;
            /// Thuc thi cau truy van
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        #endregion
    }
}
