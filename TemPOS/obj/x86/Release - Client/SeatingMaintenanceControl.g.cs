﻿#pragma checksum "..\..\..\SeatingMaintenanceControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "70125B4F60E775C6A13A19304CEB7F78"
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
    /// SeatingMaintenanceControl
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class SeatingMaintenanceControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\SeatingMaintenanceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\SeatingMaintenanceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PointOfSale.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\SeatingMaintenanceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonAdd;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\SeatingMaintenanceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonEditToggle;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\SeatingMaintenanceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonUpdate;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\SeatingMaintenanceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonCancel;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\SeatingMaintenanceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.DragScrollListBox listBox1;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\SeatingMaintenanceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PointOfSale.RoomEditorControl roomEditorControl;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\SeatingMaintenanceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PointOfSale.SeatingEditorControl seatingEditorControl;
        
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
            System.Uri resourceLocater = new System.Uri("/PointOfSale;component/seatingmaintenancecontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SeatingMaintenanceControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 9 "..\..\..\SeatingMaintenanceControl.xaml"
            ((PointOfSale.SeatingMaintenanceControl)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mainPane = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 3:
            this.Configuration = ((PointOfSale.ConfigurationManager)(target));
            return;
            case 4:
            this.buttonAdd = ((PosControls.PushButton)(target));
            
            #line 35 "..\..\..\SeatingMaintenanceControl.xaml"
            this.buttonAdd.Selected += new System.EventHandler(this.button_Selected);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonEditToggle = ((PosControls.PushButton)(target));
            
            #line 36 "..\..\..\SeatingMaintenanceControl.xaml"
            this.buttonEditToggle.Selected += new System.EventHandler(this.button_Selected);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonUpdate = ((PosControls.PushButton)(target));
            
            #line 39 "..\..\..\SeatingMaintenanceControl.xaml"
            this.buttonUpdate.Selected += new System.EventHandler(this.button_Selected);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonCancel = ((PosControls.PushButton)(target));
            
            #line 40 "..\..\..\SeatingMaintenanceControl.xaml"
            this.buttonCancel.Selected += new System.EventHandler(this.button_Selected);
            
            #line default
            #line hidden
            return;
            case 8:
            this.listBox1 = ((PosControls.DragScrollListBox)(target));
            
            #line 42 "..\..\..\SeatingMaintenanceControl.xaml"
            this.listBox1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBox1_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.roomEditorControl = ((PointOfSale.RoomEditorControl)(target));
            return;
            case 10:
            this.seatingEditorControl = ((PointOfSale.SeatingEditorControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
