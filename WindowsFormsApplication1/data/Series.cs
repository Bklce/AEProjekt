using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.data
{
    class Series
    {
        private int id_series;
        private string seriesName;
        private byte[] picture;

        public Series(int id_series, string seriesName, byte[] picture)
        {
            this.id_series = id_series;
            this.seriesName = seriesName;
            this.picture = picture;
        }

        public int Id_series
        { get; }

        public int SeriesName
        { get; }

        public int Picture
        { get; }
    }
}
