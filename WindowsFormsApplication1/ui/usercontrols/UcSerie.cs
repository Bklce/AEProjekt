using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seriendatenbank.ui.userControls;

namespace WindowsFormsApplication1.ui.usercontrols
{
    public partial class UcSerie : Template
    {
        public UcSerie()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Notify(this, UcSeries.Instance);
        }

    }
}
