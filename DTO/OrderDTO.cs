using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_mem_quan_ly_bien_ban.DTO
{
    internal class OrderDTO
    {
        public int maDonHang { get; set; }
        public string thoiGianTaoDon { get; set;}
        public float? tongTien { get;set; }
        public int maNhanVien { get; set; } 
        public int? maKhuyenMai { get; set; }
        public int maKhachHang { get; set; }

        public string tenKhachHang { get; set; }

        public string tenNhanVien { get;set; }

     


    }

}
