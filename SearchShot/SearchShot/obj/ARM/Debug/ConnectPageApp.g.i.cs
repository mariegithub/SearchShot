﻿#pragma checksum "C:\Users\yechoua\Documents\GitHub\SearchShot\SearchShot\SearchShot\ConnectPageApp.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B355A616AD41F5CE8B6DC368C110B521"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34003
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace SearchShot {
    
    
    public partial class ConnectPageApp : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button BtnLogin;
        
        internal System.Windows.Controls.PasswordBox Password;
        
        internal System.Windows.Controls.TextBox Login;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/SearchShot;component/ConnectPageApp.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.BtnLogin = ((System.Windows.Controls.Button)(this.FindName("BtnLogin")));
            this.Password = ((System.Windows.Controls.PasswordBox)(this.FindName("Password")));
            this.Login = ((System.Windows.Controls.TextBox)(this.FindName("Login")));
        }
    }
}

