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

            ScrollBar vScrollBar1 = new VScrollBar();
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Scroll += (sender, e) => { tlPanel.VerticalScroll.Value = vScrollBar1.Value; };
            tlPanel.Controls.Add(vScrollBar1);

            List<Series> series = dataAccess.GetSeries();
            int elementCount = 0;
            foreach(Series serie in series)
            {
                if (elementCount == 3)
                {
                    tlPanel.RowCount = tlPanel.RowCount + 1;
                    elementCount = 0;
                }

                tlPanel.Controls.Add(new SeriesElement(serie), elementCount, tlPanel.RowCount - 1);
                elementCount++;
            }
        }

        public static void Reset()
        {
            instance = null;
        }

    }
}
