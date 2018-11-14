using System.Data.OleDb;


namespace Seriendatenbank.database
{
    class DBConnection
    {
        private static DBConnection instance;
        private OleDbConnection connection;

        private DBConnection()
        {
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\..\\Database11.accdb");
        }

        public void Open()
        {
            connection.Open();
        }

        public void Close()
        {
            connection.Close();
        }

        public OleDbConnection GetConnection()
        {
            return connection;
        }

        public static DBConnection GetInstance()
        {
            if (instance == null)
               instance = new DBConnection();

            return instance;
        }
    }
}
