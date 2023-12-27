using BusinessCommon;
using ControlProject1510;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DuAn_QuanLyKPI.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace DuAn_QuanLyKPI.GUI
{
    public partial class FrmChonBieuMau : DevExpress.XtraEditors.XtraForm
    {
        //Lấy dữ liệu 
        private static int CapDoBieuMauKPI = Frm_Login.CapDoBieuMauKPI;
        public static string QuyNam;
        //Conenect
        private static string mconnectstring = Frm_Chinh_GUI.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public FrmChonBieuMau()
        {
            InitializeComponent();
            LoadData();
            if (nmQuarter.Value == 0)
            {
                QuyNam = nmYear.Value.ToString();
            }
            else if (nmQuarter.Value != 0)
            {
                QuyNam = (nmQuarter.Value.ToString() + nmYear.Value.ToString());
            }
        }
        #region LoadDataGrid
        //Lãnh đạo
        private void LoadData()
        {
            switch (CapDoBieuMauKPI)
            {   
                //GiamDocvaPhoGiamDoc
                case 1: 
                    msql = "SELECT * FROM [dbo].[DanhsachBieuMau] WHERE [MaCapDoKPIBenhVien] = 1";
                    DataTable gd = comm.GetDataTable(mconnectstring, msql, "GiamDocvaPhoGiamDoc");
                    dgrChonBieuMau.AutoGenerateColumns = false;
                    dgrChonBieuMau.DataSource = gd;
                break;
                //Khoa Phòng
                case 2:
                    msql = "SELECT * FROM [QuanLyKPI].[dbo].[DanhsachBieuMau] WHERE [MaCapDoKPIBenhVien] = 2";
                    DataTable kp = comm.GetDataTable(mconnectstring, msql, "KhoaPhong");
                    dgrChonBieuMau.AutoGenerateColumns = false;
                    dgrChonBieuMau.DataSource = kp;
                    break;
                //Cá nhân
                case 3:
                    msql = "SELECT * FROM [dbo].[DanhsachBieuMau] WHERE [MaCapDoKPIBenhVien] = 3";
                    DataTable cn = comm.GetDataTable(mconnectstring, msql, "CaNhan");
                    dgrChonBieuMau.AutoGenerateColumns = false;
                    dgrChonBieuMau.DataSource = cn;
                    break;
            }
        }
        #endregion
        //stt grid
        private void dgrChonBieuMau_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (dgrChonBieuMau["cChon", e.RowIndex] == dgrChonBieuMau.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có muốn mở Biểu mẫu " + dgrChonBieuMau.CurrentRow.Cells["cTenBieuMau"].Value.ToString() + " này không ?"))
                {
                    int caseValue = int.Parse(dgrChonBieuMau.CurrentRow.Cells["cIDBieuMau"].Value.ToString());
                    
                    switch (caseValue)
                    {
                        //case 71:
                        //    Frm_A710 A711 = new Frm_A710();
                        //    A711.Show(); break;
                        //case 72:
                        //    Frm_A710 A72 = new Frm_A710();
                        //    A72.Show(); break;
                        case 73:
                            try
                            {
                                FrmA73 A73 = new FrmA73();
                                A73.Show();
                            }
                            catch (Exception)
                            {
                                ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                            }
                            break;
                        //case 74:
                        //    Frm_A710 A74 = new Frm_A710();
                        //    A74.Show(); break;
                        //case 75:
                        //    frm_a710 a75 = new frm_a710();
                        //    a75.show(); break;
                        case 76:
                            Frm_A76 A76 = new Frm_A76();
                            A76.Show(); break;
                            //case 77:
                            //    Frm_A710 A77 = new Frm_A710();
                            //    A77.Show(); break;
                            //case 78:
                            //    Frm_A710 A78 = new Frm_A710();
                            //    A78.Show(); break;
                            //case 79:
                            //    Frm_A710 A79 = new Frm_A710();
                            //    A79.Show(); break;
                            //case 710: frm_a710 a710 = new frm_a710();
                            //a710.show();break;
                    }

                }
            }
        }

        private void dgrChonBieuMau_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrChonBieuMau);
        }
    }
}

