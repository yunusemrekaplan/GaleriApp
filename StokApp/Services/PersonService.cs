using StokApp.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace StokApp.Services
{
    public class PersonService
    {

        private static readonly PersonService _singleton = new PersonService();
        
        public static PersonService Instance { get { return _singleton; } }

        static List<Person> PersonList = new List<Person>();

        string connectionString = "Data Source=JUMBO;Initial Catalog=oto_stok;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;
        
        PersonService()
        {
            connection = new SqlConnection(connectionString);
            string query = "select * from persons";
            command = new SqlCommand(query, connection);
        }

        public List<Person> GetPersonsFromDb()
        {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Person> list = new List<Person>();
            while (reader.Read())
            {
                Person person = new Person();
                Dictionary<String, dynamic> map = new Dictionary<String, dynamic>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    map.Add(reader.GetName(i), reader.GetValue(i));
                }
                person.FromMap(map);
                list.Add(person);
            }
            reader.Close();
            connection.Close();
            return list;
        }

        public List<Person> GetPersons()
        {
            return PersonList;
        }
    }
}
