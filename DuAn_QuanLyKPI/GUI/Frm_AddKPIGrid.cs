using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessCommon;

namespace DuAn_QuanLyKPI.GUI
{
    public partial class Frm_AddKPIGrid : DevExpress.XtraEditors.XtraForm
    {
        //Connect
        private static string mconnectstring = Frm_Chinh_GUI.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs(string.Empty);
        private string msql;

        // Tạo biến 
        private string MaNV = Frm_Login.MaNV;

        public Frm_AddKPIGrid()
        {
            InitializeComponent();
            nmYear.Value = DateTime.Now.Year;

        }
        public void LoadNganHangKPI()
        {
            bool congvieccanhannh = chkCongViecCaNhanNganHangKPI.Checked;
            string phuongdien = FrmA73.phuongdien;
            dgrKPIBenhVien.Visible = true;
            dgrKPICaNhan.Visible = false;
            chkCongViecCaNhanCaNhan.Visible = false;
            chkCongViecCaNhanNganHangKPI.Visible = true;
            if (congvieccanhannh == true)
            {
                switch (phuongdien)
                {
                    case "tc":
                        msql = "SELECT * FROM [QuanLyKPI].[dbo].[KPI] WHERE [TieuChiID] = 'F' and [CongViecCaNhan] = 1";
                        DataTable tc = comm.GetDataTable(mconnectstring, msql, "KPINH");
                        dgrKPIBenhVien.AutoGenerateColumns = false;
                        dgrKPIBenhVien.DataSource = tc;
                        break;
                    case "kh":
                        msql = "SELECT * FROM [QuanLyKPI].[dbo].[KPI] WHERE [TieuChiID] = 'C' and [CongViecCaNhan] = 1";
                        DataTable kh = comm.GetDataTable(mconnectstring, msql, "KPINH");
                        dgrKPIBenhVien.AutoGenerateColumns = false;
                        dgrKPIBenhVien.DataSource = kh;
                        break;
                    case "vh":
                        msql = "SELECT * FROM [QuanLyKPI].[dbo].[KPI] WHERE [TieuChiID] = 'B' and [CongViecCaNhan] = 1";
                        DataTable vh = comm.GetDataTable(mconnectstring, msql, "KPINH");
                        dgrKPIBenhVien.AutoGenerateColumns = false;
                        dgrKPIBenhVien.DataSource = vh;
                        break;
                    case "pt":
                        msql = "SELECT * FROM [QuanLyKPI].[dbo].[KPI] WHERE [TieuChiID] = 'L' and [CongViecCaNhan] = 1";
                        DataTable pt = comm.GetDataTable(mconnectstring, msql, "KPINH");
                        dgrKPIBenhVien.AutoGenerateColumns = false;
                        dgrKPIBenhVien.DataSource = pt;
                        break;
                }
            }
            else if (congvieccanhannh == false)
            {
                switch (phuongdien)
                {
                    case "tc":

                        msql = "SELECT * FROM [QuanLyKPI].[dbo].[KPI] WHERE [TieuChiID] = 'F' and [CongViecCaNhan] = 0";
                        DataTable tc = comm.GetDataTable(mconnectstring, msql, "KPINH");
                        dgrKPIBenhVien.AutoGenerateColumns = false;
                        dgrKPIBenhVien.DataSource = tc;
                        break;
                    case "kh":
                        msql = "SELECT * FROM [QuanLyKPI].[dbo].[KPI] WHERE [TieuChiID] = 'C' and [CongViecCaNhan] = 0";
                        DataTable kh = comm.GetDataTable(mconnectstring, msql, "KPINH");
                        dgrKPIBenhVien.AutoGenerateColumns = false;
                        dgrKPIBenhVien.DataSource = kh;
                        break;
                    case "vh":
                        msql = "SELECT * FROM [QuanLyKPI].[dbo].[KPI] WHERE [TieuChiID] = 'B' and [CongViecCaNhan] = 0";
                        DataTable vh = comm.GetDataTable(mconnectstring, msql, "KPINH");
                        dgrKPIBenhVien.AutoGenerateColumns = false;
                        dgrKPIBenhVien.DataSource = vh;
                        break;
                    case "pt":
                        msql = "SELECT * FROM [QuanLyKPI].[dbo].[KPI] WHERE [TieuChiID] = 'L' and [CongViecCaNhan] = 0";
                        DataTable pt = comm.GetDataTable(mconnectstring, msql, "KPINH");
                        dgrKPIBenhVien.AutoGenerateColumns = false;
                        dgrKPIBenhVien.DataSource = pt;
                        break;
                }
            }
        }
        public void LoadNganHangCaNhan()
        {
            bool congvieccanhancn = chkCongViecCaNhanCaNhan.Checked;
            dgrKPIBenhVien.Visible = false;
            dgrKPICaNhan.Visible = true;
            chkCongViecCaNhanCaNhan.Visible = true;
            chkCongViecCaNhanNganHangKPI.Visible = false;
            string phuongdien = FrmA73.phuongdien;
            if (congvieccanhancn == true)
            {
                switch (phuongdien)
                {
                    case "tc":
                        msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'F' and [Nam] = " + nmYear.Value + " " +
                               "and [CongViecCaNhan] = '" + chkCongViecCaNhanNganHangKPI.Checked + "' and [CongViecCaNhan] = 1";
                        DataTable tc = comm.GetDataTable(mconnectstring, msql, "KPINH");
                        dgrKPICaNhan.AutoGenerateColumns = false;
                        dgrKPICaNhan.DataSource = tc;
                        break;
                    case "kh":
                        msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'C' and [Nam] = " + nmYear.Value + " " +
                               "and [CongViecCaNhan] = '" + chkCongViecCaNhanNganHangKPI.Checked + "' and [CongViecCaNhan] = 1";
                        DataTable kh = comm.GetDataTable(mconnectstring, msql, "KPINH");
                        dgrKPIBenhVien.AutoGenerateColumns = false;
                        dgrKPIBenhVien.DataSource = kh;
                        break;
                    case "vh":
                        msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'B' and [Nam] = " + nmYear.Value + " " +
                               "and [CongViecCaNhan] = '" + chkCongViecCaNhanNganHangKPI.Checked + "' and [CongViecCaNhan] = 1";
                        DataTable vh = comm.GetDataTable(mconnectstring, msql, "KPINH");
                        dgrKPIBenhVien.AutoGenerateColumns = false;
                        dgrKPIBenhVien.DataSource = vh;
                        break;
                    case "pt":
                        msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'L' and [Nam] = " + nmYear.Value + " " +
                               "and [CongViecCaNhan] = '" + chkCongViecCaNhanNganHangKPI.Checked + "' and [CongViecCaNhan] = 1";
                        DataTable pt = comm.GetDataTable(mconnectstring, msql, "KPINH");
                        dgrKPIBenhVien.AutoGenerateColumns = false;
                        dgrKPIBenhVien.DataSource = pt;
                        break;
                }
            }
            else if (congvieccanhancn == false)
            {
                switch (phuongdien)
                {
                    case "tc":
                        msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'F' and [Nam] = " + nmYear.Value + " " +
                               "and [CongViecCaNhan] = '" + chkCongViecCaNhanNganHangKPI.Checked + "'";
                        DataTable tc = comm.GetDataTable(mconnectstring, msql, "KPINH");
                        dgrKPICaNhan.AutoGenerateColumns = false;
                        dgrKPICaNhan.DataSource = tc;
                        break;
                    case "kh":
                        msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'C' and [Nam] = " + nmYear.Value + " " +
                               "and [CongViecCaNhan] = '" + chkCongViecCaNhanNganHangKPI.Checked + "'";
                        DataTable kh = comm.GetDataTable(mconnectstring, msql, "KPINH");
                        dgrKPIBenhVien.AutoGenerateColumns = false;
                        dgrKPIBenhVien.DataSource = kh;
                        break;
                    case "vh":
                        msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'B' and [Nam] = " + nmYear.Value + " " +
                               "and [CongViecCaNhan] = '" + chkCongViecCaNhanNganHangKPI.Checked + "'";
                        DataTable vh = comm.GetDataTable(mconnectstring, msql, "KPINH");
                        dgrKPIBenhVien.AutoGenerateColumns = false;
                        dgrKPIBenhVien.DataSource = vh;
                        break;
                    case "pt":
                        msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'L' and [Nam] = " + nmYear.Value + " " +
                               "and [CongViecCaNhan] = '" + chkCongViecCaNhanNganHangKPI.Checked + "'";
                        DataTable pt = comm.GetDataTable(mconnectstring, msql, "KPINH");
                        dgrKPIBenhVien.AutoGenerateColumns = false;
                        dgrKPIBenhVien.DataSource = pt;
                        break;
                }
            }
        }
        private void btnNganHangKPI_Click(object sender, EventArgs e)
        {
            LoadNganHangKPI();
        }

        private void btnNganHangCaNhan_Click(object sender, EventArgs e)
        {
            LoadNganHangCaNhan();
        }

        private void dgrKPIBenhVien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrKPIBenhVien);
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            Frm_AddEditKPI addkpi = new Frm_AddEditKPI();
            addkpi.ShowDialog();
        }

        private void chkCongViecCaNhanNganHangKPI_CheckedChanged(object sender, EventArgs e)
        {
            LoadNganHangKPI();
        }

        private void chkCongViecCaNhanCaNhan_CheckedChanged(object sender, EventArgs e)
        {
            LoadNganHangCaNhan();
        }

        private void dgrNganHangCaNhan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgrNganHangCaNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgrNganHangCaNhan_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null && dgv.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dgv.SelectedRows[0];

                // Lấy dữ liệu từ dòng được chọn
                object[] rowData = new object[selectedRow.Cells.Count];
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    rowData[i] = selectedRow.Cells[i].Value;
                }

                // Gọi phương thức tĩnh AddRowToDataGridView trên Form 2 để thêm dữ liệu
                FrmA73.AddRowToDataGridView(rowData);
            }
        }

        private void dgrKPIBenhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu cột được chọn là cột CheckBox và không phải là dòng Header
            if (e.ColumnIndex == dgrKPIBenhVien.Columns["Chon"].Index && e.RowIndex != -1)
            {
                DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)dgrKPIBenhVien.Rows[e.RowIndex].Cells["Chon"];
                bool isChecked = (bool)checkBox.Value;

                // Nếu CheckBox được chọn
                if (isChecked)
                {
                    // Lấy dữ liệu từ dòng được chọn và thêm vào DataTable
                    string cMaKPI = dgrKPIBenhVien.Rows[e.RowIndex].Cells["CMaKPI"].Value.ToString();
                    string cNoiDung = dgrKPIBenhVien.Rows[e.RowIndex].Cells["cNoiDung"].Value.ToString();
                    string cChiTieu = dgrKPIBenhVien.Rows[e.RowIndex].Cells["cChiTieu"].Value.ToString();

                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("CMaKPI", typeof(string));
                    dataTable.Columns.Add("cNoiDung", typeof(string));
                    dataTable.Columns.Add("cChiTieu", typeof(string));

                    dataTable.Rows.Add(cMaKPI, cNoiDung, cChiTieu);

                    // Lưu trữ dữ liệu DataTable vào Singleton
                    Singleton.Instance().setTable(dataTable);
                }
            }
        }
    }
}
