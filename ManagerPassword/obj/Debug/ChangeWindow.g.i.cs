// Updated by XamlIntelliSenseFileGenerator 06.07.2022 16:23:01
#pragma checksum "..\..\ChangeWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1590E2D4914F39A1806C31A4E6F69B4A74049E7E906DCFDD51DC2B9D432DBA4F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ManagerPassword;
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


namespace ManagerPassword
{


    /// <summary>
    /// EditWindow
    /// </summary>
    public partial class ChangeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 26 "..\..\ChangeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textboxTitle;

#line default
#line hidden


#line 27 "..\..\ChangeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textboxUsername;

#line default
#line hidden


#line 28 "..\..\ChangeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textboxEmail;

#line default
#line hidden


#line 29 "..\..\ChangeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textboxUrl;

#line default
#line hidden


#line 30 "..\..\ChangeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textboxPassword;

#line default
#line hidden


#line 31 "..\..\ChangeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textboxNote;

#line default
#line hidden


#line 32 "..\..\ChangeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChange;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ManagerPassword;component/changewindow.xaml", System.UriKind.Relative);

#line 1 "..\..\ChangeWindow.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.textboxTitle = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 2:
                    this.textboxUsername = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.textboxEmail = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.textboxUrl = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.textboxPassword = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.textboxNote = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:
                    this.btnChange = ((System.Windows.Controls.Button)(target));

#line 32 "..\..\ChangeWindow.xaml"
                    this.btnChange.Click += new System.Windows.RoutedEventHandler(this.btnChange_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}
