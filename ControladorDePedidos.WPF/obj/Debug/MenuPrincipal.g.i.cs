﻿#pragma checksum "..\..\MenuPrincipal.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E37A9E091B60B153C88A18D7C4047AEB"
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
    /// MenuPrincipal
    /// </summary>
    public partial class MenuPrincipal : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal dn32ImageButton.Controls.dn32ImageButton btnClientes;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal dn32ImageButton.Controls.dn32ImageButton btnProdutos;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal dn32ImageButton.Controls.dn32ImageButton btnVendas;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal dn32ImageButton.Controls.dn32ImageButton btnFornecedores;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal dn32ImageButton.Controls.dn32ImageButton btnCompras;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal dn32ImageButton.Controls.dn32ImageButton btnUsuarios;
        
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
            System.Uri resourceLocater = new System.Uri("/ControladorDePedidos.WPF;component/menuprincipal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MenuPrincipal.xaml"
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
            this.btnClientes = ((dn32ImageButton.Controls.dn32ImageButton)(target));
            
            #line 20 "..\..\MenuPrincipal.xaml"
            this.btnClientes.Click += new System.Windows.RoutedEventHandler(this.btnClientes_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnProdutos = ((dn32ImageButton.Controls.dn32ImageButton)(target));
            
            #line 27 "..\..\MenuPrincipal.xaml"
            this.btnProdutos.Click += new System.Windows.RoutedEventHandler(this.btnProdutos_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnVendas = ((dn32ImageButton.Controls.dn32ImageButton)(target));
            
            #line 33 "..\..\MenuPrincipal.xaml"
            this.btnVendas.Click += new System.Windows.RoutedEventHandler(this.btnVendas_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnFornecedores = ((dn32ImageButton.Controls.dn32ImageButton)(target));
            return;
            case 5:
            this.btnCompras = ((dn32ImageButton.Controls.dn32ImageButton)(target));
            
            #line 45 "..\..\MenuPrincipal.xaml"
            this.btnCompras.Click += new System.Windows.RoutedEventHandler(this.btnCompras_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnUsuarios = ((dn32ImageButton.Controls.dn32ImageButton)(target));
            
            #line 51 "..\..\MenuPrincipal.xaml"
            this.btnUsuarios.Click += new System.Windows.RoutedEventHandler(this.btnUsuarios_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

