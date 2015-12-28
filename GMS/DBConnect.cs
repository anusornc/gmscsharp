//Add MySql Library
using MySql.Data.MySqlClient;
using System.Configuration;


namespace GMS
{
    class DBConnect
    {
        private static MySqlConnection connection;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            connection = new MySqlConnection(GetConnectionStringByName("mysql"));
        }

        private string GetConnectionStringByName(string name)
        {
            // Assume failure.
            string returnValue = null;

            // Look for the name in the connectionStrings section.
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[name];

            // If found, return the connection string.
            if (settings != null)
                returnValue = settings.ConnectionString;

           

            return returnValue;
        }

 
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}