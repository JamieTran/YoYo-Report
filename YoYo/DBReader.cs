using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace YoYo
{
    public class DbReader
    {
        private readonly SqlConnection _sqlConnection;

        public DbReader()
        {
            try
            {
                _sqlConnection = new SqlConnection
                {
                    ConnectionString = ConfigurationManager.ConnectionStrings["YoYoConnection"].ConnectionString
                };
            }
            catch (Exception)
            {
                Console.WriteLine(@"Unable to connect to YoYo Database");
                throw;
            }
        }

        public int GetNumberOfPartsByState(int productId, string state)
        {
            int moldedParts;
            var sqlCommand = "SELECT COUNT(SerialNumber) " +
                             "FROM YoYo y " +
                             "JOIN State s ON y.SerialNumber = s.YoYoSerialNumber " +
                             "JOIN Product p On y.ProductID = p.ProductID " +
                             $"WHERE s.Name = '{state}' AND p.ProductID = {productId}";

            // if product is Any
            if (productId == 0)
                sqlCommand = "SELECT COUNT (*) " +
                             "FROM State s " +
                             $"WHERE s.Name = '{state}'";
            try
            {
                using (var command = new SqlCommand(sqlCommand, _sqlConnection))
                {
                    _sqlConnection.Open();
                    moldedParts = Convert.ToInt32(command.ExecuteScalar());
                    _sqlConnection.Close();
                }
            }

            catch (Exception)
            {
                Console.WriteLine($@"Unable to retrieve {productId} and {state} from database");
                throw;
            }

            return moldedParts;
        }

        public int GetNumberOfSuccessParts(int productId, string state)
        {
            int successParts;
            var sqlCommand = "SELECT COUNT(*) " +
                             "FROM YoYo y " +
                             "JOIN Product p On y.ProductID = p.ProductID " +
                             "JOIN State s ON y.SerialNumber = s.YoYoSerialNumber " +
                             $"WHERE y.Reason = '' AND p.ProductID = {productId} AND s.Name = '{state}'";

            // if product is Any
            if (productId == 0)
                sqlCommand = "SELECT COUNT (*) " +
                             "FROM YoYo y " +
                             "JOIN State s ON y.SerialNumber = s.YoYoSerialNumber " +
                             $"WHERE y.Reason = '' AND s.Name = '{state}'";
            try
            {
                using (var command = new SqlCommand(sqlCommand, _sqlConnection))
                {
                    _sqlConnection.Open();
                    successParts = Convert.ToInt32(command.ExecuteScalar());
                    _sqlConnection.Close();
                }
            }

            catch (Exception)
            {
                Console.WriteLine($@"Unable to retrieve successful {productId} from database");
                throw;
            }

            return successParts;
        }

        // Use the DevExpress Chart control to display a Pareto diagram showing the reasons for
        // rejection(rework and scrap combined).
        public List<string> GetReasons()
        {
            var reasons = new List<string>();
            var sqlCommand = "SELECT DISTINCT Reason " +
                             "FROM YoYo";
            try
            {
                using (var command = new SqlCommand(sqlCommand, _sqlConnection))
                {
                    _sqlConnection.Open();
                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read()) reasons.Add(Convert.ToString(dataReader[0].ToString()));
                    _sqlConnection.Close();
                }
            }

            catch (Exception)
            {
                Console.WriteLine(@"Unable to retrieve reasons from database");
                throw;
            }

            return reasons;
        }

        public int GetFailureCount(string reason, int productId)
        {
            int numFailures;
            var sqlCommand = "SELECT COUNT(*) " +
                             "FROM YoYo y " +
                             "JOIN Product p ON y.ProductID = p.ProductID " +
                             $"WHERE Reason = '{reason}' AND p.ProductID = {productId}";

            // if product is Any
            if (productId == 0)
                sqlCommand = "SELECT COUNT(*) " +
                             "FROM YoYo " +
                             $"WHERE Reason = '{reason}'";

            try
            {
                using (var command = new SqlCommand(sqlCommand, _sqlConnection))
                {
                    _sqlConnection.Open();
                    numFailures = Convert.ToInt32(command.ExecuteScalar());
                    _sqlConnection.Close();
                }
            }

            catch (Exception)
            {
                Console.WriteLine(@"Unable to retrieve reasons count from database");
                throw;
            }

            return numFailures;
        }
    }
}