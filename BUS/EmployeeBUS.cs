using Phan_mem_quan_ly_bien_ban.DAO;
using Phan_mem_quan_ly_bien_ban.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Phan_mem_quan_ly_bien_ban.BUS
{
    
    internal class EmployeeBUS
    {
        EmployeeDAO employeeDAO;
        EmployeeDTO employeeDTO;
        public EmployeeBUS()
        {
            employeeDAO = new EmployeeDAO();
            employeeDTO = new EmployeeDTO();
        }

        public void deleteOne(string id)
        {
            int iD = int.Parse(id.ToString());
            employeeDAO.deleteOne(iD);
        }
        public void updateOne(string id, string hoten, string taikhoan,string matkhau, string isadmin,int machinhanh)
        {
            int iD = int.Parse(id);
            if(isadmin == "True")
            {
                isadmin = "1";
            }else isadmin = "0";
            byte isAdmin_ = Convert.ToByte(isadmin);

            employeeDAO.updateOne(iD, hoten, taikhoan, matkhau,isAdmin_,machinhanh);
        }
        public void addNew(string tenNV, string taikhoan, string matKhau, string isAdmin, int chiNhanhID)
        {

             // Chuyển đổi chuỗi số thành số nguyên
            
            if(isAdmin == "Admin") {
                isAdmin = "1";
            }
            else isAdmin = "0";
            //bool isAdmin_ = bool.Parse(isAdmin);
           // isAdmin = Convert.ToByte(isAdmin);
            byte isAdmin_ = Convert.ToByte(isAdmin);
            employeeDAO.addNew(tenNV, taikhoan, matKhau, isAdmin_, chiNhanhID);

        }
    
    public EmployeeDTO DangNhap(string taikhoan, string matkhau)
        {
           
            employeeDTO = employeeDAO.DangNhap(taikhoan, matkhau);
            return employeeDTO;
        }
        public List<EmployeeDTO> getAll()
        {
            List<EmployeeDTO> list = new List<EmployeeDTO>();
           
            DataTable dataTable = employeeDAO.getAll();
            foreach (DataRow dr in dataTable.Rows)
            {
                EmployeeDTO emp = new EmployeeDTO();
                emp.maNhanVien = int.Parse(dr["maNhanVien"].ToString());
                emp.tenNhanVien = dr["tenNhanVien"].ToString();
                emp.taiKhoan = dr["taiKhoan"].ToString();
                emp.matKhau = dr["matKhau"].ToString();
                emp.maChiNhanh = int.Parse(dr["maChiNhanh"].ToString());
                list.Add(emp);
            }
            return list;
        }
        public List<EmployeeDTO> getEmployeeBaseOnChiNhanhID(int id)
        {
            List<EmployeeDTO> employeeDTOs = new List<EmployeeDTO>();
            DataTable dataTable = employeeDAO.GetEmployeeBaseOnChiNhanhId(id);
            foreach (DataRow dr in dataTable.Rows)
            {
                EmployeeDTO emp = new EmployeeDTO();
                emp.maNhanVien = int.Parse(dr["maNhanVien"].ToString());
                emp.tenNhanVien = dr["tenNhanVien"].ToString();
                emp.taiKhoan = dr["taiKhoan"].ToString();
                emp.matKhau = dr["matKhau"].ToString();
                emp.maChiNhanh = int.Parse(dr["maChiNhanh"].ToString());
                emp.isAdmin = bool.Parse(dr["isAdmin"].ToString());
                Console.WriteLine("Truoc khi ep kieu :"+ emp.isAdmin.ToString());
                Console.WriteLine("Sau khi ep kieu :" + bool.Parse(emp.isAdmin.ToString()));
                employeeDTOs.Add(emp);
            }

            return employeeDTOs;
        }
    }

   

}
