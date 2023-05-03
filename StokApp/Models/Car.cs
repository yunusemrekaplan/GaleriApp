using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokApp.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int SerialNo { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int YearProd { get; set; }
        public string? Plate { get; set; }
        public string? Gear { get; set; }
        public bool IsRented { get; set; }

        public Dictionary<string, dynamic> ToMap()
        {
            Dictionary<string, dynamic> map = new Dictionary<string, dynamic>();
            map.Add("id", Id);
            map.Add("serialNo", SerialNo!);
            map.Add("brand", Brand!);
            map.Add("model", Model!);
            map.Add("yearProd", YearProd);
            map.Add("plate", Plate!);
            map.Add("gear", Gear!);
            map.Add("isRented", IsRented);

            return map;
        }

        public void FromMap(Dictionary<string, dynamic> map)
        {
            Id = map["id"];
            SerialNo = map["serialNo"];
            Brand = map["brand"];
            Model = map["model"];
            YearProd = map["yearProd"];
            Plate = map["plate"];
            Gear = map["gear"];
            IsRented = map["isRented"];
        }
    }
}
