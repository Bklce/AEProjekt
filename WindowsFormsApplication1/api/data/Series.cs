
using System.Collections.Generic;

namespace Seriendatenbank.data
{
    public class Series
    {
        public Series(int id_series, string seriesName, byte[] picture, string description, List<Genre> genres, int numberOfSeasons)
        {
            Id_series = id_series;
            SeriesName = seriesName;
            Picture = picture;
            Description = description;
            Genres = genres;
            NumberOfSeasons = numberOfSeasons;
        }

        public int Id_series
        { get; private set; }

        public string SeriesName
        { get; private set; }

        public byte[] Picture
        { get; private set; }

        public string Description
        { get; private set; }

        public List<Genre> Genres
        { get; private set; }

        public int NumberOfSeasons
        { get; private set; }
        
        public int AverageRating
        { get; set; }
    }
}
