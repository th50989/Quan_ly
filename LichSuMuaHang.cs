using Phan_mem_quan_ly_bien_ban.BUS;
using Phan_mem_quan_ly_bien_ban.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phan_mem_quan_ly_bien_ban
{
    public partial class LichSuMuaHang : Form
    {
        List<OrderDTO> ordersDTO;
        List<ServiceDTO> serviceDTOs;
        OrderBUS orderBUS;
        ServiceBUS serviceBUS;
        private CustomerDTO customerDTO;
        public LichSuMuaHang(CustomerDTO customer)
        {
            InitializeComponent();
            orderBUS = new OrderBUS();
            serviceBUS = new ServiceBUS();
            ordersDTO = new List<OrderDTO>();
            serviceDTOs = new List<ServiceDTO>();
            this.customerDTO = customer;
            txtSnCustomer.Text = customer.maKH.ToString();
            txtNameCustomer.Text = customer.tenKH.ToString();
            txtPhoneCustomer.Text = customer.sdt.ToString();
        }

        private void LichSuMuaHang_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            ordersDTO = orderBUS.getOrderByCustomerId(customerDTO.maKH);
            gridHistoryPurchase.DataSource = ordersDTO;
        }

        private void gridHistoryPurchase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridHistoryPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy dữ liệu từ ô được click và gán vào các TextBox
                string maDH = gridHistoryPurchase.Rows[e.RowIndex].Cells["colMaDH"].Value.ToString();
                string thoiGianTao = gridHistoryPurchase.Rows[e.RowIndex].Cells["colTimeCreate"].Value.ToString();
                string tenNV = gridHistoryPurchase.Rows[e.RowIndex].Cells["colEmpName"].Value.ToString();
                string tongTien = gridHistoryPurchase.Rows[e.RowIndex].Cells["colTotalPrices"].Value.ToString();
                string maNV = gridHistoryPurchase.Rows[e.RowIndex].Cells["colEmpId"].Value.ToString();
                string maKM = gridHistoryPurchase.Rows[e.RowIndex].Cells["colDiscountId"].Value == null ? "" : gridHistoryPurchase.Rows[e.RowIndex].Cells["colDiscountId"].Value.ToString();
                txtOrderId.Text = maDH;
                txtTimeCreate.Text = thoiGianTao;
                txtIdEmployee.Text = maNV;
                txtDiscount.Text = maKM;
                txtNameEmployee.Text = tenNV;
                txtTotalPrices.Text = tongTien;

                loadServiceList(int.Parse(maDH));

            }
        }

        private void loadServiceList(int orderId)
        {
            serviceDTOs = serviceBUS.getListServiceByOrderId(orderId);
            gridServices.DataSource = serviceDTOs;
        }
    }
}
