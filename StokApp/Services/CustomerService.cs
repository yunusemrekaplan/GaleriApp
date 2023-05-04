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
    public class CustomerService
    {
        private static readonly CustomerService _singleton = new CustomerService();

        public static CustomerService Instance { get { return _singleton; } }

        public List<Customer>? Customers
        {
            get { return GetCustomersFromDb(); }
            set { }
        }

        string connectionString = "Data Source=JUMBO;Initial Catalog=oto_stok;Integrated Security=True";
        SqlConnection? connection;

        public CustomerService()
        {
            Customers = new List<Customer>();

            try
            {
                connection = new SqlConnection(connectionString);
                Customers = GetCustomersFromDb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public List<Customer> GetCustomersFromDb()
        {
            string query = "select * from customers";
            SqlCommand? command = new SqlCommand(query, connection);
            List<Customer> customers = new List<Customer>();

            try
            {
                connection!.Open();
                SqlDataReader reader = command!.ExecuteReader();
                while (reader.Read())
                {
                    Customer customer = new Customer();
                    Dictionary<string, dynamic> map = new Dictionary<string, dynamic>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        map.Add(reader.GetName(i), reader.GetValue(i));
                    }
                    customer.FromMap(map);
                    customers.Add(customer);
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                MessageBox.Show("Araçlar");
            }
            return customers;
        }

        public void AddCustomer(Customer customer)
        {
            string tcNo = customer.TcNo!;
            string name = customer.Name!;
            string surname = customer.Surname!;
            string telNo = customer.TelNo!;
            string licenseNo = customer.LicenseNo!;
            DateTime licenseDate = customer.LicenseDate!;

            try
            {
                string query = "INSERT INTO cars (tcNo, name, surname, telNo, licenseNo, licenseDate) VALUES (@tcNo, @name, @surname, @telNo, @licenseNo, @licenseDate )";

                connection!.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@tcNo", tcNo);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@surname", surname);
                command.Parameters.AddWithValue("@telNo", telNo);
                command.Parameters.AddWithValue("@licenseNo", licenseNo);
                command.Parameters.AddWithValue("@licenseDate", licenseDate);

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
