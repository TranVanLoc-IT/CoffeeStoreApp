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
    public partial class Login : Form
    {
        private QL_CAFEEntities db = new QL_CAFEEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool IsValidInfo()
        {
            errorProvider.Clear();
            foreach(var control in this.Controls)
            {
                if(control is TextBox txt)
                {
                    if(string.IsNullOrEmpty(txt.Text))
                    {
                        errorProvider.SetError(txt, "Thiếu thông tin");
                        return false;
                    }    
                    if(txt.Name == "txtUserId" && txt.Text.Length != 5)
                    {
                        errorProvider.SetError(txt, "Sai id");
                        return false;
                    }    
                }
            }
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(IsValidInfo())
            {
                var userList = db.NHANVIENs;
                string idInp = txtUserId.Text;
                string passInp = txtPassword.Text;
                NHANVIEN nv = userList.Where(i => i.manv == idInp && i.matkhau == passInp).FirstOrDefault();
                if (nv != null)
                {
                    if(userList.Select(itm => itm.maquanly).Contains(nv.manv))
                    {
                        // quản lý
                        Manager form = new Manager(nv);
                        this.Visible = false;
                        form.ShowDialog();
                    }
                    else
                    {
                        Staff form = new Staff(nv);
                        this.Visible = false;
                        form.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo");
                }
            }    
        }
    }
}
