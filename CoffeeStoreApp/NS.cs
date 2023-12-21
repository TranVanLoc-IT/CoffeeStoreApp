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
    public partial class NS : Form
    {
        QL_CAFEEntities db = new QL_CAFEEntities();
        public NS()
        {
            InitializeComponent();
        }

        private void bt_find_NV_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming you want to search for a customer based on some criteria, let's say the customer name.
                string searchTerm = tb_find_NV.Text.Trim(); // Assuming you have a TextBox named tb_search for the search term.


                var query = from nv in db.NHANVIENs
                            where nv.tennv.Contains(searchTerm) || nv.manv.Contains(searchTerm)// Adjust the condition based on your search criteria
                            select nv;
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã NV");
                dt.Columns.Add("Tên NV");
                dt.Columns.Add("SĐT");
                dt.Columns.Add("Email");
                dt.Columns.Add("Địa chỉ");
                dt.Columns.Add("Chức vụ");
                dt.Columns.Add("Ngày vào làm");
                dt.Columns.Add("Mật khẩu");
                dt.Columns.Add("Mã quản lý");
                dt.Columns.Add("Phân quyền");


                foreach (var nv in query)
                {
                    dt.Rows.Add(nv.manv, nv.tennv, nv.sdt, nv.email, nv.diachi, nv.chucvu, nv.ngayvaolam, nv.matkhau, nv.maquanly, nv.phanquyen);

                }

                dgv_list_NV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void ThemNhanVien(NHANVIEN nhanVien)
        {
            try
            {
                // Thêm nhân viên vào cơ sở dữ liệu
                db.NHANVIENs.Add(nhanVien);
                db.SaveChanges();

                // Làm mới dữ liệu
                LoadData();
                MessageBox.Show("Thêm nhân viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message);
            }
        }
        private void XoaNhanVien(string maNV)
        {
            try
            {
                // Tìm nhân viên cần xóa
                var nhanVien = db.NHANVIENs.FirstOrDefault(nv => nv.manv == maNV);

                if (nhanVien != null)
                {
                    // Xóa nhân viên khỏi cơ sở dữ liệu
                    db.NHANVIENs.Remove(nhanVien);
                    db.SaveChanges();

                    // Làm mới dữ liệu
                    LoadData();
                    MessageBox.Show("Xóa nhân viên thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên có mã " + maNV);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message);
            }
        }


        private void SuaNhanVien(NHANVIEN nhanVien)
        {
            try
            {
                // Tìm nhân viên cần sửa
                var nhanVienSua = db.NHANVIENs.FirstOrDefault(nv => nv.manv == nhanVien.manv);

                if (nhanVienSua != null)
                {
                    // Cập nhật thông tin nhân viên
                    nhanVienSua.tennv = nhanVien.tennv;
                    nhanVienSua.sdt = nhanVien.sdt;
                    nhanVienSua.email = nhanVien.email;
                    nhanVienSua.diachi = nhanVien.diachi;
                    nhanVienSua.chucvu = nhanVien.chucvu;
                    nhanVienSua.ngayvaolam = nhanVien.ngayvaolam;
                    nhanVienSua.matkhau = nhanVien.matkhau;
                    nhanVienSua.maquanly = nhanVien.maquanly;
                    nhanVienSua.phanquyen = nhanVien.phanquyen;

                    db.SaveChanges();

                    // Làm mới dữ liệu
                    LoadData();
                    MessageBox.Show("Sửa thông tin nhân viên thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên có mã " + nhanVien.manv);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa thông tin nhân viên: " + ex.Message);
            }
        }

        private void bt_add_KH_Click(object sender, EventArgs e)
        {
            NHANVIEN nhanVien = new NHANVIEN
            {
                manv = txt_maNV.Text,
                tennv = txt_tenNV.Text,
                sdt = txt_sdtNV.Text,
                email = txt_emailNV.Text,
                diachi = txt_dcNV.Text,
                chucvu = txt_chucvu.Text,
                ngayvaolam = DateTime.Parse(dateTimePicker1.Text),
                matkhau = txt_matkhau.Text,
                maquanly = txt_maquanly.Text,
                phanquyen = txt_phanquyen.Text
            };

            // Gọi hàm thêm nhân viên
            ThemNhanVien(nhanVien);
        }

        private void bt_update_KH_Click(object sender, EventArgs e)
        {
            NHANVIEN nhanVienSua = new NHANVIEN
            {
                manv = txt_maNV.Text,
                tennv = txt_tenNV.Text,
                sdt = txt_sdtNV.Text,
                email = txt_emailNV.Text,
                diachi = txt_dcNV.Text,
                chucvu = txt_chucvu.Text,
                ngayvaolam = DateTime.Parse(dateTimePicker1.Text),
                matkhau = txt_matkhau.Text,
                maquanly = txt_maquanly.Text,
                phanquyen = txt_phanquyen.Text
            };

            // Gọi hàm sửa nhân viên
            SuaNhanVien(nhanVienSua);
        }

        private void bt_clear_KH_Click(object sender, EventArgs e)
        {
            string maNhanVienXoa = txt_maNV.Text;

            // Gọi hàm xóa nhân viên
            XoaNhanVien(maNhanVienXoa);
        }

        private void bt_out_KH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_list_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_maNV.Text = dgv_list_NV.Rows[numrow].Cells[0].Value.ToString();
            txt_tenNV.Text = dgv_list_NV.Rows[numrow].Cells[1].Value.ToString();
            txt_sdtNV.Text = dgv_list_NV.Rows[numrow].Cells[2].Value.ToString();
            txt_emailNV.Text = dgv_list_NV.Rows[numrow].Cells[3].Value.ToString();
            txt_dcNV.Text = dgv_list_NV.Rows[numrow].Cells[4].Value.ToString();
            txt_chucvu.Text = dgv_list_NV.Rows[numrow].Cells[5].Value.ToString();
            dateTimePicker1.Text = dgv_list_NV.Rows[numrow].Cells[6].Value.ToString();
            txt_matkhau.Text = dgv_list_NV.Rows[numrow].Cells[7].Value.ToString();
            txt_maquanly.Text = dgv_list_NV.Rows[numrow].Cells[8].Value.ToString();
            txt_phanquyen.Text = dgv_list_NV.Rows[numrow].Cells[9].Value.ToString();
        }

        private void NS_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                var query = from nv in db.NHANVIENs
                            select nv;
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã NV");
                dt.Columns.Add("Tên NV");
                dt.Columns.Add("SĐT");
                dt.Columns.Add("Email");
                dt.Columns.Add("Địa chỉ");
                dt.Columns.Add("Chức vụ");
                dt.Columns.Add("Ngày vào làm");
                dt.Columns.Add("Mật khẩu");
                dt.Columns.Add("Mã quản lý");
                dt.Columns.Add("Phân quyền");

                foreach (var nv in query)
                {
                    dt.Rows.Add(nv.manv, nv.tennv, nv.sdt, nv.email, nv.diachi, nv.chucvu, nv.ngayvaolam, nv.matkhau, nv.maquanly, nv.phanquyen);
                }

                dgv_list_NV.DataSource = dt;
                dgv_list_NV.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
