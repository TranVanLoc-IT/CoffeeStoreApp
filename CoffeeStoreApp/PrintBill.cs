using CrystalDecisions.CrystalReports.Engine;
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
    public partial class PrintBill : Form
    {
        Data d = new Data();
        private HOADON _hd { get; set; }
        private List<BillPrinterInfo> _lhh { get; set; }
        public double moneyRecieve { get; set; }
        public double change { get; set; }
        private KHACHHANG _kh { get; set; }
        public PrintBill(HOADON hd, KHACHHANG kh, List<CartDTO> lhh, double moneyRecieve, double change)
        {
            this._hd = hd;
            this._kh = kh;
            this._lhh = lhh.Select(itm => new BillPrinterInfo { dongia = itm.tongtien, soluong = itm.soluong, tenhh = itm.ten }).ToList();
            this.change = change;
            this.moneyRecieve = moneyRecieve;
            InitializeComponent();
        }
        public PrintBill()
        {
            InitializeComponent();
        }
        private string Convert(int num)
        {
            switch (num)
            {
                case 1:
                    return "Một ";
                case 2:
                    return "Hai ";
                case 3:
                    return "Ba ";
                case 4:
                    return "Bốn ";
                case 5:
                    return "Năm ";
                case 6:
                    return "Sáu ";
                case 7:
                    return "Bảy ";
                case 8:
                    return "Tám ";
                case 9:
                    return "Chín ";
                default:
                    return "Mười ";
            }
        }
        private string ConvertPos(int num)
        {
            switch (num)
            {
                case 2:
                    return "mươi ";
                case 3:
                    return "trăm ";
                case 4:
                    return "nghìn ";
                case 5:
                    return "mươi ";
                case 6:
                    return "trăm ";
                case 7:
                    return "triệu ";
                default:
                    return "";
            }
        }
        private string NumberToString(double number)
        {
            string str = number.ToString();
            int len = str.Length;
            string result = "";
            result += Convert(int.Parse(str[0].ToString()));
            result += ConvertPos(len);
            for (int i = 1; i < len; i++)
            {
                int flag = 0;
                
                if (str[i] != '0')
                {   if (str[i] == '5')
                    {
                        result += " lăm ";
                    }
                    else
                    {
                        result += Convert(int.Parse(str[i].ToString()));
                    }
                    flag = 1;
                }
                if (flag == 1)
                {
                    result += ConvertPos(len - i);
                    flag = 0;
                }
            }
            return result;
        }
        private void PrintBill_Load(object sender, EventArgs e)
        {

            BillRpt rpt = new BillRpt();

            CrystalDecisions.CrystalReports.Engine.TextObject txtReportRecieve;
            txtReportRecieve = rpt.ReportDefinition.ReportObjects["tiennhan"] as TextObject;
            txtReportRecieve.Text = this.moneyRecieve.ToString();

            CrystalDecisions.CrystalReports.Engine.TextObject txtReportStaff;
            txtReportStaff = rpt.ReportDefinition.ReportObjects["staff"] as TextObject;
            txtReportStaff.Text = d.db.NHANVIENs.Where(i => i.manv == _hd.manv).Select(i => i.tennv).First();

            CrystalDecisions.CrystalReports.Engine.TextObject txtReportChange;
            txtReportChange = rpt.ReportDefinition.ReportObjects["tientra"] as TextObject;
            txtReportChange.Text = this.change.ToString();

            CrystalDecisions.CrystalReports.Engine.TextObject txtReportBillCode;
            txtReportBillCode = rpt.ReportDefinition.ReportObjects["mahd"] as TextObject;
            txtReportBillCode.Text = _hd.mahd;

            CrystalDecisions.CrystalReports.Engine.TextObject txtReportDateset;
            txtReportDateset = rpt.ReportDefinition.ReportObjects["ngaylap"] as TextObject;
            txtReportDateset.Text = _hd.ngaylap.ToShortDateString();

            CrystalDecisions.CrystalReports.Engine.TextObject txtReportTable;
            txtReportTable = rpt.ReportDefinition.ReportObjects["table"] as TextObject;
            if (_hd.BAN?.maban != null)
                txtReportTable.Text = _hd.BAN.tenban;
            txtReportTable.Text = "";
            CrystalDecisions.CrystalReports.Engine.TextObject txtReportMoneyString;
            txtReportMoneyString = rpt.ReportDefinition.ReportObjects["totalMoneyString"] as TextObject;
            txtReportMoneyString.Text = NumberToString(_hd.tongtien);


            rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4Small;
            rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            try
            {
                // not use using keyword, it's will use dispose when go out
                rpt.SetDataSource(_lhh);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Show();


        }
    }
}
