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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Phan_mem_quan_ly_bien_ban
{
    public partial class QuanLyDonHang : Form
    {
        List<OrderDTO> orderDTOs;
        OrderBUS orderBUS;
        public QuanLyDonHang()
        {
            InitializeComponent();
            orderDTOs = new List<OrderDTO>();
            orderBUS = new OrderBUS();
        }

        public QuanLyDonHang(EmployeeDTO emp):this()
        {
            label6.Text = emp.tenNhanVien;
            //label5.Text = emp.maNhanVien.ToString();
        }

        private void QuanLyDonHang_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            orderDTOs = orderBUS.getAll();
            foreach (OrderDTO orderDTO in orderDTOs)
            {
                ListViewItem item = new ListViewItem(new String[] { orderDTO.maDonHang.ToString() });

               // item.SubItems.Add(orderDTO.maDonHang.ToString());
                item.SubItems.Add(orderDTO.thoiGianTaoDon.ToString());
                item.SubItems.Add(orderDTO.tenNhanVien.ToString());
                item.SubItems.Add(orderDTO.maKhachHang.ToString());
                item.SubItems.Add(orderDTO.tongTien.ToString());
                item.SubItems.Add(orderDTO.maKhuyenMai.ToString());
                item.SubItems.Add(orderDTO.tenKhachHang.ToString());
               

             

                this.listView1.Items.Add(item);
            }
           
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
