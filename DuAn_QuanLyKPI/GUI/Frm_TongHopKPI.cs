using DevExpress.XtraEditors;
using DuAn_QuanLyKPI.Constants;
using DuAn_QuanLyKPI.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn_QuanLyKPI.GUI
{
    public partial class Frm_TongHopKPI : DevExpress.XtraEditors.XtraForm, INotifyPropertyChanged
    {

        public Frm_TongHopKPI()
        {
            InitializeComponent();
            loadData();
            this.gridControl1.DataSource = ListItems;
            lblWaiting.Text = Waitings.ToString();
            lblAccept.Text = Accepts.ToString();
            lblRefuse.Text = Refuses.ToString();
            loadPie();
        }
        void loadPie()
        {
            List<DataPoint> listpie = new List<DataPoint>();
            listpie.Add(new DataPoint() { Argument = "Chờ duyệt", Value = Waitings });
            listpie.Add(new DataPoint() { Argument = "Đã duyệt", Value = Accepts });
            listpie.Add(new DataPoint() { Argument = "Trả về", Value = Refuses });
            chartControl1.Series[0].DataSource = listpie;
            chartControl1.Series[0].ArgumentDataMember = "Argument";
            chartControl1.Series[0].ValueDataMembers.AddRange(new string[] { "Value" });
        }
        void loadData()
        {
            var listTH = new ObservableCollection<ListKPI_DTO>();
            var db = DataProvider.Ins.DB;
            var listKP = db.KPI_KhoaPhong.OrderBy(x => x.TrangThai).ToList();
            var listCN = db.KPI_CaNhan.OrderBy(x => x.TrangThai).ToList();
            //if (listKP.Count > 0)
            //{
            //    foreach (var item in listKP )
            //    {
            //        ListKPI_DTO dto = new ListKPI_DTO();
            //        dto.MaPhieu = item.MaPhieuKPI;
            //        dto.LoaiPhieu = "KPI Khoa Phòng";
            //        dto.NguonGui = item.PhongKhoa.TenPK;
            //        dto.TieuDe = item.TieuDe;
            //        dto.NoiDung = item.NoiDung;
            //        switch (item.Quy)
            //        {
            //            case 0: dto.Quy = ""; break;
            //            case 1: dto.Quy = "I"; break;
            //            case 2: dto.Quy = "II"; break;
            //            case 3: dto.Quy = "III"; break;
            //            case 4: dto.Quy = "IV"; break;
            //        }
            //        dto.Nam = (int)item.Nam;
            //        dto.NgayGui = (DateTime)item.NgayTao;
            //        dto.MauPhieu = item.MauPhieu;
            //        switch (item.TrangThai)
            //        {
            //            case 0: dto.TrangThai = "Chờ duyệt"; Waitings++; break;
            //            case 1: dto.TrangThai = "Đã duyệt"; Accepts++; break;
            //            case 2: dto.TrangThai = "Trả về"; Refuses++; break;
            //        }
            //        dto.LanhDao = (bool)item.LanhDao;
            //        listTH.Add(dto);
            //    }
            //}

            //if (listCN.Count > 0)
            //{
            //    foreach (var item in listCN)
            //    {
            //        ListKPI_DTO dto = new ListKPI_DTO();
            //        dto.MaPhieu = item.MaPhieuKPI;
            //        dto.LoaiPhieu = "KPI cá nhân";
            //        dto.NguonGui = item.NguoiDung.TenNV;
            //        dto.TieuDe = item.TieuDe;
            //        dto.NoiDung = item.NoiDung;
            //        switch (item.Quy)
            //        {
            //            case 0: dto.Quy = ""; break;
            //            case 1: dto.Quy = "I"; break;
            //            case 2: dto.Quy = "II"; break;
            //            case 3: dto.Quy = "III"; break;
            //            case 4: dto.Quy = "IV"; break;
            //        }
            //        dto.Nam = (int)item.Nam;
            //        dto.NgayGui = (DateTime)item.NgayTao;
            //        dto.MauPhieu = item.MauPhieu;
            //        switch (item.TrangThai)
            //        {
            //            case 0: dto.TrangThai = "Chờ duyệt"; Waitings++; break;
            //            case 1: dto.TrangThai = "Đã duyệt"; Accepts++; break;
            //            case 2: dto.TrangThai = "Trả về"; Refuses++; break;
            //            default: dto.TrangThai = "Chờ duyệt"; Waitings++; break;
            //        }
            //        listTH.Add(dto);
            //    }
            //}
            ListItems.Clear();
            ListItems = listTH;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private ObservableCollection<ListKPI_DTO> listItems = new ObservableCollection<ListKPI_DTO>();
        private int waitings;
        private int accepts;
        private int refuses;

        public ObservableCollection<ListKPI_DTO> ListItems { get => listItems; set { listItems = value; OnPropertyChanged(nameof(ListItems)); } }

        public int Waitings { get => waitings; set { waitings = value; OnPropertyChanged(nameof(Waitings)); } }
        public int Accepts { get => accepts; set { accepts = value; OnPropertyChanged(nameof(Accepts)); } }
        public int Refuses { get => refuses; set { refuses = value; OnPropertyChanged(nameof(Refuses)); } }
    }
}