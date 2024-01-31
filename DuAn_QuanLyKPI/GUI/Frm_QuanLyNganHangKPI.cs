using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessCommon;
using ControlProject1510;
using DevExpress.Charts.Native;
using DevExpress.CodeParser;
using DevExpress.Data.Linq.Helpers;
using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting.Native;
//using DevExpress.XtraVerticalGrid;
using DuAn_QuanLyKPI.Constants;
using DuAn_QuanLyKPI.DTO;
using System.Data.SqlClient;

namespace DuAn_QuanLyKPI.GUI
{
    public partial class Frm_QuanLyNganHangKPI : DevExpress.XtraEditors.XtraForm, INotifyPropertyChanged
    {
        private string mconnectstring = "server=192.168.50.108,1433; database=QuanLyKPI;uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        private int _edit = 0;
        List<int> selectedItems = new List<int>();
        private int maKPI;
        private int maKPI_Them;
        private string message;
        private bool isCaNhanSelected = false;
        private bool isBenhVienSelected = false;
        private bool isTongHopSelected = false;



        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public int Edit
        {
            get => _edit;
            set
            {
                _edit = value;
                OnPropertyChanged(nameof(Edit));
                switch (value)
                {
                    case 0:
                        splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
                        break;
                    case 1:
                        splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
                        break;
                    case 2:
                        splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
                        break;
                }
            }
        }

        public Frm_QuanLyNganHangKPI()
        {
            InitializeComponent();
            ChoPhepNhap();
            LoadCbo();
            LoadDonViTinhComboBox();
            btnAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            btnEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            btnCancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            btnSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            txt_TenTieuChi.Visible = false;
            btn_Luu.Enabled = false;
            txt_MaKPI_Them.Visible = false;
        }
        private void LoadCbo()
        {
            DataTable dataTableTieuChi = new DataTable();
            using (SqlConnection connection = new SqlConnection(mconnectstring))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT TieuChiID, TenTieuChi FROM NhomTieuChi", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTableTieuChi.Load(reader);
                    }
                }

            }
            dataTableTieuChi.DefaultView.Sort = "TieuChiID";
            dataTableTieuChi = dataTableTieuChi.DefaultView.ToTable();
            cbx_TieuChiID.DataSource = dataTableTieuChi;
            cbx_TieuChiID.ValueMember = "TieuChiID";
            cbx_TieuChiID.DisplayMember = "TenTieuChi";
            cbx_TieuChiID.SelectedIndexChanged += cbx_TieuChiID_SelectedIndexChanged;

        }
        private void LoadData()
        {
            msql = "SELECT dbo.KPI.MaKPI, dbo.KPI.NoiDung, dbo.KPI.DonViTinh, dbo.KPI.PhuongPhapDo, dbo.KPI.CongViecCaNhan, dbo.KPI.ChiTieu, dbo.KPI.TieuChiID, " +
                "dbo.NhomTieuChi.TenTieuChi FROM dbo.KPI INNER JOIN dbo.NhomTieuChi ON dbo.KPI.TieuChiID = dbo.NhomTieuChi.TieuChiID ";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "KPI");
            dtgv_QLNganHangKPI.AutoGenerateColumns = false;
            dtgv_QLNganHangKPI.DataSource = tb;

        }
        private void LoadData1()
        {
            msql = "SELECT * FROM [dbo].[KPI],[dbo].[NhomTieuChi] where KPI.TieuChiID = NhomTieuChi.TieuChiID and KPI.CongViecCaNhan = 1;";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "KPI");
            dtgv_QLNganHangKPI.AutoGenerateColumns = false;
            dtgv_QLNganHangKPI.DataSource = tb;

        }
        private void LoadData2()
        {
            msql = "SELECT * FROM [dbo].[KPI],[dbo].[NhomTieuChi] where KPI.TieuChiID = NhomTieuChi.TieuChiID and KPI.CongViecCaNhan = 0;";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "KPI");
            dtgv_QLNganHangKPI.AutoGenerateColumns = false;
            dtgv_QLNganHangKPI.DataSource = tb;

        }
        private void LoadData3()
        {
            msql = "SELECT dbo.NhomTieuChi.TenTieuChi, dbo.KPI_DangKiThem.MaKPI_DKT, dbo.KPI_DangKiThem.NoiDung, dbo.KPI_DangKiThem.DonViTinh, dbo.KPI_DangKiThem.PhuongPhapDo,dbo.KPI_DangKiThem.ChiTieu, " +
                "dbo.KPI_DangKiThem.CongViecCaNhan, dbo.KPI_DangKiThem.TieuChiID FROM  dbo.NhomTieuChi INNER JOIN dbo.KPI_DangKiThem ON dbo.NhomTieuChi.TieuChiID = dbo.KPI_DangKiThem.TieuChiID ";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "KPI_DangKiThem");
            dtgv_QLNganHangKPI.AutoGenerateColumns = false;
            dtgv_QLNganHangKPI.DataSource = tb;
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Edit = 0;
        }
        private void ShowGridPreview(GridControl grid)
        {
            // Check whether the GridControl can be previewed.
            if (!grid.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            // Open the Preview window.
            grid.ShowPrintPreview();
        }
        private void ChoPhepNhap()
        {
            txtNoiDung.Enabled = true;
            txtNoiDung.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            cbo_PhuongPhapDo.Enabled = true;
            cbo_ChiTieu.Enabled = true;
            cbo_DonViTinh.Enabled = true;
            cbx_TieuChiID.Enabled = true;

        }
        private void LamMoiThongTin()
        {
            txtNoiDung.Text = "";
            cbo_PhuongPhapDo.Text = "";
            cbo_DonViTinh.Text = "";
            cbo_ChiTieu.Text = "";
            cbo_PhuongPhapDo.Text = "";
            cbx_TieuChiID.Text = "";
        }
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Edit = 1;
            ChoPhepNhap();
            LamMoiThongTin();

        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Edit = 2;
            LamMoiThongTin();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Edit == 1)
            //thì là trạng thái thêm
            {
                string noiDung = txtNoiDung.Text;
                string donViTinh = cbo_DonViTinh.Text;
                string phuongPhapDo = cbo_PhuongPhapDo.Text;
                bool congViecCaNhan = chkCongViecCaNhan.Checked;
                string chiTieu = cbo_ChiTieu.Text;
                //string tieuChiID = cbx_TieuChiID.SelectedValue;

                //LoadData();
                ev.QFrmThongBao("Đã lưu dữ liệu thành công !");
                if (isCaNhanSelected)
                {
                    //string tieuChiID = cbx_TieuChiID.SelectedValue;
                    msql = $"INSERT INTO [dbo].[KPI_DangkiThem] (NoiDung, DonViTinh, PhuongPhapDo, CongViecCaNhan, ChiTieu, TieuChiID) VALUES (N'{noiDung}', N'{donViTinh}', N'{phuongPhapDo}', {(congViecCaNhan ? 1 : 0)}, N'{chiTieu}', N'" + cbx_TieuChiID.SelectedValue + "')";
                    comm.RunSQL(mconnectstring, msql);
                    LoadData3();
                    ev.QFrmThongBao("Đã lưu dữ liệu thành công !");
                }
                else if (isBenhVienSelected)
                {
                    msql = $"INSERT INTO [dbo].[KPI] (NoiDung, DonViTinh, PhuongPhapDo, CongViecCaNhan, ChiTieu, TieuChiID) VALUES (N'{noiDung}', N'{donViTinh}', N'{phuongPhapDo}', {(congViecCaNhan ? 1 : 0)}, N'{chiTieu}', N'" + cbx_TieuChiID.SelectedValue + "')";
                    comm.RunSQL(mconnectstring, msql);
                    LoadData2();
                    ev.QFrmThongBao("Đã lưu dữ liệu thành công !");
                }
                else if (isTongHopSelected)
                {
                    msql = $"INSERT INTO [dbo].[KPI] (NoiDung, DonViTinh, PhuongPhapDo, CongViecCaNhan, ChiTieu, TieuChiID) VALUES (N'{noiDung}', N'{donViTinh}', N'{phuongPhapDo}', {(congViecCaNhan ? 1 : 0)}, N'{chiTieu}', N'" + cbx_TieuChiID.SelectedValue + "')";
                    comm.RunSQL(mconnectstring, msql);
                    LoadData();
                    ev.QFrmThongBao("Đã lưu dữ liệu thành công !");
                }


            }
            if (Edit == 2)
            //trạng thái sửa
            {
                bool result = ev.QFrmThongBao_YesNo("Bạn có chắc chắn muốn sửa ?");
                if (result == true)
                {
                    string noiDung = txtNoiDung.Text;
                    string donViTinh = cbo_DonViTinh.Text;
                    string phuongPhapDo = cbo_PhuongPhapDo.Text;
                    bool congViecCaNhan = chkCongViecCaNhan.Checked;
                    string chiTieu = cbo_ChiTieu.Text;
                    string tieuChiID = txt_TenTieuChi.Text; // Hoặc sử dụng SelectedValue tùy thuộc vào cách bạn set up ComboBox

                    string updateSql = $"UPDATE [dbo].[KPI] SET NoiDung = N'{noiDung}', DonViTinh = N'{donViTinh}', PhuongPhapDo = N'{phuongPhapDo}', CongViecCaNhan = '{congViecCaNhan}', ChiTieu = '{chiTieu}', TieuChiID = '{tieuChiID}' WHERE MaKPI = {maKPI}";

                    comm.RunSQL(mconnectstring, updateSql);
                    LoadData2();
                    ev.QFrmThongBao("Đã cập nhật dữ liệu thành công!");

                    if (isCaNhanSelected)
                    {

                        LoadData3();

                    }
                    else if (isBenhVienSelected)
                    {

                        LoadData2();

                    }
                    else if (isTongHopSelected)
                    {
                        ev.QFrmThongBao("Đã cập nhật dữ liệu thành công!");
                    }
                }
                Edit = 0;

            }
        }

        private void btnCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool result = ev.QFrmThongBao_YesNo("Bạn chắc chắn muốn qua nút cấp !!!");

            if (result == true)
            {
                // Người dùng đã chọn "Yes", thực hiện các hành động cần thiết, ví dụ: mở form mới
                Frm_CapDanhSachKPI form = new Frm_CapDanhSachKPI();
                form.ShowDialog();
            }
            else
            {
                // Người dùng đã chọn "No", có thể thực hiện các hành động khác tùy thuộc vào yêu cầu của bạn.
            }


        }


        //Xóa
        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bool result = ev.QFrmThongBao_YesNo("Bạn chắc chắn muốn xóa !!!");

                if (result)
                {
                    msql = $"DELETE [dbo].[KPI] WHERE MaKPI = {maKPI}";
                    comm.RunSQL(mconnectstring, msql);
                    LoadData3();
                    ev.QFrmThongBao("Bạn đã xóa thành công !");

                    Edit = 0;
                }
            }
            catch (SqlException ex)
            {
                // Check if the exception is due to a foreign key constraint violation
                if (ex.Number == 547)
                {
                    ev.QFrmThongBao("Dữ liệu đang được sử dụng ở nơi khác, không thể xóa!");
                    Edit = 0;
                }
                else
                {
                    // Handle other SQL exceptions
                    ev.QFrmThongBao("Dữ liệu đang được sử dụng ở nơi khác, không thể xóa ");
                    Edit = 0;
                }
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                ev.QFrmThongBao("Dữ liệu đang được sử dụng ở nơi khác, không thể xóa ");
                Edit = 0;
            }
        }


        private void cbx_TieuChiID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu giá trị được chọn là một DataRowView
            if (cbx_TieuChiID.SelectedItem is DataRowView selectedRow)
            {
                // Lấy giá trị từ DataRowView
                string tieuchiId = selectedRow["TieuChiID"].ToString();

                // Đặt giá trị vào TextBox
                txt_TenTieuChi.Text = tieuchiId;
            }
            else
            {
                // Nếu không phải là DataRowView, đặt TextBox thành chuỗi trống
                txt_TenTieuChi.Text = string.Empty;
            }
        }
        private void UnhighlightAllRows()
        {
            // Hủy bôi đậm tất cả các hàng
            foreach (DataGridViewRow row in dtgv_QLNganHangKPI.Rows)
            {
                row.DefaultCellStyle.BackColor = dtgv_QLNganHangKPI.DefaultCellStyle.BackColor;
            }
        }
        int selectedRowIndex = -1;

        //Lấy dữ liệu từ gridview đổ lên các textbox
        private void dtgv_QLNganHangKPI_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Edit = 2;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Hủy bôi đậm các hàng khác nếu đã có
                UnhighlightAllRows();

                // Đặt màu nền cho hàng được chọn
                dtgv_QLNganHangKPI.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(217, 237, 191);

                // Lưu chỉ số hàng được chọn
                selectedRowIndex = e.RowIndex;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                
                // Lấy thông tin từ ô được chọn
                DataGridViewRow selectedRow = dtgv_QLNganHangKPI.Rows[e.RowIndex];
                string noiDung = selectedRow.Cells["clNoiDung"].Value.ToString();
                string donViTinh = selectedRow.Cells["clDonViTinh"].Value.ToString();
                string phuongPhapDo = selectedRow.Cells["clPhuongPhapDo"].Value.ToString();
                string congViecCaNhanStr = selectedRow.Cells["clCongViecCaNhan"].Value.ToString();
                bool congViecCaNhan;
                if (bool.TryParse(congViecCaNhanStr, out congViecCaNhan))
                {
                    // Đặt giá trị bool vào CheckBox
                    chkCongViecCaNhan.Checked = congViecCaNhan;
                }
                string chiTieu = selectedRow.Cells["clChiTieu"].Value.ToString();
                string tieuChiID = selectedRow.Cells["cTieuChiID"].Value.ToString();
                string tenTieuChi = selectedRow.Cells["cTenTieuChi"].Value.ToString();
                // Lấy giá trị maKPI từ cell clMaKPI
                if (selectedRow != null &&
                (selectedRow.Cells["clMaKPI_DKT"] != null && selectedRow.Cells["clMaKPI_DKT"].Value != null &&
                int.TryParse(selectedRow.Cells["clMaKPI_DKT"].Value.ToString(), out maKPI)) ||
                (selectedRow.Cells["clMaKPI"] != null && selectedRow.Cells["clMaKPI"].Value != null &&
                int.TryParse(selectedRow.Cells["clMaKPI"].Value.ToString(), out maKPI)))
                {     
                    // Lấy thông tin từ các ô cột khác nếu cần
                    txtNoiDung.Text = noiDung;
                    cbo_DonViTinh.Text = donViTinh;
                    cbo_PhuongPhapDo.Text = phuongPhapDo;
                    cbo_ChiTieu.Text = chiTieu;
                    //cbx_TieuChiID.Text = tieuChiID;
                    //txt_TenTieuChi.Text = tenTieuChi;
                    cbx_TieuChiID.Text = tenTieuChi;
                    txt_TenTieuChi.Text = tieuChiID;

                    // Hiển thị thông tin hoặc thực hiện hành động dựa trên dữ liệu của hàng được chọn

                }
                else
                {
                    // Xử lý trường hợp không thể chuyển đổi maKPI sang kiểu int
                    ev.QFrmThongBaoError("Lỗi khi lấy giá trị MaKPI từ cell clMaKPI");
                }
            }

        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }


        private void LoadDonViTinhComboBox()
        {
            using (SqlConnection connection = new SqlConnection(mconnectstring))
            {
                connection.Open();
                string query = "SELECT DISTINCT DonViTinh FROM KPI";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<string> donViTinhs = new List<string>();
                        while (reader.Read())
                        {
                            donViTinhs.Add(reader["DonViTinh"].ToString());
                        }
                        cbo_DonViTinh.DataSource = donViTinhs;
                    }
                }
            }
        }
        private bool isPercentAdded = true;

        private void cboDonViTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChitieuComboBox();

        }

        private void LoadChitieuComboBox()
        {
            string selectedDonViTinh = cbo_DonViTinh.Text;
            using (SqlConnection connection = new SqlConnection(mconnectstring))
            {
                connection.Open();
                string query = $"SELECT DISTINCT ChiTieu FROM KPI WHERE DonViTinh = N'{selectedDonViTinh}'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<string> chitieus = new List<string>(); // Sử dụng List<string> thay vì List<DateTime>
                        while (reader.Read())
                        {
                            chitieus.Add(reader["ChiTieu"].ToString()); // Đọc dữ liệu kiểu string
                        }
                        cbo_ChiTieu.DataSource = chitieus;
                    }
                }
            }
        }

        private void cbo_ChiTieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPhuongPhapDoComboBox();
        }

        private void LoadPhuongPhapDoComboBox()
        {
            string selectedDonViTinh = cbo_DonViTinh.Text;
            string selectedChitieu = cbo_ChiTieu.Text;
            using (SqlConnection connection = new SqlConnection(mconnectstring))
            {
                connection.Open();
                string query = $"SELECT DISTINCT PhuongPhapDo FROM KPI WHERE DonViTinh = N'{selectedDonViTinh}' AND ChiTieu = N'{selectedChitieu}'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<string> phuongPhapDos = new List<string>();
                        while (reader.Read())
                        {
                            phuongPhapDos.Add(reader["PhuongPhapDo"].ToString());
                        }
                        cbo_PhuongPhapDo.DataSource = phuongPhapDos;
                    }
                }
            }
        }

        //private void cbo_PhuongPhapDo_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    LoadDataGrid();
        //}

        //private void LoadDataGrid()
        //{
        //    string selectedDonViTinh = cbo_DonViTinh.Text;
        //    string selectedChitieu = cbo_ChiTieu.Text;
        //    string selectedPhuongPhapDo = cbo_PhuongPhapDo.Text;

        //    using (SqlConnection connection = new SqlConnection(mconnectstring))
        //    {
        //        connection.Open();
        //        string query = $"SELECT * FROM KPI WHERE DonViTinh = '{selectedDonViTinh}' AND ChiTieu = '{selectedChitieu}' AND PhuongPhapDo = '{selectedPhuongPhapDo}'";
        //        using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
        //        {
        //            DataTable dataTable = new DataTable();
        //            adapter.Fill(dataTable);
        //            dtgv_QLNganHangKPI.DataSource = dataTable;
        //        }
        //    }
        //}

        private void dtgv_QLNganHangKPI_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dtgv_QLNganHangKPI);
        }




        private void btn_CaNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isCaNhanSelected = true;
            isBenhVienSelected = false;
            Edit = 0;
            LoadData3();
            SetButtonVisibility(DevExpress.XtraBars.BarItemVisibility.Always);
            btn_Luu.Visible = true;
        }

        private void btn_BenhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isCaNhanSelected = false;
            isBenhVienSelected = true;
            Edit = 0;
            LoadData();
            SetButtonVisibility(DevExpress.XtraBars.BarItemVisibility.Never);
            chkCongViecCaNhan.Checked = false;
            ck_KPI.Visible = true;
            btn_Luu.Visible = false;
        }

        // Hàm này để thiết lập sự hiển thị của các nút
        private void SetButtonVisibility(DevExpress.XtraBars.BarItemVisibility visibility)
        {
            btnAdd.Visibility = visibility;
            btnEdit.Visibility = visibility;
            btnCancel.Visibility = visibility;
            btnSave.Visibility = visibility;
        }


        private void UpdatePercentIfNeeded()
        {
            if (cbo_DonViTinh.SelectedItem != null && cbo_DonViTinh.SelectedItem.ToString() == " %")
            {
                if (!isPercentAdded)
                {
                    cbo_ChiTieu.Text += "%";
                    isPercentAdded = true;
                }
            }
            else
            {
                cbo_ChiTieu.Text = cbo_ChiTieu.Text.TrimEnd('%');
                isPercentAdded = false;
            }
        }

        private void cbo_ChiTieu_Leave(object sender, EventArgs e)
        {
            UpdatePercentIfNeeded();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Edit = 0;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            #region luu
            //if (isDataChanged)
            //{
            //    if (Edit == 1)
            //    //thì là trạng thái thêm
            //    {
            //        string noiDung = txtNoiDung.Text;
            //        string donViTinh = cbo_DonViTinh.Text;
            //        string phuongPhapDo = cbo_PhuongPhapDo.Text;
            //        bool congViecCaNhan = chkCongViecCaNhan.Checked;
            //        string chiTieu = cbo_ChiTieu.Text;
            //        //string tieuChiID = cbx_TieuChiID.SelectedValue;

            //        //LoadData();
            //        ev.QFrmThongBao("Đã lưu dữ liệu thành công !");
            //        if (isCaNhanSelected)
            //        {
            //            //string tieuChiID = cbx_TieuChiID.SelectedValue;
            //            msql = $"INSERT INTO [dbo].[KPI] (NoiDung, DonViTinh, PhuongPhapDo, CongViecCaNhan, ChiTieu, TieuChiID,KPIDKT) VALUES (N'{noiDung}', N'{donViTinh}', N'{phuongPhapDo}', {(congViecCaNhan ? 1 : 0)}, N'{chiTieu}', N'" + cbx_TieuChiID.SelectedValue + "',1)";
            //            comm.RunSQL(mconnectstring, msql);
            //            LoadData3();
            //            ev.QFrmThongBao("Đã lưu dữ liệu thành công !");
            //        }
            //        else if (isBenhVienSelected)
            //        {
            //            msql = $"INSERT INTO [dbo].[KPI] (NoiDung, DonViTinh, PhuongPhapDo, CongViecCaNhan, ChiTieu, TieuChiID,KPIDKT) VALUES (N'{noiDung}', N'{donViTinh}', N'{phuongPhapDo}', {(congViecCaNhan ? 1 : 0)}, N'{chiTieu}', N'" + cbx_TieuChiID.SelectedValue + "',0)";
            //            comm.RunSQL(mconnectstring, msql);
            //            LoadData2();
            //            ev.QFrmThongBao("Đã lưu dữ liệu thành công !");
            //        }
            //    }
            //    if (Edit == 2)
            //    //trạng thái sửa
            //    {
            //        bool result = ev.QFrmThongBao_YesNo("Bạn có chắc chắn muốn sửa ?");
            //        if (result == true)
            //        {
            //            string noiDung = txtNoiDung.Text;
            //            string donViTinh = cbo_DonViTinh.Text;
            //            string phuongPhapDo = cbo_PhuongPhapDo.Text;
            //            bool congViecCaNhan = chkCongViecCaNhan.Checked;
            //            string chiTieu = cbo_ChiTieu.Text;
            //            string tieuChiID = txt_TenTieuChi.Text; // Hoặc sử dụng SelectedValue tùy thuộc vào cách bạn set up ComboBox         

            //            string updateSql = $"UPDATE [dbo].[KPI] SET NoiDung = N'{noiDung}', DonViTinh = N'{donViTinh}', PhuongPhapDo = N'{phuongPhapDo}', CongViecCaNhan = '{congViecCaNhan}', ChiTieu = '{chiTieu}', TieuChiID = '{tieuChiID}' WHERE MaKPI = {maKPI}";

            //            comm.RunSQL(mconnectstring, updateSql);
            //            ev.QFrmThongBao("Đã cập nhật dữ liệu thành công!");
            //        }
            //        if (isCaNhanSelected)
            //        {
            //            LoadData3();
            //        }
            //        else if (isBenhVienSelected)
            //        {
            //            LoadData();
            //        }
            //    }
            //    Edit = 0;

            //}
            #endregion
            Frm_AddKPIGrid form = new Frm_AddKPIGrid();
            form.ShowDialog();
        }
        private bool isDataChanged = false;
        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            isDataChanged = true;
            btn_Luu.Enabled = true;
        }

        private void cbo_DonViTinh_TextChanged(object sender, EventArgs e)
        {
            isDataChanged = true;
            btn_Luu.Enabled = true;
        }

        private void cbo_ChiTieu_TextChanged(object sender, EventArgs e)
        {
            isDataChanged = true;
            btn_Luu.Enabled = true;
        }

        private void cbo_PhuongPhapDo_TextChanged(object sender, EventArgs e)
        {
            isDataChanged = true;
            btn_Luu.Enabled = true;

        }

        private void cbx_TieuChiID_TextChanged(object sender, EventArgs e)
        {
            isDataChanged = true;
            btn_Luu.Enabled = true;
        }

        private void ck_KPI_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (ck_KPI.GetItemChecked(0) && ck_KPI.GetItemChecked(1))
            {
                LoadData();
            }
            else if (ck_KPI.GetItemChecked(0))
            {
                LoadData2();
            }
            else if (ck_KPI.GetItemChecked(1))
            {
                LoadData1();
            }
            
            else
            {
                LoadData();
            }
        }
    }

}
