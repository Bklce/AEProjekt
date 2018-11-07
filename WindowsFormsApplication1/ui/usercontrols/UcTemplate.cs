using System.Collections.Generic;
using System.Windows.Forms;
using Seriendatenbank.data;
using Seriendatenbank.database;
using WindowsFormsApplication1.api;
using WindowsFormsApplication1.ui.events;

namespace Seriendatenbank.ui.userControls
{
    public partial class Template : UserControl { 
        protected DataAccess dataAccess = DataAccess.GetInstance();
        protected static User currentUser;
        private static List<MainWindow> observers = new List<MainWindow>();

        protected Template(){
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

        protected void Notify(Template src, EventData e)
        {
            observers.ForEach(o => o.Update(src, e));
        }

        public static void SetUser(User user)
        {
            currentUser = user;
        }
        
        protected void CenterByPanel(Panel panel){
        	panel.Left = (panel.Parent.Width - panel.Width) / 2;
            panel.Top = (panel.Parent.Height - panel.Height) / 2;
        }
    
    }
}
