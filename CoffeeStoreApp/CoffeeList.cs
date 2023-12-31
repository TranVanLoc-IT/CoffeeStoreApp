﻿using System;
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
        private static List<CoffeeCard> allCfs { get; set; } = new List<CoffeeCard>();

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
                allCfs.Add(card);
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
      

        private void CoffeeList_Load(object sender, EventArgs e)
        {
            cbFilter.Items.AddRange(data.db.LOAIHANGHOAs.Select(itm => itm.tenloai).Distinct().ToArray());
            LoadHotCfs();
            LoadAllCfs();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string textSelection = cbFilter.GetItemText(cbFilter.SelectedItem);
            List<string> newListHH = new List<string>();
            newListHH = data.db.HANGHOAs.Where(itm => itm.LOAIHANGHOA.tenloai.Equals(textSelection)).Select(itm => itm.tenhh).ToList();
            flowLayoutAll.Controls.Clear();
            foreach (var card in allCfs)
            {
                if(newListHH.Contains(card.txtName.Text))
                    flowLayoutAll.Controls.Add(card);
            }
        }
    }
}
