using System;
using System.Windows.Forms;
using WindowsFormsApplication1.database;
using WindowsFormsApplication1.data;
using WindowsFormsApplication1.util;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private DataAccess dataAccess = DataAccess.GetInstance();

        public Form1()
        {
            InitializeComponent();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            User user = dataAccess.GetUser(txbx_Username.Text);
            if(user != null && new Hash(txbx_Password.Text, user.Hash.Salt).Equals(user.Hash))
                MessageBox.Show("Erfolg");
            else
                 MessageBox.Show("Benutzername oder Password scheinen falsch");
        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            if (dataAccess.AddUser(txbx_Username.Text, txbx_Password.Text))
                MessageBox.Show("Der Benutzer wurde erfolgreich angelegt");
            else
                MessageBox.Show("Der Benutzer konnte nicht angelegt werden (möglicherweise ist der Benutzername bereits vergeben)");
        }
    }
}