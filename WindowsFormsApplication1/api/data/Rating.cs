
namespace Seriendatenbank.data
{
    public class Rating
    {
        public Rating(int id_series, int id_user, bool favorite, bool marked, bool seen, int rating)
        {
            Id_series = id_series;
            Id_user = id_user;
            Favorite = favorite;
            Marked = marked;
            Seen = seen;
            RatingValue = rating;
        }

        public int Id_series
        { get; set; }

        public int Id_user
        { get; set; }

        public bool Favorite
        { get; set; }

        public bool Marked
        { get; set; }

        public bool Seen
        { get; set; }

        public int RatingValue
        { get; set; }
        
    }
}
