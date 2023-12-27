using System;
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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chartIncome.Series.Clear();
            chartIncome.Titles.Clear();
            chartIncome.ChartAreas.Clear();
            if (txtCfIdOrTypeStatistic.TextLength == 5)
            {
                string getOptionM = cbStatisticTimeOptions.GetItemText(cbStatisticTimeOptions.SelectedItem);
                string getOptionY = cbyears.GetItemText(cbyears.SelectedItem);
                int month = DateTime.Now.Month;
                int year = DateTime.Now.Year;
                if (int.TryParse(getOptionM.Split(' ')[1], out month))
                {
                    // nothing to do
                    month = int.Parse(getOptionM.Split(' ')[1]);
                }
                if (int.TryParse(getOptionY.Split(' ')[1], out year))
                {
                    // nothing to do
                    year = int.Parse(getOptionY.Split(' ')[1]);
                }
                var income = from hd in _data.db.HOADONs
                             join cthd in _data.db.CHITIETHDs
                             on hd.mahd equals cthd.mahd
                             join hh in _data.db.HANGHOAs
                             on cthd.mahh equals hh.mahh
                             where cthd.mahh == txtCfIdOrTypeStatistic.Text && hd.ngaylap.Month == month
                             && hd.ngaylap.Year == year
                             group hd by hd.ngaylap
                             into gr
                             select new { Key = gr.Key, tongtien = gr.Sum(itm => itm.tongtien), mahd = gr.Select(itm => itm.mahd) };
                if(income == null)
                {
                    MessageBox.Show("Không có dữ liệu hiển thị!", "Lỗi");
                }    
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
                if(income.Count() > 10)
                {
                    chartIncome.Series["Income"].ChartType = SeriesChartType.FastLine;
                    chartIncome.Series["QuantitySold"].ChartType = SeriesChartType.FastLine;
                }    
                foreach (var i in income)
                {
                    chartIncome.Series["Income"].Points.AddXY(i.Key, i.tongtien);
                    chartIncome.Series["QuantitySold"].Points.AddXY(i.Key, _data.db.CHITIETHDs.Where(itm => itm.mahd == i.mahd.FirstOrDefault()).Select(itm => itm.soluong).Sum());
                }
                lbSumOfCfSold.Text = income.Count().ToString();
                lbTotalIncome.Text = income.Select(itm => itm.tongtien)?.Sum().ToString();
            }    
        }

        private void txtCfIdOrTypeStatistic_TextChanged(object sender, EventArgs e)
        {
            if (txtCfIdOrTypeStatistic.TextLength == 5)
            {
                var hht = _data.db.CHITIETHDs.Where(itm => itm.mahh == txtCfIdOrTypeStatistic.Text).Select(itm => itm.mahd).ToList();
                var getMonths = _data.db.HOADONs.Where(itm => hht.Contains(itm.mahd)).Select(itm => itm.ngaylap.Month).ToList();

                List<int> getYears = _data.db.HOADONs.Where(itm => hht.Contains(itm.mahd)).Select(itm => itm.ngaylap.Year).ToList();

                cbyears.Items.AddRange(getYears.Distinct().Select(itm => "Năm " + itm).ToArray());
                cbStatisticTimeOptions.Items.AddRange(getMonths.Distinct().Select(itm => "Tháng " + itm).ToArray());
            }
        }
    }
}
