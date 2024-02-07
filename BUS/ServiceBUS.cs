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
    internal class ServiceBUS
    {
        ServiceDAO serviceDAO;
        ServiceDTO serviceDTO;
        public ServiceBUS() {
            serviceDAO = new ServiceDAO();
            serviceDTO = new ServiceDTO();

        }

        public List<ServiceDTO> getAll()
        {
            List<ServiceDTO> list = new List<ServiceDTO>();

            DataTable dataTable = serviceDAO.getAll();
            foreach (DataRow dr in dataTable.Rows)
            {
                ServiceDTO emp = new ServiceDTO();
                emp.maDichVu = int.Parse(dr["maDichVu"].ToString());
                emp.tenDichVu = dr["tenDichVu"].ToString();
                emp.giaDichVu = float.Parse(dr["giaDichVu"].ToString());
                emp.giaiThich = dr["giaiThich"].ToString();
                list.Add(emp);
            }
            return list;
        }

        public List<ServiceDTO> getCustomerById(int id)
        {
            List<ServiceDTO> list = new List<ServiceDTO>();

            DataTable dataTable = serviceDAO.getServiceById(id);
            foreach (DataRow dr in dataTable.Rows)
            {
                ServiceDTO emp = new ServiceDTO();
                emp.maDichVu = int.Parse(dr["maDichVu"].ToString());
                emp.tenDichVu = dr["tenDichVu"].ToString();
                emp.giaDichVu = float.Parse(dr["giaDichVu"].ToString());
                emp.giaiThich = dr["giaiThich"].ToString();
                list.Add(emp);
            }
            return list;
        }


        public List<ServiceDTO> getListServiceByOrderId(int id)
        {
            List<ServiceDTO> list = new List<ServiceDTO>();

            DataTable dataTable = serviceDAO.getListServicesByOrderId(id);
            foreach (DataRow dr in dataTable.Rows)
            {
                ServiceDTO emp = new ServiceDTO();
                emp.maDichVu = int.Parse(dr["maDichVu"].ToString());
                emp.tenDichVu = dr["tenDichVu"].ToString();
                emp.giaDichVu = float.Parse(dr["giaDichVu"].ToString());
                emp.giaiThich = dr["giaiThich"].ToString();
                list.Add(emp);
            }
            return list;
        }

    }


}
