//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnPhanMem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            this.HOADON_DV = new HashSet<HOADON_DV>();
            this.HOADON_SP = new HashSet<HOADON_SP>();
        }
    
        public string IDHOADON { get; set; }
        public int TONGGIA { get; set; }
        public int SOLUONG { get; set; }
        public System.DateTime NGAY { get; set; }
        public System.TimeSpan GIO { get; set; }
        public string MAKM { get; set; }
        public string TENKH { get; set; }
        public string TENNV { get; set; }
        public string SODT { get; set; }
        public string IDNHANVIEN { get; set; }
        public string IDKHACHHANG { get; set; }
    
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual KHUYENMAI KHUYENMAI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON_DV> HOADON_DV { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON_SP> HOADON_SP { get; set; }
    }
}
