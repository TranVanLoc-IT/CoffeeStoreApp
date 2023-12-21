using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using System.Data.SqlClient;
=======
>>>>>>> a419a1e68aea5648f7664307760934e7a588ec79

namespace CoffeeStoreApp
{
    public partial class KH : Form
    {
<<<<<<< HEAD
        private Data data = new Data();
        private KHACHHANG _kh { get; set; }
        public KH()
        {
            //this._kh = kh; 
            InitializeComponent();
        }
        void DSKhachHang()
        {
            Data db = new Data();
            string chuoi = "Select * from KHACHHANG";
            DataTable t = db.getDataTable(chuoi);
            dgvKh.DataSource = t;

            string chuoitruyvan = "Select * from LoaiKhachHang";
            DataTable dat = db.getDataTable(chuoitruyvan);
            DataRow drw = dat.NewRow();
            //drw["MaLKH"] = "All";
            //drw["TenLKH"] = "Tat ca cac loai khach";
            //dat.Rows.InsertAt(drw, 0);

            cboMaLoaiKhach.DataSource = dat;
            cboMaLoaiKhach.DisplayMember = "MaLoaiKH";
            cboMaLoaiKhach.ValueMember = "MaLoaiKH";
        }
        string TaoMaKhachHang()
        {
            string maKH = "KH";

            //Tìm trong bảng KhachHang có mã như mẫu

            string cauTV = "select top 1 * from KhachHang order by (MaKH) desc";
            Data db = new Data();
            DataTable dt = db.getDataTable(cauTV);
            string pn;
            pn = dt.Rows[0]["MaKH"].ToString();

            if (dt.Rows.Count > 0) // Đã có bàn
            {
                //Cắt 3 kí tự cuối chuyển sang số rồi cộng thêm 1               
                int stt = int.Parse(pn.Substring(2, 3)) + 1;

                //Bổ sung vào thêm cho đầy đủ ký tự
                if (stt < 10)
                {
                    maKH += "00" + stt;
                }
                else if (stt < 100)
                {
                    maKH += "0" + stt;
                }
                else
                {
                    maKH += stt;
                }
            }
            else //Ngược lại thì ngày chưa có cái mã phiếu nhập nào
            {
                maKH += "001";
            }

            return maKH;
        }
        void ClearDataBingDing()
        {
            txtMaKH.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtDiemTichLuy.DataBindings.Clear();
            cboMaLoaiKhach.DataBindings.Clear();
        }
        void DatabingdingKH(DataTable dt)
        {
            // Xóa DataBindings trước khi liên kết mới
            ClearDataBingDing();
            //Liên kết dữ liệu với text box
            txtMaKH.DataBindings.Add("Text", dt, "MaKH");
            txtHoTen.DataBindings.Add("Text", dt, "tenkh");
            txtDiaChi.DataBindings.Add("Text", dt, "DiaChi");
            txtPhone.DataBindings.Add("Text", dt, "SDT");
            txtEmail.DataBindings.Add("Text", dt, "Email");

            // Liên kết dữ liệu cho ComboBox
            cboMaLoaiKhach.DataBindings.Add("SelectedValue", dt, "MaLoaiKH");
            txtDiemTichLuy.DataBindings.Add("Text", dt, "DiemTichLuy");
        }
        void loadGridKH()
        {
            DatabingdingKH((DataTable)dgvKh.DataSource);
        }
        private void KH_Load(object sender, EventArgs e)
        {
            DSKhachHang();
            loadGridKH();
        }
        bool KTMaLopTrung(string k)
        {
            Data db = new Data();
            string chuoiTruyVan = "Select count(*) from KHACHHANG where MaKH = '" + k + "'";
            int kq = (int)db.getExcuteScalar(chuoiTruyVan);
            if (kq == 0)
                return true;
            return false;
        }

        bool KTKhoaNgoai(string k)
        {
            Data db = new Data();
            string chuoitruyvan = "Select count(*) from HOADON where MaKH = '" + k + "'";
            int kq = (int)db.getExcuteScalar(chuoitruyvan);
            if (kq == 0)
                return true;
            return false;
        }

        private void dgvKh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnThem.Tag == "Đã Click")
                {
                    // Xóa DataBindings trước khi liên kết mới
                    ClearDataBingDing();
                    if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtDiemTichLuy.Text) || cboMaLoaiKhach.SelectedIndex == -1)
                    {
                        throw new Exception("Vui lòng nhập đầy đủ dữ liệu");
                    }

                    // Tạo một DataRow mới và thêm dữ liệu vào
                    DataTable dt = (DataTable)dgvKh.DataSource;
                    DataRow newRow = dt.NewRow();
                    newRow["MaKH"] = txtMaKH.Text;
                    newRow["TenKH"] = txtHoTen.Text;
                    newRow["DiaChi"] = txtDiaChi.Text;
                    newRow["SDT"] = txtPhone.Text;
                    newRow["Email"] = txtEmail.Text;
                    newRow["DiemTichLuy"] = txtDiemTichLuy.Text;
                    newRow["MaLoaiKH"] = cboMaLoaiKhach.SelectedValue;

                    // Thêm DataRow vào DataTable
                    dt.Rows.Add(newRow);

                    // Gán DataTable làm DataSource cho DataGridView
                    dgvKh.DataSource = dt;
                    btnThem.Text = "Thêm";
                    loadGridKH();
                    btnThem.Tag = "Chưa Click";
                    //btnHuyThem.Visible = false;
                    txtMaKH.Enabled = true;
                }
                else if (btnThem.Tag == "Chưa Click")
                {
                    // Xóa DataBindings trước khi liên kết mới
                    ClearDataBingDing();

                    txtMaKH.Enabled = false;

                    txtMaKH.Text = TaoMaKhachHang();
                    txtHoTen.Text = "";
                    txtHoTen.Focus();
                    txtDiaChi.Text = "";
                    txtPhone.Text = "";
                    txtEmail.Text = "";
                    txtDiemTichLuy.Text = "";
                    cboMaLoaiKhach.SelectedIndex = -1;
                    btnThem.Text = "Xong";
                    btnThem.Tag = "Đã Click";

=======
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
>>>>>>> a419a1e68aea5648f7664307760934e7a588ec79
                }
            }
            catch (Exception ex)
            {
<<<<<<< HEAD
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }
    }
}
=======
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
>>>>>>> a419a1e68aea5648f7664307760934e7a588ec79
