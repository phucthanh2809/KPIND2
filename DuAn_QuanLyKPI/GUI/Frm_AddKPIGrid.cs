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
            dgrNganHangCaNhan.Visible = false;
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
            dgrNganHangCaNhan.Visible = true;
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
                        dgrNganHangCaNhan.AutoGenerateColumns = false;
                        dgrNganHangCaNhan.DataSource = tc;
                        break;
                    case "kh":
                        dgrKPIBenhVien.Visible = false;
                        dgrNganHangCaNhan.Visible = true;
                        chkCongViecCaNhanCaNhan.Visible = true;
                        chkCongViecCaNhanNganHangKPI.Visible = false;
                        msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'C' and [Nam] = " + nmYear.Value + " " +
                               "and [CongViecCaNhan] = '" + chkCongViecCaNhanNganHangKPI.Checked + "' and [CongViecCaNhan] = 1";
                        DataTable kh = comm.GetDataTable(mconnectstring, msql, "KPINH");
                        dgrKPIBenhVien.AutoGenerateColumns = false;
                        dgrKPIBenhVien.DataSource = kh;
                        break;
                    case "vh":
                        dgrKPIBenhVien.Visible = false;
                        dgrNganHangCaNhan.Visible = true;
                        chkCongViecCaNhanCaNhan.Visible = true;
                        chkCongViecCaNhanNganHangKPI.Visible = false;
                        msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'B' and [Nam] = " + nmYear.Value + " " +
                               "and [CongViecCaNhan] = '" + chkCongViecCaNhanNganHangKPI.Checked + "' and [CongViecCaNhan] = 1";
                        DataTable vh = comm.GetDataTable(mconnectstring, msql, "KPINH");
                        dgrKPIBenhVien.AutoGenerateColumns = false;
                        dgrKPIBenhVien.DataSource = vh;
                        break;
                    case "pt":
                        dgrKPIBenhVien.Visible = false;
                        dgrNganHangCaNhan.Visible = true;
                        chkCongViecCaNhanCaNhan.Visible = true;
                        chkCongViecCaNhanNganHangKPI.Visible = false;
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
                        dgrKPIBenhVien.Visible = false;
                        dgrNganHangCaNhan.Visible = true;
                        chkCongViecCaNhanCaNhan.Visible = true;
                        chkCongViecCaNhanNganHangKPI.Visible = false;
                        msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'F' and [Nam] = " + nmYear.Value + " " +
                               "and [CongViecCaNhan] = '" + chkCongViecCaNhanNganHangKPI.Checked + "'";
                        DataTable tc = comm.GetDataTable(mconnectstring, msql, "KPINH");
                        dgrNganHangCaNhan.AutoGenerateColumns = false;
                        dgrNganHangCaNhan.DataSource = tc;
                        break;
                    case "kh":
                        dgrKPIBenhVien.Visible = false;
                        dgrNganHangCaNhan.Visible = true;
                        chkCongViecCaNhanCaNhan.Visible = true;
                        chkCongViecCaNhanNganHangKPI.Visible = false;
                        msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'C' and [Nam] = " + nmYear.Value + " " +
                               "and [CongViecCaNhan] = '" + chkCongViecCaNhanNganHangKPI.Checked + "'";
                        DataTable kh = comm.GetDataTable(mconnectstring, msql, "KPINH");
                        dgrKPIBenhVien.AutoGenerateColumns = false;
                        dgrKPIBenhVien.DataSource = kh;
                        break;
                    case "vh":
                        dgrKPIBenhVien.Visible = false;
                        dgrNganHangCaNhan.Visible = true;
                        chkCongViecCaNhanCaNhan.Visible = true;
                        chkCongViecCaNhanNganHangKPI.Visible = false;
                        msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where[MaNV] = 456789 and[TieuChiID] = 'B' and [Nam] = " + nmYear.Value + " " +
                               "and [CongViecCaNhan] = '" + chkCongViecCaNhanNganHangKPI.Checked + "'";
                        DataTable vh = comm.GetDataTable(mconnectstring, msql, "KPINH");
                        dgrKPIBenhVien.AutoGenerateColumns = false;
                        dgrKPIBenhVien.DataSource = vh;
                        break;
                    case "pt":
                        dgrKPIBenhVien.Visible = false;
                        dgrNganHangCaNhan.Visible = true;
                        chkCongViecCaNhanCaNhan.Visible = true;
                        chkCongViecCaNhanNganHangKPI.Visible = false;
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

        private void dgrNganHangCaNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}