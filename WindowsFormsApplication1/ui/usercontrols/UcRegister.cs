using System;
using System.Windows.Forms;
using WindowsFormsApplication1.ui.events;

namespace Seriendatenbank.ui.userControls
{
    public partial class UcRegister : Template
    {
        private static UcRegister instance = null;

        public static UcRegister Instance
        {
            get
            {
                if (instance == null)
                    instance = new UcRegister();
                return instance;
            }
        }
        
        public static void Reset()
        {
            instance = null;
        }

        private UcRegister()
        {
            InitializeComponent();
            CenterByPanel(pnl_content);
        }

        private void btn_registrieren_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_username.Text))
                MessageBox.Show("Benutzername darf nicht leer sein");
            else if (String.IsNullOrWhiteSpace(txt_password.Text))
                MessageBox.Show("Passwort darf nicht leer sein");
            else if (String.IsNullOrWhiteSpace(txt_password2.Text))
                MessageBox.Show("Das Passwort muss wiederholt werden");
            else if (txt_password.Text != txt_password2.Text)
                MessageBox.Show("Die Passwörter stimmen nicht überein");
            else
            {
                if (dataAccess.AddUser(txt_username.Text, txt_password.Text))
                {
                    MessageBox.Show("Der Benutzer wurde erfolgreich angelegt");
                    BringElementToFront(UcLogin.Instance);
                }
                else
                    MessageBox.Show("Der Benutzer konnte nicht angelegt werden (möglicherweise ist der Benutzername bereits vergeben)");
            }
        }

        private void btn_abbrechen_Click(object sender, EventArgs e)
        {
        	Notify(this, new EventData(UcLogin.Instance));
        }

		private void Btn_backClick(object sender, EventArgs e)
		{
			Notify(this, new EventData(UcLogin.Instance));
		}
    }
}
