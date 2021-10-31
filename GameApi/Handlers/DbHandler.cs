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
                    string ID = result.GetString(4);
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
                    string ID = result.GetString(2);
                    FoundVillain = new Villain(VillainName, HP, ID);
                    VillainList.Add(FoundVillain);
                }
            }
            return VillainList;
        }
        public List<Game> GetGames()
        {
            string query = "SELECT * FROM GAME";
            List<Game> GamesList = new List<Game>();
            Game FoundGame;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader result = command.ExecuteReader();
                while (result.Read())
                {
                    System.DateTime GameTime = result.GetDateTime(0);
                    string outcome = result.GetString(1);
                    FoundGame = new Game(GameTime, outcome);
                    GamesList.Add(FoundGame);
                }
            }
            return GamesList;
        }
        public int UploadGame(string win)
        {   char winInput;
            if(win=="w"){
                winInput ='w';
            }
            else{
                winInput = 'l';
            }
            int rowsaffected = 0;
            string query = "INSERT INTO GAME VALUES(@date, @win)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlParameter DateParam = new SqlParameter();
                DateParam.ParameterName = "@date";
                DateParam.Value = System.DateTime.Now;

                SqlParameter WinParam = new SqlParameter();
                WinParam.ParameterName = "@win";
                WinParam.Value = winInput;

                command.Parameters.Add(DateParam);
                command.Parameters.Add(WinParam);

                rowsaffected = command.ExecuteNonQuery();
            }
            return rowsaffected;
        }

    }
}