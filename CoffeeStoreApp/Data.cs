using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data; 
namespace CoffeeStoreApp
{
    class Data
    {   
        public QL_CAFEEntities db = new QL_CAFEEntities();
        SqlConnection conn;
        string chuoiketnoi = "Data Source=TANPHAT-PC;Initial Catalog=QL_CAFE;Integrated Security=True;Encrypt=False"; 

        public Data()
        {
            conn = new SqlConnection(chuoiketnoi);
        }
        public Data(string chuoikn)
        {
            conn = new SqlConnection(chuoikn);
        }
        //Phuong thuc xu ly
        public void Open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public DataTable getDataTable(string chuoiTruyVan)
        {
            SqlDataAdapter da = new SqlDataAdapter(chuoiTruyVan, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public int updateDataTable(DataTable dtnew, string cautruyvan)
        {
            SqlDataAdapter da = new SqlDataAdapter(cautruyvan, conn); //Du lieu trong sql
            SqlCommandBuilder cb = new SqlCommandBuilder(da); //Cap nhat trong csdl

            int kq = da.Update(dtnew); //luu du lieu moi vao sql || Cap nhat trong dataset
            return kq;
        }
        public object getExcuteScalar(string chuoitruyvan)
        {
            Open();
            SqlCommand cmd = new SqlCommand(chuoitruyvan, conn);
            //THuc thi
            object kq = cmd.ExecuteScalar();
            Close();
            return kq;
        }
        public SqlDataReader getDataReader(string chuoitruyvan)
        {
            Open();
            SqlCommand cmd = new SqlCommand(chuoitruyvan, conn);
            //THuc thi
            SqlDataReader rd = cmd.ExecuteReader();
            Close();
            return rd;
        }


        public List<HANGHOA> GetHotDrinkSales()
        {
            var hh = (from itm in db.HANGHOAs 
                      join con in db.KIEMKEs.Where(itm => itm.sldaban > 100) 
                      on itm.mahh equals con.mahh 
                      select itm).ToList();
            return hh;
        } 
       
        public KIEMKE GetInventoryLatestOfDrinks(string id)
        {
            var getproducts = db.KIEMKEs.Where(itm => itm.mahh == id).ToList();
            DateTime latestTime = getproducts.Max(itm => itm.ngaykiemke);
            var getLatestInventory = getproducts.Where(itm => itm.ngaykiemke == latestTime).FirstOrDefault();
            return getLatestInventory;
        }
    }
}
