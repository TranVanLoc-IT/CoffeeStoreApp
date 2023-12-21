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
using MongoDB.Driver;
namespace CoffeeStoreApp
{
    public partial class Cart : Form
    {
        private NHANVIEN _nv { get; set; }
        public List<CartDTO> cfs { get; set; }
        public int flag { get; set; }
        public Cart(NHANVIEN nv)
        {
            this._nv = nv;
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            MongoClient client = new MongoClient(@"mongodb://127.0.0.1:27017");

            var database = client.GetDatabase("CoffeeDB");
            var collection = database.GetCollection<CartDTO>("cart");
            var resource = collection.Find(Builders<CartDTO>.Filter.Empty).ToList(); // NO CONDITION
            int quantity = 0;
            double money = 0;
            if(resource.Count != 0)
            {
                labelCart.Text += $" Chưa có {resource.Select(itm => itm.soluong).Sum()} sản phẩm!!";
                foreach (var i in resource)
                {
                    quantity += i.soluong;
                    money += i.tongtien;
                }
                txtTotalQuantity.Text = quantity.ToString();
                txtTotalMoney.Text = money.ToString();
                cfs = new List<CartDTO>(resource.Count);
                cfs = resource;
                dataGridViewCart.DataSource = resource;
                flag = 1;
            }
            else
            {
                labelCart.Text += $" Chưa có sản phẩm nào!!";
                flag = 0;
            }
        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            Pay pay = new Pay(this._nv);
            this.Close();
            pay.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var dataCollection = dataGridViewCart.SelectedRows;
            MessageBox.Show(dataCollection[0].ToString(), "content");
        }
    }
}
