using DevExpress.XtraEditors;
using DuAn_QuanLyKPI.Constants;
using DuAn_QuanLyKPI.DTO;
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
    public partial class Frm_AddUser : DevExpress.XtraEditors.XtraForm
    {
        public Frm_AddUser()
        {
            InitializeComponent();
        }
        #region MyRegion
        void AddNguoiDung()
        {

            var db = DataProvider.Ins.DB;
            if (pbUser.Image != null)
            {
                NguoiDung nguoidung = new NguoiDung();
                nguoidung.MaNV = txtMaNV.Text;
                nguoidung.TenNV = txtHoten.Text;
                nguoidung.Gmail = txtEmail.Text;
                nguoidung.SDT = txtSDT.Text;
                nguoidung.TenTaiKhoan = txtTenTaiKhoan.Text.ToString();
                nguoidung.HinhAnhNV = ImageToBase64(pbUser.Image, ImageFormat.Jpeg);
                nguoidung.MatKhau = txtMatKhau.Text;
                nguoidung.MaPhongKhoa = cboPhongKhoa.SelectedValue.ToString();
                nguoidung.MaChucDanh = cboChucDanh.SelectedValue.ToString();
                db.NguoiDung.Add(nguoidung);
                db.SaveChanges();
                ev.QFrmThongBao("Thêm người dùng thành công");
                LoadData();
            }
            else
            {
                ev.QFrmThongBaoError("Vui lòng nhập đủ thông tin!");
            }
            #endregion
            private void btnLuuThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Trim() != "")
            {
                AddNguoiDung();
                AddPhanQuyen();
            }
            else
            {
                ev.QFrmThongBaoError("Vui lòng nhập đủ thông tin");
            }
        }
    }
}