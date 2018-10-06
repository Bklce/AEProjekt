using System.Windows.Forms;

namespace Seriendatenbank.ui.userControls
{
    public partial class UcForgotPassword : Template
    {
        private static UcForgotPassword instance = null;

        public static UcForgotPassword Instance
        {
            get
            {
                if (instance == null)
                    instance = new UcForgotPassword();
                return instance;
            }
        }

        private UcForgotPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Notify(this, UcLogin.Instance);
        }

        public static void Reset()
        {
            instance = null;
        }
    }
}
