﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WindowsFormsApp1.Properties.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 account 的本地化字符串。
        /// </summary>
        internal static string account {
            get {
                return ResourceManager.GetString("account", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 captcha 的本地化字符串。
        /// </summary>
        internal static string captcha {
            get {
                return ResourceManager.GetString("captcha", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 login 的本地化字符串。
        /// </summary>
        internal static string login {
            get {
                return ResourceManager.GetString("login", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 password 的本地化字符串。
        /// </summary>
        internal static string password {
            get {
                return ResourceManager.GetString("password", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 reset 的本地化字符串。
        /// </summary>
        internal static string reset {
            get {
                return ResourceManager.GetString("reset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 tips 的本地化字符串。
        /// </summary>
        internal static string tips {
            get {
                return ResourceManager.GetString("tips", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 tips:account or password error 的本地化字符串。
        /// </summary>
        internal static string tips_account_password_error {
            get {
                return ResourceManager.GetString("tips_account_password_error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 tips:captcha error 的本地化字符串。
        /// </summary>
        internal static string tips_captcha_error {
            get {
                return ResourceManager.GetString("tips_captcha_error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 tips:login success 的本地化字符串。
        /// </summary>
        internal static string tips_login_success {
            get {
                return ResourceManager.GetString("tips_login_success", resourceCulture);
            }
        }
    }
}
