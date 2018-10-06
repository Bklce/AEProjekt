﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Seriendatenbank.ui.userControls;

namespace Seriendatenbank
{
    public partial class MainWindow : Form
    {
        public const int HEIGHT = 438;
        public const int WIDTH = 772;

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
        public void Update(Template src, Template dst)
        {
            var direct = new Dictionary<Type, Action> {
                { typeof(UcLogin), () => BringElementToFront(UcLogin.Instance)},
                { typeof(UcRegister), () => BringElementToFront(UcRegister.Instance)},
                { typeof(UcForgotPassword), () => BringElementToFront(UcForgotPassword.Instance) },
            }; 
            @direct[dst.GetType()]();

            pnl_root.Controls.Remove(src);

            var dispose = new Dictionary<Type, Action> {
                { typeof(UcLogin), () => UcLogin.Reset()},
                { typeof(UcRegister), () =>  UcRegister.Reset()},
                { typeof(UcForgotPassword), () =>  UcForgotPassword.Reset()},
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