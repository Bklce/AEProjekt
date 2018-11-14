using System;
using System.Windows.Forms;
using Seriendatenbank.data;
using Seriendatenbank.util;
using WindowsFormsApplication1.ui.events;
using WindowsFormsApplication1.ui.usercontrols;

namespace Seriendatenbank.ui.userControls
{
    public partial class UcLogin : Template
    {
        private static UcLogin instance = null;

        public static UcLogin Instance
        {
            get
            {
                if (instance == null)
                    instance = new UcLogin();
                return instance;
            }
        }
        
        public static void Reset()
        {
            instance = null;
        }

        private UcLogin()
        {
            InitializeComponent();
            CenterByPanel(pnl_content);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_username.Text))
                MessageBox.Show("Benutzername darf nicht leer sein");
            else if (String.IsNullOrWhiteSpace(txt_password.Text))
                MessageBox.Show("Passwort darf nicht leer sein");
            else
            {
                User user = dataAccess.GetUserWithRating(txt_username.Text);
                if (user != null && new Hash(txt_password.Text, user.Hash.Salt).Equals(user.Hash))
                {
                    currentUser = user;
                    Notify(this, new EventData(UcSeries.Instance));
                }
                else
                    MessageBox.Show("Benutzername oder Passwort scheinen falsch");
            }
        }

        private void btn_forgot_password_Click(object sender, EventArgs e)
        {
        	Notify(this,  new EventData(UcForgotPassword.Instance));
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
        	Notify(this, new EventData(UcRegister.Instance));
        }
    }
}
