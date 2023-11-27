﻿using DevExpress.XtraEditors;
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
        public static string MaNV = Frm_Login.MaNV;
        public static string MaPhongKhoa = Frm_Login.MaPhongKhoa;
        public static string MaChucDanh = Frm_Login.MaChucDanh;
        public static string TenNV = Frm_Login.TenNV;
        public static string TenChucDanh = Frm_Login.TenChucDanh;
        public static string TenPhongKhoa = Frm_Login.TenPhongKhoa;

        //coneect & event
        private static string mconnectstring = Frm_Chinh_GUI.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;

        private DataTable dataTable1;
        private DataTable dataTable2;

        private int CurrentTab = 0;
        public FrmA73()
        {
            InitializeComponent();
            LoadThongTinNhanVien();
            LoadDataBVTaiChinh();
            LoadDataBVKhachHang();
            LoadDataBVVanHanh();
            LoadDataBVPhatTrien();
        }
        #region LoadData
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
            msql = "SELECT * FROM [dbo].[ChiTietKPIKhoaPhong] as CTKPIKP, [dbo].[KPI_KhoaPhong] as KPIKP, [dbo].[ChiTietTieuChiMucTieuKhoaPhong] as CTTCMTKP, [dbo].[NhomTieuChi] as TC, [dbo].[KPI] as KPI, [dbo].[PhongKhoa] as PK, [dbo].[DanhsachBieuMau] as BM " +
                "WHERE CTTCMTKP.MaPhieuKPI = KPIKP.MaPhieuKPI and CTTCMTKP.MaKPI = KPI.MaKPI and CTTCMTKP.TieuChiID = TC.TieuChiID and CTKPIKP.ChitietID = KPIKP.IDChiTietKPIKP and KPIKP.TrangThai = 0 and KPIKP.MaPK = PK.MaPK and KPIKP.IDBieuMau = BM.IDBieuMau and KPIKP.TruongPK = 'False'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "Taichinh");
            dgrBVMucTieuTaiChinh.AutoGenerateColumns = false;
            dgrBVMucTieuTaiChinh.DataSource = tb;
        }
        private void LoadDataBVKhachHang()
        {
            msql = "select * from [dbo].[KPI] as KPI,[dbo].[KPI_KhoaPhong] as KPIKP,[dbo].[NhomTieuChi] as TC,[dbo].[PhongKhoa] as PK where KPI.MaKPI = KPIKP.MaKPI AND KPIKP.MaPK = PK.MaPK AND KPIKP.TieuChiID = TC.TieuChiID AND KPIKP.MaPK = '" + MaPhongKhoa + "' AND KPIKP.TieuChiID = 'C'AND KPI.CongViecCaNhan = 0 AND KPIKP.TrangThai = 0";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "KhachHang");
            dgrBVMucTieuKhachHang.AutoGenerateColumns = false;
            dgrBVMucTieuKhachHang.DataSource = tb;
        }
        private void LoadDataBVVanHanh()
        {
            msql = "select * from [dbo].[KPI] as KPI,[dbo].[KPI_KhoaPhong] as KPIKP,[dbo].[NhomTieuChi] as TC,[dbo].[PhongKhoa] as PK where KPI.MaKPI = KPIKP.MaKPI AND KPIKP.MaPK = PK.MaPK AND KPIKP.TieuChiID = TC.TieuChiID AND KPIKP.MaPK = '" + MaPhongKhoa + "' AND KPIKP.TieuChiID = 'B'AND KPI.CongViecCaNhan = 0 AND KPIKP.TrangThai = 0";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "VanHanh");
            dgrBVMucTieuVanHanh.AutoGenerateColumns = false;
            dgrBVMucTieuVanHanh.DataSource = tb;  
        }
        private void LoadDataBVPhatTrien()
        {
            msql = "select * from [dbo].[KPI] as KPI,[dbo].[KPI_KhoaPhong] as KPIKP,[dbo].[NhomTieuChi] as TC,[dbo].[PhongKhoa] as PK where KPI.MaKPI = KPIKP.MaKPI AND KPIKP.MaPK = PK.MaPK AND KPIKP.TieuChiID = TC.TieuChiID AND KPIKP.MaPK = '" + MaPhongKhoa + "' AND KPIKP.TieuChiID = 'L'AND KPI.CongViecCaNhan = 0 AND KPIKP.TrangThai = 0";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "VanHanh");
            dgrBVMucTieuPhatTrien.AutoGenerateColumns = false;
            dgrBVMucTieuPhatTrien.DataSource = tb;
        }


        #endregion


        #region Method
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
                    break;
                case 2:
                    tabMucTieuKhoaPhong.SelectTab(step);
                    // Thiết lập Trạng thái khi nhất nút
                    spKhachHang2.State = StepProgressBarItemState.Active;
                    FrmSPTrangThai2.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage = svgImageCollection1[0];
                    FrmSPTrangThai2.Appearances.CommonActiveColor = Color.Green;
                    FrmSPTrangThai2.Items[step - 1].ContentBlock2.Caption = "Đã xong Khách Hàng";
                    break;
                case 3:
                    tabMucTieuKhoaPhong.SelectTab(step);
                    // Thiết lập Trạng thái khi nhất nút
                    spVanHanh3.State = StepProgressBarItemState.Active;
                    FrmSPTrangThai3.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage = svgImageCollection1[0];
                    FrmSPTrangThai3.Appearances.CommonActiveColor = Color.Green;
                    FrmSPTrangThai3.Items[step - 1].ContentBlock2.Caption = "Đã xong Vận Hành";
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
        private void KiemTraTyTrong()
        {
            // Lấy tổng các giá trị trong các cột
            int total = 0;
            if (dgrNhapMucTieuTaiChinh.Rows.Count > 0)
            {
                for (int i = 0; i < dgrNhapMucTieuTaiChinh.Rows.Count; i++)
                {
                    total += int.Parse(dgrNhapMucTieuTaiChinh.CurrentRow.Cells["cTrongSoHT"].Value.ToString());
                }
                // Kiểm tra tổng các giá trị
                if (total == 0 && total == null)
                {
                    ev.QFrmThongBao("Lưu ý: Chưa nhập tỷ trọng");
                }
                else if (total > 100)
                {
                    ev.QFrmThongBao("Lưu ý: Kiểm tra tỷ trọng vượt quá 100%");
                }
                else if (total > 0 && total <= 100)
                {
                    ev.QFrmThongBao("Lưu ý: Kiểm tra tỷ trọng chưa được 100%");
                    ChuyenTrangThai(1);
                }
                else
                {
                    // Thông báo
                    ChuyenTrangThai(1);
                }
            }
            else
                {
                    ev.QFrmThongBaoError("Chưa có dữ liệu! Vui lòng kiểm tra lại");
                }    
        }
        //Method coppy data 
        #region Method Copy Data
        private void copyDataBVtoTC()
        {
            dgrNhapMucTieuTaiChinh.Rows.Clear();

            for (int i = 0; i < dgrBVMucTieuTaiChinh.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgrBVMucTieuTaiChinh.Rows[i].Cells["cChon"].Value) == true)
                {
                    int n = dgrNhapMucTieuTaiChinh.Rows.Add();
                    dgrNhapMucTieuTaiChinh.Rows[n].Cells["cNoiDungd"].Value = dgrBVMucTieuTaiChinh.Rows[i].Cells["cNoiDung"].Value.ToString();
                    dgrNhapMucTieuTaiChinh.Rows[n].Cells["cMaPhieuKPId"].Value = dgrBVMucTieuTaiChinh.Rows[i].Cells["cMaPhieuKPI"].Value.ToString();
                    dgrNhapMucTieuTaiChinh.Rows[n].Cells["cMaPhongKhoad"].Value = dgrBVMucTieuTaiChinh.Rows[i].Cells["cMaPhongKhoa"].Value.ToString();
                    dgrNhapMucTieuTaiChinh.Rows[n].Cells["cTieuChiIDd"].Value = dgrBVMucTieuTaiChinh.Rows[i].Cells["cTieuChiID"].Value.ToString();
                    dgrNhapMucTieuTaiChinh.Rows[n].Cells["cMaKPId"].Value = dgrBVMucTieuTaiChinh.Rows[i].Cells["cMaKPI"].Value.ToString();
                    dgrNhapMucTieuTaiChinh.Rows[n].Cells["cChiTieuHT"].Value = dgrBVMucTieuTaiChinh.Rows[i].Cells["cChiTieuBV"].Value.ToString();
                    dgrNhapMucTieuTaiChinh.Rows[n].Cells["cTrongSoHT"].Value = dgrBVMucTieuTaiChinh.Rows[i].Cells["cTrongSoBV"].Value.ToString();
                }
            }

        }
        private void copyDataBVtoKH()
        {
            dgrBVMucTieuTaiChinh.Rows.Clear();
            for (int i = 0; i < dgrNhapMucTieuTaiChinh.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgrNhapMucTieuTaiChinh.Rows[i].Cells["cChon"].Value) == true)
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
        //Event coppy gridview
        #region EventCopyData
        private void btnCoppyAll_Click(object sender, EventArgs e)
        {
            dgrNhapMucTieuTaiChinh.Rows.Clear();
            for (int i = 0; i < dgrBVMucTieuTaiChinh.Rows.Count; i++)
            {
                dgrBVMucTieuTaiChinh.Rows[i].Cells["cChon"].Value = true;
            }
            copyDataBVtoTC();
        }

        #endregion

        #region Event
        private void btnTiepTucTaiChinh_Click(object sender, EventArgs e)
        {
            KiemTraTyTrong();
        }

        private void btnQuayLaiKhachHang_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai(0);
        }
        private void btnQuayLaiVanHanh_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai(1);
        }
        private void btnTiepTucKhachHang_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai(2);
        }
        private void btnTiepTucVanHanh_Click_1(object sender, EventArgs e)
        {
            ChuyenTrangThai(3);
        }
        private void btnQuayLaiPhatTrien_Click_1(object sender, EventArgs e)
        {
            ChuyenTrangThai(2);
        }
        private void btnQuayLaiHoanThanh_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai(3);
        }
        private void btnTiepTucPhatTrien_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai(4);
        }
        private void btnHoanThanh_Click(object sender, EventArgs e)
        {

        }
        private void FrmA73_Load(object sender, EventArgs e)
        {
            TrangThai();
            TrangThai1();
            TrangThai2();
            TrangThai3();
            TrangThai4();

            //InVisible(tabTaiChinh);
            //InVisible(tabVanHanh);
            //InVisible(tabKhachHang);
            //InVisible(tabPhatTrien);
            //InVisible(tabHoanThanh);


        }
        //void InVisible(TabPage tab)
        //{
        //    tab.Text = "";

        //}

        private void tabMucTieuKhoaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //chặn click vào tab
            tabMucTieuKhoaPhong.SelectedIndex = CurrentTab;
        }

        private void txtMucTieu_Click(object sender, EventArgs e)
        {
        }

        private void txtMucTieu_Enter(object sender, EventArgs e)
        {
            //LoadDataMucTieu();
            //dgrChonMucTieu.Visible = true;

        }
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgrBVMucTieuTaiChinh.Rows.Count; i++)
            {
                dgrBVMucTieuTaiChinh.Rows[i].Cells["cChon"].Value = true;
            }
        }

        private void btnDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgrBVMucTieuTaiChinh.Rows.Count; i++)
            {
                dgrBVMucTieuTaiChinh.Rows[i].Cells["cChon"].Value = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(ev.QFrmThongBao_YesNo("Bạn có thật sự muốn xóa Form Nhập này không?"))
            {
                dgrNhapMucTieuTaiChinh.Rows.Clear();
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

        private void btnTiepTucTaiChinh_Click_1(object sender, EventArgs e)
        {
            KiemTraTyTrong();
        }
        private void btncopyDataBVtoTC_Click(object sender, EventArgs e)
        {
            if (ev.QFrmThongBao_YesNo("Hãy kiểm tra thật kĩ trước khi chuyển dữ liệu đã chọn nhé!"))
            {
                copyDataBVtoTC();
            }
        }




        #endregion


    }
}