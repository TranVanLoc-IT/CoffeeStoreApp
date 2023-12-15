using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeStoreApp
{
    class HistoryBill
    {
        public string billCode { get; set; }
        public KeyValuePair<string, int> products { get; set; }
        public string customerName { get; set; }
        public double totalMoney { get; set; }
    }
}
