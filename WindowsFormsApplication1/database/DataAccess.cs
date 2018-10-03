using System;
using System.Collections.Generic;
using System.Data.OleDb;
using WindowsFormsApplication1.api;
using WindowsFormsApplication1.data;
using WindowsFormsApplication1.util;

namespace WindowsFormsApplication1.database
{
    class DataAccess : IDataAccess
    {
        private const string ADD_USER = "INSERT INTO benutzer (benutzername, hash, salt) VALUES (@Benutzername, @Hash, @Salt)";
        private const string GET_USER = "SELECT * from benutzer WHERE benutzername = @Benutzername";
        private const string UPDATE_USER_PASSWORD = "UPDATE benutzer SET salt = @Salt, hash = @Hash WHERE benutzername = @Benutzername ";
        private const string UPDATE_USER_USERNAME = "UPDATE benutzer SET benutzername = @Benutzername WHERE id_benutzer = @IdBenutzer ";
        private const string ADD_GENRE = "INSERT INTO genre (bezeichnung) VALUES (@Bezeichnung)";
        private const string GET_GENRES = "SELECT * FROM genre";
        private const string ADD_RATING = "INSERT INTO bewertung (id_serie, id_benutzer, favorit, vorgemerkt, gesehen, rating) VALUES (@IdSerie, @IdBenutzer, @Favorit, @Vorgemerkt, @Gesehen, @Rating)";
        private const string GET_RATING = "SELECT rating FROM bewertung WHERE id_serie = @IdSerie AND id_benuter = @IdBenutzer";
        private const string UPDATE_RATING_FAVORITE = "UPDATE bewertung SET favorit = @Favorit WHERE id_serie = @IdSerie, id_benutzer = @IdBenutzer";
        private const string UPDATE_RATING_MARKED = "UPDATE bewertung SET vorgemerkt = @Vorgemerkt WHERE id_serie = @IdSerie, id_benutzer = @IdBenutzer";
        private const string UPDATE_RATING_SEEN = "UPDATE bewertung SET gesehen = @Gesehen WHERE id_serie = @IdSerie, id_benutzer = @IdBenutzer";
        private const string UPDATE_RATING_RATING = "UPDATE bewertung SET rating = @Rating WHERE id_serie = @IdSerie, id_benutzer = @IdBenutzer";
        private const string UPDATE_RATING = "UPDATE bewertung SET favorit = @Favorit, gesehen = @Gesehen, vorgemerkt = @Vorgemerkt, rating = @Rating";
        private const string GET_AVERAGE_RATING = "SELECT durchschnitt FROM serie_rating WHERE id_serie = @IdSerie";
        private const string ADD_SERIES = "INSERT INTO serie (serienname, beschreibung, bild) VALUES (@Serienname, @Beschreibung, @Bild)";
        private const string GET_SERIES = "SELECT * FROM serie WHERE id_serie = @IdSerie";

        private static DataAccess instance;
        private OleDbConnection connection;

        private DataAccess()
        {
            connection = DBConnection.GetInstance().GetConnection();
        }

        public static DataAccess GetInstance()
        {
            if (instance == null)
                instance = new DataAccess();

            return instance;
        }
        
        public bool AddUser(string username, string password)
        {
            connection.Open();
            try
            {
                //TODO überprüfen ob username bereits existiert (Unique klausel in datenbank)
                OleDbCommand command = new OleDbCommand(ADD_USER, connection);
                command.Parameters.Add("@Benutzername", OleDbType.VarWChar, username.Length).Value = username;

                Hash hash = new Hash(password);
                byte[] hashedPassword = hash.HashValue;
                command.Parameters.Add("@Hash", OleDbType.LongVarWChar, hashedPassword.Length).Value = hashedPassword;
                byte[] salt = hash.Salt;
                command.Parameters.Add("@Salt", OleDbType.LongVarWChar, salt.Length).Value = salt;

                if (command.ExecuteNonQuery() > 0)
                    return true;

                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            { connection.Close(); }

            return false;
        } 

        public User GetUser(string username)
        {
            connection.Open();
            try
            {
                OleDbCommand command = new OleDbCommand(GET_USER, connection);
                command.Parameters.Add("@Benutzername", OleDbType.VarWChar, username.Length).Value = username;

                OleDbDataReader reader = command.ExecuteReader();

                if (reader.Read())
                    return new User(Int32.Parse(reader["id_series"].ToString()), reader["benutzername"].ToString(), new Hash(System.Text.Encoding.UTF8.GetBytes(reader["hash"].ToString()), System.Text.Encoding.UTF8.GetBytes(reader["salt"].ToString())));
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("\nGetUser: " + e);
            }
            finally
            { connection.Close(); }

            return null;
        }

        public bool UpdateUserPassword(int id_user, string password)
        {
            connection.Open();
            try
            {
                OleDbCommand command = new OleDbCommand(UPDATE_USER_PASSWORD, connection);

                Hash hash = new Hash(password);
                byte[] hashedPassword = hash.HashValue;
                command.Parameters.Add("@Hash", OleDbType.LongVarWChar, hashedPassword.Length).Value = hashedPassword;
                byte[] salt = hash.Salt;
                command.Parameters.Add("@Salt", OleDbType.LongVarWChar, salt.Length).Value = salt;

                if (command.ExecuteNonQuery() > 0)
                    return true;

                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("\nUpdateUserPassword: " + e);
            }
            finally
            { connection.Close(); }

            return false;
        }

        public bool UpdateUserUsername(int id_user, string username)
        {
            connection.Open();
            try
            {
                OleDbCommand command = new OleDbCommand(UPDATE_USER_USERNAME, connection);

                command.Parameters.Add("@Benutzername", OleDbType.VarWChar, username.Length).Value = username;
                command.Parameters.Add("@IdBenutzer", OleDbType.Integer, id_user.ToString().Length).Value = id_user;

                if (command.ExecuteNonQuery() > 0)
                    return true;

                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("\nUpdateUserUsername: " + e);
            }
            finally
            { connection.Close(); }

            return false;
        }

        public bool AddGenre(string genre)
        {
            connection.Open();
            try
            {
                OleDbCommand command = new OleDbCommand(ADD_GENRE, connection);

                command.Parameters.Add("@Bezeichnung", OleDbType.VarWChar, genre.Length).Value = genre;
                

                if (command.ExecuteNonQuery() > 0)
                    return true;

                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("\nAddGenre: " + e);
            }
            finally
            { connection.Close(); }

            return false;
        }

        public List<Genre> GetGenres()
        {
            connection.Open();
            try
            {
                OleDbCommand command = new OleDbCommand(GET_GENRES, connection);

                OleDbDataReader reader = command.ExecuteReader();
                List<Genre> genres = new List<Genre>();
                while (reader.Read())
                {
                    genres.Add(new Genre(Int32.Parse(reader["id_genre"].ToString()), reader["beschreigung"].ToString()));
                }

                if (genres.Count > 0)
                    return genres;
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("\nGetGenres: " + e);
            }
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
            {
                Console.WriteLine("\nAddRating: " + e);
            }
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
            {
                Console.WriteLine("\nGetRating: " + e);
            }
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
            {
                Console.WriteLine("\nUpdateRating: " + e);
            }
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
            {
                Console.WriteLine("\nGetAverageRatingForSeries: " + e);
            }
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
            {
                Console.WriteLine("\nAddSeries: " + e);
            }
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
            {
                Console.WriteLine("\nGetSeries: " + e);
            }
            finally
            { connection.Close(); }

            return null;
        }
    }
}
