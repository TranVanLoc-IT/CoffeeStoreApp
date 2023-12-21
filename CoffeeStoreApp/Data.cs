using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
<<<<<<< HEAD
        } 
       
        public KIEMKE GetInventoryLatestOfDrinks(string id)
=======
        }
        public KIEMKE GetInventoryLatestOfDrinks(string id, int month = 0)
>>>>>>> a419a1e68aea5648f7664307760934e7a588ec79
        {
            var getproducts = db.KIEMKEs.Where(itm => itm.mahh == id).ToList();
            if (getproducts.Count() == 0) return null;
            DateTime latestTime = getproducts.Max(itm => itm.ngaykiemke);
            var getLatestInventory = getproducts.Where(itm => itm.ngaykiemke == latestTime).FirstOrDefault();
            return getproducts.Last();
        }
        public bool EditCustomer(KHACHHANG kh, string option)
        {
            if (kh == null) return false;
            try
            {
                switch (option)
                {
                    case "insert":
                        db.KHACHHANGs.Add(kh);
                        db.Entry<KHACHHANG>(kh).State = System.Data.Entity.EntityState.Added;
                        break;
                    case "delete":
                        db.KHACHHANGs.Remove(kh);
                        db.Entry<KHACHHANG>(kh).State = System.Data.Entity.EntityState.Deleted;
                        break;
                    case "update":
                        db.KHACHHANGs.Attach(kh);
                        db.Entry<KHACHHANG>(kh).State = System.Data.Entity.EntityState.Modified;
                        break;
                }
                db.SaveChanges();
            }catch(Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool AddBill(HOADON hd, List<CHITIETHD> cthds)
        {
            if (hd == null) return false;
            Console.WriteLine("MA NOOOOOOOOOOOOOOO");
            try
            {
                db.HOADONs.Add(hd);
                db.Entry<HOADON>(hd).State = System.Data.Entity.EntityState.Added;
                foreach (var ct in cthds)
                {
                    db.CHITIETHDs.Add(ct);
                    db.Entry<CHITIETHD>(ct).State = System.Data.Entity.EntityState.Added;
                }    
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("LOIII: " + ex.InnerException);
                return false;
            }
            return true;
        }
        public bool AddImport(KIEMKE kk)
        {
            if (kk == null) return false;
            try
            {
                db.KIEMKEs.Add(kk);
                db.Entry<KIEMKE>(kk).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public string GenerateBillCode()
        {
            // Tạo đối tượng SqlParameter cho tham số đầu ra
            var outParam = new SqlParameter("@res", System.Data.SqlDbType.Char, 5);
            outParam.Direction = System.Data.ParameterDirection.Output; // Xác định tham số là đầu ra

            // Gọi stored procedure và cung cấp tham số
            int success = db.Database.ExecuteSqlCommand("exec GenerateBillCode @res out", outParam);

            // Kiểm tra xem có lỗi hay không (success != 0)
            if (success != 0)
            {
                // Lấy giá trị của tham số đầu ra
                string result = outParam.Value.ToString();
                return result;
            }
            return string.Empty;
        }
        public List<BAN> GetEmptyTables()
        {
            var tableInBills = db.HOADONs.Select(itm => itm.maban).ToList();
            var getEmptyTables = from itm in db.BANs
                                 where !tableInBills.Contains(itm.maban)
                                 select itm;
            return getEmptyTables.ToList();
        }    
    }
}
