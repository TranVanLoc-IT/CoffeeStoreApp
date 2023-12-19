﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeStoreApp
{
    public partial class Customer : Form
    {
        private NHANVIEN _nv { get; set; }

        public KHACHHANG kh { get; set; }

        private Data data = new Data();

        public Customer(NHANVIEN nv)
        {
            this._nv = nv;
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private bool CheckFullInfo()
        {
            errorProvider1.Clear();
            foreach(var control in grInfo.Controls)
            {
                if(control is TextBox t)
                {
                    if(string.IsNullOrEmpty(t.Text))
                    {
                        errorProvider1.SetError(t, "Sai thông tin");
                        return false;
                    }    
                }    
            }    

            return true;
        }
        private void btnEditCus_Click(object sender, EventArgs e)
        {
            kh.makh = txtCusId.Text;
            kh.maloaikh = txtCustomerType.Text;
            kh.sdt = txtCusSDT.Text;
            kh.diachi = txtCusAddress.Text;
            kh.tenkh = txtCusName.Text;
            if(CheckFullInfo())
            {
                if(data.EditCustomer(kh, (sender as Button).Name))
                {
                    MessageBox.Show("Thông báo", "Thành công", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("Thông báo", "Thất bại", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }    
        }

        private void txtCusId_TextChanged(object sender, EventArgs e)
        {
            string id = txtCusId.Text;
            if(id.Length == 6)
            {
                kh = data.db.KHACHHANGs.Where(itm => itm.makh == id).FirstOrDefault();
                if(kh != null)
                {
                    txtCusId.Text = kh.makh;
                    txtCusSDT.Text = kh.sdt;
                    txtCusName.Text = kh.tenkh;
                    txtCustomerType.Text = kh.LOAIKHACHHANG.tenloai;
                    txtCusAddress.Text = kh.diachi;
                }    
            }    
        }
    }
}
