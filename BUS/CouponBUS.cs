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
    internal class CouponBUS
    {
        CouponDAO CouponDAO;
        public CouponBUS() {
            CouponDAO = new CouponDAO();
        }
        public CouponDTO CheckCoupon (string id)
        {
            CouponDTO coupon = new CouponDTO();
            if(id == "")
            {
                return null;
            }
            else
            {
                int maKhuyenMai = int.Parse(id);
                coupon = CouponDAO.CheckCoupon(maKhuyenMai);
                return coupon;
            }
           
        }
        public List<CouponDTO> getAll()
        {
            List<CouponDTO> couponBuses = new List<CouponDTO>();
            DataTable dataTable = CouponDAO.getAll();
            foreach (DataRow dr in dataTable.Rows)
            {
                CouponDTO cmp = new CouponDTO();
                cmp.maKhuyenMai = int.Parse(dr["maKhuyenMai"].ToString());
                cmp.tenKhuyenMai = dr["tenKhuyenMai"].ToString();
                cmp.desCription = dr["description"].ToString();
                cmp.status =1;
              
                couponBuses.Add(cmp);
            }

         

            return couponBuses;
        }
    }
}
