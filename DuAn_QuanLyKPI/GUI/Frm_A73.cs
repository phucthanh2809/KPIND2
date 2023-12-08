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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;
using System.Windows.Controls;
using DevExpress.XtraGrid.Views.Grid;
using GridView = System.Windows.Controls.GridView;
using Control = System.Windows.Controls.Control;
using DuAn_QuanLyKPI.Constants;

namespace DuAn_QuanLyKPI.GUI
{
    public partial class FrmA73 : DevExpress.XtraEditors.XtraForm
    {
        //lấy dữ liệu từu frm login
        private static string MaNV = Frm_Login.MaNV;
        private static string MaPhongKhoa = Frm_Login.MaPhongKhoa;
        private static string MaChucDanh = Frm_Login.MaChucDanh;
        private static string TenNV = Frm_Login.TenNV;
        private static string TenChucDanh = Frm_Login.TenChucDanh;
        private static string TenPhongKhoa = Frm_Login.TenPhongKhoa;
        private static string QuyNamPhieu = FrmChonBieuMau.QuyNam;

        //coneect & event
        private static string mconnectstring = Frm_Chinh_GUI.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        Timer updateTimer;

        private int CurrentTab = 0;
        public FrmA73()
        {
            InitializeComponent();
            LoadThongTinNhanVien();
            txtTest.Text = QuyNamPhieu;
            LoadDataBVTaiChinh();

            updateTimer = new Timer { Interval = 100 };
            updateTimer.Tick += UpdateTimer_Tick;
        }
        private void FrmA73_Load(object sender, EventArgs e)
        {
            TrangThai();
            TrangThai1();
            TrangThai2();
            TrangThai3();
            TrangThai4();

        }
        #region LoadDataGrid
        //Load thông tin nhân viên 
        private void LoadThongTinNhanVien()
        {
            txtTenNV.Text = TenNV;
            txtTenNV1.Text = TenNV;
            txtTenNV2.Text = TenNV;
            txtTenNV3.Text = TenNV;
            txtTenNV4.Text = TenNV;

            txtViTriCV.Text = TenChucDanh;
            txtViTriCV1.Text = TenChucDanh;
            txtViTriCV2.Text = TenChucDanh;
            txtViTriCV3.Text = TenChucDanh;
            txtViTriCV4.Text = TenChucDanh;

            txtKhoaPhong.Text = TenPhongKhoa;
            txtKhoaPhong1.Text = TenPhongKhoa;
            txtKhoaPhong2.Text = TenPhongKhoa;
            txtKhoaPhong3.Text = TenPhongKhoa;
            txtKhoaPhong4.Text = TenPhongKhoa;
        }
        //Load DataGridview Tài chính
        private void LoadDataBVTaiChinh()
        {
            msql = "SELECT * FROM dbo.KPI INNER JOIN dbo.ChiTietTieuChiMucTieuBV ON dbo.KPI.MaKPI = dbo.ChiTietTieuChiMucTieuBV.MaKPI INNER JOIN dbo.KPI_BenhVien ON dbo.ChiTietTieuChiMucTieuBV.MaPhieuKPIBV = dbo.KPI_BenhVien.MaPhieuKPIBV WHERE dbo.KPI.TieuChiID = 'F' AND dbo.KPI_BenhVien.NamPhieu = '" + QuyNamPhieu + "' ";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "Taichinh");
            dgrBVMucTieuTaiChinh.AutoGenerateColumns = false;
            dgrBVMucTieuTaiChinh.DataSource = tb;

            lbYearTC.Text = dgrBVMucTieuTaiChinh.Rows[0].Cells["cNamBVTC"].Value.ToString();
            lbTSTC.Text = dgrBVMucTieuTaiChinh.Rows[0].Cells["cTrongSoTieuChiBVTC"].Value.ToString() + "%";
            dgrBVMucTieuTaiChinh.CurrentCellDirtyStateChanged += dgrBVMucTieuTaiChinh_CurrentCellDirtyStateChanged;
            dgrBVMucTieuTaiChinh.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void LoadDataBVKhachHang()
        {
            msql = "SELECT * FROM dbo.KPI INNER JOIN dbo.ChiTietTieuChiMucTieuBV ON dbo.KPI.MaKPI = dbo.ChiTietTieuChiMucTieuBV.MaKPI INNER JOIN dbo.KPI_BenhVien ON dbo.ChiTietTieuChiMucTieuBV.MaPhieuKPIBV = dbo.KPI_BenhVien.MaPhieuKPIBV WHERE dbo.KPI.TieuChiID = 'C' AND dbo.KPI_BenhVien.NamPhieu = '" + QuyNamPhieu + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "KhachHang");
            dgrBVMucTieuKhachHang.AutoGenerateColumns = false;
            dgrBVMucTieuKhachHang.DataSource = tb;

            lbYearKH.Text = dgrBVMucTieuKhachHang.Rows[0].Cells["cNamBVKH"].Value.ToString();
            lbTSKH.Text = dgrBVMucTieuKhachHang.Rows[0].Cells["cTrongSoTieuChiBVKH"].Value.ToString();
            dgrBVMucTieuKhachHang.CurrentCellDirtyStateChanged += dgrBVMucTieuTaiChinh_CurrentCellDirtyStateChanged;
            dgrBVMucTieuKhachHang.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void LoadDataBVVanHanh()
        {
            msql = "SELECT * FROM dbo.KPI INNER JOIN dbo.ChiTietTieuChiMucTieuBV ON dbo.KPI.MaKPI = dbo.ChiTietTieuChiMucTieuBV.MaKPI INNER JOIN dbo.KPI_BenhVien ON dbo.ChiTietTieuChiMucTieuBV.MaPhieuKPIBV = dbo.KPI_BenhVien.MaPhieuKPIBV WHERE dbo.KPI.TieuChiID = 'B' AND dbo.KPI_BenhVien.NamPhieu = '" + QuyNamPhieu + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "VanHanh");
            dgrBVMucTieuVanHanh.AutoGenerateColumns = false;
            dgrBVMucTieuVanHanh.DataSource = tb;

            lbYearVH.Text = dgrBVMucTieuVanHanh.Rows[0].Cells["cNamBVVH"].Value.ToString();
            lbTSVH.Text = dgrBVMucTieuVanHanh.Rows[0].Cells["cTrongSoTieuChiBVVH"].Value.ToString();
            dgrBVMucTieuVanHanh.CurrentCellDirtyStateChanged += dgrBVMucTieuTaiChinh_CurrentCellDirtyStateChanged;
            dgrBVMucTieuVanHanh.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void LoadDataBVPhatTrien()
        {
            msql = "SELECT * FROM dbo.KPI INNER JOIN dbo.ChiTietTieuChiMucTieuBV ON dbo.KPI.MaKPI = dbo.ChiTietTieuChiMucTieuBV.MaKPI INNER JOIN dbo.KPI_BenhVien ON dbo.ChiTietTieuChiMucTieuBV.MaPhieuKPIBV = dbo.KPI_BenhVien.MaPhieuKPIBV WHERE dbo.KPI.TieuChiID = 'L' AND dbo.KPI_BenhVien.NamPhieu = '" + QuyNamPhieu + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "PhatTrien");
            dgrBVMucTieuPhatTrien.AutoGenerateColumns = false;
            dgrBVMucTieuPhatTrien.DataSource = tb;

            lbYearPT.Text = dgrBVMucTieuPhatTrien.Rows[0].Cells["cNamBVPT"].Value.ToString();
            lbTSPT.Text = dgrBVMucTieuPhatTrien.Rows[0].Cells["cTrongSoTieuChiBVPT"].Value.ToString();
            dgrBVMucTieuPhatTrien.CurrentCellDirtyStateChanged += dgrBVMucTieuTaiChinh_CurrentCellDirtyStateChanged;
            dgrBVMucTieuPhatTrien.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        #endregion
        #region Coppy Data
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            LoadDataTableTC();
            LoadDataTableKH();
        }
        private void LoadDataTableTC()
        {
            dgrNhapMucTieuTaiChinh.Rows.Clear();
            foreach (DataGridViewRow row in dgrBVMucTieuTaiChinh.Rows)
            {
                if (row.Cells["cChonTatCaBVTC"].Value != null && (bool)row.Cells["cChonTatCaBVTC"].Value)
                {
                    int n = dgrNhapMucTieuTaiChinh.Rows.Add();
                    dgrNhapMucTieuTaiChinh.Rows[n].Cells["cMaPhieuKPINTC"].Value = row.Cells["cMaPhieuKPIBVTC"].Value;
                    dgrNhapMucTieuTaiChinh.Rows[n].Cells["cMaKPINTC"].Value = row.Cells["cMaKPIBVTC"].Value.ToString();
                    dgrNhapMucTieuTaiChinh.Rows[n].Cells["cNoiDungNTC"].Value = row.Cells["cNoiDungBVTC"].Value.ToString();
                    dgrNhapMucTieuTaiChinh.Rows[n].Cells["cNamNTC"].Value = row.Cells["cNamBVTC"].Value;
                    dgrNhapMucTieuTaiChinh.Rows[n].Cells["cTrongSoKPINTC"].Value = row.Cells["cTrongSoKPIBVTC"].Value;
                }
            }
        }
        private void LoadDataTableKH()
        {
            dgrNhapMucTieuKhachHang.Rows.Clear();
            foreach (DataGridViewRow row in dgrBVMucTieuKhachHang.Rows)
            {
                if (row.Cells["cChonTatCaBVKH"].Value != null && (bool)row.Cells["cChonTatCaBVKH"].Value)
                {
                    int n = dgrNhapMucTieuKhachHang.Rows.Add(); 
                    dgrNhapMucTieuKhachHang.Rows[n].Cells["cMaPhieuKPINKH"].Value = row.Cells["cMaPhieuKPIBVKH"].Value.ToString();
                    dgrNhapMucTieuKhachHang.Rows[n].Cells["cMaKPINKH"].Value = row.Cells["cMaKPIBVKH"].Value.ToString();
                    dgrNhapMucTieuKhachHang.Rows[n].Cells["cNoiDungNKH"].Value = row.Cells["cNoiDungBVKH"].Value.ToString();
                    dgrNhapMucTieuKhachHang.Rows[n].Cells["cNamNKH"].Value = row.Cells["cNamBVKH"].Value;
                    dgrNhapMucTieuKhachHang.Rows[n].Cells["cTrongSoKPINKH"].Value = row.Cells["cTrongSoKPIBVKH"].Value.ToString();
                }
            }
        }
        private void LoadDataTableVH()
        {
            dgrNhapMucTieuVanHanh.Rows.Clear();
            foreach (DataGridViewRow row in dgrBVMucTieuVanHanh.Rows)
            {
                if (row.Cells["cChonTatCaBVVH"].Value != null && (bool)row.Cells["cChonTatCaBVVH"].Value)
                {
                    int n = dgrNhapMucTieuVanHanh.Rows.Add();
                    dgrNhapMucTieuVanHanh.Rows[n].Cells["cMaPhieuKPINVH"].Value = row.Cells["cMaPhieuKPIBVVH"].Value.ToString();
                    dgrNhapMucTieuVanHanh.Rows[n].Cells["cMaKPINVH"].Value = row.Cells["cMaKPIBVVH"].Value.ToString();
                    dgrNhapMucTieuVanHanh.Rows[n].Cells["cNoiDungNVH"].Value = row.Cells["cNoiDungBVVH"].Value;
                    dgrNhapMucTieuVanHanh.Rows[n].Cells["cNamNVH"].Value = row.Cells["cNamBVVH"].Value.ToString();
                    dgrNhapMucTieuVanHanh.Rows[n].Cells["cTrongSoKPINVH"].Value = row.Cells["cTrongSoKPIBVVH"].Value.ToString();
                }
            }
        }
        private void LoadDataTablePT()
        {
            dgrNhapMucTieuPhatTrien.Rows.Clear();
            foreach (DataGridViewRow row in dgrBVMucTieuPhatTrien.Rows)
            {
                if (row.Cells["cChonTatCaBVKH"].Value != null && (bool)row.Cells["cChonTatCaBVKH"].Value)
                {
                    int n = dgrNhapMucTieuPhatTrien.Rows.Add();
                    dgrNhapMucTieuPhatTrien.Rows[n].Cells["cMaPhieuKPINPT"].Value = row.Cells["cMaPhieuKPIBVPT"].Value.ToString();
                    dgrNhapMucTieuPhatTrien.Rows[n].Cells["cMaKPINPT"].Value = row.Cells["cMaKPIBVPT"].Value.ToString();
                    dgrNhapMucTieuPhatTrien.Rows[n].Cells["cNoiDungNPT"].Value = row.Cells["cNoiDungBVPT"].Value;
                    dgrNhapMucTieuPhatTrien.Rows[n].Cells["cNamNPT"].Value = row.Cells["cNamBVPT"].Value.ToString();
                    dgrNhapMucTieuPhatTrien.Rows[n].Cells["cTrongSoKPINPT"].Value = row.Cells["cTrongSoKPIBVPT"].Value;
                }
            }
        }
        private void dgrNhapMucTieuTaiChinh_ColumnHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.ColumnIndex == 0)
            {
                foreach (DataGridViewRow row in dgrBVMucTieuTaiChinh.Rows)
                {
                    row.Cells["cChonTatCaBVTC"].Value = false;
                }
            }
            LoadDataTableTC();
        }
        private void dgrNhapMucTieuKhachHang_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.ColumnIndex == 0)
            {
                foreach (DataGridViewRow row in dgrBVMucTieuKhachHang.Rows)
                {
                    row.Cells["cChonTatCaBVKH"].Value = false;
                }
            }
            LoadDataTableKH();
        }
        private void dgrBVMucTieuTaiChinh_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.ColumnIndex == 0)
            {
                foreach (DataGridViewRow row in dgrBVMucTieuTaiChinh.Rows)
                {
                    row.Cells["cChonTatCaBVTC"].Value = true;
                }
            }
        }
        private void dgrBVMucTieuKhachHang_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.ColumnIndex == 0)
            {
                foreach (DataGridViewRow row in dgrBVMucTieuKhachHang.Rows)
                {
                    row.Cells["cChonTatCaBVKH"].Value = true;
                }
            }
        }
        private void dgrBVMucTieuTaiChinh_MouseHover(object sender, EventArgs e)
        {
            updateTimer.Start();    
        }
        private void dgrBVMucTieuTaiChinh_MouseLeave(object sender, EventArgs e)
        {
            updateTimer.Stop();
        }
        private void dgrBVMucTieuKhachHang_MouseHover(object sender, EventArgs e)
        {
            updateTimer.Start();
        }
        private void dgrBVMucTieuKhachHang_MouseLeave(object sender, EventArgs e)
        {
            updateTimer.Stop();
        }
        private void dgrNhapMucTieuTaiChinh_MouseHover(object sender, EventArgs e)
        {
            updateTimer.Stop();
        }
        private void dgrNhapMucTieuKhachHang_MouseHover(object sender, EventArgs e)
        {
            updateTimer.Stop();
        }
        private void dgrNhapMucTieuTaiChinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgrNhapMucTieuTaiChinh.Rows.Count && e.ColumnIndex == 0)
            {
                foreach (DataGridViewRow row in dgrBVMucTieuTaiChinh.Rows)
                {
                    if (dgrNhapMucTieuTaiChinh.Rows[e.RowIndex].Cells["cMaKPINTC"].Value.ToString() == row.Cells["cMaKPIBVTC"].Value.ToString())
                    {
                        row.Cells["cChonTatCaBVTC"].Value = false;
                        break;
                    }
                }
                LoadDataTableTC();
            }
        }
        private void dgrNhapMucTieuKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0 && e.RowIndex < dgrNhapMucTieuKhachHang.Rows.Count && e.ColumnIndex == 0)
                {
                    foreach (DataGridViewRow row in dgrBVMucTieuKhachHang.Rows)
                    {
                        if (dgrNhapMucTieuKhachHang.Rows[e.RowIndex].Cells["cMaKPINKH"].Value.ToString() == row.Cells["cMaKPIBVKH"].Value.ToString())
                        {
                            row.Cells["cChonTatCaBVKH"].Value = false;
                            break;
                        }
                    }
                    LoadDataTableKH();
                }
        }
        private void dgrBVMucTieuTaiChinh_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dgrBVMucTieuTaiChinh.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void dgrBVMucTieuKhachHang_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dgrBVMucTieuKhachHang.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void CopyTCtoHT()
        {
            if (dgrNhapMucTieuTaiChinh.Rows.Count > 0)
            {
                dgrHTMucTieuTaiChinh.ColumnCount = dgrNhapMucTieuTaiChinh.ColumnCount;
                foreach (DataGridViewColumn col in dgrNhapMucTieuTaiChinh.Columns)
                {
                    dgrHTMucTieuTaiChinh.Columns[col.Index].Name = col.Name;
                }

                foreach (DataGridViewRow row in dgrNhapMucTieuTaiChinh.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        DataGridViewRow newRow = (DataGridViewRow)row.Clone();

                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            newRow.Cells[i].Value = row.Cells[i].Value;
                        }
                        dgrHTMucTieuTaiChinh.Rows.Add(newRow);
                    }
                }
            }
            else
            {
                ev.QFrmThongBao("Chưa có dữ liệu. Vui lòng nhập dữ liệu");
            }
        }
        private void CopyKHtoHT()
        {
            if (dgrNhapMucTieuKhachHang.Rows.Count > 0)
            {
                dgrHTMucTieuKhachHang.ColumnCount = dgrNhapMucTieuKhachHang.ColumnCount;
                foreach (DataGridViewColumn col in dgrNhapMucTieuKhachHang.Columns)
                {
                    dgrHTMucTieuKhachHang.Columns[col.Index].Name = col.Name;
                }

                foreach (DataGridViewRow row in dgrNhapMucTieuKhachHang.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        DataGridViewRow newRow = (DataGridViewRow)row.Clone();

                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            newRow.Cells[i].Value = row.Cells[i].Value;
                        }
                        dgrHTMucTieuKhachHang.Rows.Add(newRow);
                    }
                }
            }
            else
            {
                ev.QFrmThongBao("Chưa có dữ liệu. Vui lòng nhập dữ liệu");
            }
        }
        private void CopyVHtoHT()
        {
            if (dgrNhapMucTieuVanHanh.Rows.Count > 0)
            {
                dgrHTMucTieuVanHanh.ColumnCount = dgrNhapMucTieuVanHanh.ColumnCount;
                foreach (DataGridViewColumn col in dgrNhapMucTieuVanHanh.Columns)
                {
                    dgrHTMucTieuVanHanh.Columns[col.Index].Name = col.Name;
                }

                foreach (DataGridViewRow row in dgrNhapMucTieuVanHanh.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        DataGridViewRow newRow = (DataGridViewRow)row.Clone();

                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            newRow.Cells[i].Value = row.Cells[i].Value;
                        }
                        dgrHTMucTieuVanHanh.Rows.Add(newRow);
                    }
                }
            }
            else
            {
                ev.QFrmThongBao("Chưa có dữ liệu. Vui lòng nhập dữ liệu");
            }
        }
        private void CopyPTtoHT()
        {
            if (dgrNhapMucTieuPhatTrien.Rows.Count > 0)
            {
                dgrHTMucTieuPhatTrien.ColumnCount = dgrNhapMucTieuPhatTrien.ColumnCount;
                foreach (DataGridViewColumn col in dgrNhapMucTieuPhatTrien.Columns)
                {
                    dgrHTMucTieuPhatTrien.Columns[col.Index].Name = col.Name;
                }

                foreach (DataGridViewRow row in dgrNhapMucTieuPhatTrien.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        DataGridViewRow newRow = (DataGridViewRow)row.Clone();

                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            newRow.Cells[i].Value = row.Cells[i].Value;
                        }
                        dgrHTMucTieuPhatTrien.Rows.Add(newRow);
                    }
                }
            }
            else
            {
                ev.QFrmThongBao("Chưa có dữ liệu. Vui lòng nhập dữ liệu");
            }
        }
        #endregion
        #region Method Chuyển Tab


        private void TrangThai()
        {
            FrmSPTrangThai.ItemOptions.Indicator.Width = 50; // độ dài item
            FrmSPTrangThai.ConnectorLineThickness = 2; // viền đường kết nối
            FrmSPTrangThai.IndicatorLineThickness = 2; // viền đường tròn
            FrmSPTrangThai.ItemOptions.ConnectorOffset = -20; // điểm bắt đầu, kết thúc
            FrmSPTrangThai.ItemOptions.Indicator.ActiveStateDrawMode = IndicatorDrawMode.Outline; //click xanh viền tròn
            FrmSPTrangThai.ItemOptions.Indicator.InactiveStateDrawMode = IndicatorDrawMode.Outline; // chưa click viền tròn
        }
        private void TrangThai1()
        {
            FrmSPTrangThai1.ItemOptions.Indicator.Width = 50; // độ dài item
            FrmSPTrangThai1.ConnectorLineThickness = 2; // viền đường kết nối
            FrmSPTrangThai1.IndicatorLineThickness = 2; // viền đường tròn
            FrmSPTrangThai1.ItemOptions.ConnectorOffset = -20; // điểm bắt đầu, kết thúc
            FrmSPTrangThai1.ItemOptions.Indicator.ActiveStateDrawMode = IndicatorDrawMode.Outline; //click xanh viền tròn
            FrmSPTrangThai1.ItemOptions.Indicator.InactiveStateDrawMode = IndicatorDrawMode.Outline; // chưa click viền tròn

        }
        private void TrangThai2()
        {
            FrmSPTrangThai2.ItemOptions.Indicator.Width = 50; // độ dài item
            FrmSPTrangThai2.ConnectorLineThickness = 2; // viền đường kết nối
            FrmSPTrangThai2.IndicatorLineThickness = 2; // viền đường tròn
            FrmSPTrangThai2.ItemOptions.ConnectorOffset = -20; // điểm bắt đầu, kết thúc
            FrmSPTrangThai2.ItemOptions.Indicator.ActiveStateDrawMode = IndicatorDrawMode.Outline; //click xanh viền tròn
            FrmSPTrangThai2.ItemOptions.Indicator.InactiveStateDrawMode = IndicatorDrawMode.Outline; // chưa click viền tròn
            spTaiChinh2.State = StepProgressBarItemState.Active;
        }
        private void TrangThai3()
        {
            FrmSPTrangThai3.ItemOptions.Indicator.Width = 50; // độ dài item
            FrmSPTrangThai3.ConnectorLineThickness = 2; // viền đường kết nối
            FrmSPTrangThai3.IndicatorLineThickness = 2; // viền đường tròn
            FrmSPTrangThai3.ItemOptions.ConnectorOffset = -20; // điểm bắt đầu, kết thúc
            FrmSPTrangThai3.ItemOptions.Indicator.ActiveStateDrawMode = IndicatorDrawMode.Outline; //click xanh viền tròn
            FrmSPTrangThai3.ItemOptions.Indicator.InactiveStateDrawMode = IndicatorDrawMode.Outline; // chưa click viền tròn
            spTaiChinh3.State = StepProgressBarItemState.Active;
            spKhachHang3.State = StepProgressBarItemState.Active;
        }
        private void TrangThai4()
        {
            FrmSPTrangThai4.ItemOptions.Indicator.Width = 50; // độ dài item
            FrmSPTrangThai4.ConnectorLineThickness = 2; // viền đường kết nối
            FrmSPTrangThai4.IndicatorLineThickness = 2; // viền đường tròn
            FrmSPTrangThai4.ItemOptions.ConnectorOffset = -20; // điểm bắt đầu, kết thúc
            FrmSPTrangThai4.ItemOptions.Indicator.ActiveStateDrawMode = IndicatorDrawMode.Outline; //click xanh viền tròn
            FrmSPTrangThai4.ItemOptions.Indicator.InactiveStateDrawMode = IndicatorDrawMode.Outline; // chưa click viền tròn
            spTaiChinh4.State = StepProgressBarItemState.Active;
            spKhachHang4.State = StepProgressBarItemState.Active;
            spVanHanh4.State = StepProgressBarItemState.Active;
        }

        void ChuyenTrangThai(int step)
        {
            CurrentTab = step;
            switch (step)
            {
                case 0:
                    tabMucTieuKhoaPhong.SelectTab(step);
                    break;
                case 1:
                    tabMucTieuKhoaPhong.SelectTab(step);
                    // Thiết lập Trạng thái khi nhất nút
                    spTaiChinh1.State = StepProgressBarItemState.Active;
                    FrmSPTrangThai1.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage = svgImageCollection1[0];
                    FrmSPTrangThai1.Appearances.CommonActiveColor = Color.Green;
                    FrmSPTrangThai1.Items[step - 1].ContentBlock2.Caption = "Đã xong Tài Chính";
                    LoadDataBVKhachHang();
                    break;
                case 2:
                    tabMucTieuKhoaPhong.SelectTab(step);
                    //Thiết lập Trạng thái khi nhất nút
                    spKhachHang2.State = StepProgressBarItemState.Active;
                    FrmSPTrangThai2.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage = svgImageCollection1[0];
                    FrmSPTrangThai2.Appearances.CommonActiveColor = Color.Green;
                    FrmSPTrangThai2.Items[step - 1].ContentBlock2.Caption = "Đã xong Khách Hàng";
                    LoadDataBVVanHanh();
                    break;
                case 3:
                    tabMucTieuKhoaPhong.SelectTab(step);
                    //Thiết lập Trạng thái khi nhất nút
                    spVanHanh3.State = StepProgressBarItemState.Active;
                    FrmSPTrangThai3.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage = svgImageCollection1[0];
                    FrmSPTrangThai3.Appearances.CommonActiveColor = Color.Green;
                    FrmSPTrangThai3.Items[step - 1].ContentBlock2.Caption = "Đã xong Vận Hành";
                    LoadDataBVPhatTrien();
                    break;
                case 4:
                    tabMucTieuKhoaPhong.SelectTab(step);
                    spPhatTrien4.State = StepProgressBarItemState.Active;
                    FrmSPTrangThai4.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage = svgImageCollection1[0];
                    FrmSPTrangThai4.Appearances.CommonActiveColor = Color.Green;
                    FrmSPTrangThai4.Items[step - 1].ContentBlock2.Caption = "Đã xong Phát Triển";
                    break;
            }
        }
        private void KiemTraTyTrong(int step)
        {
            // Lấy tổng các giá trị trong các cột
            int total = 0;
            if (dgrNhapMucTieuTaiChinh.Rows.Count > 0)
            {
                for (int i = 0; i < dgrNhapMucTieuTaiChinh.Rows.Count; i++)
                {
                    total += int.Parse(dgrNhapMucTieuTaiChinh.CurrentRow.Cells["cTrongSoKPINTC"].Value.ToString());
                }
                // Kiểm tra tổng các giá trị
                if (total == 0 && total == null)
                {
                    ev.QFrmThongBao("Lưu ý: Chưa nhập tỷ trọng");
                }
                else if (total > 100)
                {
                    ev.QFrmThongBaoError("Trọng số đã vượt quá 100%");
                }
                else if (int.Parse(txtTongTrongSoTC.Text) > 0 && int.Parse(txtTongTrongSoTC.Text) <= 100)
                {
                    if (ev.QFrmThongBao_YesNo("Lưu ý: Kiểm tra tỷ trọng chưa được 100%. Bạn có muốn tiếp tục không?"))
                    {
                        ChuyenTrangThai(step);
                        if (step == 1)
                        {
                            CopyTCtoHT();
                        }  
                        else if (step == 2)
                        {
                            CopyKHtoHT();
                        }    
                        else if (step == 3)
                        {
                            CopyVHtoHT();
                        }   
                        else if (step == 4)
                        {
                            CopyPTtoHT();
                        }    
                    }
                    else
                    {

                    }
                }
                else
                {
                    // Thông báo  gì đó chưa biết 
                }
            }
            else
            {
                ev.QFrmThongBaoError("Chưa có dữ liệu! Vui lòng kiểm tra lại");
            }
        }
        private void TinhTrongSo()
        {
            int sc = dgrNhapMucTieuTaiChinh.Rows.Count;
            double sum = 0;
            for (int i = 0; i < sc; ++i)
                sum += double.Parse(dgrNhapMucTieuTaiChinh.Rows[i].Cells["cTrongSoKPINTC"].Value.ToString());
            txtTongTrongSoTC.Text = sum.ToString();
        }
        private void LoadTrongSoTC()
        {
            int total = 0;
            if (dgrNhapMucTieuTaiChinh.Rows.Count > 0)
            {
                for (int i = 0; i < dgrNhapMucTieuTaiChinh.Rows.Count; i++)
                {
                    total += int.Parse(dgrNhapMucTieuTaiChinh.CurrentRow.Cells["cTrongSoKPINTC"].Value.ToString());
                }
            }
            else
            {

            }
        }
        //Method coppy data 
        #region Method Copy Data
        private void copyDataBVtoTC()
        {
            dgrNhapMucTieuTaiChinh.Rows.Clear();

            for (int i = 0; i < dgrBVMucTieuTaiChinh.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgrBVMucTieuTaiChinh.Rows[i].Cells["cChonTatCaBVTC"].Value) == true)
                {
                    int n = dgrNhapMucTieuTaiChinh.Rows.Add();
                    dgrNhapMucTieuTaiChinh.Rows[n].Cells["cMaPhieuKPINTC"].Value = dgrBVMucTieuTaiChinh.Rows[i].Cells["cMaPhieuKPIBVTC"].Value.ToString();
                    dgrNhapMucTieuTaiChinh.Rows[n].Cells["cMaPKNTC"].Value = dgrBVMucTieuTaiChinh.Rows[i].Cells["cMaPKBVTC"].Value.ToString();
                    dgrNhapMucTieuTaiChinh.Rows[n].Cells["cTieuChiIDNTC"].Value = dgrBVMucTieuTaiChinh.Rows[i].Cells["cTieuChiIDBVTC"].Value.ToString();
                    dgrNhapMucTieuTaiChinh.Rows[n].Cells["cMaKPINTC"].Value = dgrBVMucTieuTaiChinh.Rows[i].Cells["cMaKPIBVTC"].Value.ToString();
                    dgrNhapMucTieuTaiChinh.Rows[n].Cells["cNoiDungNTC"].Value = dgrBVMucTieuTaiChinh.Rows[i].Cells["cMaKPIBVTC"].Value.ToString();
                    dgrNhapMucTieuTaiChinh.Rows[n].Cells["cChiTieuNTC"].Value = dgrBVMucTieuTaiChinh.Rows[i].Cells["cChiTieuBVTC"].Value.ToString();
                    dgrNhapMucTieuTaiChinh.Rows[n].Cells["cNamNTC"].Value = dgrBVMucTieuTaiChinh.Rows[i].Cells["cNamBVTC"].Value.ToString();
                    dgrNhapMucTieuTaiChinh.Rows[n].Cells["cNgayTaoKPIKPNTC"].Value = dgrBVMucTieuTaiChinh.Rows[i].Cells["cNgayTaoKPIKPBVTC"].Value.ToString();
                    dgrNhapMucTieuTaiChinh.Rows[n].Cells["cTrongSoTieuChiNTC"].Value = dgrBVMucTieuTaiChinh.Rows[i].Cells["cTrongSoTieuChiBVTC"].Value.ToString();
                    dgrNhapMucTieuTaiChinh.Rows[n].Cells["cTrongSoKPINTC"].Value = dgrBVMucTieuTaiChinh.Rows[i].Cells["cTrongSoKPIBVTC"].Value.ToString();
                    dgrNhapMucTieuTaiChinh.Rows[n].Cells["cTieuChiNHTTC"].Value = dgrBVMucTieuTaiChinh.Rows[i].Cells["cTrongSoTieuChiBVTC"].Value.ToString();
                    dgrNhapMucTieuTaiChinh.Rows[n].Cells["cTrongSoKPINTC"].Value = dgrBVMucTieuTaiChinh.Rows[i].Cells["cTrongSoKPIBVTC"].Value.ToString();
                }
            }
        }
        private void copyDataBVtoKH()
        {
            dgrBVMucTieuTaiChinh.Rows.Clear();
            for (int i = 0; i < dgrNhapMucTieuTaiChinh.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgrNhapMucTieuTaiChinh.Rows[i].Cells["cChonTatCaBVTC"].Value) == true)
                {
                    int n = dgrBVMucTieuTaiChinh.Rows.Add();
                    dgrBVMucTieuTaiChinh.Rows[n].Cells["cNhapMaPhongKhoa"].Value = dgrNhapMucTieuTaiChinh.Rows[n].Cells["cMaPhongKhoa"].Value.ToString();
                    dgrBVMucTieuTaiChinh.Rows[n].Cells["cNhapMucTieuBenhV"].Value = dgrNhapMucTieuTaiChinh.Rows[n].Cells["cMucTieuTaiChinhBV"].Value.ToString();
                    dgrBVMucTieuTaiChinh.Rows[n].Cells["cNhapTieuDe"].Value = dgrNhapMucTieuTaiChinh.Rows[n].Cells["cTieuDe"].Value.ToString();
                    dgrBVMucTieuTaiChinh.Rows[n].Cells["cNhapNoiDung"].Value = dgrNhapMucTieuTaiChinh.Rows[n].Cells["cNoiDung"].Value.ToString();
                    dgrBVMucTieuTaiChinh.Rows[n].Cells["cNhapTrongSo"].Value = dgrNhapMucTieuTaiChinh.Rows[n].Cells["cTrongSoMucTieuTaiChinhBV"].Value.ToString();
                }
            }
        }

        #endregion
        #endregion

        #region Event
        //chặn click vào tab
        private void tabMucTieuKhoaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tabMucTieuKhoaPhong.SelectedIndex = CurrentTab;
        }
        private void FrmA73_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ev.QFrmThongBao_YesNo("Bạn có thật sự muốn đóng Form này không?"))
            {
                FrmA73 a73 = new FrmA73();
                a73.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void dgrBVMucTieuTaiChinh_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrBVMucTieuTaiChinh);
        }

        private void dgrNhapMucTieuTaiChinh_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrNhapMucTieuTaiChinh);
        }
        private void btnTTKH_Click(object sender, EventArgs e)
        {
            KiemTraTyTrong(1); 
        }

        private void dgrNhapMucTieuTaiChinh_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            TinhTrongSo();
        }
        private void btnQLTC_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai(0);
        }
        private void btnTTVH_Click(object sender, EventArgs e)
        {
            KiemTraTyTrong(2);           
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai(1);
        }
        private void btnTTPT_Click(object sender, EventArgs e)
        {
            KiemTraTyTrong(3);
        }
        private void btnQLVH_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai(2);
        }
        private void btnTTHT_Click(object sender, EventArgs e)
        {
            KiemTraTyTrong(4);
        }
        private void btnQLPT_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai(4);
        }
        #endregion
        #region Dự phòng
        private void btnCoppyAll_Click(object sender, EventArgs e)
        {
            dgrNhapMucTieuTaiChinh.Rows.Clear();
            for (int i = 0; i < dgrBVMucTieuTaiChinh.Rows.Count; i++)
            {
                dgrBVMucTieuTaiChinh.Rows[i].Cells["cChonTatCaBVTCTC"].Value = true;
            }
            copyDataBVtoTC();
        }
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgrBVMucTieuTaiChinh.Rows.Count; i++)
            {
                dgrBVMucTieuTaiChinh.Rows[i].Cells["cChonTatCaBVTC"].Value = true;
            }
        }

        private void btnDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgrBVMucTieuTaiChinh.Rows.Count; i++)
            {
                dgrBVMucTieuTaiChinh.Rows[i].Cells["cChonTatCaBVTC"].Value = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (ev.QFrmThongBao_YesNo("Bạn có thật sự muốn xóa Form Nhập này không?"))
            {
                dgrNhapMucTieuTaiChinh.Rows.Clear();
            }
        }




        #endregion
    }
}