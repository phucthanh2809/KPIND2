
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
        public string a;
        public Frm_Login()
        {
            InitializeComponent();

        }
        void clear()
        {
            txtmatkhau.Text = "";
            txtdangnhap.Text = "";


        }
        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            
        }

        private void peClose_EditValueChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdangnhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void btndangnhap_Click_1(object sender, EventArgs e)
        {
            string tentk = txtdangnhap.Text;
            string mk = txtmatkhau.Text;


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
                    f.Show();
                    this.Hide();

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

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbAn_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbAn.Checked)
            {
                txtmatkhau.PasswordChar = (char)0;

            }
            else
            {
                txtmatkhau.PasswordChar = '*';

            }
        }
    }
}
