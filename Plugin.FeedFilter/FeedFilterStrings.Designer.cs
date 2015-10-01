﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VirtualRadar.Plugin.FeedFilter {
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
    public class FeedFilterStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal FeedFilterStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VirtualRadar.Plugin.FeedFilter.FeedFilterStrings", typeof(FeedFilterStrings).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Feed Filter.
        /// </summary>
        public static string PluginName {
            get {
                return ResourceManager.GetString("PluginName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prohibit MLAT positions.
        /// </summary>
        public static string ProhibitMlat {
            get {
                return ResourceManager.GetString("ProhibitMlat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prohibit unfilterable feeds.
        /// </summary>
        public static string ProhibitUnfilterableFeeds {
            get {
                return ResourceManager.GetString("ProhibitUnfilterableFeeds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception encountered: {0}.
        /// </summary>
        public static string ServerReportedException {
            get {
                return ResourceManager.GetString("ServerReportedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disabled.
        /// </summary>
        public static string StatusDisabled {
            get {
                return ResourceManager.GetString("StatusDisabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enabled.
        /// </summary>
        public static string StatusEnabled {
            get {
                return ResourceManager.GetString("StatusEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not fetch from server: {0}.
        /// </summary>
        public static string XhrFailed {
            get {
                return ResourceManager.GetString("XhrFailed", resourceCulture);
            }
        }
    }
}
