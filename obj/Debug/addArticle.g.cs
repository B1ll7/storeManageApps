﻿#pragma checksum "..\..\addArticle.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C9AC0827ACD93D6C6A286BB6ED432543CFC98D82"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using magasin;


namespace magasin {
    
    
    /// <summary>
    /// addArticle
    /// </summary>
    public partial class addArticle : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\addArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\addArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox image;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\addArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox description;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\addArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Categories;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\addArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox reference;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\addArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox price;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\addArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox quantity;
        
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
            System.Uri resourceLocater = new System.Uri("/store;component/addarticle.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\addArticle.xaml"
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
            this.name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.image = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 36 "..\..\addArticle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.FindImage);
            
            #line default
            #line hidden
            return;
            case 4:
            this.description = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Categories = ((System.Windows.Controls.ComboBox)(target));
            
            #line 40 "..\..\addArticle.xaml"
            this.Categories.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.reference = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.price = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.quantity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 55 "..\..\addArticle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateArticle);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

