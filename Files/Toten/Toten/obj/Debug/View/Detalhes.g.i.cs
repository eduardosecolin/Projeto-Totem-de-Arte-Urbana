﻿#pragma checksum "..\..\..\View\Detalhes.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B9B9862FB114FA1E320E9465923BC39C106329E11FF58C7A8E08E2F43A8999FF"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using Toten.View;


namespace Toten.View {
    
    
    /// <summary>
    /// Detalhes
    /// </summary>
    public partial class Detalhes : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\View\Detalhes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgDetails;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\View\Detalhes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Voltar;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\View\Detalhes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblLocal;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\View\Detalhes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblRegion;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\View\Detalhes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtComentarios;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\View\Detalhes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLike;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\View\Detalhes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon Icon1;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\View\Detalhes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDesLike;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\View\Detalhes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon Icon2;
        
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
            System.Uri resourceLocater = new System.Uri("/Toten;component/view/detalhes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Detalhes.xaml"
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
            this.imgDetails = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.Voltar = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\View\Detalhes.xaml"
            this.Voltar.Click += new System.Windows.RoutedEventHandler(this.Voltar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lblLocal = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblRegion = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtComentarios = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnLike = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\View\Detalhes.xaml"
            this.btnLike.Click += new System.Windows.RoutedEventHandler(this.BtnLike_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Icon1 = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 8:
            this.btnDesLike = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\View\Detalhes.xaml"
            this.btnDesLike.Click += new System.Windows.RoutedEventHandler(this.BtnDesLike_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Icon2 = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

