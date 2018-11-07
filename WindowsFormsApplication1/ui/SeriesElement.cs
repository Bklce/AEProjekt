using Seriendatenbank.data;
using WindowsFormsApplication1.util;
using WindowsFormsApplication1.ui.usercontrols;
using Seriendatenbank.ui.userControls;
using WindowsFormsApplication1.ui.events;

namespace WindowsFormsApplication1.ui
{
    public partial class SeriesElement : Template
    {
        public SeriesElement(Series serie)
        {
            InitializeComponent();
            Series = serie;
            lbl_series_name.Text = serie.SeriesName;
            pb_series_picture.Image = PictureHelper.BitmapFromByteArray(serie.Picture);
            if (serie.AverageRating.AverageRatingValue > 0)
                lbl_points.Text = serie.AverageRating.AverageRatingValue.ToString();
            else
                lbl_points.Text = "";

            lbl_series_name.Click += new System.EventHandler(this.on_series_element_Click);
            pb_series_picture.Click += new System.EventHandler(this.on_series_element_Click);
            
            pnl_content.Left = (pnl_content.Parent.Width - pnl_content.Width) / 2;
            pnl_content.Top = (pnl_content.Parent.Height - pnl_content.Height) / 2;
        }
        
        public Series Series
        { get; private set; }
        
        private void on_series_element_Click(object sender, System.EventArgs e)
        {
        	UcSerie.Create(Series);
        	Notify(UcSeries.Instance, new EventData(UcSerie.Instance));
        }
    }
}
