using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuAn_QuanLyKPI.Constants;
using DuAn_QuanLyKPI.DTO;

namespace DuAn_QuanLyKPI.GUI
{
    public partial class FrmXemAllMucTieu : Form
    {
        public FrmXemAllMucTieu()
        {
            InitializeComponent();
            LoadData();
            LoadCbo();
        }
        private void LoadData()
        {
            var db = DataProvider.Ins.DB;
            dgvXemAllMucTieu.DataSource = db.KPI.ToList();
        }
        private void cboTìmKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = DataProvider.Ins.DB;
            switch (cboTìmKiem.SelectedIndex)
            {
                case 0:
                    var list1 = db.KPI.ToList();
                    dgvXemAllMucTieu.DataSource = list1;
                    break;
                case 1:
                    var list2 = db.KPI.Where(x => x.NganHangKPI.Any(b => b.MaPK == cboKhoaPhong.SelectedValue.ToString())).ToList();
                    dgvXemAllMucTieu.DataSource = list2;
                    break;
                case 2:
                    var list3 = db.KPI.Where(x => x.NganHangKPI.Any(b => b.MaChucDanh == cboChucDanh.SelectedValue.ToString())).ToList();
                    dgvXemAllMucTieu.DataSource = list3;
                    break;
                case 3:
                    var list4 = db.KPI.Where(x => x.NganHangKPI.Any(b => b.MaChucDanh == cboChucDanh.SelectedValue.ToString() && b.MaPK == cboKhoaPhong.SelectedValue.ToString())).ToList();
                    dgvXemAllMucTieu.DataSource = list4;
                    break;
            }
        }
        private void LoadCbo()
        {
            var db = DataProvider.Ins.DB;
            //Phòng Khoa
            var list = db.PhongKhoa.ToList();
            cboKhoaPhong.DataSource = list;
            cboKhoaPhong.ValueMember = "MaPK";
            cboKhoaPhong.DisplayMember = "TenPK";
            //Chức Danh
            var list2 = db.ChucDanh.ToList();
            cboChucDanh.DataSource = list2;
            cboChucDanh.ValueMember = "MaChucDanh";
            cboChucDanh.DisplayMember = "TenChucDanh";
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
