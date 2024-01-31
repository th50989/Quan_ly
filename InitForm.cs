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
    public partial class InitForm : Form
    {
        EmployeeBUS employeeBUS;
        EmployeeDTO employeeDTO;
        public InitForm()
        {
            InitializeComponent();
            employeeBUS = new EmployeeBUS();
            employeeDTO = new EmployeeDTO();
        }

     

        private void button2_Click(object sender, EventArgs e)
        {   
            string taiKhoan = textBox1.Text;
            string matkhau = textBox2.Text;
           

            employeeDTO = employeeBUS.DangNhap(taiKhoan, matkhau);

            if (employeeDTO == null)
            {
                MessageBox.Show("Dang Nhap SAI");
            }
            else
            {
                if(employeeDTO.isAdmin == true)
                {
                     AdminOption adminOption = new AdminOption(employeeDTO);
                    adminOption.Show();
                }
                else
                {
                    QuanLyDonHang quanLyDonHang = new QuanLyDonHang(employeeDTO);
                    quanLyDonHang.Show();
                }
                
            }
            
            }

        private void InitForm_Load(object sender, EventArgs e)
        {

        }
    }
}

