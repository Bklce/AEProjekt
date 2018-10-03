
using System.Collections.Generic;

namespace WindowsFormsApplication1.data
{
    class Series
    {
        private int id_series;
        private string seriesName;
        private byte[] picture;
        private string description;
        private List<Genre> genres;
        private int numberOfSeasons;

        public Series(int id_series, string seriesName, byte[] picture, string description, List<Genre> genres, int numberOfSeasons)
        {
            this.id_series = id_series;
            this.seriesName = seriesName;
            this.picture = picture;
            this.description = description;
            this.genres = genres;
            this.numberOfSeasons = numberOfSeasons;
        }

        public int Id_series
        { get; }

        public int SeriesName
        { get; }

        public int Picture
        { get; }

        public int Description
        { get; }

        public List<Genre> Genres
        { get; }

        public int NumberOfSeasons
        { get; }
    }
}
