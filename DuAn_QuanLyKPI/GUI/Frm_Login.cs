
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
        # endregion


        Timer timer = new Timer();
        public Frm_Login()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }
        #region DateTime
            private void timer1_Tick(object sender, EventArgs e)
            {
                lbTime.Text = DateTime.Now.ToLongTimeString();
                lbDate.Text = DateTime.Now.ToLongDateString();
            }
        #endregion
        private void txtdangnhap_Enter_1(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
            if (txtdangnhap.Text != "")
            {

            }
            else
            {
                txtdangnhap.Text = "";
            }

        }
        private void txtdangnhap_Leave_1(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }
        private void txtmat_khau_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
            if (txtPassword.Text != "")
            {

            }
            else
            {
                txtPassword.Text = "";
            }
        }
        private void txtmat_khau_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }
        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

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
        private void btndangnhap_Click(object sender, EventArgs e)  
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

            //SqlDataAdapter da = new SqlDataAdapter("select * From [dbo].[DUOC_KC_tab.TAIKHOAN] where TenDangNhap = '" + txtdangnhap.Text + "' and  MatKhau='" + txtmatkhau.Text + "'", mconnectstring);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //if (dt.Rows.Count > 0)

            //{

            //    ev.QFrmThongBao("Đăng nhập thành công");

            //    //tendn = dt.Rows[0]["TenDangNhap"].ToString();

            //    Frm_Home f = new Frm_Home();
            //    this.Hide();

            //    f.ShowDialog();
            //}
            //else
            //{

            //    ev.QFrmThongBaoError("Đăng nhập không thành công");
            //}
            Frm_Login fl = new Frm_Login();
            fl.Close();
        }
        private void pbHien_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                pbAn.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }
        private void pbAn_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                pbHien.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
            txtPassword.Text = "";
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Trigger the button click event
                btndangnhap.PerformClick();

                // Mark the key press as handled to prevent it from being processed further
                e.Handled = true;
            }
        }
    }
}
