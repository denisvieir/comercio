﻿#pragma checksum "..\..\FormVendas.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "11DE9164A344BD02DA19932899DCEB5E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ControladorDePedidos.WPF;
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
using dn32ImageButton.Controls;


namespace ControladorDePedidos.WPF {
    
    
    /// <summary>
    /// FormVendas
    /// </summary>
    public partial class FormVendas : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\FormVendas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal dn32ImageButton.Controls.dn32ImageButton btnNovo;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\FormVendas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal dn32ImageButton.Controls.dn32ImageButton btnEditar;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\FormVendas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal dn32ImageButton.Controls.dn32ImageButton btnExcluir;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\FormVendas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal dn32ImageButton.Controls.dn32ImageButton btnAtualizar;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\FormVendas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lstVendas;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\FormVendas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal dn32ImageButton.Controls.dn32ImageButton btnVender;
        
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
            System.Uri resourceLocater = new System.Uri("/ControladorDePedidos.WPF;component/formvendas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FormVendas.xaml"
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
            
            #line 10 "..\..\FormVendas.xaml"
            ((ControladorDePedidos.WPF.FormVendas)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnNovo = ((dn32ImageButton.Controls.dn32ImageButton)(target));
            
            #line 34 "..\..\FormVendas.xaml"
            this.btnNovo.Click += new System.Windows.RoutedEventHandler(this.btnNovo_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnEditar = ((dn32ImageButton.Controls.dn32ImageButton)(target));
            
            #line 42 "..\..\FormVendas.xaml"
            this.btnEditar.Click += new System.Windows.RoutedEventHandler(this.btnEditar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnExcluir = ((dn32ImageButton.Controls.dn32ImageButton)(target));
            
            #line 49 "..\..\FormVendas.xaml"
            this.btnExcluir.Click += new System.Windows.RoutedEventHandler(this.btnExcluir_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnAtualizar = ((dn32ImageButton.Controls.dn32ImageButton)(target));
            
            #line 56 "..\..\FormVendas.xaml"
            this.btnAtualizar.Click += new System.Windows.RoutedEventHandler(this.btnAtualizar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lstVendas = ((System.Windows.Controls.ListView)(target));
            return;
            case 7:
            this.btnVender = ((dn32ImageButton.Controls.dn32ImageButton)(target));
            
            #line 75 "..\..\FormVendas.xaml"
            this.btnVender.Click += new System.Windows.RoutedEventHandler(this.btnVender_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
