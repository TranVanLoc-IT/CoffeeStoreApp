using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeStoreApp
{
    public partial class Pay : Form
    {
        private NHANVIEN _nv { get; set; }
        public HOADON hd { get; set; } = new HOADON();
        public KHACHHANG kh { get; set; } = new KHACHHANG();

        private static int _payStep = 1;

        private static List<CartDTO> cfs { get; set; }

        private bool isFormClosed = false;
        private Form activeForm { get; set; }

        public Pay(NHANVIEN nv)
        {
            this._nv = nv;
            InitializeComponent();
        }

        private void ActiveButton(object sender)
        {
            // add image tick
            using (FileStream stream = new FileStream("../../Images/icons/accept.png", FileMode.Open))
            {
                Image image = Image.FromStream(stream);
                if(_payStep == 1)
                {
                    fillCustomerInfo.Image = null;
                }    
                if (_payStep == 2)
                {
                    fillBillInfo.Image = null;
                }
                if(_payStep==3)
                {
                    success.Image = null;
                }
                (sender as Button).Image = image;
            }
        }
        private void OpenChildForm(Form childForm, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(sender);
            if(childForm is BillInfo bill)
            {
                bill.kh = kh;
            }    
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(childForm);
            this.Height += childForm.Height - this.mainPanel.Height;
            this.mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ChildForm_NextStepHandle(object sender, EventArgs e)
        {
            foreach(var control in activeForm.Controls)
            {
                if(control is TextBox t)
                {
                    if(string.IsNullOrEmpty(t.Text))
                    {
                        MessageBox.Show("Thiếu thông tin", "Lỗi");
                        return;
                    }    
                }    
            }    
            // Xử lý khi form con đóng, kiểm tra tên của button
            string buttonName = (sender as Button).Name;
            if (buttonName.Contains("Next"))
            {
                _payStep += 1;
            }
            else
            {
                _payStep -= 1;
            }
            switch (_payStep)
            {

                case 1:
                    Btn_Step_Click_Handle(confirmProduct, e);
                    break;
                case 2:
                    Btn_Step_Click_Handle(fillCustomerInfo, e);
                    break;

                case 3:
                    Btn_Step_Click_Handle(fillBillInfo, e);
                    break;

                case 4:
                    Btn_Step_Click_Handle(success, e);
                    break;
                default:

                    break;
            }
        }
        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Lấy giá trị trả về từ thuộc tính ReturnValue của form con
            if (!isFormClosed)
            {
                if (sender is Cart c)
                {
                    isFormClosed = true;
                    cfs = new List<CartDTO>(c.cfs.Count);
                    cfs = c.cfs;
                }
                else if (sender is Customer cus)
                {
                    kh = cus.kh;
                    isFormClosed = true;
                }
                else if (sender is BillInfo b)
                {
                    hd = b.hd;
                    isFormClosed = true;
                }
                else
                {
                    Close();
                }
            }
        }
        private void Btn_Completed(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn_Step_Click_Handle(object sender, EventArgs e)
        {
            string btnName = (sender as Button).Name;
            isFormClosed = false;
            switch (btnName)
            {
                case "confirmProduct":
                    Cart cart = new Cart(this._nv);
                    OpenChildForm(cart, sender);
                    cart.FormClosed += ChildForm_FormClosed;
                    break;
                case "fillCustomerInfo":
                    Customer cus = new Customer(_nv);
                    OpenChildForm(cus, sender);
                    cus.FormClosed += ChildForm_FormClosed;
                    break;
                case "fillBillInfo":
                    // object null exception
                    hd.manv = _nv.manv;
                    BillInfo info = new BillInfo(hd,kh, cfs);
                    OpenChildForm(info, sender);
                    info.FormClosed += ChildForm_FormClosed;
                    break;
                case "success":
                    BillStatus status = new BillStatus();
                    OpenChildForm(status, sender);
                    status.FormClosed += ChildForm_FormClosed;
                    status.hd = hd;
                    break;
            }
        }

        private void Pay_Load(object sender, EventArgs e)
        {
            _payStep = 1;
            Btn_Step_Click_Handle(confirmProduct, e);
        }
    }
}
