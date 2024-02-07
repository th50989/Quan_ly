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
    internal class ServiceDAO
    {
        DataProvider dataProvider;
        public ServiceDAO() { 
        
            dataProvider = new DataProvider();
        }

        public DataTable getListServicesByOrderId(int orderId)
        {
            string query = "select dv.maDichVu, dv.tenDichVu, dv.giaDichVu, dv.giaiThich from DonHang dh " +
                "join DonHang_DichVu dhdv on dh.maDonHang = dhdv.maDonHang " +
                "join DichVu dv on dhdv.maDichVu = dv.maDichVu " +
                "where dh.maDonHang =  @orderId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@orderId", SqlDbType.Int)
            {
                Value = orderId
            };
            return dataProvider.ExecuteSelectQuery(query, sqlParameters);
        }

        public DataTable getServiceById(int id)
        {
            string query = "select * from DichVu where maDichVu = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int) {
                Value = id
            };
            return dataProvider.ExecuteSelectQuery(query, sqlParameters); 
        }

        public DataTable getAll()
        {
            string query = "select * from DichVu";
            return dataProvider.ExecuteSelectAllQuery(query);
        }
    }
}
