﻿#pragma checksum "..\..\..\FontSettings.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9EF53A006ADAD247F91A3739D6020CA64B3FE602"
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
using TextEditor;


namespace TextEditor {
    
    
    /// <summary>
    /// FontSettings
    /// </summary>
    public partial class FontSettings : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\FontSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label FontColorLabel;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\FontSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label FontFamilyLabel;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\FontSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label FontSizeLabel;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\FontSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label FontSizeValue;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\FontSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slider;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\FontSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FontFamilyCMB;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\FontSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FontColorCMB;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TextEditor;component/fontsettings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\FontSettings.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.FontColorLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.FontFamilyLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.FontSizeLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.FontSizeValue = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.slider = ((System.Windows.Controls.Slider)(target));
            
            #line 14 "..\..\..\FontSettings.xaml"
            this.slider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.slider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.FontFamilyCMB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\..\FontSettings.xaml"
            this.FontFamilyCMB.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FontFamilyCMB_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.FontColorCMB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 16 "..\..\..\FontSettings.xaml"
            this.FontColorCMB.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FontColorCMB_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
