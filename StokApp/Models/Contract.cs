using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StokApp.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string? RentType { get; set; }
        public int TotalDays { get; set; }
        public int TotalPrice { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Dictionary<string, dynamic> ToMap()
        {
            Dictionary<string, dynamic> map = new Dictionary<string, dynamic>();
            map.Add("id", Id);
            map.Add("carId", CarId);
            map.Add("rentType", RentType!);
            map.Add("totalDays", TotalDays);
            map.Add("totalPrice", TotalPrice);
            map.Add("startTime", StartTime);
            map.Add("endTime", EndTime);

            return map;
        }

        public void FromMap(Dictionary<string, dynamic> map)
        {
            Id = map["id"];
            CarId = map["carId"];
            RentType = map["rentType"];
            TotalDays = map["totalDays"];
            TotalPrice = map["totalPrice"];
            StartTime = map["startTime"];
            EndTime = map["endTime"];
        }
    }
}
