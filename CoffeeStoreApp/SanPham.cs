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
    public partial class SanPham : Form
    {
        QL_CAFEEntities db = new QL_CAFEEntities();
        SqlConnection con = new SqlConnection(@"Data Source=MSI;Initial Catalog=QL_CAFE;Integrated Security=True");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        public SanPham()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            con.Open();
            string sql = "SELECT tenhh,dongia FROM HangHoa";
            da = new SqlDataAdapter(sql, con);
            da.Fill(ds, "HangHoa");

            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["HangHoa"].Columns[0];
            ds.Tables["HangHoa"].PrimaryKey = key;

            dgvSP.DataSource = ds.Tables["HangHoa"];
            con.Close();

        }
        void dataBingding(DataTable dt)
        {
            txt_TenSp.DataBindings.Clear();
            txt_Gia.DataBindings.Clear();

            txt_TenSp.DataBindings.Add("Text", dt, "tenhh");
            txt_Gia.DataBindings.Add("Text", dt, "dongia");
        }
        private void SanPham_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvSP.ReadOnly = true;
            dgvSP.AllowUserToAddRows = false;
            dataBingding(ds.Tables["HangHoa"]);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            dgvSP.AllowUserToAddRows = true;
            dgvSP.ReadOnly = false;
            for (int i = 0; i < dgvSP.Rows.Count - 1; i++)
            {
                dgvSP.Rows[i].ReadOnly = true;
            }
            dgvSP.FirstDisplayedScrollingRowIndex = dgvSP.Rows.Count - 1;

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables["HangHoa"].Rows.Find(txt_TenSp.Text);
            if (dr != null)
            {
                dr.Delete();
            }
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(ds, "HangHoa");
            LoadData();
            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void dgvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgvSP.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvSP.SelectedCells[0].RowIndex;
                dgvSP.ReadOnly = false;
                dgvSP.Rows[selectedRowIndex].ReadOnly = false;
                //dgvSP.Columns["tenhh"].ReadOnly = true;
                dgvSP.AllowUserToAddRows = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một ô để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
