
using BusinessCommon;
using DuAn_QuanLyKPI.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn_QuanLyKPI.GUI
{
    public partial class Frm_Login : DevExpress.XtraEditors.XtraForm
    {
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");

        #region Tạo biến truyền dữ liệu
            public static string a;
            public static string MaNV;
            public static string TenNV;
            public static string TenChucDanh;
            public static string MaPhongKhoa;
            public static string MaChucDanh;
            public static string TenPhongKhoa;
            public static string Email;
            public static string SDT;
            public static string PhanQuyen;
            public static string TK;
            public static byte[] HinhAnh;
            public static bool TPK;
            public static int CapDoBieuMauKPI;
        # endregion


        Timer timer = new Timer();

        List<Image> images = new List<Image>();
        string[] location = new string[25];
        public Frm_Login()
        {
            InitializeComponent();
            timer1.Enabled = true;
            LoadImage();
            tounage();
        }
        #region DateTime
            private void timer1_Tick(object sender, EventArgs e)
            {
                lbTime.Text = DateTime.Now.ToLongTimeString();
                lbDate.Text = DateTime.Now.ToLongDateString();
            }
        #endregion
        private byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            if (image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, format);
                    byte[] imageBytes = ms.ToArray();
                    return imageBytes;
                }
            }
            else
            {
                // Handle the case where 'image' is null, for example:
                ev.QFrmThongBaoError("Vui lòng tải hình ảnh lên");
                return null; // Or return an appropriate default value
            }
        }
        #region animation
        private void LoadImage()
        {
            location[0] = @"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_user_1.jpg";
            location[1] = @"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_user_2.jpg";
            location[2] = @"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_user_4.jpg";
            location[3] = @"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_user_5.jpg";
            location[4] = @"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_user_6.jpg";
            location[5] = @"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_user_7.jpg";
            location[6] = @"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_user_8.jpg";
            location[7] = @"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_user_9.jpg";
            location[8] = @"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_user_10.jpg";
            location[9] = @"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_user_11.jpg";
            location[10] = @"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_user_12.jpg";
            location[11] = @"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_user_13.jpg";
            location[12] = @"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_user_14.jpg";
            location[13] = @"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_user_15.jpg";
            location[14] = @"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_user_16.jpg";
            location[15] = @"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_user_17.jpg";
            location[16] = @"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_user_18.jpg";
            location[17] = @"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_user_19.jpg";
            location[18] = @"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_user_20.jpg";
            location[19] = @"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_user_21.jpg";
            location[20] = @"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_user_22.jpg";
            location[21] = @"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_user_23.jpg";
            location[22] = @"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_user_24.jpg";
        }
        private void tounage()
        { 
            for (int i = 0; i < 23; i++)
            {
                Bitmap bitmap = new Bitmap(location[i]);
                images.Add(bitmap);
            }
            images.Add(Properties.Resources.textbox_user_24);
        }
        private void txtdangnhap_TextChanged(object sender, EventArgs e)
        {
            if (txtdangnhap.Text.Length > 0 && txtdangnhap.Text.Length <= 15)
            {
                pictureBox1.Image = images[txtdangnhap.Text.Length - 1];
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (txtdangnhap.Text.Length <= 0)
                pictureBox1.Image = Properties.Resources.debut;
            else
                pictureBox1.Image = images[22];
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            Bitmap bmpass = new Bitmap(@"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_password.png");
            pictureBox1.Image = bmpass;
        }

        private void txtdangnhap_Click(object sender, EventArgs e)
        {
            if (txtdangnhap.Text.Length > 0)
                pictureBox1.Image = images[txtdangnhap.Text.Length - 1];
            else
                pictureBox1.Image = Properties.Resources.debut;
        }
        #endregion

        private void txtdangnhap_Enter(object sender, EventArgs e)
        {
            if (txtdangnhap.Text != "")
            {

            }
            else
            {
                txtdangnhap.Text = "";
            }
        }

        private void txtPassword_Enter_1(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {

            }
            else
            {
                txtPassword.Text = "";
            }
            Bitmap bmpass = new Bitmap(@"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_password.png");
            pictureBox1.Image = bmpass;
        }
        private void pbHien_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                pbAn.BringToFront();
                txtPassword.PasswordChar = '\0';
                if (txtdangnhap.Text.Length > 0)
                    pictureBox1.Image = images[txtdangnhap.Text.Length - 1];
                else
                    pictureBox1.Image = Properties.Resources.debut;
            }

        }

        private void pbAn_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                pbHien.BringToFront();
                txtPassword.PasswordChar = '*';
                Bitmap bmpass = new Bitmap(@"D:\Thanh Phuc\Dự án quản lý KPI\Du An KPI\animation\textbox_password.png");
                pictureBox1.Image = bmpass;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Trigger the button click event
                btnLogin.PerformClick();

                // Mark the key press as handled to prevent it from being processed further
                e.Handled = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tentk = txtdangnhap.Text;
            string mk = txtPassword.Text;
            var db = DataProvider.Ins.DB;
            var nguoidung = db.NguoiDung.Where(x => x.TenTaiKhoan == tentk && x.MatKhau == mk).FirstOrDefault();
            if (nguoidung != null)
            {
                #region  truyền dữ liệu sau khi đăng nhập thành công
                DataUserCurrent.Instance.IDUserCurrent = nguoidung.MaNV;
                DataUserCurrent.Instance.Permission = nguoidung.MaQuyen;

                MaNV = DataUserCurrent.Instance.Permission = nguoidung.MaNV;
                MaPhongKhoa = DataUserCurrent.Instance.Permission = nguoidung.MaPhongKhoa;
                TenPhongKhoa = DataUserCurrent.Instance.Permission = nguoidung.PhongKhoa.TenPK;
                MaChucDanh = DataUserCurrent.Instance.Permission = nguoidung.MaChucDanh;
                TenChucDanh = DataUserCurrent.Instance.Permission = nguoidung.ChucDanh.TenChucDanh;
                TenNV = DataUserCurrent.Instance.Permission = nguoidung.TenNV;
                Email = DataUserCurrent.Instance.Permission = nguoidung.Gmail;
                SDT = DataUserCurrent.Instance.Permission = nguoidung.SDT;
                TK = DataUserCurrent.Instance.Permission = nguoidung.TenTaiKhoan;
                CapDoBieuMauKPI = (int)nguoidung.MaCapDoKPIBenhVien;
                DataUserCurrent.Instance.Permission = CapDoBieuMauKPI.ToString();
                byte[] hinhAnhBytes = nguoidung.HinhAnhNV;
                DataUserCurrent.Instance.Permission = hinhAnhBytes.ToString();
                HinhAnh = hinhAnhBytes;



                #endregion
                if (DataUserCurrent.Instance.Permission != "NV")
                {
                    ev.QFrmThongBao("Đăng nhập thành công");
                    Frm_Chinh_GUI f = new Frm_Chinh_GUI();
                    this.Hide();
                    f.ShowDialog();
                }
                else
                {
                    ev.QFrmThongBaoError("Không có quyền vào form dành cho lãnh đạo");
                }
            }
            else
            {
                ev.QFrmThongBaoError("Đăng nhập thất bại");
            }
            Frm_Login fl = new Frm_Login();
            fl.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
