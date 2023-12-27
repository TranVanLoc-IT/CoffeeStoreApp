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
    public partial class ManageStorage : Form
    {
        public NHANVIEN nv { get; set; }
        private Data _data = new Data();
        public ManageStorage()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if(txtCfCode.Text == null)
            {
                MessageBox.Show("Mã cafe không được bỏ trống", "Lỗi");
            }
            else
            {
                dataGridViewImp.DataSource = _data.GetInventoryLatestOfDrinks(txtCfCode.Text).Select(
                        itm =>
                        new { MaHH = itm.mahh, TenHH = _data.db.HANGHOAs.Where(i=>i.mahh==itm.mahh).Select(i=>i.tenhh).FirstOrDefault(),
                        NgayKiemKe = itm.ngaykiemke, SoLuongConLai = itm.slconlai??0, SoLuongDaBan = itm.sldaban??0,TinhTrang=itm.tinhtrang }
                    ).ToList();
            }
        }

        private bool ValidateImportInfo()
        {
            foreach(var control in panelInfo.Controls)
            {
                if(control is TextBox t)
                {
                    if(t.Name == "txtCfCode" && string.IsNullOrEmpty(t.Text) || t.Name == "txtQuantityImp" && string.IsNullOrEmpty(t.Text))
                    {
                        MessageBox.Show("Thiếu thông tin nhập hàng", "Lỗi");
                        return false;
                    }    
                }    
            }
            return true;
        }
        private void btnAcceptImp_Click(object sender, EventArgs e)
        {
            if(ValidateImportInfo())
            {
                KIEMKE kk = new KIEMKE();
                kk.mahh = txtCfCode.Text;
                kk.ngaykiemke = dateTimePicker1.Value;
                kk.slconlai = int.Parse(cfQuantityImp.Text);
                kk.tinhtrang = "Mới nhập";
                if (_data.AddImport(kk))
                {
                    MessageBox.Show("Nhập hàng thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Đã kiểm kê", "Lỗi");
                }
            }    
        }

        private void btnCancelImp_Click(object sender, EventArgs e)
        {
            foreach (var control in panelInfo.Controls)
            {
                if (control is TextBox t)
                {
                    t.Text = "";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManageStorage_Load(object sender, EventArgs e)
        {

        }
    }
}
