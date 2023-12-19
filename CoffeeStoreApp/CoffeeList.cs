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

namespace CoffeeStoreApp
{
    public partial class CoffeeList : Form
    {
        private Data data = new Data();
        private int _height { get; set; }
        private static List<HANGHOA> allCfs { get; set; } = new List<HANGHOA>();

        private NHANVIEN _nv { get; set; }
        public CoffeeList(NHANVIEN nv)
        {
            this._nv = nv;
            InitializeComponent();
        }


        private void LoadHotCfs()
        {
            var getHotSales = data.GetHotDrinkSales();

            foreach (var itm in getHotSales)
            {
                CoffeeCard card = new CoffeeCard();
                ImagePath path = new ImagePath();
                path._folder = "../../Images/coffees/";
                foreach (var img in path.collectAllImagePath())
                {
                    if (img.Contains(itm.mahh))
                    {
                        using (FileStream stream = new FileStream("../../Images/coffees/" + img, FileMode.Open))
                        {
                            Image image = Image.FromStream(stream);
                            card.pictureBox.Image = image;
                            card.btnViewProduct.Name = "btn_" + itm.mahh;
                            break;
                        }
                    }

                }

                card.txtName.Text = itm.tenhh;
                card.txtPrice.Text = itm.dongia.ToString();
                card.btnViewProduct.Click += ToDetails;
                flowLayoutHot.Controls.Add(card);
            }
        }
        private void LoadAllCfs()
        {
            var getBikes = data.db.HANGHOAs.ToList();
            foreach (var itm in getBikes)
            {
                CoffeeCard card = new CoffeeCard();
                ImagePath path = new ImagePath();
                path._folder = "../../Images/coffees/";
                foreach (var img in path.collectAllImagePath())
                {
                    if (img.Contains(itm.mahh))
                    {
                        using (FileStream stream = new FileStream("../../Images/coffees/" + img, FileMode.Open))
                        {
                            Image image = Image.FromStream(stream);
                            card.pictureBox.Image = image;
                            card.btnViewProduct.Name = "btn_" + itm.mahh;
                            break;
                        }
                    }

                }
                card.txtName.Text = itm.tenhh;
                card.txtPrice.Text = itm.dongia.ToString();
                card.btnViewProduct.Click += ToDetails;
                allCfs.Add(itm);
                flowLayoutAll.Controls.Add(card);
            }
        }


        private void ToDetails(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string[] cpns = btn.Name.Split('_');
            Details specs = new Details(_nv, cpns[1], 0);
            specs.ShowDialog();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string textSelection = cbFilter.GetItemText(cbFilter.SelectedItem);
            List<HANGHOA> newListHH = new List<HANGHOA>();
            newListHH = allCfs.Where(itm => itm.LOAIHANGHOA.tenloai.Equals(textSelection)).ToList();
            List<CoffeeCard> newListCard = new List<CoffeeCard>();
            foreach(HANGHOA itm in newListHH)
            {
                CoffeeCard card = new CoffeeCard();

                card.txtName.Text = itm.tenhh;
                card.txtPrice.Text = itm.dongia.ToString();
                card.btnViewProduct.Click += ToDetails;
                newListCard.Add(card);
            }    
            flowLayoutAll.Controls.Clear();
            flowLayoutAll.Controls.AddRange(newListCard.ToArray());
        }

        private void CoffeeList_Load(object sender, EventArgs e)
        {
            cbFilter.Items.AddRange(data.db.LOAIHANGHOAs.Select(itm => itm.tenloai).ToArray());
            LoadHotCfs();
            LoadAllCfs();
        }
    }
}
