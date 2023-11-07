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
    public partial class FrmChonBieuMau : DevExpress.XtraEditors.XtraForm
    {
        private string mconnectstring = Frm_Chinh_GUI.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public FrmChonBieuMau()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            msql = "SELECT * FROM [QuanLyKPI].[dbo].[tabBieuMau]";
            DataTable bieumau = comm.GetDataTable(mconnectstring, msql, "tabBieuMau");
            dgrChonBieuMau.AutoGenerateColumns = false;
            dgrChonBieuMau.DataSource = bieumau;
        }
        private void dgrChonBieuMau_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrChonBieuMau);
        }

        private void dgrChonBieuMau_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (dgrChonBieuMau["cChon", e.RowIndex] == dgrChonBieuMau.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có muốn mở Biểu mẫu " + dgrChonBieuMau.CurrentRow.Cells["cTenBieuMau"].Value.ToString() + " này không ?"))
                {
                    switch (dgrChonBieuMau.CurrentRow.Cells["cIDBieuMau"].Value.ToString())
                    {


                    }
                }
            }
        }
    }
}
