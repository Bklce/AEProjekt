using System;
using System.Linq;
using Seriendatenbank.ui.userControls;
using Seriendatenbank.data;
using WindowsFormsApplication1.ui.events;
using WindowsFormsApplication1.util;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ui.usercontrols
{
    public partial class UcSerie : Template
    {
        private static UcSerie instance = null;
        private Series series;
     
    	public static UcSerie Instance
        {
            get
            {
                if (instance == null)
                	throw new Exception("Instance not created yet");
                return instance;
            }
        }
    	
    	public static void Create(Series series){
    		if(instance != null)
    			throw new Exception("Instance already created");
    		instance = new UcSerie(series);
    	}

        public static void Reset()
        {
            instance = null;
        }
    	
        private UcSerie()
        {
        	throw new Exception("Constructor is not to use");
        }
        
        private UcSerie(Series series)
        {
        	InitializeComponent();
        	if(series != null)
        	{
        		DisplaySeries(series);
           		CenterByPanel(pnl_content);
        	}
        	else
        	{
        		MessageBox.Show("Ups, das sollte so nicht sein ...");
        	}
        }
        
        private void DisplaySeries(Series series){
        	 this.series = series;
             lbl_series_name.Text = series.SeriesName;
             lbl_description.Text = series.Description;
             pb_series_picture.Image = PictureHelper.BitmapFromByteArray(series.Picture);
                
             FillRatingAffiliatedElements();
        }
        
        private void FillRatingAffiliatedElements(){
        	 Dictionary<int, Rating> userRatings = currentUser.Ratings;
             Rating rating = null;
             if(userRatings.ContainsKey(series.Id_series))
             	rating = userRatings[series.Id_series];
                
             if(rating != null)
             {
                 txt_rating.Text = rating.RatingValue.ToString();
                 tb_favorite.SetState(rating.Favorite);
                 tb_marked.SetState(rating.Marked);
                 tb_seen.SetState(rating.Seen);
             }
             else{
                 txt_rating.Text = "0";
                 tb_favorite.SetState(false);
                 tb_marked.SetState(false);
                 tb_seen.SetState(false);
             } 
        }
        
        private Rating GetCurrentRating(){
			return new Rating(series.Id_series, currentUser.Id, tb_favorite.IsDown, tb_marked.IsDown, tb_seen.IsDown, Int32.Parse(txt_rating.Text));
		}
        
		private void Btn_backClick(object sender, EventArgs e)
		{
			currentUser.Ratings = dataAccess.GetAllRatings(currentUser.Id);
			Notify(this, new EventData(UcSeries.Instance));
		}
		
		private void Btn_change_ratingClick(object sender, EventArgs e)
		{
			//check ratingValue == number
			int ratingValue;
			if(!String.IsNullOrEmpty(txt_rating.Text) || !Int32.TryParse(txt_rating.Text, out ratingValue) || ratingValue < 0 || ratingValue > 100){
				MessageBox.Show("Der Wertebereich für Bewertungen liegt zwischen 0 - 100.");
				txt_rating.Text = currentUser.Ratings[series.Id_series].RatingValue.ToString();
				return;
			} 
			
			if(dataAccess.UpdateOrAddRating(GetCurrentRating()))
			{
				MessageBox.Show("Erfolg!");
			}
			else{
				Rating rating = currentUser.Ratings[series.Id_series];
				tb_favorite.SetState(rating.Favorite);
				tb_marked.SetState(rating.Marked);
				tb_seen.SetState(rating.Seen);
				txt_rating.Text = rating.RatingValue.ToString();
				MessageBox.Show("Bewertung konnte nicht geändert werden.");
			}
		}
		
		private void Tb_favoriteClick(object sender, EventArgs e)
		{
			tb_favorite.SetState(!tb_favorite.IsDown);		
		}
		
		private void Tb_markedClick(object sender, EventArgs e)
		{
			tb_marked.SetState(!tb_marked.IsDown);		
		}
		
		private void Tb_seenClick(object sender, EventArgs e)
		{
			tb_seen.SetState(!tb_seen.IsDown);		
		}
    }
}
