using System;
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

        public int flag { get; set; } = 0;

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
            foreach(var control in panelCusinfo.Controls)
            {
                if(control is TextBox t)
                {
                    if(string.IsNullOrEmpty(t.Text))
                    {
                        errorProvider1.SetError(t, "Thiếu thông tin");
                        return false;
                    }    
                }    
            }
            flag = 1;
            return true;
        }
        private void btnEditCus_Click(object sender, EventArgs e)
        {
            kh = new KHACHHANG();
            kh.makh = txtCusId.Text;
            kh.maloaikh = data.db.LOAIKHACHHANGs.Where(i => i.tenloai.Equals(txtCustomerType.Text)).Select(i=>i.maloaikh).FirstOrDefault();// mặc định khi mới thêm
            if (kh.maloaikh.Length != 4) kh.maloaikh = "BD01";
            kh.sdt = txtCusSDT.Text;
            kh.diachi = txtCusAddress.Text;
            kh.tenkh = txtCusName.Text;
            kh.diemtichluy = kh.diemtichluy>0?kh.diemtichluy :0 ;
            kh.email = txtEmail.Text;
            if(CheckFullInfo())
            {
                if(data.EditCustomer(kh, (sender as Button).Name))
                {
                    MessageBox.Show("Thành công", "Thông báo",  MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }    
        }

        private void txtCusId_TextChanged(object sender, EventArgs e)
        {
            string id = txtCusId.Text;
            if(id.Length == 6)
            {
                flag = 1;
                kh = data.db.KHACHHANGs.Where(itm => itm.makh == id).FirstOrDefault();
                if(kh != null)
                {
                    txtCusId.Text = kh.makh;
                    txtCusSDT.Text = kh.sdt;
                    txtCusName.Text = kh.tenkh;
                    txtCustomerType.Text = kh.LOAIKHACHHANG.tenloai;
                    txtCusAddress.Text = kh.diachi;
                    txtEmail.Text = kh.email;
                }    
            }    
        }
    }
}
