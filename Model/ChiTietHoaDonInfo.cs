using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Model
{
    public class ChiTietHoaDonInfo
    {
        
        public int ID { get; set; }      
        public string MaHoaDon { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
       // public string BillCode { get; set; }
        public int? SoLuong { get; set; }
        public double? UnitPrice { get; set; }
        public double? Discount { get; set; }
        public double? IntoMoney { get; set; }
    }
}
