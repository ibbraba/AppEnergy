﻿#pragma checksum "..\..\..\..\Templates\AddEquipmentForm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "789A17FAD655FBB58486A110BD55CABB9285D3C4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using AppEnergy.Templates;
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


namespace AppEnergy.Templates {
    
    
    /// <summary>
    /// AddEquipmentForm
    /// </summary>
    public partial class AddEquipmentForm : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\..\Templates\AddEquipmentForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ClientNameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Templates\AddEquipmentForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox EquipmentComboBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Templates\AddEquipmentForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox EquipmentColorComboBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Templates\AddEquipmentForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddEquipmentButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AppEnergy;component/templates/addequipmentform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Templates\AddEquipmentForm.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ClientNameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.EquipmentComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 41 "..\..\..\..\Templates\AddEquipmentForm.xaml"
            this.EquipmentComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.EquipmentComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.EquipmentColorComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.AddEquipmentButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\Templates\AddEquipmentForm.xaml"
            this.AddEquipmentButton.Click += new System.Windows.RoutedEventHandler(this.AddEquipmentButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

