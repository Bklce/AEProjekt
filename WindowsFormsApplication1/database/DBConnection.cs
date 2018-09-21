using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.database
{
    class DBConnection
    {
        private static DBConnection instance;
        private OleDbConnection connection;

        private DBConnection()
        {
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\..\\..\\Database11.accdb");
        }

        public void open()
        {
            connection.Open();
        }

        public void close()
        {
            connection.Close();
        }

        public OleDbConnection getConnection()
        {
            return this.connection;
        }

        public static DBConnection getInstance()
        {
            if (instance == null)
                DBConnection.instance = new DBConnection();

            return instance;
        }
    }
}
