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

        private static string phuongdien = FrmA73.phuongdien;


        public Frm_AddKPIGrid()
        {
            InitializeComponent();
            nmYear.Value = DateTime.Now.Year;
        }
        public void LoadNganHangKPI(string phuongdien)
        {
            switch (phuongdien)
            {
                case "tc":
                    dgrKPIBenhVien.Visible = true;
                    msql = "SELECT * FROM [QuanLyKPI].[dbo].[KPI] WHERE [TieuChiID] = 'F' ";
                    DataTable tc = comm.GetDataTable(mconnectstring, msql, "KPINH");
                    dgrKPIBenhVien.AutoGenerateColumns = false;
                    dgrKPIBenhVien.DataSource = tc;
                break;
                case "kh":
                    dgrKPIBenhVien.Visible = true;
                    msql = "SELECT * FROM [QuanLyKPI].[dbo].[KPI] WHERE [TieuChiID] = 'C'";
                    DataTable kh = comm.GetDataTable(mconnectstring, msql, "KPINH");
                    dgrKPIBenhVien.AutoGenerateColumns = false;
                    dgrKPIBenhVien.DataSource = kh;
               break;
                case "vh":
                    dgrKPIBenhVien.Visible = true;
                    msql = "SELECT * FROM [QuanLyKPI].[dbo].[KPI] WHERE [TieuChiID] = 'B'";
                    DataTable vh = comm.GetDataTable(mconnectstring, msql, "KPINH");
                    dgrKPIBenhVien.AutoGenerateColumns = false;
                    dgrKPIBenhVien.DataSource = vh;
                break;
                case "pt":
                    dgrKPIBenhVien.Visible = true;
                    msql = "SELECT * FROM [QuanLyKPI].[dbo].[KPI] WHERE [TieuChiID] = 'L'";
                    DataTable pt = comm.GetDataTable(mconnectstring, msql, "KPINH");
                    dgrKPIBenhVien.AutoGenerateColumns = false;
                    dgrKPIBenhVien.DataSource = pt;
                break;
            }     
        }
        public void LoadNganHangCaNhan(string phuongdien)
        {
            switch (phuongdien)
            {
                case "tc":
                    dgrNganHangCaNhan.Visible = true;
                    msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'F' and [Nam] = "+nmYear.Value+" " +
                           "and [CongViecCaNhan] = '"+chkCongViecCaNhan.Checked+"'";
                    DataTable tc = comm.GetDataTable(mconnectstring, msql, "KPINH");
                    dgrNganHangCaNhan.AutoGenerateColumns = false;
                    dgrNganHangCaNhan.DataSource = tc;
                    break;
                case "kh":
                    dgrKPIBenhVien.Visible = true;
                    msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'C' and [Nam] = " + nmYear.Value + " " +
                           "and [CongViecCaNhan] = '" + chkCongViecCaNhan.Checked + "'";
                    DataTable kh = comm.GetDataTable(mconnectstring, msql, "KPINH");
                    dgrKPIBenhVien.AutoGenerateColumns = false;
                    dgrKPIBenhVien.DataSource = kh;
                    break;
                case "vh":
                    dgrKPIBenhVien.Visible = true;
                    msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'B' and [Nam] = " + nmYear.Value + " " +
                           "and [CongViecCaNhan] = '" + chkCongViecCaNhan.Checked + "'";
                    DataTable vh = comm.GetDataTable(mconnectstring, msql, "KPINH");
                    dgrKPIBenhVien.AutoGenerateColumns = false;
                    dgrKPIBenhVien.DataSource = vh;
                    break;
                case "pt":
                    dgrKPIBenhVien.Visible = true;
                    msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'L' and [Nam] = " + nmYear.Value + " " +
                           "and [CongViecCaNhan] = '" + chkCongViecCaNhan.Checked + "'";
                    DataTable pt = comm.GetDataTable(mconnectstring, msql, "KPINH");
                    dgrKPIBenhVien.AutoGenerateColumns = false;
                    dgrKPIBenhVien.DataSource = pt;
                    break;
            }
        }
        private void btnNganHangKPI_Click(object sender, EventArgs e)
        {
            LoadNganHangKPI(phuongdien);
        }

        private void btnNganHangCaNhan_Click(object sender, EventArgs e)
        {
            LoadNganHangCaNhan(phuongdien);
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

        private void chkCongViecCaNhan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCongViecCaNhan.Checked == true)
            {

            }    
        }
    }
}