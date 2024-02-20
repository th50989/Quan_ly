using Phan_mem_quan_ly_bien_ban.BUS;
using Phan_mem_quan_ly_bien_ban.DAO;
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
        //orders
        List<OrderDTO> orderDTOs;
        OrderBUS orderBUS;


        //services
        ServiceBUS serviceBUS;
        List<ServiceDTO> serviceDTOs;
        List<string> chosenServices;

        CouponBUS couponBUS;
        CouponDTO couponDTO;
        int maDonHang;
        float moneyChange;
        int tempFlagCheck;
        EmployeeDTO user;
        public QuanLyDonHang(EmployeeDTO emp):this()
        {
            InitializeComponent();
            orderDTOs = new List<OrderDTO>();
            orderBUS = new OrderBUS();
            serviceBUS = new ServiceBUS();
            serviceDTOs = new List<ServiceDTO>();
            couponDTO = new CouponDTO();
            couponBUS = new CouponBUS();
            chosenServices = new List<String>();
            label6.Text = emp.tenNhanVien;
            user = emp;
            moneyChange = 0;
            tempFlagCheck = 0;
            checkedListBox1.ItemCheck += new ItemCheckEventHandler(checkedListBox1_ItemCheck);
            checkedListBox1.SelectedIndexChanged += enableBtnTaoDon;
        }

        public QuanLyDonHang()
        {
        }

        //public QuanLyDonHang(EmployeeDTO emp):this()
        //{
        //    label6.Text = emp.tenNhanVien;
        //    //label5.Text = emp.maNhanVien.ToString();
        //}

        private void QuanLyDonHang_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            orderDTOs = orderBUS.getAll(user.maChiNhanh);
            foreach(OrderDTO order in orderDTOs)
            {
                Console.WriteLine(order.maDonHang + order.maKhachHang + order.maNhanVien + order.tenNhanVien + order.maKhuyenMai + order.tenKhachHang + order.thoiGianTaoDon + order.tongTien.ToString());
            }
            //orderDTOs = orderDTOs.Distinct().ToList();  
            foreach (OrderDTO orderDTO in orderDTOs)
            {
                ListViewItem item = new ListViewItem(new String[] { orderDTO.maDonHang.ToString() });
                item.SubItems.Add(orderDTO.thoiGianTaoDon.ToString());
                item.SubItems.Add(orderDTO.tenNhanVien.ToString());
                item.SubItems.Add(orderDTO.tongTien.ToString());
                item.SubItems.Add(orderDTO.maKhuyenMai.ToString());
                item.SubItems.Add(orderDTO.tenKhachHang.ToString());
                //item.SubItems.Add(orderDTO.maKhachHang.ToString());

                this.listView1.Items.Add(item);
            }



            serviceDTOs = serviceBUS.getAll();
            foreach(ServiceDTO serviceDTO in serviceDTOs)
            {
                checkedListBox1.Items.Add(serviceDTO.tenDichVu.ToString());
              
            }
           
        }
        public void enableBtnTaoDon(object sender,EventArgs e)
        {
            if(checkedListBox1.CheckedItems.Count > 0)
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }
        public void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            tempFlagCheck++;
            if(tempFlagCheck == 1)
            {
                int selectedIndex = e.Index;
                Console.WriteLine("index: " + selectedIndex);
                if (selectedIndex >= 0 && selectedIndex < serviceDTOs.Count)
                {
                    ServiceDTO selectedService = serviceDTOs[selectedIndex];

                    // If the item is being checked, add the money; otherwise, subtract it
                    moneyChange = (e.NewValue == CheckState.Checked) ? selectedService.giaDichVu : -selectedService.giaDichVu;

                    label2.Text = (int.Parse(label2.Text) + moneyChange).ToString();

                }


                string selectedItem = checkedListBox1.Items[e.Index].ToString();
                //ServiceDTO serviceDTO = serviceDTOs[selectedIndex];
                if ((e.CurrentValue == CheckState.Checked))
                {
                    chosenServices.Remove(selectedItem);
                }
                else if ((e.CurrentValue == CheckState.Unchecked))
                {
                    chosenServices.Add(selectedItem);
                }

                //if (e.CurrentValue == CheckState.Checked)
                //{
                //    // Item is being checked
                //    chosenServices.Remove(serviceDTO);
                //}
                //else if (e.CurrentValue == CheckState.Unchecked)
                //{
                //    // Item is being unchecked
                //    chosenServices.Add(serviceDTO);
                ////}
                //Console.WriteLine(chosenServices.Count.ToString());
                //foreach (String service in chosenServices)
                //{
                //    Console.WriteLine("truoc :trong list co: " + service.ToString());
                //}


                chosenServices = chosenServices.Distinct().ToList();
                Console.WriteLine(chosenServices.Count.ToString());
                foreach (String service in chosenServices)
                {
                    Console.WriteLine("Sau :trong list co: " + service.ToString());
                }
            }else tempFlagCheck =0;
            
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection item;
            item = listView1.SelectedItems;
            if(item.Count > 0)
            {
                maDonHang =int.Parse( item[0].SubItems[0].Text);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        static float TinhToan(float tongTien, string phepToanChuoi)
        {
            if (phepToanChuoi.StartsWith("*"))
            {
                // Phép toán nhân
                float heSo = float.Parse(phepToanChuoi.Replace("*", ""));
                return tongTien * heSo;
            }
            else if (phepToanChuoi.StartsWith("-"))
            {
                // Trừ trực tiếp
                float soTru = float.Parse(phepToanChuoi.Replace("-", ""));
                return tongTien - soTru;
            }
            // Các phép toán khác có thể được thêm vào tại đây

            // Nếu không phải bất kỳ phép toán nào trên, trả về giá trị mặc định
            return tongTien;
        }
    
        private async void button1_Click (object sender, EventArgs e)
        {
            string sdt = textBox2.Text;
            float tongtien =float.Parse(label2.Text);
            DateTime now = DateTime.Now;
            int maNhanVien = user.maNhanVien;
            int? maKhuyenMai = null;

            if (string.IsNullOrEmpty(textBox1.Text) ) {
                 maKhuyenMai = null;
            }else
            {
                 maKhuyenMai = int.Parse(textBox1.Text);
            }



            //kiem tra khung nhap sdt
            if (string.IsNullOrEmpty(sdt)) {
                MessageBox.Show("Vui long nhap SDT"); 
            }
            else {
              
               
                  
                    CustomerBUS customerBUS = new CustomerBUS();
                    List<CustomerDTO> list = new List<CustomerDTO>();
                    list =  customerBUS.getCustomerByPhone(sdt);
                    //so luong khach hang co sdt
                    if (list.Count > 0)
                    {
                    if (string.IsNullOrEmpty(textBox1.Text))
                    {
                        orderBUS.add(now, tongtien, maNhanVien, maKhuyenMai, list[0].maKH, chosenServices);
                        listView1.Items.Clear();
                        checkedListBox1.Items.Clear();
                        label2.Text = "0";
                        moneyChange = 0;
                        load();
                    }
                    else
                    {
                        couponDTO = couponBUS.CheckCoupon(textBox1.Text);

                        if (couponDTO == null)
                        {
                            MessageBox.Show("Mã khuyến mãi k tồn tại");
                        }
                        tongtien = TinhToan(tongtien, couponDTO.desCription);
                        Console.WriteLine(tongtien.ToString());
                        label2.Text = tongtien.ToString();
                        await Task.Run(() => MessageBox.Show("Tổng tiền sau khi giảm : " + tongtien));
                        orderBUS.add(now, tongtien, maNhanVien, maKhuyenMai, list[0].maKH, chosenServices);
                        listView1.Items.Clear();
                        checkedListBox1.Items.Clear();
                        label2.Text = "0";
                        moneyChange = 0;
                        load();
                    }
                       
                    }
                    else
                    {
                        MessageBox.Show("SDT khong ton tai, vui long tao thong tin khach hang truoc");
                    }
                
              
            }




            //bool isAtLeastOneItemChecked = IsAtLeastOneItemChecked();

            //if (isAtLeastOneItemChecked)
            //{
            //    // Do something when at least one item is checked
            //    // Add your logic here
            //    if(textBox2.Text != "")
            //    {

            //        MessageBox.Show("Tao don thanh cong");
            //    }
            //    else { MessageBox.Show("vui long Nhap sdt"); }
                
            //}
            //else
            //{
            //    // Do something when no item is checked
            //    // Add your logic here
            //    MessageBox.Show("Vui long chon dich vu");
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(user.isAdmin)
            {
                Console.WriteLine(maDonHang.ToString());
                orderBUS.deleteOrder(maDonHang);
                listView1 .Items.Clear();
                checkedListBox1.Items.Clear();
                label2.Text = "0";
                moneyChange = 0;
                load();
            }
            else
            {
                MessageBox.Show("Only admin");
            }
           
        }

        //private bool IsAtLeastOneItemChecked()
        //{
        //    foreach (int checkedIndex in checkedListBox1.CheckedIndices)
        //    {
        //        if (checkedIndex >= 0 && checkedIndex < serviceDTOs.Count)
        //        {
        //            // At least one item is checked
        //            return true;
        //        }
        //    }

        //    // No item is checked
        //    return false;
        //}
    }
}
