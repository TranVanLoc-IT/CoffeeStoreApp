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
    public partial class TableHandle : Form
    {
        private Data _data = new Data();
        public static int empty { get; set; }
        public static int inuse { get; set; }
        public TableHandle()
        {
            InitializeComponent();
        }

        private void TableHandle_Load(object sender, EventArgs e)
        {
            empty = _data.db.BANs.Count();
            foreach(var t in _data.db.HOADONs.Where(itm => itm.maban != null).ToList())
            {
                inuse += 1;
                BillHandle handle = new BillHandle();
                handle.txtBillCode.Text = t.mahd;
                handle.txtTableCode.Text = t.maban;
                foreach(var ct in _data.db.CHITIETHDs.Where(itm => itm.mahd == t.mahd).ToList())
                {
                    handle.txtSP.Text += ct.HANGHOA.tenhh + "x" + ct.soluong.ToString();
                }
                handle.btnTable.Name = t.mahd;
                handle.btnTable.Click += TableHandle_Click;
                flowLayoutPanel1.Controls.Add(handle);
            }
            empty -= inuse;
            txtEmptyTable.Text = empty.ToString();
            txtTableUsing.Text = inuse.ToString();
        }

        private void TableHandle_Click(object sender, EventArgs e)
        {
            string mahd = (sender as Button).Name;
            foreach (var control in flowLayoutPanel1.Controls)
            {
                BillHandle handle = control as BillHandle;
                if(handle.btnTable.Name == mahd)
                {
                    flowLayoutPanel1.Controls.Remove(handle);
                    _data.UpdateTableStatus(mahd);
                    break;
                }    
            }
            --inuse;
            ++empty;
            txtEmptyTable.Text = empty.ToString();
            txtTableUsing.Text = inuse.ToString();
        }

        private void btnClearTable_Click(object sender, EventArgs e)
        {
            foreach (var control in flowLayoutPanel1.Controls)
            {
                BillHandle handle = control as BillHandle;
                flowLayoutPanel1.Controls.Remove(handle);
                --inuse;
                ++empty;
                _data.UpdateTableStatus(handle.btnTable.Name);
            }
            MessageBox.Show("Tất cả bàn đã trống", "Thông báo");
            
            txtEmptyTable.Text = empty.ToString();
            txtTableUsing.Text = inuse.ToString();
        }
    }
}
