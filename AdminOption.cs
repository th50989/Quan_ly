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
    public partial class AdminOption : Form
    {
        EmployeeDTO employeeDTO;
        public AdminOption()
        {
            InitializeComponent();
        }

        public AdminOption(EmployeeDTO emp):this()
        {
            label7.Text = emp.tenNhanVien.ToString() +" ID: " + emp.maNhanVien;
            employeeDTO = emp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyDonHang quanLyDonHang = new QuanLyDonHang(employeeDTO);
            quanLyDonHang.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien quanLyNhanVien = new QuanLyNhanVien();
            quanLyNhanVien.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang quanLyKhachHang = new QuanLyKhachHang();
            quanLyKhachHang.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuanLyKhuyenMai quanLyKhuyenMai = new QuanLyKhuyenMai();
            quanLyKhuyenMai.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AdminOption_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Statistic statistic = new Statistic();
            statistic.Show();
        }
    }
}
