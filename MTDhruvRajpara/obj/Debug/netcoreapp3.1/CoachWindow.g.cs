﻿#pragma checksum "..\..\..\CoachWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90B5ADCC24CB689F70E72EB175C1949CB5CCE5E0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MTDhruvRajpara;
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


namespace MTDhruvRajpara {
    
    
    /// <summary>
    /// CoachWindow
    /// </summary>
    public partial class CoachWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\CoachWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem quitMenu;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\CoachWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox coachList;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\CoachWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblID;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\CoachWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textId;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\CoachWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textName;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\CoachWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textNumberOfTeamsCoached;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\CoachWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textPlayersTrained;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\CoachWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textWinPercentage;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\CoachWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textYearsOfExperience;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\CoachWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnInsert;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\CoachWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\CoachWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MTDhruvRajpara;component/coachwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CoachWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\CoachWindow.xaml"
            ((MTDhruvRajpara.CoachWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Winodw_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.quitMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 15 "..\..\..\CoachWindow.xaml"
            this.quitMenu.Click += new System.Windows.RoutedEventHandler(this.quitMenu_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 19 "..\..\..\CoachWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnInsert_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 20 "..\..\..\CoachWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 21 "..\..\..\CoachWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 24 "..\..\..\CoachWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.studInfo_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.coachList = ((System.Windows.Controls.ListBox)(target));
            
            #line 29 "..\..\..\CoachWindow.xaml"
            this.coachList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.coachList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lblID = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.textId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.textName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.textNumberOfTeamsCoached = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.textPlayersTrained = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.textWinPercentage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.textYearsOfExperience = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.btnInsert = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\CoachWindow.xaml"
            this.btnInsert.Click += new System.Windows.RoutedEventHandler(this.btnInsert_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\CoachWindow.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.btnUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\CoachWindow.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

