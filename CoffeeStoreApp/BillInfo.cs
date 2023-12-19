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
    public partial class BillInfo : Form
    {
        private Data data = new Data();
        public HOADON hd { get; set; }
        public event Action<string> FormClosingEvent;
        public string _tenkh { get; set; }
        public BillInfo(HOADON hd, string tenkh)
        {
            InitializeComponent();
        }

        
        private void FormClosed(string buttonName)
        {
            // nextstep
            FormClosingEvent?.Invoke(buttonName);
            Close();
        }    
        private void BillInfo_Load(object sender, EventArgs e)
        {
            //var emptytable 
            txtBillCode.Text = hd.mahd;
            txtTotalMoney.Text = hd.tongtien.ToString("N2");
            txtCustomerName.Text = _tenkh;
            txtVAT.Text = (hd.tongtien * 0.2).ToString("N2");

        }

        private void btnBill_Click(object sender, EventArgs e)
        {

        }
    }
}
