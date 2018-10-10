using System.Windows.Forms;
using Seriendatenbank.data;
using WindowsFormsApplication1.util;

namespace WindowsFormsApplication1.ui
{
    public partial class SeriesElement : UserControl
    {
        private Series serie;
        public SeriesElement() { InitializeComponent(); }

        public SeriesElement(Series serie)
        {
            InitializeComponent();
            this.serie = serie;
            lbl_series_name.Text = serie.SeriesName;
            pb_series_picture.Image = PictureHelper.BitmapFromByteArray(serie.Picture);
        }
    }
}
