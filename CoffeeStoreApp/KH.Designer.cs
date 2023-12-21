<<<<<<< HEAD
﻿
namespace CoffeeStoreApp
=======
﻿namespace CoffeeStoreApp
>>>>>>> a419a1e68aea5648f7664307760934e7a588ec79
{
    partial class KH
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
<<<<<<< HEAD
            this.gbKH = new System.Windows.Forms.GroupBox();
            this.cboMaLoaiKhach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDiemTichLuy = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.dgvKh = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbKH
            // 
            this.gbKH.Controls.Add(this.cboMaLoaiKhach);
            this.gbKH.Controls.Add(this.label1);
            this.gbKH.Controls.Add(this.label3);
            this.gbKH.Controls.Add(this.txtDiaChi);
            this.gbKH.Controls.Add(this.txtDiemTichLuy);
            this.gbKH.Controls.Add(this.txtEmail);
            this.gbKH.Controls.Add(this.txtPhone);
            this.gbKH.Controls.Add(this.txtMaKH);
            this.gbKH.Controls.Add(this.txtHoTen);
            this.gbKH.Controls.Add(this.lblDiaChi);
            this.gbKH.Controls.Add(this.label2);
            this.gbKH.Controls.Add(this.label5);
            this.gbKH.Controls.Add(this.lblPhone);
            this.gbKH.Controls.Add(this.lblHoTen);
            this.gbKH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKH.Location = new System.Drawing.Point(13, 48);
            this.gbKH.Margin = new System.Windows.Forms.Padding(4);
            this.gbKH.Name = "gbKH";
            this.gbKH.Padding = new System.Windows.Forms.Padding(4);
            this.gbKH.Size = new System.Drawing.Size(528, 544);
            this.gbKH.TabIndex = 37;
            this.gbKH.TabStop = false;
            this.gbKH.Text = "Khách Hàng";
            // 
            // cboMaLoaiKhach
            // 
            this.cboMaLoaiKhach.FormattingEnabled = true;
            this.cboMaLoaiKhach.Location = new System.Drawing.Point(179, 408);
            this.cboMaLoaiKhach.Name = "cboMaLoaiKhach";
            this.cboMaLoaiKhach.Size = new System.Drawing.Size(321, 29);
            this.cboMaLoaiKhach.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Điểm tích lũy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã Loại Khách";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(182, 212);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(318, 27);
            this.txtDiaChi.TabIndex = 12;
            // 
            // txtDiemTichLuy
            // 
            this.txtDiemTichLuy.Location = new System.Drawing.Point(178, 473);
            this.txtDiemTichLuy.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiemTichLuy.Name = "txtDiemTichLuy";
            this.txtDiemTichLuy.Size = new System.Drawing.Size(321, 28);
            this.txtDiemTichLuy.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(178, 352);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(321, 28);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(182, 284);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(318, 28);
            this.txtPhone.TabIndex = 3;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(182, 58);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(318, 28);
            this.txtMaKH.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(182, 135);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(318, 28);
            this.txtHoTen.TabIndex = 1;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(40, 212);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(68, 21);
            this.lblDiaChi.TabIndex = 6;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 359);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
=======
            this.dgv_list_KH = new System.Windows.Forms.DataGridView();
            this.txtdiem = new System.Windows.Forms.TextBox();
            this.tb_loai_KH = new System.Windows.Forms.TextBox();
            this.tb_email_KH = new System.Windows.Forms.TextBox();
            this.tb_sdt_KH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_dc_KH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_tenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_maKH = new System.Windows.Forms.TextBox();
            this.bt_update_KH = new System.Windows.Forms.Button();
            this.tb_find_KH = new System.Windows.Forms.TextBox();
            this.bt_out_KH = new System.Windows.Forms.Button();
            this.bt_find_KH = new System.Windows.Forms.Button();
            this.bt_clear_KH = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Ban = new System.Windows.Forms.GroupBox();
            this.bt_add_KH = new System.Windows.Forms.Button();
            this.gb_listBan = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_KH)).BeginInit();
            this.gb_Ban.SuspendLayout();
            this.gb_listBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_list_KH
            // 
            this.dgv_list_KH.AllowUserToAddRows = false;
            this.dgv_list_KH.AllowUserToDeleteRows = false;
            this.dgv_list_KH.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_list_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list_KH.Location = new System.Drawing.Point(5, 44);
            this.dgv_list_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_list_KH.Name = "dgv_list_KH";
            this.dgv_list_KH.ReadOnly = true;
            this.dgv_list_KH.RowHeadersWidth = 51;
            this.dgv_list_KH.RowTemplate.Height = 24;
            this.dgv_list_KH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list_KH.Size = new System.Drawing.Size(1079, 495);
            this.dgv_list_KH.TabIndex = 0;
            this.dgv_list_KH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_list_KH_CellClick);
            // 
            // txtdiem
            // 
            this.txtdiem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtdiem.Location = new System.Drawing.Point(192, 457);
            this.txtdiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new System.Drawing.Size(309, 28);
            this.txtdiem.TabIndex = 2;
            // 
            // tb_loai_KH
            // 
            this.tb_loai_KH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_loai_KH.Location = new System.Drawing.Point(192, 396);
            this.tb_loai_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_loai_KH.Name = "tb_loai_KH";
            this.tb_loai_KH.Size = new System.Drawing.Size(309, 28);
            this.tb_loai_KH.TabIndex = 2;
            // 
            // tb_email_KH
            // 
            this.tb_email_KH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_email_KH.Location = new System.Drawing.Point(192, 325);
            this.tb_email_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_email_KH.Name = "tb_email_KH";
            this.tb_email_KH.Size = new System.Drawing.Size(309, 28);
            this.tb_email_KH.TabIndex = 2;
            // 
            // tb_sdt_KH
            // 
            this.tb_sdt_KH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_sdt_KH.Location = new System.Drawing.Point(192, 261);
            this.tb_sdt_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_sdt_KH.Name = "tb_sdt_KH";
            this.tb_sdt_KH.Size = new System.Drawing.Size(309, 28);
            this.tb_sdt_KH.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(5, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Điểm tích lũy:";
            // 
            // tb_dc_KH
            // 
            this.tb_dc_KH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_dc_KH.Location = new System.Drawing.Point(192, 188);
            this.tb_dc_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_dc_KH.Name = "tb_dc_KH";
            this.tb_dc_KH.Size = new System.Drawing.Size(309, 28);
            this.tb_dc_KH.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(5, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Loại:";
            // 
            // tb_tenKH
            // 
            this.tb_tenKH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_tenKH.Location = new System.Drawing.Point(192, 128);
            this.tb_tenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tenKH.Name = "tb_tenKH";
            this.tb_tenKH.Size = new System.Drawing.Size(309, 28);
            this.tb_tenKH.TabIndex = 2;
>>>>>>> a419a1e68aea5648f7664307760934e7a588ec79
            // 
            // label5
            // 
            this.label5.AutoSize = true;
<<<<<<< HEAD
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã KH";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(40, 284);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(98, 21);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Điện thoại";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(40, 142);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(67, 21);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên";
            // 
            // dgvKh
            // 
            this.dgvKh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvKh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKh.Location = new System.Drawing.Point(6, 60);
            this.dgvKh.Name = "dgvKh";
            this.dgvKh.RowHeadersWidth = 51;
            this.dgvKh.RowTemplate.Height = 24;
            this.dgvKh.Size = new System.Drawing.Size(656, 360);
            this.dgvKh.TabIndex = 38;
            this.dgvKh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKh_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(244, 633);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 86);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Plum;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHuy.Location = new System.Drawing.Point(549, 22);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(107, 51);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Cyan;
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSua.Location = new System.Drawing.Point(206, 22);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 51);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Brown;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Location = new System.Drawing.Point(376, 23);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 51);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThem.Location = new System.Drawing.Point(17, 22);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 51);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKh);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(749, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 544);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Khách Hàng";
=======
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(5, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email:";
            // 
            // tb_maKH
            // 
            this.tb_maKH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_maKH.Location = new System.Drawing.Point(192, 64);
            this.tb_maKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_maKH.Name = "tb_maKH";
            this.tb_maKH.Size = new System.Drawing.Size(309, 28);
            this.tb_maKH.TabIndex = 2;
            // 
            // bt_update_KH
            // 
            this.bt_update_KH.BackColor = System.Drawing.Color.ForestGreen;
            this.bt_update_KH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_update_KH.ForeColor = System.Drawing.Color.White;
            this.bt_update_KH.Location = new System.Drawing.Point(872, 693);
            this.bt_update_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_update_KH.Name = "bt_update_KH";
            this.bt_update_KH.Size = new System.Drawing.Size(185, 47);
            this.bt_update_KH.TabIndex = 43;
            this.bt_update_KH.Text = "Cập Nhật";
            this.bt_update_KH.UseVisualStyleBackColor = false;
            this.bt_update_KH.Click += new System.EventHandler(this.bt_update_KH_Click);
            // 
            // tb_find_KH
            // 
            this.tb_find_KH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_find_KH.Location = new System.Drawing.Point(578, 41);
            this.tb_find_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_find_KH.Name = "tb_find_KH";
            this.tb_find_KH.Size = new System.Drawing.Size(869, 28);
            this.tb_find_KH.TabIndex = 39;
            // 
            // bt_out_KH
            // 
            this.bt_out_KH.BackColor = System.Drawing.Color.SlateBlue;
            this.bt_out_KH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_out_KH.ForeColor = System.Drawing.Color.White;
            this.bt_out_KH.Location = new System.Drawing.Point(1464, 693);
            this.bt_out_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_out_KH.Name = "bt_out_KH";
            this.bt_out_KH.Size = new System.Drawing.Size(185, 47);
            this.bt_out_KH.TabIndex = 40;
            this.bt_out_KH.Text = "Thoát";
            this.bt_out_KH.UseVisualStyleBackColor = false;
            this.bt_out_KH.Click += new System.EventHandler(this.bt_out_KH_Click);
            // 
            // bt_find_KH
            // 
            this.bt_find_KH.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_find_KH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_find_KH.ForeColor = System.Drawing.Color.White;
            this.bt_find_KH.Location = new System.Drawing.Point(1470, 31);
            this.bt_find_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_find_KH.Name = "bt_find_KH";
            this.bt_find_KH.Size = new System.Drawing.Size(185, 47);
            this.bt_find_KH.TabIndex = 41;
            this.bt_find_KH.Text = "Tìm Kiếm";
            this.bt_find_KH.UseVisualStyleBackColor = false;
            // 
            // bt_clear_KH
            // 
            this.bt_clear_KH.BackColor = System.Drawing.Color.Crimson;
            this.bt_clear_KH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_clear_KH.ForeColor = System.Drawing.Color.White;
            this.bt_clear_KH.Location = new System.Drawing.Point(1168, 693);
            this.bt_clear_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_clear_KH.Name = "bt_clear_KH";
            this.bt_clear_KH.Size = new System.Drawing.Size(185, 47);
            this.bt_clear_KH.TabIndex = 42;
            this.bt_clear_KH.Text = "Xóa";
            this.bt_clear_KH.UseVisualStyleBackColor = false;
            this.bt_clear_KH.Click += new System.EventHandler(this.bt_clear_KH_Click);
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
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã KH:";
            // 
            // gb_Ban
            // 
            this.gb_Ban.Controls.Add(this.txtdiem);
            this.gb_Ban.Controls.Add(this.tb_loai_KH);
            this.gb_Ban.Controls.Add(this.tb_email_KH);
            this.gb_Ban.Controls.Add(this.tb_sdt_KH);
            this.gb_Ban.Controls.Add(this.label7);
            this.gb_Ban.Controls.Add(this.tb_dc_KH);
            this.gb_Ban.Controls.Add(this.label6);
            this.gb_Ban.Controls.Add(this.tb_tenKH);
            this.gb_Ban.Controls.Add(this.label5);
            this.gb_Ban.Controls.Add(this.tb_maKH);
            this.gb_Ban.Controls.Add(this.label4);
            this.gb_Ban.Controls.Add(this.label3);
            this.gb_Ban.Controls.Add(this.label2);
            this.gb_Ban.Controls.Add(this.label1);
            this.gb_Ban.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.gb_Ban.Location = new System.Drawing.Point(22, 26);
            this.gb_Ban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Ban.Name = "gb_Ban";
            this.gb_Ban.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Ban.Size = new System.Drawing.Size(517, 714);
            this.gb_Ban.TabIndex = 38;
            this.gb_Ban.TabStop = false;
            this.gb_Ban.Text = "Khách Hàng";
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
            this.bt_add_KH.TabIndex = 44;
            this.bt_add_KH.Text = "Thêm";
            this.bt_add_KH.UseVisualStyleBackColor = false;
            this.bt_add_KH.Click += new System.EventHandler(this.bt_add_KH_Click);
            // 
            // gb_listBan
            // 
            this.gb_listBan.Controls.Add(this.dgv_list_KH);
            this.gb_listBan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.gb_listBan.Location = new System.Drawing.Point(573, 107);
            this.gb_listBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_listBan.Name = "gb_listBan";
            this.gb_listBan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_listBan.Size = new System.Drawing.Size(1089, 546);
            this.gb_listBan.TabIndex = 37;
            this.gb_listBan.TabStop = false;
            this.gb_listBan.Text = "Danh Sách Khách Hàng";
>>>>>>> a419a1e68aea5648f7664307760934e7a588ec79
            // 
            // KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1685, 766);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbKH);
            this.Name = "KH";
            this.Text = "KH";
            this.Load += new System.EventHandler(this.KH_Load);
            this.gbKH.ResumeLayout(false);
            this.gbKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
=======
            this.ClientSize = new System.Drawing.Size(1685, 766);
            this.Controls.Add(this.bt_update_KH);
            this.Controls.Add(this.tb_find_KH);
            this.Controls.Add(this.bt_out_KH);
            this.Controls.Add(this.bt_find_KH);
            this.Controls.Add(this.bt_clear_KH);
            this.Controls.Add(this.gb_Ban);
            this.Controls.Add(this.bt_add_KH);
            this.Controls.Add(this.gb_listBan);
            this.Name = "KH";
            this.Text = "KH";
            this.Load += new System.EventHandler(this.KH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_KH)).EndInit();
            this.gb_Ban.ResumeLayout(false);
            this.gb_Ban.PerformLayout();
            this.gb_listBan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
>>>>>>> a419a1e68aea5648f7664307760934e7a588ec79

        }

        #endregion
<<<<<<< HEAD
        private System.Windows.Forms.GroupBox gbKH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvKh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMaLoaiKhach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiemTichLuy;
=======

        private System.Windows.Forms.DataGridView dgv_list_KH;
        private System.Windows.Forms.TextBox txtdiem;
        private System.Windows.Forms.TextBox tb_loai_KH;
        private System.Windows.Forms.TextBox tb_email_KH;
        private System.Windows.Forms.TextBox tb_sdt_KH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_dc_KH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_tenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_maKH;
        private System.Windows.Forms.Button bt_update_KH;
        private System.Windows.Forms.TextBox tb_find_KH;
        private System.Windows.Forms.Button bt_out_KH;
        private System.Windows.Forms.Button bt_find_KH;
        private System.Windows.Forms.Button bt_clear_KH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_Ban;
        private System.Windows.Forms.Button bt_add_KH;
        private System.Windows.Forms.GroupBox gb_listBan;
>>>>>>> a419a1e68aea5648f7664307760934e7a588ec79
    }
}