namespace Phan_mem_quan_ly_bien_ban
{
    partial class QuanLyKhachHang
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
            this.txtSearchKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchKH = new System.Windows.Forms.Button();
            this.btnDeleteSearchbox = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSnCustomer = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtPhoneCustomer = new System.Windows.Forms.MaskedTextBox();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.gridCustomer = new System.Windows.Forms.DataGridView();
            this.colmaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSdtKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnLichSuMuaHang = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchKH
            // 
            this.txtSearchKH.Location = new System.Drawing.Point(619, 26);
            this.txtSearchKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchKH.Name = "txtSearchKH";
            this.txtSearchKH.Size = new System.Drawing.Size(191, 20);
            this.txtSearchKH.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập SĐT Khách Hàng";
            // 
            // btnSearchKH
            // 
            this.btnSearchKH.Location = new System.Drawing.Point(829, 19);
            this.btnSearchKH.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchKH.Name = "btnSearchKH";
            this.btnSearchKH.Size = new System.Drawing.Size(85, 33);
            this.btnSearchKH.TabIndex = 2;
            this.btnSearchKH.Text = "Tìm";
            this.btnSearchKH.UseVisualStyleBackColor = true;
            this.btnSearchKH.Click += new System.EventHandler(this.btnSearchKH_Click);
            // 
            // btnDeleteSearchbox
            // 
            this.btnDeleteSearchbox.Location = new System.Drawing.Point(939, 20);
            this.btnDeleteSearchbox.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteSearchbox.Name = "btnDeleteSearchbox";
            this.btnDeleteSearchbox.Size = new System.Drawing.Size(77, 32);
            this.btnDeleteSearchbox.TabIndex = 4;
            this.btnDeleteSearchbox.Text = "Xóa Hết";
            this.btnDeleteSearchbox.UseVisualStyleBackColor = true;
            this.btnDeleteSearchbox.Click += new System.EventHandler(this.btnDeleteSearchbox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã KH:";
            // 
            // txtSnCustomer
            // 
            this.txtSnCustomer.Enabled = false;
            this.txtSnCustomer.Location = new System.Drawing.Point(87, 50);
            this.txtSnCustomer.Name = "txtSnCustomer";
            this.txtSnCustomer.Size = new System.Drawing.Size(196, 20);
            this.txtSnCustomer.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddCustomer);
            this.groupBox1.Controls.Add(this.btnDeleteCustomer);
            this.groupBox1.Controls.Add(this.btnUpdateCustomer);
            this.groupBox1.Controls.Add(this.mtxtPhoneCustomer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNameCustomer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSnCustomer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 368);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Location = new System.Drawing.Point(87, 102);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(196, 20);
            this.txtNameCustomer.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Họ tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "SĐT:";
            // 
            // mtxtPhoneCustomer
            // 
            this.mtxtPhoneCustomer.Location = new System.Drawing.Point(87, 156);
            this.mtxtPhoneCustomer.Mask = "0000000000";
            this.mtxtPhoneCustomer.Name = "mtxtPhoneCustomer";
            this.mtxtPhoneCustomer.PromptChar = ' ';
            this.mtxtPhoneCustomer.Size = new System.Drawing.Size(196, 20);
            this.mtxtPhoneCustomer.TabIndex = 11;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(42, 220);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(123, 37);
            this.btnUpdateCustomer.TabIndex = 12;
            this.btnUpdateCustomer.Text = "Cập nhật";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(189, 220);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(75, 37);
            this.btnDeleteCustomer.TabIndex = 13;
            this.btnDeleteCustomer.Text = "Xóa";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(189, 319);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(94, 32);
            this.btnAddCustomer.TabIndex = 14;
            this.btnAddCustomer.Text = "Thêm mới";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // gridCustomer
            // 
            this.gridCustomer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmaKhachHang,
            this.coltenKhachHang,
            this.colSdtKhachHang,
            this.colBtnLichSuMuaHang});
            this.gridCustomer.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.gridCustomer.Location = new System.Drawing.Point(371, 93);
            this.gridCustomer.MultiSelect = false;
            this.gridCustomer.Name = "gridCustomer";
            this.gridCustomer.ReadOnly = true;
            this.gridCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCustomer.Size = new System.Drawing.Size(694, 430);
            this.gridCustomer.TabIndex = 9;
            this.gridCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCustomer_CellClick);
            this.gridCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCustomer_CellContentClick);
            // 
            // colmaKhachHang
            // 
            this.colmaKhachHang.DataPropertyName = "maKH";
            this.colmaKhachHang.HeaderText = "Mã KH";
            this.colmaKhachHang.Name = "colmaKhachHang";
            this.colmaKhachHang.ReadOnly = true;
            // 
            // coltenKhachHang
            // 
            this.coltenKhachHang.DataPropertyName = "tenKH";
            this.coltenKhachHang.HeaderText = "Họ tên ";
            this.coltenKhachHang.Name = "coltenKhachHang";
            this.coltenKhachHang.ReadOnly = true;
            this.coltenKhachHang.Width = 250;
            // 
            // colSdtKhachHang
            // 
            this.colSdtKhachHang.DataPropertyName = "sdt";
            this.colSdtKhachHang.HeaderText = "SĐT";
            this.colSdtKhachHang.Name = "colSdtKhachHang";
            this.colSdtKhachHang.ReadOnly = true;
            this.colSdtKhachHang.Width = 150;
            // 
            // colBtnLichSuMuaHang
            // 
            this.colBtnLichSuMuaHang.HeaderText = "Lịch sử mua hàng";
            this.colBtnLichSuMuaHang.Name = "colBtnLichSuMuaHang";
            this.colBtnLichSuMuaHang.ReadOnly = true;
            this.colBtnLichSuMuaHang.Text = "Xem lịch sử";
            this.colBtnLichSuMuaHang.UseColumnTextForButtonValue = true;
            this.colBtnLichSuMuaHang.Width = 150;
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 563);
            this.Controls.Add(this.gridCustomer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteSearchbox);
            this.Controls.Add(this.btnSearchKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchKH);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyKhachHang";
            this.Text = "QuanLyKhachHang";
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteSearchbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSnCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtxtPhoneCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnSearchKH;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.DataGridView gridCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSdtKhachHang;
        private System.Windows.Forms.DataGridViewButtonColumn colBtnLichSuMuaHang;
    }
}