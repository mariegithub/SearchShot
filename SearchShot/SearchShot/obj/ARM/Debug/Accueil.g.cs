﻿#pragma checksum "C:\Users\yechoua\Documents\Visual Studio 2013\Projects\SearchShot\SearchShot\Accueil.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4749602DEC9EA3A325238631C4D41796"
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
    
    
    public partial class Accueil : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button BtnJouer;
        
        internal System.Windows.Controls.Button BtnClassement;
        
        internal System.Windows.Controls.Button BtnOptions;
        
        internal System.Windows.Controls.Button BtnAmis;
        
        internal System.Windows.Controls.Button BtnQuitter;
        
        internal System.Windows.Controls.TextBlock PlayerName;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/SearchShot;component/Accueil.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.BtnJouer = ((System.Windows.Controls.Button)(this.FindName("BtnJouer")));
            this.BtnClassement = ((System.Windows.Controls.Button)(this.FindName("BtnClassement")));
            this.BtnOptions = ((System.Windows.Controls.Button)(this.FindName("BtnOptions")));
            this.BtnAmis = ((System.Windows.Controls.Button)(this.FindName("BtnAmis")));
            this.BtnQuitter = ((System.Windows.Controls.Button)(this.FindName("BtnQuitter")));
            this.PlayerName = ((System.Windows.Controls.TextBlock)(this.FindName("PlayerName")));
        }
    }
}

