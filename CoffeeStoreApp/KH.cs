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
    public partial class KH : Form
    {
        QL_CAFEEntities db = new QL_CAFEEntities();
        public KH()
        {
            InitializeComponent();
        }


        private void bt_find_KH_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming you want to search for a customer based on some criteria, let's say the customer name.
                string searchTerm = tb_find_KH.Text.Trim(); // Assuming you have a TextBox named tb_search for the search term.


                var query = from kh in db.KHACHHANGs
                            where kh.tenkh.Contains(searchTerm) || kh.makh.Contains(searchTerm)// Adjust the condition based on your search criteria
                            select kh;
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã KH");
                dt.Columns.Add("Tên KH");
                dt.Columns.Add("SĐT");
                dt.Columns.Add("Email");
                dt.Columns.Add("Địa chỉ");
                dt.Columns.Add("Mã loại KH");
                dt.Columns.Add("Điểm tích lũy");

                foreach (var kh in query)
                {
                    dt.Rows.Add(kh.makh, kh.tenkh, kh.sdt, kh.email, kh.diachi, kh.maloaikh, kh.diemtichluy);
                }

                dgv_list_KH.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                var query = from kh in db.KHACHHANGs
                            select kh;
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã KH");
                dt.Columns.Add("Tên KH");
                dt.Columns.Add("SĐT");
                dt.Columns.Add("Email");
                dt.Columns.Add("Địa chỉ");
                dt.Columns.Add("Mã loại KH");
                dt.Columns.Add("Điểm tích lũy");

                foreach (var kh in query)
                {
                    dt.Rows.Add(kh.makh, kh.tenkh, kh.sdt, kh.email, kh.diachi, kh.maloaikh, kh.diemtichluy);
                }

                dgv_list_KH.DataSource = dt;
                dgv_list_KH.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void KH_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_list_KH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            tb_maKH.Text = dgv_list_KH.Rows[numrow].Cells[0].Value.ToString();
            tb_tenKH.Text = dgv_list_KH.Rows[numrow].Cells[1].Value.ToString();
            tb_sdt_KH.Text = dgv_list_KH.Rows[numrow].Cells[2].Value.ToString();
            tb_email_KH.Text = dgv_list_KH.Rows[numrow].Cells[3].Value.ToString();
            tb_dc_KH.Text = dgv_list_KH.Rows[numrow].Cells[4].Value.ToString();
            tb_loai_KH.Text = dgv_list_KH.Rows[numrow].Cells[5].Value.ToString();
            txtdiem.Text = dgv_list_KH.Rows[numrow].Cells[6].Value.ToString();
        }
        private void ThemKhachHang(KHACHHANG khachHang)
        {
            try
            {
                // Thêm khách hàng vào cơ sở dữ liệu
                db.KHACHHANGs.Add(khachHang);
                db.SaveChanges();

                // Làm mới dữ liệu
                LoadData();
                MessageBox.Show("Thêm khách hàng thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message);
            }
        }

        private void XoaKhachHang(string maKH)
        {
            try
            {
                // Tìm khách hàng cần xóa
                var khachHang = db.KHACHHANGs.FirstOrDefault(kh => kh.makh == maKH);

                if (khachHang != null)
                {
                    // Xóa khách hàng khỏi cơ sở dữ liệu
                    db.KHACHHANGs.Remove(khachHang);
                    db.SaveChanges();

                    // Làm mới dữ liệu
                    LoadData();
                    MessageBox.Show("Xóa khách hàng thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng có mã " + maKH);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message);
            }
        }


        private void SuaKhachHang(KHACHHANG khachHang)
        {
            try
            {
                // Tìm khách hàng cần sửa
                var khachHangSua = db.KHACHHANGs.FirstOrDefault(kh => kh.makh == khachHang.makh);

                if (khachHangSua != null)
                {
                    // Cập nhật thông tin khách hàng
                    khachHangSua.tenkh = khachHang.tenkh;
                    khachHangSua.sdt = khachHang.sdt;
                    khachHangSua.email = khachHang.email;
                    khachHangSua.diachi = khachHang.diachi;
                    khachHangSua.maloaikh = khachHang.maloaikh;
                    khachHangSua.diemtichluy = khachHang.diemtichluy;

                    db.SaveChanges();

                    // Làm mới dữ liệu
                    LoadData();
                    MessageBox.Show("Sửa thông tin khách hàng thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng có mã " + khachHang.makh);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa thông tin khách hàng: " + ex.Message);
            }
        }
        private void bt_add_KH_Click(object sender, EventArgs e)
        {
            KHACHHANG khachHang = new KHACHHANG
            {
                makh = tb_maKH.Text,
                tenkh = tb_tenKH.Text,
                sdt = tb_sdt_KH.Text,
                email = tb_email_KH.Text,
                diachi = tb_dc_KH.Text,
                maloaikh = tb_loai_KH.Text,
                diemtichluy = Convert.ToInt32(txtdiem.Text) // Giả sử điểm tích lũy là kiểu số nguyên
            };

            // Gọi hàm thêm khách hàng
            ThemKhachHang(khachHang);
        }

        private void bt_update_KH_Click(object sender, EventArgs e)
        {
            KHACHHANG khachHangSua = new KHACHHANG
            {
                makh = tb_maKH.Text,
                tenkh = tb_tenKH.Text,
                sdt = tb_sdt_KH.Text,
                email = tb_email_KH.Text,
                diachi = tb_dc_KH.Text,
                maloaikh = tb_loai_KH.Text,
                diemtichluy = Convert.ToInt32(txtdiem.Text) // Giả sử điểm tích lũy là kiểu số nguyên
            };

            // Gọi hàm sửa khách hàng
            SuaKhachHang(khachHangSua);
        }

        private void bt_clear_KH_Click(object sender, EventArgs e)
        {
            string maKhachHangXoa = tb_maKH.Text;

            // Gọi hàm xóa khách hàng
            XoaKhachHang(maKhachHangXoa);
        }

        private void bt_out_KH_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
