﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CoffeeStoreApp
{
    public partial class StatisticIncome : Form
    {
        private Data _data = new Data();
        public StatisticIncome()
        {
            InitializeComponent();
        }

        private void StatisticIncome_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            cbStatisticTimeOptions.SelectedIndex = 0;
            var getMonths = _data.db.HOADONs.Select(itm => itm.ngaylap.Month).ToList();

            cbStatisticTimeOptions.Items.AddRange(getMonths.Distinct().Select(itm => "Tháng " + itm).ToArray());
=======
            
>>>>>>> a419a1e68aea5648f7664307760934e7a588ec79
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chartIncome.Series.Clear();
            chartIncome.Titles.Clear();
            chartIncome.ChartAreas.Clear();
            if (txtCfIdOrTypeStatistic.TextLength == 5)
            {
<<<<<<< HEAD
=======
                cbStatisticTimeOptions.SelectedIndex = 0;
                var hht = _data.db.CHITIETHDs.Where(itm => itm.mahh == txtCfIdOrTypeStatistic.Text).Select(itm => itm.mahd).ToList();
                var getMonths = _data.db.HOADONs.Where(itm => hht.Contains(itm.mahd)).Select(itm => itm.ngaylap.Month).ToList();

                cbStatisticTimeOptions.Items.AddRange(getMonths.Distinct().Select(itm => "Tháng " + itm).ToArray());
>>>>>>> a419a1e68aea5648f7664307760934e7a588ec79
                string getOption = cbStatisticTimeOptions.GetItemText(cbStatisticTimeOptions.SelectedItem);
                int month = DateTime.Now.Month;
                if (int.TryParse(getOption.Split(' ')[1], out month))
                {
                    // nothing to do
<<<<<<< HEAD
=======
                    MessageBox.Show(getOption.Split(' ')[1], getOption.Split(' ')[1]);
                    month = int.Parse(getOption.Split(' ')[1]);
>>>>>>> a419a1e68aea5648f7664307760934e7a588ec79
                }
                var income = from hd in _data.db.HOADONs
                             join cthd in _data.db.CHITIETHDs
                             on hd.mahd equals cthd.mahd
                             join hh in _data.db.HANGHOAs
                             on cthd.mahh equals hh.mahh
                             where cthd.mahh == txtCfIdOrTypeStatistic.Text && hd.ngaylap.Month == month ||
                             hh.maloaihh == txtCfIdOrTypeStatistic.Text && hd.ngaylap.Month == month
                             group hd by hd.ngaylap
                             into gr
                             select new { Key = gr.Key, tongtien = gr.Sum(itm => itm.tongtien), mahd = gr.Select(itm => itm.mahd) };
<<<<<<< HEAD
=======
                if(income == null)
                {
                    MessageBox.Show("Không có dữ liệu hiển thị!", "Lỗi");
                }    
>>>>>>> a419a1e68aea5648f7664307760934e7a588ec79
                ChartArea area = new ChartArea();
                area.AxisX.Title = "Thời gian";
                area.AxisY.Title = "Doanh thu";
                area.Position = new ElementPosition(5, 5, 90, 80);
                area.Position.Width = 100;
                area.Position.Height = 100;
                chartIncome.ChartAreas.Add(area);
                // series
                chartIncome.Series.Add("Income");
                chartIncome.Series.Add("QuantitySold");
                // setup
                chartIncome.Titles.Add("Doanh thu " + _data.db.HANGHOAs.Where(itm => itm.mahh == txtCfIdOrTypeStatistic.Text).Select(itm => itm.tenhh).First() + " tháng: " + month);
                foreach (var i in income)
                {
                    chartIncome.Series["Income"].Points.AddXY(i.Key, i.tongtien);
                    chartIncome.Series["QuantitySold"].Points.AddXY(i.Key, _data.db.CHITIETHDs.Where(itm => itm.mahd == i.mahd.FirstOrDefault()).Select(itm => itm.soluong).Sum());
                }
                lbSumOfCfSold.Text = income.Count().ToString();
<<<<<<< HEAD
                lbTotalIncome.Text = income.Select(itm => itm.tongtien).Sum().ToString();
            }    
        }
=======
                lbTotalIncome.Text = income.Select(itm => itm.tongtien)?.Sum().ToString();
            }    
        }

        private void txtCfIdOrTypeStatistic_TextChanged(object sender, EventArgs e)
        {
            if (txtCfIdOrTypeStatistic.TextLength == 5)
            {
                cbStatisticTimeOptions.SelectedIndex = 0;
                var hht = _data.db.CHITIETHDs.Where(itm => itm.mahh == txtCfIdOrTypeStatistic.Text).Select(itm => itm.mahd).ToList();
                var getMonths = _data.db.HOADONs.Where(itm => hht.Contains(itm.mahd)).Select(itm => itm.ngaylap.Month).ToList();

                cbStatisticTimeOptions.Items.AddRange(getMonths.Distinct().Select(itm => "Tháng " + itm).ToArray());
            }
        }
>>>>>>> a419a1e68aea5648f7664307760934e7a588ec79
    }
}
