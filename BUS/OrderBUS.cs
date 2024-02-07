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
    internal class OrderBUS
    {
        OrderDAO orderDAO;
        public OrderBUS() { 
            orderDAO = new OrderDAO();
        }
        public List<OrderDTO> getAll()
        {
            List<OrderDTO> list = new List<OrderDTO>();

            DataTable dataTable = orderDAO.getAll();
            foreach (DataRow dr in dataTable.Rows)
            {
                OrderDTO ord = new OrderDTO();
                ord.maDonHang = int.Parse(dr["maDonHang"].ToString());
                ord.thoiGianTaoDon= dr["thoiGianTaoDon"].ToString();
                // Console.WriteLine("tong tien:"+dr["tongTien"].ToString());
                ord.tongTien = float.Parse(dr["tongTien"].ToString());
                string maKhuyenMaiString = dr["maKhuyenMai"].ToString();
                if (int.TryParse(maKhuyenMaiString, out int maKhuyenMaiValue))
                {
                    ord.maKhuyenMai = maKhuyenMaiValue;
                }
                else
                {
                    ord.maKhuyenMai = null;
                }
                //ord.maKhuyenMai = dr["maKhuyenMai"].ToString() == "null" ? null : int.Parse(dr["maKhuyenMai"].ToString());
                ord.maNhanVien = int.Parse(dr["maNhanVien"].ToString());
                ord.maKhachHang = int.Parse(dr["maKhachHang"].ToString());
                ord.tenKhachHang = dr["tenKhachHang"].ToString();
                ord.tenNhanVien = dr["tenNhanVien"].ToString();
                list.Add(ord);
            }
            return list;
        }


        public List<OrderDTO> getOrderByCustomerId(int id)
        {
            List<OrderDTO> list = new List<OrderDTO>();

            DataTable dataTable = orderDAO.getOrderByCustomerId(id);
            foreach (DataRow dr in dataTable.Rows)
            {
                OrderDTO ord = new OrderDTO();
                ord.maDonHang = int.Parse(dr["maDonHang"].ToString());
                ord.thoiGianTaoDon = dr["thoiGianTaoDon"].ToString();
                // Console.WriteLine("tong tien:"+dr["tongTien"].ToString());
                ord.tongTien = float.Parse(dr["tongTien"].ToString());
                string maKhuyenMaiString = dr["maKhuyenMai"].ToString();
                if (int.TryParse(maKhuyenMaiString, out int maKhuyenMaiValue))
                {
                    ord.maKhuyenMai = maKhuyenMaiValue;
                }
                else
                {
                    ord.maKhuyenMai = null;
                }
                //ord.maKhuyenMai = dr["maKhuyenMai"].ToString() == "null" ? null : int.Parse(dr["maKhuyenMai"].ToString());
                ord.maNhanVien = int.Parse(dr["maNhanVien"].ToString());
                ord.maKhachHang = int.Parse(dr["maKhachHang"].ToString());
                ord.tenKhachHang = dr["tenKhachHang"].ToString();
                ord.tenNhanVien = dr["tenNhanVien"].ToString();
                list.Add(ord);
            }
            return list;
        }
    }
}
