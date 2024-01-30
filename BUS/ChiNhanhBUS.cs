using Phan_mem_quan_ly_bien_ban.DAO;
using Phan_mem_quan_ly_bien_ban.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_mem_quan_ly_bien_ban.BUS
{
    internal class ChiNhanhBUS
    {
        ChiNhanhDAO chiNhanhDAO;
        public ChiNhanhBUS() {
            chiNhanhDAO = new ChiNhanhDAO();
        }
        public List<ChiNhanhDTO> GetAllChiNhanh() {
            List<ChiNhanhDTO> chiNhanhs1 = new List<ChiNhanhDTO>();
            DataTable dataTable = chiNhanhDAO.GetAll();
            foreach (DataRow dr in dataTable.Rows)
            {
                ChiNhanhDTO cn = new ChiNhanhDTO();
                cn.maChiNhanh = int.Parse(dr["maChiNhanh"].ToString());
                cn.tenChiNhanh = dr["tenChiNhanh"].ToString();
                cn.diachi = dr["diaChi"].ToString();
                chiNhanhs1.Add(cn);
            }


            return chiNhanhs1;
        
        }
    }
}
