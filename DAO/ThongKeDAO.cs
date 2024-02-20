using Phan_mem_quan_ly_bien_ban.DATA;
using Phan_mem_quan_ly_bien_ban.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Phan_mem_quan_ly_bien_ban.DAO
{
    internal class ThongKeDAO
    {
        private DataProvider dataProvider;

        public ThongKeDAO()
        {
            dataProvider = new DataProvider(); // Khởi tạo DataProvider
        }

        public DataTable getThongKeData()
        {
            string query = "SELECT * FROM ThongKe";
            return dataProvider.ExecuteSelectAllQuery(query);
        }

        public List<string> GetTenChiNhanh()
        {
            List<string> tenChiNhanhs = new List<string>();

            try
            {
                // Thêm tùy chọn "Tất cả" vào đầu danh sách
                tenChiNhanhs.Add("Tất cả");

                string query = "SELECT tenChiNhanh FROM ChiNhanh";
                DataTable dataTable = dataProvider.ExecuteSelectAllQuery(query);

                foreach (DataRow row in dataTable.Rows)
                {
                    string tenChiNhanh = row["tenChiNhanh"].ToString();
                    tenChiNhanhs.Add(tenChiNhanh);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu cần
                Console.WriteLine("Error in GetTenChiNhanh: " + ex.Message);
            }

            return tenChiNhanhs;
        }


        public List<ThongKeDTO> GetThongKeDataByChiNhanh(string selectedChiNhanh)
        {
            List<ThongKeDTO> thongKeData = new List<ThongKeDTO>();

            try
            {
                string query = "SELECT NV.maNhanVien, NV.tenNhanVien, DH.maDonHang, DH.tongTien, DV.tenDichVu, CN.tenChiNhanh " +
                               "FROM NhanVien NV " +
                               "JOIN ChiNhanh CN ON NV.maChiNhanh = CN.maChiNhanh " +
                               "JOIN Donhang DH ON NV.maNhanVien = DH.maNhanVien " +
                               "JOIN DonHang_DichVu DHDV ON DH.maDonHang = DHDV.maDonHang " +
                               "JOIN DichVu DV ON DHDV.maDichVu = DV.maDichVu " +
                               "WHERE CN.tenChiNhanh = @TenChiNhanh";
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@TenChiNhanh", selectedChiNhanh)
                };

                DataTable dataTable = dataProvider.ExecuteSelectQuery(query, parameters);

                foreach (DataRow row in dataTable.Rows)
                {
                    ThongKeDTO thongKe = new ThongKeDTO();
                    thongKe.MaNhanVien = Convert.ToInt32(row["maNhanVien"]);
                    thongKe.TenNhanVien = row["tenNhanVien"].ToString();
                    thongKe.MaDonHang = Convert.ToInt32(row["maDonHang"]);
                    thongKe.TongTien = Convert.ToDecimal(row["tongTien"]);
                    thongKe.TenDichVu = row["tenDichVu"].ToString();
                    thongKe.TenChiNhanh = row["tenChiNhanh"].ToString();
                    thongKeData.Add(thongKe);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu cần
                Console.WriteLine("Error in GetThongKeDataByChiNhanh: " + ex.Message);
            }

            return thongKeData;
        }


        public decimal CalculateTotalAllRevenue()
        {
            decimal totalRevenue = 0;

            try
            {
                string query = "SELECT SUM(tongTien) AS TotalRevenue FROM ThongKe";
                SqlParameter[] parameters = new SqlParameter[0];

                DataTable dataTable = dataProvider.ExecuteSelectQuery(query, parameters);

                if (dataTable.Rows.Count > 0)
                {
                    totalRevenue = Convert.ToDecimal(dataTable.Rows[0]["TotalRevenue"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in CalculateTotalAllRevenue: " + ex.Message);
            }

            return totalRevenue;
        }

        public decimal CalculateTotalRevenue(string selectedChiNhanh)
        {
            decimal totalRevenue = 0;

            try
            {
                // Viết câu truy vấn SQL để tính tổng doanh thu cho chi nhánh được chọn
                string query = "SELECT SUM(tongTien) AS TotalRevenue FROM ThongKe WHERE tenChiNhanh = @TenChiNhanh";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@TenChiNhanh", selectedChiNhanh)
                };

                // Thực thi câu truy vấn và lấy tổng doanh thu từ kết quả
                object result = dataProvider.ExecuteScalar(query, parameters);
                if (result != null && result != DBNull.Value)
                {
                    totalRevenue = Convert.ToDecimal(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in CalculateTotalRevenue: " + ex.Message);
            }

            return totalRevenue;
        }

        public decimal totalOrder(string selectedChiNhanh)
        {
            decimal totalOrder = 0;
            try
            {
                // Đoạn truy vấn để tính tổng số đơn hàng từ bảng Donhang
                string query = "SELECT COUNT(DH.maDonhang) AS TongSoDonHang " +
                                            "FROM Donhang DH " +
                                            "JOIN NhanVien NV ON DH.maNhanVien = NV.maNhanVien " +
                                            "JOIN ChiNhanh CN ON NV.maChiNhanh = CN.maChiNhanh " +
                                            "WHERE CN.tenChiNhanh = @TenChiNhanh";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@TenChiNhanh", selectedChiNhanh)
                };

                // Thực thi câu truy vấn và lấy tổng doanh thu từ kết quả
                object result = dataProvider.ExecuteScalar(query, parameters);
                if (result != null && result != DBNull.Value)
                {
                    totalOrder = Convert.ToDecimal(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in TotalOrder method: " + ex.Message);
            }
            return totalOrder;
        }

        public decimal totalOrderAll() 
        {
            decimal totalOrder = 0;
            try
            {
                string query = "SELECT COUNT(DH.maDonhang) AS TongSoDonHang FROM Donhang DH";
                // Thực thi câu truy vấn và lấy tổng doanh thu từ kết quả
                SqlParameter[] parameters = new SqlParameter[0];

                DataTable dataTable = dataProvider.ExecuteSelectQuery(query, parameters);

                if (dataTable.Rows.Count > 0)
                {
                    totalOrder = Convert.ToDecimal(dataTable.Rows[0]["TongSoDonHang"]);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error in Calculate Total Orders: " + ex.Message);
            }
            return totalOrder;
        }
    }
}
