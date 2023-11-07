using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraVerticalGrid;
using DuAn_QuanLyKPI.Constants;
using DuAn_QuanLyKPI.DTO;
using BusinessCommon;


namespace DuAn_QuanLyKPI.GUI
{
    public partial class FrmChiTietQuanLyNganHang : Form
    {
        private string makpi;
        public FrmChiTietQuanLyNganHang(string makpi)
        {
            InitializeComponent();
            this.makpi = makpi;
            LoadData();
        }

        private void LoadData ()
        {
            var db = DataProvider.Ins.DB;

            int ma = Convert.ToInt32(makpi);
            var k = db.KPI.Where(x => x.MaKPI == ma).First();
            txtNoiDung.Text = k.NoiDung.ToString();
            txtChiTieu.Text = k.ChiTieu.ToString();
            txtDonViTinh.Text = k.DonViTinh.ToString();
            txtPhuongPhapDo.Text = k.PhuongPhapDo.ToString();
            if (k.CongViecCaNhan)
                chkCongViecCaNhan.Checked = true;
            else
                chkCongViecCaNhan.Checked = false;
        }
        
        private void btnBoqua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCap_Click(object sender, EventArgs e)
        {
            var db = DataProvider.Ins.DB;
        }
    }
}
