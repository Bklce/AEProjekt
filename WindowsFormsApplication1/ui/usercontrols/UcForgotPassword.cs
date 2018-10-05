using System.Windows.Forms;

namespace Seriendatenbank.ui.userControls
{
    public partial class UcForgotPassword : Template
    {
        private static UcForgotPassword instance;

        public static UcForgotPassword Instance
        {
            get
            {
                if (instance == null)
                    instance = new UcForgotPassword();
                return instance;
            }
        }

        public UcForgotPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            BringElementToFront(UcLogin.Instance);
            this.Dispose();
        }

        protected override void clear()
        {
        }
    }
}
