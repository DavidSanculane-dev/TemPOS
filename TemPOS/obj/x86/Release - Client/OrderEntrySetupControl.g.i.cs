﻿#pragma checksum "..\..\..\OrderEntrySetupControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AB26B4D931FF617C4B0C8205709F51FA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PointOfSale;
using PosControls;
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


namespace PointOfSale {
    
    
    /// <summary>
    /// OrderEntrySetupControl
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class OrderEntrySetupControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\OrderEntrySetupControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\OrderEntrySetupControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PointOfSale.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\OrderEntrySetupControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonItems;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\OrderEntrySetupControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonCoupons;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\OrderEntrySetupControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonSeating;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\OrderEntrySetupControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonEmployees;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\OrderEntrySetupControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonTaxes;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\OrderEntrySetupControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonHardware;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\OrderEntrySetupControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonUpdate;
        
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
            System.Uri resourceLocater = new System.Uri("/PointOfSale;component/orderentrysetupcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\OrderEntrySetupControl.xaml"
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
            this.mainPane = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 2:
            this.Configuration = ((PointOfSale.ConfigurationManager)(target));
            return;
            case 3:
            this.buttonItems = ((PosControls.PushButton)(target));
            
            #line 21 "..\..\..\OrderEntrySetupControl.xaml"
            this.buttonItems.Selected += new System.EventHandler(this.buttonItems_Selected);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonCoupons = ((PosControls.PushButton)(target));
            
            #line 22 "..\..\..\OrderEntrySetupControl.xaml"
            this.buttonCoupons.Selected += new System.EventHandler(this.buttonCoupons_Selected);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonSeating = ((PosControls.PushButton)(target));
            
            #line 23 "..\..\..\OrderEntrySetupControl.xaml"
            this.buttonSeating.Selected += new System.EventHandler(this.buttonSeating_Selected);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonEmployees = ((PosControls.PushButton)(target));
            
            #line 24 "..\..\..\OrderEntrySetupControl.xaml"
            this.buttonEmployees.Selected += new System.EventHandler(this.buttonEmployees_Selected);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonTaxes = ((PosControls.PushButton)(target));
            
            #line 25 "..\..\..\OrderEntrySetupControl.xaml"
            this.buttonTaxes.Selected += new System.EventHandler(this.buttonTaxes_Selected);
            
            #line default
            #line hidden
            return;
            case 8:
            this.buttonHardware = ((PosControls.PushButton)(target));
            
            #line 26 "..\..\..\OrderEntrySetupControl.xaml"
            this.buttonHardware.Selected += new System.EventHandler(this.buttonHardware_Selected);
            
            #line default
            #line hidden
            return;
            case 9:
            this.buttonUpdate = ((PosControls.PushButton)(target));
            
            #line 27 "..\..\..\OrderEntrySetupControl.xaml"
            this.buttonUpdate.Selected += new System.EventHandler(this.buttonUpdate_Selected);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
