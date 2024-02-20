namespace Phan_mem_quan_ly_bien_ban
{
    partial class Statistic
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
            this.components = new System.ComponentModel.Container();
            this.do_an_phat_trien_phan_mem_udDataSet = new Phan_mem_quan_ly_bien_ban.do_an_phat_trien_phan_mem_udDataSet();
            this.doanphattrienphanmemudDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grBox_ThongKe = new System.Windows.Forms.GroupBox();
            this.cBox_ChiNhanh = new System.Windows.Forms.ComboBox();
            this.txtBox_DonHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_DoanhThu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.do_an_phat_trien_phan_mem_udDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanphattrienphanmemudDataSetBindingSource)).BeginInit();
            this.grBox_ThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // do_an_phat_trien_phan_mem_udDataSet
            // 
            this.do_an_phat_trien_phan_mem_udDataSet.DataSetName = "do_an_phat_trien_phan_mem_udDataSet";
            this.do_an_phat_trien_phan_mem_udDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doanphattrienphanmemudDataSetBindingSource
            // 
            this.doanphattrienphanmemudDataSetBindingSource.DataSource = this.do_an_phat_trien_phan_mem_udDataSet;
            this.doanphattrienphanmemudDataSetBindingSource.Position = 0;
            // 
            // grBox_ThongKe
            // 
            this.grBox_ThongKe.Controls.Add(this.cBox_ChiNhanh);
            this.grBox_ThongKe.Controls.Add(this.txtBox_DonHang);
            this.grBox_ThongKe.Controls.Add(this.label3);
            this.grBox_ThongKe.Controls.Add(this.txtBox_DoanhThu);
            this.grBox_ThongKe.Controls.Add(this.label2);
            this.grBox_ThongKe.Controls.Add(this.label1);
            this.grBox_ThongKe.Location = new System.Drawing.Point(12, 282);
            this.grBox_ThongKe.Name = "grBox_ThongKe";
            this.grBox_ThongKe.Size = new System.Drawing.Size(776, 161);
            this.grBox_ThongKe.TabIndex = 0;
            this.grBox_ThongKe.TabStop = false;
            this.grBox_ThongKe.Text = "Thống kê :";
            // 
            // cBox_ChiNhanh
            // 
            this.cBox_ChiNhanh.FormattingEnabled = true;
            this.cBox_ChiNhanh.Location = new System.Drawing.Point(128, 34);
            this.cBox_ChiNhanh.Name = "cBox_ChiNhanh";
            this.cBox_ChiNhanh.Size = new System.Drawing.Size(194, 24);
            this.cBox_ChiNhanh.TabIndex = 6;
            this.cBox_ChiNhanh.SelectedIndexChanged += new System.EventHandler(this.CBox_ChiNhanh_SelectedIndexChanged);
            // 
            // txtBox_DonHang
            // 
            this.txtBox_DonHang.Location = new System.Drawing.Point(128, 119);
            this.txtBox_DonHang.Name = "txtBox_DonHang";
            this.txtBox_DonHang.ReadOnly = true;
            this.txtBox_DonHang.Size = new System.Drawing.Size(194, 22);
            this.txtBox_DonHang.TabIndex = 5;
            this.txtBox_DonHang.TextChanged += new System.EventHandler(this.txtBox_DonHang_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng đơn hàng:";
            // 
            // txtBox_DoanhThu
            // 
            this.txtBox_DoanhThu.Location = new System.Drawing.Point(128, 77);
            this.txtBox_DoanhThu.Name = "txtBox_DoanhThu";
            this.txtBox_DoanhThu.ReadOnly = true;
            this.txtBox_DoanhThu.Size = new System.Drawing.Size(194, 22);
            this.txtBox_DoanhThu.TabIndex = 3;
            this.txtBox_DoanhThu.TextChanged += new System.EventHandler(this.txtBox_DoanhThu_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng doanh thu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Nhánh :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 240);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grBox_ThongKe);
            this.Name = "Statistic";
            this.Text = "ThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.do_an_phat_trien_phan_mem_udDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanphattrienphanmemudDataSetBindingSource)).EndInit();
            this.grBox_ThongKe.ResumeLayout(false);
            this.grBox_ThongKe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private do_an_phat_trien_phan_mem_udDataSet do_an_phat_trien_phan_mem_udDataSet;
        private System.Windows.Forms.BindingSource doanphattrienphanmemudDataSetBindingSource;
        private System.Windows.Forms.GroupBox grBox_ThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBox_DoanhThu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_DonHang;
        private System.Windows.Forms.ComboBox cBox_ChiNhanh;
    }
}