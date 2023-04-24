using StokApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokApp.Services
{
    public class CarService
    {
        private static readonly CarService _singleton = new CarService();

        public static CarService Instance { get { return _singleton; } }

        static List<Car>? Cars { get; set; }

        string connectionString = "Data Source=JUMBO;Initial Catalog=oto_stok;Integrated Security=True";
        SqlConnection? connection;
        SqlCommand? command;

        CarService() 
        {
            try
            {
                connection = new SqlConnection(connectionString);
                string query = "select * from cars";
                command = new SqlCommand(query, connection);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public List<Car> GetCarsFromDb()
        {
            List<Car> list = new List<Car>();
            try
            {
                connection!.Open();
                SqlDataReader reader = command!.ExecuteReader();
                while (reader.Read())
                {
                    Car car = new Car();
                    Dictionary<string, dynamic> map = new Dictionary<string, dynamic>();
                    for(int i=0; i<reader.FieldCount; i++)
                    {
                        map.Add(reader.GetName(i), reader.GetValue(i));
                    }
                    car.FromMap(map);
                    list.Add(car);
                }
                reader.Close();
                connection.Close();
                Cars = list;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return list;
        }
    }
}
