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
        public long SerialNo { get; set; }
        public string? Name { get; set; }
        public string? LicensePlate { get; set; }

        public Dictionary<string, dynamic> ToMap()
        {
            Dictionary<string, dynamic> map = new Dictionary<string, dynamic>();
            map.Add("id", Id);
            map.Add("serial_no", SerialNo);
            map.Add("name", Name!);
            map.Add("license_plate", LicensePlate!);

            return map;
        }

        public void FromMap(Dictionary<string, dynamic> map)
        {
            Id = map["id"];
            SerialNo = map["serial_no"];
            Name = map["name"];
            LicensePlate = map["license_plate"];
        }
    }
}
