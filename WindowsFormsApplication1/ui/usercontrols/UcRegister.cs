namespace Seriendatenbank.ui.userControls
{
    public partial class UcRegister : Template
    {
        private static UcRegister instance;

        public static UcRegister Instance
        {
            get
            {
                if (instance == null)
                    instance = new UcRegister();
                return instance;
            }
        }

        public UcRegister()
        {
            InitializeComponent();
        }

        /*
        private void btn_register_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_username.Text))
                MessageBox.Show("Benutzername darf nicht leer sein");
            else if (String.IsNullOrWhiteSpace(txt_password.Text))
                MessageBox.Show("Passwort darf nicht leer sein");
            else
            {
                if (dataAccess.AddUser(txt_username.Text, txt_password.Text))
                    MessageBox.Show("Der Benutzer wurde erfolgreich angelegt");
                else
                    MessageBox.Show("Der Benutzer konnte nicht angelegt werden (möglicherweise ist der Benutzername bereits vergeben)");
            }
        }
        */

        
        protected override void clear()
        {

        }
    }
}
