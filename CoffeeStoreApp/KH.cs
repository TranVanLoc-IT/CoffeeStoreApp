using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CoffeeStoreApp
{
    public partial class KH : Form
    {
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

                }
            }
            catch (Exception ex)
            {
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