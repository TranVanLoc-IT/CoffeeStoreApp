namespace CoffeeStoreApp
{
    partial class NS
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
            this.gb_listBan = new System.Windows.Forms.GroupBox();
            this.dgv_list_NV = new System.Windows.Forms.DataGridView();
            this.bt_add_KH = new System.Windows.Forms.Button();
            this.bt_update_KH = new System.Windows.Forms.Button();
            this.tb_find_NV = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bt_out_KH = new System.Windows.Forms.Button();
            this.txt_phanquyen = new System.Windows.Forms.TextBox();
            this.txt_maquanly = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_chucvu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_emailNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_sdtNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_dcNV = new System.Windows.Forms.TextBox();
            this.bt_clear_KH = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tenNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_maNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Ban = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_find_NV = new System.Windows.Forms.Button();
            this.gb_listBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_NV)).BeginInit();
            this.gb_Ban.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_listBan
            // 
            this.gb_listBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_listBan.Controls.Add(this.dgv_list_NV);
            this.gb_listBan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.gb_listBan.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gb_listBan.Location = new System.Drawing.Point(573, 107);
            this.gb_listBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_listBan.Name = "gb_listBan";
            this.gb_listBan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_listBan.Size = new System.Drawing.Size(930, 546);
            this.gb_listBan.TabIndex = 45;
            this.gb_listBan.TabStop = false;
            this.gb_listBan.Text = "Danh Sách Nhân Viên";
            // 
            // dgv_list_NV
            // 
            this.dgv_list_NV.AllowUserToAddRows = false;
            this.dgv_list_NV.AllowUserToDeleteRows = false;
            this.dgv_list_NV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_list_NV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_list_NV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_list_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list_NV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_list_NV.Location = new System.Drawing.Point(3, 23);
            this.dgv_list_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_list_NV.Name = "dgv_list_NV";
            this.dgv_list_NV.ReadOnly = true;
            this.dgv_list_NV.RowHeadersWidth = 51;
            this.dgv_list_NV.RowTemplate.Height = 24;
            this.dgv_list_NV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list_NV.Size = new System.Drawing.Size(924, 521);
            this.dgv_list_NV.TabIndex = 0;
            this.dgv_list_NV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_list_NV_CellClick);
            // 
            // bt_add_KH
            // 
            this.bt_add_KH.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_add_KH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_add_KH.ForeColor = System.Drawing.Color.White;
            this.bt_add_KH.Location = new System.Drawing.Point(576, 693);
            this.bt_add_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_add_KH.Name = "bt_add_KH";
            this.bt_add_KH.Size = new System.Drawing.Size(185, 47);
            this.bt_add_KH.TabIndex = 52;
            this.bt_add_KH.Text = "Thêm";
            this.bt_add_KH.UseVisualStyleBackColor = false;
            this.bt_add_KH.Click += new System.EventHandler(this.bt_add_KH_Click);
            // 
            // bt_update_KH
            // 
            this.bt_update_KH.BackColor = System.Drawing.Color.ForestGreen;
            this.bt_update_KH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_update_KH.ForeColor = System.Drawing.Color.White;
            this.bt_update_KH.Location = new System.Drawing.Point(808, 693);
            this.bt_update_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_update_KH.Name = "bt_update_KH";
            this.bt_update_KH.Size = new System.Drawing.Size(185, 47);
            this.bt_update_KH.TabIndex = 51;
            this.bt_update_KH.Text = "Cập Nhật";
            this.bt_update_KH.UseVisualStyleBackColor = false;
            this.bt_update_KH.Click += new System.EventHandler(this.bt_update_KH_Click);
            // 
            // tb_find_NV
            // 
            this.tb_find_NV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_find_NV.Location = new System.Drawing.Point(578, 41);
            this.tb_find_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_find_NV.Name = "tb_find_NV";
            this.tb_find_NV.Size = new System.Drawing.Size(611, 28);
            this.tb_find_NV.TabIndex = 47;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(192, 457);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(309, 28);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // bt_out_KH
            // 
            this.bt_out_KH.BackColor = System.Drawing.Color.SlateBlue;
            this.bt_out_KH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_out_KH.ForeColor = System.Drawing.Color.White;
            this.bt_out_KH.Location = new System.Drawing.Point(1267, 693);
            this.bt_out_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_out_KH.Name = "bt_out_KH";
            this.bt_out_KH.Size = new System.Drawing.Size(185, 47);
            this.bt_out_KH.TabIndex = 48;
            this.bt_out_KH.Text = "Thoát";
            this.bt_out_KH.UseVisualStyleBackColor = false;
            this.bt_out_KH.Click += new System.EventHandler(this.bt_out_KH_Click);
            // 
            // txt_phanquyen
            // 
            this.txt_phanquyen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_phanquyen.Location = new System.Drawing.Point(192, 630);
            this.txt_phanquyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_phanquyen.Name = "txt_phanquyen";
            this.txt_phanquyen.Size = new System.Drawing.Size(309, 28);
            this.txt_phanquyen.TabIndex = 2;
            // 
            // txt_maquanly
            // 
            this.txt_maquanly.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_maquanly.Location = new System.Drawing.Point(192, 570);
            this.txt_maquanly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_maquanly.Name = "txt_maquanly";
            this.txt_maquanly.Size = new System.Drawing.Size(309, 28);
            this.txt_maquanly.TabIndex = 2;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_matkhau.Location = new System.Drawing.Point(192, 512);
            this.txt_matkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(309, 28);
            this.txt_matkhau.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(5, 630);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Phân quyền:";
            // 
            // txt_chucvu
            // 
            this.txt_chucvu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_chucvu.Location = new System.Drawing.Point(192, 396);
            this.txt_chucvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_chucvu.Name = "txt_chucvu";
            this.txt_chucvu.Size = new System.Drawing.Size(309, 28);
            this.txt_chucvu.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(5, 570);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mã quản lý:";
            // 
            // txt_emailNV
            // 
            this.txt_emailNV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_emailNV.Location = new System.Drawing.Point(192, 325);
            this.txt_emailNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_emailNV.Name = "txt_emailNV";
            this.txt_emailNV.Size = new System.Drawing.Size(309, 28);
            this.txt_emailNV.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(5, 512);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mật khẩu:";
            // 
            // txt_sdtNV
            // 
            this.txt_sdtNV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_sdtNV.Location = new System.Drawing.Point(192, 261);
            this.txt_sdtNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sdtNV.Name = "txt_sdtNV";
            this.txt_sdtNV.Size = new System.Drawing.Size(309, 28);
            this.txt_sdtNV.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(5, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày vào làm:";
            // 
            // txt_dcNV
            // 
            this.txt_dcNV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_dcNV.Location = new System.Drawing.Point(192, 188);
            this.txt_dcNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dcNV.Name = "txt_dcNV";
            this.txt_dcNV.Size = new System.Drawing.Size(309, 28);
            this.txt_dcNV.TabIndex = 2;
            // 
            // bt_clear_KH
            // 
            this.bt_clear_KH.BackColor = System.Drawing.Color.Crimson;
            this.bt_clear_KH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_clear_KH.ForeColor = System.Drawing.Color.White;
            this.bt_clear_KH.Location = new System.Drawing.Point(1048, 693);
            this.bt_clear_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_clear_KH.Name = "bt_clear_KH";
            this.bt_clear_KH.Size = new System.Drawing.Size(185, 47);
            this.bt_clear_KH.TabIndex = 50;
            this.bt_clear_KH.Text = "Xóa";
            this.bt_clear_KH.UseVisualStyleBackColor = false;
            this.bt_clear_KH.Click += new System.EventHandler(this.bt_clear_KH_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(5, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Chức vụ:";
            // 
            // txt_tenNV
            // 
            this.txt_tenNV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_tenNV.Location = new System.Drawing.Point(192, 128);
            this.txt_tenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenNV.Name = "txt_tenNV";
            this.txt_tenNV.Size = new System.Drawing.Size(309, 28);
            this.txt_tenNV.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(5, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email:";
            // 
            // txt_maNV
            // 
            this.txt_maNV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_maNV.Location = new System.Drawing.Point(192, 64);
            this.txt_maNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.Size = new System.Drawing.Size(309, 28);
            this.txt_maNV.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(5, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(5, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(5, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã NV:";
            // 
            // gb_Ban
            // 
            this.gb_Ban.Controls.Add(this.dateTimePicker1);
            this.gb_Ban.Controls.Add(this.txt_phanquyen);
            this.gb_Ban.Controls.Add(this.txt_maquanly);
            this.gb_Ban.Controls.Add(this.txt_matkhau);
            this.gb_Ban.Controls.Add(this.label10);
            this.gb_Ban.Controls.Add(this.txt_chucvu);
            this.gb_Ban.Controls.Add(this.label9);
            this.gb_Ban.Controls.Add(this.txt_emailNV);
            this.gb_Ban.Controls.Add(this.label8);
            this.gb_Ban.Controls.Add(this.txt_sdtNV);
            this.gb_Ban.Controls.Add(this.label7);
            this.gb_Ban.Controls.Add(this.txt_dcNV);
            this.gb_Ban.Controls.Add(this.label6);
            this.gb_Ban.Controls.Add(this.txt_tenNV);
            this.gb_Ban.Controls.Add(this.label5);
            this.gb_Ban.Controls.Add(this.txt_maNV);
            this.gb_Ban.Controls.Add(this.label4);
            this.gb_Ban.Controls.Add(this.label3);
            this.gb_Ban.Controls.Add(this.label2);
            this.gb_Ban.Controls.Add(this.label1);
            this.gb_Ban.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.gb_Ban.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gb_Ban.Location = new System.Drawing.Point(22, 26);
            this.gb_Ban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Ban.Name = "gb_Ban";
            this.gb_Ban.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Ban.Size = new System.Drawing.Size(517, 714);
            this.gb_Ban.TabIndex = 46;
            this.gb_Ban.TabStop = false;
            this.gb_Ban.Text = "Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(5, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "SDT:";
            // 
            // bt_find_NV
            // 
            this.bt_find_NV.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_find_NV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_find_NV.ForeColor = System.Drawing.Color.White;
            this.bt_find_NV.Location = new System.Drawing.Point(1218, 26);
            this.bt_find_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_find_NV.Name = "bt_find_NV";
            this.bt_find_NV.Size = new System.Drawing.Size(185, 47);
            this.bt_find_NV.TabIndex = 49;
            this.bt_find_NV.Text = "Tìm Kiếm";
            this.bt_find_NV.UseVisualStyleBackColor = false;
            this.bt_find_NV.Click += new System.EventHandler(this.bt_find_NV_Click);
            // 
            // NS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1514, 766);
            this.Controls.Add(this.gb_listBan);
            this.Controls.Add(this.bt_add_KH);
            this.Controls.Add(this.bt_update_KH);
            this.Controls.Add(this.tb_find_NV);
            this.Controls.Add(this.bt_out_KH);
            this.Controls.Add(this.bt_clear_KH);
            this.Controls.Add(this.gb_Ban);
            this.Controls.Add(this.bt_find_NV);
            this.Name = "NS";
            this.Text = "NS";
            this.Load += new System.EventHandler(this.NS_Load);
            this.gb_listBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_NV)).EndInit();
            this.gb_Ban.ResumeLayout(false);
            this.gb_Ban.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_listBan;
        private System.Windows.Forms.DataGridView dgv_list_NV;
        private System.Windows.Forms.Button bt_add_KH;
        private System.Windows.Forms.Button bt_update_KH;
        private System.Windows.Forms.TextBox tb_find_NV;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bt_out_KH;
        private System.Windows.Forms.TextBox txt_phanquyen;
        private System.Windows.Forms.TextBox txt_maquanly;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_chucvu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_emailNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_sdtNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_dcNV;
        private System.Windows.Forms.Button bt_clear_KH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tenNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_maNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_Ban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_find_NV;
    }
}