using DevExpress.XtraEditors;
using DuAn_QuanLyKPI.Constants;
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
    public partial class Frm_HoanThanhKhoaPhong : DevExpress.XtraEditors.XtraForm
    {
        public Frm_HoanThanhKhoaPhong()
        {
            InitializeComponent();
            LoadGrid();
        }
        private void LoadGrid()
        {
            var db = DataProvider.Ins.DB;
            var liskkp = from kp in db.KPI_KhoaPhong
                        join cttcppk in db.ChiTietTieuChiPhieuPhongKhoa on kp.MaPhieuKPI equals cttcppk.MaPhieuKPI
                        join ctkpikp in db.ChiTietKPIKhoaPhong on cttcppk.MaChiTietPK equals ctkpikp.ChitietID
                        select new
                        {
                            KhoaPhong = kp,
                            ChiTietKPIKhoaPhong = ctkpikp,
                            ChiTietTieuChiPhieuPhongKhoa = cttcppk
                        };

            gcBieuMau.DataSource = liskkp.ToList();
        }
    }
}