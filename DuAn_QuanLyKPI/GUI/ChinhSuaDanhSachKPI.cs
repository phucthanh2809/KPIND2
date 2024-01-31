using BusinessCommon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn_QuanLyKPI.GUI
{
    public partial class ChinhSuaDanhSachKPI : DevExpress.XtraEditors.XtraForm
    {
        private DataTable _dataTable;
        private static string mconnectstring = Frm_Chinh_GUI.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public int NamPhieu { get; set; }
        public ChinhSuaDanhSachKPI()
        {
            InitializeComponent();
        }
        private void DisplayData()
        {

            // Hiển thị dữ liệu trên DataGridView
            dgrBVMucTieuTaiChinh.DataSource = _dataTable;
        }
        public ChinhSuaDanhSachKPI(int namPhieu)
        {
            InitializeComponent();
            DisplayData();
            NamPhieu = namPhieu;

            if (NamPhieu != 0)
            {
                // Directly assign the integer value to the TextBox
                txt_YearTC.Text = NamPhieu.ToString();
              
            }
            
        }

        private void txt_YearTC_TextChanged(object sender, EventArgs e)
        {
            int namPhieu;

            if (int.TryParse(txt_YearTC.Text, out namPhieu))
            {
                using (SqlConnection connection = new SqlConnection(mconnectstring))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("dbo.KiemTraNamPhieuTrangThai", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@NamPhieu", SqlDbType.Int).Value = namPhieu;
                        SqlParameter ketQuaParam = new SqlParameter("@KetQua", SqlDbType.Int);
                        ketQuaParam.Direction = ParameterDirection.ReturnValue; // Thay đổi từ Output thành ReturnValue
                        cmd.Parameters.Add(ketQuaParam);
                        cmd.ExecuteNonQuery();
                        int ketQua = (int)cmd.Parameters["@KetQua"].Value;
                        if (ketQua == 3)
                        {
                            SqlCommand getMaPhieuCmd = new SqlCommand("SELECT dbo.GetMaPhieuByNamPhieu(@NamPhieu)", connection);
                            getMaPhieuCmd.Parameters.AddWithValue("@NamPhieu", namPhieu);
                            txt_Nam.Text = namPhieu.ToString();

                            string maPhieu = getMaPhieuCmd.ExecuteScalar()?.ToString();

                            if (!string.IsNullOrEmpty(maPhieu))
                            {
                                SqlDataAdapter adapter = new SqlDataAdapter(
                                     $"SELECT ChiTiet.*, NhomTieuChi.TenTieuChi " +
                                     $"FROM dbo.ChiTietTieuChiMucTieuBV ChiTiet " +
                                     $"INNER JOIN dbo.NhomTieuChi ON ChiTiet.TieuChiID = NhomTieuChi.TieuChiID " +
                                     $"WHERE ChiTiet.MaPhieuKPIBV = '{maPhieu}' AND ChiTiet.TieuChiID = 'F'", connection);
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);
                                dgrNhapMucTieuTaiChinh.DataSource = dataTable;
                                dgrHTMucTieuTaiChinh.DataSource = dataTable;
                                // txt_MaPhieu.Text = maPhieu.ToString();                             
                                dgrNhapMucTieuTaiChinh .Columns["cXoaTatCaNTC"].Visible = false;
                                SqlDataAdapter adapter1 = new SqlDataAdapter(
                                    $"SELECT ChiTiet.*, NhomTieuChi.TenTieuChi " +
                                    $"FROM dbo.ChiTietTieuChiMucTieuBV ChiTiet " +
                                    $"INNER JOIN dbo.NhomTieuChi ON ChiTiet.TieuChiID = NhomTieuChi.TieuChiID " +
                                    $"WHERE ChiTiet.MaPhieuKPIBV = '{maPhieu}' AND ChiTiet.TieuChiID = 'C'", connection);
                                DataTable dataTable1 = new DataTable();
                                adapter1.Fill(dataTable1);
                                dgrNhapMucTieuKhachHang.DataSource = dataTable1;
                                dgrHTMucTieuKhachHang.DataSource = dataTable1;
                                // txt_MaPhieu.Text = maPhieu.ToString();                             
                                //dgrNhapMucTieuTaiChinh.Columns["cXoaTatCaNKH"].Visible = false;

                                SqlDataAdapter adapter2 = new SqlDataAdapter(
                                $"SELECT ChiTiet.*, NhomTieuChi.TenTieuChi " +
                                $"FROM dbo.ChiTietTieuChiMucTieuBV ChiTiet " +
                                $"INNER JOIN dbo.NhomTieuChi ON ChiTiet.TieuChiID = NhomTieuChi.TieuChiID " +
                                $"WHERE ChiTiet.MaPhieuKPIBV = '{maPhieu}' AND ChiTiet.TieuChiID = 'B'", connection);
                                DataTable dataTable2 = new DataTable();
                                adapter2.Fill(dataTable2);
                                dgrHTMucTieuVanHanh.DataSource = dataTable2;
                                dgrHTMucTieuVanHanh.DataSource = dataTable2;
                                // txt_MaPhieu.Text = maPhieu.ToString();                             
                                //dgrNhapMucTieuTaiChinh.Columns["cXoaTatCaNVH"].Visible = false;
                                SqlDataAdapter adapter3 = new SqlDataAdapter(
                                    $"SELECT ChiTiet.*, NhomTieuChi.TenTieuChi " +
                                    $"FROM dbo.ChiTietTieuChiMucTieuBV ChiTiet " +
                                    $"INNER JOIN dbo.NhomTieuChi ON ChiTiet.TieuChiID = NhomTieuChi.TieuChiID " +
                                    $"WHERE ChiTiet.MaPhieuKPIBV = '{maPhieu}' AND ChiTiet.TieuChiID = 'L'", connection);
                                DataTable dataTable3 = new DataTable();
                                adapter3.Fill(dataTable3);
                                dgrNhapMucTieuPhatTrien.DataSource = dataTable3;
                                dgrHTMucTieuPhatTrien.DataSource = dataTable3;
                                // txt_MaPhieu.Text = maPhieu.ToString();                             
                                //dgrNhapMucTieuTaiChinh.Columns["cXoaTatCaNPT"].Visible = false;
                            }
                            else
                            {
                                ev.QFrmThongBao("Lỗi khi lấy mã phiếu.");
                            }
                        }

                    }
                }
            }
        }
    }
}