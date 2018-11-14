
using System.Collections.Generic;
using Seriendatenbank.data;

namespace Seriendatenbank.api
{
    interface IDataAccess
    {
        bool AddUser(string username, string password);
        User GetUser(string username);
        bool UpdateUserPassword(string username, string password);
        bool UpdateUserUsername(string username, string usernameNew);
        bool AddGenre(string genre);
        List<Genre> GetGenres();
        Rating GetRating(int id_series, int id_user);
        bool UpdateOrAddRating(Rating rating);
        bool AddSeries(string seriesName, byte[] picture, string description, List<Genre> genres, int numberOfSeasons);
        List<Series> GetSeries();
    }
}
