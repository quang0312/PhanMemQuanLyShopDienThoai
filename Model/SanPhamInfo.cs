using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Model
{
    public class SanPhamInfo
    { 
        public int ID { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string LoaiSP { get; set; }
        public string NhaSanXuat { get; set; }
        public int? SoLuong { get; set; }
        public string MauSac { get; set; }
        public double? Gia { get; set; }
    }
}
