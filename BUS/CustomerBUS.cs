using Phan_mem_quan_ly_bien_ban.DAO;
using Phan_mem_quan_ly_bien_ban.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_mem_quan_ly_bien_ban.BUS
{
    internal class CustomerBUS
    {
        CustomerDAO customerDAO;
        CustomerDTO customerDTO;

        public CustomerBUS(){
            customerDAO = new CustomerDAO();
            customerDTO = new CustomerDTO();
        }

        public void deleteOne(string id)
        {
            int ID = int.Parse(id.ToString());
            customerDAO.deleteOne(ID);
        }

        public void updateOne(string id, string hoten, string sdt)
        {
            int iD = int.Parse(id);

            customerDAO.updateOne(iD, hoten, sdt);
        }

        public void addNew(string hoten, string sdt)
        {
         
            customerDAO.addNew(hoten, sdt);

        }

        public List<CustomerDTO> getAll()
        {
            List<CustomerDTO> list = new List<CustomerDTO>();

            DataTable dataTable = customerDAO.getAll();
            foreach (DataRow dr in dataTable.Rows)
            {
                CustomerDTO emp = new CustomerDTO();
                emp.maKH = int.Parse(dr["maKhachHang"].ToString());
                emp.tenKH = dr["tenKhachHang"].ToString();
                emp.sdt = dr["sdt"].ToString();
                list.Add(emp);
            }
            return list;
        }

        public List<CustomerDTO> getCustomerByPhone(string sdt)
        {
            List<CustomerDTO> list = new List<CustomerDTO>();

            DataTable dataTable = customerDAO.getCustomerByPhone(sdt);
            foreach (DataRow dr in dataTable.Rows)
            {
                CustomerDTO emp = new CustomerDTO();
                emp.maKH = int.Parse(dr["maKhachHang"].ToString());
                emp.tenKH = dr["tenKhachHang"].ToString();
                emp.sdt = dr["sdt"].ToString();
                list.Add(emp);
            }
            return list;
        }

    }
}
