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
    public partial class Manager : Form
    {
        private NHANVIEN _nv { get; set; }
        private Button currentButton { get; set; }
        private Form activeForm { get; set; }
        public Manager(NHANVIEN nv)
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
                    break;
            }
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }
    }
}
