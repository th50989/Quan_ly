using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_mem_quan_ly_bien_ban.DTO
{
    internal class EmployeeDTO
    {
        public int maNhanVien { get; set; }
        public string tenNhanVien { get; set; }
        public string taiKhoan { get; set; }
        public string matKhau { get; set; }
        public bool isAdmin { get; set; }
        public int maChiNhanh { get; set; }

    }
}
