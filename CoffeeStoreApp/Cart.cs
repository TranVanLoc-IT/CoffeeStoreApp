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
        private List<CartDTO> resource { get; set; }
        public List<CartDTO> cfs { get; set; }
        public string mahh { get; set; }
        public int flag { get; set; } = 0;
        public Cart(NHANVIEN nv)
        {
            MongoClient client = new MongoClient(@"mongodb://127.0.0.1:27017");

            var database = client.GetDatabase("CoffeeDB");
            var collection = database.GetCollection<CartDTO>("cart");
            resource = collection.Find(Builders<CartDTO>.Filter.Empty).ToList(); // NO CONDITION
            flag = resource.Count;
            this._nv = nv;
            InitializeComponent();
        }

        private void dgv_list_Cart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                int numrow;
                numrow = e.RowIndex;
                mahh = dataGridViewCart.Rows[numrow].Cells[1].Value.ToString();
        }
        private void LoadData()
        {
            MongoClient client = new MongoClient(@"mongodb://127.0.0.1:27017");

            var database = client.GetDatabase("CoffeeDB");
            var collection = database.GetCollection<CartDTO>("cart");
            resource = collection.Find(Builders<CartDTO>.Filter.Empty).ToList(); // NO CONDITION

            int quantity = 0;
            double money = 0;
            if (resource.Count != 0)
            {
                labelCart.Text = $"Giỏ hàng Có {resource.Select(itm => itm.soluong).Sum()} sản phẩm!!";
                
            }
            else
            {
                labelCart.Text = $"Giỏ hàng Chưa có sản phẩm nào!!";
            }
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
        }
        private void Cart_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            Pay pay = new Pay(this._nv);
            this.Close();
            pay.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            MongoClient client = new MongoClient(@"mongodb://127.0.0.1:27017");

            var database = client.GetDatabase("CoffeeDB");
            var collection = database.GetCollection<CartDTO>("cart");
            var result= collection.DeleteOne(Builders<CartDTO>.Filter.Eq("_id", mahh));
            if(result.DeletedCount != 0)
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                LoadData();
            }
        }
    }
}
