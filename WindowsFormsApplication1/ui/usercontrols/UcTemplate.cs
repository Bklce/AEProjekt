using System.Collections.Generic;
using System.Windows.Forms;
using Seriendatenbank.data;
using Seriendatenbank.database;

namespace Seriendatenbank.ui.userControls
{
    public partial class Template : UserControl
    {
        protected DataAccess dataAccess = DataAccess.GetInstance();
        protected static User currentUser;
        private static List<MainWindow> observers = new List<MainWindow>();

        public Template(){
            this.Height = 515;
            this.Width = 951;
        }                        

        protected void BringElementToFront(Template element)
        {
            if (this.Parent == null || this.Parent.GetType() != typeof(Panel))
                return;

            Panel parent = (this.Parent as Panel);
            if (!parent.Contains(element))
                parent.Controls.Add(element);
            element.Dock = DockStyle.Fill;
            element.BringToFront();
        }

        public static void Subscribe(MainWindow observer)
        {
            observers.Add(observer);
        }

        protected void Notify(Template src, Template dst)
        {
            //observers.ForEach(e => e.Update(src, dst));
        }

        public static void SetUser(User user)
        {
            currentUser = user;
        }
    }
}
