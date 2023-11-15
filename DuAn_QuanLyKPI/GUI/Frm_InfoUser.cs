using BusinessCommon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DuAn_QuanLyKPI.GUI
{
    public partial class Frm_InfoUser : DevExpress.XtraEditors.XtraForm
    {
    //Tạo biến
        private static string MaNV;
        private static string TenNV;
        private static string Email;
        private static string SDT;
        private static string TenTK;
        private static string TenPK;
        private static string ChucDanh;
        private static string PhanQuyen;
        private static byte[] HinhAnh;

        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        public Frm_InfoUser()
        {
            InitializeComponent();
            LoadData();    
        }
        private Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        //Nhận dữ liệu 
        private void GetData()
        {
            MaNV = Frm_Login.MaNV;
            TenNV = Frm_Login.TenNV;
            Email = Frm_Login.Email;
            SDT = Frm_Login.SDT;
            TenTK = Frm_Login.TK;
            TenPK = Frm_Login.TenPhongKhoa;
            ChucDanh = Frm_Login.TenChucDanh;
            PhanQuyen = Frm_Login.PhanQuyen;
            HinhAnh = Frm_Login.HinhAnh;
        }

        //Load dữ liệu 
        private void LoadData()
        {
            GetData();
            txtMaNV.Text = MaNV;
            txtHoten.Text = TenNV;
            txtEmail.Text = Email;
            txtSDT.Text = SDT;
            txtPhongKhoa.Text = TenPK;
            txtChucDanh.Text = ChucDanh;

            try
            {
                pbUser.Image = Base64ToImage((byte[])HinhAnh);
            }
            catch (Exception)
            {
                pbUser.Image = DuAn_QuanLyKPI.Properties.Resources.noimage;
            }
        }
    }
}