﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public KIEMKE GetInventoryLatestOfDrinks(string id, int month = 0)
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
            try
            {
                foreach(var ct in cthds)
                {
                    db.CHITIETHDs.Add(ct);
                    db.Entry<CHITIETHD>(ct).State = System.Data.Entity.EntityState.Added;
                }    
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
            string sql = "exec GenerateBillCode @res out";
            var outParam = new SqlParameter("res", System.Data.SqlDbType.Char, 5);

            int success = db.Database.ExecuteSqlCommand(sql, outParam);
            if(success != 0)
            {
                return outParam.Value.ToString();
            }
            return null;
        }
    }
}
