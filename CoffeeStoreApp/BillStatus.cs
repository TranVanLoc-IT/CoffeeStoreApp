﻿using System;
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
    public partial class BillStatus : Form
    {
        public HOADON hd { get; set; }
        public List<CartDTO> cfs { get; set; } = new List<CartDTO>();
        public double moneyRecieve { get; set; }
        public double change { get; set; }
        public KHACHHANG kh { get; set; }
        Data d = new Data();
        public BillStatus(HOADON hd, KHACHHANG kh, List<CartDTO> cfs, double change, double moneyRecieve)
        {
            this.hd = hd;
            this.kh = kh;
            this.change = change;
            this.moneyRecieve = moneyRecieve;
            this.cfs = cfs;
            InitializeComponent();
        }

        private void BillStatus_Load(object sender, EventArgs e)
        {
            foreach(var cf in cfs)
            {
                txtProductList.Text += $"{cf.ten} x {cf.soluong}\n";
            }
            int score = hd.tongtien > 200000 ? 20 : hd.tongtien < 100000 ? 10 : 5;
            txtScore.Text = $"{kh.diemtichluy} + {score}";
            txtStaffName.Text = d.db.NHANVIENs.Where(itm => itm.manv == hd.manv).Select(itm => itm.tennv).First();
            if (hd.maban != null)
                txtTable.Text = d.db.BANs.Where(i => i.maban == hd.maban).Select(i => i.tenban).First();
            tenkh.Text = kh.tenkh;
            dateSet.Text = hd.ngaylap.ToString();
            txtTotal.Text = hd.tongtien.ToString();
            txtBillCode.Text = hd.mahd;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintBill print = new PrintBill(hd, kh, cfs, moneyRecieve,change);
            print.ShowDialog();
        }
    }
}
