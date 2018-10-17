using System;
using System.Collections.Generic;
using System.Data.OleDb;
using Seriendatenbank.api;
using Seriendatenbank.data;
using Seriendatenbank.util;
using System.Linq;

namespace Seriendatenbank.database
{
    public class DataAccess : IDataAccess
    {
        private const string ADD_USER = "INSERT INTO benutzer (benutzername, hash, salt) VALUES (@Benutzername, @Hash, @Salt)";
        private const string GET_USER = "SELECT * from benutzer WHERE benutzername = @Benutzername";
        private const string UPDATE_USER_PASSWORD = "UPDATE benutzer SET salt = @Salt, hash = @Hash WHERE benutzername = @Benutzername";
        private const string UPDATE_USER_USERNAME = "UPDATE benutzer SET benutzername = @Benutzername WHERE benutzername = @IdBenutzerNeu";
        private const string ADD_GENRE = "INSERT INTO genre (bezeichnung) VALUES (@Bezeichnung)";
        private const string GET_GENRES = "SELECT * FROM genre";
        private const string ADD_RATING = "INSERT INTO bewertung (id_serie, id_benutzer, favorit, vorgemerkt, gesehen, rating) VALUES (@IdSerie, @IdBenutzer, @Favorit, @Vorgemerkt, @Gesehen, @Rating)";
        private const string GET_RATING = "SELECT * FROM bewertung WHERE id_serie = @IdSerie AND id_benutzer = @IdBenutzer";
        private const string GET_ALL_RATINGS = "SELECT * FROM bewertung WHERE id_benutzer = @IdBenutzer";
        private const string UPDATE_RATING_FAVORITE = "UPDATE bewertung SET favorit = @Favorit WHERE id_serie = @IdSerie AND id_benutzer = @IdBenutzer";
        private const string UPDATE_RATING_MARKED = "UPDATE bewertung SET vorgemerkt = @Vorgemerkt WHERE id_serie = @IdSerie AND id_benutzer = @IdBenutzer";
        private const string UPDATE_RATING_SEEN = "UPDATE bewertung SET gesehen = @Gesehen WHERE id_serie = @IdSerie, id_benutzer = @IdBenutzer";
        private const string UPDATE_RATING_RATING = "UPDATE bewertung SET rating = @Rating WHERE id_serie = @IdSerie, id_benutzer = @IdBenutzer";
        private const string UPDATE_RATING = "UPDATE bewertung SET favorit = @Favorit, gesehen = @Gesehen, vorgemerkt = @Vorgemerkt, rating = @Rating WHERE id_serie = @IdSerie AND id_benutzer = @IdBenutzer";
        private const string GET_AVERAGE_RATING = "SELECT durchschnitt FROM serie_rating WHERE id_serie = @IdSerie";
        private const string GET_AVERAGE_RATINGS = "SELECT id_serie, durchschnitt FROM serie_rating";
        private const string ADD_SERIES = "INSERT INTO serie (serienname, beschreibung, bild) VALUES (@Serienname, @Beschreibung, @Bild)";
        private const string GET_SERIES = "SELECT * FROM serie WHERE id_serie = @IdSerie";
        private const string GET_ALL_SERIES = "SELECT * FROM serie";

        private static DataAccess instance;
        private readonly OleDbConnection connection;

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
                var command = new OleDbCommand(ADD_USER, connection);
                command.Parameters.Add("@Benutzername", OleDbType.VarWChar, username.Length).Value = username;

                var hash = new Hash(password);
                byte[] hashedPassword = hash.HashValue;
                command.Parameters.Add("@Hash", OleDbType.Binary, hashedPassword.Length).Value = hashedPassword;
                byte[] salt = hash.Salt;
                command.Parameters.Add("@Salt", OleDbType.Binary, salt.Length).Value = salt;

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
                var command = new OleDbCommand(GET_USER, connection);
                command.Parameters.Add("@Benutzername", OleDbType.VarWChar, username.Length).Value = username;

                OleDbDataReader reader = command.ExecuteReader();

                if (reader.Read())
                    return new User(Int32.Parse(reader["id_benutzer"].ToString()), reader["benutzername"].ToString(), new Hash((byte[])reader["hash"], (byte[])reader["salt"]));
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
        
        public User GetUserWithRating(string username){
        	User user = GetUser(username);
        	if(user != null)
        	{
        		Dictionary<int, Rating> ratings = GetAllRatings(user.Id);
        		if(ratings != null)
        			user.Ratings = ratings;
        		
        		return user;
        	}
        		
        	return null;
        }

        public bool UpdateUserPassword(string username, string password)
        {
            connection.Open();
            try
            {
                //TODO mit addUser zusammenführen
                var command = new OleDbCommand(UPDATE_USER_PASSWORD, connection);
                
                var hash = new Hash(password);
                command.Parameters.Add("@Salt", OleDbType.Binary, hash.Salt.Length).Value = hash.Salt;
                command.Parameters.Add("@Hash", OleDbType.Binary, hash.HashValue.Length).Value = hash.HashValue;
               
                command.Parameters.Add("@Benutzername", OleDbType.VarWChar, username.Length).Value = username;

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

        public bool UpdateUserUsername(string username, string usernameNew)
        {
            connection.Open();
            try
            {
                var command = new OleDbCommand(UPDATE_USER_USERNAME, connection);
                command.Parameters.Add("@Benutzername", OleDbType.VarWChar, username.Length).Value = username;
                command.Parameters.Add("@BenutzernameNeu", OleDbType.Integer, usernameNew.Length).Value = usernameNew;

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
                var command = new OleDbCommand(ADD_GENRE, connection);

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
                var command = new OleDbCommand(GET_GENRES, connection);

                OleDbDataReader reader = command.ExecuteReader();
                var genres = new List<Genre>();
                while (reader.Read())
                {
                    genres.Add(new Genre(Int32.Parse(reader["id_genre"].ToString()), reader["beschreibung"].ToString()));
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

        protected bool AddRating(Rating rating)
        {
            connection.Open();
            try
            {
                var command = new OleDbCommand(ADD_RATING, connection);
                
                command.Parameters.AddWithValue("@IdSerie", rating.Id_series);
                command.Parameters.AddWithValue("@IdBenutzer", rating.Id_user);
                command.Parameters.AddWithValue("@Favorit", rating.Favorite);
                command.Parameters.AddWithValue("@Markiert", rating.Marked);
                command.Parameters.AddWithValue("@Gesehen", rating.Seen);
                command.Parameters.AddWithValue("@Rating", rating.RatingValue);
                
                if (command.ExecuteNonQuery() > 0)
                    return true;

                return false;
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
                var command = new OleDbCommand(GET_RATING, connection);
                command.Parameters.AddWithValue("@IdSerie", id_series);
                command.Parameters.AddWithValue("@IdBenutzer", id_user);

                OleDbDataReader reader = command.ExecuteReader();

                if (reader.Read())
                	return new Rating(id_series, id_user, (bool)reader["favorit"], (bool)reader["vorgemerkt"], (bool)reader["gesehen"], Int32.Parse(reader["rating"].ToString()));
                
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("\nGetRating: " + e);
            }
            finally
            { connection.Close(); }

            return null;
        }

        public Dictionary<int, Rating> GetAllRatings(int id_user)
        {
            connection.Open();
            try
            {
                var command = new OleDbCommand(GET_ALL_RATINGS, connection);
                command.Parameters.Add("@IdBenutzer", OleDbType.VarWChar).Value = id_user;

                OleDbDataReader reader = command.ExecuteReader();

                var all_ratings = new Dictionary<int,Rating>();
                while (reader.Read())
                {
                    int serien_id = Int32.Parse(reader["id_serie"].ToString());
                    all_ratings.Add(serien_id, new Rating(serien_id, id_user, (bool)reader["favorit"], (bool)reader["vorgemerkt"], (bool)reader["gesehen"], Int32.Parse(reader["rating"].ToString())));
                }
                return all_ratings;
            }
            catch (Exception e)
            {
                Console.WriteLine("\nGetAllRatings: " + e);
            }
            finally
            { connection.Close(); }

            return null;
        }
        
        public bool UpdateOrAddRating(Rating rating){
        	Rating existingRating = GetRating(rating.Id_series, rating.Id_user);
        	if(existingRating != null)
        		return UpdateRating(rating);
        	else
        		return AddRating(rating);
        }
        
        protected bool UpdateRating(Rating rating)
        {
            connection.Open();
            try
            {
                var command = new OleDbCommand(UPDATE_RATING, connection);
                
                command.Parameters.AddWithValue("@Favorit", rating.Favorite);
                command.Parameters.AddWithValue("@Gesehen", rating.Seen);
                command.Parameters.AddWithValue("@Vorgemerkt", rating.Marked);
                command.Parameters.AddWithValue("@Rating", rating.RatingValue);
                command.Parameters.AddWithValue("@IdSerie", rating.Id_series);
                command.Parameters.AddWithValue("@IdBenutzer", rating.Id_user);
                
                if (command.ExecuteNonQuery() > 0)
                    return true;

                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("\nUpdateRating: " + e);
            }
            finally
            { connection.Close(); }
            return false;
        }

        public Dictionary<int, int> GetAverageRatingsForSeries()
        {
            connection.Open();
            try
            {
            	//
                var command = new OleDbCommand(GET_AVERAGE_RATINGS, connection);
                OleDbDataReader reader = command.ExecuteReader();

                var all_ratings = new Dictionary<int, int>();
                while (reader.Read())
                	all_ratings.Add(Int32.Parse(reader["id_serie"].ToString()), (int)Math.Round((double)reader["durchschnitt"], 0)); //Round up
                 
                return all_ratings;
            }
            catch (Exception e)
            {
                Console.WriteLine("\nGetAverageRatingForSeries: " + e);
            }
            finally
            { connection.Close(); }

            return new Dictionary<int, int>();
        }

        public bool AddSeries(string seriesName, byte[] picture, string description, List<Genre> genres, int numberOfSeasons)
        {
            connection.Open();
            try
            {
                var command = new OleDbCommand(ADD_SERIES, connection);
                command.Parameters.Add("@Serienname", OleDbType.VarWChar, seriesName.Length).Value = seriesName;
                command.Parameters.Add("@Beschreibung", OleDbType.VarWChar, description.Length).Value = description;
                command.Parameters.Add("@Bild", OleDbType.Binary, picture.Length).Value = picture;

                //TODO Hinzufügen der Genres, und Staffelanzahl für die Serie

                if (command.ExecuteNonQuery() > 0)
                    return true;

                return false;
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
                var command = new OleDbCommand(GET_ALL_SERIES, connection);

                OleDbDataReader reader = command.ExecuteReader();
                var series = new List<Series>();
                while (reader.Read())
                {
                    series.Add(new Series(Int32.Parse(reader["id_serie"].ToString()), reader["serienname"].ToString(), (byte[])reader["bild"], reader["beschreibung"].ToString(), new List<Genre>
                        (), -1));
                }

                if (series.Count > 0)
                    return series;
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("\nGetSeries: " + e);
            }
            finally
            { connection.Close(); }

            return null;
        }
        
        public List<Series> GetSeriesWithAverageRatings(){
        	List<Series> series = GetSeries();
        	var filteredList = (Dictionary<int, Series>)series.ToDictionary(k => k.Id_series);
        	if(filteredList != null && filteredList.Count != 0)
        	{
        		foreach(KeyValuePair<int, int> entry in GetAverageRatingsForSeries())
        			filteredList[entry.Key].AverageRating = entry.Value;
        		return filteredList.Select(x => x.Value).ToList();
        	}
        	return null;
        }
    }
}
