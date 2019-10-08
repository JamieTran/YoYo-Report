/* File: DBReader.cs
 * Project: Business Intelligence Assignment 02
 * Author: Jamie Tran
 * Description: This file contains all the logic that queries from the database
 */

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace YoYo
{
    /// <summary>
    /// DbReader contains all the logic that communicates and establishes a connection with the sql server
    /// </summary>
    public class DbReader
    {
        private readonly SqlConnection _sqlConnection;

        /// <summary>
        /// Constructor
        /// On initalization establish connection with sql server
        /// </summary>
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

        /// <summary>
        /// gets the number of parts by state
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="state"></param>
        /// <returns></returns>
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

        /// <summary>
        /// gets the number of parts that didnt fail
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="state"></param>
        /// <returns></returns>
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

        /// <summary>
        /// gets the list of reasons of failure from db
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// gets the number of failures based on product id
        /// </summary>
        /// <param name="reason"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
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