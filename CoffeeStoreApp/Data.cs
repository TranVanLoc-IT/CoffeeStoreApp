using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeStoreApp
{
    class Data
    {   
        public QL_CAFEEntities db = new QL_CAFEEntities();
        public Data()
        {
            
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
            if (getproducts.Count() == 0) return null;
            DateTime latestTime = getproducts.Max(itm => itm.ngaykiemke);
            var getLatestInventory = getproducts.Where(itm => itm.ngaykiemke == latestTime).FirstOrDefault();
            return getLatestInventory;
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
        public bool AddBill(HOADON hd)
        {
            if (hd == null) return false;
            try
            {
                db.HOADONs.Add(hd);
                db.Entry<HOADON>(hd).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
