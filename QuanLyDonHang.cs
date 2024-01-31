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
    public partial class QuanLyDonHang : Form
    {
        public QuanLyDonHang()
        {
            InitializeComponent();
        }

        public QuanLyDonHang(EmployeeDTO emp):this()
        {
            label6.Text = emp.tenNhanVien;
            //label5.Text = emp.maNhanVien.ToString();
        }

        private void QuanLyDonHang_Load(object sender, EventArgs e)
        {

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
    }
}
