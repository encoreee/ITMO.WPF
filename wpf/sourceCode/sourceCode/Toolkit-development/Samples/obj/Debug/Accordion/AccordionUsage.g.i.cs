﻿#pragma checksum "..\..\..\Accordion\AccordionUsage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "750544D134CFDB082F9C1CC63C64C217C3775ED33CC62C1B14FC4981FD05C91D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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


namespace System.Windows.Controls.Samples {
    
    
    /// <summary>
    /// AccordionUsage
    /// </summary>
    public partial class AccordionUsage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 146 "..\..\..\Accordion\AccordionUsage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Accordion accordionGeneratedContent;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\..\Accordion\AccordionUsage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Accordion accordionDefaultHeaderTemplate;
        
        #line default
        #line hidden
        
        
        #line 198 "..\..\..\Accordion\AccordionUsage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Accordion accordionExpandCollapse;
        
        #line default
        #line hidden
        
        
        #line 226 "..\..\..\Accordion\AccordionUsage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Accordion accordionCLRTypes;
        
        #line default
        #line hidden
        
        
        #line 248 "..\..\..\Accordion\AccordionUsage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Accordion accordionAccordionItem;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFToolkitSamples;component/accordion/accordionusage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Accordion\AccordionUsage.xaml"
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
            this.accordionGeneratedContent = ((System.Windows.Controls.Accordion)(target));
            return;
            case 2:
            this.accordionDefaultHeaderTemplate = ((System.Windows.Controls.Accordion)(target));
            return;
            case 3:
            
            #line 180 "..\..\..\Accordion\AccordionUsage.xaml"
            ((System.Windows.Controls.Accordion)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Accordion_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.accordionExpandCollapse = ((System.Windows.Controls.Accordion)(target));
            return;
            case 5:
            
            #line 213 "..\..\..\Accordion\AccordionUsage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ExpandAll_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 217 "..\..\..\Accordion\AccordionUsage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CollapseAll_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.accordionCLRTypes = ((System.Windows.Controls.Accordion)(target));
            
            #line 228 "..\..\..\Accordion\AccordionUsage.xaml"
            this.accordionCLRTypes.SelectedItemsChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(this.CLRTypesSelectedItemsChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.accordionAccordionItem = ((System.Windows.Controls.Accordion)(target));
            
            #line 249 "..\..\..\Accordion\AccordionUsage.xaml"
            this.accordionAccordionItem.Loaded += new System.Windows.RoutedEventHandler(this.SetMouseEvents);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
