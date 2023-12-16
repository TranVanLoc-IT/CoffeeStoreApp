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
    public partial class Staff : Form
    {
        private NHANVIEN _nv { get; set; }
        private Button currentButton { get; set; }
        private Form activeForm { get; set; }
        public Staff(NHANVIEN nv)
        {
            this._nv = nv;
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }
        private void ActiveButton(object sender)
        {
            if (currentButton != null)
                currentButton.BackColor = Color.Red;
            Button btn = sender as Button;
            currentButton = btn;
            btn.BackColor = Color.Chocolate;
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
        private void btnView_Click(object sender, EventArgs e)
        {
            string btnFunction = (sender as Button).Name;
            switch (btnFunction)
            {
                case "btnView":
                    CoffeeList view = new CoffeeList(this._nv);
                    OpenChildForm(view, sender);
                    break;
                case "btnCustomer":
                    //Customer customer = new Customer();
                    //OpenChildForm(customer, sender);
                    break;
                case "btnPay":
                    Pay pay = new Pay(this._nv);
                    OpenChildForm(pay, sender);
                    break;
                case "btncart":
                    Cart cart = new Cart();
                    OpenChildForm(cart, sender);
                    break;

            }
        }
    }
}
