using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Seriendatenbank.ui.userControls;
using WindowsFormsApplication1.ui.usercontrols;
using WindowsFormsApplication1.ui;

namespace Seriendatenbank
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            //Subscriben an allen UserControls
            Template.Subscribe(this);

            //LogIn Maske Initial einblenden
            UcLogin login = UcLogin.Instance;
            pnl_root.Controls.Add(login);
            login.Dock = DockStyle.Fill;
            login.BringToFront();

          //  Type objType = Type.GetType(typeof(UcLogin).FullName+", " + typeof(UcLogin).AssemblyQualifiedName + ", Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");
          //  UcLogin obj = (UcLogin)Activator.CreateInstance(objType);
        }

        //Updaten des angezeigten UserControls, wegräumen des alten
        public void Update(Template src, UcEvent e)
        {
            var direct = new Dictionary<Type, Action> {
                { typeof(UcLogin), () => BringElementToFront(UcLogin.Instance)},
                { typeof(UcRegister), () => BringElementToFront(UcRegister.Instance)},
                { typeof(UcForgotPassword), () => BringElementToFront(UcForgotPassword.Instance) },
                { typeof(UcSeries), () => BringElementToFront(UcSeries.Instance) },
                { typeof(UcAddSeries), () => BringElementToFront(UcAddSeries.Instance) },
            }; 
            @direct[e.Destination.GetType()]();

            if (e.Dispose) { 
                pnl_root.Controls.Remove(src);

                var dispose = new Dictionary<Type, Action> {
                    { typeof(UcLogin), () => UcLogin.Reset()},
                    { typeof(UcRegister), () =>  UcRegister.Reset()},
                    { typeof(UcForgotPassword), () =>  UcForgotPassword.Reset()},
                    { typeof(UcSeries), () =>  UcSeries.Reset()},
                    { typeof(UcAddSeries), () =>  UcAddSeries.Reset()},
                };
                @dispose[src.GetType()]();
            }
        }

        private void BringElementToFront(Template element)
        {
            if (!pnl_root.Contains(element))
                pnl_root.Controls.Add(element);
            element.Dock = DockStyle.Fill;
            element.BringToFront();
        }

    }
}