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
    public partial class Pay : Form
    {
        private NHANVIEN _nv { get; set; }
        private Form activeForm { get; set; }

        public Pay(NHANVIEN nv)
        {
            this._nv = nv;
            InitializeComponent();
        }

        private void ActiveButton(object sender)
        {
            // add image tick
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
        private void btnConfirmProduct_Click(object sender, EventArgs e)
        {
            string btnName = (sender as Button).Name;
            switch (btnName)
            {
                case "confirmProducts":

                    break;
                case "fillCustomerInfo":

                    break;
                case "fillBillInfo":

                    break;
                case "success":

                    break;
            }
        }
    }
}
