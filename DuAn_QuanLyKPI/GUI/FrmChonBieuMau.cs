using BusinessCommon;
using ControlProject1510;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DuAn_QuanLyKPI.Constants;
using DuAn_QuanLyKPI.DTO;
using PhanMemQuanLyKPI;
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
        //Conenect
        private static string mconnectstring = Frm_Chinh_GUI.mconnectstring;
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        //Lấy dữ liệu 
        private static int CapDoBieuMauKPI = Frm_Login.CapDoBieuMauKPI;
        public static string Quy;
        public static string Nam;
        public FrmChonBieuMau()
        {
            InitializeComponent();
            LoadDataNam();
            nmYear.Text = DateTime.Now.ToString("yyyy");
        }
        #region LoadDataGrid
        //Lãnh đạo
        private void LoadDataNam()
        {
            switch (CapDoBieuMauKPI)
            {
                //Admin
                case 0:
                    msql = "SELECT * FROM [dbo].[DanhsachBieuMau] WHERE [Nam] = 1";
                    DataTable adn = comm.GetDataTable(mconnectstring, msql, "AdminNam");
                    dgrChonBieuMauNam.AutoGenerateColumns = false;
                    dgrChonBieuMauNam.DataSource = adn;
                    break;

                    msql = "SELECT * FROM [dbo].[DanhsachBieuMau] WHERE [Nam] = 0";
                    DataTable adq = comm.GetDataTable(mconnectstring, msql, "AdminQuy");
                    dgrChonBieuMauQuy.AutoGenerateColumns = false;
                    dgrChonBieuMauQuy.DataSource = adq;
                    break;
                //GiamDocvaPhoGiamDoc
                case 1:
                    msql = "SELECT * FROM [dbo].[DanhsachBieuMau] WHERE [MaCapDoKPIBenhVien] = 1 and [Nam] = 1";
                    DataTable gd = comm.GetDataTable(mconnectstring, msql, "GiamDocvaPhoGiamDoc");
                    dgrChonBieuMauNam.AutoGenerateColumns = false;
                    dgrChonBieuMauNam.DataSource = gd;
                    btnQuy.Visible = false;
                    break;
                //Khoa Phòng
                case 2:
                    msql = "SELECT * FROM [dbo].[DanhsachBieuMau] WHERE [MaCapDoKPIBenhVien] = 2 and [Nam] = 1";
                    DataTable kpn = comm.GetDataTable(mconnectstring, msql, "KhoaPhongNam");
                    dgrChonBieuMauNam.AutoGenerateColumns = false;
                    dgrChonBieuMauNam.DataSource = kpn;

                    msql = "SELECT * FROM [dbo].[DanhsachBieuMau] WHERE [MaCapDoKPIBenhVien] = 2 and [Nam] = 0";
                    DataTable kpq = comm.GetDataTable(mconnectstring, msql, "KhoaPhongQuy");
                    dgrChonBieuMauQuy.AutoGenerateColumns = false;
                    dgrChonBieuMauQuy.DataSource = kpq;
                    break;
                //Cá nhân
                case 3:
                    msql = "SELECT * FROM [dbo].[DanhsachBieuMau] WHERE [MaCapDoKPIBenhVien] = 3 and [Nam] = 1";
                    DataTable cnn = comm.GetDataTable(mconnectstring, msql, "CaNhanNam");
                    dgrChonBieuMauNam.AutoGenerateColumns = false;
                    dgrChonBieuMauNam.DataSource = cnn;

                    msql = "SELECT * FROM [dbo].[DanhsachBieuMau] WHERE [MaCapDoKPIBenhVien] = 3 and [Nam] = 0";
                    DataTable cnq = comm.GetDataTable(mconnectstring, msql, "CaNhanQuy");
                    dgrChonBieuMauQuy.AutoGenerateColumns = false;
                    dgrChonBieuMauQuy.DataSource = cnq;
                    break;
            }
        }
        private void LoadDataQuy()
        {
            switch (CapDoBieuMauKPI)
            {
                //Admin
                case 0:
                    msql = "SELECT * FROM [dbo].[DanhsachBieuMau] WHERE [Nam] = 0";
                    DataTable adq = comm.GetDataTable(mconnectstring, msql, "AdminQuy");
                    dgrChonBieuMauQuy.AutoGenerateColumns = false;
                    dgrChonBieuMauQuy.DataSource = adq;
                    break;
                //GiamDocvaPhoGiamDoc
                case 1:
                    msql = "SELECT * FROM [dbo].[DanhsachBieuMau] WHERE [MaCapDoKPIBenhVien] = 1 and [Nam] = 0";
                    DataTable gd = comm.GetDataTable(mconnectstring, msql, "GiamDocvaPhoGiamDoc");
                    dgrChonBieuMauNam.AutoGenerateColumns = false;
                    dgrChonBieuMauNam.DataSource = gd;
                    btnQuy.Visible = false;
                    break;
                //Khoa Phòng
                case 2:
                    msql = "SELECT * FROM [dbo].[DanhsachBieuMau] WHERE [MaCapDoKPIBenhVien] = 2 and [Nam] = 0";
                    DataTable kpq = comm.GetDataTable(mconnectstring, msql, "KhoaPhongQuy");
                    dgrChonBieuMauQuy.AutoGenerateColumns = false;
                    dgrChonBieuMauQuy.DataSource = kpq;
                    break;
                //Cá nhân
                case 3:
                    msql = "SELECT * FROM [dbo].[DanhsachBieuMau] WHERE [MaCapDoKPIBenhVien] = 3 and [Nam] = 0";
                    DataTable cnq = comm.GetDataTable(mconnectstring, msql, "CaNhanQuy");
                    dgrChonBieuMauQuy.AutoGenerateColumns = false;
                    dgrChonBieuMauQuy.DataSource = cnq;
                    break;
            }
        }
        private void OpenForm(int Frm)
        {
            try
            {
                switch (Frm)
                {
                    //BV
                    case 71:
                        Frm_A71 A71 = new Frm_A71();
                        A71.ShowDialog();
                        break;
                    case 72:
                        Frm_A72 A72 = new Frm_A72();
                        A72.ShowDialog();
                        break;
                    case 75:
                        Frm_A75 A75 = new Frm_A75();
                        A75.ShowDialog();
                        break;
                    //KP
                    case 73:
                        FrmA73 A73 = new FrmA73();
                        A73.ShowDialog();
                        break;
                    case 74:
                        Frm_A74 A74 = new Frm_A74();
                        A74.ShowDialog();
                        break;
                    case 76:
                        Frm_A76 A76 = new Frm_A76();
                        A76.ShowDialog();
                        break;
                    //TK
                    case 77:
                        Frm_A77 A77 = new Frm_A77();
                        A77.ShowDialog();
                        break;
                    case 710:
                        Frm_A710 A710 = new Frm_A710();
                        A710.ShowDialog();
                        break;
                    //CB
                    case 78:
                        Frm_A78 A78 = new Frm_A78();
                        A78.ShowDialog();
                        break;
                    case 79:
                        Frm_A79 A79 = new Frm_A79();
                        A79.ShowDialog();
                        break;
                }
            }
            catch (Exception ex)
            {
                ev.QFrmThongBaoError("Có lỗi xảy ra trong quá trình mở Biểu mẫu! Vui lòng khởi đồng lại Phần mềm");
            }
        }

        #endregion
        //stt grid
        private void dgrChonBieuMau_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (dgrChonBieuMauNam["cNam", e.RowIndex] == dgrChonBieuMauNam.CurrentCell)
            {
                if (nmYear == null)
                {
                    ev.QFrmThongBao("Vui lòng nhập năm vào");
                    nmYear.Focus();
                }
                else
                {
                    if (ev.QFrmThongBao_YesNo("Bạn có muốn mở Biểu mẫu " + dgrChonBieuMauNam.CurrentRow.Cells["cTenBieuMau"].Value.ToString() + "Năm này không ?"))
                    {
                        int caseValue = int.Parse(dgrChonBieuMauNam.CurrentRow.Cells["cIDBieuMau"].Value.ToString());
                        Nam = nmYear.Text;
                        switch (caseValue)
                        {
                            case 71:
                                OpenForm(71);
                                break;
                            case 72:
                                OpenForm(72);
                                break;
                            case 73:
                                OpenForm(73);
                                break;
                            case 74:
                                OpenForm(74);
                                break;
                            case 79:
                                OpenForm(79);
                                break;
                            case 710:
                                OpenForm(710);
                                break;
                        }
                    }
                }
            }

        }

        private void dgrChonBieuMau_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrChonBieuMauNam);
        }

        private void nmYear_ValueChanged(object sender, EventArgs e)
        {
            string newValue = (string)nmYear.Value.ToString();
            Nam = newValue;
        }

        private void nmYear_Click(object sender, EventArgs e)
        {
            string newValue = (string)nmYear.Value.ToString();
            Nam = newValue;
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            dgrChonBieuMauNam.Visible = true;
            dgrChonBieuMauQuy.Visible = false;
            LoadDataNam();
        }

        private void btnQuy_Click(object sender, EventArgs e)
        {
            dgrChonBieuMauNam.Visible = false;
            dgrChonBieuMauQuy.Visible = true;
            LoadDataQuy();
        }

        private void dgrChonBieuMauQuy_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrChonBieuMauQuy);
        }

        private void dgrChonBieuMauQuy_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (nmYear.Text != "")
            {
                if (dgrChonBieuMauNam["cQuy1", e.RowIndex] == dgrChonBieuMauNam.CurrentCell)
                {
                    if (ev.QFrmThongBao_YesNo("Bạn có muốn mở Biểu mẫu " + dgrChonBieuMauNam.CurrentRow.Cells["cTenBieuMau"].Value.ToString() + "Quý 1 này không ?"))
                    {
                        int caseValue = int.Parse(dgrChonBieuMauNam.CurrentRow.Cells["cIDBieuMau"].Value.ToString());
                        Quy = ("1" + nmYear.Text.Trim()).Trim();
                        switch (caseValue)
                        {
                            case 75:
                                OpenForm(75);
                                break;
                            case 76:
                                OpenForm(76);
                                break;
                            case 77:
                                OpenForm(77);
                                break;
                            case 78:
                                OpenForm(78);
                                break;
                        }
                    }
                }
                else if (dgrChonBieuMauNam["cQuy2", e.RowIndex] == dgrChonBieuMauNam.CurrentCell)
                {
                    if (ev.QFrmThongBao_YesNo("Bạn có muốn mở Biểu mẫu " + dgrChonBieuMauNam.CurrentRow.Cells["cTenBieuMau"].Value.ToString() + "Quý 2 này không ?"))
                    {
                        int caseValue = int.Parse(dgrChonBieuMauNam.CurrentRow.Cells["cIDBieuMau"].Value.ToString());
                        Quy = ("2" + nmYear.Text.Trim()).Trim();
                        switch (caseValue)
                        {
                            case 75:
                                OpenForm(75);
                                break;
                            case 76:
                                OpenForm(76);
                                break;
                            case 77:
                                OpenForm(77);
                                break;
                            case 78:
                                OpenForm(78);
                                break;
                        }
                    }
                }
                else if (dgrChonBieuMauNam["cQuy3", e.RowIndex] == dgrChonBieuMauNam.CurrentCell)
                {
                    if (ev.QFrmThongBao_YesNo("Bạn có muốn mở Biểu mẫu " + dgrChonBieuMauNam.CurrentRow.Cells["cTenBieuMau"].Value.ToString() + "Quý 3 này không ?"))
                    {
                        int caseValue = int.Parse(dgrChonBieuMauNam.CurrentRow.Cells["cIDBieuMau"].Value.ToString());
                        Quy = ("3" + nmYear.Text.Trim()).Trim();
                        switch (caseValue)
                        {
                            case 75:
                                OpenForm(75);
                                break;
                            case 76:
                                OpenForm(76);
                                break;
                            case 77:
                                OpenForm(77);
                                break;
                            case 78:
                                OpenForm(78);
                                break;
                        }
                    }
                }
                else if (dgrChonBieuMauNam["cQuy4", e.RowIndex] == dgrChonBieuMauNam.CurrentCell)
                {
                    if (ev.QFrmThongBao_YesNo("Bạn có muốn mở Biểu mẫu " + dgrChonBieuMauNam.CurrentRow.Cells["cTenBieuMau"].Value.ToString() + "Quý 4 này không ?"))
                    {
                        int caseValue = int.Parse(dgrChonBieuMauNam.CurrentRow.Cells["cIDBieuMau"].Value.ToString());
                        Quy = ("4" + nmYear.Text.Trim()).Trim();
                        switch (caseValue)
                        {
                            case 75:
                                OpenForm(75);
                                break;
                            case 76:
                                OpenForm(76);
                                break;
                            case 77:
                                OpenForm(77);
                                break;
                            case 78:
                                OpenForm(78);
                                break;
                        }
                    }
                }
            }
        }
    }
}

