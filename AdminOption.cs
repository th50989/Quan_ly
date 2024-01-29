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
        public AdminOption()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyDonHang quanLyDonHang = new QuanLyDonHang();
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
    }
}
