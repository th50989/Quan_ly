using Phan_mem_quan_ly_bien_ban.DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_mem_quan_ly_bien_ban.DAO
{
    internal class OrderDAO
    {

        DataProvider dataProvider;
        public OrderDAO()
        {
            dataProvider = new DataProvider();
        }
        public DataTable getAll()
        {
            string query = "select * from ChiTietDonHang";
            return dataProvider.ExecuteSelectAllQuery(query);
        }

        public DataTable getOrderByCustomerId(int id) {
            string query = "select * from ChiTietDonHang where maKhachHang = @customerId";
            SqlParameter[] sqlParameter = new SqlParameter[1];
            sqlParameter[0] = new SqlParameter("@customerId", SqlDbType.Int) { 
                Value = id
            };
            return dataProvider.ExecuteSelectQuery(query, sqlParameter);
        }
    }
}
