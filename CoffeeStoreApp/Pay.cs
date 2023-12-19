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
        public HOADON hd { get; set; }
        public KHACHHANG kh { get; set; }
        private int _payStep = 1;
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
                    fillCustomerInfo.Image.Dispose();
                }    
                if (_payStep == 2)
                {
                    fillBillInfo.Image.Dispose();
                }
                if(_payStep==3)
                {
                    success.Image.Dispose();
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
            // Xử lý khi form con đóng, kiểm tra tên của button
            string buttonName = (sender as Button).Name;
            int prev = this._payStep;
            if (buttonName.Contains("Next"))
            {
                this._payStep += 1;
            }
            else
            {
                this._payStep -= 1;
            }
           
            this.Close();
            switch (this._payStep)
            {
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
                if (sender is Cart)
                {
                    isFormClosed = true;
                    Btn_Step_Click_Handle(fillCustomerInfo, EventArgs.Empty);
                }
                else if (sender is Customer cus)
                {
                    kh = cus.kh;
                    isFormClosed = true;
                    Btn_Step_Click_Handle(fillBillInfo, EventArgs.Empty);
                }
                else if (sender is BillInfo b)
                {
                    hd = b.hd;
                    isFormClosed = true;
                    BillStatus status = new BillStatus(hd);
                    OpenChildForm(status, success);
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
                    BillInfo info = new BillInfo(hd,kh.tenkh);
                    OpenChildForm(info, sender);
                    info.FormClosed += ChildForm_FormClosed;
                    break;
                case "success":
                    this.Close();
                    break;
            }
        }

        private void Pay_Load(object sender, EventArgs e)
        {
            confirmProduct.Click += Btn_Step_Click_Handle;
        }
    }
}
