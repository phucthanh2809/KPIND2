using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessCommon;
using ControlProject1510;
using DevExpress.Charts.Native;
using DevExpress.CodeParser;
using DevExpress.Data.Linq.Helpers;
using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting.Native;
//using DevExpress.XtraVerticalGrid;
using DuAn_QuanLyKPI.Constants;
using DuAn_QuanLyKPI.DTO;
using System.Data.SqlClient;

namespace DuAn_QuanLyKPI.GUI
{
    public partial class Frm_ChiTieuVuaGiao : DevExpress.XtraEditors.XtraForm
    {
        private List<int> receivedItems;
        private string mconnectstring = "server=192.168.50.108,1433; database=QuanLyKPI;uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public string ChucDanhData
        {
            get { return txt_ChucDanh.Text; }
            set { txt_ChucDanh.Text = value; }
        }

        public string KhoaPhongData
        {
            get { return txt_KhoaPhong.Text; }
            set { txt_KhoaPhong.Text = value; }
        }
        public Frm_ChiTieuVuaGiao()
        {
            InitializeComponent();
            LoadCbo();

        }
        private void LoadCbo()
        {
            DataTable dataTableTieuChi = new DataTable();
            using (SqlConnection connection = new SqlConnection(mconnectstring))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT TieuChiID, TenTieuChi FROM NhomTieuChi", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTableTieuChi.Load(reader);
                    }
                }

            }
            dataTableTieuChi.DefaultView.Sort = "TieuChiID";
            dataTableTieuChi = dataTableTieuChi.DefaultView.ToTable();
            cbo_BieuMau.DataSource = dataTableTieuChi;
            cbo_BieuMau.ValueMember = "TieuChiID";
            cbo_BieuMau.DisplayMember = "TenTieuChi";
           

        }

        public Frm_ChiTieuVuaGiao(List<int> selectedItems)
        {
            InitializeComponent();
            receivedItems = selectedItems;
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(mconnectstring))
            {
                connection.Open();

                // Tạo một command để thực thi truy vấn
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    string query = "SELECT dbo.KPI.*, dbo.NhomTieuChi.TenTieuChi FROM dbo.KPI INNER JOIN dbo.NhomTieuChi ON dbo.KPI.TieuChiID = dbo.NhomTieuChi.TieuChiID AND MaKPI IN (" + string.Join(",", receivedItems) + ")";
                    command.CommandText = query;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            dtgv_ChiTietKPI.DataSource = dataTable;

        }
        public string CreateKpiCode(DateTime ngay)
        {
            using (SqlConnection connection = new SqlConnection(mconnectstring))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT [dbo].[TaoMaPhieuKPI1](@ngay)", connection))
                {
                    command.Parameters.AddWithValue("@ngay", ngay);
                    string result = command.ExecuteScalar().ToString();
                    return result;
                }
            }
        }
        public int GetYearFromNgayTaoPhieuKPI(DateTime ngay)
        {
            using (SqlConnection connection = new SqlConnection(mconnectstring))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT YEAR(@ngay)", connection))
                {
                    command.Parameters.AddWithValue("@ngay", ngay);
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {                     
                        return (int)result;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
        public int GetQuarterFromNgayTaoPhieuKPI(DateTime ngay)
        {
            using (SqlConnection connection = new SqlConnection(mconnectstring))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT [dbo].[GetQuarterFromNgayTaoPhieuKPI](@ngay)", connection))
                {
                    command.Parameters.AddWithValue("@ngay", ngay);
                    object result = command.ExecuteScalar();
                    return (int)result;
                }
            }
        }
       
        private void layQuy()
        {
            DateTime ngayTao = dt_NgayTaoMaPhieu.Value;
            int quy = GetQuarterFromNgayTaoPhieuKPI(ngayTao);
            txt_MaPhieu2.Text = quy.ToString();
        }


        private void btn_TaoMaPhieu_Click(object sender, EventArgs e)
        {
            DateTime ngayTao = dt_NgayTaoMaPhieu.Value; // Assume dtNgayTao is your DateTimePicker
            string maPhieuKPI = CreateKpiCode(ngayTao);
            txt_MaPhieu.Text = maPhieuKPI;
        }
        private void layNam()
        {
            DateTime ngayTao = dt_NgayTaoMaPhieu.Value;
            int nam = GetYearFromNgayTaoPhieuKPI(ngayTao);
            txt_MaPhieu1.Text = nam.ToString();
        }
        private void SaveToDatabase()
        {
            using (SqlConnection connection = new SqlConnection(mconnectstring))
            {
                connection.Open();
                if (dtgv_ChiTietKPI.SelectedCells.Count > 0)
                {
                    string maPhieu = txt_MaPhieu.Text;
                    string maKhoa = txt_MaKhoa.Text;
                    bool truongPhongKhoa = ck_TruongPhong.Checked;
                    DateTime ngayTaoMaPhieu = dt_NgayTaoMaPhieu.Value;
                    foreach (DataGridViewRow row in dtgv_ChiTietKPI.Rows)
                    {
                        if (row.Index == dtgv_ChiTietKPI.Rows.Count - 1)
                        {
                            continue;
                        }
                        // Tạo một command để thực thi truy vấn
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = connection;
                            string query = "INSERT INTO [dbo].[PhieuKPITongHop] (MaPhieuKPI, MaKPI, MaPK, TruongPK, CongViecCaNhan, TieuChiID, ChiTieuBV, TrongSoTieuChiBV, TrongSoKPIBV, NgayTaoPhieuKPI)" +
                                " VALUES (@mpkpi, @mkpi, @mkp, @truongpk,@cvcn,@tcid,@ctbv,@tstcbv,@tskpibv,@ntpkpi)";
                            command.CommandText = query;

                            int maKPI = Convert.ToInt32(row.Cells["clMaKPI"].Value);
                            bool congViecCaNhan = Convert.ToBoolean(row.Cells["clCongViecCaNhan"].Value);
                            int chiTieuBV = Convert.ToInt32(row.Cells["clChiTieuBV"].Value);
                            int trongSoTieuChiBV = Convert.ToInt32(row.Cells["clTrongSoTCBV"].Value);
                            int trongSoKPIBV = Convert.ToInt32(row.Cells["cTrongSoKPIBV"].Value);
                            string tieuChiID = row.Cells["clTieuChiID"].Value.ToString();
                            // Thay thế các tham số bằng giá trị thực từ form của bạn
                            command.Parameters.AddWithValue("@mpkpi", maPhieu);
                            command.Parameters.AddWithValue("@mkpi", maKPI);
                            command.Parameters.AddWithValue("@mkp", maKhoa);
                            command.Parameters.AddWithValue("@truongpk", truongPhongKhoa);
                            command.Parameters.AddWithValue("@cvcn", congViecCaNhan);                                                     
                            command.Parameters.AddWithValue("@ctbv", chiTieuBV);
                            command.Parameters.AddWithValue("@tstcbv", trongSoTieuChiBV);
                            command.Parameters.AddWithValue("@tskpibv", trongSoKPIBV);
                            command.Parameters.AddWithValue("@ntpkpi", ngayTaoMaPhieu);
                            command.Parameters.AddWithValue("@tcid", tieuChiID);

                            // Tiếp tục thêm các tham số khác tương ứng với cột trong bảng

                            // Thực thi truy vấn
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Bạn đã lưu thành công");


                }
                else
                {
                    MessageBox.Show("Bị lỗi");
                }
            }
        }
        private void SavetoDatabase1()
        {
            DateTime ngayTaoMaPhieu = dt_NgayTaoMaPhieu.Value;
            int trangThai = 0; // Giả sử trạng thái là 0

            string msql = "INSERT INTO [dbo].[TongHopBieuMauPhieuKPI] (MaPhieuKPI, IDBieuMau, Nam, Quy, NgayTaoPhieuKPI, TrangThai) " +
                          "VALUES (@MaPhieu, @IDBieuMau, @Nam, @Quy, @NgayTaoPhieu, @TrangThai)";

            using (SqlConnection connection = new SqlConnection(mconnectstring))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(msql, connection))
                {
                    // Sử dụng tham số để tránh injection và đảm bảo an toàn
                    command.Parameters.AddWithValue("@MaPhieu", txt_MaPhieu.Text);
                    command.Parameters.AddWithValue("@IDBieuMau", cbo_BieuMau.SelectedValue);
                    command.Parameters.AddWithValue("@Nam", txt_MaPhieu1.Text);
                    command.Parameters.AddWithValue("@Quy", txt_MaPhieu2.Text);
                    command.Parameters.AddWithValue("@NgayTaoPhieu", ngayTaoMaPhieu);
                    command.Parameters.AddWithValue("@TrangThai", trangThai);

                    // Thực hiện câu truy vấn
                    command.ExecuteNonQuery();
                }
            }
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            SavetoDatabase1();
            SaveToDatabase();
            
        }

        private void dt_NgayTaoMaPhieu_ValueChanged(object sender, EventArgs e)
        {
            layNam();
            layQuy();
        }

        private void Frm_ChiTieuVuaGiao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKPIDataSet3.DanhsachBieuMau' table. You can move, or remove it, as needed.
            //this.danhsachBieuMauTableAdapter.Fill(this.quanLyKPIDataSet3.DanhsachBieuMau);

        }
    }
    
}