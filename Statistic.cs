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
    public partial class Statistic : Form
    {
        List<ThongKeDTO> statisticDTO;
        ThongKeBUS statisticBUS;
        public Statistic()
        {
            InitializeComponent();
            statisticDTO = new List<ThongKeDTO>();
            statisticBUS = new ThongKeBUS();
            this.Load += Statistic_Load;
            cBox_ChiNhanh.SelectedIndexChanged += CBox_ChiNhanh_SelectedIndexChanged; // Bắt sự kiện khi ComboBox thay đổi
        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            
            List<string> tenChiNhanhList = statisticBUS.GetTenChiNhanh();

            // Đặt danh sách chi nhánh vào ComboBox
            cBox_ChiNhanh.DataSource = tenChiNhanhList;

            // Mặc định chọn "Tất cả"
            cBox_ChiNhanh.SelectedIndex = 0;
            LoadData();
            LoadChiNhanhNames();
        }
       
        private void LoadData()
        {
            statisticDTO.Clear();
            // Load dữ liệu ban đầu cho DataGridView
            statisticDTO = statisticBUS.GetThongKeData();
            dataGridView1.DataSource = statisticDTO;
        }

        private void LoadChiNhanhNames()
        {
            // Thực hiện truy vấn để lấy tên các chi nhánh từ cơ sở dữ liệu
            List<string> chiNhanhNames = statisticBUS.GetTenChiNhanh();

            // Thêm tên các chi nhánh vào ComboBox
            cBox_ChiNhanh.DataSource = chiNhanhNames;
        }

        private void CBox_ChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBox_ChiNhanh.SelectedIndex == 0)
            {
                statisticDTO = statisticBUS.GetThongKeData();
                dataGridView1.DataSource = statisticDTO;
                decimal totalRevenue = statisticBUS.CalculateTotalAllRevenue();
                txtBox_DoanhThu.Text = totalRevenue.ToString();
                decimal totalOrder = statisticBUS.totalOrderAll();
                txtBox_DonHang.Text = totalOrder.ToString();
            }
            else
            {
                // Refresh dữ liệu hiện có trên DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                // Lấy tên chi nhánh được chọn từ ComboBox
                string selectedChiNhanh = cBox_ChiNhanh.SelectedItem.ToString();

                // Lấy dữ liệu mới từ cơ sở dữ liệu dựa trên chi nhánh được chọn và gán vào DataGridView
                List<ThongKeDTO> thongKeData = statisticBUS.GetThongKeDataByChiNhanh(selectedChiNhanh);
                dataGridView1.DataSource = thongKeData;

                // Tính và hiển thị tổng doanh thu
                decimal totalRevenue = statisticBUS.CalculateTotalRevenue(selectedChiNhanh);
                txtBox_DoanhThu.Text = totalRevenue.ToString();

                // Tính và hiển thị tổng đơn hàng
                decimal totalOrder = statisticBUS.totalOrder(selectedChiNhanh);
                txtBox_DonHang.Text = totalOrder.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBox_DoanhThu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_DonHang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
