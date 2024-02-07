using Phan_mem_quan_ly_bien_ban.BUS;
using Phan_mem_quan_ly_bien_ban.DAO;
using Phan_mem_quan_ly_bien_ban.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Phan_mem_quan_ly_bien_ban
{
    public partial class QuanLyKhachHang : Form
    {
        List<CustomerDTO> customerDTOs;
        CustomerBUS customerBUS;
        public QuanLyKhachHang()
        {
            InitializeComponent();
            customerDTOs = new List<CustomerDTO>();
            customerBUS = new CustomerBUS();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            load();
            
        }

        private void load()
        {
            customerDTOs.Clear();
            customerDTOs = customerBUS.getAll();
            gridCustomer.DataSource = customerDTOs;
        
        }

        private void gridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã click vào một ô hợp lệ chưa
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy dữ liệu từ ô được click và gán vào các TextBox
                string  maKH = gridCustomer.Rows[e.RowIndex].Cells["colmaKhachHang"].Value.ToString();
                string tenKH = gridCustomer.Rows[e.RowIndex].Cells["coltenKhachHang"].Value.ToString();
                string sdt = gridCustomer.Rows[e.RowIndex].Cells["colSdtKhachHang"].Value.ToString();
                txtNameCustomer.Text = tenKH;
                txtSnCustomer.Text = maKH;
                mtxtPhoneCustomer.Text = sdt;
            }

        }

        private void gridCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerDTO customerDTO = new CustomerDTO();
            
            customerDTO.tenKH = txtNameCustomer.Text;
            customerDTO.sdt = mtxtPhoneCustomer.Text;
            customerDTO.maKH = int.Parse(txtSnCustomer.Text);
            LichSuMuaHang lichSuMuaHang = new LichSuMuaHang(customerDTO);
            if (e.ColumnIndex == 0 )
            {
                
              
                lichSuMuaHang.Show();
            }
            
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if(txtSnCustomer.Text != string.Empty)
            {
                // Trước khi chạy hàm, hiển thị một hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có muốn thực hiện hành động này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Kiểm tra xem người dùng đã chọn Yes hay No
                if (result == DialogResult.Yes)
                {
                    // Thực thi hàm khi người dùng chọn Yes
                    string maKH = txtSnCustomer.Text;
                    string tenKH = txtNameCustomer.Text;
                    string sdt = mtxtPhoneCustomer.Text;

                    bool flag = false;

                    foreach (CustomerDTO cus in customerDTOs)
                    {
                        if(cus.sdt == sdt)
                        {
                            MessageBox.Show("Số điện thoại đã tồn tại","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
                            flag = true;
                            break;
                        }
                        continue;
                    }
                    if(flag == false)
                    {
                        customerBUS.updateOne(maKH, tenKH, sdt);

                        

                    }
                    customerDTOs.Clear();
                    customerDTOs = customerBUS.getAll();
                    gridCustomer.DataSource = customerDTOs;
                }
                else
                {
                    // Thực hiện hành động khác hoặc không làm gì cả khi người dùng chọn No
                }
               


            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (txtSnCustomer.Text != string.Empty)
            {
                // Trước khi chạy hàm, hiển thị một hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có muốn thực hiện hành động này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Kiểm tra xem người dùng đã chọn Yes hay No
                if (result == DialogResult.Yes)
                {
                    // Thực thi hàm khi người dùng chọn Yes
                    string maKH = txtSnCustomer.Text;
                   


                    customerBUS.deleteOne(maKH);

                    customerDTOs.Clear();
                    customerDTOs = customerBUS.getAll();
                    gridCustomer.DataSource = customerDTOs;
                }
                else
                {
                    // Thực hiện hành động khác hoặc không làm gì cả khi người dùng chọn No
                }



            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtNameCustomer.Text != string.Empty && mtxtPhoneCustomer.Text != string.Empty)
            {
                // Trước khi chạy hàm, hiển thị một hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có muốn thực hiện hành động này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Kiểm tra xem người dùng đã chọn Yes hay No
                if (result == DialogResult.Yes)
                {
                    // Thực thi hàm khi người dùng chọn Yes
                   
                    string tenKH = txtNameCustomer.Text;
                    string sdt = mtxtPhoneCustomer.Text;

                    bool flag = false;

                    foreach (CustomerDTO cus in customerDTOs)
                    {
                        if (cus.sdt == sdt)
                        {
                            MessageBox.Show("Số điện thoại đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            flag = true;
                            break;
                        }
                        continue;
                    }
                    if (flag == false)
                    {
                        customerBUS.addNew(tenKH, sdt);



                    }
                    customerDTOs.Clear();
                    customerDTOs = customerBUS.getAll();
                    gridCustomer.DataSource = customerDTOs;
                }
                else
                {
                    // Thực hiện hành động khác hoặc không làm gì cả khi người dùng chọn No
                }



            }
            else { 
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnSearchKH_Click(object sender, EventArgs e)
        {
            if(txtSearchKH.Text != string.Empty)
            {
                string sdt = txtSearchKH.Text;


                customerDTOs.Clear();

                customerDTOs = customerBUS.getCustomerByPhone(sdt);

                gridCustomer.DataSource = customerDTOs;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSearchbox_Click(object sender, EventArgs e)
        {
            txtSearchKH.Text = string.Empty;    

            customerDTOs.Clear();

            customerDTOs = customerBUS.getAll();

            gridCustomer.DataSource = customerDTOs;
        }
    }
}
