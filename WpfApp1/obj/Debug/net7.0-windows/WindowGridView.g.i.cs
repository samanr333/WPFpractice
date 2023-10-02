﻿#pragma checksum "..\..\..\WindowGridView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BBCC79C41C5C8ED74FDDE41C099DEE73B5E06441"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CompiledBindings.Markup;
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// WindowGridView
    /// </summary>
    public partial class WindowGridView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 76 "..\..\..\WindowGridView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameEntry;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\WindowGridView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddressEntry;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\WindowGridView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DobEntry;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\WindowGridView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SalaryEntry;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\..\WindowGridView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView MyList;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\WindowGridView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBox;
        
        #line default
        #line hidden
        
        
        #line 231 "..\..\..\WindowGridView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SortBy;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;V1.0.0.0;component/windowgridview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WindowGridView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.NameEntry = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.AddressEntry = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.DobEntry = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.SalaryEntry = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 118 "..\..\..\WindowGridView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddList);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 123 "..\..\..\WindowGridView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteList);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 128 "..\..\..\WindowGridView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClearList);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 133 "..\..\..\WindowGridView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateList);
            
            #line default
            #line hidden
            return;
            case 9:
            this.MyList = ((System.Windows.Controls.ListView)(target));
            
            #line 153 "..\..\..\WindowGridView.xaml"
            this.MyList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListChange);
            
            #line default
            #line hidden
            return;
            case 10:
            this.SearchBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 197 "..\..\..\WindowGridView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchList);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 211 "..\..\..\WindowGridView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GroupList);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 218 "..\..\..\WindowGridView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ResetList);
            
            #line default
            #line hidden
            return;
            case 14:
            this.SortBy = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 15:
            
            #line 242 "..\..\..\WindowGridView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SortList);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 250 "..\..\..\WindowGridView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ResetList);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

