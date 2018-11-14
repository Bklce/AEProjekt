
using System.Collections.Generic;
using WindowsFormsApplication1.api.data;

namespace Seriendatenbank.data
{
    public class Series
    {
        public Series(int id_series, string seriesName, byte[] picture, string description)
        {
            Id_series = id_series;
            SeriesName = seriesName;
            Picture = picture;
            Description = description;
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
        { get; set; }

        public List<Season> Seasons
        { get; set; }
        
        public AverageRating AverageRating
        { get; set; }
    }
}
