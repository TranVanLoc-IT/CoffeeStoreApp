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
    public partial class Details : Form
    {
        private Data data = new Data();
        public string idhh { get; set; }
        public int mode { get; set; }
        public Details(NHANVIEN nv, string idhh, int f)
        {
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
            // sure
            if(hh != null)
            {
                txtName.Text = hh.tenhh;
                txtPrice.Text = hh.dongia.ToString("N2");
                txtQuantityLeft.Text = inventory.slconlai.ToString();
                txtQuantitySold.Text = inventory.sldaban.ToString();
            }
            else
            {

            } 
        }

        private void btnToCart_Click(object sender, EventArgs e)
        {

        }
    }
}
    