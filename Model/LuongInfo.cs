using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Model
{
    public class LuongInfo
    {
        public int ID { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public int? HoursWork { get; set; }
        public double? Bonus { get; set; }
        public double? TotalLuong { get; set; }
    }
}
