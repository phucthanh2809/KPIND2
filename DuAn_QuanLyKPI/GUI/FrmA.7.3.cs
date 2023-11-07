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
    public partial class FrmA73 : DevExpress.XtraEditors.XtraForm
    {
        //public static string MaNV = FrmDangNhapTest.MaNV;
        //public static string MaPhongKhoa = FrmDangNhapTest.MaPhongKhoa;
        //public static string MaChucDanh = FrmDangNhapTest.MaChucDanh;
        public static string mconnectstring = "server=192.168.50.108,1433;database= QuanLyKPI; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;

        private int CurrentTab = 0;
        public FrmA73()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            msql = "select * from BangTamMucTieuKhoaPhong";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "BangTamMucTieuKhoaPhong");
            dgrTaiChinh.AutoGenerateColumns = false;
            dgrTaiChinh.DataSource = tb;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTiepTucTaiChinh_Click(object sender, EventArgs e)
        {
            KiemTraTyTrong();
        }

        private void btnQuayLaiKhachHang_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai(0);
        }

        private void btnTiepTucKhachHang_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai(2);
        }

        private void btnQuayLaiVanHanh_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai(1);
        }

        private void btnTiepTucVanHanh_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai(3);
        }

        private void btnQuayLaiPhatTrien_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai(2);
        }

        private void btnTiepTucPhatTrien_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai(4);
        }

        private void btnQuayLaiHoanThanh_Click(object sender, EventArgs e)
        {
            ChuyenTrangThai(3);
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
            //TrangThai4();
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
        private void TrangThai()
        {

            FrmSPTrangThai.ItemOptions.Indicator.Width = 50; // độ dài item
            FrmSPTrangThai.ConnectorLineThickness = 2; // viền đường kết nối
            FrmSPTrangThai.IndicatorLineThickness = 2; // viền đường tròn
            FrmSPTrangThai.ItemOptions.ConnectorOffset = -20; // điểm bắt đầu, kết thúc
            FrmSPTrangThai.ItemOptions.Indicator.ActiveStateDrawMode = IndicatorDrawMode.Outline; //click xanh viền tròn
            FrmSPTrangThai.ItemOptions.Indicator.InactiveStateDrawMode = IndicatorDrawMode.Outline; // chưa click viền tròn
            spTC.State = StepProgressBarItemState.Active;

        }
        private void TrangThai1()
        {
            FrmSPTrangThai1.ItemOptions.Indicator.Width = 50; // độ dài item
            FrmSPTrangThai1.ConnectorLineThickness = 2; // viền đường kết nối
            FrmSPTrangThai1.IndicatorLineThickness = 2; // viền đường tròn
            FrmSPTrangThai1.ItemOptions.ConnectorOffset = -20; // điểm bắt đầu, kết thúc
            FrmSPTrangThai1.ItemOptions.Indicator.ActiveStateDrawMode = IndicatorDrawMode.Outline; //click xanh viền tròn
            FrmSPTrangThai1.ItemOptions.Indicator.InactiveStateDrawMode = IndicatorDrawMode.Outline; // chưa click viền tròn
            Khach_hang.State = StepProgressBarItemState.Active;

        }
        private void TrangThai2()
        {
            FrmSPTrangThai2.ItemOptions.Indicator.Width = 50; // độ dài item
            FrmSPTrangThai2.ConnectorLineThickness = 2; // viền đường kết nối
            FrmSPTrangThai2.IndicatorLineThickness = 2; // viền đường tròn
            FrmSPTrangThai2.ItemOptions.ConnectorOffset = -20; // điểm bắt đầu, kết thúc
            FrmSPTrangThai2.ItemOptions.Indicator.ActiveStateDrawMode = IndicatorDrawMode.Outline; //click xanh viền tròn
            FrmSPTrangThai2.ItemOptions.Indicator.InactiveStateDrawMode = IndicatorDrawMode.Outline; // chưa click viền tròn
            Van_Hanh.State = StepProgressBarItemState.Active;
        }
        private void TrangThai3()
        {
            FrmSPTrangThai_3.ItemOptions.Indicator.Width = 50; // độ dài item
            FrmSPTrangThai_3.ConnectorLineThickness = 2; // viền đường kết nối
            FrmSPTrangThai_3.IndicatorLineThickness = 2; // viền đường tròn
            FrmSPTrangThai_3.ItemOptions.ConnectorOffset = -20; // điểm bắt đầu, kết thúc
            FrmSPTrangThai_3.ItemOptions.Indicator.ActiveStateDrawMode = IndicatorDrawMode.Outline; //click xanh viền tròn
            FrmSPTrangThai_3.ItemOptions.Indicator.InactiveStateDrawMode = IndicatorDrawMode.Outline; // chưa click viền tròn
            spTC3.State = StepProgressBarItemState.Active;
            spKH3.State = StepProgressBarItemState.Active;
        }
        //private void TrangThai4()
        //{
        //    FrmSPTrangThai4.ItemOptions.Indicator.Width = 50; // độ dài item
        //    FrmSPTrangThai4.ConnectorLineThickness = 2; // viền đường kết nối
        //    FrmSPTrangThai4.IndicatorLineThickness = 2; // viền đường tròn
        //    FrmSPTrangThai4.ItemOptions.ConnectorOffset = -20; // điểm bắt đầu, kết thúc
        //    FrmSPTrangThai4.ItemOptions.Indicator.ActiveStateDrawMode = IndicatorDrawMode.Outline; //click xanh viền tròn
        //    FrmSPTrangThai4.ItemOptions.Indicator.InactiveStateDrawMode = IndicatorDrawMode.Outline; // chưa click viền tròn
        //    spTaiChinh4.State = StepProgressBarItemState.Active;
        //    spKhachHang4.State = StepProgressBarItemState.Active;
        //    spVanHanh4.State = StepProgressBarItemState.Active;
        //}
        void ChuyenTrangThai(int step)
        {
            CurrentTab = step;
            switch (step)
            {
                case 0:
                    FrmSPTrangThai3.SelectTab(step);
                    break;
                case 1:
                    FrmSPTrangThai3.SelectTab(step);
                    // Thiết lập Trạng thái khi nhất nút
                    spTC1.State = StepProgressBarItemState.Active;
                    FrmSPTrangThai.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage = svgImageCollection1[0];
                    FrmSPTrangThai.Appearances.CommonActiveColor = Color.Green;
                    FrmSPTrangThai.Items[step - 1].ContentBlock2.Caption = "Đã xong Tài Chính";
                    break;
                case 2:
                    FrmSPTrangThai3.SelectTab(step);
                    // Thiết lập Trạng thái khi nhất nút
                    spKH2.State = StepProgressBarItemState.Active;
                    FrmSPTrangThai1.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage = svgImageCollection1[0];
                    FrmSPTrangThai1.Appearances.CommonActiveColor = Color.Green;
                    FrmSPTrangThai1.Items[step - 1].ContentBlock2.Caption = "Đã xong Khách Hàng";
                    break;
                case 3:
                    FrmSPTrangThai3.SelectTab(step);
                    // Thiết lập Trạng thái khi nhất nút
                    spVH3.State = StepProgressBarItemState.Active;
                    FrmSPTrangThai2.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage = svgImageCollection1[0];
                    FrmSPTrangThai2.Appearances.CommonActiveColor = Color.Green;
                    FrmSPTrangThai2.Items[step - 1].ContentBlock2.Caption = "Đã xong Vận Hành";
                    break;
                case 4:
                    FrmSPTrangThai3.SelectTab(step);
                    spPT3.State = StepProgressBarItemState.Active;
                    FrmSPTrangThai3.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage = svgImageCollection1[0];
                    FrmSPTrangThai3.Appearances.CommonActiveColor = Color.Green;
                    FrmSPTrangThai3.Items[step - 1].ContentBlock2.Caption = "Đã xong Phát Triển";
                    break;
            }
        }
        private void tabMucTieuKhoaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //chặn click vào tab
            FrmSPTrangThai3.SelectedIndex = CurrentTab;
        }

        private void txtMucTieu_Click(object sender, EventArgs e)
        {
        }

        private void txtMucTieu_Enter(object sender, EventArgs e)
        {
            LoadDataMucTieu();
            dgrChonMucTieu.Visible = true;

        }

        private void LoadDataMucTieu()
        {
            msql = "select * from [KPITrongNganHang] as A, [NganHangKPI] as B, [KPI] as C where A.MaKPI = C.MaKPI and A.MaNganHangKPI = B.MaNganHangKPI and B.MaPK='" + MaPhongKhoa + "' and B.MaChucDanh='" + MaChucDanh + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "KPITrongNganHang");
            dgrChonMucTieu.AutoGenerateColumns = false;
            dgrChonMucTieu.DataSource = tb;
            //var list = DataProvider.Ins.DB.KPI.Where(x => x.NganHangKPI.Any(a => a.MaPK == MaPhongKhoa)).ToList();
            //dgrChonMucTieu.AutoGenerateColumns = false;
            //dgrChonMucTieu.DataSource = list;
        }

        private void dgrChonMucTieu_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrChonMucTieu);
        }
        private void dgrTaiChinh_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrTaiChinh);
        }
        private void txtTrongSoTC_Click(object sender, EventArgs e)
        {
            dgrChonMucTieu.Visible = false;
        }

        private void txtTieuChiDanhGiaTC_Click(object sender, EventArgs e)
        {
            dgrChonMucTieu.Visible = false;
        }

        private void txtHoanThanhTC_Click(object sender, EventArgs e)
        {
            dgrChonMucTieu.Visible = false;
        }
        private void dgrChonMucTieu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt.Text = dgrChonMucTieu.CurrentRow.Cells["cNoiDung"].Value.ToString();
            dgrChonMucTieu.Visible = false;
        }

        private void txtMucTieu_Leave(object sender, EventArgs e)
        {
            //txtMucTieu.Text = dgrChonMucTieu.CurrentRow.Cells["cNoiDung"].Value.ToString();

        }
        private void txtMucTieu_TextChanged(object sender, EventArgs e)
        {
            dgrChonMucTieu.Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemDuLieu();
            LoadData();
            XoaThongTin();
        }
        private void ThemDuLieu()
        {
            //// Lấy tổng các giá trị trong các cột
            //int total = 0;
            //for (int i = 0; i < dgrTaiChinh.Rows.Count; i++)
            //{
            //    total += int.Parse(dgrTaiChinh.CurrentRow.Cells["cTrongSo"].Value.ToString());
            //}

            //int value = int.Parse(txtTrongSoTC.Text);
            //int tytrong = total + value;
            //// Kiểm tra giá trị
            //if (tytrong > 100)
            //{
            //    ev.QFrmThongBao("Lưu ý: Tỷ trọng vượt quá 100%");
            //}
            //else 
            //{
            //    msql = "INSERT INTO [dbo].[BangTamMucTieuKhoaPhong]([MaKPI],[MucTieu],[TrongSo],[TieuChiDanhGia],[HoanThanh])" +
            //    "VALUES ('" + txtMaKPITC.Text + "', N'" + txtMucTieuTC.Text + "', '" + txtTrongSoTC.Text + "', N'" + txtTieuChiDanhGiaTC.Text + "', '" + txtHoanThanhTC.Text + "')";
            //    comm.RunSQL(mconnectstring, msql);
            //    ev.QFrmThongBao("Đã thêm thành công");
            //}


            {
                // Khai báo biến tổng và biến đếm
                int total = 0;
                int count = 0;

                // Vòng lặp duyệt qua tất cả các hàng trong bảng
                for (int i = 0; i < dgrTaiChinh.Rows.Count; i++)
                {
                    // Lấy giá trị trong cột tỷ trọng của hàng hiện tại
                    int trongSo = int.Parse(dgrTaiChinh.CurrentRow.Cells["cTrongSo"].Value.ToString());

                    // Thêm giá trị này vào biến tổng
                    total += trongSo;

                    // Tăng biến đếm lên 1
                    count++;

                }
                if (total > 100)
                {
                    ev.QFrmThongBao("Lưu ý: Tỷ trọng vượt quá 100%");
                }
                else
                {
                    msql = "INSERT INTO [dbo].[BangTamMucTieuKhoaPhong]([MaKPI],[MucTieu],[TrongSo],[TieuChiDanhGia],[HoanThanh])" +
                    "VALUES ('" + txtMaKPITC.Text + "', N'" + txt.Text + "', '" + TC.Text + "', N'" + txtTieuChiDanhGiaTC.Text + "', '" + txtHoanThanhTC.Text + "')";
                    comm.RunSQL(mconnectstring, msql);
                    ev.QFrmThongBao("Đã thêm thành công");
                }
            }




        }
        private void KiemTraTyTrong()
        {
            // Lấy tổng các giá trị trong các cột
            int total = 0;
            for (int i = 1; i < dgrTaiChinh.Rows.Count; i++)
            {
                total += int.Parse(dgrTaiChinh.CurrentRow.Cells["cTrongSo"].Value.ToString());
            }

            // Kiểm tra tổng các giá trị
            if (total > 100)
            {
                ev.QFrmThongBao("Lưu ý: Kiểm tra tỷ trọng vượt quá 100%");

            }
            else
            {
                // Thông báo
                ChuyenTrangThai(1);
            }

        }
        private void XoaThongTin()
        {
            txtMaKPITC.Text = "";
            txt.Text = "";
            TC.Text = "";
            txtTieuChiDanhGiaTC.Text = "";
            txtHoanThanhTC.Text = "";
        }

        private void tabMucTieuKhoaPhong_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void xFilteg5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void tabPhatTrien_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtViTriCV_TextChanged(object sender, EventArgs e)
        {

        }

        private void xFilteg4_TextChanged(object sender, EventArgs e)
        {

        }

        private void xFilteg7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtHoanThanhTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKhoaPhongTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmSPTrangThai_Click(object sender, EventArgs e)
        {

        }

        private void xFilteg15_TextChanged(object sender, EventArgs e)
        {

        }

        private void xFilteg1_TextChanged(object sender, EventArgs e)
        {

        }

        private void xFilteg14txtMaKPITC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void dgrKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtMucTieuTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxSearch2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKPITC_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void xFilteg8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void xFilteg3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTieuChiDanhGiaTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabVanHanh_Click(object sender, EventArgs e)
        {

        }

        private void tabTaiChinh_Click(object sender, EventArgs e)
        {

        }

        private void xFilteg10_TextChanged(object sender, EventArgs e)
        {

        }

        private void xFilteg11_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbTen_Click(object sender, EventArgs e)
        {

        }

        private void xFilteg13_TextChanged(object sender, EventArgs e)
        {

        }

        private void xFilteg14_TextChanged(object sender, EventArgs e)
        {

        }

        private void xFilteg12_TextChanged(object sender, EventArgs e)
        {

        }

        private void xFilteg17_TextChanged(object sender, EventArgs e)
        {

        }

        private void xFilteg18_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgrChonMucTieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xFilteg6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgrVanHanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTrongSoTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbViTriCV_Click(object sender, EventArgs e)
        {

        }

        private void stepProgressBar2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSearch3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void xFilteg2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void xFilteg9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void dgrTaiChinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void stepProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}