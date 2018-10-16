using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Seriendatenbank.ui.userControls;
using WindowsFormsApplication1.ui.usercontrols;
using WindowsFormsApplication1.ui.events;
using Seriendatenbank.data;

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
        }

        //Updaten des angezeigten UserControls, wegräumen des alten
        public void Update(Template src, EventData e)
        {
            var direct = new Dictionary<Type, Action> {
                { typeof(UcLogin), () => BringElementToFront(UcLogin.Instance)},
                { typeof(UcRegister), () => BringElementToFront(UcRegister.Instance)},
                { typeof(UcForgotPassword), () => BringElementToFront(UcForgotPassword.Instance) },
                { typeof(UcSeries), () => BringElementToFront(UcSeries.Instance) },
                { typeof(UcSerie), () =>  BringElementToFront(UcSerie.Instance) },
                { typeof(UcAddSeries), () => BringElementToFront(UcAddSeries.Instance) },
            }; 
            @direct[e.Destination.GetType()]();

            pnl_root.Controls.Remove(src);

            var dispose = new Dictionary<Type, Action> {
                { typeof(UcLogin), () => UcLogin.Reset()},
                { typeof(UcRegister), () =>  UcRegister.Reset()},
                { typeof(UcForgotPassword), () =>  UcForgotPassword.Reset()},
                { typeof(UcSeries), () =>  UcSeries.Reset()},
                { typeof(UcSerie), () =>  UcSerie.Reset()},
                { typeof(UcAddSeries), () =>  UcAddSeries.Reset()},
            };
            @dispose[src.GetType()]();
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