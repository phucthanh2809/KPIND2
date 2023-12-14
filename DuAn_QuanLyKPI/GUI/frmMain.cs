using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using PhanMemQuanLyKPI.DAO;
using PhanMemQuanLyKPI.DTO;
using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyKPI
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtDanhSach1;
        DataTable dtDanhSach2 = new DataTable();

        DataTable dtKhachHang1;
        DataTable dtKhachHang2 = new DataTable();
        public frmMain()
        {
            InitializeComponent();
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

        }
        PHONGKHOA _phongkhoa;

        private void frmMain_Load(object sender, EventArgs e)
        {
            loadData();
            loadData2();

            loadKH1();
            loadKH2();


            loadTaiChinhHT();

            txtTen.Enabled = false;
            txtViTri.Enabled = false;
            _phongkhoa = new PHONGKHOA();
            loadChungMinh();
            loadEnabled();


            btnXoa.Click += BtnXoa_Click;
            gvDanhSach1.CustomDrawColumnHeader += GvDanhSach1_CustomDrawColumnHeader;

            gvDanhSach2.ShowingEditor += GvDanhSach2_ShowingEditor;
            gvDanhSach2.ValidatingEditor += GvDanhSach2_ValidatingEditor;


        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (gvDanhSach2.GetFocusedRowCellValue("MaKPI") != null)
            {
                string maKPI = gvDanhSach2.GetFocusedRowCellValue("MaKPI").ToString();

                // Xóa MaPhieuKPIBV tương ứng từ DataTable mới của danh sách 2
                DataRow[] rowsToDelete = dtDanhSach2.Select($"MaKPI = '{maKPI}'");
                foreach (var row in rowsToDelete)
                {
                    dtDanhSach2.Rows.Remove(row);
                }

                gcDanhSach2.DataSource = dtDanhSach2; // Cập nhật DataSource cho danh sách 2
                for (int i = 0; i < gvDanhSach1.RowCount; i++)
                {
                    string maPhieuKPIBV = gvDanhSach1.GetRowCellValue(i, "MaKPI").ToString();
                    if (maPhieuKPIBV == maKPI)
                    {
                        gvDanhSach1.UnselectRow(i); // Hủy chọn dòng tương ứng
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn KPI", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TinhTrongSo();
        }

        private void GvDanhSach2_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "TrongSoTCBV")
            {
                double result;
                if (!double.TryParse(e.Value.ToString(), out result))
                {
                    e.Valid = false;
                    MessageBox.Show(e.ErrorText = "Vui lòng nhập số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GvDanhSach2_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "TrongSoTCBV")
            {
                string cellValue = view.GetFocusedValue().ToString();
                double result;
                e.Cancel = !double.TryParse(cellValue, out result);
            }
        }

        private void GvDanhSach1_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column != null)
            {
                GridColumn column = e.Column;

                if (column.ColumnType == typeof(bool) && column.Visible && column.OptionsColumn.AllowSort == DefaultBoolean.False)
                {
                    column.Caption = "Chọn tất cả";
                }
            }
        }






        void loadData()
        {
            dtDanhSach1 = myFunctions.laydulieu("SELECT A.MaPhieuKPIBV, A.IDBieuMau, B.TrongSoTCBV, C.NoiDung, C.MaKPI, C.PhuongPhapDo, C.TieuChiID, C.DonViTinh, " +
         "D.TieuChiDanhGiaKQ, D.NguonChungMinh, D.KeHoach, D.ThucHien, D.HoanThanh FROM dbo.KPI_BenhVien A INNER JOIN dbo.ChiTietTieuChiMucTieuBV B ON A.MaPhieuKPIBV = B.MaPhieuKPIBV " +
         "INNER JOIN dbo.KPI C ON B.MaKPI = C.MaKPI LEFT JOIN dbo.ChiTietKPIBenhVien D ON A.MaPhieuKPIBV = D.MaPhieuKPIBV WHERE C.TIeuChiID = 'F'");

            gcDanhSach1.DataSource = dtDanhSach1;
            gvDanhSach1.OptionsBehavior.Editable = false;
            gvDanhSach1.ColumnPanelRowHeight = 60;
            gvDanhSach1.Appearance.HeaderPanel.BackColor = Color.LightBlue;
            gvDanhSach1.Appearance.HeaderPanel.ForeColor = Color.DeepPink;
        }

        void loadData2()
        {
            dtDanhSach2 = dtDanhSach1.Clone();
            gvDanhSach2.ColumnPanelRowHeight = 60;
            gvDanhSach2.Appearance.HeaderPanel.BackColor = Color.LightBlue;
            gvDanhSach2.Appearance.HeaderPanel.ForeColor = Color.DeepPink;
        }

        void loadKH1()
        {
            dtKhachHang1 = myFunctions.laydulieu("SELECT A.MaPhieuKPIBV, A.IDBieuMau, B.TrongSoTCBV, C.NoiDung, C.MaKPI, C.PhuongPhapDo, C.TieuChiID, C.DonViTinh, " +
       "D.TieuChiDanhGiaKQ, D.NguonChungMinh, D.KeHoach, D.ThucHien, D.HoanThanh FROM dbo.KPI_BenhVien A INNER JOIN dbo.ChiTietTieuChiMucTieuBV B ON A.MaPhieuKPIBV = B.MaPhieuKPIBV " +
       "INNER JOIN dbo.KPI C ON B.MaKPI = C.MaKPI LEFT JOIN dbo.ChiTietKPIBenhVien D ON A.MaPhieuKPIBV = D.MaPhieuKPIBV WHERE C.TIeuChiID = 'C'");

            gcKhachHang1.DataSource = dtDanhSach1;
            gvKhachHang1.OptionsBehavior.Editable = false;
            gvKhachHang1.ColumnPanelRowHeight = 60;
            gvKhachHang1.Appearance.HeaderPanel.BackColor = Color.LightBlue;
            gvKhachHang1.Appearance.HeaderPanel.ForeColor = Color.DeepPink;
        }

        void loadKH2()
        {
            dtKhachHang2 = dtKhachHang1.Clone();
            gvKhachHang2.ColumnPanelRowHeight = 60;
            gvKhachHang2.Appearance.HeaderPanel.BackColor = Color.LightBlue;
            gvKhachHang2.Appearance.HeaderPanel.ForeColor = Color.DeepPink;
        }


        void loadChungMinh()
        {
            slkChungMinh.DataSource = _phongkhoa.getList();
            slkChungMinh.DisplayMember = "MaPK";
            slkChungMinh.ValueMember = "TenPK";
        }

        void loadTaiChinhHT()
        {
            gvTaiChinhHT.OptionsBehavior.Editable = true;
            gvTaiChinhHT.ColumnPanelRowHeight = 60;
            gvTaiChinhHT.Appearance.HeaderPanel.BackColor = Color.LightBlue;
            gvTaiChinhHT.Appearance.HeaderPanel.ForeColor = Color.DeepPink;
        }

        void loadEnabled()
        {
            gvTaiChinhHT.OptionsBehavior.Editable = false;
        }


        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (IsHandleCreated)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    //lblTime.Text = DateTime.Now.ToString("T");
                    lblDay.Text = DateTime.Now.ToLongDateString();
                }));
            }
        }


        private void TinhTrongSo()
        {
            int sc = gvDanhSach2.RowCount;
            double sum = 0;
            for (int i = 0; i < sc; ++i)
                sum += double.Parse(gvDanhSach2.GetFocusedRowCellValue("TrongSoTCBV").ToString());
            txtTongTrongSo.Text = sum.ToString();
        }


        private void gvDanhSach1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            var selectedRows = gvDanhSach1.GetSelectedRows();

            foreach (var rowHandle in selectedRows)
            {
                DataRow dataRow = gvDanhSach1.GetDataRow(rowHandle);
                string maPhieuKPIBV = dataRow["MaKPI"].ToString();

                DataRow[] foundRows = dtDanhSach2.Select($"MaKPI = '{maPhieuKPIBV}'");

                if (foundRows.Length == 0)
                {
                    dtDanhSach2.ImportRow(dataRow); // Thêm dữ liệu vào DataTable mới của danh sách 2
                }
            }

            gcDanhSach2.DataSource = dtDanhSach2;
            TinhTrongSo();
        }


        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            int range = 100;
            int trongSo = 0;

            gcTaiChinhHT.DataSource = dtDanhSach2;
            if (int.TryParse(txtTongTrongSo.Text, out trongSo))
            {
                if (trongSo > range)
                {
                    DialogResult dialogResult = MessageBox.Show("Trọng số đang lớn hơn 100. Bạn có muốn tiếp tục?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                    // Kiểm tra nếu người dùng chọn Yes
                    if (dialogResult == DialogResult.Yes)
                    {
                        tabDanhSach.SelectedTabPage = tabKhachHang;
                    }
                    else
                    {
                        return;
                    }
                }
                //else if (txtTongTrongSo.Text == trongSo.ToString())
                //{
                //    MessageBox.Show("Trọng số đang bằng 0. Vui lòng chọn danh mục KPI?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                //} 
                else
                {
                    tabDanhSach.SelectedTabPage = tabKhachHang;
                }
            }
            else
            {
                MessageBox.Show("Trọng số KPI đang thiếu. Vui lòng kiểm tra lại thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void DeleteSelectedRows(DataTable dataTable, GridView gridView)
        {
            var selectedRows = gridView.GetSelectedRows();

            List<string> selectedMaPhieuKPIBV = new List<string>();
            foreach (var rowHandle in selectedRows)
            {
                string maPhieuKPIBV = gridView.GetRowCellValue(rowHandle, "MaKPI").ToString();
                selectedMaPhieuKPIBV.Add(maPhieuKPIBV);
            }

            for (int i = dataTable.Rows.Count - 1; i >= 0; i--)
            {
                string maPhieuKPIBV = dataTable.Rows[i]["MaKPI"].ToString();
                if (selectedMaPhieuKPIBV.Contains(maPhieuKPIBV))
                {
                    dataTable.Rows.RemoveAt(i);
                }
            }

            gcDanhSach2.DataSource = dataTable;

            // Vô hiệu hóa tạm thời sự kiện SelectionChanged để xử lý xóa các dòng đã chọn
            gvDanhSach1.SelectionChanged -= gvDanhSach1_SelectionChanged;

            // Duyệt qua danh sách 1 để hủy chọn các dòng đã xóa từ danh sách 2
            for (int i = 0; i < gvDanhSach1.RowCount; i++)
            {
                string maPhieuKPIBV = gvDanhSach1.GetRowCellValue(i, "MaKPI").ToString();
                if (selectedMaPhieuKPIBV.Contains(maPhieuKPIBV))
                {
                    gvDanhSach1.UnselectRow(i);
                }
            }

            // Kích hoạt lại sự kiện SelectionChanged sau khi hoàn tất xóa
            gvDanhSach1.SelectionChanged += gvDanhSach1_SelectionChanged;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DeleteSelectedRows(dtDanhSach2, gvDanhSach1);
            TinhTrongSo();
        }


        private void gvDanhSach2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            TinhTrongSo();
        }

        private void gvDanhSach2_MouseDown(object sender, MouseEventArgs e)
        {
            {
                GridView view = sender as GridView;
                if (view != null && e.Button == MouseButtons.Left)
                {
                    DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hitInfo = view.CalcHitInfo(e.Location);
                    if (hitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.Column)
                    {
                        string columnName = hitInfo.Column.FieldName; // Tên của cột được click
                                                                      // Thực hiện xóa dữ liệu hoặc các hành động khác dựa trên tên cột ở đây
                                                                      // Ví dụ:
                        if (columnName == "XOAALL")
                        {
                            DeleteSelectedRows(dtDanhSach2, gvDanhSach1);
                            TinhTrongSo();
                        }

                    }
                }
            }
        }
    }
}
    
 
