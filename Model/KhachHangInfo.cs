using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Model
{
    public class KhachHangInfo
    {
        public int ID { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public DateTime? Tuoi { get; set; }
        public string GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
    }
}
