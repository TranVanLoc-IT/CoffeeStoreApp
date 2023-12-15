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
            DateTime latestTime = getproducts.Max(itm => itm.ngaykiemke);
            var getLatestInventory = getproducts.Where(itm => itm.ngaykiemke == latestTime).FirstOrDefault();
            return getLatestInventory;
        }
    }
}
