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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Phan_mem_quan_ly_bien_ban
{
    public partial class QuanLyNhanVien : Form
    {
        EmployeeBUS employeeBUS;
        List<EmployeeDTO> lstEmployeeDTO;

        List<DTO.ChiNhanhDTO> lstChiNhanhDTO;
        ChiNhanhBUS chiNhanhBUS;    
        public QuanLyNhanVien()
        {
            InitializeComponent();
            employeeBUS = new EmployeeBUS();
            lstChiNhanhDTO = new List<DTO.ChiNhanhDTO>();
            chiNhanhBUS = new ChiNhanhBUS();    
            lstEmployeeDTO = new List<DTO.EmployeeDTO>();
            comboBox1.SelectedIndex = 1;
      
        }
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            //Load tree view
            lstChiNhanhDTO = chiNhanhBUS.GetAllChiNhanh();
            foreach (ChiNhanhDTO chiNhanh in lstChiNhanhDTO)
            {
                TreeNode node = new TreeNode("Chi Nhanh: "+chiNhanh.tenChiNhanh);
                node.Name = chiNhanh.tenChiNhanh;
                node.Tag = chiNhanh.maChiNhanh;

                lstEmployeeDTO = employeeBUS.getEmployeeBaseOnChiNhanhID(chiNhanh.maChiNhanh);
                foreach (DTO.EmployeeDTO emp in lstEmployeeDTO)
                {
                    TreeNode empNode = new TreeNode(emp.tenNhanVien);
                    empNode.Name = emp.tenNhanVien;
                    empNode.Tag = emp.maNhanVien;
                    node.Nodes.Add(empNode);

                }

                treeView1.Nodes.Add(node);
                //treeView1.SelectedNode = null;
            }

         

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Check if the selected node is a root node
            if (e.Node.Parent == null)
            {
                // Root node clicked (Function A)
                ParentNodeClicked(sender, e);
            }
            else
            {

                // Subnode clicked (Function B)
                SubNodeClicked();
            }
        }
        public void ParentNodeClicked(object sender, TreeViewEventArgs e)
        {
            //listView1.Items.Clear();
            Console.WriteLine("Parent Clicked");
          
           //listView2.Clear();
           lstEmployeeDTO = employeeBUS.getEmployeeBaseOnChiNhanhID(int.Parse(e.Node.Tag.ToString()));
           foreach(DTO.EmployeeDTO emp in lstEmployeeDTO)
            {
                Console.WriteLine(emp.isAdmin.ToString());
            }    
            label7.Text = e.Node.Tag.ToString();
            //Load list view
            //List<DTO.EmployeeDTO> list = employeeBUS.getAll();
            dataGridView1.DataSource = lstEmployeeDTO;

            //foreach (DTO.EmployeeDTO emp in lstEmployeeDTO)
            //{
            //    //ListViewItem item = new ListViewItem(new String[] { emp.maNhanVien.ToString() });
            //    //// item.SubItems.Add(category.CategoryName);
            //    //item.SubItems.Add(emp.tenNhanVien);
            //    //item.SubItems.Add(emp.taiKhoan);
            //    //item.SubItems.Add(emp.matKhau);
            //    //item.SubItems.Add(emp.maChiNhanh.ToString());
            //    //// item.SubItems.Add(emp.isAdmin.ToString());
            //    //this.listView2.Items.Add(item);
            //}

        }
        public void SubNodeClicked() { }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string tenNV = textBox2.Text;
            string taiKhoan = textBox3.Text;
            string matkhau = textBox4.Text;

            string isAdmin = comboBox1.SelectedItem.ToString();
           

            List<EmployeeDTO> employeeDTOs = employeeBUS.getAll();
            bool flag = false;
            foreach(EmployeeDTO emp in employeeDTOs)
            {
                if(emp.taiKhoan == taiKhoan)
                {
                    MessageBox.Show("Tài Khoản Đã Tồn Tại");
                    flag = true;
                    break;
                }    
            }
            if (flag == false)
            {
                employeeBUS.addNew(tenNV, taiKhoan, matkhau, isAdmin, int.Parse(label7.Text));
                lstEmployeeDTO = employeeBUS.getEmployeeBaseOnChiNhanhID(int.Parse(label7.Text.ToString()));
                dataGridView1.DataSource = lstEmployeeDTO;
            }
           
            // dataGridView1.DataSource = lstEmployeeDTO;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 1)
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
                string idd = id.ToString();
                employeeBUS.deleteOne(idd);


                lstEmployeeDTO = employeeBUS.getEmployeeBaseOnChiNhanhID(int.Parse(label7.Text.ToString()));
                dataGridView1.DataSource = lstEmployeeDTO;

            }
            if (e.ColumnIndex == 0)
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
                string idd = id.ToString();
                string hoten = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string taikhoan = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                string matkhau = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                string isadmin = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                int machinhanh =(int)dataGridView1.Rows[e.RowIndex].Cells[7].Value;

                Console.WriteLine(idd+hoten+taikhoan+matkhau+isadmin+machinhanh);
                // studentBUS.updateOne(idd, hoten, diachi, email);

                List<EmployeeDTO> employeeDTOs = employeeBUS.getAll();
                bool flag = false;
                foreach (EmployeeDTO employeeDTO in employeeDTOs)
                {
                    if(employeeDTO.taiKhoan == taikhoan)
                    {
                        MessageBox.Show("Tài Khoản Đã Tồn Tại");
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    employeeBUS.updateOne(idd, hoten, taikhoan, matkhau, isadmin, machinhanh);
                }
                lstEmployeeDTO = employeeBUS.getEmployeeBaseOnChiNhanhID(int.Parse(label7.Text.ToString()));
                dataGridView1.DataSource = lstEmployeeDTO;
                // employeeBUS.updateOne(idd,hoten,taikhoan,matkhau,isadmin,machinhanh);
            }
        }
    }
}
