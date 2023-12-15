using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace CoffeeStoreApp
{
    class CartDTO
    {
        [DisplayName("Số thứ tự")]
        public int stt { get; set; }
        [DisplayName("Tên thức uống")]
        public string ten { get; set; }
        [DisplayName("Số lượng")]
        public int soluong { get; set; }
        [DisplayName("Tổng tiền")]
        public double tongtien { get; set; }
    }
}
