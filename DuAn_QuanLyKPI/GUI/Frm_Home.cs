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


            


        }

        
       
       
        private void btnQuanLyNguoiDung_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Load(new Frm_User());
        }

        private void btnDoiMatKhau_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Change_Password c = new Frm_Change_Password();
            c.Show();
        }

        private void btnDangXuat_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            Frm_Login home = new Frm_Login();
            home.Show();
        }
    }
}
