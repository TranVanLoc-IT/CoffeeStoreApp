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
        public int flag { get; set; } = 0;
        public int back { get; set; } = 0;
        public double moneyRecieve { get; set; }
        public double change { get; set; }
        public static HOADON hd { get; set; } = new HOADON();

        public event Action<string> FormClosing;
        public static KHACHHANG kh { get; set; } = new KHACHHANG();
        private NHANVIEN _nv { get; set; }

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
            if(childForm is Cart cart)
            {
                flag = cart.flag;
            }
            if (childForm is BillInfo bill)
            {
                bill.kh = kh;
            }
            if (childForm is BillStatus status)
            {
                status.moneyRecieve = this.moneyRecieve;
                status.change = this.change;

            }
            if (back != 0)
            {
                // reset lại cho bước lùi tới
                back = 0;
                ActiveButton(sender);
            }
            else
            {
                if (flag == 0)
                {
                    // nếu ko lùi mà tiến gặp lỗi thì trừ lại do khi nhấp step đã tăng
                    MessageBox.Show("Nhập thông tin/tạo hóa đơn chưa hoàn tất", "Lỗi");
                    if (back == 0) _payStep--;
                    return;
                }
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
            if (buttonName.Contains("Next"))
            {
                _payStep += 1;
            }
            else
            {
                // lùi về bước thanh toán trước
                back = 1;
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
        private void Child_FormClosing(object sender, FormClosingEventArgs e)
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
                    flag = cus.flag;
                    isFormClosed = true;
                }
                else if (sender is BillInfo b)
                {
                    hd = b.hd;
                    flag = b.flag;
                    this.moneyRecieve = b.moneyRecieve;
                    this.change = b.change;
                    isFormClosed = true;
                }
                else
                {
                    Close();
                }
            }
            // hủy đóng khi lỗi
            if (flag == 0) e.Cancel = true;
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
                    cart.FormClosing += Child_FormClosing;
                    break;
                case "fillCustomerInfo":
                    Customer cus = new Customer(_nv);
                    OpenChildForm(cus, sender);
                    cus.FormClosing += Child_FormClosing;
                    break;
                case "fillBillInfo":
                    // object null exception
                    hd.manv = _nv.manv;
                    BillInfo info = new BillInfo(hd,kh, cfs);
                    OpenChildForm(info, sender);
                    info.FormClosing += Child_FormClosing;
                    break;
                case "success":
                    BillStatus status = new BillStatus(hd, kh, cfs, this.moneyRecieve, this.change);
                    OpenChildForm(status, sender);
                    status.FormClosing += Child_FormClosing;
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
