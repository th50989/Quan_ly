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
    public partial class InitForm : Form
    {
        public InitForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminOption admin = new AdminOption();
            admin.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanLyDonHang quanLyDonHang = new QuanLyDonHang();  
            quanLyDonHang.Show();
        }
    }
}
