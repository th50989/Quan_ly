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
    public partial class QuanLyKhuyenMai : Form
    {
        CouponBUS couponBUS;
        public QuanLyKhuyenMai()
        {
            InitializeComponent();
            couponBUS = new CouponBUS();
        }

        public void QuanLyKhuyenMai_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
           List<CouponDTO>couponDTOs = new List<CouponDTO>();
            couponDTOs = couponBUS.getAll();
            dataGridView1.DataSource = couponDTOs;
        }
    }
}
