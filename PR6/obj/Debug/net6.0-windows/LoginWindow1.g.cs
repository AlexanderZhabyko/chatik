﻿#pragma checksum "..\..\..\LoginWindow1.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3EBB0465C0A45322C065BE50806ECAA6748A8BAE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PR6;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace PR6 {
    
    
    /// <summary>
    /// LoginWindow1
    /// </summary>
    public partial class LoginWindow1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\LoginWindow1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ClientNick;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\LoginWindow1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IPbox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\LoginWindow1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Toclient;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\LoginWindow1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ServerNick;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\LoginWindow1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Toserver;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PR6;component/loginwindow1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\LoginWindow1.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ClientNick = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\..\LoginWindow1.xaml"
            this.ClientNick.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ClientNick_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.IPbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\..\LoginWindow1.xaml"
            this.IPbox.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.IPbox_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Toclient = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\LoginWindow1.xaml"
            this.Toclient.Click += new System.Windows.RoutedEventHandler(this.Toclient_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ServerNick = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\LoginWindow1.xaml"
            this.ServerNick.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ServerNick_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Toserver = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\LoginWindow1.xaml"
            this.Toserver.Click += new System.Windows.RoutedEventHandler(this.Toserver_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

