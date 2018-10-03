using System.Windows.Forms;
using Seriendatenbank.ui.userControls;

namespace Seriendatenbank
{
    public partial class MainWindow : Form
    {
        public const int HEIGHT = 438;
        public const int WIDTH = 772;

        public MainWindow()
        {
            InitializeComponent();

            UcLogin login = UcLogin.Instance;
            pnl_root.Controls.Add(login);
            login.Dock = DockStyle.Fill;
            login.BringToFront();
        }
    }
}