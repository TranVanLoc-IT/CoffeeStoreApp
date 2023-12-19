using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
namespace CoffeeStoreApp
{
    public partial class BillInfo : Form
    {
        private Data data = new Data();

        public HOADON hd { get; set; }

        public event Action<string> FormClosingEvent;
        
        public List<CartDTO> cfs { get; set; }

        public string _tenkh { get; set; }

        public BillInfo(HOADON hd, string tenkh, List<CartDTO> cfs)
        {
            this.hd = hd;
            this.cfs = cfs;
            this._tenkh = tenkh;
            InitializeComponent();
        }
        public BillInfo()
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
            hd.tongtien = cfs.Select(itm => itm.tongtien).Sum();
            txtTotalMoney.Text = hd.tongtien.ToString("N2");
            txtCustomerName.Text = _tenkh;
            txtVAT.Text = (hd.tongtien * 0.2).ToString("N2");

            hd.mahd = data.GenerateBillCode();
            txtBillCode.Text = hd.mahd;
            hd.ngaylap = DateTime.Now;
        }
        private void ClearCart()
        {
            MongoClient client = new MongoClient(@"mongodb://127.0.0.1:27017");

            var database = client.GetDatabase("CoffeeDB");
            var collection = database.GetCollection<CartDTO>("cart");

            var result = collection.DeleteMany(Builders<CartDTO>.Filter.Empty);
            if(result.DeletedCount != 0)
            {
                MessageBox.Show("Hoàn tất thanh toán");
            }    
        }
        private void btnBill_Click(object sender, EventArgs e)
        {
            List<CHITIETHD> cthds = new List<CHITIETHD>();
            foreach(var i in cfs)
            {
                CHITIETHD cthd = new CHITIETHD();
                cthd.mahd = hd.mahd;
                cthd.mahh = i.id;
                cthd.soluong = i.soluong;
                cthd.thanhtien = decimal.Parse(i.tongtien.ToString());
                cthds.Add(cthd);
            }    
            if(data.AddBill(hd, cthds))
            {
                MessageBox.Show("Thanh toán Thành công", "Thông báo");
                ClearCart();
            }
            else
            {
                MessageBox.Show("Thanh toán Thất bại", "Thông báo");
            }
        }
    }
}
