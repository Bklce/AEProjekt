
namespace Seriendatenbank.data
{
    public class Rating
    {
        private Rating(int id_series, int id_user, bool favorite, bool marked, bool seen, int rating)
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


        public class RatingBuilder{
            private int id_series;
            private int id_user;
            private bool favorite = false;
            private bool marked = false;
            private bool seen = false;
            private int rating = -1;

            public RatingBuilder(int id_series, int id_user)
            {
                this.id_series = id_series;
                this.id_user = id_user;
            }

            public RatingBuilder SetFavorite(bool favorite)
            {
                this.favorite = favorite;
                return this;
            }

            public RatingBuilder SetMarked(bool marked)
            {
                this.marked = marked;
                return this;
            }

            public RatingBuilder SetSeen(bool seen)
            {
                this.seen = seen;
                return this;
            }

            public RatingBuilder SetRating(int rating)
            {
                this.rating = rating;
                return this;
            }

            public Rating Build()
            {
                return new Rating(id_series, id_user, favorite, marked, seen, rating);
            }    
        }
    }
}
