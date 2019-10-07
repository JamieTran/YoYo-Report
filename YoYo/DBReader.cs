using System;
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
        public int GetMoldedParts()
        {
            int moldedParts;

            try
            {
                using (var command = new SqlCommand("SELECT COUNT(TestPassed) FROM lamp WHERE TestPassed = 0",
                    _sqlConnection))
                {
                    _sqlConnection.Open();
                    moldedParts = Convert.ToInt32(command.ExecuteScalar());
                    _sqlConnection.Close();
                }
            }

            catch (Exception)
            {
                Console.WriteLine(@"Unable to retrieve molded parts");
                throw;
            }

            return moldedParts;
        }
    }
}