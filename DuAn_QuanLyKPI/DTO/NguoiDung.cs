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
    
    public partial class NguoiDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NguoiDung()
        {
            this.KPI_CaNhan = new HashSet<KPI_CaNhan>();
            this.ThongBao = new HashSet<ThongBao>();
        }
    
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public byte[] HinhAnhNV { get; set; }
        public string SDT { get; set; }
        public string Gmail { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string MaPhongKhoa { get; set; }
        public string MaChucDanh { get; set; }
        public string MaQuyen { get; set; }
        public Nullable<bool> TruongPK { get; set; }
    
        public virtual ChucDanh ChucDanh { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KPI_CaNhan> KPI_CaNhan { get; set; }
        public virtual PhongKhoa PhongKhoa { get; set; }
        public virtual Quyen Quyen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongBao> ThongBao { get; set; }
    }
}
