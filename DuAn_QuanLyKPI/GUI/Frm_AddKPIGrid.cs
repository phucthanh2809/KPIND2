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
        private string MaNV = Frm_Login.MaNV;


        private static string mconnectstring = Frm_Chinh_GUI.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs(string.Empty);
        private string msql;
        public Frm_AddKPIGrid()
        {
            InitializeComponent();
        }

        private void btnNganHangKPI_Click(object sender, EventArgs e)
        {
            dgrKPIBenhVien.Visible = true;
            msql = "SELECT * FROM [dbo].[KPI]";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "KPINH");
            dgrKPIBenhVien.AutoGenerateColumns = false;
            dgrKPIBenhVien.DataSource = tb;
        }

        private void btnNganHangCaNhan_Click(object sender, EventArgs e)
        {
            dgrNganHangCaNhan.Visible = true;
            msql = "SELECT * FROM [dbo].[KPI_DangKiThem] where MaNV = 'MaNV'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "KPINH");
            dgrNganHangCaNhan.AutoGenerateColumns = false;
            dgrNganHangCaNhan.DataSource = tb;
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

        private void dgrKPIBenhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}