﻿#pragma checksum "..\..\..\Child Windows\InsertActor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "34858BF67943BC4EF49CBE0D81F13C04D8AD21EB7B63BF4BBC8F46E178FBB37A"
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
    /// InsertActor
    /// </summary>
    public partial class InsertActor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\Child Windows\InsertActor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Ivanov_WPF_EF_MovieCatalog.InsertActor AddActorWindow;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Child Windows\InsertActor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameTB;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Child Windows\InsertActor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ageTB;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Child Windows\InsertActor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox birthdateTB;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Child Windows\InsertActor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox countryTB;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Child Windows\InsertActor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button insertB;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Child Windows\InsertActor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clearB;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Child Windows\InsertActor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelB;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Child Windows\InsertActor.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Ivanov_WPF_EF_MovieCatalog;component/child%20windows/insertactor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Child Windows\InsertActor.xaml"
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
            this.AddActorWindow = ((Ivanov_WPF_EF_MovieCatalog.InsertActor)(target));
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
            this.insertB = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.clearB = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.cancelB = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\Child Windows\InsertActor.xaml"
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
