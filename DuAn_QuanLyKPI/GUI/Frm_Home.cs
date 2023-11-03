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
    public partial class Frm_Home : Form
    {
        public Frm_Home()
        {
            InitializeComponent();
            Loaddata();
        }

        public void Load(object Form)
        {
            if (this.pnhome.Controls.Count > 0)
                this.pnhome.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnhome.Controls.Add(f);
            this.pnhome.Tag = f;
            f.Show();

        }
        void Loaddata()
        {


            //var db = DataProvider.Ins.DB;
            //var nguoidung = db.NguoiDung.Where(x => x.TenTaiKhoan).FirstOrDefault();
            //if (nguoidung.TenTaiKhoan == "kha")
            //{
            //    btnQuanLyNguoiDung.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            //}
            //else if(nguoidung.TenTaiKhoan == "An")
            //{
            //    btnQuanLyNguoiDung.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

            //}
            //var db = DataProvider.Ins.DB;
            //bool isButtonVisible = (db != null); 
            //NguoiDung nguoidung = new NguoiDung();
            //var a =nguoidung.TenTaiKhoan = "kha";

            //if (a)
            //{

            //    btnQuanLyNguoiDung.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            //}
            //else
            //{

            //}


        }

        //public bool LogoutUser(int userId)
        //{

        //    var db = DataProvider.Ins.DB;
        //    NguoiDung nguoidung = new NguoiDung();

        //    try
        //    {
        //        // Tìm thông tin người dùng cần đăng xuất
        //        var user = NguoiDung.nguoidung.FirstOrDefault(u => u.m == userId);

        //        if (user != null)
        //        {
        //            // Đặt trạng thái đăng nhập của người dùng về false hoặc xóa thông tin đăng nhập
        //            user.IsLoggedIn = false;
        //            // Lưu thay đổi vào cơ sở dữ liệu bằng Entity Framework
        //            NguoiDung.SaveChanges();

        //            // Đăng xuất thành công
        //            return true;
        //        }

        //        // Người dùng không tồn tại hoặc đã đăng xuất trước đó
        //        return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Xử lý lỗi nếu cần thiết
        //        Console.WriteLine("Lỗi khi đăng xuất người dùng: " + ex.Message);
        //        return false;
        //    }
        //}
        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Login f1 = new Frm_Login();
            f1.ShowDialog();
        }

        private void btnQuanLyNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Load(new Frm_User());
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            Frm_Login home = new Frm_Login();
            home.Show();



        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Change_Password c = new Frm_Change_Password();
            c.Show();

        }
    }
}
