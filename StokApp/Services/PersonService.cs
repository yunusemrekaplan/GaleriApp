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

        static List<Person>? Persons { get; set; }

        string connectionString = "Data Source=JUMBO;Initial Catalog=oto_stok;Integrated Security=True";
        SqlConnection? connection;
        SqlCommand? command;
        
        PersonService()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                string query = "select * from persons";
                command = new SqlCommand(query, connection);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public List<Person> GetPersonsFromDb()
        {
            List<Person> list = new List<Person>();
            try
            {
                connection!.Open();
                SqlDataReader reader = command!.ExecuteReader();
                while (reader.Read())
                {
                    Person person = new Person();
                    Dictionary<string, dynamic> map = new Dictionary<string, dynamic>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        map.Add(reader.GetName(i), reader.GetValue(i));
                    }
                    person.FromMap(map);
                    list.Add(person);
                }
                reader.Close();
                connection.Close();
                Persons = list;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return list;
        }

    }
}
