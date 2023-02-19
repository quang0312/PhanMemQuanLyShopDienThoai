using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Model
{ 
    public class HoaDonInfo
    {
        public int ID { get; set; }
        public string MaKH { get; set; }
        public int KhachHangID { get; set; }
        public int NhanVienID { get; set; }
        public string MaNV { get; set; }
        public DateTime? NgayLap { get; set; }
        public double? TongTien { get; set; }
    }
}
