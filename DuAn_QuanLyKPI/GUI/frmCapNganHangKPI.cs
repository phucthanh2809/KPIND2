using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.XtraCharts;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DuAn_QuanLyKPI.Constants;
using DuAn_QuanLyKPI.DTO;


namespace DuAn_QuanLyKPI.GUI
{
    public partial class frmCapNganHangKPI : Form
    {
        public frmCapNganHangKPI()
        {
            InitializeComponent();
            LoadCbo();
            LoadData();
        }

        private void LoadData()
        {
            var db = DataProvider.Ins.DB;
            dgvkpidc.DataSource = db.KPI.ToList();
            //HienThiCotDaCo();
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
        private void CapDuLieu()
        {
            var db = DataProvider.Ins.DB;
            //var list = db.KPI.Where(x => x.NganHangKPI.Any(b => b.MaPK == cboKhoaPhong.SelectedValue.ToString())).ToList();

            var find = db.NganHangKPI.Where(x => x.MaChucDanh == cboChucDanh.SelectedValue && x.MaPK == cboKhoaPhong.SelectedValue).FirstOrDefault();
            if (find != null)
            {
                //tìm thấy
                //remove chi tiết cũ, thêm chi tiết mới vào
                //db.NganHangKPI.Remove(find);
                //db.NganHangKPI.Add(find);
                //find.MaNganHangKPI.ToList();
                GridView gridView1 = this.dgvkpidc.MainView as GridView;
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    DataRow dr = gridView1.GetDataRow(i);
                    if (Convert.ToInt32(dr["MaKPI"]) == DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                    {
                        gridView1.SelectRow(i);
                        break;
                    }
                }
            }
            else 
            {
                //tìm không thấy
                //tạo mới xong add
                find.MaNganHangKPI = null;
                //db.NganHangKPI.Add(find);
                find.MaNganHangKPI.ToList();
            }
        }
        private void HienThiCotDaCo()
        {
            GridView activeView = this.dgvkpidc.MainView as GridView;
            int rowHandle = activeView.LocateByValue("MaKPI", 1123);
            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                gridView1.SelectRow(rowHandle);
            }
            
            //List<string> listds = new List<string> ();
            //for (int rowHandle = 0; rowHandle < gridView1.RowCount; rowHandle++)
            //{

            //    //string cv = gridView1.GetRowCellValue(rowHandle, "MaKPI").ToString(); 

            //    //if (listds.Contains(cv))
            //    //{
            //    //    gridView1.SelectRow(rowHandle);
            //    //}
            //}

        }
        
        private void btnCap_Click(object sender, EventArgs e)
        {
            //CapDuLieu();
            //var selectCheckboxes = 




        }
        //private void CapDuLieu1()
        //{
        //    var db = DataProvider.Ins.DB;

        //    // Try to find existing record for the selected department and position.
        //   // var find = db.NganHangKPI.Where(x => x.MaChucDanh == cboChucDanh.SelectedValue && x.MaPK == cboKhoaPhong.SelectedValue).FirstOrDefault();

        //    // If existing record found, remove it.
        //    //if (find != null)
        //    //{
        //    //    db.NganHangKPI.Remove(find);
        //    //}

        //    // Create new record and add it to the database.
        //    var newRecord = new NganHangKPI
        //    {
        //        MaNganHangKPI = "",

        //    };

        //    db.NganHangKPI.Add(newRecord);

        //    // Try to save changes to the database.
        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle error if saving changes fails.
        //    } 
        //}
    
    }
}
