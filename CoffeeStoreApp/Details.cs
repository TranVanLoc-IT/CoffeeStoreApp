using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
namespace CoffeeStoreApp
{
    public partial class Details : Form
    {
        private const string ConnectionString = @"mongodb://127.0.0.1:27017";
        private Data data = new Data();
        public string idhh { get; set; }
        public int mode { get; set; }
        private NHANVIEN _nv { get; set; }
        public Details(NHANVIEN nv, string idhh, int f)
        {
            this._nv = nv;
            this.idhh = idhh;
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Details_Load(object sender, EventArgs e)
        {
            HANGHOA hh = data.db.HANGHOAs.Where(itm => itm.mahh == idhh).FirstOrDefault();
            KIEMKE inventory = data.GetInventoryLatestOfDrinks(idhh);
            // read coffee info 
            MongoClient client = new MongoClient(connectionString: ConnectionString);
            pictureBox1.Image = Image.FromStream(new FileStream("../../Images/coffees/" + hh.hinhanh, FileMode.Open));
            var database = client.GetDatabase("CoffeeDB");

            var collection = database.GetCollection<CoffeeInfo>("cfi");
            var resources = collection.Find(Builders<CoffeeInfo>.Filter.Eq("_id", idhh)).FirstOrDefault();
            if(resources != null)
            {
                // do
                txtBrand.Text = resources.thuonghieu;
                txtMadeIn.Text = resources.xuatxu;
                txtDescribe.Text = resources.thongtin;
                txtTaste.Text = resources.huongvi;
            }    
            // sure
            if(hh != null && inventory != null)
            {
                txtName.Text = hh.tenhh;
                txtPrice.Text = hh.dongia.ToString("N2");
                txtQuantityLeft.Text = inventory.slconlai.ToString();
                txtQuantitySold.Text = "1";

                int star = inventory.sldaban??0;
                star = (50 / 5)/2;
                while(star != 0)
                {
                    PictureBox pic = new PictureBox();
                    pic.Width = 50;
                    pic.Height = 45;
                    pic.Image = Image.FromStream(new FileStream("../../Images/icons/star.png", FileMode.Open));
                    flowLayoutPanel1.Controls.Add(pic);
                }    
            }
            else
            {
                txtName.Text = hh.tenhh;
                txtPrice.Text = hh.dongia.ToString("N2");
                txtQuantityLeft.Text = "Chưa có dữ liệu";
                txtQuantitySold.Text = "1";
            } 
        }

        private void btnToCart_Click(object sender, EventArgs e)
        {
            MongoClient client = new MongoClient(connectionString: ConnectionString);

            var database = client.GetDatabase("CoffeeDB");

            var collection = database.GetCollection<CartDTO>("cart");
            try
            {

                collection.InsertOne(new CartDTO()
                {   
                    id = idhh,
                    soluong = int.Parse(txtQuantitySold.Text),
                    ten = txtName.Text,
                    stt = 1,
                    tongtien = (double.Parse(txtQuantitySold.Text) * double.Parse(txtPrice.Text))
                });
            }catch(Exception ex)
            {
                MessageBox.Show("Thông báo", "Thêm món thất bại");
            }
            MessageBox.Show("Thông báo", "Thêm món thành công");
        }
    }
}
    