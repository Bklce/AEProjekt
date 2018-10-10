using Seriendatenbank.data;
using Seriendatenbank.ui.userControls;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ui.usercontrols
{
    public partial class UcSeries : Template
    {
        private static UcSeries instance = null;

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
            
            List<Series> series = dataAccess.GetSeries();
            Dictionary<int, Rating> ratings = dataAccess.GetAllRatings(currentUser.Id);
            for(int i = 0; i< 8; i++)
            {
                series.Add(series[0]);
            }
            int elementCount = 0;
            foreach(Series serie in series)
            {
                if (elementCount == 3)
                {
                    tlPanel.RowCount = tlPanel.RowCount + 1;
                    elementCount = 0;
                }

                tlPanel.Controls.Add(new SeriesElement(serie), elementCount, tlPanel.RowCount - 1 );
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
    }
}
