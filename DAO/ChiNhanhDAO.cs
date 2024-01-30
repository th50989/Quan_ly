using Phan_mem_quan_ly_bien_ban.DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_mem_quan_ly_bien_ban.DAO
{
    internal class ChiNhanhDAO
    {
        DataProvider dataProvider;
        public ChiNhanhDAO() { 
            dataProvider = new DataProvider();
        }

        public DataTable GetAll()
        {
            string query = string.Format("select * from chiNhanh");

            return dataProvider.ExecuteSelectAllQuery(query);
        }
    }
}
