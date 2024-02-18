using Phan_mem_quan_ly_bien_ban.DATA;
using System;
using System.Collections;
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
        public DataTable getAll(int id)
        {
            string query = "select * from ChiTietDonHang where machinhanh = @machinhanh";
            SqlParameter[] sqlParameter = new SqlParameter[1];
            sqlParameter[0] = new SqlParameter("@machinhanh", SqlDbType.Int)
            {
                Value = id
            };
            return dataProvider.ExecuteSelectAllOrderQuery(query, sqlParameter);
        }

        public DataTable getOrderByCustomerId(int id) {
            string query = "select * from ChiTietDonHang where maKhachHang = @customerId";
            SqlParameter[] sqlParameter = new SqlParameter[1];
            sqlParameter[0] = new SqlParameter("@customerId", SqlDbType.Int) { 
                Value = id
            };
            return dataProvider.ExecuteSelectQuery(query, sqlParameter);
        }
        public void addNew(DateTime thoiGianTaoDon, float tongTien, int maNhanVien, int? maKhuyenMai, int maKhachHang, List<string> dichvu)
        {
            string query = "insert into DonHang(thoiGianTaoDon,tongTien,maKhachHang,maNhanVien,maKhuyenMai)" +
                " OUTPUT INSERTED.madonhang " +
                "values (@thoigiantaodon,@tongtien,@maKhachHang,@maNhanVien,@maKhuyenMai)";
            SqlParameter[] sqlParameter = new SqlParameter[5];
            sqlParameter[0] = new SqlParameter("@thoigiantaodon", SqlDbType.VarChar)
            {
                Value = thoiGianTaoDon.ToString()
            };
            sqlParameter[1] = new SqlParameter("@tongtien", SqlDbType.Float)
            {
                Value = tongTien
            };
            sqlParameter[2] = new SqlParameter("@maKhachHang", SqlDbType.Int)
            {
                Value = maKhachHang
            };
            sqlParameter[3] = new SqlParameter("@maNhanVien", SqlDbType.Int)
            {
                Value = maNhanVien
            };
            if (maKhuyenMai == null)
            {
                sqlParameter[4] = new SqlParameter("@maKhuyenMai", SqlDbType.Int)
                {

                    Value = DBNull.Value
                };
            }
            else {
                sqlParameter[4] = new SqlParameter("@maKhuyenMai", SqlDbType.Int)
                {

                    Value = maKhuyenMai
                };
            }
            
          
           

            //dataProvider.ExecuteQuery(query, sqlParameter);
            //do something to get the exact madonhang from sql
            Console.WriteLine(query);
            int madonhang = Convert.ToInt32(dataProvider.ExecuteScalar(query, sqlParameter));
            Console.WriteLine("madonhang: "+madonhang.ToString());
            //
            foreach (string moidichvu in dichvu)
            {
                Console.WriteLine(moidichvu);
                query = "insert into DonHang_DichVu(maDonHang,maDichVu)" +
                "values (@madonhang,(select maDichVu from DichVu where tenDichVu like @dichvu))";
               sqlParameter = new SqlParameter[2];
                sqlParameter[0] = new SqlParameter("@madonhang", SqlDbType.Int)
                {
                    Value = madonhang
                };
                sqlParameter[1] = new SqlParameter("@dichvu", SqlDbType.VarChar)
                {
                    Value = moidichvu
                };
                query = query.Replace("'@dichvu'", "@dichvu");
                Console.WriteLine(query);
                dataProvider.ExecuteQuery(query, sqlParameter);
            }
          
        }
        public void deleteOne(int id)
        {
            string query = "delete from donhang where maDonHang = @madonhang";
            SqlParameter[] sqlParameter = new SqlParameter[1];
            sqlParameter[0] = new SqlParameter("@madonhang", SqlDbType.Int)
            {
                Value = id
            };
            dataProvider.ExecuteQuery(query, sqlParameter); 
        }
    }
}
