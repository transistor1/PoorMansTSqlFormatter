﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PoorMansTSqlFormatterSSMSAddIn {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class GeneralLanguageContent {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal GeneralLanguageContent() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PoorMansTSqlFormatterSSMSAddIn.GeneralLanguageContent", typeof(GeneralLanguageContent).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to The active document is not listed as a &quot;.sql&quot; file - are you sure you want to format?.
        /// </summary>
        internal static string FileTypeWarningMessage {
            get {
                return ResourceManager.GetString("FileTypeWarningMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Non-SQL File.
        /// </summary>
        internal static string FileTypeWarningMessageTitle {
            get {
                return ResourceManager.GetString("FileTypeWarningMessageTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Format T-SQL Code.
        /// </summary>
        internal static string FormatButtonText {
            get {
                return ResourceManager.GetString("FormatButtonText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Formats the selected T-SQL code (or all the code in the active window, if none selected).
        /// </summary>
        internal static string FormatButtonToolTip {
            get {
                return ResourceManager.GetString("FormatButtonToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to T-SQL Formatter hotkey binding failed - please revise hotkey setting.{0}Error Details:{0}{1}.
        /// </summary>
        internal static string HotkeyBindingFailureMessage {
            get {
                return ResourceManager.GetString("HotkeyBindingFailureMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to T-SQL Formatter hotkey retrieval failed - please revise hotkey setting.{0}Error Details:{0}{1}.
        /// </summary>
        internal static string HotkeyRetrievalFailureMessage {
            get {
                return ResourceManager.GetString("HotkeyRetrievalFailureMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to T-SQL Formatting Options....
        /// </summary>
        internal static string OptionsButtonText {
            get {
                return ResourceManager.GetString("OptionsButtonText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Allows you to edit the Poor Man&apos;s T-SQL Formatter options.
        /// </summary>
        internal static string OptionsButtonToolTip {
            get {
                return ResourceManager.GetString("OptionsButtonToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Errors found during SQL parsing. Would you like to apply formatting anyway?.
        /// </summary>
        internal static string ParseErrorWarningMessage {
            get {
                return ResourceManager.GetString("ParseErrorWarningMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Errors found. Continue?.
        /// </summary>
        internal static string ParseErrorWarningMessageTitle {
            get {
                return ResourceManager.GetString("ParseErrorWarningMessageTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A simple free (AGPL) T-SQL Formatting Addin for SSMS and SSMS Express 2005-2012 and Visual Studio 2005-2010..
        /// </summary>
        internal static string ProjectAboutDescription {
            get {
                return ResourceManager.GetString("ProjectAboutDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to retrieve localized Text Editor key binding scope name.{0}Error Details:{0}{1}.
        /// </summary>
        internal static string TextEditorScopeNameRetrievalFailureMessage {
            get {
                return ResourceManager.GetString("TextEditorScopeNameRetrievalFailureMessage", resourceCulture);
            }
        }
    }
}
