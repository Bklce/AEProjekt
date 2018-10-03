
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
        { get; }

        public string SeriesName
        { get; }

        public byte[] Picture
        { get; }

        public string Description
        { get; }

        public List<Genre> Genres
        { get; }

        public int NumberOfSeasons
        { get; }
    }
}
