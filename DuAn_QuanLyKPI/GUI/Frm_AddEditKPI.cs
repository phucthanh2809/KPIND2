using BusinessCommon;
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

namespace DuAn_QuanLyKPI.GUI
{
    public partial class Frm_AddEditKPI : DevExpress.XtraEditors.XtraForm
    {
        private string MaNV = Frm_Login.MaNV;

        private static string mconnectstring = Frm_Chinh_GUI.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs(string.Empty);
        private string msql;
        Frm_AddKPIGrid addkpi = new Frm_AddKPIGrid();
        public Frm_AddEditKPI()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            msql = "SELECT * FROM [QuanLyKPI].[dbo].[NhomTieuChi]";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "NhomTieuChi");
            cboPhuongDien.DataSource = tb.Copy();
            cboPhuongDien.DisplayMember = "TenTieuChi";
            cboPhuongDien.ValueMember = "TieuChiID";
            cboPhuongDien.CustomAlignment = new string[] { "l", "l" };
            cboPhuongDien.CustomColumnStyle = new string[] { "t", "t" };

            //txtMaNV.Text = MaNV.ToString();
            nmYear.Value = DateTime.Now.Year;

            int currentMonth = DateTime.Now.Month;
            int currentQuarter = (currentMonth - 1) / 3 + 1;

            nmQuarter.Value = currentQuarter;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            msql = "INSERT INTO [dbo].[KPI_DangKiThem] " +
                   "([MaNV],[Quy],[Nam],[NoiDung],[DonViTinh],[PhuongPhapDo],[CongViecCaNhan],[TieuChiID],[ChiTieu]) " +
                   "VALUES (N'" + txtMaNV.Text + "','" + nmQuarter.Value.ToString()+ "','" + nmYear.Value.ToString() + "',N'" + txtNoiDungKPI.Text + "',N'" + txtDVT.Text + "',N'" + txtPhuongPhapDo.Text + "','" + chkCongViecCaNhan.Checked + "',N'" + cboPhuongDien.SelectedValue + "',N'" + txtChiTieu.Text + "')";
            comm.RunSQL(mconnectstring, msql);
        }
    }
}