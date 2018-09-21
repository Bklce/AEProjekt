
namespace WindowsFormsApplication1.data
{
    class Rating
    {
        private int id_series;
        private int id_user;
        private bool favorite;
        private bool marked;
        private bool seen;
        private int ratingValue;

        private Rating(int id_series, int id_user, bool favorite, bool marked, bool seen, int rating)
        {
            this.id_series = id_series;
            this.id_user = id_user;
            this.favorite = favorite;
            this.marked = marked;
            this.seen = seen;
            this.ratingValue = rating;
        }

        public int Id_series
        { get; set; }

        public int Id_user
        { get; set; }

        public int Favorite
        { get; set; }

        public int Marked
        { get; set; }

        public int Seen
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
                return new Rating(this.id_series, id_user, favorite, marked, seen, rating);
            }    
        }
    }
}
