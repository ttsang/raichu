﻿#pragma checksum "Z:\Documents\SJSU\Cmpe 195b\raichu\mobile\raichumobile2\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6647316AA21B6FBC9A71BA5958A7B4B0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace raichumobile2 {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.ListBox allDevicesListBox;
        
        internal System.Windows.Controls.Grid grid1;
        
        internal System.Windows.Controls.TextBox ServerAddressTextBox;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
        internal System.Windows.Controls.TextBlock textBlock2;
        
        internal System.Windows.Controls.TextBlock connectionStatusTextBLock;
        
        internal System.Windows.Controls.TextBox ServerPortNumberTextBox;
        
        internal System.Windows.Controls.Button button1;
        
        internal System.Windows.Controls.TextBlock textBlock3;
        
        internal System.Windows.Controls.TextBox deviceNameTextBox;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/raichumobile2;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.allDevicesListBox = ((System.Windows.Controls.ListBox)(this.FindName("allDevicesListBox")));
            this.grid1 = ((System.Windows.Controls.Grid)(this.FindName("grid1")));
            this.ServerAddressTextBox = ((System.Windows.Controls.TextBox)(this.FindName("ServerAddressTextBox")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
            this.textBlock2 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock2")));
            this.connectionStatusTextBLock = ((System.Windows.Controls.TextBlock)(this.FindName("connectionStatusTextBLock")));
            this.ServerPortNumberTextBox = ((System.Windows.Controls.TextBox)(this.FindName("ServerPortNumberTextBox")));
            this.button1 = ((System.Windows.Controls.Button)(this.FindName("button1")));
            this.textBlock3 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock3")));
            this.deviceNameTextBox = ((System.Windows.Controls.TextBox)(this.FindName("deviceNameTextBox")));
        }
    }
}

