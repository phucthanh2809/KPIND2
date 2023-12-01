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
//using DevExpress.XtraVerticalGrid;
using DuAn_QuanLyKPI.Constants;
using DuAn_QuanLyKPI.DTO;
using BusinessCommon;


namespace DuAn_QuanLyKPI.GUI
{
    public partial class Frm_XemChiTietQuanLyNganHangKPI : DevExpress.XtraEditors.XtraForm
    {
        
        public Frm_XemChiTietQuanLyNganHangKPI()
        {
            InitializeComponent();        
        }
        public void SetData(string noidung, string donvitinh, string phuongphapdo, bool congvieccanhan, string chitieu)
        {
            txtNoiDung.Text = noidung;
            txtDonViTinh.Text = donvitinh;
            txtPhuongPhapDo.Text = phuongphapdo;
            chkCongViecCaNhan.Checked = congvieccanhan;
            txtChiTieu.Text = chitieu;
        }

    }
}