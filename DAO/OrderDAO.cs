using Phan_mem_quan_ly_bien_ban.DATA;
using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
