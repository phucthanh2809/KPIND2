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
        DataTable tc = new DataTable();
        DataTable kh = new DataTable();
        DataTable vh = new DataTable();
        DataTable pt = new DataTable();

        private int CurrentTab = 0;
        public FrmA73()
        {
            InitializeComponent();

            txtTest.Text = QuyNamPhieu;
            LoadThongTinNhanVien();
            LoadDataBVTaiChinh();

            CreateTableCopyTC();
            //CreateTableCopyKH();
            //CreateTableCopyVH();
            //CreateTableCopyPT();

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
        }
        private void LoadDataBVKhachHang()
        {
            msql = "SELECT * FROM dbo.KPI INNER JOIN dbo.ChiTietTieuChiMucTieuBV ON dbo.KPI.MaKPI = dbo.ChiTietTieuChiMucTieuBV.MaKPI INNER JOIN dbo.KPI_BenhVien ON dbo.ChiTietTieuChiMucTieuBV.MaPhieuKPIBV = dbo.KPI_BenhVien.MaPhieuKPIBV WHERE dbo.KPI.TieuChiID = 'C' AND dbo.KPI_BenhVien.NamPhieu = '" + QuyNamPhieu + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "KhachHang");
            dgrBVMucTieuKhachHang.AutoGenerateColumns = false;
            dgrBVMucTieuKhachHang.DataSource = tb;

            lbYearKH.Text = dgrBVMucTieuKhachHang.Rows[0].Cells["cNamBVKH"].Value.ToString();
            lbTSKH.Text = dgrBVMucTieuKhachHang.Rows[0].Cells["cTrongSoTieuChiBVKH"].Value.ToString();
        }
        private void LoadDataBVVanHanh()
        {
            msql = "SELECT * FROM dbo.KPI INNER JOIN dbo.ChiTietTieuChiMucTieuBV ON dbo.KPI.MaKPI = dbo.ChiTietTieuChiMucTieuBV.MaKPI INNER JOIN dbo.KPI_BenhVien ON dbo.ChiTietTieuChiMucTieuBV.MaPhieuKPIBV = dbo.KPI_BenhVien.MaPhieuKPIBV WHERE dbo.KPI.TieuChiID = 'B' AND dbo.KPI_BenhVien.NamPhieu = '" + QuyNamPhieu + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "VanHanh");
            dgrBVMucTieuVanHanh.AutoGenerateColumns = false;
            dgrBVMucTieuVanHanh.DataSource = tb;

            lbYearVH.Text = dgrBVMucTieuVanHanh.Rows[0].Cells["cNamBVVH"].Value.ToString();
            lbTSVH.Text = dgrBVMucTieuVanHanh.Rows[0].Cells["cTrongSoTieuChiBVVH"].Value.ToString();
        }
        private void LoadDataBVPhatTrien()
        {
            msql = "SELECT * FROM dbo.KPI INNER JOIN dbo.ChiTietTieuChiMucTieuBV ON dbo.KPI.MaKPI = dbo.ChiTietTieuChiMucTieuBV.MaKPI INNER JOIN dbo.KPI_BenhVien ON dbo.ChiTietTieuChiMucTieuBV.MaPhieuKPIBV = dbo.KPI_BenhVien.MaPhieuKPIBV WHERE dbo.KPI.TieuChiID = 'L' AND dbo.KPI_BenhVien.NamPhieu = '" + QuyNamPhieu + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "PhatTrien");
            dgrBVMucTieuPhatTrien.AutoGenerateColumns = false;
            dgrBVMucTieuPhatTrien.DataSource = tb;

            lbYearPT.Text = dgrBVMucTieuPhatTrien.Rows[0].Cells["cNamBVPT"].Value.ToString();
            lbTSPT.Text = dgrBVMucTieuPhatTrien.Rows[0].Cells["cTrongSoTieuChiBVPT"].Value.ToString();
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
            if (dgrNhapMucTieuTaiChinh.Rows.Count > 0)
            {
                switch (step)
                {
                    case 1:
                        int totaltc = 0;
                        for (int i = 0; i < dgrNhapMucTieuTaiChinh.Rows.Count; i++)
                        {
                            totaltc += int.Parse(dgrNhapMucTieuTaiChinh.CurrentRow.Cells["cTrongSoKPINTC"].Value.ToString());
                        }
                        if (totaltc == 0 && totaltc == null)
                        {
                            ev.QFrmThongBao("Lưu ý: Chưa nhập tỷ trọng");
                        }
                        else if (totaltc > 100)
                        {
                            ev.QFrmThongBaoError("Trọng số đã vượt quá 100%");
                        }
                        else if (totaltc > 0 && totaltc <= 100 && int.Parse(txtTongTrongSoTC.Text) > 0 && int.Parse(txtTongTrongSoTC.Text) <= 100)
                        {
                            if (ev.QFrmThongBao_YesNo("Lưu ý: Kiểm tra tỷ trọng chưa được 100%. Bạn có muốn tiếp tục không?"))
                            {
                                CopyTCtoHT();
                                LoadDataBVKhachHang();
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
                        int totalkh = 0;
                        for (int i = 0; i < dgrNhapMucTieuKhachHang.Rows.Count; i++)
                        {
                            totalkh += int.Parse(dgrNhapMucTieuKhachHang.CurrentRow.Cells["cTrongSoKPINKH"].Value.ToString());
                        }
                        if (totalkh == 0 && totalkh == null)
                        {
                            ev.QFrmThongBao("Lưu ý: Chưa nhập tỷ trọng");
                        }
                        else if (totalkh > 100)
                        {
                            ev.QFrmThongBaoError("Trọng số đã vượt quá 100%");
                        }
                        else if (totalkh > 0 && totalkh <= 100 && int.Parse(txtTongTrongSoKH.Text) > 0 && int.Parse(txtTongTrongSoKH.Text) <= 100)
                        {
                            if (ev.QFrmThongBao_YesNo("Lưu ý: Kiểm tra tỷ trọng chưa được 100%. Bạn có muốn tiếp tục không?"))
                            {
                                CopyKHtoHT();
                                LoadDataBVVanHanh();
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
                        int totalvh = 0;
                        for (int i = 0; i < dgrNhapMucTieuVanHanh.Rows.Count; i++)
                        {
                            totalvh += int.Parse(dgrNhapMucTieuVanHanh.CurrentRow.Cells["cTrongSoKPINVH"].Value.ToString());
                        }
                        if (totalvh == 0 && totalvh == null)
                        {
                            ev.QFrmThongBao("Lưu ý: Chưa nhập tỷ trọng");
                        }
                        else if (totalvh > 100)
                        {
                            ev.QFrmThongBaoError("Trọng số đã vượt quá 100%");
                        }
                        else if (totalvh > 0 && totalvh <= 100 && int.Parse(txtTongTrongSoVH.Text) > 0 && int.Parse(txtTongTrongSoVH.Text) <= 100)
                        {
                            if (ev.QFrmThongBao_YesNo("Lưu ý: Kiểm tra tỷ trọng chưa được 100%. Bạn có muốn tiếp tục không?"))
                            {
                                CopyVHtoHT();
                                LoadDataBVPhatTrien();
                            }
                            else
                            {

                            }
                        }
                        else if (totalvh == null && int.Parse(txtTongTrongSoKH.Text) == null)
                        {
                            ev.QFrmThongBaoError("Lỗi không có dữ liệu");
                        }
                        break;
                    case 4:
                        int totalpt = 0;
                        for (int i = 0; i < dgrNhapMucTieuPhatTrien.Rows.Count; i++)
                        {
                            totalpt += int.Parse(dgrNhapMucTieuPhatTrien.CurrentRow.Cells["cTrongSoKPINPT"].Value.ToString());
                        }
                        if (totalpt == 0 && totalpt == null)
                        {
                            ev.QFrmThongBao("Lưu ý: Chưa nhập tỷ trọng");
                        }
                        else if (totalpt > 100)
                        {
                            ev.QFrmThongBaoError("Trọng số đã vượt quá 100%");
                        }
                        else if (totalpt > 0 && totalpt <= 100 && int.Parse(txtTongTrongSoPT.Text) > 0 && int.Parse(txtTongTrongSoPT.Text) <= 100)
                        {
                            if (ev.QFrmThongBao_YesNo("Lưu ý: Kiểm tra tỷ trọng chưa được 100%. Bạn có muốn tiếp tục không?"))
                            {
                                CopyPTtoHT();
                            }
                            else
                            {

                            }
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

        private void dgrNhapMucTieuTaiChinh_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrNhapMucTieuTaiChinh);
        }
        private void btnTTKH_Click(object sender, EventArgs e)
        {
            dgrHTMucTieuTaiChinh.Rows.Clear();
            KiemTraTyTrong(1); 
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
            ChuyenTrangThai(4);
        }
       
        #endregion
        #region Copy GridView

        #region Method
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
                    newRow["cNamcpTC"] = dgrBVMucTieuTaiChinh.Rows[i].Cells["cNamBVTC"].Value.ToString();
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
                    newRow["cNamcpKH"] = dgrBVMucTieuKhachHang.Rows[i].Cells["cNamBVKH"].Value.ToString();
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
            dgrBVMucTieuKhachHang.DataSource = kh;
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
                    newRow["cNamcpVH"] = dgrBVMucTieuVanHanh.Rows[i].Cells["cNamBVVH"].Value.ToString();
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
            dgrBVMucTieuVanHanh.DataSource = vh;
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
                    newRow["cNamcpPT"] = dgrBVMucTieuPhatTrien.Rows[i].Cells["cNamBVPT"].Value.ToString();
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
            dgrBVMucTieuPhatTrien.DataSource = pt;
        }

        private void CreateTableCopyTC()
        {
            tc.Columns.Add("cMaKPIcpTC", typeof(string));
            tc.Columns.Add("cNoiDungcpTC", typeof(string));
            tc.Columns.Add("cNamcpTC", typeof(int));
            tc.Columns.Add("TrongSocpTC", typeof(int));
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = tc.Columns["cMaKPIcpTC"];
            tc.PrimaryKey = PrimaryKeyColumns;
        }
        private void CreateTableCopyKH()
        {
            kh.Columns.Add("cMaKPIcpKH", typeof(string));
            kh.Columns.Add("cNoiDungcpKH", typeof(string));
            kh.Columns.Add("cNamcpKH", typeof(int));
            kh.Columns.Add("TrongSocpKH", typeof(int));
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = kh.Columns["cMaKPIcpKH"];
            kh.PrimaryKey = PrimaryKeyColumns;
        }
        private void CreateTableCopyVH()
        {
            vh.Columns.Add("cMaKPIcpVH", typeof(string));
            vh.Columns.Add("cNoiDungcpVH", typeof(string));
            vh.Columns.Add("cNamcpVH", typeof(int));
            vh.Columns.Add("TrongSocpVH", typeof(int));
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = vh.Columns["cMaKPIcpVH"];
            vh.PrimaryKey = PrimaryKeyColumns;
        }
        private void CreateTableCopyPT()
        {
            pt.Columns.Add("cMaKPIcpPT", typeof(string));
            pt.Columns.Add("cNoiDungcpPT", typeof(string));
            pt.Columns.Add("cNamcpPT", typeof(int));
            pt.Columns.Add("TrongSocpPT", typeof(int));
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = pt.Columns["cMaKPIcpPT"];
            pt.PrimaryKey = PrimaryKeyColumns;
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
            for (int j = 0; j < dgrNhapMucTieuKhachHang.Rows.Count; j++)
            {
                foreach (DataRow row in kh.Rows)
                {
                    String id = Convert.ToString(row["cMaKPIcpKH"]);
                    if (id == Convert.ToString(dgrNhapMucTieuKhachHang.Rows[j].Cells["cMaKPIBVKH"].Value))
                    {
                        dgrNhapMucTieuKhachHang.Rows[j].Cells["cTrongSocpKH"].Value = row["TrongSocpKH"].ToString();
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
            for (int j = 0; j < dgrNhapMucTieuVanHanh.Rows.Count; j++)
            {
                foreach (DataRow row in vh.Rows)
                {
                    String id = Convert.ToString(row["cMaKPIcpVH"]);
                    if (id == Convert.ToString(dgrNhapMucTieuVanHanh.Rows[j].Cells["cMaKPIBVVH"].Value))
                    {
                        dgrNhapMucTieuVanHanh.Rows[j].Cells["cTrongSocpVH"].Value = row["TrongSocpVH"].ToString();
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
            for (int j = 0; j < dgrNhapMucTieuPhatTrien.Rows.Count; j++)
            {
                foreach (DataRow row in pt.Rows)
                {
                    String id = Convert.ToString(row["cMaKPIcpPT"]);
                    if (id == Convert.ToString(dgrNhapMucTieuPhatTrien.Rows[j].Cells["cMaKPIBVPT"].Value))
                    {
                        dgrNhapMucTieuPhatTrien.Rows[j].Cells["cTrongSocpPT"].Value = row["TrongSocpPT"].ToString();
                    }
                }
            }
        }
        private void TinhTrongSoTC()
        {
            int sc = dgrNhapMucTieuTaiChinh.Rows.Count;
            double sum = 0;
            for (int i = 0; i < sc; ++i)
                sum += double.Parse(dgrNhapMucTieuTaiChinh.Rows[i].Cells["cTrongSoKPINTC"].Value.ToString());
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
        private void TinhTrongSoKH()
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
        private void TinhTrongSoVH()
        {
            int sc = dgrNhapMucTieuVanHanh.Rows.Count;
            double sum = 0;
            for (int i = 0; i < sc; ++i)
                sum += double.Parse(dgrNhapMucTieuVanHanh.Rows[i].Cells["cTrongSoKPINVH"].Value.ToString());
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
        private void TinhTrongSoPT()
        {
            int sc = dgrNhapMucTieuPhatTrien.Rows.Count;
            double sum = 0;
            for (int i = 0; i < sc; ++i)
                sum += double.Parse(dgrNhapMucTieuPhatTrien.Rows[i].Cells["cTrongSoKPINPT"].Value.ToString());
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
        private void dgrNhapMucTieuVanHanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgrNhapMucTieuVanHanh.Rows.Count && e.ColumnIndex == 0)
            {
                foreach (DataGridViewRow row in dgrBVMucTieuVanHanh.Rows)
                {
                    if (dgrNhapMucTieuVanHanh.Rows[e.RowIndex].Cells["cMaKPINVH"].Value.ToString() == row.Cells["cMaKPINVH"].Value.ToString())
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
                    if (dgrNhapMucTieuPhatTrien.Rows[e.RowIndex].Cells["cMaKPINPT"].Value.ToString() == row.Cells["cMaKPINPT"].Value.ToString())
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
        private void dgrNhapMucTieuTaiChinh_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == dgrNhapMucTieuTaiChinh.Columns["cTrongSoKPINTC"].Index)
            {
                string userInput = e.FormattedValue.ToString();
                int parsedValue;

                if (!int.TryParse(userInput, out parsedValue))
                {
                    ev.QFrmThongBaoError("Chỉ được nhập số không nhận chữ cái");
                    dgrNhapMucTieuTaiChinh.CancelEdit();
                }
            }
        }
        private void dgrNhapMucTieuKhachHang_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == dgrNhapMucTieuKhachHang.Columns["cTrongSoKPINKH"].Index)
            {
                string userInput = e.FormattedValue.ToString();
                int parsedValue;

                if (!int.TryParse(userInput, out parsedValue))
                {
                    ev.QFrmThongBaoError("Chỉ được nhập số không nhận chữ cái");
                    dgrNhapMucTieuKhachHang.CancelEdit();
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
                    ev.QFrmThongBaoError("Chỉ được nhập số không nhận chữ cái");
                    dgrNhapMucTieuVanHanh.CancelEdit();
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
                    ev.QFrmThongBaoError("Chỉ được nhập số không nhận chữ cái");
                    dgrNhapMucTieuPhatTrien.CancelEdit();
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
            TinhTrongSoTC();
            TinhTrongSoTC();
        }
        private void dgrNhapMucTieuKhachHang_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            TinhTrongSoKH();
            TinhTrongSoKH();
        }
        private void dgrNhapMucTieuVanHanh_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            TinhTrongSoVH();
            TinhTrongSoVH();
        }
        private void dgrNhapMucTieuPhatTrien_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            TinhTrongSoPT();
            TinhTrongSoPT();
        }
        //ColumnHeaderMouseClick
        private void dgrBVMucTieuTaiChinh_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                for (int i = 0; i < dgrBVMucTieuTaiChinh.Rows.Count; i++)
                {
                    dgrBVMucTieuTaiChinh.Rows[i].Cells["cChonTatCaBVTC"].Value = true;
                }
            }
            LoadDataTableTC();
        }
        private void dgrBVMucTieuKhachHang_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                for (int i = 0; i < dgrBVMucTieuKhachHang.Rows.Count; i++)
                {
                    dgrBVMucTieuKhachHang.Rows[i].Cells["cChonTatCaBVKH"].Value = true;
                }
            }
            LoadDataTableKH();
        }
        private void dgrBVMucTieuVanHanh_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                for (int i = 0; i < dgrBVMucTieuVanHanh.Rows.Count; i++)
                {
                    dgrBVMucTieuVanHanh.Rows[i].Cells["cChonTatCaBVVH"].Value = true;
                }
            }
            LoadDataTableVH();
        }

        private void dgrBVMucTieuPhatTrien_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                for (int i = 0; i < dgrBVMucTieuPhatTrien.Rows.Count; i++)
                {
                    dgrBVMucTieuPhatTrien.Rows[i].Cells["cChonTatCaBVPT"].Value = true;
                }
            }
            LoadDataTablePT();
        }

        private void dgrNhapMucTieuTaiChinh_ColumnHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                for (int i = 0; i < dgrBVMucTieuTaiChinh.Rows.Count; i++)
                {
                    dgrBVMucTieuTaiChinh.Rows[i].Cells["cChonTatCaBVTC"].Value = false;
                }
            }
            LoadDataTableTC();
        }
        private void dgrNhapMucTieuKhachHang_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                for (int i = 0; i < dgrNhapMucTieuKhachHang.Rows.Count; i++)
                {
                    dgrNhapMucTieuKhachHang.Rows[i].Cells["cChonTatCaBVKH"].Value = false;
                }
            }
            LoadDataTableKH();
        }
        private void dgrNhapMucTieuVanHanh_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                for (int i = 0; i < dgrNhapMucTieuVanHanh.Rows.Count; i++)
                {
                    dgrNhapMucTieuVanHanh.Rows[i].Cells["cChonTatCaBVVH"].Value = false;
                }
            }
            LoadDataTableVH();
        }
        private void dgrNhapMucTieuPhatTrien_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                for (int i = 0; i < dgrNhapMucTieuPhatTrien.Rows.Count; i++)
                {
                    dgrNhapMucTieuPhatTrien.Rows[i].Cells["cChonTatCaBVPT"].Value = false;
                }
            }
            LoadDataTablePT();
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
    }
}