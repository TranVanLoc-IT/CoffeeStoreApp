//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoffeeStoreApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            this.CALAMVIECs = new HashSet<CALAMVIEC>();
            this.HOADONs = new HashSet<HOADON>();
        }
    
        public string manv { get; set; }
        public string tennv { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }
        public string diachi { get; set; }
        public string chucvu { get; set; }
        public Nullable<System.DateTime> ngayvaolam { get; set; }
        public string matkhau { get; set; }
        public string maquanly { get; set; }
        public string phanquyen { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CALAMVIEC> CALAMVIECs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
        public virtual NHANVIEN NHANVIEN1 { get; set; }
        public virtual NHANVIEN NHANVIEN2 { get; set; }
    }
}