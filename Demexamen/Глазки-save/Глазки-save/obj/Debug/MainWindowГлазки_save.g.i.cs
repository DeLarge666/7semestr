﻿#pragma checksum "..\..\MainWindowГлазки_save.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F68501E57F57113D0E8C927E9E330CD54BAFDAA85645FD76EEE9025DE94F6F83"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using Глазки_save;


namespace Глазки_save {
    
    
    /// <summary>
    /// MainWindowГлазки_save
    /// </summary>
    public partial class MainWindowГлазки_save : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\MainWindowГлазки_save.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border string1;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\MainWindowГлазки_save.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border string2;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MainWindowГлазки_save.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Глазки_save_png;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\MainWindowГлазки_save.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Bucs;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MainWindowГлазки_save.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Main;
        
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
            System.Uri resourceLocater = new System.Uri("/Глазки-save;component/mainwindow%d0%93%d0%bb%d0%b0%d0%b7%d0%ba%d0%b8_save.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindowГлазки_save.xaml"
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
            this.string1 = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.string2 = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.Глазки_save_png = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            
            #line 22 "..\..\MainWindowГлазки_save.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Admin);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 23 "..\..\MainWindowГлазки_save.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.User);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Bucs = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\MainWindowГлазки_save.xaml"
            this.Bucs.Click += new System.Windows.RoutedEventHandler(this.Back);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Main = ((System.Windows.Controls.Frame)(target));
            
            #line 26 "..\..\MainWindowГлазки_save.xaml"
            this.Main.ContentRendered += new System.EventHandler(this.Buck);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

