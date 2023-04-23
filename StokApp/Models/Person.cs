﻿using System;
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
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Nickname { get; set; }
        public string? Password { get; set; }
        
        public Dictionary<String, dynamic> ToMap()
        {
            Dictionary<String, dynamic> map = new Dictionary<String, dynamic>();
            map.Add("id", Id);
            map.Add("name", Name!);
            map.Add("surname", Surname!);
            map.Add("nickname", Nickname!);
            map.Add("Password", Password!);

            return map;
        }

        public void FromMap(Dictionary<String, dynamic> map)
        {
            Id = map["id"];
            Name = map["name"];
            Surname = map["surname"];
            Nickname = map["nickname"];
            Password = map["password"];
        }
    }
}
