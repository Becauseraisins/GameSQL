using System.Collections.Generic;
using System.Data.SqlClient;
namespace GameApi.Handlers{
      public class DbHandler
    {
        static string connectionString = "Server=database-1.ctcz9gxl3kws.us-east-1.rds.amazonaws.com;Database=CarsDB;User Id=admin;password=asdf1234";
        SqlConnection connection;

        public SqlConnection Connection { get => connection; set => connection = value; }

        public string Connect()
        {
            Connection = new SqlConnection(connectionString);
            Connection.Open();

            return "Ok";

        }
}
}