﻿using Seriendatenbank.data;
using Seriendatenbank.util;
using System;
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

        public static void Reset()
        {
            instance = null;
        }

        private void btn_abbrechen_Click(object sender, System.EventArgs e)
        {
            Notify(this, UcLogin.Instance);
        }

        private void btn_registrieren_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_username.Text))
                MessageBox.Show("Benutzername darf nicht leer sein");
            else if (String.IsNullOrWhiteSpace(txt_password_current.Text))
                MessageBox.Show("Aktuelles Passwort darf nicht leer sein");
            else if (String.IsNullOrWhiteSpace(txt_password_new.Text))
                MessageBox.Show("Das neue Passwort darf nicht leer sein");
            else if (String.IsNullOrWhiteSpace(txt_password_new2.Text))
                MessageBox.Show("Das neue Passwort muss wiederholt werden");
            else if (txt_password_new.Text != txt_password_new2.Text)
                MessageBox.Show("Die neuen Passwörter stimmen nicht überein");
            else
            {
                User user = dataAccess.GetUser(txt_username.Text);
                if (user != null && user.Hash.Equals(new Hash(txt_password_current.Text, user.Hash.Salt)))
                {
                    if (dataAccess.UpdateUserPassword(txt_username.Text, txt_password_new.Text))
                    {
                        MessageBox.Show("Passwort wurde geändert.");
                        Notify(this, UcLogin.Instance);
                    }
                    else
                        MessageBox.Show("Das Passwort konnte nicht geändert werde, möglicherweise existiert der angegebene Benutzer nicht oder das eingegebene Passwort ist falsch.");
                }
                else
                    MessageBox.Show("Das Passwort konnte nicht geändert werde, möglicherweise existiert der angegebene Benutzer nicht oder das eingegebene Passwort ist falsch.");
            }
        }
    }
}
