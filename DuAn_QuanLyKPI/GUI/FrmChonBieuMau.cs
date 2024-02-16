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
            nmYear.Text = DateTime.Now.ToString("yyyy");
        }
        #region LoadDataGrid
        //Lãnh đạo
        internal void LoadData()
        {
            switch (CapDoBieuMauKPI)
            {
                //GiamDocvaPhoGiamDoc
                case 1:
                    msql = "SELECT * FROM [dbo].[DanhsachBieuMau] WHERE [MaCapDoKPIBenhVien] = 1";
                    DataTable gd = comm.GetDataTable(mconnectstring, msql, "GiamDocvaPhoGiamDoc");
                    dgrChonBieuMauNam.AutoGenerateColumns = false;
                    dgrChonBieuMauNam.DataSource = gd;
                    btnQuy.Visible = false;
                    break;
                //Khoa Phòng
                case 2:
                    msql = "SELECT * FROM [dbo].[DanhsachBieuMau] WHERE [MaCapDoKPIBenhVien] <> 1 and [Nam] = 1";
                    DataTable kpn = comm.GetDataTable(mconnectstring, msql, "KhoaPhongNam");
                    dgrChonBieuMauNam.AutoGenerateColumns = false;
                    dgrChonBieuMauNam.DataSource = kpn;

                    msql = "SELECT * FROM [dbo].[DanhsachBieuMau] WHERE [MaCapDoKPIBenhVien] <> 1 and [Nam] = 0";
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
        private void OpenForm(int Frm)
        {
            try
            {
                switch (Frm)
                {
                    case 71:
                        Frm_A71 A71 = new Frm_A71();
                        A71.ShowDialog();
                        break;
                    case 73:
                        FrmA73 A73 = new FrmA73();
                        A73.ShowDialog();
                        break;
                    case 75:
                        Frm_A75 A75 = new Frm_A75();
                        A75.ShowDialog();
                        break;
                    case 76:
                        Frm_A76 A76 = new Frm_A76();
                        A76.ShowDialog();
                        break;
                    case 77:
                        Frm_A77 A77 = new Frm_A77();
                        A77.ShowDialog();
                        break;
                    case 78:
                        Frm_A78 A78 = new Frm_A78();
                        A78.ShowDialog();
                        break;
                    default:
                        // Handle case where Frm doesn't match any known form
                        break;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here, for example:
                MessageBox.Show("Đã có lỗi xảy ra khi mở Biểu mẫu " + ex.Message);
            }
        }

        #endregion
        //stt grid
        private void dgrChonBieuMau_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
                        QuyNam = ("1" + nmYear.Text.Trim()).Trim();
                        switch (caseValue)
                        {
                            //case 72:
                            //    Frm_A710 A72 = new Frm_A710();
                            //    A72.Show(); break;
                            case 73:
                                try
                                {
                                    OpenForm(73);
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
                    
                                A76.Show(); 
                                break;
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
                else if (dgrChonBieuMauNam["cQuy2", e.RowIndex] == dgrChonBieuMauNam.CurrentCell)
                {
                    if (ev.QFrmThongBao_YesNo("Bạn có muốn mở Biểu mẫu " + dgrChonBieuMauNam.CurrentRow.Cells["cTenBieuMau"].Value.ToString() + "Quý 2 này không ?"))
                    {
                        int caseValue = int.Parse(dgrChonBieuMauNam.CurrentRow.Cells["cIDBieuMau"].Value.ToString());
                        QuyNam = ("2" + nmYear.Text.Trim()).Trim();
                        switch (caseValue)
                        {
                            //case 72:
                            //    try
                            //    {
                            //        FrmA72 A72 = new FrmA72();
                            //        A72.Show();
                            //    }
                            //    catch (Exception)
                            //    {
                            //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                            //    }
                            //    break;
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
                                //    try
                                //    {
                                //        FrmA74 A74 = new FrmA74();
                                //        A74.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                                //case 75:
                                //    try
                                //    {
                                //        FrmA75 A75 = new FrmA75();
                                //        A75.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                                //case 76:
                                //    try
                                //    {
                                //        FrmA76 A76 = new FrmA76();
                                //        A76.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                                //case 77:
                                //    try
                                //    {
                                //        FrmA77 A77 = new FrmA77();
                                //        A77.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                                //case 78:
                                //    try
                                //    {
                                //        FrmA78 A78 = new FrmA78();
                                //        A78.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                                //case 79:
                                //    try
                                //    {
                                //        FrmA79 A79 = new FrmA79();
                                //        A79.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                                //case 710:
                                //    try
                                //    {
                                //        FrmA710 A710 = new FrmA710();
                                //        A710.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                        }
                    }
                }
                else if (dgrChonBieuMauNam["cQuy3", e.RowIndex] == dgrChonBieuMauNam.CurrentCell)
                {
                    if (ev.QFrmThongBao_YesNo("Bạn có muốn mở Biểu mẫu " + dgrChonBieuMauNam.CurrentRow.Cells["cTenBieuMau"].Value.ToString() + "Quý 3 này không ?"))
                    {
                        int caseValue = int.Parse(dgrChonBieuMauNam.CurrentRow.Cells["cIDBieuMau"].Value.ToString());
                        QuyNam = ("3" + nmYear.Text.Trim()).Trim();
                        switch (caseValue)
                        {
                            //case 72:
                            //    try
                            //    {
                            //        FrmA72 A72 = new FrmA72();
                            //        A72.Show();
                            //    }
                            //    catch (Exception)
                            //    {
                            //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                            //    }
                            //    break;
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
                                //    try
                                //    {
                                //        FrmA74 A74 = new FrmA74();
                                //        A74.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                                //case 75:
                                //    try
                                //    {
                                //        FrmA75 A75 = new FrmA75();
                                //        A75.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                                //case 76:
                                //    try
                                //    {
                                //        FrmA76 A76 = new FrmA76();
                                //        A76.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                                //case 77:
                                //    try
                                //    {
                                //        FrmA77 A77 = new FrmA77();
                                //        A77.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                                //case 78:
                                //    try
                                //    {
                                //        FrmA78 A78 = new FrmA78();
                                //        A78.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                                //case 79:
                                //    try
                                //    {
                                //        FrmA79 A79 = new FrmA79();
                                //        A79.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                                //case 710:
                                //    try
                                //    {
                                //        FrmA710 A710 = new FrmA710();
                                //        A710.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                        }
                    }
                }
                else if (dgrChonBieuMauNam["cQuy4", e.RowIndex] == dgrChonBieuMauNam.CurrentCell)
                {
                    if (ev.QFrmThongBao_YesNo("Bạn có muốn mở Biểu mẫu " + dgrChonBieuMauNam.CurrentRow.Cells["cTenBieuMau"].Value.ToString() + "Quý 4 này không ?"))
                    {
                        int caseValue = int.Parse(dgrChonBieuMauNam.CurrentRow.Cells["cIDBieuMau"].Value.ToString());
                        QuyNam = ("4" + nmYear.Text.Trim()).Trim();
                        switch (caseValue)
                        {
                            //case 72:
                            //    try
                            //    {
                            //        FrmA72 A72 = new FrmA72();
                            //        A72.Show();
                            //    }
                            //    catch (Exception)
                            //    {
                            //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                            //    }
                            //    break;
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
                                //    try
                                //    {
                                //        FrmA74 A74 = new FrmA74();
                                //        A74.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                                //case 75:
                                //    try
                                //    {
                                //        FrmA75 A75 = new FrmA75();
                                //        A75.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                                //case 76:
                                //    try
                                //    {
                                //        FrmA76 A76 = new FrmA76();
                                //        A76.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                                //case 77:
                                //    try
                                //    {
                                //        FrmA77 A77 = new FrmA77();
                                //        A77.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                                //case 78:
                                //    try
                                //    {
                                //        FrmA78 A78 = new FrmA78();
                                //        A78.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                                //case 79:
                                //    try
                                //    {
                                //        FrmA79 A79 = new FrmA79();
                                //        A79.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                                //case 710:
                                //    try
                                //    {
                                //        FrmA710 A710 = new FrmA710();
                                //        A710.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                        }
                    }
                }
                else if (dgrChonBieuMauNam["cNam", e.RowIndex] == dgrChonBieuMauNam.CurrentCell)
                {
                    if (ev.QFrmThongBao_YesNo("Bạn có muốn mở Biểu mẫu " + dgrChonBieuMauNam.CurrentRow.Cells["cTenBieuMau"].Value.ToString() + "Năm này không ?"))
                    {
                        int caseValue = int.Parse(dgrChonBieuMauNam.CurrentRow.Cells["cIDBieuMau"].Value.ToString());
                        QuyNam = txtTest.Text;
                        switch (caseValue)
                        {
                            case 71:
                                try
                                {
                                    Frm_A71 A71 = new Frm_A71();
                                    A71.Show();
                                }
                                catch (Exception)
                                {
                                    ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                }
                                break;
                            //case 72:
                            //    try
                            //    {
                            //        FrmA72 A72 = new FrmA72();
                            //        A72.Show();
                            //    }
                            //    catch (Exception)
                            //    {
                            //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                            //    }
                            //    break;
                            case 73:
                                try
                                {
                                    
                                    FrmA73 A73 = new FrmA73();
                                    A73.Show();
                                }
                                catch (Exception ex)
                                {
                                    ev.QFrmThongBaoError($"Error: {ex.Message}");
                                }
                                break;

                                //case 74:
                                //    try
                                //    {
                                //        FrmA74 A74 = new FrmA74();
                                //        A74.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                                //case 75:
                                //    try
                                //    {
                                //        FrmA75 A75 = new FrmA75();
                                //        A75.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                                //case 76:
                                //    try
                                //    {
                                //        FrmA76 A76 = new FrmA76();
                                //        A76.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                                //case 77:
                                //    try
                                //    {
                                //        FrmA77 A77 = new FrmA77();
                                //        A77.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                                //case 78:
                                //    try
                                //    {
                                //        FrmA78 A78 = new FrmA78();
                                //        A78.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                                //case 79:
                                //    try
                                //    {
                                //        FrmA79 A79 = new FrmA79();
                                //        A79.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                                //case 710:
                                //    try
                                //    {
                                //        FrmA710 A710 = new FrmA710();
                                //        A710.Show();
                                //    }
                                //    catch (Exception)
                                //    {
                                //        ev.QFrmThongBaoError("Không có dữ liệu tương ứng");
                                //    }
                                //    break;
                        }
                    }
                }
            }
            else if (nmYear.Text == "")
            {
                ev.QFrmThongBao("Vui lòng nhập năm vào");
                nmYear.Focus();
            }    
        }

        private void dgrChonBieuMau_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrChonBieuMauNam);
        }

        private void FrmChonBieuMau_Load(object sender, EventArgs e)
        {

        }

        private void nmYear_ValueChanged(object sender, EventArgs e)
        {
            string newValue = (string)nmYear.Value.ToString();
            QuyNam = newValue;
        }

        private void nmYear_Click(object sender, EventArgs e)
        {
            string newValue = (string)nmYear.Value.ToString();
            QuyNam = newValue;
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            dgrChonBieuMauNam.Visible = true;
            dgrChonBieuMauQuy.Visible = false;
        }

        private void btnQuy_Click(object sender, EventArgs e)
        {
            dgrChonBieuMauNam.Visible = false;
            dgrChonBieuMauQuy.Visible = true;
        }
    }
}

