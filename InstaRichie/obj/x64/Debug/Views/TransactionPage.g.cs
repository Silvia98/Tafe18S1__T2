﻿#pragma checksum "D:\5TSD\AssignmentPart1_YangWang\Tafe18S1__T2\InstaRichie\Views\TransactionPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8FA1CCBB2C228364490F32CB3E66571E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StartFinance.Views
{
    partial class TransactionPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
        };

        private class TransactionPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITransactionPage_Bindings
        {
            private global::StartFinance.Views.TransactionPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.AppBarButton obj23;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj24;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj25;

            public TransactionPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 23:
                        this.obj23 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += (global::System.Object param0, global::Windows.UI.Xaml.RoutedEventArgs param1) =>
                        {
                        this.dataRoot.ViewModel.GotoSettings();
                        };
                        break;
                    case 24:
                        this.obj24 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += (global::System.Object param0, global::Windows.UI.Xaml.RoutedEventArgs param1) =>
                        {
                        this.dataRoot.ViewModel.GotoPrivacy();
                        };
                        break;
                    case 25:
                        this.obj25 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += (global::System.Object param0, global::Windows.UI.Xaml.RoutedEventArgs param1) =>
                        {
                        this.dataRoot.ViewModel.GotoAbout();
                        };
                        break;
                    default:
                        break;
                }
            }

            // ITransactionPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // TransactionPage_obj1_Bindings

            public void SetDataRoot(global::StartFinance.Views.TransactionPage newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 28 "..\..\..\Views\TransactionPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                    #line default
                }
                break;
            case 2:
                {
                    this.ViewModel = (global::StartFinance.ViewModels.MainPageViewModel)(target);
                }
                break;
            case 3:
                {
                    this.AdaptiveVisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 4:
                {
                    this.VisualStateNarrow = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5:
                {
                    this.VisualStateNormal = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6:
                {
                    this.VisualStateWide = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 7:
                {
                    this.pageHeader = (global::Template10.Controls.PageHeader)(target);
                }
                break;
            case 8:
                {
                    this.pageFooter = (global::Template10.Controls.PageHeader)(target);
                }
                break;
            case 9:
                {
                    this.InternFooter = (global::Template10.Controls.PageHeader)(target);
                }
                break;
            case 10:
                {
                    this.pagecontent = (global::Windows.UI.Xaml.Controls.Pivot)(target);
                    #line 117 "..\..\..\Views\TransactionPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Pivot)this.pagecontent).SelectionChanged += this.Pivot_SelectionChanged;
                    #line default
                }
                break;
            case 11:
                {
                    this.FromAccountsSel = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 12:
                {
                    this.ToAccountSel = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 13:
                {
                    this.TranDateStamp = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 14:
                {
                    this.TransferMoney = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 15:
                {
                    this.TDesc = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 16:
                {
                    this.AccountsListSel = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 17:
                {
                    this.DateStamp = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 18:
                {
                    this.IncExpSelect = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 19:
                {
                    this.MoneyIn = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 20:
                {
                    this.Desc = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 21:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element21 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 111 "..\..\..\Views\TransactionPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element21).Click += this.Transfer_Click;
                    #line default
                }
                break;
            case 22:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element22 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 101 "..\..\..\Views\TransactionPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element22).Click += this.AddData;
                    #line default
                }
                break;
            case 23:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element23 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 24:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element24 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 25:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element25 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    TransactionPage_obj1_Bindings bindings = new TransactionPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}
