//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DuAn_QuanLyKPI.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class KPI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KPI()
        {
            this.ChiTietKPIBenhVien = new HashSet<ChiTietKPIBenhVien>();
            this.ChiTietKPICaNhan = new HashSet<ChiTietKPICaNhan>();
            this.ChiTietKPIKhoaPhong = new HashSet<ChiTietKPIKhoaPhong>();
            this.ChiTietKPITruongKhoaPhong = new HashSet<ChiTietKPITruongKhoaPhong>();
            this.ChiTietTieuChiMucTieuBV = new HashSet<ChiTietTieuChiMucTieuBV>();
            this.ChiTietTieuChiMucTieuKhoaPhong = new HashSet<ChiTietTieuChiMucTieuKhoaPhong>();
            this.KPI_DangKiThem = new HashSet<KPI_DangKiThem>();
            this.NganHangKPI = new HashSet<NganHangKPI>();
        }
    
        public int MaKPI { get; set; }
        public string NoiDung { get; set; }
        public string DonViTinh { get; set; }
        public string PhuongPhapDo { get; set; }
        public bool CongViecCaNhan { get; set; }
        public string ChiTieu { get; set; }
        public string TieuChiID { get; set; }
        public Nullable<bool> KPIDKT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietKPIBenhVien> ChiTietKPIBenhVien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietKPICaNhan> ChiTietKPICaNhan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietKPIKhoaPhong> ChiTietKPIKhoaPhong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietKPITruongKhoaPhong> ChiTietKPITruongKhoaPhong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietTieuChiMucTieuBV> ChiTietTieuChiMucTieuBV { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietTieuChiMucTieuKhoaPhong> ChiTietTieuChiMucTieuKhoaPhong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KPI_DangKiThem> KPI_DangKiThem { get; set; }
        public virtual NhomTieuChi NhomTieuChi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NganHangKPI> NganHangKPI { get; set; }
    }
}
