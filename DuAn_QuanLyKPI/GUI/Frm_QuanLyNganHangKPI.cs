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

namespace DuAn_QuanLyKPI.GUI
{
    public partial class Frm_QuanLyNganHangKPI : DevExpress.XtraEditors.XtraForm, INotifyPropertyChanged
    {
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        private int _edit = 0;
        private string makpi = "";
        public int Edit { get => _edit; 
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

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Frm_QuanLyNganHangKPI()
        {
            InitializeComponent();
            LoadData();
            //ShowGridPreview(GridControl grid);
        }

        private void LoadData ()
        {
            var db = DataProvider.Ins.DB;
            dgrMucTieuNganHang.DataSource = db.KPI.ToList();
        }
        
        private void cboChucDanh_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var db = DataProvider.Ins.DB;
            //switch (cboFilter.SelectedIndex)
            //{
            //    case 0:
            //        var list1 = db.KPI.ToList();
            //        dgrMucTieuNganHang.DataSource = list1;
            //        break; 
            //    case 1:
            //        var list2 = db.KPI.Where(x => x.NganHangKPI.Any(b => b.MaPK == cboKhoaPhong.SelectedValue.ToString())).ToList();
            //        dgrMucTieuNganHang.DataSource = list2;
            //        break;
            //    case 2:
            //        var list3 = db.KPI.Where(x => x.NganHangKPI.Any(b => b.MaChucDanh == cboChucDanh.SelectedValue.ToString())).ToList();
            //        dgrMucTieuNganHang.DataSource = list3;
            //        break;
            //    case 3:
            //        var list4 = db.KPI.Where(x => x.NganHangKPI.Any(b => b.MaChucDanh == cboChucDanh.SelectedValue.ToString() && b.MaPK == cboKhoaPhong.SelectedValue.ToString())).ToList();
            //        dgrMucTieuNganHang.DataSource = list4;
            //        break;
            //}
        }

        


        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadLuu()
        {
            var db = DataProvider.Ins.DB;
            KPI kpi = new KPI();
            kpi.NoiDung = txtNoiDung.Text.Trim();
            kpi.DonViTinh = txtDonViTinh.Text.Trim();
            kpi.PhuongPhapDo = txtPhuongPhapDo.Text.Trim();
            kpi.ChiTieu = txtChiTieu.Text.Trim();
            kpi.CongViecCaNhan = chkCongViecCaNhan.Checked;
            db.KPI.Add(kpi);
            db.SaveChanges();
            MessageBox.Show("Bạn đã nhập dữ liệu thành công");
            LoadData();
        }

        private void LoadSua()
        {
            var db = DataProvider.Ins.DB;
            KPI kpi = db.KPI.Where(x => x.NoiDung == txtNoiDung.Text).FirstOrDefault();
            txtNoiDung.Text = kpi.NoiDung;
            txtDonViTinh.Text = kpi.DonViTinh;
            txtPhuongPhapDo.Text = kpi.PhuongPhapDo;
            txtChiTieu.Text = kpi.ChiTieu;
            db.KPI.Attach(kpi);
            db.Entry(kpi).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            MessageBox.Show("Bạn đã sửa thành công!!");
        }

        private void loadXoa()
        {
            
            try
            {
                var db = DataProvider.Ins.DB;
                //string id = txtMaKPI.Text;
                KPI nd = db.KPI.Where(x => x.NoiDung == txtNoiDung.Text).SingleOrDefault();
                txtNoiDung.Text = nd.NoiDung;
                txtDonViTinh.Text = nd.DonViTinh;
                txtPhuongPhapDo.Text = nd.PhuongPhapDo;
                txtChiTieu.Text = nd.ChiTieu;
                db.KPI.Remove(nd);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Bạn đã xóa thành công!!");
            }
            catch
            {
                MessageBox.Show("Bạn đã bị lỗi!!");
            }
        }
        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowGridPreview(dgrMucTieuNganHang);
        }



        //private void FrmQuanLyNganHangKPI_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    switch (e.KeyChar.ToString().ToLower())
        //    {
        //        case  "crtl+1":this.BtnLuu.PerformClick();
        //            break;
        //        case  "crtl+2":this.btnLoadData.PerformClick();
        //            break;
        //    }
        //}


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
            //LamMoiNgayHienTai();
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
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Edit == 1)
            {
                //thì là trạng thái thêm
                LoadLuu();
            }
            else
            {
                //thì là trạng thái sửa
                LoadSua();
            }
            Edit = 0;

        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Edit = 0;
            loadXoa();
        }
        private void btnCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_CapDanhSachKPI f = new Frm_CapDanhSachKPI();
            f.ShowDialog(); 
        }
        private void btnXemAllMucTieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_XemMucTieuKPI f = new Frm_XemMucTieuKPI();
            f.ShowDialog();
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            makpi = gridView2.GetFocusedRowCellValue("MaKPI").ToString();
            txtNoiDung.Text = gridView2.GetFocusedRowCellValue("NoiDung").ToString();
            txtDonViTinh.Text = gridView2.GetFocusedRowCellValue("DonViTinh").ToString();
            txtPhuongPhapDo.Text = gridView2.GetFocusedRowCellValue("PhuongPhapDo").ToString();
            txtChiTieu.Text = gridView2.GetFocusedRowCellValue("ChiTieu").ToString();
            var a = gridView2.GetFocusedRowCellValue("CongViecCaNhan").ToString();
            if (a == "True")
                chkCongViecCaNhan.Checked = true;
            else 
                chkCongViecCaNhan.Checked = false;

            //FrmChiTietQuanLyNganHang f = new FrmChiTietQuanLyNganHang();
            //f.ShowDialog();
            //makpi = gridView2.GetFocusedRowCellValue("NoiDung").ToString();
            //makpi = gridView2.GetFocusedRowCellValue("DonViTinh").ToString();
            //makpi = gridView2.GetFocusedRowCellValue("PhuongPhapDo").ToString();
            //makpi = gridView2.GetFocusedRowCellValue("ChiTieu").ToString();
            //makpi = gridView2.GetFocusedRowCellValue("CongViecCaNhan").ToString();
            //if (makpi == "True")
            //    chkCongViecCaNhan.Checked = true;
            //else
            //    chkCongViecCaNhan.Checked = false;
        }

        private void dgrMucTieuNganHang_DoubleClick(object sender, EventArgs e)
        {
            Frm_XemChiTietQuanLyNganHangKPI f = new Frm_XemChiTietQuanLyNganHangKPI(makpi);
            f.ShowDialog();
        }

        private void btnCap_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
