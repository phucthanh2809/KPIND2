﻿using BusinessCommon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using VBSQLHelper;

namespace DuAn_QuanLyKPI.GUI
{
    public partial class FrmA73 : DevExpress.XtraEditors.XtraForm
    {
        //coneect & event
        private static string mconnectstring = Frm_Chinh_GUI.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs(string.Empty);
        private string msql;

        Timer updateTimer;

        private DataGridView[] dataGridViews;
        private TextBox[] textBoxes;

        private DataTable tc = new DataTable();
        private DataTable kh = new DataTable();
        private DataTable vh = new DataTable();
        private DataTable pt = new DataTable();

        private int CurrentTab = 0;
        //lấy dữ liệu từu frm login
        private static string MaNV = Frm_Login.MaNV;
        private static string MaPhongKhoa = Frm_Login.MaPhongKhoa;
        private static string MaChucDanh = Frm_Login.MaChucDanh;
        private static string TenNV = Frm_Login.TenNV;
        private static string TenChucDanh = Frm_Login.TenChucDanh;
        private static string TenPhongKhoa = Frm_Login.TenPhongKhoa;
        private static string QuyPhieu = FrmChonBieuMau.Quy;
        private static string NamPhieu = FrmChonBieuMau.Nam;
        //Truyền dữ liệu sang form để thêm kpi vào grid
        public static string phuongdien;

        public System.Windows.Forms.DataGridView dgr;

        public FrmA73()
        {
            InitializeComponent();
            InitializeDataGridViews();
            LoadThongTinNhanVien();
            LoadDataBVTaiChinh();

            CreateTableCopyTC();

            updateTimer = new Timer { Interval = 100 };
            updateTimer.Tick += UpdateTimer_Tick;
            dtNgayLap.Value = DateTime.Now;
            ChuyenTrangThai(0);
        }
        private void FrmA73_Load(object sender, EventArgs e)
        {
            TrangThai();
            TrangThai1();
            TrangThai2();
            TrangThai3();
            TrangThai4();
        }
        private void InitializeDataGridViews()
        {
            // Khởi tạo mảng DataGridView
            dataGridViews = new DataGridView[] { dgrHTMucTieuTaiChinh, dgrHTMucTieuKhachHang, dgrHTMucTieuVanHanh, dgrHTMucTieuPhatTrien };

            // Code khởi tạo và hiển thị dữ liệu trong các DataGridView ở đây...

            // Ví dụ:
            for (int i = 0; i < dataGridViews.Length; i++)
            {
                dataGridViews[i].Rows.Add($"Row {i + 1}, Column 1", $"Row {i + 1}, Column 2", $"Row {i + 1}, Column 3");
            }
        }
        public DataGridView gridView
        {
            get
            {
                return dgrNhapMucTieuTaiChinh;
            }
            set
            {
                dgrNhapMucTieuTaiChinh = value;
            }
        }

        #region LoadDataGrid
        //Load thông tin nhân viên 
        private void LoadThongTinNhanVien()
        {
            txtTenNVTC.Text = TenNV;
            txtTenNVKH.Text = TenNV;
            txtTenNVVH.Text = TenNV;
            txtTenNVPT.Text = TenNV;
            txtTenNVHT.Text = TenNV;

            txtViTriCVTC.Text = TenChucDanh;
            txtViTriCVKH.Text = TenChucDanh;
            txtViTriCVVH.Text = TenChucDanh;
            txtViTriCVPT.Text = TenChucDanh;
            txtViTriCVHT.Text = TenChucDanh;

            lbKhoaPhongTC.Text = TenPhongKhoa;
            lbKhoaPhongKH.Text = TenPhongKhoa;
            lbKhoaPhongVH.Text = TenPhongKhoa;
            lbKhoaPhongPT.Text = TenPhongKhoa;
            lbKhoaPhongHT.Text = TenPhongKhoa;
        }
        //Load DataGridview Tài chính

        private void LoadDataBVTaiChinh()
        {
            msql = "SELECT * FROM dbo.KPI INNER JOIN dbo.ChiTietTieuChiMucTieuBV ON dbo.KPI.MaKPI = dbo.ChiTietTieuChiMucTieuBV.MaKPI INNER JOIN dbo.KPI_BenhVien ON dbo.ChiTietTieuChiMucTieuBV.MaPhieuKPIBV = dbo.KPI_BenhVien.MaPhieuKPIBV WHERE dbo.KPI.TieuChiID = 'F' AND dbo.KPI_BenhVien.NamPhieu = '" + NamPhieu + "' ";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "Taichinh");
            if (tb != null)
            {
                dgrBVMucTieuTaiChinh.AutoGenerateColumns = false;
                dgrBVMucTieuTaiChinh.DataSource = tb;    
            }
            if (dgrBVMucTieuTaiChinh.Rows.Count > 0)
            {
                lbYearTC.Text = dgrBVMucTieuTaiChinh.Rows[0].Cells["cNamBVTC"].Value.ToString();
            }
            try
            {
                txtTCHT.Text = dgrBVMucTieuTaiChinh.Rows[0].Cells["cTrongSoTieuChiBVTC"].Value.ToString();
                foreach (DataGridViewRow row in dgrBVMucTieuTaiChinh.Rows)
                {
                    string noiDung = row.Cells["cNoiDungBVTC"].Value.ToString();

                    if (noiDung.Contains(" X ") || noiDung.Contains(" X%"))
                    {
                        //thay thế giá trị X của cột PPD và ND bằng giá trị của cột Kế hoạch(Chỉ tiêu)
                        noiDung = noiDung.Replace("X", row.Cells["cKeHoachBVTC"].Value.ToString().Trim());
                    }
                    else if (noiDung.Contains("dd/mm/yyyy"))
                    {
                        //thay thế giá trị dd/mm/yyyy của cột PPD và ND bằng giá trị của cột Kế hoạch(Chỉ tiêu)
                        noiDung = noiDung.Replace("dd/mm/yyyy", row.Cells["cKeHoachBVTC"].Value.ToString().Trim());
                    }
                    row.Cells["cNoiDungBVTC"].Value = noiDung;
                }
            }
            catch (Exception)
            {
                ev.QFrmThongBaoError("Không có dữ liệu Kế Hoạch");
            }
        }
        private void LoadDataBVKhachHang()
        {
            msql = "SELECT * FROM dbo.KPI INNER JOIN dbo.ChiTietTieuChiMucTieuBV ON dbo.KPI.MaKPI = dbo.ChiTietTieuChiMucTieuBV.MaKPI INNER JOIN dbo.KPI_BenhVien ON dbo.ChiTietTieuChiMucTieuBV.MaPhieuKPIBV = dbo.KPI_BenhVien.MaPhieuKPIBV WHERE dbo.KPI.TieuChiID = 'C' AND dbo.KPI_BenhVien.NamPhieu = '" + NamPhieu + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "KhachHang");
            if (tb != null)
            {
                dgrBVMucTieuKhachHang.AutoGenerateColumns = false;
                dgrBVMucTieuKhachHang.DataSource = tb;
                txtKHHT.Text = dgrBVMucTieuKhachHang.Rows[0].Cells["cTrongSoTieuChiBVKH"].Value.ToString();
            }
            if (dgrBVMucTieuTaiChinh.Rows.Count > 0)
            {
                lbYearKH.Text = dgrBVMucTieuKhachHang.Rows[0].Cells["cNamBVKH"].Value.ToString();
            }
            try
            {
                foreach (DataGridViewRow row in dgrBVMucTieuKhachHang.Rows)
                {
                    string noiDung = row.Cells["cNoiDungBVKH"].Value.ToString();

                    if (noiDung.Contains(" X ") || noiDung.Contains(" X%"))
                    {
                        //thay thế giá trị X của cột PPD và ND bằng giá trị của cột Kế hoạch(Chỉ tiêu)
                        noiDung = noiDung.Replace("X", row.Cells["cKeHoachBVKH"].Value.ToString().Trim());
                    }
                    else if (noiDung.Contains("dd/mm/yyyy"))
                    {
                        //thay thế giá trị dd/mm/yyyy của cột PPD và ND bằng giá trị của cột Kế hoạch(Chỉ tiêu)
                        noiDung = noiDung.Replace("dd/mm/yyyy", row.Cells["cKeHoachBVKH"].Value.ToString().Trim());
                    }
                    row.Cells["cNoiDungBVKH"].Value = noiDung;
                }
            }
            catch (Exception)
            {
                ev.QFrmThongBaoError("Không có dữ liệu Kế Hoạch");
            }
        }
        private void LoadDataBVVanHanh()
        {
            msql = "SELECT * FROM dbo.KPI INNER JOIN dbo.ChiTietTieuChiMucTieuBV ON dbo.KPI.MaKPI = dbo.ChiTietTieuChiMucTieuBV.MaKPI INNER JOIN dbo.KPI_BenhVien ON dbo.ChiTietTieuChiMucTieuBV.MaPhieuKPIBV = dbo.KPI_BenhVien.MaPhieuKPIBV WHERE dbo.KPI.TieuChiID = 'B' AND dbo.KPI_BenhVien.NamPhieu = '" + NamPhieu + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "VanHanh");
            if (tb != null)
            {
                dgrBVMucTieuVanHanh.AutoGenerateColumns = false;
                dgrBVMucTieuVanHanh.DataSource = tb;
                txtVHHT.Text = dgrBVMucTieuVanHanh.Rows[0].Cells["cTrongSoTieuChiBVVH"].Value.ToString();
            }
            if (dgrBVMucTieuTaiChinh.Rows.Count > 0)
            {
                lbYearVH.Text = dgrBVMucTieuVanHanh.Rows[0].Cells["cNamBVVH"].Value.ToString();
            }
            try
            {
                foreach (DataGridViewRow row in dgrBVMucTieuVanHanh.Rows)
                {
                    string noiDung = row.Cells["cNoiDungBVVH"].Value.ToString();

                    if (noiDung.Contains(" X ") || noiDung.Contains(" X%"))
                    {
                        //thay thế giá trị X của cột PPD và ND bằng giá trị của cột Kế hoạch(Chỉ tiêu)
                        noiDung = noiDung.Replace("X", row.Cells["cKeHoachBVVH"].Value.ToString().Trim());
                    }
                    else if (noiDung.Contains("dd/mm/yyyy"))
                    {
                        //thay thế giá trị dd/mm/yyyy của cột PPD và ND bằng giá trị của cột Kế hoạch(Chỉ tiêu)
                        noiDung = noiDung.Replace("dd/mm/yyyy", row.Cells["cKeHoachBVVH"].Value.ToString().Trim());
                    }
                    row.Cells["cNoiDungBVVH"].Value = noiDung;
                }
            }
            catch (Exception)
            {
                ev.QFrmThongBaoError("Không có dữ liệu Kế Hoạch");
            }
        }
        private void LoadDataBVPhatTrien()
        {
            msql = "SELECT * FROM dbo.KPI INNER JOIN dbo.ChiTietTieuChiMucTieuBV ON dbo.KPI.MaKPI = dbo.ChiTietTieuChiMucTieuBV.MaKPI INNER JOIN dbo.KPI_BenhVien ON dbo.ChiTietTieuChiMucTieuBV.MaPhieuKPIBV = dbo.KPI_BenhVien.MaPhieuKPIBV WHERE dbo.KPI.TieuChiID = 'L' AND dbo.KPI_BenhVien.NamPhieu = '" + NamPhieu + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "PhatTrien");
            if (tb != null)
            {
                dgrBVMucTieuPhatTrien.AutoGenerateColumns = false;
                dgrBVMucTieuPhatTrien.DataSource = tb;
                txtPTHT.Text = dgrBVMucTieuPhatTrien.Rows[0].Cells["cTrongSoTieuChiBVPT"].Value.ToString();
            }
            if (dgrBVMucTieuTaiChinh.Rows.Count > 0)
            {
                lbYearPT.Text = dgrBVMucTieuPhatTrien.Rows[0].Cells["cNamBVPT"].Value.ToString();
                lbYearHT.Text = dgrBVMucTieuPhatTrien.Rows[0].Cells["cNamBVPT"].Value.ToString();
            }
            try
            {
                foreach (DataGridViewRow row in dgrBVMucTieuPhatTrien.Rows)
                {
                    string noiDung = row.Cells["cNoiDungBVPT"].Value.ToString();

                    if (noiDung.Contains(" X ") || noiDung.Contains(" X%"))
                    {
                        //thay thế giá trị X của cột PPD và ND bằng giá trị của cột Kế hoạch(Chỉ tiêu)
                        noiDung = noiDung.Replace("X", row.Cells["cKeHoachBVPT"].Value.ToString().Trim());
                    }
                    else if (noiDung.Contains("dd/mm/yyyy"))
                    {
                        //thay thế giá trị dd/mm/yyyy của cột PPD và ND bằng giá trị của cột Kế hoạch(Chỉ tiêu)
                        noiDung = noiDung.Replace("dd/mm/yyyy", row.Cells["cKeHoachBVPT"].Value.ToString().Trim());
                    }
                    row.Cells["cNoiDungBVPT"].Value = noiDung;
                }
            }
            catch (Exception)
            {
                ev.QFrmThongBaoError("Không có dữ liệu Kế Hoạch");
            }
        }
        #endregion
        #region Method Chuyển Tab
        private void TrangThai()
        {
            FrmSPTrangThaiTC.ItemOptions.Indicator.Width = 50; // độ dài item
            FrmSPTrangThaiTC.ConnectorLineThickness = 2; // viền đường kết nối
            FrmSPTrangThaiTC.IndicatorLineThickness = 2; // viền đường tròn
            FrmSPTrangThaiTC.ItemOptions.ConnectorOffset = 20; // điểm bắt đầu, kết thúc
            FrmSPTrangThaiTC.ItemOptions.Indicator.ActiveStateDrawMode = IndicatorDrawMode.Outline; //click xanh viền tròn
            FrmSPTrangThaiTC.ItemOptions.Indicator.InactiveStateDrawMode = IndicatorDrawMode.Outline; // chưa click viền tròn
        }
        private void TrangThai1()
        {
            FrmSPTrangThaiKH.ItemOptions.Indicator.Width = 50; // độ dài item
            FrmSPTrangThaiKH.ConnectorLineThickness = 2; // viền đường kết nối
            FrmSPTrangThaiKH.IndicatorLineThickness = 2; // viền đường tròn
            FrmSPTrangThaiKH.ItemOptions.ConnectorOffset = 20; // điểm bắt đầu, kết thúc
            FrmSPTrangThaiKH.ItemOptions.Indicator.ActiveStateDrawMode = IndicatorDrawMode.Outline; //click xanh viền tròn
            FrmSPTrangThaiKH.ItemOptions.Indicator.InactiveStateDrawMode = IndicatorDrawMode.Outline; // chưa click viền tròn
        }
        private void TrangThai2()
        {
            FrmSPTrangThaiVH.ItemOptions.Indicator.Width = 50; // độ dài item
            FrmSPTrangThaiVH.ConnectorLineThickness = 2; // viền đường kết nối
            FrmSPTrangThaiVH.IndicatorLineThickness = 2; // viền đường tròn
            FrmSPTrangThaiVH.ItemOptions.ConnectorOffset = -20; // điểm bắt đầu, kết thúc
            FrmSPTrangThaiVH.ItemOptions.Indicator.ActiveStateDrawMode = IndicatorDrawMode.Outline; //click xanh viền tròn
            FrmSPTrangThaiVH.ItemOptions.Indicator.InactiveStateDrawMode = IndicatorDrawMode.Outline; // chưa click viền tròn
            spTaiChinhVH.State = StepProgressBarItemState.Active;
        }
        private void TrangThai3()
        {
            FrmSPTrangThaiPT.ItemOptions.Indicator.Width = 50; // độ dài item
            FrmSPTrangThaiPT.ConnectorLineThickness = 2; // viền đường kết nối
            FrmSPTrangThaiPT.IndicatorLineThickness = 2; // viền đường tròn
            FrmSPTrangThaiPT.ItemOptions.ConnectorOffset = -20; // điểm bắt đầu, kết thúc
            FrmSPTrangThaiPT.ItemOptions.Indicator.ActiveStateDrawMode = IndicatorDrawMode.Outline; //click xanh viền tròn
            FrmSPTrangThaiPT.ItemOptions.Indicator.InactiveStateDrawMode = IndicatorDrawMode.Outline; // chưa click viền tròn
            spTaiChinhPT.State = StepProgressBarItemState.Active;
            spKhachHangPT.State = StepProgressBarItemState.Active;
        }
        private void TrangThai4()
        {
            FrmSPTrangThaiHT.ItemOptions.Indicator.Width = 50; // độ dài item
            FrmSPTrangThaiHT.ConnectorLineThickness = 2; // viền đường kết nối
            FrmSPTrangThaiHT.IndicatorLineThickness = 2; // viền đường tròn
            FrmSPTrangThaiHT.ItemOptions.ConnectorOffset = -20; // điểm bắt đầu, kết thúc
            FrmSPTrangThaiHT.ItemOptions.Indicator.ActiveStateDrawMode = IndicatorDrawMode.Outline; //click xanh viền tròn
            FrmSPTrangThaiHT.ItemOptions.Indicator.InactiveStateDrawMode = IndicatorDrawMode.Outline; // chưa click viền tròn
            spTaiChinhHT.State = StepProgressBarItemState.Active;
            spKhachHangHT.State = StepProgressBarItemState.Active;
            spVanHanhHT.State = StepProgressBarItemState.Active;
        }
        void ChuyenTrangThai(int step)
        {
            CurrentTab = step;
            switch (step)
            {
                case 0:
                    tabMucTieuKhoaPhong.SelectTab(step);
                    spTaiChinhTC.State = StepProgressBarItemState.Active;
                    FrmSPTrangThaiTC.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage = svgImageCollection1[0];
                    FrmSPTrangThaiTC.Appearances.CommonActiveColor = Color.Green;
                    FrmSPTrangThaiTC.Items[step].ContentBlock2.Caption = "Đang tại Tài chính";
                    break;
                case 1:
                    tabMucTieuKhoaPhong.SelectTab(step);
                    // Thiết lập Trạng thái khi nhất nút
                    spTaiChinhKH.State = StepProgressBarItemState.Active;
                    spKhachHangKH.State = StepProgressBarItemState.Active;
                    FrmSPTrangThaiKH.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage = svgImageCollection1[0];
                    FrmSPTrangThaiKH.Appearances.CommonActiveColor = Color.Green;
                    FrmSPTrangThaiKH.Items[step - 1].ContentBlock2.Caption = "Đã xong Tài Chính";
                    FrmSPTrangThaiKH.Items[step].ContentBlock2.Caption = "Đang tại Khách Hàng";
                    LoadDataBVKhachHang();
                    break;
                case 2:
                    tabMucTieuKhoaPhong.SelectTab(step);
                    //Thiết lập Trạng thái khi nhất nút
                    spTaiChinhVH.State = StepProgressBarItemState.Active;
                    spKhachHangVH.State = StepProgressBarItemState.Active;
                    spVanHanhVH.State = StepProgressBarItemState.Active;
                    FrmSPTrangThaiVH.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage = svgImageCollection1[0];
                    FrmSPTrangThaiVH.Appearances.CommonActiveColor = Color.Green;
                    FrmSPTrangThaiVH.Items[step - 2].ContentBlock2.Caption = "Đã xong Tài chính";
                    FrmSPTrangThaiVH.Items[step - 1].ContentBlock2.Caption = "Đã xong Khách Hàng";
                    FrmSPTrangThaiVH.Items[step].ContentBlock2.Caption = "Đang tại Vận hành";
                    LoadDataBVVanHanh();
                    break;
                case 3:
                    tabMucTieuKhoaPhong.SelectTab(step);
                    //Thiết lập Trạng thái khi nhất nút
                    spTaiChinhPT.State = StepProgressBarItemState.Active;
                    spKhachHangPT.State = StepProgressBarItemState.Active;
                    spVanHanhPT.State = StepProgressBarItemState.Active;
                    spPhatTrienPT.State = StepProgressBarItemState.Active;

                    FrmSPTrangThaiPT.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage = svgImageCollection1[0];
                    FrmSPTrangThaiPT.Appearances.CommonActiveColor = Color.Green;
                    FrmSPTrangThaiPT.Items[step - 3].ContentBlock2.Caption = "Đã xong Tài chính";
                    FrmSPTrangThaiPT.Items[step - 2].ContentBlock2.Caption = "Đã xong Khách Hàng";
                    FrmSPTrangThaiPT.Items[step - 1].ContentBlock2.Caption = "Đã xong Vận Hành";
                    FrmSPTrangThaiPT.Items[step].ContentBlock2.Caption = "Đang tại Phát triển";
                    LoadDataBVPhatTrien();
                    break;
                case 4:
                    tabMucTieuKhoaPhong.SelectTab(step);
                    spPhatTrienHT.State = StepProgressBarItemState.Active;
                    FrmSPTrangThaiHT.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage = svgImageCollection1[1];
                    FrmSPTrangThaiHT.Appearances.CommonActiveColor = Color.Green;
                    break;
                case 5:
                    tabMucTieuKhoaPhong.SelectTab(step);
                    LoadNganHangKPI();
                    break;
            }
        }
        private void KiemTraTyTrong(int step)
        {
            // Lấy tổng các giá trị trong các cột
            if (dgrNhapMucTieuTaiChinh.Rows.Count > 0)
            {
                switch (step)
                {
                    case 1:
                        int rowdgrtc = dgrNhapMucTieuTaiChinh.Rows.Count;
                        int totaltc = 0;
                        for (int i = 0; i < rowdgrtc; ++i)
                            totaltc += int.Parse(dgrNhapMucTieuTaiChinh.Rows[i].Cells["cTrongSoKPINTC"].Value.ToString());

                        if (totaltc == 0 && totaltc == 0 || totaltc == null && totaltc == null)
                        {
                            ev.QFrmThongBao("Lưu ý: Chưa nhập tỷ trọng");
                        }
                        else if (totaltc > 100 && int.Parse(txtTongTrongSoTC.Text) > 100)
                        {
                            ev.QFrmThongBaoError("Trọng số đã vượt quá 100%");
                        }
                        else if (totaltc > 0 && totaltc < 100 && int.Parse(txtTongTrongSoTC.Text) > 0 && int.Parse(txtTongTrongSoTC.Text) < 100)
                        {
                            ev.QFrmThongBaoError("Trọng số chưa được 100%");
                        }
                        else if (totaltc == 100 && int.Parse(txtTongTrongSoTC.Text) == 100)
                        {
                            LoadDataBVKhachHang();
                            CopyTCtoHT();
                            ChuyenTrangThai(1);
                            if (txtTongTrongSoKH.Text == string.Empty)
                            {
                                CreateTableCopyKH();
                            }
                            else
                            {

                            }
                        }
                        else if (totaltc == null && int.Parse(txtTongTrongSoTC.Text) == null)
                        {
                            ev.QFrmThongBaoError("Lỗi không có dữ liệu");
                        }
                        break;
                    case 2:
                        int rowdgrkh = dgrNhapMucTieuKhachHang.Rows.Count;
                        int totalkh = 0;
                        for (int i = 0; i < rowdgrkh; ++i)
                            totalkh += int.Parse(dgrNhapMucTieuKhachHang.Rows[i].Cells["cTrongSoKPINKH"].Value.ToString());
                        if (totalkh == 0 && totalkh == 0 || totalkh == null && totalkh == null)
                        {
                            ev.QFrmThongBao("Lưu ý: Chưa nhập tỷ trọng");
                        }
                        else if (totalkh > 100 && int.Parse(txtTongTrongSoKH.Text) > 100)
                        {
                            ev.QFrmThongBaoError("Trọng số đã vượt quá 100%");
                        }
                        else if (totalkh > 0 && totalkh < 100 && int.Parse(txtTongTrongSoKH.Text) > 0 && int.Parse(txtTongTrongSoKH.Text) < 100)
                        {
                            ev.QFrmThongBaoError("Trọng số chưa được 100%");
                        }
                        else if (totalkh == 100 && int.Parse(txtTongTrongSoKH.Text) == 100)
                        {
                            CopyKHtoHT();
                            LoadDataBVVanHanh();
                            ChuyenTrangThai(2);
                            if (txtTongTrongSoVH.Text == string.Empty)
                            {
                                CreateTableCopyVH();
                            }
                            else
                            {

                            }
                        }
                        else if (totalkh == null && int.Parse(txtTongTrongSoKH.Text) == null)
                        {
                            ev.QFrmThongBaoError("Lỗi không có dữ liệu");
                        }
                        break;
                    case 3:
                        int rowdgrvh = dgrNhapMucTieuVanHanh.Rows.Count;
                        int totalvh = 0;
                        for (int i = 0; i < rowdgrvh; ++i)
                            totalvh += int.Parse(dgrNhapMucTieuVanHanh.Rows[i].Cells["cTrongSoKPINVH"].Value.ToString());
                        if (totalvh == 0 && totalvh == 0 || totalvh == null && totalvh == null)
                        {
                            ev.QFrmThongBao("Lưu ý: Chưa nhập tỷ trọng");
                        }
                        else if (totalvh > 100 && int.Parse(txtTongTrongSoVH.Text) > 100)
                        {
                            ev.QFrmThongBaoError("Trọng số đã vượt quá 100%");
                        }
                        else if (totalvh > 0 && totalvh < 100 && int.Parse(txtTongTrongSoVH.Text) > 0 && int.Parse(txtTongTrongSoVH.Text) < 100)
                        {
                            ev.QFrmThongBaoError("Trọng số chưa được 100%");
                        }
                        else if (totalvh == 100 && int.Parse(txtTongTrongSoVH.Text) == 100)
                        {
                            CopyVHtoHT();
                            LoadDataBVPhatTrien();
                            ChuyenTrangThai(3);
                            if (txtTongTrongSoPT.Text == string.Empty)
                            {
                                CreateTableCopyPT();
                            }
                            else
                            {

                            }
                        }
                        else if (totalvh == null && int.Parse(txtTongTrongSoVH.Text) == null)
                        {
                            ev.QFrmThongBaoError("Lỗi không có dữ liệu");
                        }
                        break;
                    case 4:
                        int rowdgrpt = dgrNhapMucTieuPhatTrien.Rows.Count;
                        int totalpt = 0;
                        for (int i = 0; i < rowdgrpt; ++i)
                            totalpt += int.Parse(dgrNhapMucTieuPhatTrien.Rows[i].Cells["cTrongSoKPINPT"].Value.ToString());
                        if (totalpt == 0 && totalpt == 0 || totalpt == null && totalpt == null)
                        {
                            ev.QFrmThongBao("Lưu ý: Chưa nhập tỷ trọng");
                        }
                        else if (totalpt > 100)
                        {
                            ev.QFrmThongBaoError("Trọng số đã vượt quá 100%");
                        }
                        else if (totalpt > 0 && totalpt < 100 && int.Parse(txtTongTrongSoPT.Text) > 0 && int.Parse(txtTongTrongSoPT.Text) < 100)
                        {
                            ev.QFrmThongBaoError("Trọng số chưa được 100%");
                        }
                        else if (totalpt == 100 && int.Parse(txtTongTrongSoPT.Text) == 100)
                        {
                            CopyPTtoHT();
                            ChuyenTrangThai(4);
                            TinhTongTrongSoPhuongDien();
                        }
                        else if (totalpt == null && int.Parse(txtTongTrongSoPT.Text) == null)
                        {
                            ev.QFrmThongBaoError("Lỗi không có dữ liệu");
                        }
                        break;
                }
            }
            else
            {
                ev.QFrmThongBaoError("Chưa có dữ liệu! Vui lòng kiểm tra lại");
            }
        }
        #endregion
        #region Method
        private void TinhTongTrongSoPhuongDien()
        {
            try
            {
                int tc = int.Parse(txtTCHT.Text);
                int kh = int.Parse(txtKHHT.Text);
                int vh = int.Parse(txtVHHT.Text);
                int pt = int.Parse(txtPTHT.Text);
                int sum = tc + kh + vh + pt;
                txtTongTrongSoMucTieu.Text = sum.ToString();
            }
            catch (Exception)
            {
                ev.QFrmThongBaoError("Lỗi nhập sai định dạng hoặc thiếu dữ liệu");
            }
        }
        public string TaoMaPhieu()
        {
            return SQLHelper.ExecQuerySacalar($@"SELECT [dbo].[TaoMaPhieuKPIKP]('" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "')").ToString();
        }
        #endregion
        #region Event
        //chặn click vào ta b
        private void tabMucTieuKhoaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tabMucTieuKhoaPhong.SelectedIndex = CurrentTab;
        }
        private void dgrNhapMucTieuTaiChinh_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrNhapMucTieuTaiChinh);
        }
        private void btnTTKH_Click(object sender, EventArgs e)
        {
            dgrHTMucTieuTaiChinh.Rows.Clear();
            KiemTraTyTrong(1);
            txtMaPhieu.Text = TaoMaPhieu();
        }
        private void btnQLTC_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai(0);
        }
        private void btnTTVH_Click(object sender, EventArgs e)
        {
            dgrHTMucTieuKhachHang.Rows.Clear();
            KiemTraTyTrong(2);
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai(1);
        }
        private void btnTTPT_Click(object sender, EventArgs e)
        {
            dgrHTMucTieuVanHanh.Rows.Clear();
            KiemTraTyTrong(3);
        }
        private void btnQLVH_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai(2);
        }
        private void btnTTHT_Click(object sender, EventArgs e)
        {
            dgrHTMucTieuPhatTrien.Rows.Clear();
            KiemTraTyTrong(4);

        }
        private void btnQLPT_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai(3);
        }
        private void txtTCHT_Enter(object sender, EventArgs e)
        {
            txtTCHT.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTCHT_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtKHHT);
        }

        private void txtTCHT_Leave(object sender, EventArgs e)
        {
            txtTCHT.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }
        private void txtKHHT_Enter(object sender, EventArgs e)
        {
            txtKHHT.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }
        private void txtKHHT_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtVHHT);
        }
        private void txtKHHT_Leave(object sender, EventArgs e)
        {
            TinhTongTrongSoPhuongDien();
            txtKHHT.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }
        private void txtVHHT_Enter(object sender, EventArgs e)
        {
            txtVHHT.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtVHHT_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtPTHT);
        }

        private void txtVHHT_Leave(object sender, EventArgs e)
        {
            TinhTongTrongSoPhuongDien();
            txtVHHT.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtPTVH_Enter(object sender, EventArgs e)
        {
            txtPTHT.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }
        private void txtPTVH_Leave(object sender, EventArgs e)
        {
            TinhTongTrongSoPhuongDien();
            txtPTHT.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }
        private void txtTCHT_Validating(object sender, CancelEventArgs e)
        {
            string userInput = txtTCHT.Text.ToString();
            int parsedValue;
            if (!int.TryParse(userInput, out parsedValue))
            {
                ev.QFrmThongBaoError("Chỉ được nhập số không nhận chữ cái");
                txtTCHT.Text = "0";
            }
            else
            {
                if (parsedValue < 0 || parsedValue > 100)
                {
                    ev.QFrmThongBaoError("Số nhập vào phải nằm trong khoảng từ 0 đến 100");
                    dgrHTMucTieuPhatTrien.CancelEdit();
                    txtTCHT.Text = "0";
                }
            }

            TinhTongTrongSoPhuongDien();
            int sum = int.Parse(txtTongTrongSoMucTieu.Text);
            if (sum > 100)
            {
                ev.QFrmThongBaoError("Tổng trọng số mục tiêu vượt quá 100%.Vui lòng nhập lại!");
                txtTCHT.Text = "0";
                TinhTongTrongSoPhuongDien();
                txtTCHT.Focus();
            }
        }

        private void txtKHHT_Validating(object sender, CancelEventArgs e)
        {
            string userInput = txtKHHT.Text.ToString();
            int parsedValue;

            if (!int.TryParse(userInput, out parsedValue))
            {
                ev.QFrmThongBaoError("Chỉ được nhập số không nhận chữ cái");
                txtKHHT.Text = "0";
            }
            else
            {
                if (parsedValue < 0 || parsedValue > 100)
                {
                    ev.QFrmThongBaoError("Số nhập vào phải nằm trong khoảng từ 0 đến 100");
                    dgrHTMucTieuPhatTrien.CancelEdit();
                    txtKHHT.Text = "0";
                }
            }

            TinhTongTrongSoPhuongDien();
            try
            {
                int sum = int.Parse(txtTongTrongSoMucTieu.Text);
                if (sum > 100)
                {
                    ev.QFrmThongBaoError("Tổng trọng số mục tiêu vượt quá 100%.Vui lòng nhập lại!");
                    txtKHHT.Text = "0";
                    TinhTongTrongSoPhuongDien();
                    txtKHHT.Focus();
                }
            }
            catch (Exception)
            {
                ev.QFrmThongBaoError("Tổng lỗi");   
            }
        }
        private void txtVHHT_Validating(object sender, CancelEventArgs e)
        {
            string userInput = txtVHHT.Text.ToString();
            int parsedValue;

            if (!int.TryParse(userInput, out parsedValue))
            {
                ev.QFrmThongBaoError("Chỉ được nhập số không nhận chữ cái");
                txtVHHT.Text = "0";
            }
            else
            {
                if (parsedValue < 0 || parsedValue > 100)
                {
                    ev.QFrmThongBaoError("Số nhập vào phải nằm trong khoảng từ 0 đến 100");
                    dgrHTMucTieuPhatTrien.CancelEdit();
                    txtVHHT.Text = "0";
                }
            }

            TinhTongTrongSoPhuongDien();
            int sum = int.Parse(txtTongTrongSoMucTieu.Text);
            if (sum > 100)
            {
                ev.QFrmThongBaoError("Tổng trọng số mục tiêu vượt quá 100%.Vui lòng nhập lại!");
                txtVHHT.Text = "0";
                TinhTongTrongSoPhuongDien();
                txtVHHT.Focus();
            }
        }

        private void txtPTHT_Validating(object sender, CancelEventArgs e)
        {
            string userInput = txtPTHT.Text.ToString();
            int parsedValue;

            if (!int.TryParse(userInput, out parsedValue))
            {
                ev.QFrmThongBaoError("Chỉ được nhập số không nhận chữ cái");
                txtPTHT.Text = "0";
            }
            else
            {
                if (parsedValue < 0 || parsedValue > 100)
                {
                    ev.QFrmThongBaoError("Số nhập vào phải nằm trong khoảng từ 0 đến 100");
                    dgrHTMucTieuPhatTrien.CancelEdit();
                    txtPTHT.Text = "0";
                }
            }

            TinhTongTrongSoPhuongDien();
            int sum = int.Parse(txtTongTrongSoMucTieu.Text);
            if (sum > 100)
            {
                ev.QFrmThongBaoError("Tổng trọng số mục tiêu vượt quá 100%. Vui lòng nhập lại!");
                txtPTHT.Text = "0";
                TinhTongTrongSoPhuongDien();
                txtPTHT.Focus();
            }
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
        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            dgrHTMucTieuTaiChinh.Columns["cKeHoachHTTC"].Visible = false;
            dgrHTMucTieuKhachHang.Columns["cKeHoachHTKH"].Visible = false;
            dgrHTMucTieuVanHanh.Columns["cKeHoachHTVH"].Visible = false;
            dgrHTMucTieuPhatTrien.Columns["cKeHoachHTPT"].Visible = false;

            try
            {
                int sum = int.Parse(txtTongTrongSoMucTieu.Text);

                if (sum > 100)
                {
                    ev.QFrmThongBaoError("Trọng số vượt quá 100%");
                }
                else if (sum > 0 && sum < 100)
                {
                    ev.QFrmThongBaoError("Trọng số chưa đạt đủ 100%");
                }
                else if (sum == 100)
                {
                    if (ev.QFrmThongBao_YesNo("Hãy kiểm tra thật kĩ thông tin trước khi Hoàn thành nhé!"))
                    {
                        // Divide the values in DataGridViews by 100
                        DivideColumnValuesBy100(dgrHTMucTieuTaiChinh, "cTrongSoKPIHTTC");
                        DivideColumnValuesBy100(dgrHTMucTieuKhachHang, "cTrongSoKPIHTKH");
                        DivideColumnValuesBy100(dgrHTMucTieuVanHanh, "cTrongSoKPIHTVH");
                        DivideColumnValuesBy100(dgrHTMucTieuPhatTrien, "cTrongSoKPIHTPT");

                        // Lấy đường dẫn của thư mục bin-debug
                        string binDebugPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Documents");

                        // Tên tệp tin
                        string fileName = "A73.xlsx";

                        // Tạo đường dẫn đầy đủ
                        ev.QFrmThongBao("Nếu cần chỉnh sửa. Vui lòng chỉnh sửa trên Form, KHÔNG ĐƯỢC chỉnh sửa trên Excel. Mọi sự chỉnh sửa trên Excel phải tự chịu trách nhiệm!");
                        string existingFilePath = Path.Combine(binDebugPath, fileName);
                        AddDataGridViewsToExistingExcelSheet(dataGridViews, dgrBVMucTieuTaiChinh, dgrBVMucTieuKhachHang, dgrBVMucTieuVanHanh, dgrBVMucTieuPhatTrien, existingFilePath, txtTCHT.Text, txtKHHT.Text, txtVHHT.Text, txtPTHT.Text, TenNV, dtNgayLap.Value.ToString("dd/MM/yyyy"), dgrBVMucTieuTaiChinh.Rows[0].Cells["cTrongSoTieuChiBVTC"].Value.ToString(), dgrBVMucTieuKhachHang.Rows[0].Cells["cTrongSoTieuChiBVKH"].Value.ToString(), dgrBVMucTieuVanHanh.Rows[0].Cells["cTrongSoTieuChiBVVH"].Value.ToString(), dgrBVMucTieuPhatTrien.Rows[0].Cells["cTrongSoTieuChiBVPT"].Value.ToString()) ;

                        // Multiply the values in DataGridViews by 100
                        MultiplyColumnValuesBy100(dgrHTMucTieuTaiChinh, "cTrongSoKPIHTTC");
                        MultiplyColumnValuesBy100(dgrHTMucTieuKhachHang, "cTrongSoKPIHTKH");
                        MultiplyColumnValuesBy100(dgrHTMucTieuVanHanh, "cTrongSoKPIHTVH");
                        MultiplyColumnValuesBy100(dgrHTMucTieuPhatTrien, "cTrongSoKPIHTPT");
                    }
                }
                else if (sum == null || sum == 0)
                {
                    ev.QFrmThongBao("Vui lòng nhập dữ liệu");
                }
            }
            catch (Exception)
            {
                ev.QFrmThongBaoError("Sai định dạng dữ liệu không thể tính tổng");
            }
            
        } 
        private int[] startRows = { 7, 18, 29, 40 };
        private void DivideColumnValuesBy100(DataGridView dataGridView, string columnName)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[columnName].Value != null)
                {
                    double originalValue = Convert.ToDouble(row.Cells[columnName].Value);
                    double newValue = originalValue / 100;
                    row.Cells[columnName].Value = newValue;
                }
            }
        }
        // Function to multiply column values by 100
        private void MultiplyColumnValuesBy100(DataGridView dataGridView, string columnName)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[columnName].Value != null)
                {
                    double value = Convert.ToDouble(row.Cells[columnName].Value);
                    value *= 100;
                    row.Cells[columnName].Value = value;
                }
            }
        }
        private void AddDataGridViewsToExistingExcelSheet(DataGridView[] dataGridViews, DataGridView dgrBVMucTieuTaiChinh, DataGridView dgrBVMucTieuKhachHang, DataGridView dgrBVMucTieuVanHanh, DataGridView dgrBVMucTieuPhatTrien, string existingFilePath, string tc, string kh, string vh, string pt, string tennv, string ngaylap, string tcbv, string khbv, string vhbv, string ptbv)
        {
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;

            try
            {
                string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string kpiFolderPath = Path.Combine(documentPath, "KPI");

                if (!Directory.Exists(kpiFolderPath))
                {
                    Directory.CreateDirectory(kpiFolderPath);
                }

                string newFilePath = Path.Combine(kpiFolderPath, "A73_Biểu mẫu Mục tiêu Khoa Phòng.xlsx");

                if (File.Exists(newFilePath))
                {
                    File.Delete(newFilePath);
                }

                File.Copy(existingFilePath, newFilePath);

                excelApp = new Excel.Application();
                excelApp.Visible = true;
                workbook = excelApp.Workbooks.Open(newFilePath);

                Excel.Worksheet worksheet = null;
                foreach (Excel.Worksheet sheet in workbook.Sheets)
                {
                    if (sheet.Name == "A7.3.Muc tieu khoa.phong")
                    {
                        worksheet = sheet;
                        break;
                    }
                }

                if (worksheet == null)
                {
                    ev.QFrmThongBaoError("Không tìm thấy worksheet có tên A7.3.Muc tieu khoa.phong trong file Excel.");
                    return;
                }
                worksheet.Cells[2, 3] = "MỤC TIÊU KHOA/PHÒNG - NĂM " + DateTime.Now.Year.ToString();
                worksheet.Cells[3, 3] = "KHOA / PHÒNG: " + TenPhongKhoa.ToString();

                worksheet.Cells[6, 4] = double.Parse(tcbv) / 100;
                worksheet.Cells[17, 4] = double.Parse(khbv) / 100;
                worksheet.Cells[28, 4] = double.Parse(vhbv) / 100;
                worksheet.Cells[39, 4] = double.Parse(ptbv) / 100;

                worksheet.Cells[6, 6] = double.Parse(tc) / 100;
                worksheet.Cells[17, 6] = double.Parse(kh) / 100;
                worksheet.Cells[28, 6] = double.Parse(vh) / 100;
                worksheet.Cells[39, 6] = double.Parse(pt) / 100;

                worksheet.Cells[58, 2] = tennv;
                worksheet.Cells[59, 2] = "Ngày(Date) " + ngaylap;

                try
                {
                    // Convert and transfer data from dataGridViews to Excel
                    for (int groupIndex = 0; groupIndex < dataGridViews.Length; groupIndex++)
                    {
                        int startRow = startRows[groupIndex];
                        int startCol = 5; // Starting column index in Excel worksheet

                        for (int colIndex = 0; colIndex < dataGridViews[groupIndex].Columns.Count; colIndex++)
                        {
                            // Check if the column is visible
                            if (dataGridViews[groupIndex].Columns[colIndex].Visible)
                            {
                                for (int rowIndex = 0; rowIndex < dataGridViews[groupIndex].Rows.Count; rowIndex++)
                                {
                                    // Convert specific columns to double and divide by 100
                                    string columnName = dataGridViews[groupIndex].Columns[colIndex].Name;
                                    if (columnName.StartsWith("cTrongSoKPIBV"))
                                    {
                                        double originalValue = Convert.ToDouble(dataGridViews[groupIndex][colIndex, rowIndex].Value);
                                        double newValue = originalValue / 100;
                                        worksheet.Cells[startRow + rowIndex, startCol] = newValue;
                                    }
                                    else
                                    {
                                        // Transfer other data to the corresponding cells in the Excel worksheet
                                        worksheet.Cells[startRow + rowIndex, startCol] = dataGridViews[groupIndex][colIndex, rowIndex].Value;
                                    }
                                }

                                startCol++; // Move to the next column in Excel worksheet
                            }
                        }

                        if (groupIndex != dataGridViews.Length - 1)
                        {
                            startRow += dataGridViews[groupIndex].Rows.Count + 2; // Use 2 empty rows
                        }
                        else
                        {
                            startRow += dataGridViews[groupIndex].Rows.Count + 1; // Use 1 empty row for the last group
                        }
                    }

                    // Add data from dgrBVMucTieuTaiChinh to Excel
                    int startRowBVTC = 7;  // Update the starting row for the new data
                    int startColBVTC = 3;  // Update the starting column for the new data

                    for (int rowIndexBVTC = 0; rowIndexBVTC < dgrBVMucTieuTaiChinh.Rows.Count; rowIndexBVTC++)
                    {
                        // Transfer data to the corresponding cells in the Excel worksheet
                        worksheet.Cells[startRowBVTC + rowIndexBVTC, startColBVTC] = dgrBVMucTieuTaiChinh["cNoiDungBVTC", rowIndexBVTC].Value;

                        // Convert cTrongSoKPIBVTC to double and divide by 100
                        double originalValueBVTC = Convert.ToDouble(dgrBVMucTieuTaiChinh["cTrongSoKPIBVTC", rowIndexBVTC].Value);
                        double newValueBVTC = originalValueBVTC / 100;
                        worksheet.Cells[startRowBVTC + rowIndexBVTC, startColBVTC + 1] = newValueBVTC;
                    }

                    // Add data from dgrBVMucTieuKhachHang to Excel
                    int startRowBVKH = 18;  // Update the starting row for the new data
                    int startColBVKH = 3;  // Update the starting column for the new data

                    for (int rowIndexBVKH = 0; rowIndexBVKH < dgrBVMucTieuKhachHang.Rows.Count; rowIndexBVKH++)
                    {
                        // Transfer data to the corresponding cells in the Excel worksheet
                        worksheet.Cells[startRowBVKH + rowIndexBVKH, startColBVKH] = dgrBVMucTieuKhachHang["cNoiDungBVKH", rowIndexBVKH].Value;

                        // Convert cTrongSoKPIBVKH to double and divide by 100
                        double originalValueBVKH = Convert.ToDouble(dgrBVMucTieuKhachHang["cTrongSoKPIBVKH", rowIndexBVKH].Value);
                        double newValueBVKH = originalValueBVKH / 100;
                        worksheet.Cells[startRowBVKH + rowIndexBVKH, startColBVKH + 1] = newValueBVKH;
                    }

                    // Add data from dgrBVMucTieuVanHanh to Excel
                    int startRowBVVH = 29;  // Update the starting row for the new data
                    int startColBVVH = 3;  // Update the starting column for the new data

                    for (int rowIndexBVVH = 0; rowIndexBVVH < dgrBVMucTieuVanHanh.Rows.Count; rowIndexBVVH++)
                    {
                        // Transfer data to the corresponding cells in the Excel worksheet
                        worksheet.Cells[startRowBVVH + rowIndexBVVH, startColBVVH] = dgrBVMucTieuVanHanh["cNoiDungBVVH", rowIndexBVVH].Value;

                        // Convert cTrongSoKPIBVVH to double and divide by 100
                        double originalValueBVVH = Convert.ToDouble(dgrBVMucTieuVanHanh["cTrongSoKPIBVVH", rowIndexBVVH].Value);
                        double newValueBVVH = originalValueBVVH / 100;
                        worksheet.Cells[startRowBVVH + rowIndexBVVH, startColBVVH + 1] = newValueBVVH;
                    }

                    // Add data from dgrBVMucTieuPhatTrien to Excel
                    int startRowBVPT = 40;  // Update the starting row for the new data
                    int startColBVPT = 3;   // Update the starting column for the new data

                    for (int rowIndexBVPT = 0; rowIndexBVPT < dgrBVMucTieuPhatTrien.Rows.Count; rowIndexBVPT++)
                    {
                        // Transfer data to the corresponding cells in the Excel worksheet
                        worksheet.Cells[startRowBVPT + rowIndexBVPT, startColBVPT] = dgrBVMucTieuPhatTrien["cNoiDungBVPT", rowIndexBVPT].Value;

                        // Convert cTrongSoKPIBVPT to double and divide by 100
                        double originalValueBVPT = Convert.ToDouble(dgrBVMucTieuPhatTrien["cTrongSoKPIBVPT", rowIndexBVPT].Value);
                        double newValueBVPT = originalValueBVPT / 100;
                        worksheet.Cells[startRowBVPT + rowIndexBVPT, startColBVPT + 1] = newValueBVPT;
                    }
                    btnXacNhanGuiDi.Visible = true;
                }
                catch (Exception ex)
                {
                    ev.QFrmThongBaoError("An error occurred: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                ev.QFrmThongBaoError("An error occurred: " + ex.Message);
            }
        }
        
        #region CoppyGrid
        private void CreateTableCopyKH()
        {
            DataColumn existingColumn = kh.Columns["cMaKPIcpKH"];
            if (existingColumn == null)
            {
                // Column doesn't exist, so add it
                kh.Columns.Add("cMaKPIcpKH", typeof(string));
                kh.Columns.Add("cNoiDungcpKH", typeof(string));
                kh.Columns.Add("cKeHoachcpKH", typeof(string));
                kh.Columns.Add("cChiTieuKPIcpKH", typeof(string));
                kh.Columns.Add("TrongSocpKH", typeof(int));

                DataColumn[] primaryKeyColumns = new DataColumn[1];
                primaryKeyColumns[0] = kh.Columns["cMaKPIcpKH"];
                kh.PrimaryKey = primaryKeyColumns;
            }
            else
            {

            }
        }
        private void CreateTableCopyVH()
        {
            if (vh.Columns["cMaKPIcpVH"] == null)
            {
                vh.Columns.Add("cMaKPIcpVH", typeof(string));
                vh.Columns.Add("cNoiDungcpVH", typeof(string));
                vh.Columns.Add("cKeHoachcpVH", typeof(string));
                vh.Columns.Add("cChiTieuKPIcpVH", typeof(string));
                vh.Columns.Add("TrongSocpVH", typeof(int));
                DataColumn[] PrimaryKeyColumns = new DataColumn[1];
                PrimaryKeyColumns[0] = vh.Columns["cMaKPIcpVH"];
                vh.PrimaryKey = PrimaryKeyColumns;
            }
            else
            {

            }
        }
        private void CreateTableCopyPT()
        {
            if (pt.Columns["cMaKPIcpPT"] == null)
            {
                pt.Columns.Add("cMaKPIcpPT", typeof(string));
                pt.Columns.Add("cNoiDungcpPT", typeof(string));
                pt.Columns.Add("cKeHoachcpPT", typeof(string));
                pt.Columns.Add("cChiTieuKPIcpPT", typeof(string));
                pt.Columns.Add("TrongSocpPT", typeof(int));
                DataColumn[] PrimaryKeyColumns = new DataColumn[1];
                PrimaryKeyColumns[0] = pt.Columns["cMaKPIcpPT"];
                pt.PrimaryKey = PrimaryKeyColumns;
            }
            else
            {

            }
        }
        private void LoadDataTableKH()
        {
            kh.Rows.Clear();
            for (int i = 0; i < dgrBVMucTieuKhachHang.Rows.Count; i++)
            {
                if (dgrBVMucTieuKhachHang.Rows[i].Cells["cChonTatCaBVKH"].Value != null && (bool)dgrBVMucTieuKhachHang.Rows[i].Cells["cChonTatCaBVKH"].Value == true)
                {
                    DataRow newRow = kh.NewRow();
                    newRow["cMaKPIcpKH"] = dgrBVMucTieuKhachHang.Rows[i].Cells["cMaKPIBVKH"].Value;
                    newRow["cNoiDungcpKH"] = dgrBVMucTieuKhachHang.Rows[i].Cells["cNoiDungBVKH"].Value.ToString();
                    newRow["cKeHoachcpKH"] = dgrBVMucTieuKhachHang.Rows[i].Cells["cKeHoachBVKH"].Value.ToString();
                    newRow["cChiTieuKPIcpKH"] = dgrBVMucTieuKhachHang.Rows[i].Cells["cChiTieuKPIKH"].Value.ToString();
                    if (dgrBVMucTieuKhachHang.Rows[i].Cells["cTrongSocpKH"].Value == null)
                    {
                        dgrBVMucTieuKhachHang.Rows[i].Cells["cTrongSocpKH"].Value = "0";
                        newRow["TrongSocpKH"] = dgrBVMucTieuKhachHang.Rows[i].Cells["cTrongSocpKH"].Value.ToString();
                    }
                    else
                        newRow["TrongSocpKH"] = dgrBVMucTieuKhachHang.Rows[i].Cells["cTrongSocpKH"].Value.ToString();
                    kh.Rows.Add(newRow);
                }
            }
            dgrNhapMucTieuKhachHang.DataSource = kh;
        }
        private void LoadDataTableVH()
        {
            vh.Rows.Clear();
            for (int i = 0; i < dgrBVMucTieuVanHanh.Rows.Count; i++)
            {
                if (dgrBVMucTieuVanHanh.Rows[i].Cells["cChonTatCaBVVH"].Value != null && (bool)dgrBVMucTieuVanHanh.Rows[i].Cells["cChonTatCaBVVH"].Value == true)
                {
                    DataRow newRow = vh.NewRow();
                    newRow["cMaKPIcpVH"] = dgrBVMucTieuVanHanh.Rows[i].Cells["cMaKPIBVVH"].Value;
                    newRow["cNoiDungcpVH"] = dgrBVMucTieuVanHanh.Rows[i].Cells["cNoiDungBVVH"].Value.ToString();
                    newRow["cKeHoachcpVH"] = dgrBVMucTieuVanHanh.Rows[i].Cells["cKeHoachBVVH"].Value.ToString();
                    newRow["cChiTieuKPIcpVH"] = dgrBVMucTieuVanHanh.Rows[i].Cells["cChiTieuKPIVH"].Value.ToString();
                    if (dgrBVMucTieuVanHanh.Rows[i].Cells["cTrongSocpVH"].Value == null)
                    {
                        dgrBVMucTieuVanHanh.Rows[i].Cells["cTrongSocpVH"].Value = "0";
                        newRow["TrongSocpVH"] = dgrBVMucTieuVanHanh.Rows[i].Cells["cTrongSocpVH"].Value.ToString();
                    }
                    else
                        newRow["TrongSocpVH"] = dgrBVMucTieuVanHanh.Rows[i].Cells["cTrongSocpVH"].Value.ToString();
                    vh.Rows.Add(newRow);
                }
            }
            dgrNhapMucTieuVanHanh.DataSource = vh;
        }
        private void LoadDataTablePT()
        {
            pt.Rows.Clear();
            for (int i = 0; i < dgrBVMucTieuPhatTrien.Rows.Count; i++)
            {
                if (dgrBVMucTieuPhatTrien.Rows[i].Cells["cChonTatCaBVPT"].Value != null && (bool)dgrBVMucTieuPhatTrien.Rows[i].Cells["cChonTatCaBVPT"].Value == true)
                {
                    DataRow newRow = pt.NewRow();
                    newRow["cMaKPIcpPT"] = dgrBVMucTieuPhatTrien.Rows[i].Cells["cMaKPIBVPT"].Value;
                    newRow["cNoiDungcpPT"] = dgrBVMucTieuPhatTrien.Rows[i].Cells["cNoiDungBVPT"].Value.ToString();
                    newRow["cKeHoachcpPT"] = dgrBVMucTieuPhatTrien.Rows[i].Cells["cKeHoachBVPT"].Value.ToString();
                    newRow["cChiTieuKPIcpPT"] = dgrBVMucTieuPhatTrien.Rows[i].Cells["cChiTieuKPIPT"].Value.ToString();
                    if (dgrBVMucTieuPhatTrien.Rows[i].Cells["cTrongSocpPT"].Value == null)
                    {
                        dgrBVMucTieuPhatTrien.Rows[i].Cells["cTrongSocpPT"].Value = "0";
                        newRow["TrongSocpPT"] = dgrBVMucTieuPhatTrien.Rows[i].Cells["cTrongSocpPT"].Value.ToString();
                    }
                    else
                        newRow["TrongSocpPT"] = dgrBVMucTieuPhatTrien.Rows[i].Cells["cTrongSocpPT"].Value.ToString();
                    pt.Rows.Add(newRow);
                }
            }
            dgrNhapMucTieuPhatTrien.DataSource = pt;
        }

        private void ReturnDataTableKH()
        {
            for (int i = 0; i < dgrNhapMucTieuKhachHang.Rows.Count; i++)
            {
                string value = dgrNhapMucTieuKhachHang.Rows[i].Cells["cTrongSoKPINKH"].Value.ToString().Trim();
                foreach (DataRow row in kh.Rows)
                {
                    String id = Convert.ToString(row["cMaKPIcpKH"]);
                    if (id == Convert.ToString(dgrNhapMucTieuKhachHang.Rows[i].Cells["cMaKPINKH"].Value))
                    {
                        row["TrongSocpKH"] = value;
                    }
                }
            }
            dgrNhapMucTieuKhachHang.DataSource = kh;
            for (int j = 0; j < dgrBVMucTieuKhachHang.Rows.Count; j++)
            {
                foreach (DataRow row in kh.Rows)
                {
                    String id = Convert.ToString(row["cMaKPIcpKH"]);
                    if (id == Convert.ToString(dgrBVMucTieuKhachHang.Rows[j].Cells["cMaKPIBVKH"].Value))
                    {
                        dgrBVMucTieuKhachHang.Rows[j].Cells["cTrongSocpKH"].Value = row["TrongSocpKH"].ToString();
                    }
                }
            }
        }
        private void ReturnDataTableVH()
        {
            for (int i = 0; i < dgrNhapMucTieuVanHanh.Rows.Count; i++)
            {
                string value = dgrNhapMucTieuVanHanh.Rows[i].Cells["cTrongSoKPINVH"].Value.ToString().Trim();
                foreach (DataRow row in vh.Rows)
                {
                    String id = Convert.ToString(row["cMaKPIcpVH"]);
                    if (id == Convert.ToString(dgrNhapMucTieuVanHanh.Rows[i].Cells["cMaKPINVH"].Value))
                    {
                        row["TrongSocpVH"] = value;
                    }
                }
            }
            dgrNhapMucTieuVanHanh.DataSource = vh;
            for (int j = 0; j < dgrBVMucTieuVanHanh.Rows.Count; j++)
            {
                foreach (DataRow row in vh.Rows)
                {
                    String id = Convert.ToString(row["cMaKPIcpVH"]);
                    if (id == Convert.ToString(dgrBVMucTieuVanHanh.Rows[j].Cells["cMaKPIBVVH"].Value))
                    {
                        dgrBVMucTieuVanHanh.Rows[j].Cells["cTrongSocpVH"].Value = row["TrongSocpVH"].ToString();
                    }
                }
            }
        }
        private void ReturnDataTablePT()
        {
            for (int i = 0; i < dgrNhapMucTieuPhatTrien.Rows.Count; i++)
            {
                string value = dgrNhapMucTieuPhatTrien.Rows[i].Cells["cTrongSoKPINPT"].Value.ToString().Trim();
                foreach (DataRow row in pt.Rows)
                {
                    String id = Convert.ToString(row["cMaKPIcpPT"]);
                    if (id == Convert.ToString(dgrNhapMucTieuPhatTrien.Rows[i].Cells["cMaKPINPT"].Value))
                    {
                        row["TrongSocpPT"] = value;
                    }
                }
            }
            dgrNhapMucTieuPhatTrien.DataSource = pt;
            for (int j = 0; j < dgrBVMucTieuPhatTrien.Rows.Count; j++)
            {
                foreach (DataRow row in pt.Rows)
                {
                    String id = Convert.ToString(row["cMaKPIcpPT"]);
                    if (id == Convert.ToString(dgrBVMucTieuPhatTrien.Rows[j].Cells["cMaKPIBVPT"].Value))
                    {
                        dgrBVMucTieuPhatTrien.Rows[j].Cells["cTrongSocpPT"].Value = row["TrongSocpPT"].ToString();
                    }
                }
            }
        }
        private void TinhTrongSoKPITC()
        {
            int sc = dgrNhapMucTieuTaiChinh.Rows.Count;
            int sum = 0;
            for (int i = 0; i < sc; ++i)
                sum += int.Parse(dgrNhapMucTieuTaiChinh.Rows[i].Cells["cTrongSoKPINTC"].Value.ToString());
            if (sum > 100)
            {
                ev.QFrmThongBaoError("Trọng số đã vượt quá 100%. Vui lòng nhập lại trọng số");

                dgrNhapMucTieuTaiChinh.CurrentRow.Cells["cTrongSoKPINTC"].Value = 0;
            }
            else if (sum > 0 && sum <= 100)
            {
                txtTongTrongSoTC.Text = sum.ToString();
            }
            else if (sum == null)
                ev.QFrmThongBaoError("Trọng số chưa hợp lý!");
            else
            {

            }
        }
        private void TinhTrongSoKPIKH()
        {
            int sc = dgrNhapMucTieuKhachHang.Rows.Count;
            int sum = 0;
            for (int i = 0; i < sc; ++i)
                sum += int.Parse(dgrNhapMucTieuKhachHang.Rows[i].Cells["cTrongSoKPINKH"].Value.ToString());
            if (sum > 100)
            {
                ev.QFrmThongBaoError("Trọng số đã vượt quá 100%. Vui lòng nhập lại trọng số");

                dgrNhapMucTieuKhachHang.CurrentRow.Cells["cTrongSoKPINKH"].Value = 0;
            }
            else if (sum > 0 && sum <= 100)
            {
                txtTongTrongSoKH.Text = sum.ToString();
            }
            else if (sum == null)
                ev.QFrmThongBaoError("Trọng số chưa hợp lý!");
            else
            {

            }
        }
        private void TinhTrongSoKPIVH()
        {
            int sc = dgrNhapMucTieuVanHanh.Rows.Count;
            int sum = 0;
            for (int i = 0; i < sc; ++i)
                sum += int.Parse(dgrNhapMucTieuVanHanh.Rows[i].Cells["cTrongSoKPINVH"].Value.ToString());
            if (sum > 100)
            {
                ev.QFrmThongBaoError("Trọng số đã vượt quá 100%. Vui lòng nhập lại trọng số");

                dgrNhapMucTieuVanHanh.CurrentRow.Cells["cTrongSoKPINVH"].Value = 0;
            }
            else if (sum > 0 && sum <= 100)
            {
                txtTongTrongSoVH.Text = sum.ToString();
            }
            else if (sum == null)
                ev.QFrmThongBaoError("Trọng số chưa hợp lý!");
            else
            {

            }
        }
        private void TinhTrongSoKPIPT()
        {
            int sc = dgrNhapMucTieuPhatTrien.Rows.Count;
            int sum = 0;
            for (int i = 0; i < sc; ++i)
                sum += int.Parse(dgrNhapMucTieuPhatTrien.Rows[i].Cells["cTrongSoKPINPT"].Value.ToString());
            if (sum > 100)
            {
                ev.QFrmThongBaoError("Trọng số đã vượt quá 100%. Vui lòng nhập lại trọng số");

                dgrNhapMucTieuPhatTrien.CurrentRow.Cells["cTrongSoKPINPT"].Value = 0;
            }
            else if (sum > 0 && sum <= 100)
            {
                txtTongTrongSoPT.Text = sum.ToString();
            }
            else if (sum == null)
                ev.QFrmThongBaoError("Trọng số chưa hợp lý!");
            else
            {

            }
        }

        private void CopyTCtoHT()
        {
            if (dgrNhapMucTieuTaiChinh.Rows.Count > 0)
            {
                // Chắc chắn rằng dgrHTMucTieuTaiChinh có đúng 3 cột
                if (dgrHTMucTieuTaiChinh.ColumnCount == 4)
                {
                    // Đặt tên cho cột của dgrHTMucTieuTaiChinh
                    dgrHTMucTieuTaiChinh.Columns[0].Name = "cNoiDungHTTC";
                    dgrHTMucTieuTaiChinh.Columns[1].Name = "cKeHoachHTTC";
                    dgrHTMucTieuTaiChinh.Columns[2].Name = "cChiTieuKPIHTTC";
                    dgrHTMucTieuTaiChinh.Columns[3].Name = "cTrongSoKPIHTTC";
                    foreach (DataGridViewRow row in dgrNhapMucTieuTaiChinh.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            // Lấy giá trị của 3 cột cần thiết
                            object noiDung = row.Cells["cNoiDungNTC"].Value;
                            object keHoach = row.Cells["cKeHoachNTC"].Value;
                            object chitieu = row.Cells["cChiTieuKPINTC"].Value;
                            object trongSo = row.Cells["cTrongSoKPINTC"].Value;
                            // Thêm giá trị vào dgrHTMucTieuTaiChinh
                            dgrHTMucTieuTaiChinh.Rows.Add(noiDung, keHoach, chitieu, trongSo);
                        }
                    }
                }
                else
                {
                    // Số lượng cột của dgrHTMucTieuTaiChinh không đúng, thông báo lỗi
                    ev.QFrmThongBao("Số lượng cột của Hoàn thành Tài chính không đúng. Vui lòng kiểm tra lại.");
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
                // Chắc chắn rằng dgrHTMucTieuTaiChinh có đúng 3 cột
                if (dgrHTMucTieuKhachHang.ColumnCount == 4)
                {
                    // Đặt tên cho cột của dgrHTMucTieuTaiChinh
                    dgrHTMucTieuKhachHang.Columns[0].Name = "cNoiDungHTKH";
                    dgrHTMucTieuKhachHang.Columns[1].Name = "cKeHoachHTKH";
                    dgrHTMucTieuKhachHang.Columns[2].Name = "cChiTieuKPIHTKH";
                    dgrHTMucTieuKhachHang.Columns[3].Name = "cTrongSoKPIHTKH";

                    foreach (DataGridViewRow row in dgrNhapMucTieuKhachHang.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            // Lấy giá trị của 3 cột cần thiết
                            object noiDung = row.Cells["cNoiDungNKH"].Value;
                            object keHoach = row.Cells["cKeHoachNKH"].Value;
                            object chitieu = row.Cells["cChiTieuKPINKH"].Value;
                            object trongSo = row.Cells["cTrongSoKPINKH"].Value;

                            // Thêm giá trị vào dgrHTMucTieuTaiChinh
                            dgrHTMucTieuKhachHang.Rows.Add(noiDung, keHoach, chitieu, trongSo);
                        }
                    }
                }
                else
                {
                    // Số lượng cột của dgrHTMucTieuTaiChinh không đúng, thông báo lỗi
                    ev.QFrmThongBao("Số lượng cột của Hoàn thành Khách hàng không đúng. Vui lòng kiểm tra lại.");
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
                // Chắc chắn rằng dgrHTMucTieuTaiChinh có đúng 3 cột
                if (dgrHTMucTieuVanHanh.ColumnCount == 4)
                {
                    // Đặt tên cho cột của dgrHTMucTieuTaiChinh
                    dgrHTMucTieuVanHanh.Columns[0].Name = "cNoiDungHTVH";
                    dgrHTMucTieuVanHanh.Columns[1].Name = "cKeHoachHTVH";
                    dgrHTMucTieuVanHanh.Columns[2].Name = "cChiTieuKPIHTVH";
                    dgrHTMucTieuVanHanh.Columns[3].Name = "cTrongSoKPIHTVH";

                    foreach (DataGridViewRow row in dgrNhapMucTieuVanHanh.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            // Lấy giá trị của 3 cột cần thiết
                            object noiDung = row.Cells["cNoiDungNVH"].Value;
                            object keHoach = row.Cells["cKeHoachNVH"].Value;
                            object chitieu = row.Cells["cChiTieuKPINVH"].Value;
                            object trongSo = row.Cells["cTrongSoKPINVH"].Value;

                            // Thêm giá trị vào dgrHTMucTieuTaiChinh
                            dgrHTMucTieuVanHanh.Rows.Add(noiDung, keHoach, chitieu, trongSo);
                        }
                    }
                }
                else
                {
                    // Số lượng cột của dgrHTMucTieuTaiChinh không đúng, thông báo lỗi
                    ev.QFrmThongBao("Số lượng cột của Hoàn thành Vận hành không đúng. Vui lòng kiểm tra lại.");
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
                // Chắc chắn rằng dgrHTMucTieuTaiChinh có đúng 3 cột
                if (dgrHTMucTieuPhatTrien.ColumnCount == 4)
                {
                    // Đặt tên cho cột của dgrHTMucTieuTaiChinh
                    dgrHTMucTieuPhatTrien.Columns[0].Name = "cNoiDungHTPT";
                    dgrHTMucTieuPhatTrien.Columns[1].Name = "cKeHoachHTPT";
                    dgrHTMucTieuPhatTrien.Columns[2].Name = "cChiTieuKPIHTPT";
                    dgrHTMucTieuPhatTrien.Columns[3].Name = "cTrongSoKPIHTPT";

                    foreach (DataGridViewRow row in dgrNhapMucTieuPhatTrien.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            // Lấy giá trị của 3 cột cần thiết
                            object noiDung = row.Cells["cNoiDungNPT"].Value;
                            object keHoach = row.Cells["cKeHoachNPT"].Value;
                            object chitieu = row.Cells["cChiTieuKPINPT"].Value;
                            object trongSo = row.Cells["cTrongSoKPINPT"].Value;

                            // Thêm giá trị vào dgrHTMucTieuTaiChinh
                            dgrHTMucTieuPhatTrien.Rows.Add(noiDung, keHoach, chitieu, trongSo);
                        }
                    }
                }
                else
                {
                    // Số lượng cột của dgrHTMucTieuTaiChinh không đúng, thông báo lỗi
                    ev.QFrmThongBao("Số lượng cột của Hoàn thành Phát triển không đúng. Vui lòng kiểm tra lại.");
                }
            }
            else
            {
                ev.QFrmThongBao("Chưa có dữ liệu. Vui lòng nhập dữ liệu");
            }
        }
        #endregion

        #region Event
        //Timer_Tick
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            LoadDataTableTC();
            LoadDataTableKH();
            LoadDataTableVH();
            LoadDataTablePT();
        }
        //CellClick 

        private void dgrBVMucTieuKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgrBVMucTieuKhachHang.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dgrBVMucTieuKhachHang.Columns.Count)
            {
                if (dgrBVMucTieuKhachHang.Rows[e.RowIndex].Cells["cChonTatCaBVKH"].Value != null && (bool)dgrBVMucTieuKhachHang.Rows[e.RowIndex].Cells["cChonTatCaBVKH"].Value == true)
                {
                    LoadDataTableKH();
                    dgrBVMucTieuKhachHang.Rows[e.RowIndex].Cells["cChonTatCaBVKH"].Value = false;
                    return;
                }
                LoadDataTableKH();
                dgrBVMucTieuKhachHang.Rows[e.RowIndex].Cells["cChonTatCaBVKH"].Value = true;
            }
        }

        private void dgrBVMucTieuVanHanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgrBVMucTieuVanHanh.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dgrBVMucTieuVanHanh.Columns.Count)
            {
                if (dgrBVMucTieuVanHanh.Rows[e.RowIndex].Cells["cChonTatCaBVVH"].Value != null && (bool)dgrBVMucTieuVanHanh.Rows[e.RowIndex].Cells["cChonTatCaBVVH"].Value == true)
                {
                    LoadDataTableVH();
                    dgrBVMucTieuVanHanh.Rows[e.RowIndex].Cells["cChonTatCaBVVH"].Value = false;
                    return;
                }
                LoadDataTableVH();
                dgrBVMucTieuVanHanh.Rows[e.RowIndex].Cells["cChonTatCaBVVH"].Value = true;
            }
        }
        private void dgrBVMucTieuPhatTrien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgrBVMucTieuPhatTrien.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dgrBVMucTieuPhatTrien.Columns.Count)
            {
                if (dgrBVMucTieuPhatTrien.Rows[e.RowIndex].Cells["cChonTatCaBVPT"].Value != null && (bool)dgrBVMucTieuPhatTrien.Rows[e.RowIndex].Cells["cChonTatCaBVPT"].Value == true)
                {
                    LoadDataTablePT();
                    dgrBVMucTieuPhatTrien.Rows[e.RowIndex].Cells["cChonTatCaBVPT"].Value = false;
                    return;
                }
                LoadDataTablePT();
                dgrBVMucTieuPhatTrien.Rows[e.RowIndex].Cells["cChonTatCaBVPT"].Value = true;
            }
        }
        //
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
        private void dgrNhapMucTieuVanHanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgrNhapMucTieuVanHanh.Rows.Count && e.ColumnIndex == 0)
            {
                foreach (DataGridViewRow row in dgrBVMucTieuVanHanh.Rows)
                {
                    if (dgrNhapMucTieuVanHanh.Rows[e.RowIndex].Cells["cMaKPINVH"].Value.ToString() == row.Cells["cMaKPIBVVH"].Value.ToString())
                    {
                        row.Cells["cChonTatCaBVVH"].Value = false;
                        break;
                    }
                }
                LoadDataTableVH();
            }
        }
        private void dgrNhapMucTieuPhatTrien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgrNhapMucTieuPhatTrien.Rows.Count && e.ColumnIndex == 0)
            {
                foreach (DataGridViewRow row in dgrBVMucTieuPhatTrien.Rows)
                {
                    if (dgrNhapMucTieuPhatTrien.Rows[e.RowIndex].Cells["cMaKPINPT"].Value.ToString() == row.Cells["cMaKPIBVPT"].Value.ToString())
                    {
                        row.Cells["cChonTatCaBVPT"].Value = false;
                        break;
                    }
                }
                LoadDataTablePT();
            }
        }
        //CellValueChanged
        private void dgrNhapMucTieuTaiChinh_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ReturnDataTableTC(); 
        }
        private void dgrNhapMucTieuKhachHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ReturnDataTableKH();
        }

        private void dgrNhapMucTieuVanHanh_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ReturnDataTableVH();
        }

        private void dgrNhapMucTieuPhatTrien_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ReturnDataTablePT();
        }
        //CellValidating
        private void dgrNhapMucTieuKhachHang_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == dgrNhapMucTieuKhachHang.Columns["cTrongSoKPINKH"].Index)
            {
                string userInput = e.FormattedValue.ToString();
                int parsedValue;

                if (!int.TryParse(userInput, out parsedValue))
                {
                    ev.QFrmThongBaoError("Chỉ được nhập số không nhận chữ cái");
                    dgrNhapMucTieuKhachHang.CancelEdit();
                }
                else
                {
                    if (parsedValue < 0 || parsedValue > 100)
                    {
                        ev.QFrmThongBaoError("Số nhập vào phải nằm trong khoảng từ 0 đến 100");
                        dgrNhapMucTieuKhachHang.CancelEdit();
                    }
                }
            }
            if (e.ColumnIndex == dgrNhapMucTieuKhachHang.Columns["cKeHoachNKH"].Index)
            {
                try
                {
                    string chitieu = dgrNhapMucTieuKhachHang.CurrentRow.Cells["cChiTieuKPINKH"].Value.ToString();

                    if (chitieu.Contains("dd/mm/yyyy") || chitieu.Contains("dd/MM/yyyy"))
                    {
                        string userInput = e.FormattedValue.ToString();
                        DateTime dttc;

                        if (!DateTime.TryParseExact(userInput, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dttc))
                        {
                            ev.QFrmThongBaoError("Nhập sai định dạng ngày tháng (dd/MM/yyyy)");
                            dgrNhapMucTieuKhachHang.CancelEdit();
                            dgrNhapMucTieuKhachHang.CurrentRow.Cells["cKeHoachNKH"].Value = "";
                        }
                        else if (dttc < DateTime.MinValue || dttc > DateTime.MaxValue)
                        {
                            ev.QFrmThongBaoError("Ngày giờ nhập vào không hợp lệ");
                            dgrNhapMucTieuKhachHang.CancelEdit();
                            dgrNhapMucTieuKhachHang.CurrentRow.Cells["cKeHoachNKH"].Value = "";
                        }
                        else
                        {
                            // Set the appropriate value for the "cKeHoachNKH" column if needed.
                            dgrNhapMucTieuKhachHang.CurrentRow.Cells["cKeHoachNKH"].Value = userInput;
                        }
                    }
                    else
                    {
                        string userInput = e.FormattedValue.ToString();
                        int parsedValue;

                        if (!int.TryParse(userInput, out parsedValue))
                        {
                            ev.QFrmThongBaoError("Chỉ được nhập số");
                            dgrNhapMucTieuKhachHang.CancelEdit();
                            dgrNhapMucTieuKhachHang.CurrentRow.Cells["cKeHoachNKH"].Value = 0; // Or another default value.
                        }
                        else if (parsedValue < 0 || parsedValue > 100)
                        {
                            ev.QFrmThongBaoError("Số nhập vào phải nằm trong khoảng từ 0 đến 100");
                            dgrNhapMucTieuKhachHang.CancelEdit();
                            dgrNhapMucTieuKhachHang.CurrentRow.Cells["cKeHoachNKH"].Value = 0; // Or another default value.
                        }
                        else
                        {
                            // Set the appropriate value for the "cKeHoachNKH" column if needed.
                            dgrNhapMucTieuKhachHang.CurrentRow.Cells["cKeHoachNKH"].Value = parsedValue;
                        }
                    }
                }
                catch (Exception)
                {
                    ev.QFrmThongBaoError("Sai định dạng hoặc không có dữ liệu");
                }
            }

        }
        private void dgrNhapMucTieuVanHanh_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == dgrNhapMucTieuVanHanh.Columns["cTrongSoKPINVH"].Index)
            {
                string userInput = e.FormattedValue.ToString();
                int parsedValue;

                if (!int.TryParse(userInput, out parsedValue))
                {
                    ev.QFrmThongBaoError("Chỉ được nhập số không nhận chữ cái");
                    dgrNhapMucTieuVanHanh.CancelEdit();
                }
                else
                {
                    if (parsedValue < 0 || parsedValue > 100)
                    {
                        ev.QFrmThongBaoError("Số nhập vào phải nằm trong khoảng từ 0 đến 100");
                        dgrNhapMucTieuVanHanh.CancelEdit();
                    }
                }
            }
            if (e.ColumnIndex == dgrNhapMucTieuVanHanh.Columns["cKeHoachNVH"].Index)
            {
                try
                {
                    string chitieu = dgrNhapMucTieuVanHanh.CurrentRow.Cells["cChiTieuKPINVH"].Value.ToString();

                    if (chitieu.Contains("dd/mm/yyyy") || chitieu.Contains("dd/MM/yyyy"))
                    {
                        string userInput = e.FormattedValue.ToString();
                        DateTime dttc;

                        if (!DateTime.TryParseExact(userInput, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dttc))
                        {
                            ev.QFrmThongBaoError("Nhập sai định dạng ngày tháng (dd/MM/yyyy)");
                            dgrNhapMucTieuVanHanh.CancelEdit();
                            dgrNhapMucTieuVanHanh.CurrentRow.Cells["cKeHoachNVH"].Value = "";
                        }
                        else if (dttc < DateTime.MinValue || dttc > DateTime.MaxValue)
                        {
                            ev.QFrmThongBaoError("Ngày giờ nhập vào không hợp lệ");
                            dgrNhapMucTieuVanHanh.CancelEdit();
                            dgrNhapMucTieuVanHanh.CurrentRow.Cells["cKeHoachNVH"].Value = "";
                        }
                        else
                        {
                            // Set the appropriate value for the "cKeHoachNVH" column if needed.
                            dgrNhapMucTieuVanHanh.CurrentRow.Cells["cKeHoachNVH"].Value = userInput;
                        }
                    }
                    else
                    {
                        string userInput = e.FormattedValue.ToString();
                        int parsedValue;

                        if (!int.TryParse(userInput, out parsedValue))
                        {
                            ev.QFrmThongBaoError("Chỉ được nhập số");
                            dgrNhapMucTieuVanHanh.CancelEdit();
                            dgrNhapMucTieuVanHanh.CurrentRow.Cells["cKeHoachNVH"].Value = 0; // Or another default value.
                        }
                        else if (parsedValue < 0 || parsedValue > 100)
                        {
                            ev.QFrmThongBaoError("Số nhập vào phải nằm trong khoảng từ 0 đến 100");
                            dgrNhapMucTieuVanHanh.CancelEdit();
                            dgrNhapMucTieuVanHanh.CurrentRow.Cells["cKeHoachNVH"].Value = 0; // Or another default value.
                        }
                        else
                        {
                            // Set the appropriate value for the "cKeHoachNVH" column if needed.
                            dgrNhapMucTieuVanHanh.CurrentRow.Cells["cKeHoachNVH"].Value = parsedValue;
                        }
                    }
                }
                catch (Exception)
                {
                    ev.QFrmThongBaoError("Sai định dạng hoặc không có dữ liệu");
                }
            }

        }

        private void dgrNhapMucTieuPhatTrien_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == dgrNhapMucTieuPhatTrien.Columns["cTrongSoKPINPT"].Index)
            {
                string userInput = e.FormattedValue.ToString();
                int parsedValue;

                if (!int.TryParse(userInput, out parsedValue))
                {
                    ev.QFrmThongBaoError("Chỉ được nhập số không nhận chữ cái");
                    dgrNhapMucTieuPhatTrien.CancelEdit();
                }
                else
                {
                    if (parsedValue < 0 || parsedValue > 100)
                    {
                        ev.QFrmThongBaoError("Số nhập vào phải nằm trong khoảng từ 0 đến 100");
                        dgrNhapMucTieuPhatTrien.CancelEdit();
                    }
                }
            }
            if (e.ColumnIndex == dgrNhapMucTieuPhatTrien.Columns["cKeHoachNPT"].Index)
            {
                try
                {
                    string chitieu = dgrNhapMucTieuPhatTrien.CurrentRow.Cells["cChiTieuKPINPT"].Value.ToString();

                    if (chitieu.Contains("dd/mm/yyyy") || chitieu.Contains("dd/MM/yyyy"))
                    {
                        string userInput = e.FormattedValue.ToString();
                        DateTime dttc;

                        if (!DateTime.TryParseExact(userInput, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dttc))
                        {
                            ev.QFrmThongBaoError("Nhập sai định dạng ngày tháng (dd/MM/yyyy)");
                            dgrNhapMucTieuPhatTrien.CancelEdit();
                            dgrNhapMucTieuPhatTrien.CurrentRow.Cells["cKeHoachNPT"].Value = "";
                        }
                        else if (dttc < DateTime.MinValue || dttc > DateTime.MaxValue)
                        {
                            ev.QFrmThongBaoError("Ngày giờ nhập vào không hợp lệ");
                            dgrNhapMucTieuPhatTrien.CancelEdit();
                            dgrNhapMucTieuPhatTrien.CurrentRow.Cells["cKeHoachNPT"].Value = "";
                        }
                        else
                        {
                            // Set the appropriate value for the "cKeHoachNPT" column if needed.
                            dgrNhapMucTieuPhatTrien.CurrentRow.Cells["cKeHoachNPT"].Value = userInput;
                        }
                    }
                    else
                    {
                        string userInput = e.FormattedValue.ToString();
                        int parsedValue;

                        if (!int.TryParse(userInput, out parsedValue))
                        {
                            ev.QFrmThongBaoError("Chỉ được nhập số");
                            dgrNhapMucTieuPhatTrien.CancelEdit();
                            dgrNhapMucTieuPhatTrien.CurrentRow.Cells["cKeHoachNPT"].Value = 0; // Or another default value.
                        }
                        else if (parsedValue < 0 || parsedValue > 100)
                        {
                            ev.QFrmThongBaoError("Số nhập vào phải nằm trong khoảng từ 0 đến 100");
                            dgrNhapMucTieuPhatTrien.CancelEdit();
                            dgrNhapMucTieuPhatTrien.CurrentRow.Cells["cKeHoachNPT"].Value = 0; // Or another default value.
                        }
                        else
                        {
                            // Set the appropriate value for the "cKeHoachNPT" column if needed.
                            dgrNhapMucTieuPhatTrien.CurrentRow.Cells["cKeHoachNPT"].Value = parsedValue;
                        }
                    }
                }
                catch (Exception)
                {
                    ev.QFrmThongBaoError("Sai định dạng hoặc không có dữ liệu");
                }
            }

        }

        //CellEndEdit
        private void dgrNhapMucTieuTaiChinh_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgrNhapMucTieuTaiChinh.Rows[e.RowIndex].ErrorText = string.Empty;

        }
        private void dgrNhapMucTieuKhachHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgrNhapMucTieuKhachHang.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        private void dgrNhapMucTieuVanHanh_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgrNhapMucTieuVanHanh.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        private void dgrNhapMucTieuPhatTrien_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgrNhapMucTieuPhatTrien.Rows[e.RowIndex].ErrorText = string.Empty;
        }
        //MouseClick
        private void dgrBVMucTieuTaiChinh_MouseClick(object sender, MouseEventArgs e)
        {
            updateTimer.Start();
        }
        private void dgrBVMucTieuKhachHang_MouseClick(object sender, MouseEventArgs e)
        {
            updateTimer.Start();
        }
        private void dgrBVMucTieuVanHanh_MouseClick(object sender, MouseEventArgs e)
        {
            updateTimer.Start();
        }
        private void dgrBVMucTieuPhatTrien_MouseClick(object sender, MouseEventArgs e)
        {
            updateTimer.Start();
        }
        //MouseLeave
        private void dgrBVMucTieuTaiChinh_MouseLeave(object sender, EventArgs e)
        {
            updateTimer.Stop();
        }
        private void dgrBVMucTieuKhachHang_MouseLeave(object sender, EventArgs e)
        {
            updateTimer.Stop();
        }
        private void dgrBVMucTieuVanHanh_MouseLeave(object sender, EventArgs e)
        {
            updateTimer.Stop();
        }
        private void dgrBVMucTieuPhatTrien_MouseLeave(object sender, EventArgs e)
        {
            updateTimer.Stop();
        }
        //RowPostPaint
        private void dgrBVMucTieuTaiChinh_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
       {
            ev.Qdgr_RowPostPaint(sender, e, dgrBVMucTieuTaiChinh);
        }
        private void dgrBVMucTieuKhachHang_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrBVMucTieuKhachHang);
        }
        private void dgrBVMucTieuVanHanh_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrBVMucTieuVanHanh);
        }
        private void dgrBVMucTieuPhatTrien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrBVMucTieuPhatTrien);
        }
        private void dgrNhapMucTieuTaiChinh_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrNhapMucTieuTaiChinh);
        }
        private void dgrNhapMucTieuKhachHang_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrNhapMucTieuKhachHang);
        }
        private void dgrNhapMucTieuVanHanh_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrNhapMucTieuVanHanh);
        }
        private void dgrNhapMucTieuPhatTrien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrNhapMucTieuPhatTrien);
        }
        private void dgrHTMucTieuTaiChinh_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrHTMucTieuTaiChinh);
        }
        private void dgrHTMucTieuKhachHang_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrHTMucTieuKhachHang);
        }
        private void dgrHTMucTieuVanHanh_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrHTMucTieuVanHanh);
        }
        private void dgrHTMucTieuPhatTrien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrHTMucTieuPhatTrien);
        }
        //CellValidated
        private void dgrNhapMucTieuTaiChinh_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            TinhTrongSoKPITC();
            TinhTrongSoKPITC();     
        }
        private void dgrNhapMucTieuKhachHang_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            TinhTrongSoKPIKH();
            TinhTrongSoKPIKH();
        }
        private void dgrNhapMucTieuVanHanh_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            TinhTrongSoKPIVH();
            TinhTrongSoKPIVH();
        }
        private void dgrNhapMucTieuPhatTrien_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            TinhTrongSoKPIPT();
            TinhTrongSoKPIPT();
        }
        //ColumnHeaderMouseClick

        private void dgrBVMucTieuKhachHang_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.ColumnIndex == 0)
            {
                for (int i = 0; i < dgrBVMucTieuKhachHang.Rows.Count; i++)
                {
                    dgrBVMucTieuKhachHang.Rows[i].Cells["cChonTatCaBVKH"].Value = true;
                }
                LoadDataTableKH();
            }
        }
        private void dgrBVMucTieuVanHanh_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.ColumnIndex == 0)
            {
                for (int i = 0; i < dgrBVMucTieuVanHanh.Rows.Count; i++)
                {
                    dgrBVMucTieuVanHanh.Rows[i].Cells["cChonTatCaBVVH"].Value = true;
                }
                LoadDataTableVH();
            }
        }

        private void dgrBVMucTieuPhatTrien_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.ColumnIndex == 0)
            {
                for (int i = 0; i < dgrBVMucTieuPhatTrien.Rows.Count; i++)
                {
                    dgrBVMucTieuPhatTrien.Rows[i].Cells["cChonTatCaBVPT"].Value = true;
                }
                LoadDataTablePT();
            }
        }
        private void dgrNhapMucTieuKhachHang_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.ColumnIndex == 0)
            {
                for (int i = 0; i < dgrBVMucTieuKhachHang.Rows.Count; i++)
                {
                    dgrBVMucTieuKhachHang.Rows[i].Cells["cChonTatCaBVKH"].Value = false;
                }
                LoadDataTableKH();
            }
        }
        private void dgrNhapMucTieuVanHanh_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.ColumnIndex == 0)
            {
                for (int i = 0; i < dgrBVMucTieuVanHanh.Rows.Count; i++)
                {
                    dgrBVMucTieuVanHanh.Rows[i].Cells["cChonTatCaBVVH"].Value = false;
                }
                LoadDataTableVH();
            }
        }
        private void dgrNhapMucTieuPhatTrien_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.ColumnIndex == 0)
            {
                for (int i = 0; i < dgrBVMucTieuPhatTrien.Rows.Count; i++)
                {
                    dgrBVMucTieuPhatTrien.Rows[i].Cells["cChonTatCaBVPT"].Value = false;
                }
                LoadDataTablePT();
            }
        }
        //MouseHover
        private void dgrNhapMucTieuTaiChinh_MouseHover(object sender, EventArgs e)
        {
            updateTimer.Stop();
        }
        private void dgrNhapMucTieuKhachHang_MouseHover(object sender, EventArgs e)
        {
            updateTimer.Stop();
        }
        private void dgrNhapMucTieuVanHanh_MouseHover(object sender, EventArgs e)
        {
            updateTimer.Stop();
        }
        private void dgrNhapMucTieuPhatTrien_MouseHover(object sender, EventArgs e)
        {
            updateTimer.Stop();
        }
        #endregion

        #endregion

        #region Nhập và kiểm tra Kế hoạch 


        #endregion

        private void CreateTableCopyTC()
        {
            tc.Columns.Add("cMaKPIcpTC", typeof(string));
            tc.Columns.Add("cNoiDungcpTC", typeof(string));
            tc.Columns.Add("cKeHoachcpTC", typeof(string));
            tc.Columns.Add("cChiTieuKPIcpTC", typeof(string));
            tc.Columns.Add("TrongSocpTC", typeof(int));

            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = tc.Columns["cMaKPIcpTC"];
            tc.PrimaryKey = PrimaryKeyColumns;
        }
        private void LoadDataTableTC()
        {
            tc.Rows.Clear();
            for (int i = 0; i < dgrBVMucTieuTaiChinh.Rows.Count; i++)
            {
                if (dgrBVMucTieuTaiChinh.Rows[i].Cells["cChonTatCaBVTC"].Value != null && (bool)dgrBVMucTieuTaiChinh.Rows[i].Cells["cChonTatCaBVTC"].Value == true)
                {
                    DataRow newRow = tc.NewRow();
                    newRow["cMaKPIcpTC"] = dgrBVMucTieuTaiChinh.Rows[i].Cells["cMaKPIBVTC"].Value;
                    newRow["cNoiDungcpTC"] = dgrBVMucTieuTaiChinh.Rows[i].Cells["cNoiDungBVTC"].Value.ToString();
                    newRow["cKeHoachcpTC"] = dgrBVMucTieuTaiChinh.Rows[i].Cells["cKeHoachBVTC"].Value.ToString();
                    newRow["cChiTieuKPIcpTC"] = dgrBVMucTieuTaiChinh.Rows[i].Cells["cChiTieuKPITC"].Value.ToString();

                    if (dgrBVMucTieuTaiChinh.Rows[i].Cells["cTrongSocpTC"].Value == null)
                    {
                        dgrBVMucTieuTaiChinh.Rows[i].Cells["cTrongSocpTC"].Value = "0";
                        newRow["TrongSocpTC"] = dgrBVMucTieuTaiChinh.Rows[i].Cells["cTrongSocpTC"].Value.ToString();
                    }
                    else
                        newRow["TrongSocpTC"] = dgrBVMucTieuTaiChinh.Rows[i].Cells["cTrongSocpTC"].Value.ToString();
                        tc.Rows.Add(newRow);
                }
            }

            dgrNhapMucTieuTaiChinh.DataSource = tc;

            // After loading the DataTable, call ReplaceBVTC
        }
        private void ReturnDataTableTC()
        {

            for (int i = 0; i < dgrNhapMucTieuTaiChinh.Rows.Count; i++)
            {
                string value = dgrNhapMucTieuTaiChinh.Rows[i].Cells["cTrongSoKPINTC"].Value.ToString().Trim();
                foreach (DataRow row in tc.Rows)
                {
                    String id = Convert.ToString(row["cMaKPIcpTC"]);
                    if (id == Convert.ToString(dgrNhapMucTieuTaiChinh.Rows[i].Cells["cMaKPINTC"].Value))
                    {
                        row["TrongSocpTC"] = value;
                    }
                }
            }
            dgrNhapMucTieuTaiChinh.DataSource = tc;
            for (int j = 0; j < dgrBVMucTieuTaiChinh.Rows.Count; j++)
            {
                foreach (DataRow row in tc.Rows)
                {
                    String id = Convert.ToString(row["cMaKPIcpTC"]);
                    if (id == Convert.ToString(dgrBVMucTieuTaiChinh.Rows[j].Cells["cMaKPIBVTC"].Value))
                    {
                        dgrBVMucTieuTaiChinh.Rows[j].Cells["cTrongSocpTC"].Value = row["TrongSocpTC"].ToString();
                    }
                }
            }
        }
        private void dgrBVMucTieuTaiChinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgrBVMucTieuTaiChinh.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dgrBVMucTieuTaiChinh.Columns.Count)
            {
                if (dgrBVMucTieuTaiChinh.Rows[e.RowIndex].Cells["cChonTatCaBVTC"].Value != null && (bool)dgrBVMucTieuTaiChinh.Rows[e.RowIndex].Cells["cChonTatCaBVTC"].Value == true)
                {
                    LoadDataTableTC();
                    dgrBVMucTieuTaiChinh.Rows[e.RowIndex].Cells["cChonTatCaBVTC"].Value = false;
                    return;
                }
                LoadDataTableTC();
                dgrBVMucTieuTaiChinh.Rows[e.RowIndex].Cells["cChonTatCaBVTC"].Value = true;
            }
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
        private void dgrNhapMucTieuTaiChinh_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //Thay đổi nội dung  của Trọng số 
            if (e.ColumnIndex == dgrNhapMucTieuTaiChinh.Columns["cTrongSoKPINTC"].Index)
            {
                string userInput = e.FormattedValue.ToString();
                int parsedValue;

                if (!int.TryParse(userInput, out parsedValue))
                {
                    ev.QFrmThongBaoError("Chỉ được nhập số không nhận chữ cái");
                    dgrNhapMucTieuTaiChinh.CancelEdit();
                }
                else
                {
                    if (parsedValue < 0 || parsedValue > 100)
                    {
                        ev.QFrmThongBaoError("Số nhập vào phải nằm trong khoảng từ 0 đến 100");
                        dgrNhapMucTieuTaiChinh.CancelEdit();
                    }
                }
            }
            if (e.ColumnIndex == dgrNhapMucTieuTaiChinh.Columns["cKeHoachNTC"].Index)
            {
                try
                {
                    ReplaceNTC(false);
                    string chitieu = dgrNhapMucTieuTaiChinh.CurrentRow.Cells["cChiTieuKPINTC"].Value.ToString();

                    if (chitieu.Contains("dd/mm/yyyy") || chitieu.Contains("dd/MM/yyyy"))
                    {
                        string userInput = e.FormattedValue.ToString();
                        DateTime dttc;

                        if (!DateTime.TryParseExact(userInput, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dttc))
                        {
                            ev.QFrmThongBaoError("Nhập sai định dạng ngày tháng (dd/MM/yyyy)");
                            dgrNhapMucTieuTaiChinh.CancelEdit();
                            dgrNhapMucTieuTaiChinh.CurrentRow.Cells["cKeHoachNTC"].Value = DateTime.Now.ToString("dd-MM-yyyy");
                        }
                        else if (dttc < DateTime.MinValue || dttc > DateTime.MaxValue)
                        {
                            ev.QFrmThongBaoError("Ngày giờ nhập vào không hợp lệ");
                            dgrNhapMucTieuTaiChinh.CancelEdit();
                            dgrNhapMucTieuTaiChinh.CurrentRow.Cells["cKeHoachNTC"].Value = DateTime.Now.ToString("dd-MM-yyyy");
                        }
                        else
                        {
                            // Set the appropriate value for the "cKeHoachNTC" column if needed.
                            dgrNhapMucTieuTaiChinh.CurrentRow.Cells["cKeHoachNTC"].Value = userInput;
                        }
                        ReplaceNTC(true);
                    }
                    else
                    {
                        string userInput = e.FormattedValue.ToString();
                        int parsedValue;

                        if (!int.TryParse(userInput, out parsedValue))
                        {
                            ev.QFrmThongBaoError("Chỉ được nhập số");
                            dgrNhapMucTieuTaiChinh.CancelEdit();
                            dgrNhapMucTieuTaiChinh.CurrentRow.Cells["cKeHoachNTC"].Value = 0; // Or another default value.
                        }
                        else if (parsedValue < 0 || parsedValue > 100)
                        {
                            ev.QFrmThongBaoError("Số nhập vào phải nằm trong khoảng từ 0 đến 100");
                            dgrNhapMucTieuTaiChinh.CancelEdit();
                            dgrNhapMucTieuTaiChinh.CurrentRow.Cells["cKeHoachNTC"].Value = 0; // Or another default value.
                        }
                        else
                        {
                            // Set the appropriate value for the "cKeHoachNTC" column if needed.
                            dgrNhapMucTieuTaiChinh.CurrentRow.Cells["cKeHoachNTC"].Value = parsedValue;
                        }
                    }
                }
                catch (Exception)
                {
                    ev.QFrmThongBaoError("Sai định dạng hoặc không có dữ liệu");
                }
            }
        }
        private void dgrBVMucTieuTaiChinh_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.ColumnIndex == 0)
            {
                for (int i = 0; i < dgrBVMucTieuTaiChinh.Rows.Count; i++)
                {
                    dgrBVMucTieuTaiChinh.Rows[i].Cells["cChonTatCaBVTC"].Value = true;
                }
                LoadDataTableTC();
            }
        }
        private void dgrNhapMucTieuTaiChinh_ColumnHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.ColumnIndex == 0)
            {
                for (int i = 0; i < dgrBVMucTieuTaiChinh.Rows.Count; i++)
                {
                    dgrBVMucTieuTaiChinh.Rows[i].Cells["cChonTatCaBVTC"].Value = false;
                }
                LoadDataTableTC();
            }
        }
        private void ReplaceBVTC(bool Replace)
        {
            if (Replace)
            {
                try
                {
                    foreach (DataGridViewRow row in dgrBVMucTieuTaiChinh.Rows)
                    {
                        string noiDung = row.Cells["cNoiDungBVTC"].Value.ToString();

                        if (noiDung.Contains(" X ") || noiDung.Contains(" X%"))
                        {
                            // Replace the value only if the condition is met
                            noiDung = noiDung.Replace("X", row.Cells["cKeHoachBVTC"].Value.ToString().Trim());
                        }
                        else if (noiDung.Contains("dd/mm/yyyy"))
                        {
                            // Replace the value only if the condition is met
                            noiDung = noiDung.Replace("dd/mm/yyyy", row.Cells["cKeHoachBVTC"].Value.ToString().Trim());
                        }
                        row.Cells["cNoiDungBVTC"].Value = noiDung;
                    }
                }
                catch (Exception)
                {
                    ev.QFrmThongBaoError("Không có dữ liệu Kế Hoạch");
                }
            }
            else
            {
                // Example: assuming originalValues is a List<string>
                List<string> originalValues = new List<string>(); // Replace with your initialization

                // Code for restoring to the original state
                foreach (DataGridViewRow row in dgrBVMucTieuTaiChinh.Rows)
                {
                    int rowIndex = row.Index;

                    if (rowIndex >= 0 && rowIndex < originalValues.Count)
                    {
                        row.Cells["cNoiDungBVTC"].Value = originalValues[rowIndex];
                    }
                    else
                    {
                        // Handle the case where the index is out of range
                        // You may want to log or display an error message
                    }
                }
            }
        }
        private void ReplaceNTC(bool Replace)
        {
            if (Replace)
            {
                try
                {
                    foreach (DataGridViewRow row in dgrNhapMucTieuTaiChinh.Rows)
                    {
                        string noiDung = row.Cells["cNoiDungNTC"].Value.ToString();
                        if (noiDung.Contains(" X ") || noiDung.Contains(" X%"))
                        {
                            // Replace the value only if the condition is met
                            noiDung = noiDung.Replace("X", row.Cells["cKeHoachNTC"].Value.ToString().Trim());
                        }
                        else if (noiDung.Contains("dd/mm/yyyy"))
                        {
                            // Replace the value only if the condition is met
                            noiDung = noiDung.Replace("dd/mm/yyyy", row.Cells["cKeHoachNTC"].Value.ToString().Trim());
                        }
                        row.Cells["cNoiDungNTC"].Value = noiDung;
                    }
                }
                catch (Exception)
                {
                    ev.QFrmThongBaoError("Không có dữ liệu Kế Hoạch");
                }
            }
            else
            {

            }
        }

        private void dgrHTMucTieuTaiChinh_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView dataGridView;
            dataGridView = dgrHTMucTieuTaiChinh;
            if (e.ColumnIndex == dataGridView.Columns["cTrongSoKPIHTTC"].Index)
            {
                string userInput = e.FormattedValue.ToString();
                int parsedValue;

                if (!int.TryParse(userInput, out parsedValue))
                {
                    ev.QFrmThongBaoError("Chỉ được nhập số không nhận chữ cái");
                    dataGridView.CancelEdit();
                }
                else
                {
                    if (parsedValue < 0 || parsedValue > 100)
                    {
                        ev.QFrmThongBaoError("Số nhập vào phải nằm trong khoảng từ 0 đến 100");
                        dataGridView.CancelEdit();
                    }
                }
            }
            if (e.ColumnIndex == dataGridView.Columns["cKeHoachHTTC"].Index)
            {
                try
                {
                    string chitieu = dataGridView.CurrentRow.Cells["cChiTieuKPIHTTC"].Value.ToString();

                    if (chitieu.Contains("dd/mm/yyyy") || chitieu.Contains("dd/MM/yyyy"))
                    {
                        string userInput = e.FormattedValue.ToString();
                        DateTime dttc;

                        if (!DateTime.TryParseExact(userInput, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dttc))
                        {
                            ev.QFrmThongBaoError("Nhập sai định dạng ngày tháng (dd/MM/yyyy)");
                            dataGridView.CancelEdit();
                            dataGridView.CurrentRow.Cells["cKeHoachHTTC"].Value = "";
                        }
                        else if (dttc < DateTime.MinValue || dttc > DateTime.MaxValue)
                        {
                            ev.QFrmThongBaoError("Ngày giờ nhập vào không hợp lệ");
                            dataGridView.CancelEdit();
                            dataGridView.CurrentRow.Cells["cKeHoachHTTC"].Value = "";
                        }
                        else
                        {
                            // Set the appropriate value for the "cKeHoachNVH" column if needed.
                            dataGridView.CurrentRow.Cells["cKeHoachHTTC"].Value = userInput;
                        }
                    }
                    else
                    {
                        string userInput = e.FormattedValue.ToString();
                        int parsedValue;

                        if (!int.TryParse(userInput, out parsedValue))
                        {
                            ev.QFrmThongBaoError("Chỉ được nhập số");
                            dataGridView.CancelEdit();
                            dataGridView.CurrentRow.Cells["cKeHoachHTTC"].Value = 0; // Or another default value.
                        }
                        else if (parsedValue < 0 || parsedValue > 100)
                        {
                            ev.QFrmThongBaoError("Số nhập vào phải nằm trong khoảng từ 0 đến 100");
                            dataGridView.CancelEdit();
                            dataGridView.CurrentRow.Cells["cKeHoachHTTC"].Value = 0; // Or another default value.
                        }
                        else
                        {
                            // Set the appropriate value for the "cKeHoachNVH" column if needed.
                            dataGridView.CurrentRow.Cells["cKeHoachHTTC"].Value = parsedValue;
                        }
                    }
                }
                catch (Exception)
                {
                    ev.QFrmThongBaoError("Sai định dạng hoặc không có dữ liệu");
                }
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if(ev.QFrmThongBao_YesNo("Bạn có chắc muốn chỉnh sửa không?"))
            {
                dgrHTMucTieuTaiChinh.ReadOnly = false;
                dgrHTMucTieuTaiChinh.Columns["cKeHoachHTTC"].Visible = true;

                dgrHTMucTieuKhachHang.ReadOnly = false;
                dgrHTMucTieuKhachHang.Columns["cKeHoachHTKH"].Visible = true;

                dgrHTMucTieuVanHanh.ReadOnly = false;
                dgrHTMucTieuVanHanh.Columns["cKeHoachHTVH"].Visible = true;

                dgrHTMucTieuPhatTrien.ReadOnly = false;
                dgrHTMucTieuPhatTrien.Columns["cKeHoachHTPT"].Visible = true;
            }    
        }
        private void dtNgayLap_ValueChanged(object sender, EventArgs e)
        {
            if(dtNgayLap.Value < DateTime.Now || dtNgayLap.Value > DateTime.Now)
            {
                ev.QFrmThongBaoError("Ngày lập phải là ngày hiện tại không được thay đổi");
            }    
        }

        private void btnAddKPIKH_Click(object sender, EventArgs e)
        {
            DiemDenKPIThemVao(1);
            ChuyenTrangThai(5);
        }

        private void btnAddKPIVH_Click(object sender, EventArgs e)
        {
            DiemDenKPIThemVao(2);
            ChuyenTrangThai(5);
        }

        private void btnAddKPIPT_Click(object sender, EventArgs e)
        {
            DiemDenKPIThemVao(3);
            ChuyenTrangThai(5);
        }

        private void btnAddKPITC_Click(object sender, EventArgs e)
        {
            DiemDenKPIThemVao(0); 
            ChuyenTrangThai(5);
        }

        private void btnXacNhanGuiDi_Click(object sender, EventArgs e)
        {
            try
            {
                SaveTaiChinh();
                SaveKhachHang();
                SaveVanHanh();
                SavePhatTrien();
                SaveThongTinPhieu();
                ev.QFrmThongBao("Đã lưu thành công");
            }
            catch (Exception)
            {
                ev.QFrmThongBaoError("Đã có lỗi xảy ra trong quá trình lưu dữ liệu ");
            }
        }
        private void SaveTaiChinh()
        {
            for (int i = 0; i < dgrHTMucTieuTaiChinh.RowCount; i++) 
            {
                msql = "INSERT INTO [dbo].[ChiTietTieuChiMucTieuKhoaPhong]" +
                   "([MaPhieuKPIKP],[NoiDungKPI],[TrongSoTCKP],[TrongSoKPIKP],[KeHoach])" +
                   "VALUES('" + txtMaPhieu.Text + "',N'" + dgrHTMucTieuTaiChinh.Rows[i].Cells["cNoiDungHTTC"].Value.ToString() + "','" + int.Parse(txtTCHT.Text) + "','" +int.Parse(dgrHTMucTieuTaiChinh.Rows[i].Cells["cTrongSoKPIHTTC"].Value.ToString()) + "',N'" + dgrHTMucTieuTaiChinh.Rows[i].Cells["cKeHoachHTTC"].Value.ToString() + "')";
                comm.RunSQL(mconnectstring, msql);
            }
        }
        private void SaveKhachHang()
        {
            for (int i = 0; i < dgrHTMucTieuKhachHang.RowCount; i++)
            {
                msql = "INSERT INTO [dbo].[ChiTietTieuChiMucTieuKhoaPhong]" +
                   "([MaPhieuKPIKP],[NoiDungKPI],[TrongSoTCKP],[TrongSoKPIKP],[KeHoach])" +
                   "VALUES('" + txtMaPhieu.Text + "',N'" + dgrHTMucTieuKhachHang.Rows[i].Cells["cNoiDungHTKH"].Value.ToString() + "','" + int.Parse(txtKHHT.Text) + "','" + int.Parse(dgrHTMucTieuKhachHang.Rows[i].Cells["cTrongSoKPIHTKH"].Value.ToString()) + "',N'" + dgrHTMucTieuKhachHang.Rows[i].Cells["cKeHoachHTKH"].Value.ToString() + "')";
                comm.RunSQL(mconnectstring, msql);
            }
        }
        private void SaveVanHanh()
        {
            for (int i = 0; i < dgrHTMucTieuVanHanh.RowCount; i++)
            {
                msql = "INSERT INTO [dbo].[ChiTietTieuChiMucTieuKhoaPhong]" +
                   "([MaPhieuKPIKP],[NoiDungKPI],[TrongSoTCKP],[TrongSoKPIKP],[KeHoach])" +
                   "VALUES('" + txtMaPhieu.Text + "',N'" + dgrHTMucTieuVanHanh.Rows[i].Cells["cNoiDungHTVH"].Value.ToString() + "','" + int.Parse(txtVHHT.Text) + "','" + int.Parse(dgrHTMucTieuVanHanh.Rows[i].Cells["cTrongSoKPIHTVH"].Value.ToString()) + "',N'" + dgrHTMucTieuVanHanh.Rows[i].Cells["cKeHoachHTVH"].Value.ToString() + "')";
                comm.RunSQL(mconnectstring, msql);
            }
        }
        private void SavePhatTrien()
        {
            for (int i = 0; i < dgrHTMucTieuPhatTrien.RowCount; i++)
            {
                msql = "INSERT INTO [dbo].[ChiTietTieuChiMucTieuKhoaPhong]" +
                   "([MaPhieuKPIKP],[NoiDungKPI],[TrongSoTCKP],[TrongSoKPIKP],[KeHoach])" +
                   "VALUES('" + txtMaPhieu.Text + "',N'" + dgrHTMucTieuPhatTrien.Rows[i].Cells["cNoiDungHTPT"].Value.ToString() + "','" + int.Parse(txtPTHT.Text) + "','" + int.Parse(dgrHTMucTieuPhatTrien.Rows[i].Cells["cTrongSoKPIHTPT"].Value.ToString()) + "',N'" + dgrHTMucTieuPhatTrien.Rows[i].Cells["cKeHoachHTPT"].Value.ToString() + "')";
                comm.RunSQL(mconnectstring, msql);
            }
        }
        private void SaveThongTinPhieu()
        {
            msql = "INSERT INTO [dbo].[KPI_KhoaPhong] " +
                   "([MaPhieuKPIBV],[MaPhieuKPIKPCT],[MaPhieuKPIKP],[MaPK],[QuyNam],[NguoiLap],[NguoiPheDuyet],[NguoiXemXet],[NgayLapPhieuKPIKP],[NgayPheDuyet],[NgayXemXet],[IDBieuMau],[TrangThai])" +
                   "VALUES ('" + dgrBVMucTieuTaiChinh.CurrentRow.Cells["cMaPhieuKPIBVTC"].Value.ToString() + "','','" + txtMaPhieu.Text + "','" + MaPhongKhoa.ToString() + "','" + dtNgayLap.Value.ToString("yyyy") + "','" + MaNV.ToString() + "','','','" + dtNgayLap.Value.ToString("yyyy-MM-dd") + "','','',73,0)";
            comm.RunSQL(mconnectstring, msql);
        }
        #region Xử lí Thêm KPI bên ngoài vào Grid 
        private void LoadNganHangKPI()
        {
            bool congvieccanhannh = chkCongViecCaNhanNganHangKPI.Checked;
            string phuongdien = FrmA73.phuongdien;
            dgrKPIBenhVien.Visible = true;
            //dgrKPICaNhan.Visible = false;
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
        //private void LoadNganHangCaNhan()
        //{
        //    bool congvieccanhancn = chkCongViecCaNhanCaNhan.Checked;
        //    dgrKPIBenhVien.Visible = false;
        //    dgrKPICaNhan.Visible = true;
        //    chkCongViecCaNhanCaNhan.Visible = true;
        //    chkCongViecCaNhanNganHangKPI.Visible = false;
        //    string phuongdien = FrmA73.phuongdien;
        //    if (congvieccanhancn == true)
        //    {
        //        switch (phuongdien)
        //        {
        //            case "tc":
        //                msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'F' and [Nam] = " + nmYear.Value + " " +
        //                       "and [CongViecCaNhan] = '" + chkCongViecCaNhanNganHangKPI.Checked + "' and [CongViecCaNhan] = 1";
        //                DataTable tc = comm.GetDataTable(mconnectstring, msql, "KPINH");
        //                dgrKPICaNhan.AutoGenerateColumns = false;
        //                dgrKPICaNhan.DataSource = tc;
        //                break;
        //            case "kh":
        //                msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'C' and [Nam] = " + nmYear.Value + " " +
        //                       "and [CongViecCaNhan] = '" + chkCongViecCaNhanNganHangKPI.Checked + "' and [CongViecCaNhan] = 1";
        //                DataTable kh = comm.GetDataTable(mconnectstring, msql, "KPINH");
        //                dgrKPICaNhan.AutoGenerateColumns = false;
        //                dgrKPICaNhan.DataSource = kh;
        //                break;
        //            case "vh":
        //                msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'B' and [Nam] = " + nmYear.Value + " " +
        //                       "and [CongViecCaNhan] = '" + chkCongViecCaNhanNganHangKPI.Checked + "' and [CongViecCaNhan] = 1";
        //                DataTable vh = comm.GetDataTable(mconnectstring, msql, "KPINH");
        //                dgrKPICaNhan.AutoGenerateColumns = false;
        //                dgrKPICaNhan.DataSource = vh;
        //                break;
        //            case "pt":
        //                msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'L' and [Nam] = " + nmYear.Value + " " +
        //                       "and [CongViecCaNhan] = '" + chkCongViecCaNhanNganHangKPI.Checked + "' and [CongViecCaNhan] = 1";
        //                DataTable pt = comm.GetDataTable(mconnectstring, msql, "KPINH");
        //                dgrKPICaNhan.AutoGenerateColumns = false;
        //                dgrKPICaNhan.DataSource = pt;
        //                break;
        //        }
        //    }
        //    else if (congvieccanhancn == false)
        //    {
        //        switch (phuongdien)
        //        {
        //            case "tc":
        //                msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'F' and [Nam] = " + nmYear.Value + " " +
        //                       "and [CongViecCaNhan] = '" + chkCongViecCaNhanNganHangKPI.Checked + "'";
        //                DataTable tc = comm.GetDataTable(mconnectstring, msql, "KPINH");
        //                dgrKPICaNhan.AutoGenerateColumns = false;
        //                dgrKPICaNhan.DataSource = tc;
        //                break;
        //            case "kh":
        //                msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'C' and [Nam] = " + nmYear.Value + " " +
        //                       "and [CongViecCaNhan] = '" + chkCongViecCaNhanNganHangKPI.Checked + "'";
        //                DataTable kh = comm.GetDataTable(mconnectstring, msql, "KPINH");
        //                dgrKPICaNhan.AutoGenerateColumns = false;
        //                dgrKPICaNhan.DataSource = kh;
        //                break;
        //            case "vh":
        //                msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'B' and [Nam] = " + nmYear.Value + " " +
        //                       "and [CongViecCaNhan] = '" + chkCongViecCaNhanNganHangKPI.Checked + "'";
        //                DataTable vh = comm.GetDataTable(mconnectstring, msql, "KPINH");
        //                dgrKPICaNhan.AutoGenerateColumns = false;
        //                dgrKPICaNhan.DataSource = vh;
        //                break;
        //            case "pt":
        //                msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'L' and [Nam] = " + nmYear.Value + " " +
        //                       "and [CongViecCaNhan] = '" + chkCongViecCaNhanNganHangKPI.Checked + "'";
        //                DataTable pt = comm.GetDataTable(mconnectstring, msql, "KPINH");
        //                dgrKPICaNhan.AutoGenerateColumns = false;
        //                dgrKPICaNhan.DataSource = pt;
        //                break;
        //        }
        //    }
        //}
        private string BieuMau;
        bool t = false;
        private void dgrKPIBenhVien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrKPIBenhVien);
        }
        private void btnNganHangKPI_Click(object sender, EventArgs e)
        {
            btnTaoMoi.Visible = false;
            LoadNganHangKPI();
        }
        private void btnNganHangCaNhan_Click(object sender, EventArgs e)
        {
            //LoadNganHangCaNhan();
            btnTaoMoi.Visible = true;
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
            //LoadNganHangCaNhan();
        }
        private void DiemDenKPIThemVao(int _phuongdien)
        {
            switch (_phuongdien)
            {
                case 0:
                    txtTabTieuChi.Text = "Tài chính";
                    phuongdien = "tc";
                    break;
                case 1:
                    txtTabTieuChi.Text = "Khách hàng";
                    break;
                case 2:
                    txtTabTieuChi.Text = "Vận hành";
                    break;
                case 3:
                    txtTabTieuChi.Text = "Phát triển";
                    break;
            }
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            CopyDaTa();
        }
        private void CopyDaTa()
        {
            if (phuongdien == "tc")
            {
                dgrNhapMucTieuTaiChinh.Rows.Clear();
                // dgrNhapMucTieuTaiChinh.AllowUserToAddRows = true;
                for (int i = 0; i < dgrKPIBenhVien.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgrKPIBenhVien.Rows[i].Cells["cChonIAddBVTC"].Value) == true)
                    {
                        int n = dgrNhapMucTieuTaiChinh.Rows.Add();
                        //dataGridView1.Rows[n].Cells["cMaKPINTC"].Value = dgrKPIBenhVien.Rows[n].Cells["cMaKPIAddBVTC"].Value.ToString();
                        //dataGridView1.Rows[n].Cells["cNoiDungNTC"].Value = dgrKPIBenhVien.Rows[n].Cells["cNoiDungIAddBVTC"].Value.ToString();
                        //dataGridView1.Rows[n].Cells["cKeHoachNTC"].Value = dgrKPIBenhVien.Rows[n].Cells["cNoiDungIAddBVTC"].Value.ToString();
                        //dataGridView1.Rows[n].Cells["cChiTieuKPINTC"].Value = dgrKPIBenhVien.Rows[n].Cells["cChiTieuIAddBVTC"].Value.ToString();

                        dgrNhapMucTieuTaiChinh.Rows[n].Cells[1].Value = dgrKPIBenhVien.Rows[n].Cells[1].Value.ToString();
                        dgrNhapMucTieuTaiChinh.Rows[n].Cells[2].Value = dgrKPIBenhVien.Rows[n].Cells[2].Value.ToString();
                        dgrNhapMucTieuTaiChinh.Rows[n].Cells[3].Value = "";
                        dgrNhapMucTieuTaiChinh.Rows[n].Cells[4].Value = dgrKPIBenhVien.Rows[n].Cells[6].Value.ToString();
                        dgrNhapMucTieuTaiChinh.Rows[n].Cells[4].Value = "";
                        
                    }
                }
            }
        }
        #endregion


    }
}