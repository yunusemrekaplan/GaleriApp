using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StokApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string? TcNo { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? TelNo { get; set; }
        public string? LicenseNo { get; set; }
        public DateTime LicenseDate { get; set; }

        public Dictionary<string, dynamic> ToMap()
        {
            Dictionary<string, dynamic> map = new Dictionary<string, dynamic>();
            map.Add("id", Id);
            map.Add("tcNo", TcNo!);
            map.Add("name", Name!);
            map.Add("surname", Surname!);
            map.Add("telNo", TelNo!);
            map.Add("licenseNo", LicenseNo!);
            map.Add("licenseDate", LicenseDate!);
            
            return map;
        }

        public void FromMap(Dictionary<string, dynamic> map)
        {
            Id = map["id"];
            TcNo = map["tcNo"];
            Name = map["name"];
            Surname = map["surname"];
            TelNo = map["telNo"];
            LicenseNo = map["licenseNo"];
            LicenseDate = map["licenseDate"];
        }
    }
}
