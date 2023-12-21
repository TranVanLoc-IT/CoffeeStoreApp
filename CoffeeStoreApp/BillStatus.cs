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
    public partial class BillStatus : Form
    {
        public HOADON hd { get; set; }
        public List<CartDTO> cfs { get; set; } = new List<CartDTO>();
        public KHACHHANG kh { get; set; }
        public BillStatus(HOADON hd,KHACHHANG kh, List<CartDTO> cfs)
        {
            this.hd = hd;
            this.kh = kh;
            this.cfs = cfs;
            InitializeComponent();
        }

        private void BillStatus_Load(object sender, EventArgs e)
        {
            foreach(var cf in cfs)
            {
                txtProductList.Text += $"{cf.ten}x{cf.soluong}\n";
            }
            int score = hd.tongtien > 200000 ? 20 : hd.tongtien < 100000 ? 10 : 5;
            txtScore.Text = $"{kh.diemtichluy} + {score}";
            txtStaffName.Text = hd.NHANVIEN.tennv;
            txtTable.Text = hd.BAN.tenban + " - " + hd.BAN.KHUVUC.tenkv;
            txtTotal.Text = hd.tongtien.ToString();
            txtBillCode.Text = hd.mahd;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
