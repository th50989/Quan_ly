using Phan_mem_quan_ly_bien_ban.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Phan_mem_quan_ly_bien_ban.DATA;

namespace Phan_mem_quan_ly_bien_ban.DAO
{
     class EmployeeDAO
    {
        DataProvider dataProvider;
        public EmployeeDAO() { 
            dataProvider = new DataProvider();
        }
        public void updateOne(int id, string hoten, string taikhoan,string matkhau,byte isadmin, int machinhanh)
        {
            string query = "update nhanvien set tennhanvien = @hoten,taikhoan = @taikhoan,matkhau = @matkhau,isadmin = @isadmin, machinhanh = @macn where manhanvien = @manv ;";

            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@hoten", SqlDbType.VarChar)
            {
                Value = hoten
            };
            sqlParameters[1] = new SqlParameter("@taikhoan", SqlDbType.VarChar)
            {
                Value = taikhoan
            };
            sqlParameters[2] = new SqlParameter("@matkhau", SqlDbType.VarChar)
            {
                Value = matkhau
            };
            sqlParameters[3] = new SqlParameter("@isadmin", SqlDbType.Bit)
            {
                Value = isadmin
            };
            sqlParameters[4] = new SqlParameter("@macn", SqlDbType.Int)
            {
                Value = machinhanh
            };
            sqlParameters[5] = new SqlParameter("@manv", SqlDbType.Int)
            {
                Value = id
            };
            dataProvider.ExecuteQuery(query, sqlParameters);

        }
        public void deleteOne(int id)
        {
            string query = "delete from nhanvien where manhanvien = @manhanvien";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@manhanvien", SqlDbType.Int)
            {
                Value = id
            };
            dataProvider.ExecuteQuery(query, sqlParameters);
        }

        public void addNew(string ten, string taiKhoan, string matkhau,byte isadmin, int machiNhanh)
        {
            string query = "insert into nhanvien (tennhanvien,taikhoan,matkhau,isadmin,machinhanh)" +
                " values(@ten,@taikhoan,@matkhau,@isadmin,@machinhanh);";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@ten", SqlDbType.VarChar)
            {
                Value = ten
            };
            sqlParameters[1] = new SqlParameter("@taikhoan", SqlDbType.VarChar)
            {
                Value = taiKhoan
            };
            sqlParameters[2] = new SqlParameter("@matkhau", SqlDbType.VarChar)
            {
                Value = matkhau
            };
            sqlParameters[3] = new SqlParameter("@isadmin", SqlDbType.Bit)
            {
                Value = isadmin
            };
            sqlParameters[4] = new SqlParameter("@machinhanh", SqlDbType.Int)
            {
                Value = machiNhanh
            };
            Console.WriteLine(query.ToString());
            dataProvider.ExecuteQuery(query, sqlParameters);
        }
        public EmployeeDTO DangNhap(string taikhoan, string matkhau)
        {
            EmployeeDTO emp = new EmployeeDTO();
            string query = "select * from NhanVien where taikhoan = @taikhoan and matkhau = @matkhau";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@taikhoan", SqlDbType.VarChar)
            {
                Value = taikhoan
             };
            sqlParameters[1] = new SqlParameter("@matkhau", SqlDbType.VarChar)
            {
                Value = taikhoan
            };

            emp = dataProvider.ExecuteDangNhapQuery(query,sqlParameters);
            return emp;
        }
        public DataTable GetEmployeeBaseOnChiNhanhId(int _id)
        {
            string query = "select * from nhanVien where maChiNhanh = @maChiNhanh";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@maChiNhanh", SqlDbType.Int)
            {
                Value = _id
            };
            return dataProvider.ExecuteSelectQuery(query, sqlParameters);
        }
        

        public DataTable getAll()
        {
            string query = "select * from nhanVien";
            return dataProvider.ExecuteSelectAllQuery(query);
        }
    }
}
