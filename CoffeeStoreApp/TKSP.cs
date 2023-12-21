using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCAFE
{
    public partial class TKSP : Form
    {
        public TKSP()
        {
            InitializeComponent();
            chart2.Titles.Add("Số lượng đã bán của từng sản phẩm");
            SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=QL_CAFE1;Integrated Security=True");
            SqlDataAdapter ad = new SqlDataAdapter("select tenhh, sldaban  from KIEMKE, HANGHOA where KIEMKE.mahh = HANGHOA.mahh", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            chart2.DataSource = dt;
            chart2.Series["Series2"].XValueMember = "tenhh";
            chart2.Series["Series2"].YValueMembers = "sldaban";
            chart2.Series["Series2"].IsVisibleInLegend = true;
            comboBox1.Items.Add("Năm");
            comboBox1.Items.Add("Tháng");

        }

        private void chart1_Enter(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=QL_CAFE1;Integrated Security=True");
            SqlDataAdapter ad = new SqlDataAdapter("SELECT COUNT(MAKH) AS SLKH, YEAR(NGAYLAP) AS NAM   FROM HOADON GROUP BY YEAR(ngaylap)", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            chart1.DataSource = dt;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Năm";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số Lượng Khách Hàng";

            chart1.Series["Series1"].XValueMember = "NAM";
            chart1.Series["Series1"].YValueMembers = "SLKH";
            label1.Text = "Biểu đồ thể hiện số lượng khách hàng đã mua ở mỗi năm";
        }

        private void chart2_Enter(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=QL_CAFE1;Integrated Security=True");
           
            if (comboBox1.SelectedItem.ToString().Equals("Năm"))
            {
                SqlDataAdapter ad = new SqlDataAdapter("SELECT COUNT(MAKH) AS SLKH, YEAR(NGAYLAP) AS NAM  FROM HOADON GROUP BY YEAR(ngaylap)", conn);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                chart1.DataSource = dt;
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Năm";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số Lượng Khách Hàng";

                chart1.Series["Series1"].XValueMember = "NAM";
                chart1.Series["Series1"].YValueMembers = "SLKH";
                label1.Text = "Biểu đồ thể hiện số lượng khách hàng đã mua ở mỗi năm";
            }
            else
            {
                SqlDataAdapter ad = new SqlDataAdapter("SELECT COUNT(MAKH) AS SLKH, MONTH(ngaylap) AS THANG  FROM HOADON GROUP BY  MONTH(ngaylap)", conn);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                chart1.DataSource = dt;
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số Lượng Khách Hàng";

                chart1.Series["Series1"].XValueMember = "THANG";
                chart1.Series["Series1"].YValueMembers = "SLKH";
                label1.Text = "Biểu đồ thể hiện số lượng khách hàng đã mua theo tháng";
            }
        }
    }
}
