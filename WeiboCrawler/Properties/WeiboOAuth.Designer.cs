﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeiboTools.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class WeiboOAuth : global::System.Configuration.ApplicationSettingsBase {
        
        private static WeiboOAuth defaultInstance = ((WeiboOAuth)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new WeiboOAuth())));
        
        public static WeiboOAuth Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AccessToken {
            get {
                return ((string)(this["AccessToken"]));
            }
            set {
                this["AccessToken"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("744917056")]
        public string AppKey {
            get {
                return ((string)(this["AppKey"]));
            }
            set {
                this["AppKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("9880920d66a7eb371e708992c6b65a1a")]
        public string AppSecrect {
            get {
                return ((string)(this["AppSecrect"]));
            }
            set {
                this["AppSecrect"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://127.0.0.1")]
        public string CallbackUrl {
            get {
                return ((string)(this["CallbackUrl"]));
            }
            set {
                this["CallbackUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Richbird123")]
        public string WeiboPassword {
            get {
                return ((string)(this["WeiboPassword"]));
            }
            set {
                this["WeiboPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("silver6wings")]
        public string WeiboUser {
            get {
                return ((string)(this["WeiboUser"]));
            }
            set {
                this["WeiboUser"] = value;
            }
        }
    }
}
