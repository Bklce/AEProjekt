using Seriendatenbank.data;
using Seriendatenbank.ui.userControls;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ui.usercontrols
{
    public partial class UcSeries : Template
    {
        private static UcSeries instance = null;
        private Dictionary<int, Series> series;
        public static UcSeries Instance
        {
            get
            {
                if (instance == null)
                    instance = new UcSeries();
                return instance;
            }
        }

        public UcSeries()
        {
            InitializeComponent();
            series = dataAccess.GetSeries();
            LoadSeries(series);
            
            
        }

        private void LoadSeries(Dictionary<int, Series> series)
        {
//            List<Series> series = dataAccess.GetSeries();
            int elementCount = 0;
            foreach (KeyValuePair<int, Series> serie in series)
            {
                if (elementCount == 3)
                {
                    tlPanel.RowCount = tlPanel.RowCount + 1;
                    elementCount = 0;
                }

                tlPanel.Controls.Add(new SeriesElement(serie.Value), elementCount, tlPanel.RowCount - 1);
                elementCount++;
            }

        }

        public static void Reset()
        {
            instance = null;
        }

        private void btn_add_series_Click(object sender, System.EventArgs e)
        {
            Notify(this, UcAddSeries.Instance);
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            currentUser = null;
            Notify(this, UcLogin.Instance);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            tlPanel.Controls.Clear();
            Dictionary<int, Rating> ratings = dataAccess.GetAllRatings(currentUser.Id);
            Dictionary<int, Series> favourites = new Dictionary<int, Series>();
            if (ratings != null)
            {
                foreach (KeyValuePair<int, Rating> favourite_test in ratings)
                {
                    if (favourite_test.Value.Favorite)
                    {
                        int IdSeries = favourite_test.Value.Id_series;
                        favourites.Add(IdSeries, series[IdSeries]);
                    }
                }
                LoadSeries(favourites);
            }
        

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            tlPanel.Controls.Clear();
            Dictionary<int, Rating> ratings = dataAccess.GetAllRatings(currentUser.Id);
            Dictionary<int, Series> favourites = new Dictionary<int, Series>();
            if (ratings != null)
            {
                foreach (KeyValuePair<int, Rating> favourite_test in ratings)
                {
                    if (favourite_test.Value.Marked)
                    {
                        int IdSeries = favourite_test.Value.Id_series;
                        favourites.Add(IdSeries, series[IdSeries]);
                    }
                }
                LoadSeries(favourites);
            }

        }
    }
}
