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
    
    public partial class PhongKhoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhongKhoa()
        {
            this.ChiTietKPICaNhan = new HashSet<ChiTietKPICaNhan>();
            this.ChiTietKPIKhoaPhong = new HashSet<ChiTietKPIKhoaPhong>();
            this.ChucDanh = new HashSet<ChucDanh>();
            this.NganHangKPI = new HashSet<NganHangKPI>();
            this.NguoiDung = new HashSet<NguoiDung>();
            this.PhieuKPITongHop = new HashSet<PhieuKPITongHop>();
        }
    
        public string MaPK { get; set; }
        public string TenPK { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietKPICaNhan> ChiTietKPICaNhan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietKPIKhoaPhong> ChiTietKPIKhoaPhong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChucDanh> ChucDanh { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NganHangKPI> NganHangKPI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NguoiDung> NguoiDung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuKPITongHop> PhieuKPITongHop { get; set; }
    }
}
