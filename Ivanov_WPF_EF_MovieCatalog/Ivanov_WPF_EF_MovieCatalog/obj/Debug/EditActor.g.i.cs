﻿#pragma checksum "..\..\EditActor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2375D5193EFE0157B4B0AD339E9720A315E99F1700C6F08AEEE65395BC13E6E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ivanov_WPF_EF_MovieCatalog;
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


namespace Ivanov_WPF_EF_MovieCatalog {
    
    
    /// <summary>
    /// UpdateActor
    /// </summary>
    public partial class UpdateActor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\EditActor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Ivanov_WPF_EF_MovieCatalog.UpdateActor UpdateActorWindow;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\EditActor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameTB;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\EditActor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ageTB;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\EditActor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox birthdateTB;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\EditActor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox countryTB;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\EditActor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updateB;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\EditActor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button defaultB;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\EditActor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelB;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\EditActor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image actorImage;
        
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
            System.Uri resourceLocater = new System.Uri("/Ivanov_WPF_EF_MovieCatalog;component/editactor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditActor.xaml"
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
            this.UpdateActorWindow = ((Ivanov_WPF_EF_MovieCatalog.UpdateActor)(target));
            return;
            case 2:
            this.nameTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ageTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.birthdateTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.countryTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.updateB = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\EditActor.xaml"
            this.updateB.Click += new System.Windows.RoutedEventHandler(this.updateB_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.defaultB = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\EditActor.xaml"
            this.defaultB.Click += new System.Windows.RoutedEventHandler(this.defaultB_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cancelB = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\EditActor.xaml"
            this.cancelB.Click += new System.Windows.RoutedEventHandler(this.cancelB_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.actorImage = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

