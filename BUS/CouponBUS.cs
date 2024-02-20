using Phan_mem_quan_ly_bien_ban.DAO;
using Phan_mem_quan_ly_bien_ban.DTO;
using System;
using System.Collections.Generic;
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
    }
}
