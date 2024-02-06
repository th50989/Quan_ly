using Phan_mem_quan_ly_bien_ban.DATA;
using Phan_mem_quan_ly_bien_ban.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_mem_quan_ly_bien_ban.DAO
{
    internal class CustomerDAO
    {
        DataProvider dataProvider;
        public CustomerDAO()
        {
            dataProvider = new DataProvider();
        }
        public void updateOne(int id, string hoten, string sdt)
        {
            string query = "update KhachHang set tenKhachHang = @hoten,sdt = @sdt where maKhachHang = @maKH ;";

            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@hoten", SqlDbType.NVarChar)
            {
                Value = hoten
            };
            sqlParameters[1] = new SqlParameter("@sdt", SqlDbType.VarChar)
            {
                Value = sdt
            };
            
            sqlParameters[2] = new SqlParameter("@maKH", SqlDbType.Int)
            {
                Value = id
            };
            dataProvider.ExecuteQuery(query, sqlParameters);

        }
        public void deleteOne(int id)
        {
            string query = "delete from KhachHang where maKhachHang = @maKH";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@maKH", SqlDbType.Int)
            {
                Value = id
            };
            dataProvider.ExecuteQuery(query, sqlParameters);
        }

        public void addNew(string ten, string sdt)
        {
            string query = "insert into KhachHang (tenKhachHang,sdt)" +
                " values(@ten,@sdt);";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@ten", SqlDbType.VarChar)
            {
                Value = ten
            };
            sqlParameters[1] = new SqlParameter("@sdt", SqlDbType.VarChar)
            {
                Value = sdt
            };
            
            Console.WriteLine(query.ToString());
            dataProvider.ExecuteQuery(query, sqlParameters);
        }
        
       
        public DataTable getCustomerByPhone(string sdt)
        {
            string query = "select * from KhachHang where sdt = @sdt";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@sdt", SqlDbType.VarChar)
            {
                Value = sdt
            };
            return dataProvider.ExecuteSelectQuery(query, sqlParameters);
        }

        public DataTable getAll()
        {
            string query = "select * from KhachHang";
            return dataProvider.ExecuteSelectAllQuery(query);
        }
    }
}
