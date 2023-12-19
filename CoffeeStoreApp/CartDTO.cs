using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using MongoDB.Bson.Serialization.Attributes;
namespace CoffeeStoreApp
{
    public class CartDTO
    {
        [BsonElement("_stt")]
        [DisplayName("Số thứ tự")]
        public int stt { get; set; }
        [BsonId]
        [BsonElement("_id")]
        [DisplayName("Mã món")]
        public string id{ get; set; }
        [BsonElement("_name")]

        [DisplayName("Tên thức uống")]
        public string ten { get; set; }
        [BsonElement("_quantity")]

        [DisplayName("Số lượng")]
        public int soluong { get; set; }
        [BsonElement("_totalmoney")]
        [DisplayName("Tổng tiền")]
        public double tongtien { get; set; }
        public CartDTO()
        {

        }

    }
}
