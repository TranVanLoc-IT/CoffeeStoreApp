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
    
    public partial class LOAIHANGHOA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIHANGHOA()
        {
            this.HANGHOAs = new HashSet<HANGHOA>();
        }
    
        public string maloaihh { get; set; }
        public string tenloai { get; set; }
        public string mota { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HANGHOA> HANGHOAs { get; set; }
    }
}
