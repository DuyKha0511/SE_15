//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SE_15_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoatDong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoatDong()
        {
            this.DangKies = new HashSet<DangKy>();
        }
    
        public string IDHoatDong { get; set; }
        public Nullable<int> IDLoaiHoatDong { get; set; }
        public Nullable<int> IDKhoa { get; set; }
        public string TenHoatDong { get; set; }
        public Nullable<int> SoLuongThamGia { get; set; }
        public Nullable<System.DateTime> ThoiGian { get; set; }
        public string DiaDiem { get; set; }
        public Nullable<int> ChiPhi { get; set; }
        public string MoTa { get; set; }
        public string YeuCau { get; set; }
        public Nullable<int> DiemHD { get; set; }
        public string TrangThaiPheDuyet { get; set; }
        public string TrangThaiDangKy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKy> DangKies { get; set; }
        public virtual Khoa Khoa { get; set; }
        public virtual LoaiHoatDong LoaiHoatDong { get; set; }
    }
}
