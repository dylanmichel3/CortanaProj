﻿#pragma checksum "C:\Users\502707467\Desktop\Techtana\Techtana\Connectivity.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E2455FC991417C2E61BFC37C91CBE1CF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Techtana
{
    partial class Connectivity : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
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
                    this.Guide = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 2:
                {
                    this.Request = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 40 "..\..\..\Connectivity.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Request).Click += this.RequestButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.Manage = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 48 "..\..\..\Connectivity.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Manage).Click += this.ManageButton_Click;
                    #line default
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
            return returnValue;
        }
    }
}
