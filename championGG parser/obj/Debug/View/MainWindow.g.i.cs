﻿#pragma checksum "..\..\..\View\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "474B969A79D83204A79D871AD01AE69D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using championGG_parser;


namespace championGG_parser {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 18 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem dropdownUpdateData;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem dropdownExportFiles;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem dropdownClearHTML;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listbox1;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox itemSet;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ParserButton;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonDeletePreviousData;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonGetData;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement loadingGif;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image checkmarkImage;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image dataLoadingBarBackground;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image dataLoadingBarForeground;
        
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
            System.Uri resourceLocater = new System.Uri("/championGG parser;component/view/mainwindow.xaml", System.UriKind.Relative);
            
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
            
            #line 14 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowAboutWindow);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 15 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ShutdownApplication);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dropdownUpdateData = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 4:
            this.dropdownExportFiles = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 5:
            this.dropdownClearHTML = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 6:
            
            #line 21 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowSettingsWindow);
            
            #line default
            #line hidden
            return;
            case 7:
            this.listbox1 = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.itemSet = ((System.Windows.Controls.ListBox)(target));
            return;
            case 11:
            this.ParserButton = ((System.Windows.Controls.Button)(target));
            return;
            case 12:
            this.buttonDeletePreviousData = ((System.Windows.Controls.Button)(target));
            return;
            case 13:
            this.buttonGetData = ((System.Windows.Controls.Button)(target));
            return;
            case 14:
            this.loadingGif = ((System.Windows.Controls.MediaElement)(target));
            
            #line 108 "..\..\..\View\MainWindow.xaml"
            this.loadingGif.MediaEnded += new System.Windows.RoutedEventHandler(this.LoadingGif_MediaEnded);
            
            #line default
            #line hidden
            return;
            case 15:
            this.checkmarkImage = ((System.Windows.Controls.Image)(target));
            return;
            case 16:
            this.dataLoadingBarBackground = ((System.Windows.Controls.Image)(target));
            return;
            case 17:
            this.dataLoadingBarForeground = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 9:
            
            #line 56 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Image)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.ShowToolTips);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 75 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Image)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.ShowToolTips);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
