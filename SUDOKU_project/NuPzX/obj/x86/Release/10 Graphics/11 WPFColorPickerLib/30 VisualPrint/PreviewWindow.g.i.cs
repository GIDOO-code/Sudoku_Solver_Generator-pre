﻿#pragma checksum "..\..\..\..\..\..\10 Graphics\11 WPFColorPickerLib\30 VisualPrint\PreviewWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C129DEA01C3CD0B043135EF4FBFD4CB8AE1FC53C0DD1E5EB59E22E5653F2D194"
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


namespace VisualPrint {
    
    
    /// <summary>
    /// PreviewWindow
    /// </summary>
    public partial class PreviewWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\..\..\10 Graphics\11 WPFColorPickerLib\30 VisualPrint\PreviewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu PrintMenu;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\..\10 Graphics\11 WPFColorPickerLib\30 VisualPrint\PreviewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel DocumentPanel;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\..\10 Graphics\11 WPFColorPickerLib\30 VisualPrint\PreviewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.FlowDocumentReader Viewer;
        
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
            System.Uri resourceLocater = new System.Uri("/GNPXEx;component/10%20graphics/11%20wpfcolorpickerlib/30%20visualprint/previewwi" +
                    "ndow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\10 Graphics\11 WPFColorPickerLib\30 VisualPrint\PreviewWindow.xaml"
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
            
            #line 4 "..\..\..\..\..\..\10 Graphics\11 WPFColorPickerLib\30 VisualPrint\PreviewWindow.xaml"
            ((VisualPrint.PreviewWindow)(target)).Closed += new System.EventHandler(this.OnClosed);
            
            #line default
            #line hidden
            
            #line 4 "..\..\..\..\..\..\10 Graphics\11 WPFColorPickerLib\30 VisualPrint\PreviewWindow.xaml"
            ((VisualPrint.PreviewWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PrintMenu = ((System.Windows.Controls.Menu)(target));
            return;
            case 3:
            
            #line 19 "..\..\..\..\..\..\10 Graphics\11 WPFColorPickerLib\30 VisualPrint\PreviewWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OnPrintClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DocumentPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 5:
            this.Viewer = ((System.Windows.Controls.FlowDocumentReader)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

