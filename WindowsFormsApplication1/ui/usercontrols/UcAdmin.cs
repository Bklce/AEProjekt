using System;
using Seriendatenbank.ui.userControls;
using WindowsFormsApplication1.ui.events;

namespace WindowsFormsApplication1.ui.usercontrols
{
	public partial class UcAdmin : Template
	{
		private static UcAdmin instance = null;

        public static UcAdmin Instance
        {
            get
            {
                if (instance == null)
                    instance = new UcAdmin();
                return instance;
            }
        }
        
        public static void Reset()
        {
            instance = null;
        }

        private UcAdmin()
        {
            InitializeComponent();
            CenterByPanel(pnl_content);
        }
        
		private void Btn_add_seriesClick(object sender, EventArgs e)
		{
			Notify(this, new EventData(UcAddSeries.Instance, null, false));
		}
	}
}
