﻿#pragma checksum "D:\github\FrostyFunBox\testfolder\uwptest\BigApp\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9469132024BF1866E63C057E9AA17D27"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BigApp
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 12
                {
                    this.bigbutton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.bigbutton).Click += this.BIG_Button_Click;
                }
                break;
            case 3: // MainPage.xaml line 13
                {
                    this.testbox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.testbox).SelectionChanged += this.testbox_SelectionChanged;
                }
                break;
            case 4: // MainPage.xaml line 14
                {
                    this.UPGRADE = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.UPGRADE).Click += this.UPGRADE_Click;
                }
                break;
            case 5: // MainPage.xaml line 19
                {
                    this.UpgradeCost = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.UpgradeCost).SelectionChanged += this.UpgradeCost_SelectionChanged;
                }
                break;
            case 6: // MainPage.xaml line 20
                {
                    this.ClickAmount = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.ClickAmount).SelectionChanged += this.UpgradeCost_SelectionChanged;
                }
                break;
            case 7: // MainPage.xaml line 21
                {
                    this.AutoToggle = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.AutoToggle).Click += this.AutoToggle_Click;
                }
                break;
            case 8: // MainPage.xaml line 22
                {
                    this.TimeIncrease = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.TimeIncrease).Click += this.TimeIncrease_Click;
                }
                break;
            case 9: // MainPage.xaml line 23
                {
                    this.TimeCost = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.TimeCost).SelectionChanged += this.UpgradeCost_SelectionChanged;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

