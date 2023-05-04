using StokApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokApp.Services
{
    public class ContractService
    {
        private static readonly ContractService _singleton = new ContractService();

        public static ContractService Instance { get { return _singleton; } }

        public List<StokApp.Models.Contract>? Contracts
        {
            get { return GetContractsFromDb(); }
            set { }
        }

        string connectionString = "Data Source=JUMBO;Initial Catalog=oto_stok;Integrated Security=True";
        SqlConnection? connection;

        public ContractService()
        {
            Contracts = new List<StokApp.Models.Contract>();

            try
            {
                connection = new SqlConnection(connectionString);
                Contracts = GetContractsFromDb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public List<StokApp.Models.Contract> GetContractsFromDb()
        {
            string query = "select * from contracts";
            SqlCommand? command = new SqlCommand(query, connection);
            List<StokApp.Models.Contract> contracts = new List<StokApp.Models.Contract>();

            try
            {
                connection!.Open();
                SqlDataReader reader = command!.ExecuteReader();
                while (reader.Read())
                {
                    StokApp.Models.Contract contract = new StokApp.Models.Contract();
                    Dictionary<string, dynamic> map = new Dictionary<string, dynamic>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        map.Add(reader.GetName(i), reader.GetValue(i));
                    }
                    contract.FromMap(map);
                    contracts.Add(contract);
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                MessageBox.Show("Araçlar");
            }
            return contracts;
        }

        public void AddContract(StokApp.Models.Contract contract)
        {
            int carId = contract.CarId;
            string rentType = contract.RentType!;
            int totalDays = contract.TotalDays;
            int totalPrice = contract.TotalPrice;
            DateTime startTime = contract.StartTime;
            DateTime endTime = contract.EndTime;

            try
            {
                string query = "INSERT INTO cars (carId, rentType, totalDays, totalPrice, startTime, endTime) VALUES (@carId, @rentType, @totalDays, @totalPrice, @startTime, @endTime )";

                connection!.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@carId", carId);
                command.Parameters.AddWithValue("@rentType", rentType);
                command.Parameters.AddWithValue("@totalDays", totalDays);
                command.Parameters.AddWithValue("@totalPrice", totalPrice);
                command.Parameters.AddWithValue("@startTime", startTime);
                command.Parameters.AddWithValue("@endTime", endTime);

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
