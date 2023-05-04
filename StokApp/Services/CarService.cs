using StokApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
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

        public List<Car>? Cars 
        {
            get { return GetCarsFromDb(); }
            set { }
        }

        string connectionString = "Data Source=JUMBO;Initial Catalog=oto_stok;Integrated Security=True";
        SqlConnection? connection;
        CarService()
        {
            Cars = new List<Car>();
            
            try
            {
                connection = new SqlConnection(connectionString);
                Cars = GetCarsFromDb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public List<Car> GetCarsFromDb()
        {
            string query = "select * from cars";
            SqlCommand? command = new SqlCommand(query, connection);
            List<Car> cars = new List<Car>();
            
            try
            {
                connection!.Open();
                SqlDataReader reader = command!.ExecuteReader();
                while (reader.Read())
                {
                    Car car = new Car();
                    Dictionary<string, dynamic> map = new Dictionary<string, dynamic>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        map.Add(reader.GetName(i), reader.GetValue(i));
                    }
                    car.FromMap(map);
                    cars.Add(car);
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                MessageBox.Show("Araçlar");
            }
            return cars;
        }

        public void AddCar(Car car)
        {
            int serialNo = car.SerialNo;
            string brand = car.Brand!;
            string model = car.Model!;
            int yearProd = car.YearProd;
            string plate = car.Plate!;
            string gear = car.Gear!;
            bool isRented = car.IsRented;
            int dailyPrice = car.DailyPrice;
            int weeklyPrice = car.WeeklyPrice;
            int monthlyPrice = car.MonthlyPrice;
            int sixMonthPrice = car.SixMonthPrice;
            int annualPrice = car.AnnualPrice;

            try
            {
                string query = "INSERT INTO cars (serialNo, brand, model, plate, gear, isRented, yearProd, dailyPrice, weeklyPrice, monthlyPrice, sixMonthPrice, annualPrice) VALUES (@serialNo, @brand, @model, @plate, @gear, @isRented, @yearProd, @dailyPrice, @weeklyPrice, @monthlyPrice, @sixMonthPrice, @annualPrice, )";

                connection!.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@serialNo", serialNo);
                command.Parameters.AddWithValue("@brand", brand);
                command.Parameters.AddWithValue("@model", model);
                command.Parameters.AddWithValue("@plate", plate);
                command.Parameters.AddWithValue("@gear", gear);
                command.Parameters.AddWithValue("@yearProd", yearProd);
                command.Parameters.AddWithValue("@dailyPrice", dailyPrice);
                command.Parameters.AddWithValue("@monthlyPrice", monthlyPrice);
                command.Parameters.AddWithValue("@weeklyPrice", weeklyPrice);
                command.Parameters.AddWithValue("@sixMonthPrice", sixMonthPrice);
                command.Parameters.AddWithValue("@annualPrice", annualPrice);
                command.Parameters.Add("@isRented", SqlDbType.Bit).Value = isRented;

                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show(rowsAffected.ToString());
                connection!.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void UpdateCar(Car car)
        {
            int id = car.Id;
            int serialNo = car.SerialNo;
            string brand = car.Brand!;
            string model = car.Model!;
            int yearProd = car.YearProd;
            string plate = car.Plate!;
            string gear = car.Gear!;
            bool isRented = car.IsRented;
            int dailyPrice = car.DailyPrice;
            int weeklyPrice = car.WeeklyPrice;
            int monthlyPrice = car.MonthlyPrice;
            int sixMonthPrice = car.SixMonthPrice;
            int annualPrice = car.AnnualPrice;

            try
            {
                string query = "UPDATE cars SET serialNo = @serialNo, brand = @brand, model = @model, yearProd = @yearProd, plate = @plate, gear = @gear, isRented = @isRented, dailyPrice = @dailyPrice, weeklyPrice = @weeklyPrice, monthlyPrice = @monthlyPrice, sixMonthPrice = @sixMonthPrice, annualPrice = @annualPrice WHERE id = @id";
                connection?.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@serialNo", serialNo);
                command.Parameters.AddWithValue("@brand", brand);
                command.Parameters.AddWithValue("@model", model);
                command.Parameters.AddWithValue("@plate", plate);
                command.Parameters.AddWithValue("@gear", gear);
                command.Parameters.AddWithValue("@yearProd", yearProd);
                command.Parameters.AddWithValue("@dailyPrice", dailyPrice);
                command.Parameters.AddWithValue("@monthlyPrice", monthlyPrice);
                command.Parameters.AddWithValue("@weeklyPrice", weeklyPrice);
                command.Parameters.AddWithValue("@sixMonthPrice", sixMonthPrice);
                command.Parameters.AddWithValue("@annualPrice", annualPrice);
                command.Parameters.Add("@isRented", SqlDbType.Bit).Value = isRented;

                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show(rowsAffected.ToString());
                connection!.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void DeleteCar(Car car)
        {
            int id = car.Id;
            try
            {
                string query = "DELETE FROM cars WHERE id = @id";

                connection!.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show(rowsAffected.ToString());
                connection!.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
