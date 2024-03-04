 using BusinessCommon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn_QuanLyKPI.GUI
{
    public partial class Frm_A71 : DevExpress.XtraEditors.XtraForm
    {
        private static string mconnecstring = Frm_Chinh_GUI.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs(string.Empty);
        private string msql;

        private int CurrentTab;
        public static string MaNV = Frm_Login.MaNV;
        public static string MaPhongKhoa = Frm_Login.MaPhongKhoa;
        public static string MaChucDanh = Frm_Login.MaChucDanh;
        public static string TenNV = Frm_Login.TenNV;
        public static string TenChucDanh = Frm_Login.TenChucDanh;
        public static string TenPhongKhoa = Frm_Login.TenPhongKhoa;
        private static string NamPhieu = FrmChonBieuMau.Nam;
        Timer updateTimer;
        DataTable tc = new DataTable();
        DataTable kh = new DataTable();
        DataTable vh = new DataTable();
        DataTable pt = new DataTable();


        public Frm_A71()
        {
            InitializeComponent();
            LoadTaiChinh();
            LoadPhatTrien();
            LoadVanHanh();
            LoadKhachHang();
            CreateTableCopyTC();
            updateTimer = new Timer { Interval = 100 };
            updateTimer.Tick += UpdateTimer_Tick;

        }
        #region LoadDataGridview
        private void LoadTaiChinh()
        {
            msql = "SELECT dbo.KPI.*, dbo.NhomTieuChi.TenTieuChi FROM dbo.KPI INNER JOIN dbo.NhomTieuChi ON dbo.KPI.TieuChiID = dbo.NhomTieuChi.TieuChiID AND dbo.KPI.TieuChiID = 'F'";
            DataTable tb = comm.GetDataTable(mconnecstring, msql, "TaiChinh");
            dgrBVMucTieuTaiChinh.AutoGenerateColumns = false;
            dgrBVMucTieuTaiChinh.DataSource = tb;
        }
        private void LoadKhachHang()
        {
            msql = "SELECT dbo.KPI.*, dbo.NhomTieuChi.TenTieuChi FROM dbo.KPI INNER JOIN dbo.NhomTieuChi ON dbo.KPI.TieuChiID = dbo.NhomTieuChi.TieuChiID AND dbo.KPI.TieuChiID = 'C'";
            DataTable tb = comm.GetDataTable(mconnecstring, msql, "KhachHang");
            dgrBVMucTieuKhachHang.AutoGenerateColumns = false;
            dgrBVMucTieuKhachHang.DataSource = tb;
        }
        private void LoadVanHanh()
        {
            msql = "SELECT dbo.KPI.*, dbo.NhomTieuChi.TenTieuChi FROM dbo.KPI INNER JOIN dbo.NhomTieuChi ON dbo.KPI.TieuChiID = dbo.NhomTieuChi.TieuChiID AND dbo.KPI.TieuChiID = 'B'";
            DataTable tb = comm.GetDataTable(mconnecstring, msql, "VanHanh");
            dgrBVMucTieuVanHanh.AutoGenerateColumns = false;
            dgrBVMucTieuVanHanh.DataSource = tb;
        }
        private void LoadPhatTrien()
        {
            msql = "SELECT dbo.KPI.*, dbo.NhomTieuChi.TenTieuChi FROM dbo.KPI INNER JOIN dbo.NhomTieuChi ON dbo.KPI.TieuChiID = dbo.NhomTieuChi.TieuChiID AND dbo.KPI.TieuChiID = 'L'";
            DataTable tb = comm.GetDataTable(mconnecstring, msql, "PhatTrien");
            dgrBVMucTieuPhatTrien.AutoGenerateColumns = false;
            dgrBVMucTieuPhatTrien.DataSource =  tb;
        }

        #endregion

        #region LoadTrangThai
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
                    break;
                case 1:
                    tabMucTieuKhoaPhong.SelectTab(step);
                    // Thiết lập Trạng thái khi nhất nút
                    spTaiChinhKH.State = StepProgressBarItemState.Active;
                    FrmSPTrangThaiKH.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage = svgImageCollection1[0];
                    FrmSPTrangThaiKH.Appearances.CommonActiveColor = Color.Green;
                    FrmSPTrangThaiKH.Items[step - 1].ContentBlock2.Caption = "Đã xong Tài Chính";
                    LoadKhachHang();
                    break;
                case 2:
                    tabMucTieuKhoaPhong.SelectTab(step);
                    //Thiết lập Trạng thái khi nhất nút
                    spKhachHangVH.State = StepProgressBarItemState.Active;
                    FrmSPTrangThaiVH.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage = svgImageCollection1[0];
                    FrmSPTrangThaiVH.Appearances.CommonActiveColor = Color.Green;
                    FrmSPTrangThaiVH.Items[step - 1].ContentBlock2.Caption = "Đã xong Khách Hàng";
                    LoadVanHanh();
                    break;
                case 3:
                    tabMucTieuKhoaPhong.SelectTab(step);
                    //Thiết lập Trạng thái khi nhất nút
                    spVanHanhPT.State = StepProgressBarItemState.Active;
                    FrmSPTrangThaiPT.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage = svgImageCollection1[0];
                    FrmSPTrangThaiPT.Appearances.CommonActiveColor = Color.Green;
                    FrmSPTrangThaiPT.Items[step - 1].ContentBlock2.Caption = "Đã xong Vận Hành";
                    LoadPhatTrien();
                    break;
                case 4:
                    tabMucTieuKhoaPhong.SelectTab(step);
                    spPhatTrienHT.State = StepProgressBarItemState.Active;
                    FrmSPTrangThaiHT.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage = svgImageCollection1[0];
                    FrmSPTrangThaiHT.Appearances.CommonActiveColor = Color.Green;
                    FrmSPTrangThaiHT.Items[step - 1].ContentBlock2.Caption = "Đã xong Phát Triển";
                    break;
            }
        }
        #endregion
        #region Copydata
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            LoadDataTableTC();
            LoadDataTableKH();
        }
        #region 
        private void CreateTableCopyTC()
        {
            tc.Columns.Add("clMaKPICP", typeof(int));
            tc.Columns.Add("clNoiDungCP", typeof(string));
            tc.Columns.Add("clPhuongPhapDoCP", typeof(string));
            tc.Columns.Add("clDonViCP", typeof(string));
            tc.Columns.Add("clChiTieuCP", typeof(string));


            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = tc.Columns["clMaKPICP"];
            tc.PrimaryKey = PrimaryKeyColumns;

        }
        private void CreateTableCopyKH()
        {
            kh.Columns.Add("clMaKPICPKH", typeof(int));
            kh.Columns.Add("clNoiDungCPKH", typeof(string));
            kh.Columns.Add("clPhuongPhapDoCPKH", typeof(string));
            kh.Columns.Add("clDonViCPKH", typeof(string));
            kh.Columns.Add("clChiTieuCPKH", typeof(string));


            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = kh.Columns["clMaKPICPKH"];
            kh.PrimaryKey = PrimaryKeyColumns;

        }
        private void CreateTableCopyVH()
        {
            vh.Columns.Add("clMaKPICPVH", typeof(int));
            vh.Columns.Add("clNoiDungCPVH", typeof(string));
            vh.Columns.Add("clPhuongPhapDoCPVH", typeof(string));
            vh.Columns.Add("clDonViCPVH", typeof(string));
            vh.Columns.Add("clChiTieuCPVH", typeof(string));

            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = vh.Columns["clMaKPICPVH"];
            vh.PrimaryKey = PrimaryKeyColumns;
        }
        private void CreateTableCopyPT()
        {
            pt.Columns.Add("clMaKPICPPT", typeof(int));
            pt.Columns.Add("clNoiDungCPPT", typeof(string));
            pt.Columns.Add("clPhuongPhapDoCPPT", typeof(string));
            pt.Columns.Add("clDonViCPPT", typeof(string));
            pt.Columns.Add("clChiTieuCPPT", typeof(string));

            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = pt.Columns["clMaKPICPPT"];
            pt.PrimaryKey = PrimaryKeyColumns;
        }
        private void LoadDataTableTC()
        {
                tc.Rows.Clear();
                for (int i = 0; i < dgrBVMucTieuTaiChinh.Rows.Count; i++)
                {
                    if (dgrBVMucTieuTaiChinh.Rows[i].Cells["cChon"].Value != null && (bool)dgrBVMucTieuTaiChinh.Rows[i].Cells["cChon"].Value == true)
                    {
                        DataRow newRow = tc.NewRow();
                        newRow["clMaKPICP"] = dgrBVMucTieuTaiChinh.Rows[i].Cells["clMaKPI"].Value;
                        newRow["clNoiDungCP"] = dgrBVMucTieuTaiChinh.Rows[i].Cells["clNoiDung"].Value.ToString();
                        newRow["clPhuongPhapDoCP"] = dgrBVMucTieuTaiChinh.Rows[i].Cells["clPhuongPhapDo"].Value.ToString();
                        newRow["clDonViCP"] = dgrBVMucTieuTaiChinh.Rows[i].Cells["clDonVi"].Value.ToString();
                        newRow["clChiTieuCP"] = dgrBVMucTieuTaiChinh.Rows[i].Cells["clChiTieu"].Value.ToString();
                        tc.Rows.Add(newRow);
                    }
                }
                dgrNhapMucTieuTaiChinh.DataSource = tc;
        }
        private void LoadDataTableKH()
        {
                kh.Rows.Clear();
                for (int i = 0; i < dgrBVMucTieuKhachHang.Rows.Count; i++)
                {
                    if (dgrBVMucTieuKhachHang.Rows[i].Cells["cChonKH"].Value != null && (bool)dgrBVMucTieuKhachHang.Rows[i].Cells["cChonKH"].Value == true)
                    {
                        DataRow newRow = kh.NewRow();
                        newRow["clMaKPICPKH"] = dgrBVMucTieuKhachHang.Rows[i].Cells["clMaKPIKH"].Value;
                        newRow["clNoiDungCPKH"] = dgrBVMucTieuKhachHang.Rows[i].Cells["clNoiDungKH"].Value.ToString();
                        newRow["clPhuongPhapDoCPKH"] = dgrBVMucTieuKhachHang.Rows[i].Cells["clPhuongPhapDoKH"].Value.ToString();
                        newRow["clDonViCPKH"] = dgrBVMucTieuKhachHang.Rows[i].Cells["clDonViKH"].Value.ToString();
                        newRow["clChiTieuCPKH"] = dgrBVMucTieuKhachHang.Rows[i].Cells["clChiTieuKH"].Value.ToString();
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
                if (dgrBVMucTieuVanHanh.Rows[i].Cells["cChonVH"].Value != null && (bool)dgrBVMucTieuVanHanh.Rows[i].Cells["cChonVH"].Value == true)
                {
                    DataRow newRow = vh.NewRow();
                    newRow["clMaKPICPVH"] = dgrBVMucTieuVanHanh.Rows[i].Cells["clMaKPIVH"].Value;
                    newRow["clNoiDungCPVH"] = dgrBVMucTieuVanHanh.Rows[i].Cells["clNoiDungVH"].Value.ToString();
                    newRow["clPhuongPhapDoCPVH"] = dgrBVMucTieuVanHanh.Rows[i].Cells["clPhuongPhapDoVH"].Value.ToString();
                    newRow["clDonViCPVH"] = dgrBVMucTieuVanHanh.Rows[i].Cells["clDonViVH"].Value.ToString();
                    newRow["clChiTieuCPVH"] = dgrBVMucTieuVanHanh.Rows[i].Cells["clChiTieuVH"].Value.ToString();
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
                if (dgrBVMucTieuPhatTrien.Rows[i].Cells["cChonPT"].Value != null && (bool)dgrBVMucTieuPhatTrien.Rows[i].Cells["cChonPT"].Value == true)
                {
                    DataRow newRow = pt.NewRow();
                    newRow["clMaKPICPPT"] = dgrBVMucTieuPhatTrien.Rows[i].Cells["clMaKPIPT"].Value;
                    newRow["clNoiDungCPPT"] = dgrBVMucTieuPhatTrien.Rows[i].Cells["clNoiDungPT"].Value.ToString();
                    newRow["clPhuongPhapDoCPPT"] = dgrBVMucTieuPhatTrien.Rows[i].Cells["clPhuongPhapDoPT"].Value.ToString();
                    newRow["clDonViCPPT"] = dgrBVMucTieuPhatTrien.Rows[i].Cells["clDonViPT"].Value.ToString();
                    newRow["clChiTieuCPPT"] = dgrBVMucTieuPhatTrien.Rows[i].Cells["clChiTieuPT"].Value.ToString();
                    pt.Rows.Add(newRow);
                }
            }
            dgrNhapMucTieuPhatTrien.DataSource = pt;
        }

        private void CopyTCtoHT()
        {

            if (dgrNhapMucTieuTaiChinh.Rows.Count > 0)
            {
                dgrHTMucTieuTaiChinh.ColumnCount = dgrNhapMucTieuTaiChinh.ColumnCount;
                //foreach (DataGridViewColumn col in dgrNhapMucTieuTaiChinh.Columns)
                //{
                //    dgrHTMucTieuTaiChinh.Columns[col.Index].Name = col.Name;
                //}

                foreach (DataGridViewRow row in dgrNhapMucTieuTaiChinh.Rows)
                {
                    if (!row.IsNewRow)
                    {

                        DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                        newRow.Cells[0].Value = row.Cells["clMaKPIChon"].Value;
                        newRow.Cells[1].Value = row.Cells["clNoiDungChon"].Value;
                        newRow.Cells[2].Value = row.Cells["clPhuongPhapDoChon"].Value;
                        newRow.Cells[3].Value = row.Cells["clDonViChon"].Value;
                        newRow.Cells[4].Value = row.Cells["clChiTieuChon"].Value;
                        newRow.Cells[5].Value = row.Cells["clTrongSoKPIBVChon"].Value;
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
                //foreach (DataGridViewColumn col in dgrNhapMucTieuTaiChinh.Columns)
                //{
                //    dgrHTMucTieuTaiChinh.Columns[col.Index].Name = col.Name;
                //}

                foreach (DataGridViewRow row in dgrNhapMucTieuKhachHang.Rows)
                {
                    if (!row.IsNewRow)
                    {

                        DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                        newRow.Cells[0].Value = row.Cells["clMaKPINhapKH"].Value;
                        newRow.Cells[1].Value = row.Cells["clNoiDungNhapKH"].Value;
                        newRow.Cells[2].Value = row.Cells["clPhuongPhapDoNhapKH"].Value;
                        newRow.Cells[3].Value = row.Cells["clDonViNhapKH"].Value;
                        newRow.Cells[4].Value = row.Cells["clChiTieuNhapKH"].Value;
                        newRow.Cells[5].Value = row.Cells["clTrongSoKPINhapKH"].Value;
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
                //foreach (DataGridViewColumn col in dgrNhapMucTieuTaiChinh.Columns)
                //{
                //    dgrHTMucTieuTaiChinh.Columns[col.Index].Name = col.Name;
                //}

                foreach (DataGridViewRow row in dgrNhapMucTieuVanHanh.Rows)
                {
                    if (!row.IsNewRow)
                    {

                        DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                        newRow.Cells[0].Value = row.Cells["clMaKPINhapVH"].Value;
                        newRow.Cells[1].Value = row.Cells["clNoiDungNhapVH"].Value;
                        newRow.Cells[2].Value = row.Cells["clPhuongPhapDoNhapVH"].Value;
                        newRow.Cells[3].Value = row.Cells["clDonViNhapVH"].Value;
                        newRow.Cells[4].Value = row.Cells["clTieuChiNhapVH"].Value;
                        newRow.Cells[5].Value = row.Cells["clTrongSoKPIBVNhapVH"].Value;
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
                //foreach (DataGridViewColumn col in dgrNhapMucTieuTaiChinh.Columns)
                //{
                //    dgrHTMucTieuTaiChinh.Columns[col.Index].Name = col.Name;
                //}

                foreach (DataGridViewRow row in dgrNhapMucTieuPhatTrien.Rows)
                {
                    if (!row.IsNewRow)
                    {

                        DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                        newRow.Cells[0].Value = row.Cells["clMaKPINhapPT"].Value;
                        newRow.Cells[1].Value = row.Cells["clNoiDungNhapPT"].Value;
                        newRow.Cells[2].Value = row.Cells["clPhuongPhapDoNhapPT"].Value;
                        newRow.Cells[3].Value = row.Cells["clDonViNhapPT"].Value;
                        newRow.Cells[4].Value = row.Cells["clChiTieuNhapPT"].Value;
                        newRow.Cells[5].Value = row.Cells["clTrongSoKPIBVNhapPT"].Value;
                        dgrHTMucTieuPhatTrien.Rows.Add(newRow);
                    }
                }
            }
            else
            {
                ev.QFrmThongBao("Chưa có dữ liệu. Vui lòng nhập dữ liệu");
            }
        }
        private void KiemTraTyTrong(int step)
        {
            // Lấy tổng các giá trị trong các cột
            if (dgrNhapMucTieuTaiChinh.Rows.Count > 0)
            {
                bool checkNull = false;
                switch (step)
                {
                    case 1:
                        int rowdgrtc = dgrNhapMucTieuTaiChinh.Rows.Count;
                        int totaltc = 0;
                        for (int i = 0; i < rowdgrtc; ++i)
                        {
                            if(dgrNhapMucTieuTaiChinh.Rows[i].Cells["clTrongSoKPIBVChon"].Value != null)
                            {
                                totaltc += int.Parse(dgrNhapMucTieuTaiChinh.Rows[i].Cells["clTrongSoKPIBVChon"].Value.ToString());
                            }
                            else
                            {
                                ev.QFrmThongBaoError("Vui lòng nhập đủ thông tin.");
                                checkNull = true;
                                break;
                            }
                        }
                        if (!checkNull)
                        {
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
                                LoadKhachHang();
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

                        }
                        break;
                    case 2:
                        int rowdgrkh = dgrNhapMucTieuKhachHang.Rows.Count;
                        int totalkh = 0;
                        for (int i = 0; i < rowdgrkh; ++i)
                        {
                            if (dgrNhapMucTieuKhachHang.Rows[i].Cells["clTrongSoKPINhapKH"].Value != null)
                            {
                                totalkh += int.Parse(dgrNhapMucTieuKhachHang.Rows[i].Cells["clTrongSoKPINhapKH"].Value.ToString());
                            }
                            else
                            {
                                ev.QFrmThongBaoError("Vui lòng nhập đủ thông tin.");
                                checkNull = true;
                                break;
                            }
                        }
                        if (!checkNull)
                        {
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
                                LoadVanHanh();
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
                        }
                        break;
                    case 3:
                        int rowdgrvh = dgrNhapMucTieuVanHanh.Rows.Count;
                        int totalvh = 0;
                        for (int i = 0; i < rowdgrvh; ++i)
                        {
                            if (dgrNhapMucTieuVanHanh.Rows[i].Cells["clTrongSoKPIBVNhapVH"].Value != null)
                            {
                                totalvh += int.Parse(dgrNhapMucTieuVanHanh.Rows[i].Cells["clTrongSoKPIBVNhapVH"].Value.ToString());
                            }
                            else
                            {
                                ev.QFrmThongBaoError("Vui lòng nhập đủ thông tin.");
                                checkNull = true;
                                break;
                            }
                        }
                        if (!checkNull)
                        {
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
                                LoadPhatTrien();
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
                        }
                        break;
                    case 4:
                        int rowdgrpt = dgrNhapMucTieuPhatTrien.Rows.Count;
                        int totalpt = 0;
                        for (int i = 0; i < rowdgrpt; ++i)
                        {
                            if(dgrNhapMucTieuPhatTrien.Rows[i].Cells["clTrongSoKPIBVNhapPT"].Value!=null)
                            {
                                totalpt += int.Parse(dgrNhapMucTieuPhatTrien.Rows[i].Cells["clTrongSoKPIBVNhapPT"].Value.ToString());
                            }
                            else
                            {
                                ev.QFrmThongBaoError("Vui lòng nhập đủ thông tin.");
                                checkNull = true;
                                break;
                            }
                        }
                        if (!checkNull)
                        {
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
                            }
                            else if (totalpt == null && int.Parse(txtTongTrongSoPT.Text) == null)
                            {
                                ev.QFrmThongBaoError("Lỗi không có dữ liệu");
                            }
                        }
                        break;
                }
            }
            else
            {
                ev.QFrmThongBaoError("Chưa có dữ liệu! Vui lòng kiểm tra lại");
            }
        }
        private void TinhTrongSoKPITC(TextBox txtTongTrongSoTC)
        {
            int sc = dgrNhapMucTieuTaiChinh.Rows.Count;
            int sum = 0;
            var checkSum = false;
            for (int i = 0; i < sc; ++i)
            {
                string cellValue = dgrNhapMucTieuTaiChinh.Rows[i].Cells["clTrongSoKPIBVChon"].Value.ToString();

                if (int.TryParse(cellValue, out int parsedValue))
                {
                    sum += parsedValue;
                    checkSum = false;
                }
                else
                {
                    // Hiển thị thông báo lỗi cho định dạng không hợp lệ
                    ev.QFrmThongBaoError($"Lỗi: Định dạng không hợp lệ ở dòng {i + 1}. Vui lòng nhập một giá trị số hợp lệ.");
                    // Bạn có thể thêm logic xử lý lỗi khác ở đây nếu cần
                    txtTongTrongSoTC.Text = "0";
                    checkSum = true;
                    break;
                }
            }
            if (!checkSum)
            {
                if (sum > 100)
                {
                    ev.QFrmThongBaoError("Trọng số đã vượt quá 100%. Vui lòng nhập lại trọng số");

                    dgrNhapMucTieuTaiChinh.CurrentRow.Cells["clTrongSoKPIBVChon"].Value = 0;
                    txtTongTrongSoTC.Text = "0";
                }
                else if (sum > 0 && sum < 100)
                {
                    txtTongTrongSoTC.Text = sum.ToString();
                    ev.QFrmThongBaoError("Chưa đủ tỷ trọng");
                }
                else if(sum == 100)
                {
                    txtTongTrongSoTC.Text = sum.ToString();

                }
                else if (sum == null)
                    ev.QFrmThongBaoError("Trọng số chưa hợp lý!");
                else
                {

                }   

            }
        }
        private void TinhTrongSoKPIKH(TextBox txtTongTrongSoKH)
        {
            int sc = dgrNhapMucTieuKhachHang.Rows.Count;
            int sum = 0;
            var checkSum = false;
            for (int i = 0; i < sc; ++i)
            {
                string cellValue = dgrNhapMucTieuKhachHang.Rows[i].Cells["clTrongSoKPINhapKH"].Value.ToString();

                if (int.TryParse(cellValue, out int parsedValue))
                {
                    sum += parsedValue;
                    checkSum = false;
                }
                else
                {
                    // Hiển thị thông báo lỗi cho định dạng không hợp lệ
                    ev.QFrmThongBaoError($"Lỗi: Định dạng không hợp lệ ở dòng {i + 1}. Vui lòng nhập một giá trị số hợp lệ.");
                    // Bạn có thể thêm logic xử lý lỗi khác ở đây nếu cần
                    txtTongTrongSoKH.Text = "0";
                    checkSum = true;
                    break;
                }
            }
            if (!checkSum)
            {
                if (sum > 100)
                {
                    ev.QFrmThongBaoError("Trọng số đã vượt quá 100%. Vui lòng nhập lại trọng số");

                    dgrNhapMucTieuKhachHang.CurrentRow.Cells["clTrongSoKPINhapKH"].Value = 0;
                    txtTongTrongSoKH.Text = "0";
                }
                else if (sum > 0 && sum < 100)
                {
                    txtTongTrongSoKH.Text = sum.ToString();
                    ev.QFrmThongBaoError("Chưa đủ tỷ trọng");
                }
                else if (sum == 100)
                {
                    txtTongTrongSoKH.Text = sum.ToString();

                }
                else if (sum == null)
                    ev.QFrmThongBaoError("Trọng số chưa hợp lý!");
                else
                {

                }

            }
        }
        private void TinhTrongSoKPIVH(TextBox txtTongTrongSoVH)
        {
            int sc = dgrNhapMucTieuVanHanh.Rows.Count;
            int sum = 0;
            var checkSum = false;
            for (int i = 0; i < sc; ++i)
            {
                string cellValue = dgrNhapMucTieuVanHanh.Rows[i].Cells["clTrongSoKPIBVNhapVH"].Value.ToString();

                if (int.TryParse(cellValue, out int parsedValue))
                {
                    sum += parsedValue;
                    checkSum = false;
                }
                else
                {
                    // Hiển thị thông báo lỗi cho định dạng không hợp lệ
                    ev.QFrmThongBaoError($"Lỗi: Định dạng không hợp lệ ở dòng {i + 1}. Vui lòng nhập một giá trị số hợp lệ.");
                    // Bạn có thể thêm logic xử lý lỗi khác ở đây nếu cần
                    txtTongTrongSoVH.Text = "0";
                    checkSum = true;
                    break;
                }
            }
            if (!checkSum)
            {
                if (sum > 100)
                {
                    ev.QFrmThongBaoError("Trọng số đã vượt quá 100%. Vui lòng nhập lại trọng số");

                    dgrNhapMucTieuVanHanh.CurrentRow.Cells["clTrongSoKPIBVNhapVH"].Value = 0;
                    txtTongTrongSoVH.Text = "0";
                }
                else if (sum > 0 && sum < 100)
                {
                    txtTongTrongSoVH.Text = sum.ToString();
                    ev.QFrmThongBaoError("Chưa đủ tỷ trọng");
                }
                else if (sum == 100)
                {
                    txtTongTrongSoVH.Text = sum.ToString();

                }
                else if (sum == null)
                    ev.QFrmThongBaoError("Trọng số chưa hợp lý!");
                else
                {

                }

            }
        }
        private void TinhTrongSoKPIPT(TextBox txtTongTrongSoPT)
        {
            int sc = dgrNhapMucTieuPhatTrien.Rows.Count;
            int sum = 0;
            var checkSum = false;
            for (int i = 0; i < sc; ++i)
            {
                string cellValue = dgrNhapMucTieuPhatTrien.Rows[i].Cells["clTrongSoKPIBVNhapPT"].Value.ToString();

                if (int.TryParse(cellValue, out int parsedValue))
                {
                    sum += parsedValue;
                    checkSum = false;
                }
                else
                {
                    // Hiển thị thông báo lỗi cho định dạng không hợp lệ
                    ev.QFrmThongBaoError($"Lỗi: Định dạng không hợp lệ ở dòng {i + 1}. Vui lòng nhập một giá trị số hợp lệ.");
                    // Bạn có thể thêm logic xử lý lỗi khác ở đây nếu cần
                    txtTongTrongSoPT.Text = "0";
                    checkSum = true;
                    break;
                }
            }
            if (!checkSum)
            {
                if (sum > 100)
                {
                    ev.QFrmThongBaoError("Trọng số đã vượt quá 100%. Vui lòng nhập lại trọng số");

                    dgrNhapMucTieuPhatTrien.CurrentRow.Cells["clTrongSoKPIBVNhapPT"].Value = 0;
                    txtTongTrongSoPT.Text = "0";
                }
                else if (sum > 0 && sum < 100)
                {
                    txtTongTrongSoPT.Text = sum.ToString();
                    ev.QFrmThongBaoError("Chưa đủ tỷ trọng");
                }
                else if (sum == 100)
                {
                    txtTongTrongSoPT.Text = sum.ToString();

                }
                else if (sum == null)
                    ev.QFrmThongBaoError("Trọng số chưa hợp lý!");
                else
                {

                }

            }
        }
        private bool AllTrongSoCellsEdited()
        {
            foreach (DataGridViewRow row in dgrNhapMucTieuTaiChinh.Rows)
            {
                if (row.Index != dgrNhapMucTieuTaiChinh.NewRowIndex && string.IsNullOrEmpty(row.Cells["clTrongSoKPIBVChon"].Value?.ToString()))
                {
                    return false;
                }
            }
            return true;
        }
        private bool AllTrongSoCellsEditedKH()
        {
            foreach (DataGridViewRow row in dgrNhapMucTieuKhachHang.Rows)
            {
                if (row.Index != dgrNhapMucTieuKhachHang.NewRowIndex && string.IsNullOrEmpty(row.Cells["clTrongSoKPINhapKH"].Value?.ToString()))
                {
                    return false;
                }
            }
            return true;
        }
        private bool AllTrongSoCellsEditedVH()
        {
            foreach (DataGridViewRow row in dgrNhapMucTieuVanHanh.Rows)
            {
                if (row.Index != dgrNhapMucTieuVanHanh.NewRowIndex && string.IsNullOrEmpty(row.Cells["clTrongSoKPIBVNhapVH"].Value?.ToString()))
                {
                    return false;
                }
            }
            return true;
        }
        private bool AllTrongSoCellsEditedPT()
        {
            foreach (DataGridViewRow row in dgrNhapMucTieuPhatTrien.Rows)
            {
                if (row.Index != dgrNhapMucTieuPhatTrien.NewRowIndex && string.IsNullOrEmpty(row.Cells["clTrongSoKPIBVNhapPT"].Value?.ToString()))
                {
                    return false;
                }
            }
            return true;
        }
        private void dgrNhapMucTieuTaiChinh_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //ReturnDataTableTC();
        }
        private void dgrBVMucTieuTaiChinh_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Kiểm tra xem cột được nhấp có phải là cột "cChon" và là header không
                if (dgrBVMucTieuTaiChinh.Columns[e.ColumnIndex].Name == "cChon" && e.RowIndex == -1)
                {
                    // Thực hiện chỉ thao tác nếu cột được nhấp là "cChon" và là header
                    for (int i = 0; i < dgrBVMucTieuTaiChinh.Rows.Count; i++)
                    {
                        dgrBVMucTieuTaiChinh.Rows[i].Cells["cChon"].Value = true;
                    }

                    // Force một cell để chuyển trạng thái từ dirty sang clean
                    dgrBVMucTieuTaiChinh.CurrentCell = null;

                    // LoadDataTableTC() sẽ được gọi ở sự kiện CellValueChanged
                }
            }

        }
        private void dgrBVMucTieuTaiChinh_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Xác nhận rằng ô checkbox đã thay đổi giá trị
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgrBVMucTieuTaiChinh.Columns[e.ColumnIndex].Name == "cChon")
            {
                LoadDataTableTC();
            }
           
        }
        private void dgrNhapMucTieuTaiChinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgrNhapMucTieuTaiChinh.Rows.Count && e.ColumnIndex == 0)
            {
                foreach (DataGridViewRow row in dgrBVMucTieuTaiChinh.Rows)
                {
                    if (dgrNhapMucTieuTaiChinh.Rows[e.RowIndex].Cells["clMaKPIChon"].Value.ToString() == row.Cells["clMaKPI"].Value.ToString())
                    {
                        row.Cells["cChon"].Value = false;
                        break;
                    }
                }
                LoadDataTableTC();
            }
        }
        private void dgrBVMucTieuTaiChinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dgrBVMucTieuTaiChinh.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dgrBVMucTieuTaiChinh.Columns.Count)
            {
                if (dgrBVMucTieuTaiChinh.Rows[e.RowIndex].Cells["cChon"].Value != null && (bool)dgrBVMucTieuTaiChinh.Rows[e.RowIndex].Cells["cChon"].Value == true)
                {
                    LoadDataTableTC();
                    dgrBVMucTieuTaiChinh.Rows[e.RowIndex].Cells["cChon"].Value = false;
                    return;
                }
                LoadDataTableTC();
                dgrBVMucTieuTaiChinh.Rows[e.RowIndex].Cells["cChon"].Value = true;
            }
        }
       
        private int editedCellCount = 0;
        private void dgrNhapMucTieuTaiChinh_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            // Kiểm tra xem sự kiện có xảy ra trong cột clTrongSoTCBV không
            if (e.ColumnIndex == dgrNhapMucTieuTaiChinh.Columns["clTrongSoKPIBVChon"].Index)
            {
                // Ghi nhận việc chỉnh sửa ô
                editedCellCount++;

                // Kiểm tra xem đã chỉnh sửa hết tất cả các ô trong cột clTrongSoTCBV của tất cả các dòng chưa
                if (AllTrongSoCellsEdited())
                {
                    // Gọi lại hàm để tính tổng trọng số và cập nhật TextBox
                    TinhTrongSoKPITC(txtTongTrongSoTC);

                    // Reset biến đếm
                    editedCellCount = 0;
                }
            }
        }
        private void btnTTKH_Click(object sender, EventArgs e)
        {
            dgrHTMucTieuTaiChinh.Rows.Clear();
            KiemTraTyTrong(1);
        }
        
        private void dgrBVMucTieuKhachHang_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Kiểm tra xem cột được nhấp có phải là cột "cChon" và là header không
                if (dgrBVMucTieuKhachHang.Columns[e.ColumnIndex].Name == "cChonKH" && e.RowIndex == -1)
                {
                    // Thực hiện chỉ thao tác nếu cột được nhấp là "cChon" và là header
                    for (int i = 0; i < dgrBVMucTieuKhachHang.Rows.Count; i++)
                    {
                        dgrBVMucTieuKhachHang.Rows[i].Cells["cChonKH"].Value = true;
                    }

                    // Force một cell để chuyển trạng thái từ dirty sang clean
                    dgrBVMucTieuKhachHang.CurrentCell = null;

                    // LoadDataTableTC() sẽ được gọi ở sự kiện CellValueChanged
                }
            }

        }
        private void dgrBVMucTieuKhachHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Xác nhận rằng ô checkbox đã thay đổi giá trị
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgrBVMucTieuKhachHang.Columns[e.ColumnIndex].Name == "cChonKH")
            {
                LoadDataTableKH();
            }

        }
        private void dgrNhapMucTieuKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgrNhapMucTieuKhachHang.Rows.Count && e.ColumnIndex == 0)
            {
                foreach (DataGridViewRow row in dgrBVMucTieuKhachHang.Rows)
                {
                    if (dgrNhapMucTieuKhachHang.Rows[e.RowIndex].Cells["clMaKPINhapKH"].Value.ToString() == row.Cells["clMaKPIKH"].Value.ToString())
                    {
                        row.Cells["cChonKH"].Value = false;
                        break;
                    }
                }
                LoadDataTableKH();
            }
        }
        private void dgrBVMucTieuKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dgrBVMucTieuKhachHang.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dgrBVMucTieuKhachHang.Columns.Count)
            {
                if (dgrBVMucTieuKhachHang.Rows[e.RowIndex].Cells["cChonKH"].Value != null && (bool)dgrBVMucTieuKhachHang.Rows[e.RowIndex].Cells["cChonKH"].Value == true)
                {
                    LoadDataTableKH();
                    dgrBVMucTieuKhachHang.Rows[e.RowIndex].Cells["cChonKH"].Value = false;
                    return;
                }
                LoadDataTableKH();
                dgrBVMucTieuKhachHang.Rows[e.RowIndex].Cells["cChonKH"].Value = true;
            }
        }

        private int editedCellCount1 = 0;
        private void dgrNhapMucTieuKhachHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            // Kiểm tra xem sự kiện có xảy ra trong cột clTrongSoTCBV không
            if (e.ColumnIndex == dgrNhapMucTieuKhachHang.Columns["clTrongSoKPINhapKH"].Index)
            {
                // Ghi nhận việc chỉnh sửa ô
                editedCellCount1++;

                // Kiểm tra xem đã chỉnh sửa hết tất cả các ô trong cột clTrongSoTCBV của tất cả các dòng chưa
                if (AllTrongSoCellsEditedKH())
                {
                    // Gọi lại hàm để tính tổng trọng số và cập nhật TextBox
                    TinhTrongSoKPIKH(txtTongTrongSoKH);

                    // Reset biến đếm
                    editedCellCount1 = 0;
                }
            }
        }
        private void btnTTVH_Click(object sender, EventArgs e)
        {
            dgrHTMucTieuKhachHang.Rows.Clear();
            KiemTraTyTrong(2);
        }
        private void btnQLTC_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai(0);
        }

        private void dgrBVMucTieuVanHanh_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Kiểm tra xem cột được nhấp có phải là cột "cChon" và là header không
                if (dgrBVMucTieuVanHanh.Columns[e.ColumnIndex].Name == "cChonVH" && e.RowIndex == -1)
                {
                    // Thực hiện chỉ thao tác nếu cột được nhấp là "cChon" và là header
                    for (int i = 0; i < dgrBVMucTieuKhachHang.Rows.Count; i++)
                    {
                        dgrBVMucTieuVanHanh.Rows[i].Cells["cChonVH"].Value = true;
                    }

                    // Force một cell để chuyển trạng thái từ dirty sang clean
                    dgrBVMucTieuVanHanh.CurrentCell = null;

                    // LoadDataTableTC() sẽ được gọi ở sự kiện CellValueChanged
                }
            }

        }
        private void dgrBVMucTieuVanHanh_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Xác nhận rằng ô checkbox đã thay đổi giá trị
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgrBVMucTieuVanHanh.Columns[e.ColumnIndex].Name == "cChonVH")
            {
                LoadDataTableVH();
            }

        }
        private void dgrNhapMucTieuVanHanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgrNhapMucTieuVanHanh.Rows.Count && e.ColumnIndex == 0)
            {
                foreach (DataGridViewRow row in dgrBVMucTieuVanHanh.Rows)
                {
                    if (dgrNhapMucTieuVanHanh.Rows[e.RowIndex].Cells["clMaKPINhapVH"].Value.ToString() == row.Cells["clMaKPIVH"].Value.ToString())
                    {
                        row.Cells["cChonVH"].Value = false;
                        break;
                    }
                }
                LoadDataTableVH();
            }
        }
        private void dgrBVMucTieuVanHanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgrBVMucTieuVanHanh.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dgrBVMucTieuVanHanh.Columns.Count)
            {
                if (dgrBVMucTieuVanHanh.Rows[e.RowIndex].Cells["cChonVH"].Value != null && (bool)dgrBVMucTieuVanHanh.Rows[e.RowIndex].Cells["cChonVH"].Value == true)
                {
                    LoadDataTableVH();
                    dgrBVMucTieuVanHanh.Rows[e.RowIndex].Cells["cChonVH"].Value = false;
                    return;
                }
                LoadDataTableVH();
                dgrBVMucTieuVanHanh.Rows[e.RowIndex].Cells["cChonVH"].Value = true;
            }
        }

        private int editedCellCount2 = 0;
        private void dgrNhapMucTieuVanHanh_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            // Kiểm tra xem sự kiện có xảy ra trong cột clTrongSoTCBV không
            if (e.ColumnIndex == dgrNhapMucTieuVanHanh.Columns["clTrongSoKPIBVNhapVH"].Index)
            {
                // Ghi nhận việc chỉnh sửa ô
                editedCellCount2++;

                // Kiểm tra xem đã chỉnh sửa hết tất cả các ô trong cột clTrongSoTCBV của tất cả các dòng chưa
                if (AllTrongSoCellsEditedVH())
                {
                    // Gọi lại hàm để tính tổng trọng số và cập nhật TextBox
                    TinhTrongSoKPIVH(txtTongTrongSoVH);

                    // Reset biến đếm
                    editedCellCount2 = 0;
                }
            }
        }
        private void btnTTPT_Click(object sender, EventArgs e)
        {
            dgrHTMucTieuVanHanh.Rows.Clear();
            KiemTraTyTrong(3);
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai(1);
        }

        private void dgrBVMucTieuPhatTrien_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Kiểm tra xem cột được nhấp có phải là cột "cChon" và là header không
                if (dgrBVMucTieuPhatTrien.Columns[e.ColumnIndex].Name == "cChonPT" && e.RowIndex == -1)
                {
                    // Thực hiện chỉ thao tác nếu cột được nhấp là "cChon" và là header
                    for (int i = 0; i < dgrBVMucTieuPhatTrien.Rows.Count; i++)
                    {
                        dgrBVMucTieuPhatTrien.Rows[i].Cells["cChonPT"].Value = true;
                    }

                    // Force một cell để chuyển trạng thái từ dirty sang clean
                    dgrBVMucTieuPhatTrien.CurrentCell = null;

                    // LoadDataTableTC() sẽ được gọi ở sự kiện CellValueChanged
                }
            }

        }
        private void dgrBVMucTieuPhatTrien_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Xác nhận rằng ô checkbox đã thay đổi giá trị
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgrBVMucTieuPhatTrien.Columns[e.ColumnIndex].Name == "cChonPT")
            {
                LoadDataTablePT();
            }

        }
        private void dgrNhapMucTieuPhatTrien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgrNhapMucTieuPhatTrien.Rows.Count && e.ColumnIndex == 0)
            {
                foreach (DataGridViewRow row in dgrBVMucTieuPhatTrien.Rows)
                {
                    if (dgrNhapMucTieuPhatTrien.Rows[e.RowIndex].Cells["clMaKPINhapPT"].Value.ToString() == row.Cells["clMaKPIPT"].Value.ToString())
                    {
                        row.Cells["cChonPT"].Value = false;
                        break;
                    }
                }
                LoadDataTablePT();
            }
        }
        private void dgrBVMucTieuPhatTrien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgrBVMucTieuPhatTrien.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dgrBVMucTieuPhatTrien.Columns.Count)
            {
                if (dgrBVMucTieuPhatTrien.Rows[e.RowIndex].Cells["cChonPT"].Value != null && (bool)dgrBVMucTieuPhatTrien.Rows[e.RowIndex].Cells["cChonPT"].Value == true)
                {
                    LoadDataTablePT();
                    dgrBVMucTieuPhatTrien.Rows[e.RowIndex].Cells["cChonPT"].Value = false;
                    return;
                }
                LoadDataTablePT();
                dgrBVMucTieuPhatTrien.Rows[e.RowIndex].Cells["cChonPT"].Value = true;
            }
           
        }

        private int editedCellCount3 = 0;
        private void dgrNhapMucTieuPhatTrien_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            // Kiểm tra xem sự kiện có xảy ra trong cột clTrongSoTCBV không
            if (e.ColumnIndex == dgrNhapMucTieuPhatTrien.Columns["clTrongSoKPIBVNhapPT"].Index)
            {
                // Ghi nhận việc chỉnh sửa ô
                editedCellCount3++;

                // Kiểm tra xem đã chỉnh sửa hết tất cả các ô trong cột clTrongSoTCBV của tất cả các dòng chưa
                if (AllTrongSoCellsEditedPT())
                {
                    // Gọi lại hàm để tính tổng trọng số và cập nhật TextBox
                    TinhTrongSoKPIPT(txtTongTrongSoPT);

                    // Reset biến đếm
                    editedCellCount3 = 0;
                }
            }
        }


        private void btnQLPT_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai(3);
        }
        private void btnTTHT_Click(object sender, EventArgs e)
        {
            dgrHTMucTieuPhatTrien.Rows.Clear();
            KiemTraTyTrong(4);
        }
        private void btnQLVH_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai(2);
        }


        #endregion

        #endregion
        #region Tinhtrongsophuongdien
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
               // ev.QFrmThongBaoError("Lỗi nhập sai định dạng hoặc thiếu dữ liệu");
            }
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

            //txtTCHT.xActive = false;
            //ev.Qtxt_Leave(sender, e);
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
            //TinhTongTrongSoPhuongDien();
            //txtKHHT.xActive = false;
            //ev.Qtxt_Leave(sender, e);
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
            //TinhTongTrongSoPhuongDien();
            //txtVHHT.xActive = false;
            //ev.Qtxt_Leave(sender, e);
        }

        private void txtPTVH_Enter(object sender, EventArgs e)
        {
            txtPTHT.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtPTVH_Leave(object sender, EventArgs e)
        {
            //TinhTongTrongSoPhuongDien();
            //txtPTHT.xActive = false;
            //ev.Qtxt_Leave(sender, e);
        }
        private void txtTCHT_Validating(object sender, CancelEventArgs e)
        {
            string userInput = txtTCHT.Text.ToString();
            int parsedValue;
            if (!int.TryParse(userInput, out parsedValue))
            {
                ev.QFrmThongBaoError("Chỉ được nhập số không nhận chữ cái và kí tự khác");
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
            //int sum = int.Parse(txtTongTrongSoMucTieu.Text);
            //if (sum > 100)
            //{
            //    ev.QFrmThongBaoError("Tổng trọng số mục tiêu vượt quá 100%.Vui lòng nhập lại!");
            //    txtTCHT.Text = "0";
            //    TinhTongTrongSoPhuongDien();
            //    txtTCHT.Focus();
            //}
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
            //int sum = int.Parse(txtTongTrongSoMucTieu.Text);
            //if (sum > 100)
            //{
            //    ev.QFrmThongBaoError("Tổng trọng số mục tiêu vượt quá 100%.Vui lòng nhập lại!");
            //    txtKHHT.Text = "0";
            //    TinhTongTrongSoPhuongDien();
            //    txtKHHT.Focus();
            //}
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
            //int sum = int.Parse(txtTongTrongSoMucTieu.Text);
            //if (sum > 100)
            //{
            //    ev.QFrmThongBaoError("Tổng trọng số mục tiêu vượt quá 100%.Vui lòng nhập lại!");
            //    txtVHHT.Text = "0";
            //    TinhTongTrongSoPhuongDien();
            //    txtVHHT.Focus();
            //}
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
            //int sum = int.Parse(txtTongTrongSoMucTieu.Text);
            //if (sum > 100)
            //{
            //    ev.QFrmThongBaoError("Tổng trọng số mục tiêu vượt quá 100%. Vui lòng nhập lại!");
            //    txtPTHT.Text = "0";
            //    TinhTongTrongSoPhuongDien();
            //    txtPTHT.Focus();
            //}
        }
        
        private void Frm_A71_FormClosing(object sender, FormClosingEventArgs e)
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
        #endregion
        #region
        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            TinhTongTrongSoPhuongDien();
            int sum = int.Parse(txtTongTrongSoMucTieu.Text);
            if (sum < 100 && sum > 100)
            {
                ev.QFrmThongBaoError("Trọng số chưa đạt đủ hoặc vượt quá 100%");
            }
            else if (sum == 100)
            {
                SavetoDatabaseBang();
                SaveToDatabaseChiTietbang();
            }
            else
            {

            }
        }
        private void SavetoDatabaseBang()
        {
            DateTime ngayTaoMaPhieu = dt_NgayTaoMaPhieu.Value;


            // Kiểm tra giá trị không null
            if (string.IsNullOrEmpty(txt_MaPhieu.Text) || string.IsNullOrEmpty(NamPhieu) || string.IsNullOrEmpty(txtTongTrongSoMucTieu.Text))
            {
                // Xử lý khi giá trị null hoặc rỗng
                // (Bạn có thể hiển thị thông báo hoặc thực hiện các xử lý phù hợp khác)
                return;
            }

            string msql = "INSERT INTO [dbo].[KPI_BenhVien] ([MaPhieuKPIBV],[NamPhieu],[NguoiLap],[NguoiPheDuyet],[NgayLapPhieuKPIBV],[NgayPheDuyet],[IDBieuMau],[TrangThai])" +
                          " VALUES (@mpkpi, @np, @nl, @nguoipheduyet, @ngaylpkpi, @npd, @idbm,@trangthai)";

            using (SqlConnection connection = new SqlConnection(mconnecstring))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(msql, connection))
                {
                    command.Parameters.AddWithValue("@mpkpi", txt_MaPhieu.Text);
                    command.Parameters.AddWithValue("@np", NamPhieu);
                    command.Parameters.AddWithValue("@nl", 456789);
                    command.Parameters.AddWithValue("@nguoipheduyet", DBNull.Value); // Hoặc có thể sử dụng giá trị mặc định phù hợp
                    command.Parameters.AddWithValue("@ngaylpkpi", ngayTaoMaPhieu);
                    command.Parameters.AddWithValue("@npd", DBNull.Value); // Hoặc có thể sử dụng giá trị mặc định phù hợp
                    command.Parameters.AddWithValue("@idbm", 71);
                    command.Parameters.AddWithValue("@trangthai", 0);
                    command.ExecuteNonQuery();
                }
            }
        }
        private bool IsCellValueValid(DataGridViewCell cell)
        {
            return cell != null && cell.Value != null && !string.IsNullOrWhiteSpace(cell.Value.ToString());
        }
        private void SaveToDatabaseChiTietbang()
        {
            using (SqlConnection connection = new SqlConnection(mconnecstring))
            {
                connection.Open();

                if (dgrHTMucTieuTaiChinh.SelectedCells.Count > 0 & dgrHTMucTieuPhatTrien.SelectedCells.Count > 0 & dgrHTMucTieuVanHanh.SelectedCells.Count > 0 & dgrHTMucTieuPhatTrien.SelectedCells.Count > 0)
                {
                    string maPhieu = txt_MaPhieu.Text;
                    DateTime ngayTaoMaPhieu = dt_NgayTaoMaPhieu.Value;
                    bool allRowsFilled = true;

                    foreach (DataGridViewRow row in dgrHTMucTieuTaiChinh.Rows)
                    {
                        if (row.Index == dgrHTMucTieuTaiChinh.Rows.Count )
                        {
                            continue;
                        }

                        if (!IsCellValueValid(row.Cells["clTrongSoKPIBVHTTC"]) && string.IsNullOrEmpty(NamPhieu))
                        {
                            allRowsFilled = false;
                            break;
                        }
                    }

                    if (allRowsFilled)
                    {
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = connection;
                            string query = "INSERT INTO [dbo].[ChiTietTieuChiMucTieuBV]([NoiDungKPI],[KeHoach],[TrongSoTCBV],[TrongSoKPIBV],[MaPhieuKPIBV],[TieuChiID])" +
                                " VALUES (@noidung,@kehoach, @tstcbv, @tskpibv,@mpkpi,@tcid)";
                            command.CommandText = query;

                            foreach (DataGridViewRow row in dgrHTMucTieuTaiChinh.Rows)
                            {
                                if (row.Index == dgrHTMucTieuTaiChinh.Rows.Count)
                                {
                                    continue;
                                }

                                int trongSoTieuChiBV;
                                int trongSoKPIBV;
                                string kehoach;
                                string noidung;

                                if ( int.TryParse(row.Cells["clTrongSoKPIBVHTTC"].Value.ToString(), out trongSoKPIBV) && int.TryParse(txtTCHT.Text.ToString(), out trongSoTieuChiBV))
                                {
                                    kehoach = row.Cells["clTieuChiHTTC"].Value.ToString();
                                    noidung = row.Cells["clNoiDungHTTC"].Value.ToString();
                                    command.Parameters.Clear();
                                    command.Parameters.AddWithValue("@noidung", noidung);
                                    command.Parameters.AddWithValue("@kehoach", kehoach);
                                    command.Parameters.AddWithValue("@tstcbv", trongSoTieuChiBV);
                                    command.Parameters.AddWithValue("@tskpibv", trongSoKPIBV);
                                    command.Parameters.AddWithValue("@mpkpi", maPhieu);
                                    command.Parameters.AddWithValue("@tcid", 'F');
                                    command.ExecuteNonQuery();
                                }
                                else
                                {
                                    ev.QFrmThongBaoError("Lỗi chuyển đổi kiểu dữ liệu.");
                                    return;
                                }
                            }

                            //btnHoanThanh.Visible = false;
                            //ev.QFrmThongBao("Bạn đã lưu thành công");
                        }
                    }
                    else
                    {
                        ev.QFrmThongBaoError("Vui lòng nhập giá trị cho tất cả các hàng của trọng số tiêu chí tài chính của bệnh viện");
                    }
                    foreach (DataGridViewRow row in dgrHTMucTieuKhachHang.Rows)
                    {
                        if (row.Index == dgrHTMucTieuKhachHang.Rows.Count)
                        {
                            continue;
                        }

                        if (!IsCellValueValid(row.Cells["clTrongSoKPIBVHTKH"]) && string.IsNullOrEmpty(NamPhieu))
                        {
                            allRowsFilled = false;
                            break;
                        }
                    }
                    if (allRowsFilled)
                    {
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = connection;
                            string query = "INSERT INTO [dbo].[ChiTietTieuChiMucTieuBV]([NoiDungKPI],[KeHoach],[TrongSoTCBV],[TrongSoKPIBV],[MaPhieuKPIBV],[TieuChiID])" +
                                " VALUES (@noidung,@kehoach, @tstcbv, @tskpibv,@mpkpi,@tcid)";
                            command.CommandText = query;

                            foreach (DataGridViewRow row in dgrHTMucTieuKhachHang.Rows)
                            {
                                if (row.Index == dgrHTMucTieuKhachHang.Rows.Count )
                                {
                                    continue;
                                }

                                int trongSoTieuChiBV;
                                int trongSoKPIBV;
                                string kehoach;
                                string noidung;

                                if (int.TryParse(row.Cells["clTrongSoKPIBVHTKH"].Value.ToString(), out trongSoKPIBV) && int.TryParse(txtKHHT.Text.ToString(), out trongSoTieuChiBV))
                                {
                                    kehoach = row.Cells["clTieuChiHTKH"].Value.ToString();
                                    noidung = row.Cells["clNoiDungHTKH"].Value.ToString();
                                    command.Parameters.Clear();
                                    command.Parameters.AddWithValue("@noidung", noidung);
                                    command.Parameters.AddWithValue("@kehoach", kehoach);
                                    command.Parameters.AddWithValue("@tstcbv", trongSoTieuChiBV);
                                    command.Parameters.AddWithValue("@tskpibv", trongSoKPIBV);
                                    command.Parameters.AddWithValue("@mpkpi", maPhieu);
                                    command.Parameters.AddWithValue("@tcid", 'C');
                                    command.ExecuteNonQuery();
                                }
                                else
                                {
                                    ev.QFrmThongBaoError("Lỗi chuyển đổi kiểu dữ liệu.");
                                    return;
                                }
                            }

                            //btnHoanThanh.Visible = false;
                            //ev.QFrmThongBao("Bạn đã lưu thành công");
                        }
                    }
                    else
                    {
                        ev.QFrmThongBaoError("Vui lòng nhập giá trị cho tất cả các hàng của trọng số tiêu chí khách hàng bệnh viện");
                    }
                    foreach (DataGridViewRow row in dgrHTMucTieuVanHanh.Rows)
                    {
                        if (row.Index == dgrHTMucTieuVanHanh.Rows.Count)
                        {
                            continue;
                        }

                        if (!IsCellValueValid(row.Cells["clTrongSoKPIBVHTVH"]) && string.IsNullOrEmpty(NamPhieu))
                        {
                            allRowsFilled = false;
                            break;
                        }
                    }

                    if (allRowsFilled)
                    {
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = connection;
                            string query = "INSERT INTO [dbo].[ChiTietTieuChiMucTieuBV]([NoiDungKPI],[KeHoach],[TrongSoTCBV],[TrongSoKPIBV],[MaPhieuKPIBV],[TieuChiID])" +
                                " VALUES (@noidung,@kehoach, @tstcbv, @tskpibv,@mpkpi,@tcid)";
                            command.CommandText = query;

                            foreach (DataGridViewRow row in dgrHTMucTieuVanHanh.Rows)
                            {
                                if (row.Index == dgrHTMucTieuVanHanh.Rows.Count)
                                {
                                    continue;
                                }

                                int trongSoTieuChiBV;
                                int trongSoKPIBV;
                                string kehoach;
                                string noidung;

                                if (int.TryParse(row.Cells["clTrongSoKPIBVHTVH"].Value.ToString(), out trongSoKPIBV) && int.TryParse(txtVHHT.Text.ToString(), out trongSoTieuChiBV))
                                {
                                    kehoach = row.Cells["clChiTieuHTVH"].Value.ToString();

                                    noidung = row.Cells["clNoiDungHTVH"].Value.ToString();
                                    command.Parameters.Clear();
                                    command.Parameters.AddWithValue("@noidung", noidung);
                                    command.Parameters.AddWithValue("@kehoach", kehoach);
                                    command.Parameters.AddWithValue("@tstcbv", trongSoTieuChiBV);
                                    command.Parameters.AddWithValue("@tskpibv", trongSoKPIBV);
                                    command.Parameters.AddWithValue("@mpkpi", maPhieu);
                                    command.Parameters.AddWithValue("@tcid", 'B');
                                    command.ExecuteNonQuery();
                                }
                                else
                                {
                                    ev.QFrmThongBaoError("Lỗi chuyển đổi kiểu dữ liệu.");
                                    return;
                                }
                            }

                            //btnHoanThanh.Visible = false;
                            //ev.QFrmThongBao("Bạn đã lưu thành công");
                        }
                    }
                    else
                    {
                        ev.QFrmThongBaoError("Vui lòng nhập giá trị cho tất cả các hàng của trọng số tiêu chí vận hành bệnh viện");
                    }
                    foreach (DataGridViewRow row in dgrHTMucTieuPhatTrien.Rows)
                    {
                        if (row.Index == dgrHTMucTieuPhatTrien.Rows.Count - 1)
                        {
                            continue;
                        }

                        if (!IsCellValueValid(row.Cells["clTrongSoKPIBVHTPT"]) && string.IsNullOrEmpty(NamPhieu))
                        {
                            allRowsFilled = false;
                            break;
                        }
                    }

                    if (allRowsFilled)
                    {
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = connection;
                            string query = "INSERT INTO [dbo].[ChiTietTieuChiMucTieuBV]([NoiDungKPI],[KeHoach],[TrongSoTCBV],[TrongSoKPIBV],[MaPhieuKPIBV],[TieuChiID])" +
                                " VALUES (@noidung,@kehoach, @tstcbv, @tskpibv,@mpkpi,@tcid)";
                            command.CommandText = query;

                            foreach (DataGridViewRow row in dgrHTMucTieuPhatTrien.Rows)
                            {
                                if (row.Index == dgrHTMucTieuPhatTrien.Rows.Count)
                                {
                                    continue;
                                }

                                int trongSoTieuChiBV;
                                int trongSoKPIBV;
                                string kehoach;
                                string noidung;

                                if (int.TryParse(row.Cells["clTrongSoKPIBVHTPT"].Value.ToString(), out trongSoKPIBV) && int.TryParse(txtPTHT.Text.ToString(), out trongSoTieuChiBV))
                                {
                                    kehoach = row.Cells["clChiTieuHTPT"].Value.ToString();
                                    noidung = row.Cells["clNoiDungHTPT"].Value.ToString();
                                    command.Parameters.Clear();
                                    command.Parameters.AddWithValue("@noidung", noidung);
                                    command.Parameters.AddWithValue("@kehoach", kehoach);
                                    command.Parameters.AddWithValue("@tstcbv", trongSoTieuChiBV);
                                    command.Parameters.AddWithValue("@tskpibv", trongSoKPIBV);
                                    command.Parameters.AddWithValue("@mpkpi", maPhieu);
                                    command.Parameters.AddWithValue("@tcid", 'L');
                                    command.ExecuteNonQuery();
                                }
                                else
                                {
                                    ev.QFrmThongBaoError("Lỗi chuyển đổi kiểu dữ liệu.");
                                    return;
                                }
                            }

                            //btnHoanThanh.Visible = false;
                            //ev.QFrmThongBao("Bạn đã lưu thành công");
                        }
                       
                    }
                    else
                    {
                        ev.QFrmThongBaoError("Vui lòng nhập giá trị cho tất cả các hàng của trọng số tiêu chí phát triển của bệnh viện");
                    }          
                } 
                else
                {
                    ev.QFrmThongBaoError("Bị lỗi");
                }

                btnHoanThanh.Visible = false;
                ev.QFrmThongBao("Bạn đã lưu thành công");
            }
        }
        public string CreateKpiCode(DateTime ngay)
        {
            using (SqlConnection connection = new SqlConnection(mconnecstring))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT [dbo].[TaoMaPhieuKPIBV](@ngay)", connection))
                {
                    command.Parameters.AddWithValue("@ngay", ngay);
                    string result = command.ExecuteScalar().ToString();
                    return result;
                }
            }
        }
        public int GetYearFromNgayTaoPhieuKPI(DateTime ngay)
        {
            using (SqlConnection connection = new SqlConnection(mconnecstring))
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

        private void btn_TaoMaPhieu_Click(object sender, EventArgs e)
        {
            DateTime ngayTao = dt_NgayTaoMaPhieu.Value; // Assume dtNgayTao is your DateTimePicker
            string maPhieuKPI = CreateKpiCode(ngayTao);
            txt_MaPhieu.Text = maPhieuKPI;
        }

        private void txt_Nam_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NamPhieu))
            {
                if (int.TryParse(NamPhieu, out int nam))
                {
                    int namhientai = DateTime.Now.Year;
                    if (nam < namhientai)
                    {
                        ev.QFrmThongBao("Không thể tạo cho năm nhỏ hơn năm hiện tại.");
                        btnHoanThanh.Visible = false;
                    }
                }
            }
            int namPhieu;
            if (int.TryParse(NamPhieu, out namPhieu))
            {
                using (SqlConnection connection = new SqlConnection(mconnecstring))
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
                        //Nam chưa có 
                        if (ketQua == 1)
                        {

                        }
                        else if (ketQua == 3)
                        {
                            bool result = ev.QFrmThongBao_YesNo("Phiếu đã được cấp trên duyệt. bạn có muốn xem lại?");
                            if (result == true)
                            {
                                if (int.TryParse(NamPhieu, out int namphieu))
                                {
                                    ChinhSuaDanhSachKPI form = new ChinhSuaDanhSachKPI(namphieu);
                                    form.ShowDialog();
                                }
                            }

                        }
                        else if (ketQua == 4)
                        {
                            bool result = ev.QFrmThongBao_YesNo("Phiếu năm này đã được tạo bạn có muốn chỉnh sửa phiếu lại không ???");
                            if (result == true)
                            {
                                SqlCommand getMaPhieuCmd = new SqlCommand("SELECT dbo.GetMaPhieuByNamPhieu(@NamPhieu)", connection);
                                getMaPhieuCmd.Parameters.AddWithValue("@NamPhieu", namPhieu);

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

                                    SqlDataAdapter adapter1 = new SqlDataAdapter(
                                    $"SELECT ChiTiet.*, NhomTieuChi.TenTieuChi " +
                                    $"FROM dbo.ChiTietTieuChiMucTieuBV ChiTiet " +
                                    $"INNER JOIN dbo.NhomTieuChi ON ChiTiet.TieuChiID = NhomTieuChi.TieuChiID " +
                                    $"WHERE ChiTiet.MaPhieuKPIBV = '{maPhieu}' AND ChiTiet.TieuChiID = 'C'", connection);
                                    DataTable dataTable1 = new DataTable();
                                    adapter1.Fill(dataTable1);

                                    SqlDataAdapter adapter2 = new SqlDataAdapter(
                                    $"SELECT ChiTiet.*, NhomTieuChi.TenTieuChi " +
                                    $"FROM dbo.ChiTietTieuChiMucTieuBV ChiTiet " +
                                    $"INNER JOIN dbo.NhomTieuChi ON ChiTiet.TieuChiID = NhomTieuChi.TieuChiID " +
                                    $"WHERE ChiTiet.MaPhieuKPIBV = '{maPhieu}' AND ChiTiet.TieuChiID = 'B'", connection);
                                    DataTable dataTable2 = new DataTable();
                                    adapter2.Fill(dataTable2);

                                    SqlDataAdapter adapter3 = new SqlDataAdapter(
                                    $"SELECT ChiTiet.*, NhomTieuChi.TenTieuChi " +
                                    $"FROM dbo.ChiTietTieuChiMucTieuBV ChiTiet " +
                                    $"INNER JOIN dbo.NhomTieuChi ON ChiTiet.TieuChiID = NhomTieuChi.TieuChiID " +
                                    $"WHERE ChiTiet.MaPhieuKPIBV = '{maPhieu}' AND ChiTiet.TieuChiID = 'L'", connection);
                                    DataTable dataTable3 = new DataTable();
                                    adapter3.Fill(dataTable3);

                                    // Tạo một form mới và truyền DataTable tới constructor
                                    //ChinhSuaDanhSachKPI newForm = new ChinhSuaDanhSachKPI(dataTable, namPhieu, maPhieu);
                                    //ChinhSuaDanhSachKPI newForm1 = new ChinhSuaDanhSachKPI(dataTable1, namPhieu, maPhieu);
                                    //ChinhSuaDanhSachKPI newForm2 = new ChinhSuaDanhSachKPI(dataTable2, namPhieu, maPhieu);
                                    //ChinhSuaDanhSachKPI newForm3 = new ChinhSuaDanhSachKPI(dataTable3, namPhieu, maPhieu);


                                    // Hiển thị form mới
                                    //newForm.ShowDialog();
                                    //newForm1.ShowDialog();
                                    //newForm2.ShowDialog();
                                    //newForm3.ShowDialog();

                                }
                                else
                                {
                                    ev.QFrmThongBao("Lỗi khi lấy mã phiếu.");
                                }
                            }
                            else
                            {
                                ev.QFrmThongBao("Không có chỉnh sửa cần thay đổi!");
                            }
                        }
                    }
                }
            }
            else
            {
                ev.QFrmThongBaoError("Vui lòng nhập số nguyên vào ô NamPhieu.");
            }

        }
        private void layNam()
        {
            DateTime ngayTao = dt_NgayTaoMaPhieu.Value;
            int nam = GetYearFromNgayTaoPhieuKPI(ngayTao);
            NamPhieu = nam.ToString();
        }
        private void dt_NgayTaoMaPhieu_ValueChanged(object sender, EventArgs e)
        {
            layNam();
        }
        private void txt_MaPhieu_TextChanged(object sender, EventArgs e)
        {
            layNam();
        }
        #endregion

        private void btnAddKPITC_Click(object sender, EventArgs e)
        {
        }
    }
}