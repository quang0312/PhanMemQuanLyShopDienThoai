//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopDienThoai
{
    using System;
    using System.Collections.Generic;
    
    public partial class Luong
    {
        public int ID { get; set; }
        public Nullable<int> NhanVienID { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public Nullable<int> Hours_work { get; set; }
        public Nullable<double> Bonus { get; set; }
        public Nullable<double> Total_luong { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
    }
}
