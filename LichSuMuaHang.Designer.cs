namespace Phan_mem_quan_ly_bien_ban
{
    partial class LichSuMuaHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPhoneCustomer = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSnCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridHistoryPurchase = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalPrices = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdEmployee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNameEmployee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimeCreate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridServices = new System.Windows.Forms.DataGridView();
            this.colMaDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTimeCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalPrices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServicePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistoryPurchase)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridServices)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPhoneCustomer);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.txtNameCustomer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSnCustomer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(43, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtPhoneCustomer
            // 
            this.txtPhoneCustomer.Enabled = false;
            this.txtPhoneCustomer.Location = new System.Drawing.Point(81, 158);
            this.txtPhoneCustomer.Name = "txtPhoneCustomer";
            this.txtPhoneCustomer.Size = new System.Drawing.Size(167, 20);
            this.txtPhoneCustomer.TabIndex = 5;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(32, 161);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(32, 13);
            this.label.TabIndex = 4;
            this.label.Text = "SĐT:";
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Enabled = false;
            this.txtNameCustomer.Location = new System.Drawing.Point(81, 110);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(167, 20);
            this.txtNameCustomer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên KH:";
            // 
            // txtSnCustomer
            // 
            this.txtSnCustomer.Enabled = false;
            this.txtSnCustomer.Location = new System.Drawing.Point(81, 64);
            this.txtSnCustomer.Name = "txtSnCustomer";
            this.txtSnCustomer.Size = new System.Drawing.Size(167, 20);
            this.txtSnCustomer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã KH:";
            // 
            // gridHistoryPurchase
            // 
            this.gridHistoryPurchase.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridHistoryPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHistoryPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDH,
            this.colTimeCreate,
            this.colEmpName,
            this.colEmpId,
            this.colDiscountId,
            this.colTotalPrices});
            this.gridHistoryPurchase.Location = new System.Drawing.Point(359, 25);
            this.gridHistoryPurchase.Name = "gridHistoryPurchase";
            this.gridHistoryPurchase.Size = new System.Drawing.Size(725, 221);
            this.gridHistoryPurchase.TabIndex = 1;
            this.gridHistoryPurchase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHistoryPurchase_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalPrices);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDiscount);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtIdEmployee);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNameEmployee);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTimeCreate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtOrderId);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.gridServices);
            this.groupBox2.Location = new System.Drawing.Point(43, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1041, 350);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết đơn hàng";
            // 
            // txtTotalPrices
            // 
            this.txtTotalPrices.Enabled = false;
            this.txtTotalPrices.Location = new System.Drawing.Point(100, 234);
            this.txtTotalPrices.Name = "txtTotalPrices";
            this.txtTotalPrices.Size = new System.Drawing.Size(187, 20);
            this.txtTotalPrices.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tổng tiền:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Enabled = false;
            this.txtDiscount.Location = new System.Drawing.Point(100, 199);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(187, 20);
            this.txtDiscount.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mã KM:";
            // 
            // txtIdEmployee
            // 
            this.txtIdEmployee.Enabled = false;
            this.txtIdEmployee.Location = new System.Drawing.Point(100, 160);
            this.txtIdEmployee.Name = "txtIdEmployee";
            this.txtIdEmployee.Size = new System.Drawing.Size(187, 20);
            this.txtIdEmployee.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã NV:";
            // 
            // txtNameEmployee
            // 
            this.txtNameEmployee.Enabled = false;
            this.txtNameEmployee.Location = new System.Drawing.Point(100, 125);
            this.txtNameEmployee.Name = "txtNameEmployee";
            this.txtNameEmployee.Size = new System.Drawing.Size(187, 20);
            this.txtNameEmployee.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "NV tạo đơn:";
            // 
            // txtTimeCreate
            // 
            this.txtTimeCreate.Enabled = false;
            this.txtTimeCreate.Location = new System.Drawing.Point(100, 89);
            this.txtTimeCreate.Name = "txtTimeCreate";
            this.txtTimeCreate.Size = new System.Drawing.Size(187, 20);
            this.txtTimeCreate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thời gian tạo:";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Enabled = false;
            this.txtOrderId.Location = new System.Drawing.Point(100, 54);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(187, 20);
            this.txtOrderId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã ĐH:";
            // 
            // gridServices
            // 
            this.gridServices.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colServiceId,
            this.colServiceName,
            this.colServicePrice,
            this.colServiceDetail});
            this.gridServices.Location = new System.Drawing.Point(316, 19);
            this.gridServices.Name = "gridServices";
            this.gridServices.Size = new System.Drawing.Size(695, 314);
            this.gridServices.TabIndex = 0;
            // 
            // colMaDH
            // 
            this.colMaDH.DataPropertyName = "maDonHang";
            this.colMaDH.HeaderText = "Mã ĐH";
            this.colMaDH.Name = "colMaDH";
            this.colMaDH.ReadOnly = true;
            // 
            // colTimeCreate
            // 
            this.colTimeCreate.DataPropertyName = "thoiGianTaoDon";
            this.colTimeCreate.HeaderText = "Thời gian tạo";
            this.colTimeCreate.Name = "colTimeCreate";
            this.colTimeCreate.ReadOnly = true;
            // 
            // colEmpName
            // 
            this.colEmpName.DataPropertyName = "tenNhanVien";
            this.colEmpName.HeaderText = "NV tạo đơn";
            this.colEmpName.Name = "colEmpName";
            this.colEmpName.ReadOnly = true;
            this.colEmpName.Width = 150;
            // 
            // colEmpId
            // 
            this.colEmpId.DataPropertyName = "maNhanVien";
            this.colEmpId.HeaderText = "Mã NV";
            this.colEmpId.Name = "colEmpId";
            this.colEmpId.ReadOnly = true;
            // 
            // colDiscountId
            // 
            this.colDiscountId.DataPropertyName = "maKhuyenMai";
            this.colDiscountId.HeaderText = "Mã KM";
            this.colDiscountId.Name = "colDiscountId";
            this.colDiscountId.ReadOnly = true;
            // 
            // colTotalPrices
            // 
            this.colTotalPrices.DataPropertyName = "tongTien";
            this.colTotalPrices.HeaderText = "Tổng tiền";
            this.colTotalPrices.Name = "colTotalPrices";
            this.colTotalPrices.ReadOnly = true;
            this.colTotalPrices.Width = 130;
            // 
            // colServiceId
            // 
            this.colServiceId.DataPropertyName = "maDichVu";
            this.colServiceId.HeaderText = "Mã DV";
            this.colServiceId.Name = "colServiceId";
            this.colServiceId.ReadOnly = true;
            // 
            // colServiceName
            // 
            this.colServiceName.DataPropertyName = "tenDichVu";
            this.colServiceName.HeaderText = "Tên DV";
            this.colServiceName.Name = "colServiceName";
            this.colServiceName.ReadOnly = true;
            this.colServiceName.Width = 200;
            // 
            // colServicePrice
            // 
            this.colServicePrice.DataPropertyName = "giaDichVu";
            this.colServicePrice.HeaderText = "Giá tiền";
            this.colServicePrice.Name = "colServicePrice";
            this.colServicePrice.ReadOnly = true;
            // 
            // colServiceDetail
            // 
            this.colServiceDetail.DataPropertyName = "giaiThich";
            this.colServiceDetail.HeaderText = "Chi tiết";
            this.colServiceDetail.Name = "colServiceDetail";
            this.colServiceDetail.ReadOnly = true;
            this.colServiceDetail.Width = 250;
            // 
            // LichSuMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 627);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gridHistoryPurchase);
            this.Controls.Add(this.groupBox1);
            this.Name = "LichSuMuaHang";
            this.Text = "LichSuMuaHang";
            this.Load += new System.EventHandler(this.LichSuMuaHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistoryPurchase)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPhoneCustomer;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSnCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridHistoryPurchase;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridServices;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalPrices;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdEmployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNameEmployee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimeCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscountId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPrices;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServicePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceDetail;
    }
}