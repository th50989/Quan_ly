using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_mem_quan_ly_bien_ban.DTO
{
    internal class CouponDTO
    {
        public CouponDTO() { }
        public int maKhuyenMai { get; set; }
        public string tenKhuyenMai { get; set; }
        public string desCription { get; set; }
        public byte status { get; set; }    
    }
}
