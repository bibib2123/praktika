﻿#pragma checksum "..\..\Calculate.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CEF7D1A3C306E72815A733F75FF6847F663B99258880CD7C20554AA79B9D98F7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FirstTask;
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


namespace FirstTask {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Calculate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox choice;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Calculate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button decision;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Calculate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label answer;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Calculate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label dop;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Calculate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox number1;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Calculate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox number2;
        
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
            System.Uri resourceLocater = new System.Uri("/FirstTask;component/calculate.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Calculate.xaml"
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
            this.choice = ((System.Windows.Controls.ComboBox)(target));
            
            #line 10 "..\..\Calculate.xaml"
            this.choice.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.choice_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.decision = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Calculate.xaml"
            this.decision.Click += new System.Windows.RoutedEventHandler(this.decision_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.answer = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.dop = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.number1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.number2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\Calculate.xaml"
            this.number2.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.number2_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

