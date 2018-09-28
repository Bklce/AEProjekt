using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.database;
using WindowsFormsApplication1.data;
using WindowsFormsApplication1.util;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            DataAccess Testen = DataAccess.GetInstance();
            User Benutzername = Testen.GetUser(txbx_Username.Text);
            //Passwort vergleichen
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            DataAccess Registrieren = DataAccess.GetInstance();
            if (Registrieren.AddUser(txbx_Username.Text, txbx_Password.Text))
                MessageBox.Show("Der Benutzer ist erfolgreich angelegt");
            else
                MessageBox.Show("Der Benutzer konnte nicht angelegt werden");
        }
    }
}