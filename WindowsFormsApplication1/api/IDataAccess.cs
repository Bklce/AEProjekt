
using System.Collections.Generic;
using WindowsFormsApplication1.data;

namespace WindowsFormsApplication1.api
{
    interface IDataAccess
    {
        bool AddUser(string username, string password);
        User GetUser(string username);
        bool UpdateUserPassword(int id_user, string password);
        bool UpdateUserUsername(int id_user, string username);
        bool AddGenre(string genre);
        List<Genre> GetGenres();
        bool AddRating(int id_series, int id_user, int ratingValue);
        Rating GetRating(int id_series, int id_user);
        bool UpdateRating(int id_series, int id_user, int ratingValue);
        int GetAverageRatingForSeries(int seriesId);
        bool AddSeries(string seriesName, byte[] picture, string description, List<Genre> genres, int numberOfSeasons);
        List<Series> GetSeries();
    }
}
