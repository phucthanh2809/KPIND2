using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn_QuanLyKPI.DTO
{
    public class ListKPI_DTO : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ListKPI_DTO() { }
        private String _MaPhieu = "";
        private String _NguonGuiCode = "";
        private String _NguonGui = "";
        private String _TieuDe = "";
        private String _NoiDung = "";
        private DateTime _NgayGui;
        private String _Quy = "";
        private int _Nam;
        private String _LoaiPhieu ="";
        private String _MauPhieu = "";
        private String _TrangThai = "";
        private bool _LanhDao = false;

        public string MaPhieu { get => _MaPhieu; set { _MaPhieu = value; OnPropertyChanged(nameof(MaPhieu)); } }
        public string NguonGuiCode { get => _NguonGuiCode; set { _NguonGuiCode = value; OnPropertyChanged(nameof(NguonGuiCode)); } }
        public string NguonGui { get => _NguonGui; set { _NguonGui = value; OnPropertyChanged(nameof(NguonGui)); } }
        public string TieuDe { get => _TieuDe; set { _TieuDe = value; OnPropertyChanged(nameof(TieuDe)); } }
        public string NoiDung { get => _NoiDung; set { _NoiDung = value; OnPropertyChanged(nameof(NoiDung)); } }
        public DateTime NgayGui { get => _NgayGui; set { _NgayGui = value; OnPropertyChanged(nameof(NgayGui)); } }
        public string Quy { get => _Quy; set { _Quy = value; OnPropertyChanged(nameof(Quy)); } }
        public int Nam { get => _Nam; set { _Nam = value; OnPropertyChanged(nameof(Nam)); } }
        public string LoaiPhieu { get => _LoaiPhieu; set { _LoaiPhieu = value; OnPropertyChanged(nameof(LoaiPhieu)); } }
        public string MauPhieu { get => _MauPhieu; set { _MauPhieu = value; OnPropertyChanged(nameof(MauPhieu)); } }
        public string TrangThai { get => _TrangThai; set { _TrangThai = value; OnPropertyChanged(nameof(MauPhieu)); } }

        public bool LanhDao { get => _LanhDao; set { _LanhDao = value; OnPropertyChanged(nameof(MauPhieu)); } }
    }
}
