using System.Collections.Generic;
using System.Data.SqlClient;
using GameLib;

namespace GameApi.Handlers
{
    public class DbHandler
    {
        static string connectionString = "Server=HeroGame.mssql.somee.com;Database=HeroGame;User Id=swin103581210_SQLLogin_1;password=4oav88gop5";
        SqlConnection connection;

        public SqlConnection Connection { get => connection; set => connection = value; }

        public string Connect()
        {
            Connection = new SqlConnection(connectionString);
            Connection.Open();

            return "Ok";
        }

        public List<Hero> GetHeroes()
        {
            string query = "Select * from Heroes";
            List<Hero> HeroesList = new List<Hero>();
            Hero FoundHero;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader result = command.ExecuteReader();
                while (result.Read())
                {
                    string HeroName = result.GetString(0);
                    int DiceMax = result.GetInt32(1);
                    int DiceMin = result.GetInt32(2);
                    int UsesLeft = result.GetInt32(3);
                    int ID = result.GetInt32(4);
                    FoundHero = new Hero(HeroName, DiceMin, DiceMax, UsesLeft, ID);
                    HeroesList.Add(FoundHero);
                }
            }
            return HeroesList;
        }
        public List<Villain> GetVillains()
        {
            string query = "Select * from Villains";
            List<Villain> VillainList = new List<Villain>();
            Villain FoundVillain;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader result = command.ExecuteReader();
                while (result.Read())
                {
                    string VillainName = result.GetString(0);
                    int HP = result.GetInt32(1);
                    int ID = result.GetInt32(2);
                    FoundVillain = new Villain(VillainName, HP, ID);
                    VillainList.Add(FoundVillain);
                }
            }
            return VillainList;
        }
        public string UploadGame(string win)
        {
            int rowsaffected;
            string query = "INSERT INTO GAME VALUES(@Date, @Win)";
            SqlCommand command = new SqlCommand(query, connection);
            SqlParameter DateParam = new SqlParameter();
            DateParam.ParameterName = "@Date";
            DateParam.Value = System.DateTime.Now;

            SqlParameter WinParam = new SqlParameter();
            WinParam.ParameterName = "@Win";
            WinParam.Value = win;

            command.Parameters.Add(DateParam);
            command.Parameters.Add(WinParam);
            connection.Open();
            rowsaffected = command.ExecuteNonQuery();
            if (rowsaffected > 0)
            {
                return "Upload Successful!";
                }
                else return "Failed";
        }

    }
}