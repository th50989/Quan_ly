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
    internal class ThongKeBUS
    {
        ThongKeDAO thongKeDAO;
        ThongKeDTO thongKeDTO;

        public ThongKeBUS()
        {
            thongKeDAO = new ThongKeDAO(); // Khởi tạo DAO
            thongKeDTO = new ThongKeDTO();
        }

        public List<ThongKeDTO> GetThongKeData()
        {
            List<ThongKeDTO> list = new List<ThongKeDTO>();
            int count = 1;
            try
            {
                DataTable dataTable = thongKeDAO.getThongKeData();

                foreach (DataRow dr in dataTable.Rows)
                {
                    ThongKeDTO thongKe = new ThongKeDTO();

                    // Gán dữ liệu từ DataRow cho các thuộc tính của DTO
                    thongKe.MaNhanVien = Convert.ToInt32(dr["maNhanVien"]);
                    thongKe.TenNhanVien = Convert.ToString(dr["tenNhanVien"]);
                    thongKe.MaDonHang = Convert.ToInt32(dr["maDonHang"]);
                    thongKe.TongTien = Convert.ToDecimal(dr["tongTien"]);
                    thongKe.TenDichVu = Convert.ToString(dr["tenDichVu"]);
                    thongKe.TenChiNhanh = Convert.ToString(dr["tenChiNhanh"]);
                    thongKe.TenKhachHang = Convert.ToString(dr["tenKhachHang"]);
                    // Thêm DTO vào danh sách
                    list.Add(thongKe);

                    // Tăng biến đếm số thứ tự
                    count++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetThongKeData: " + ex.Message);
            }
            return list;
        }

        // Phương thức để lấy tên các chi nhánh từ cơ sở dữ liệu
        public List<string> GetTenChiNhanh()
        {
            return thongKeDAO.GetTenChiNhanh();
        }

        public List<string> GetToanBoNhanVien(string selectedChiNhanh)
        {
            return thongKeDAO.GetToanBoNhanVien(selectedChiNhanh);
        }


        // Phương thức để lấy dữ liệu thống kê dựa trên chi nhánh được chọn
        public List<ThongKeDTO> GetThongKeDataByChiNhanh(string selectedChiNhanh)
        {
            return thongKeDAO.GetThongKeDataByChiNhanh(selectedChiNhanh);
        }

        public List<ThongKeDTO> GetThongKeDataByNhanVien(string selectedNhanVien)
        {
            return thongKeDAO.GetThongKeDataByNhanVien(selectedNhanVien);
        }

        public decimal CalculateTotalRevenue(string selectedChiNhanh)
        {
            return thongKeDAO.CalculateTotalRevenue(selectedChiNhanh);
        }

        public decimal CalculateTotalAllRevenue()
        {
            return thongKeDAO.CalculateTotalAllRevenue();
        }

        public decimal totalOrder(string selectedChiNhanh) { 
            return thongKeDAO.totalOrder(selectedChiNhanh);
        }

        public decimal totalOrderAll() {
            return thongKeDAO.totalOrderAll();
         }
        public decimal totalCustomer(string selectedChiNhanh, string selectedNhanVien) 
        {
            return thongKeDAO.totalCustomer(selectedChiNhanh,  selectedNhanVien);
        }
        public decimal totalCustomerAll()
        {
            return thongKeDAO.totalCustomerAll();
        }
    }
}
