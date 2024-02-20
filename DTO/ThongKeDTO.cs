using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_mem_quan_ly_bien_ban.DTO
{
    internal class ThongKeDTO
    {
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public int MaDonHang { get; set; }
        public decimal TongTien { get; set; }
        public string TenDichVu { get; set; }
        public string TenChiNhanh { get; set; }
        public string TenKhachHang { get; set; }
    }
}
