using Seriendatenbank.data;
using Seriendatenbank.ui.userControls;
using System.Collections.Generic;
using WindowsFormsApplication1.ui.events;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ui.usercontrols
{
    public partial class UcSeries : Template
    {
        private static UcSeries instance = null;
        private List<Series> series;
        
        public static UcSeries Instance
        {
            get
            {
                if (instance == null)
                    instance = new UcSeries();
                return instance;
            }
        }
        
        public static void Reset()
        {
            instance = null;
        }

        private UcSeries()
        {
            InitializeComponent();
            CenterByPanel(pnl_content);
            
            series = dataAccess.GetSeriesWithAverageRatings();
            LoadSeries(series);
        }

        private void LoadSeries(List<Series> series)
        {
            int elementCount = 0;
            foreach (Series serie in series)
            {
                if (elementCount == 3)
                {
                    tlPanel.RowCount = tlPanel.RowCount + 1;
                    elementCount = 0;
                }

                var element = new SeriesElement(serie);
                tlPanel.Controls.Add(element, elementCount, tlPanel.RowCount - 1);
               
                elementCount++;
            }
        }
      
        private List<Series> GetListOf(RatingType ratingType){
        	tlPanel.Controls.Clear();
            Dictionary<int, Rating> ratings = dataAccess.GetAllRatings(currentUser.Id);
            currentUser.Ratings = ratings;
            
            if (ratings != null)
            {
            	var filteredList = new List<int>();
            	switch(ratingType){
                    	case RatingType.FAVORITES:
            				filteredList = ratings.Where(x => x.Value.Favorite).Select(x => x.Value.Id_series).ToList();
                    		break;
                    	case RatingType.MARKED:
            				filteredList = ratings.Where(x => x.Value.Marked).Select(x => x.Value.Id_series).ToList();
                    		break; 
                    	case RatingType.SEEN:
            				filteredList = ratings.Where(x => x.Value.Seen).Select(x => x.Value.Id_series).ToList();
                    		break;
                    	case RatingType.ALL:
            				filteredList = series.Select(x => x.Id_series).ToList();
                    		break;
                }
            	return series.Where(x => filteredList.Contains(x.Id_series)).ToList();
            }
            
            return null;
        }
        
        private enum RatingType{
        	ALL, FAVORITES, MARKED, SEEN
        }
        
        private void Btn_add_series_Click(object sender, System.EventArgs e)
        {
        	Notify(this, new EventData(UcAddSeries.Instance));
        }

        private void Btn_logoutClick(object sender, System.EventArgs e)
        {
            currentUser = null;
            Notify(this,  new EventData(UcLogin.Instance));
        }

        private void Btn_favoritesClick(object sender, System.EventArgs e)
        {
            List<Series> favorites = GetListOf(RatingType.FAVORITES);
            if (favorites != null) {
            	tlPanel.Controls.Clear();
            	LoadSeries(favorites);
            }
        }

        private void Btn_markedClick(object sender, System.EventArgs e)
        {
           List<Series> marked = GetListOf(RatingType.MARKED);
           if (marked != null) {
           		tlPanel.Controls.Clear();
            	LoadSeries(marked);
           }
        }
        
		private void Btn_seenClick(object sender, System.EventArgs e)
		{
			List<Series> seen = GetListOf(RatingType.SEEN);
           	if (seen != null) {
           		tlPanel.Controls.Clear();
            	LoadSeries(seen);
          	}
		}
		
		private void Btn_homeClick(object sender, System.EventArgs e)
		{
			List<Series> all = GetListOf(RatingType.ALL);
           	if (all != null) {
           		tlPanel.Controls.Clear();
            	LoadSeries(all);
          	}
		}
    }
}
