﻿#pragma checksum "..\..\ClientWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6623C895D505B6BAF3B1D88382B7187D68A33D6F38946CDD03A407D71A104A80"
//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using TCPConnectApp;


namespace TCPConnectApp {
    
    
    /// <summary>
    /// ClientWindow
    /// </summary>
    public partial class ClientWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TCPConnectApp;component/clientwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ClientWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.textbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\ClientWindow.xaml"
            this.textbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox);
            
            #line default
            #line hidden
            return;
            case 2:
            this.button = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\ClientWindow.xaml"
            this.button.Click += new System.Windows.RoutedEventHandler(this.SendButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.button1 = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\ClientWindow.xaml"
            this.button1.Click += new System.Windows.RoutedEventHandler(this.Button1_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
