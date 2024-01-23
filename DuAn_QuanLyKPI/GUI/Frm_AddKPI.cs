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
    public partial class Frm_AddKPI : DevExpress.XtraEditors.XtraForm
    {
        private static string mconnectstring = Frm_Chinh_GUI.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs(string.Empty);
        private string msql;
        public Frm_AddKPI()
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
            msql = "SELECT * FROM [dbo].[KPI]";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "KPINH");
            dgrKPIBenhVien.AutoGenerateColumns = false;
            dgrKPIBenhVien.DataSource = tb;
        }

        private void dgrKPIBenhVien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrKPIBenhVien);
        }
    }
}