﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
<<<<<<< HEAD
//using MongoDB.Driver;
=======
using MongoDB.Driver;
>>>>>>> a419a1e68aea5648f7664307760934e7a588ec79
namespace CoffeeStoreApp
{
    public partial class BillInfo : Form
    {
        private Data data = new Data();

        private static string maban;

        public HOADON hd { get; set; }

        public event Action<string> FormClosingEvent;
        
        public List<CartDTO> cfs { get; set; }

        public int flag { get; set; }
        public KHACHHANG kh { get; set; }

        public BillInfo(HOADON hd,KHACHHANG kh, List<CartDTO> cfs)
        {
            this.hd = hd;
            this.cfs = cfs;
            this.kh = kh;
            this.hd.makh = hd.makh;
            InitializeComponent();
        }
        public BillInfo()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        //private void FormClosed(string buttonName)
        //{
        //    // nextstep
        //    //FormClosingEvent?.Invoke(buttonName);
        //    //Close();
        //}    
        private void BillInfo_Load(object sender, EventArgs e)
        {
            //var emptytable = data.GetEmptyTables();
            //foreach(var ban in emptytable)
            //{
            //    TableCard table = new TableCard();
            //    table.btnTable.BackColor = System.Drawing.Color.GreenYellow;
            //    table.btnTable.Text = ban.tenban + " - " + ban.KHUVUC.tenkv;
            //    table.btnTable.Name = ban.maban;
            //    table.btnTable.Click += btnTable_Click;
            //    panelTable.Controls.Add(table);
            //}    
            //if(cfs.Count() > 1)
            //{
            //    hd.tongtien = cfs[0].tongtien;
            //}
            //else
            //{
            //    hd.tongtien = cfs.Select(itm => itm.tongtien).Sum();
            //}
            //txtTotalMoney.Text = hd.tongtien.ToString("N2");
            //txtCustomerName.Text = kh.tenkh;
            //txtVAT.Text = (hd.tongtien * 0.2).ToString("N2");

            //hd.mahd = data.GenerateBillCode();
            //hd.makh = kh.makh;
            //txtBillCode.Text = hd.mahd;
            //if(string.IsNullOrEmpty(hd.mahd))
            //{
            //    MessageBox.Show("Vui lòng thử lại", "Lỗi");
            //}    
            //hd.ngaylap = DateTime.Now;
        }
        private void btnTable_Click(object sender, EventArgs e)
        {
            //maban = (sender as Button).Name;
            //foreach(var t in panelTable.Controls)
            //{
            //    if(t is Button table)
            //    {
            //        if (table.Name.Equals(maban))
            //        {
            //            table.BackColor = System.Drawing.Color.Red;
            //            break;
            //        }
            //    }
            //}    

            //txtTableCode.Text = maban;
        }
        private void ClearCart()
        {
            //MongoClient client = new MongoClient(@"mongodb://127.0.0.1:27017");

            //var database = client.GetDatabase("CoffeeDB");
            //var collection = database.GetCollection<CartDTO>("cart");

            //var result = collection.DeleteMany(Builders<CartDTO>.Filter.Empty);
            //if(result.DeletedCount != 0)
            //{
            //    MessageBox.Show("Hoàn tất thanh toán");
            //}    
        }
        private void btnBill_Click(object sender, EventArgs e)
        {
            //List<CHITIETHD> cthds = new List<CHITIETHD>();
            //if(!string.IsNullOrEmpty(maban))
            //{
            //    hd.maban = maban;
            //}    
            //foreach(var i in cfs)
            //{
            //    CHITIETHD cthd = new CHITIETHD();
            //    cthd.mahd = hd.mahd;
            //    cthd.mahh = i.id;
            //    cthd.soluong = i.soluong;
            //    cthd.thanhtien = decimal.Parse(i.tongtien.ToString());
            //    cthds.Add(cthd);
            //}
            //Console.WriteLine($"{hd.mahd}-{hd.manv}-{hd.makh}-{hd.tongtien}-{hd.maban}-{hd.ngaylap}");
            //foreach(var i in cthds)
            //{
            //    Console.WriteLine($"{i.mahd}-{i.mahh}-{i.soluong}");
            //}    
            //if(data.AddBill(hd, cthds))
            //{
            //    MessageBox.Show("Thanh toán Thành công", "Thông báo");
            //    flag = 1;
            //    ClearCart();
            //}
            //else
            //{
            //    MessageBox.Show("Thanh toán Thất bại", "Thông báo");
            //}
=======
        private void FormClosed(string buttonName)
        {
            // nextstep
            FormClosingEvent?.Invoke(buttonName);
            Close();
        }    
        private void BillInfo_Load(object sender, EventArgs e)
        {
            var emptytable = data.GetEmptyTables();
            foreach(var ban in emptytable)
            {
                TableCard table = new TableCard();
                table.btnTable.BackColor = System.Drawing.Color.GreenYellow;
                table.btnTable.Text = ban.tenban + " - " + ban.KHUVUC.tenkv;
                table.btnTable.Name = ban.maban;
                table.btnTable.Click += btnTable_Click;
                panelTable.Controls.Add(table);
            }    
            if(cfs.Count() > 1)
            {
                hd.tongtien = cfs[0].tongtien;
            }
            else
            {
                hd.tongtien = cfs.Select(itm => itm.tongtien).Sum();
            }
            txtTotalMoney.Text = hd.tongtien.ToString("N2");
            txtCustomerName.Text = kh.tenkh;
            txtVAT.Text = (hd.tongtien * 0.2).ToString("N2");

            hd.mahd = data.GenerateBillCode();
            hd.makh = kh.makh;
            txtBillCode.Text = hd.mahd;
            if(string.IsNullOrEmpty(hd.mahd))
            {
                MessageBox.Show("Vui lòng thử lại", "Lỗi");
            }    
            hd.ngaylap = DateTime.Now;
        }
        private void btnTable_Click(object sender, EventArgs e)
        {
            maban = (sender as Button).Name;
            foreach(var t in panelTable.Controls)
            {
                if(t is Button table)
                {
                    if (table.Name.Equals(maban))
                    {
                        table.BackColor = System.Drawing.Color.Red;
                        break;
                    }
                }
            }    

            txtTableCode.Text = maban;
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
            if(!string.IsNullOrEmpty(maban))
            {
                hd.maban = maban;
            }    
            foreach(var i in cfs)
            {
                CHITIETHD cthd = new CHITIETHD();
                cthd.mahd = hd.mahd;
                cthd.mahh = i.id;
                cthd.soluong = i.soluong;
                cthd.thanhtien = decimal.Parse(i.tongtien.ToString());
                cthds.Add(cthd);
            }
            Console.WriteLine($"{hd.mahd}-{hd.manv}-{hd.makh}-{hd.tongtien}-{hd.maban}-{hd.ngaylap}");
            foreach(var i in cthds)
            {
                Console.WriteLine($"{i.mahd}-{i.mahh}-{i.soluong}");
            }    
            if(data.AddBill(hd, cthds))
            {
                MessageBox.Show("Thanh toán Thành công", "Thông báo");
                flag = 1;
                ClearCart();
            }
            else
            {
                MessageBox.Show("Thanh toán Thất bại", "Thông báo");
            }
>>>>>>> a419a1e68aea5648f7664307760934e7a588ec79
        }

        private void btnCancelTable_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            //    foreach (var t in panelTable.Controls)
            //    {
            //        if (t is Button table)
            //        {
            //            if (table.Name.Equals(maban))
            //            {
            //                table.BackColor = System.Drawing.Color.GreenYellow;
            //                break;
            //            }    
            //        }
            //    }
            //    txtTableCode.Text = "";
            //    maban = string.Empty;
            //}
=======
            foreach (var t in panelTable.Controls)
            {
                if (t is Button table)
                {
                    if (table.Name.Equals(maban))
                    {
                        table.BackColor = System.Drawing.Color.GreenYellow;
                        break;
                    }    
                }
            }
            txtTableCode.Text = "";
            maban = string.Empty;
>>>>>>> a419a1e68aea5648f7664307760934e7a588ec79
        }
    }
}
