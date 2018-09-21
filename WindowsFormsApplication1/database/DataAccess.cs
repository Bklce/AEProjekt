using System;
using System.Collections.Generic;
using System.Data.OleDb;
using WindowsFormsApplication1.data;
using WindowsFormsApplication1.util;

namespace WindowsFormsApplication1.database
{
    class DataAccess
    {
        private const string ADD_USER = "INSERT INTO benutzer (benutzername, hash, salt) VALUES (@Benutzername, @Hash, @Salt)";
        private const string GET_USER = "SELECT * from benutzer WHERE benutername = @Benutzername";
        private const string UPDATE_USER = "";
        private const string ADD_GENRE = "";
        private const string GET_GENRES = "";
        private const string ADD_RATING = "";
        private const string GET_RATING = "";
        private const string UPDATE_RATING = "";
        private const string GET_AVERAGE_RATING = "";
        private const string ADD_SERIES = "";
        private const string GET_SERIES = "";

        private static DataAccess instance;
        private OleDbConnection connection;
        private OleDbDataAdapter adapter = new OleDbDataAdapter();

        private DataAccess()
        {
            connection = DBConnection.GetInstance().GetConnection();
        }

        public DataAccess GetInstance()
        {
            if (instance == null)
                instance = new DataAccess();

            return instance;
        }
        
        public bool AddUser(string username, string password)
        {
            //TODO überprüfen ob username bereits existiert (Unique klausel in datenbank)
            OleDbCommand command = new OleDbCommand(ADD_USER, connection);
            command.Parameters.Add("@Benutzername", OleDbType.VarWChar, username.Length, username);
           
            Hash hash = new Hash(password);
            string hashedPassword = hash.HashValue;
            command.Parameters.Add("@Hash", OleDbType.LongVarWChar, hashedPassword.Length, hashedPassword);
            string salt = hash.Salt;
            command.Parameters.Add("@Salt", OleDbType.LongVarWChar, salt.Length, salt);

            adapter.InsertCommand = command;

            return false;
        } 

        public User GetUser(string username)
        {
            connection.Open();
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            { /*log?*/ }
            finally
            { connection.Close(); }

            return null;
        }

        public bool UpdateUser(int id_user)
        {
            connection.Open();
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            { /*log?*/ }
            finally
            { connection.Close(); }

            return false;
        }

        public bool AddGenre(string genre)
        {
            connection.Open();
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            { /*log?*/ }
            finally
            { connection.Close(); }

            return false;
        }

        public List<Genre> GetGenres()
        {
            connection.Open();
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            { /*log?*/ }
            finally
            { connection.Close(); }

            return null;
        }

        public bool AddRating(int id_series, int id_user, int ratingValue)
        {
            connection.Open();
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            { /*log?*/ }
            finally
            { connection.Close(); }

            return false;
        }

        public Rating GetRating(int id_series, int id_user)
        {
            connection.Open();
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            { /*log?*/ }
            finally
            { connection.Close(); }

            return null;
        }

        public bool UpdateRating(int id_series, int id_user, int ratingValue)
        {
            connection.Open();
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            { /*log?*/ }
            finally
            { connection.Close(); }

            return false;
        }

        public int GetAverageRatingForSeries(int seriesId)
        {
            connection.Open();
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            { /*log?*/ }
            finally
            { connection.Close(); }

            return -1;
        }

        public bool AddSeries(string seriesName, byte[] picture, string description, List<Genre> genres, int numberOfSeasons)
        {
            connection.Open();
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            { /*log?*/ }
            finally
            { connection.Close(); }

            return false;
        }

        public List<Series> GetSeries()
        {
            connection.Open();
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            { /*log?*/ }
            finally
            { connection.Close(); }

            return null;
        }
    }
}
