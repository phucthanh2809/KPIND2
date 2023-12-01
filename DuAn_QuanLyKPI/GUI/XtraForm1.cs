using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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



namespace DuAn_QuanLyKPI.GUI
{
    
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        private string mconnectstring = "server=192.168.50.108,1433; database=QuanLyKPI;uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        private int _edit = 0;
        List<int> selectedItems = new List<int>();

        // Lấy danh sách các cột của grid control

        public XtraForm1()
        {
            InitializeComponent();
            //LoadData();
            LoadCbo();


        }
        private void LoadData()
        {
            msql = "SELECT * FROM [dbo].[KPI],[dbo].[NhomTieuChi] where KPI.TieuChiID = NhomTieuChi.TieuChiID";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "KPI");
            dtgv_CapKPI.AutoGenerateColumns = false;
            dtgv_CapKPI.DataSource = tb;
        }
        //Loa mã khoa phòng và lấy chức danh theo khoa phòng
        private void LoadCbo()
        {           
            DataTable dataTableKhoaPhong = new DataTable();
            using (SqlConnection connection = new SqlConnection(mconnectstring))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT MaPK, TenPK FROM PhongKhoa", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTableKhoaPhong.Load(reader);
                    }
                }
            }

            // Sắp xếp dữ liệu của DataTable
            dataTableKhoaPhong.DefaultView.Sort = "MaPK";
            dataTableKhoaPhong = dataTableKhoaPhong.DefaultView.ToTable();

            // Lấy dữ liệu chức danh
            DataTable dataTableChucDanh = new DataTable();
            using (SqlConnection connection = new SqlConnection(mconnectstring))
            {
                connection.Open();
                using (SqlCommand command1 = new SqlCommand("SELECT MaChucDanh, TenChucdanh, MaPK FROM ChucDanh", connection))
                {
                    using (SqlDataReader reader = command1.ExecuteReader())
                    {
                        dataTableChucDanh.Load(reader);
                    }
                }
            }

            // Sắp xếp dữ liệu của DataTable
            dataTableChucDanh.DefaultView.Sort = "MaPK";
            dataTableChucDanh = dataTableChucDanh.DefaultView.ToTable();

            // Thêm cột MaPhongKhoa vào dataTableChucDanh
            dataTableChucDanh.Columns.Add("MaPhongKhoa", typeof(string));

            // Đọc dữ liệu từ bảng ChucDanh và gán giá trị MaPhongKhoa tương ứng
            foreach (DataRow rowChucDanh in dataTableChucDanh.Rows)
            {
                string maPhongKhoa = rowChucDanh["MaPK"].ToString();
                DataRow[] matchingRows = dataTableKhoaPhong.Select($"MaPK = '{maPhongKhoa}'");
                if (matchingRows.Length > 0)
                {
                    rowChucDanh["MaPhongKhoa"] = matchingRows[0]["MaPK"];
                }
            }

            // Gán danh sách phòng khoa cho cboKhoaPhong
            cboKhoaPhong.DataSource = dataTableKhoaPhong;
            cboKhoaPhong.ValueMember = "MaPK";
            cboKhoaPhong.DisplayMember = "TenPK";

            // Thiết lập sự kiện SelectedIndexChanged để cập nhật danh sách chức danh
            cboKhoaPhong.SelectedIndexChanged += (sender, e) =>
            {
                string maPhongKhoaSelected = cboKhoaPhong.SelectedValue?.ToString();
                DataView dv = new DataView(dataTableChucDanh);
                dv.RowFilter = $"MaPhongKhoa = '{maPhongKhoaSelected}'";
                cboChucDanh.DataSource = dv;
                cboChucDanh.ValueMember = "MaChucDanh";
                cboChucDanh.DisplayMember = "TenChucDanh";
            };

            // Gọi sự kiện để ban đầu nó có thể lấy dữ liệu cho cboChucDanh theo phòng khoa đầu tiên
            cboKhoaPhong.SelectedIndex = 0;
        }

        //Ấn nút cấp danh sách 
        private void btnCap_Click(object sender, EventArgs e)
        {

            if (selectedItems.Count > 0)
            {
                Frm_ChiTieuVuaGiao newForm = new Frm_ChiTieuVuaGiao(selectedItems);

                // Lấy giá trị từ DataRowView của ComboBox
                DataRowView selectedChucDanhRowView = (DataRowView)cboChucDanh.SelectedItem;
                string tenChucDanh = selectedChucDanhRowView["TenChucDanh"].ToString();

                DataRowView selectedKhoaPhongRowView = (DataRowView)cboKhoaPhong.SelectedItem;
                string tenKhoaPhong = selectedKhoaPhongRowView["TenPK"].ToString();

                // Truyền dữ liệu từ ComboBox sang TextBox trong Form2
                newForm.ChucDanhData = tenChucDanh;
                newForm.KhoaPhongData = tenKhoaPhong;
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một mục để cấp.");
            }

        }

       
        //Lấy danh sách mã KPI các mục cần cấp
        private void dtgv_CapKPI_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgv_CapKPI.Columns[0].Index && e.RowIndex >= 0) // Thay 0 bằng index của cột chứa checkbox
            {
                DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)dtgv_CapKPI.Rows[e.RowIndex].Cells["cChon"];
                if (Convert.ToBoolean(checkBox.Value)) // Kiểm tra trạng thái của checkbox
                {
                    int maKPI = Convert.ToInt32(dtgv_CapKPI.Rows[e.RowIndex].Cells["cMaKPI"].Value);
                    if (!selectedItems.Contains(maKPI))
                    {
                        selectedItems.Add(maKPI);
                    }
                    
                }


                else
                {
                    int maKPI = Convert.ToInt32(dtgv_CapKPI.Rows[e.RowIndex].Cells["cMaKPI"].Value);
                    if (selectedItems.Contains(maKPI))
                    {
                        selectedItems.Remove(maKPI);
                    }
                }

            }

        }
        //Load danh sách theo mã khoa phòng và chức danh.
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string maChucDanh = cboChucDanh.SelectedValue.ToString();
            string maPhongKhoa = cboKhoaPhong.SelectedValue.ToString();
            string msql = @"SELECT dbo.KPI.*, dbo.NhomTieuChi.* FROM dbo.KPI
            INNER JOIN dbo.KPITrongNganHang ON dbo.KPI.MaKPI = dbo.KPITrongNganHang.MaKPI
            INNER JOIN dbo.NganHangKPI ON dbo.KPITrongNganHang.MaNganHangKPI = dbo.NganHangKPI.MaNganHangKPI
            LEFT JOIN dbo.NhomTieuChi ON dbo.KPI.TieuChiID = dbo.NhomTieuChi.TieuChiID
            WHERE dbo.NganHangKPI.MaChucDanh = @maChucDanh
            AND dbo.NganHangKPI.MaPK = @maPK;";
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(mconnectstring))
            {
                SqlCommand command = new SqlCommand(msql, connection);
                command.Parameters.AddWithValue("@maChucDanh", maChucDanh);
                command.Parameters.AddWithValue("@maPK", maPhongKhoa);
                SqlDataAdapter adapter =new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            dtgv_CapKPI.AutoGenerateColumns = false;
            dtgv_CapKPI.DataSource = dt;
        }
    }   
}
