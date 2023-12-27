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
            KIEMKE inventory = data.GetInventoryLatestOfDrinks(idhh)?.Last();
            // read coffee info 
            MongoClient client = new MongoClient(connectionString: ConnectionString);
            using(var stream = new FileStream("../../Images/coffees/" + hh.hinhanh, FileMode.Open))
            {
                pictureBox1.Image = Image.FromStream(stream);
            }    
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
                star = (star / 5)/2;
                if (star > 5) star = 5;
                while(star != 0)
                {
                    PictureBox pic = new PictureBox();
                    pic.Width = 50;
                    pic.Height = 45;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    using (FileStream stream = new FileStream("../../Images/icons/star.png", FileMode.Open))
                    {
                        Image image = Image.FromStream(stream);
                        pic.Image = image;
                    }
                    star--;
                    flowLayoutPanel1.Controls.Add(pic);
                }    
            }
            else
            {
                txtName.Text = hh.tenhh;
                txtPrice.Text = hh.dongia.ToString("N2");
                txtQuantityLeft.Text = "10";
                txtQuantitySold.Text = "1";
                PictureBox pic = new PictureBox();
                pic.Width = 50;
                pic.Height = 45;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                using (FileStream stream = new FileStream("../../Images/icons/star.png", FileMode.Open))
                {
                    Image image = Image.FromStream(stream);
                    pic.Image = image;
                }
                flowLayoutPanel1.Controls.Add(pic);
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
                MessageBox.Show("Thêm món thất bại", "Thông báo");
                return;
            }
            MessageBox.Show("Thêm món thành công", "Thông báo");
            this.Close();
        }
    }
}
    