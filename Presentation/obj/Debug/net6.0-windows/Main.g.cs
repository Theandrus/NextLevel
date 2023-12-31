﻿#pragma checksum "..\..\..\Main.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B6A687B7B2522ED784D0F57857FCBC282CEC9CB3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Presentation;
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


namespace MYB_NEW {
    
    
    /// <summary>
    /// Main
    /// </summary>
    public partial class Main : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 82 "..\..\..\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel IncomeListView;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SavingsListView;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel CategoriesListView;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UsernameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DataExportButton;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\..\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TipsAndTricksButton;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SettingsButton;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SignOutButton;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ToggleButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Presentation;component/main.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Main.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 69 "..\..\..\Main.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.IncomeListView = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            
            #line 85 "..\..\..\Main.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddIncome_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SavingsListView = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            
            #line 96 "..\..\..\Main.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddSavings_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CategoriesListView = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            
            #line 113 "..\..\..\Main.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddCategory_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.UsernameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.DataExportButton = ((System.Windows.Controls.Button)(target));
            
            #line 138 "..\..\..\Main.xaml"
            this.DataExportButton.Click += new System.Windows.RoutedEventHandler(this.DataExportButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.TipsAndTricksButton = ((System.Windows.Controls.Button)(target));
            
            #line 140 "..\..\..\Main.xaml"
            this.TipsAndTricksButton.Click += new System.Windows.RoutedEventHandler(this.TipsAndTricksButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.SettingsButton = ((System.Windows.Controls.Button)(target));
            
            #line 142 "..\..\..\Main.xaml"
            this.SettingsButton.Click += new System.Windows.RoutedEventHandler(this.SettingsButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.SignOutButton = ((System.Windows.Controls.Button)(target));
            
            #line 144 "..\..\..\Main.xaml"
            this.SignOutButton.Click += new System.Windows.RoutedEventHandler(this.SignOutButton_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.ToggleButton = ((System.Windows.Controls.Button)(target));
            
            #line 147 "..\..\..\Main.xaml"
            this.ToggleButton.Click += new System.Windows.RoutedEventHandler(this.Toggle_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 162 "..\..\..\Main.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.TransactionButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

