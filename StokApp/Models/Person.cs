using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokApp.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        
        public Dictionary<dynamic, dynamic> ToMap()
        {
            Dictionary<dynamic, dynamic> Map = new Dictionary<dynamic, dynamic>();
            Map.Add("id", Id);
            Map.Add("name", Name);
            Map.Add("surname", Surname);
            Map.Add("Password", Password);

            return Map;
        }
    }
}
