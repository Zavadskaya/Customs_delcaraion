﻿#pragma checksum "..\..\..\View\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B33982DF7E96EC3964F7D7E184C6A311"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using KURSOVOI;
using KURSOVOI.Model;
using Mindscape.WpfElements;
using Mindscape.WpfElements.Charting;
using Mindscape.WpfElements.PropertyEditing;
using Mindscape.WpfElements.Themes;
using Mindscape.WpfElements.WpfDataGrid;
using Mindscape.WpfElements.WpfPropertyGrid;
using Mindscape.WpfElements.WpfPropertyGrid.Themes;
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


namespace KURSOVOI.View {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 126 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid1;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateDatePicker;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock InfoStat;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ListDeclar;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Us;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UsE;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox List;
        
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
            System.Uri resourceLocater = new System.Uri("/KURSOVOI;component/view/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\MainWindow.xaml"
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
            
            #line 11 "..\..\..\View\MainWindow.xaml"
            ((KURSOVOI.View.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 32 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Push_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 54 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Product_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 76 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Customer_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 98 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.grid1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.dateDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.InfoStat = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.ListDeclar = ((System.Windows.Controls.ComboBox)(target));
            
            #line 162 "..\..\..\View\MainWindow.xaml"
            this.ListDeclar.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListDeclar_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Us = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.UsE = ((System.Windows.Controls.TextBox)(target));
            
            #line 165 "..\..\..\View\MainWindow.xaml"
            this.UsE.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.UsE_TextChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.List = ((System.Windows.Controls.ListBox)(target));
            
            #line 166 "..\..\..\View\MainWindow.xaml"
            this.List.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.List_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

