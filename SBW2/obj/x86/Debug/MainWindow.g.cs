﻿#pragma checksum "..\..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A188BC40BCFA52D7CFAE3BDA2F711A00"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Windows.Controls;
using Microsoft.Windows.Controls.Ribbon;
using SBW2;
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


namespace SBW2 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class MainWindow : Microsoft.Windows.Controls.Ribbon.RibbonWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.Ribbon.RibbonButton StartStopQAB;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private Microsoft.Windows.Controls.Ribbon.RibbonButton StartRB;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.Ribbon.RibbonButton StopRB;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.Ribbon.RibbonButton RestartRB;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private Microsoft.Windows.Controls.Ribbon.RibbonTwoLineText Ribbon_Status;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private Microsoft.Windows.Controls.Ribbon.RibbonTwoLineText MemStats;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private Microsoft.Windows.Controls.Ribbon.RibbonTwoLineText Uptime;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.Ribbon.RibbonComboBox memcb;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private Microsoft.Windows.Controls.Ribbon.RibbonGallery memboxGal;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private Microsoft.Windows.Controls.Ribbon.RibbonGalleryCategory MemoryComboBox;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private Microsoft.Windows.Controls.Ribbon.RibbonToggleButton NetworkToggle;
        
        #line default
        #line hidden
        
        /// <summary>
        /// outputBox Name Field
        /// </summary>
        
        #line 127 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.RichTextBox outputBox;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputBox;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private System.Windows.Shell.ThumbButtonInfo StartThumb;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shell.ThumbButtonInfo StopThumb;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shell.ThumbButtonInfo RestartThumb;
        
        #line default
        #line hidden
        
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
            System.Uri resourceLocater = new System.Uri("/SBW2;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 40 "..\..\..\MainWindow.xaml"
            ((SBW2.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.RibbonWindowClosing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.StartStopQAB = ((Microsoft.Windows.Controls.Ribbon.RibbonButton)(target));
            return;
            case 3:
            this.StartRB = ((Microsoft.Windows.Controls.Ribbon.RibbonButton)(target));
            return;
            case 4:
            this.StopRB = ((Microsoft.Windows.Controls.Ribbon.RibbonButton)(target));
            return;
            case 5:
            this.RestartRB = ((Microsoft.Windows.Controls.Ribbon.RibbonButton)(target));
            return;
            case 6:
            this.Ribbon_Status = ((Microsoft.Windows.Controls.Ribbon.RibbonTwoLineText)(target));
            return;
            case 7:
            this.MemStats = ((Microsoft.Windows.Controls.Ribbon.RibbonTwoLineText)(target));
            return;
            case 8:
            this.Uptime = ((Microsoft.Windows.Controls.Ribbon.RibbonTwoLineText)(target));
            return;
            case 9:
            this.memcb = ((Microsoft.Windows.Controls.Ribbon.RibbonComboBox)(target));
            return;
            case 10:
            this.memboxGal = ((Microsoft.Windows.Controls.Ribbon.RibbonGallery)(target));
            
            #line 103 "..\..\..\MainWindow.xaml"
            this.memboxGal.SelectionChanged += new System.Windows.RoutedPropertyChangedEventHandler<object>(this.MemoryComboBoxSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.MemoryComboBox = ((Microsoft.Windows.Controls.Ribbon.RibbonGalleryCategory)(target));
            return;
            case 12:
            this.NetworkToggle = ((Microsoft.Windows.Controls.Ribbon.RibbonToggleButton)(target));
            
            #line 118 "..\..\..\MainWindow.xaml"
            this.NetworkToggle.Checked += new System.Windows.RoutedEventHandler(this.NetToggleChecked);
            
            #line default
            #line hidden
            
            #line 119 "..\..\..\MainWindow.xaml"
            this.NetworkToggle.Unchecked += new System.Windows.RoutedEventHandler(this.NetworkToggleUnchecked);
            
            #line default
            #line hidden
            return;
            case 13:
            this.outputBox = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 14:
            this.inputBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 138 "..\..\..\MainWindow.xaml"
            this.inputBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.TextBoxKeyDown);
            
            #line default
            #line hidden
            return;
            case 15:
            this.StartThumb = ((System.Windows.Shell.ThumbButtonInfo)(target));
            return;
            case 16:
            this.StopThumb = ((System.Windows.Shell.ThumbButtonInfo)(target));
            return;
            case 17:
            this.RestartThumb = ((System.Windows.Shell.ThumbButtonInfo)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

