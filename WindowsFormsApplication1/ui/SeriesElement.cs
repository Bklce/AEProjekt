using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seriendatenbank.data;

namespace WindowsFormsApplication1.ui
{
    public partial class SeriesElement : UserControl
    {
        private Series serie;

        public SeriesElement(Series serie)
        {
            InitializeComponent();
            this.serie = serie;
            label1.Text = serie.SeriesName;
        }
    }
}
