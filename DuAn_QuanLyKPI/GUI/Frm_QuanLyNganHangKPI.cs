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
            LoadData();
            ChoPhepNhap();
            LoadCbo();
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

            msql = "SELECT * FROM [dbo].[KPI],[dbo].[NhomTieuChi] where KPI.TieuChiID = NhomTieuChi.TieuChiID";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "KPI");
            dtgv_QLNganHangKPI.AutoGenerateColumns = false;
            dtgv_QLNganHangKPI.DataSource = tb;
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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
            
            txtNoiDung.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            txtDonViTinh.Enabled = true;
            txtDonViTinh.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            txtPhuongPhapDo.Enabled = true;
            txtPhuongPhapDo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            txtChiTieu.Enabled = true;
            txtChiTieu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
        }
        private void LamMoiThongTin()
        {
            txtNoiDung.Text = "";
            txtDonViTinh.Text = "";
            txtPhuongPhapDo.Text = "";
            txtChiTieu.Text = "";
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
                msql = "INSERT INTO [dbo].[KPI] (NoiDung, DonViTinh, PhuongPhapDo,CongViecCaNhan, ChiTieu, TieuChiID) VALUES (N'" + txtNoiDung.Text + "','" + txtDonViTinh.Text + "','" + txtPhuongPhapDo.Text + "','" + chkCongViecCaNhan.Checked + "','" + txtChiTieu.Text + "','"+cbx_TieuChiID.SelectedValue.ToString()+"')";
                comm.RunSQL(mconnectstring, msql);
                LoadData();
            }
            if (Edit == 2)
            //trạng thái sửa
            {
                int maKPI = 0;
                if (dtgv_QLNganHangKPI.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dtgv_QLNganHangKPI.SelectedRows[0];
                    int.TryParse(selectedRow.Cells["cMaKPI"].Value.ToString(), out maKPI);
                }
                msql = "UPDATE [dbo].[KPI] SET NoiDung = N'" + txtNoiDung.Text + "', DonViTinh = N'" + txtDonViTinh.Text + "', PhuongPhapDo = N'" + txtPhuongPhapDo.Text + "',CongViecCaNhan = '" + chkCongViecCaNhan.Checked + "', ChiTieu = '" + txtChiTieu.Text + "', TieuChiID = '" + cbx_TieuChiID.SelectedValue + "' WHERE MaKPI ='" + maKPI + "'";
                comm.RunSQL(mconnectstring, msql);
                LoadData();
            }
            Edit = 0;

        }

        private void btnCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraForm1 form = new XtraForm1();
            form.ShowDialog();
        }
        //Lấy dữ liệu từ gridview đổ lên các textbox
        private void dtgv_QLNganHangKPI_Click(object sender, EventArgs e)
        {
            if (dtgv_QLNganHangKPI.SelectedRows.Count > 0)
            {
                // Lấy thông tin từ hàng được chọn
                DataGridViewRow selectedRow = dtgv_QLNganHangKPI.SelectedRows[0];
                string noiDung = selectedRow.Cells["cNoiDung"].Value.ToString();
                string donViTinh = selectedRow.Cells["cDonViTinh"].Value.ToString();
                string phuongPhapDo = selectedRow.Cells["cPhuongPhapDo"].Value.ToString();
                string congViecCaNhanStr = selectedRow.Cells["cCongViecCaNhan"].Value.ToString();
                bool congViecCaNhan;
                if (bool.TryParse(congViecCaNhanStr, out congViecCaNhan))
                {
                    // Đặt giá trị bool vào CheckBox
                    chkCongViecCaNhan.Checked = congViecCaNhan;
                }
                string chiTieu = selectedRow.Cells["cChiTieu"].Value.ToString();
                string tieuChiID = selectedRow.Cells["cTieuChiID"].Value.ToString();
                string tenTieuChi = selectedRow.Cells["cTenTieuChi"].Value.ToString();
                // Lấy thông tin từ các ô cột khác nếu cần
                txtNoiDung.Text = noiDung;
                txtDonViTinh.Text = donViTinh;
                txtPhuongPhapDo.Text = phuongPhapDo;
                txtChiTieu.Text = chiTieu;
                cbx_TieuChiID.Text = tieuChiID;
                txt_TenTieuChi.Text = tenTieuChi;

                // Hiển thị thông tin hoặc thực hiện hành động dựa trên dữ liệu của hàng được chọn
                MessageBox.Show($"Đã chọn hàng có nội dung: {noiDung}");
            }
        }
        //Xóa
        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int maKPI = 0;
            if (dtgv_QLNganHangKPI.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgv_QLNganHangKPI.SelectedRows[0];
                int.TryParse(selectedRow.Cells["cMaKPI"].Value.ToString(), out maKPI);
            }
            msql = "DELETE [dbo].[KPI] WHERE MaKPI ='" + maKPI + "'";
            comm.RunSQL(mconnectstring, msql);
            LoadData();
        }

        private void dtgv_QLNganHangKPI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int selectedRowIndex = dtgv_QLNganHangKPI.SelectedCells[0].RowIndex;
                if (selectedRowIndex >= 0 && selectedRowIndex < dtgv_QLNganHangKPI.Rows.Count)
                {
                    DataGridViewRow selectedRow = dtgv_QLNganHangKPI.Rows[selectedRowIndex];
                    string noidung = selectedRow.Cells["cNoiDung"].Value != null ? selectedRow.Cells["cNoiDung"].Value.ToString() : "";


                    string donvitinh = selectedRow.Cells["cDonViTinh"].Value != null ? selectedRow.Cells["cDonViTinh"].Value.ToString() : "";
                    string phuongphapdo = selectedRow.Cells["cPhuongPhapDo"].Value != null ? selectedRow.Cells["cPhuongPhapDo"].Value.ToString() : "";
                    bool congvieccanhan = selectedRow.Cells["cCongViecCaNhan"].Value != null && (bool)selectedRow.Cells["cCongViecCaNhan"].Value;
                    string chitieu = selectedRow.Cells["cChiTieu"].Value != null ? selectedRow.Cells["cChiTieu"].Value.ToString() : "";

                    Frm_XemChiTietQuanLyNganHangKPI form2 = new Frm_XemChiTietQuanLyNganHangKPI();
                    form2.SetData(noidung, donvitinh, phuongphapdo, congvieccanhan, chitieu);
                    form2.Show();
                }
            }
        }

        private void cbx_TieuChiID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy giá trị được chọn từ ComboBox
            string tenTieuChi = cbx_TieuChiID.Text;

            // Đặt giá trị vào TextBox
            txt_TenTieuChi.Text = tenTieuChi;
        }
    }
}
