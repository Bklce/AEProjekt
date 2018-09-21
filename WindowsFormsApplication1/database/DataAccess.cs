using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.util;

namespace WindowsFormsApplication1.database
{
    class DataAccess
    {
        private static DataAccess instance;
        private const string ADD_USER = "INSERT INTO benutzer (benutzername, hash, salt) VALUES (@Benutzername, @Hash, @Salt)";
        private OleDbConnection connection;
        private OleDbDataAdapter adapter = new OleDbDataAdapter();

        private DataAccess()
        {
            connection = DBConnection.getInstance().getConnection();
        }

        public DataAccess getInstance()
        {
            if (instance == null)
                DataAccess.instance = new DataAccess();

            return instance;
        }
        

        public bool addUser(string username, string password)
        {
            OleDbCommand command = new OleDbCommand(ADD_USER, this.connection);
            command.Parameters.Add("@Benutzername", OleDbType.VarWChar, username.Length, username);
           
            Hash hash = new Hash(password);
            string hashedPassword = hash.HashValue;
            command.Parameters.Add("@Hash", OleDbType.LongVarWChar, hashedPassword.Length, hashedPassword);
            string salt = hash.Salt;
            command.Parameters.Add("@Salt", OleDbType.LongVarWChar, salt.Length, salt);

            adapter.InsertCommand = command;

            return false;
        } 
    }
}
