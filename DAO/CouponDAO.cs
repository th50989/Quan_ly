using Phan_mem_quan_ly_bien_ban.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Phan_mem_quan_ly_bien_ban.DTO;

namespace Phan_mem_quan_ly_bien_ban.DAO
{
    
    internal class CouponDAO
    {
        DataProvider dataProvider;

        public CouponDAO()
        {

            dataProvider = new DataProvider();
        }
        public CouponDTO CheckCoupon(int id)
        {
            CouponDTO coupon = new CouponDTO();

            string query = "select * from KhuyenMai where maKhuyenMai = @makhuyenmai";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@makhuyenmai", SqlDbType.Int)
            {
                Value = id
            };


            coupon = dataProvider.ExecuteCheckKhuyenMaiQuery(query, sqlParameters);
           
            return coupon;
        }
    }
}
