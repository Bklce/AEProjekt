using System.Windows.Forms;
using Seriendatenbank.database;

namespace Seriendatenbank.ui.userControls
{
    public abstract partial class Template : UserControl
    {
        protected DataAccess dataAccess = DataAccess.GetInstance();

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

        abstract protected void clear();
    }
}
