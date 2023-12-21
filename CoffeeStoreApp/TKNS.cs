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
    public partial class TKNS : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=QL_CAFE1;Integrated Security=True");
        public TKNS()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;


                cmd.CommandText = "select * from NHANVIEN";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string[] row = { dr["manv"].ToString(), dr["tennv"].ToString(), dr["chucvu"].ToString(), dr["phanquyen"].ToString(), dr["matkhau"].ToString() };


                    if (dr["chucvu"].ToString() == "Nhân viên")
                    {
                        listView1.Items.Add(new ListViewItem(row));
                    }
                    else
                    {
                        listView2.Items.Add(new ListViewItem(row));
                    }
                }
                dr.Close();
            }
            finally
            {
                conn.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string ten = textBox2.Text;
                string sdt = textBox3.Text;
                string email = textBox4.Text;
                string diaChi = textBox5.Text;
                string chucVu = textBox6.Text;
                string matKhau = textBox7.Text;
                string ngayVaoLam = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
                string phanQuyen = textBox8.Text;
                string maQuanLy = textBox9.Text;


                conn.Open();
                string sqlInsert = "insert into NHANVIEN(tennv, sdt, email,diachi,chucvu, ngayvaolam, matkhau, maquanly, phanquyen) values(@ten, @sdt, @email, @diachi, @chucvu, @ngayvaolam, @matkhau, @maquanly, @phanquyen)";
                SqlCommand cmd = new SqlCommand(sqlInsert, conn);
                cmd.Parameters.AddWithValue("@ten", ten);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@diachi", diaChi);
                cmd.Parameters.AddWithValue("@chucvu", chucVu);
                cmd.Parameters.AddWithValue("@ngayvaolam", ngayVaoLam);
                cmd.Parameters.AddWithValue("@matkhau", matKhau);
                cmd.Parameters.AddWithValue("@phanquyen", phanQuyen);
                cmd.Parameters.AddWithValue("@maquanly", maQuanLy);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string[] row = { dr["manv"].ToString(), dr["tennv"].ToString(), dr["chucvu"].ToString(), dr["phanquyen"].ToString(), dr["matkhau"].ToString() };


                    if (dr["chucvu"].ToString() == "Nhân viên")
                    {
                        listView1.Items.Add(new ListViewItem(row));
                    }
                    else
                    {
                        listView2.Items.Add(new ListViewItem(row));
                    }

                }
                dr.Close();
                listView1.Items.Clear();
                listView2.Items.Clear();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Thêm...");
                listView1.Items.Clear();
            }
            finally
            {
                LoadData();
            }
        }
        
        
        public void loadUser(string ma)
        {
           
            conn.Open();
            string sql = "select * from NHANVIEN where manv=@v1";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@v1", ma);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                textBox2.Text = dr["tennv"].ToString();
                textBox3.Text = dr["sdt"].ToString();
                textBox4.Text = dr["email"].ToString();
                textBox5.Text = dr["diachi"].ToString();
                textBox6.Text = dr["chucvu"].ToString();
                textBox7.Text = dr["matkhau"].ToString();
                textBox8.Text = dr["phanquyen"].ToString();
                textBox9.Text = dr["maquanly"].ToString();
                textBox10.Text = dr["manv"].ToString();
                string dateString = dr["ngayvaolam"].ToString();

               
                DateTime date = DateTime.Parse(dateString);


                monthCalendar1.SelectionStart = date;
                monthCalendar1.SelectionEnd = date;
                conn.Close();

            }
        }

        private void listView2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            foreach (ListViewItem i in listView2.SelectedItems)
            {
                string ma = i.SubItems[0].Text;
                loadUser(ma);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem i in listView1.SelectedItems)
            {
                string ma = i.SubItems[0].Text;
                loadUser(ma);
            }
        }
        private void deleteUser(string id)
        {
           
            conn.Open();
            string sqlDelete = "delete from NHANVIEN where manv=@v1";
            SqlCommand cmd = new SqlCommand(sqlDelete, conn);
            cmd.Parameters.AddWithValue("@v1", textBox10.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteUser(textBox10.Text);
            listView1.Items.Clear();
            listView2.Items.Clear();
            LoadData();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
        }
        public void updateNhanVien(string ma,string ten, string sdt, string email, string diaChi, string chucVu, string matKhau, string ngayVaoLam, string maQuanLy, string phanQuyen)
        {
            conn.Open();
            string sqlUpdate = "update NHANVIEN set tennv = @v2, sdt= @v3, email = @v4, diachi=@v5, chucvu = @v6, ngayvaolam = @v7, matkhau = @v8, maquanly = @v9, phanquyen = @v10 where manv = @v1";
            SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
            cmd.Parameters.AddWithValue("@v1", ma);
            cmd.Parameters.AddWithValue("@v2", ten);
            cmd.Parameters.AddWithValue("@v3", sdt);
            cmd.Parameters.AddWithValue("@v4", email);
            cmd.Parameters.AddWithValue("@v5", diaChi);
            cmd.Parameters.AddWithValue("@v6", chucVu);
            cmd.Parameters.AddWithValue("@v7", ngayVaoLam);
            cmd.Parameters.AddWithValue("@v8", matKhau);
            cmd.Parameters.AddWithValue("@v9", maQuanLy);
            cmd.Parameters.AddWithValue("@v10", phanQuyen);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateNhanVien(textBox10.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"), textBox9.Text, textBox8.Text);
            listView1.Items.Clear();
            listView2.Items.Clear();
            LoadData();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ma = textBox10.Text;
            conn.Open();
            string sqlSearch = "select * from NhanVien where manv = @ma";
            SqlCommand cmd = new SqlCommand(sqlSearch, conn);
            cmd.Parameters.AddWithValue("@ma", ma);
            SqlDataReader dr = cmd.ExecuteReader();
            listView1.Items.Clear();
            listView2.Items.Clear();
            while (dr.Read())
            {
                string[] row = { dr["manv"].ToString(), dr["tennv"].ToString(), dr["chucvu"].ToString(), dr["phanquyen"].ToString(), dr["matkhau"].ToString() };


                if (dr["chucvu"].ToString() == "Nhân viên")
                {
                    listView1.Items.Add(new ListViewItem(row));
                }
                else
                {
                    listView2.Items.Add(new ListViewItem(row));
                }

            }
            textBox10.Clear();
            conn.Close();
        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
