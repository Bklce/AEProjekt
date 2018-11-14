using Seriendatenbank.data;
using Seriendatenbank.ui.userControls;
using System.Collections.Generic;
using WindowsFormsApplication1.ui.events;
using System.Linq;
using System.Windows.Forms;
using System;


namespace WindowsFormsApplication1.ui.usercontrols
{
    public partial class UcSeries : Template
    {
        private static UcSeries instance = null;
        private List<Series> series;
        private bool visible = false;
        
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

            series = dataAccess.GetSeries();
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
        
            foreach(Genre genre in dataAccess.GetGenres()){
                var cb = new CheckBox();
                cb.Text = genre.Description;
                cb.Name = "cb_" + genre.Description;
                fp_genreList.Controls.Add(cb);
            }
        }
      
        private List<Series> GetListOf(RatingType ratingType, List<string> genres){
        	tlPanel.Controls.Clear();
            Dictionary<int, Rating> ratings = dataAccess.GetAllRatings(currentUser.Id);
            currentUser.Ratings = ratings;
            List<Series> resutlSeries = new List<Series>();
            
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
                List<Series> filteredSeries = series.Where(x => filteredList.Contains(x.Id_series)).ToList();
                if (genres.Count > 0)
                {
                    foreach (Series serie in filteredSeries)
                    {
                        int bananenBrot = 0;
                        foreach (Genre genre in serie.Genres)
                        {
                            if (genres.Contains(genre.Description))
                            {
                                bananenBrot++;
                            }
                        }
                        if (bananenBrot == genres.Count)
                        {
                            resutlSeries.Add(serie);
                        }
                    }

                }
                else
                {
                    resutlSeries = filteredSeries;
                }
            }
            
            return resutlSeries;
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
		
		private void Btn_homeClick(object sender, System.EventArgs e)
		{
			List<Series> all = GetListOf(RatingType.ALL, new List<string>());
           	if (all != null) {
           		tlPanel.Controls.Clear();
            	LoadSeries(all);
          	}
		}

        private void btn_filter_Click(object sender, System.EventArgs e)
        {
            if (visible)
            {
                Timer timer = new Timer();
                timer.Interval = 10;
                timer.Tick += timer_backward_Tick;
                timer.Start();
            }
            else
            {
                pnl_filter.Visible = visible = true;
                pnl_filter.BringToFront();
                Timer timer = new Timer();
                timer.Interval = 10;
                timer.Tick += timer_forward_Tick;
                timer.Start();
            }
        }

        private void timer_forward_Tick(object sender, EventArgs e)
        {
            //400x300
            if (pnl_filter.Height < 300 && pnl_filter.Width < 400) 
            {
                pnl_filter.Height += 10;
                pnl_filter.Width += 12;
            }
            else 
            {
                ((Timer)sender).Stop();
            }
                
        }

        private void timer_backward_Tick(object sender, EventArgs e)
        {
            //400x300
            if (pnl_filter.Height > 1 && pnl_filter.Width > 1)
            {
                pnl_filter.Height -= 10;
                pnl_filter.Width -= 12;
            }
            else
            {
                ((Timer)sender).Stop();
                pnl_filter.Visible = visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RatingType type = RatingType.ALL;
           if (cb_favorit.Checked)
           {
               type = RatingType.FAVORITES;
           }
           else if (cb_gesehen.Checked)
           {
               type = RatingType.SEEN;
           }
           else if (cb_vermerkt.Checked)
           {
               type = RatingType.MARKED;
           }

            List<string> genres = new List<string>();
           foreach (Control control in fp_genreList.Controls)
           {
               if (control.GetType() == typeof(CheckBox))
               {
                   CheckBox box = (CheckBox)control;
                   if (box.Checked)
                   {
                       genres.Add(box.Text);
                   }
               }
           }
           tlPanel.Controls.Clear();
            LoadSeries(GetListOf(type, genres));
        }
        
    }
}
