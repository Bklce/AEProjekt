using System;
using System.Windows.Forms;
using Seriendatenbank.data;
using Seriendatenbank.util;

namespace Seriendatenbank.ui.userControls
{
    public partial class UcLogin : Template
    {
        private static UcLogin instance;

        public static UcLogin Instance
        {
            get
            {
                if (instance == null)
                    instance = new UcLogin();
                return instance;
            }
        }

        public UcLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_username.Text))
                MessageBox.Show("Benutzername darf nicht leer sein");
            else if (String.IsNullOrWhiteSpace(txt_password.Text))
                MessageBox.Show("Passwort darf nicht leer sein");
            else
            {
                User user = dataAccess.GetUser(txt_username.Text);
                if (user != null && new Hash(txt_password.Text, user.Hash.Salt).Equals(user.Hash))
                    MessageBox.Show("Erfolg");
                else
                    MessageBox.Show("Benutzername oder Passwort scheinen falsch");
            }
        }

        private void btn_forgot_password_Click(object sender, EventArgs e)
        {
            BringElementToFront(UcForgotPassword.Instance);
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            BringElementToFront(UcRegister.Instance);
        }

        
    }
}
