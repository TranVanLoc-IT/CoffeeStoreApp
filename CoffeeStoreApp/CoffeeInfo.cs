using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
namespace CoffeeStoreApp
{
    class CoffeeInfo
    {
        [BsonElement("_id")]
        public string mahh { get; set; }
        [BsonElement("_thongtin")]
        public string thongtin { get; set; }
        [BsonElement("_xuatxu")]
        public string xuatxu { get; set; }
        [BsonElement("_thuonghieu")]
        public string thuonghieu { get; set; }
        [BsonElement("_huongvi")]
        public string huongvi { get; set; }

    }
}
