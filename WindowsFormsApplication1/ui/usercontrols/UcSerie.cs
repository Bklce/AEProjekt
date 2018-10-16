using System;
using System.Linq;
using Seriendatenbank.ui.userControls;
using Seriendatenbank.data;
using WindowsFormsApplication1.ui.events;
using WindowsFormsApplication1.util;
using System.Collections.Generic;
using System.Windows.Forms;
using Seriendatenbank.data;

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
        		this.series = series;
        		lbl_series_name.Text = series.SeriesName;
        		lbl_description.Text = series.Description;
        		pb_series_picture.Image = PictureHelper.BitmapFromByteArray(series.Picture);
        		
        		Dictionary<int, Rating> userRatings = currentUser.Ratings;
        		if(userRatings.ContainsKey(series.Id_series))
                    txt_rating.Text = userRatings[series.Id_series].RatingValue.ToString();
                else
                    txt_rating.Text = "0";
        		
           		pnl_content.Left = (pnl_content.Parent.Width - pnl_content.Width) / 2;
            	pnl_content.Top = (pnl_content.Parent.Height - pnl_content.Height) / 2;
        	}
        }
        
		private void Btn_backClick(object sender, EventArgs e)
		{
			Notify(this, new EventData(UcSeries.Instance));
		}
		
		private void Btn_change_ratingClick(object sender, EventArgs e)
		{
			if(dataAccess.UpdateOrAddRating(new Rating(this.series.Id_series, currentUser.Id, Int32.Parse(txt_rating.Text))))
				MessageBox.Show("Erfolg!");
			else
				MessageBox.Show("Bewertung konnte nicht geändert werden.");
		}
    }
}
