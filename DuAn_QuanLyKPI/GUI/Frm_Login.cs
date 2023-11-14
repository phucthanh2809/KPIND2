
using BusinessCommon;
using DuAn_QuanLyKPI.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        public static string a;
        public static string MaNV;
        public static string MaPhongKhoa;
        public static string MaChucDanh;
        Timer timer = new Timer();
        public Frm_Login()
        {
            InitializeComponent();
            InitializeTimer();
        }
        #region DateTime
            private void InitializeTimer()
            {
            // Lấy ngày và giờ hiện tại
            DateTime now = DateTime.Now;
            // Hiển thị ngày và giờ lên Label
            lbDateTime.Text = now.ToString();
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
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string tentk = txtdangnhap.Text;
            string mk = txtPassword.Text;


            var db = DataProvider.Ins.DB;
            var nguoidung = db.NguoiDung.Where(x => x.TenTaiKhoan == tentk && x.MatKhau == mk).FirstOrDefault();
            if (nguoidung != null)
            {
                //clear();


                DataUserCurrent.Instance.IDUserCurrent = nguoidung.MaNV;
                DataUserCurrent.Instance.Permission = nguoidung.Quyen.First().MaQuyen;


                if (DataUserCurrent.Instance.Permission != "NV")
                {
                    ev.QFrmThongBao("Đăng nhập thành công");
                    Frm_Chinh_GUI f = new Frm_Chinh_GUI();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    

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
            if(txtPassword.PasswordChar == '*')
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
    }
}
