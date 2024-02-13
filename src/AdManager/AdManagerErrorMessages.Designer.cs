﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Api.Ads.AdManager {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AdManagerErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AdManagerErrorMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Google.Api.Ads.AdManager.AdManagerErrorMessages", typeof(AdManagerErrorMessages).Assembly);
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
        ///   Looks up a localized string similar to The complete query is already set. Partial query building is not allowed..
        /// </summary>
        internal static string CompleteQuerySet {
            get {
                return ResourceManager.GetString("CompleteQuerySet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not set AuthToken or OAuthHeader for outgoing API call. Please check if service.RequestHeader is not null..
        /// </summary>
        internal static string FailedToSetAuthorizationHeader {
            get {
                return ResourceManager.GetString("FailedToSetAuthorizationHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OFFSET cannot be set if LIMIT is not set..
        /// </summary>
        internal static string InvalidOffsetAndLimit {
            get {
                return ResourceManager.GetString("InvalidOffsetAndLimit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OAuth provider cannot be null when selecting Authorization method as &quot;OAuth&quot;..
        /// </summary>
        internal static string OAuthProviderCannotBeNull {
            get {
                return ResourceManager.GetString("OAuthProviderCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A partial query is already set. Access to the complete query is restricted..
        /// </summary>
        internal static string PartialQuerySet {
            get {
                return ResourceManager.GetString("PartialQuerySet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A valid application name was not found in the request header. Please provide a valid application name by modifying the ApplicationName setting in your application&apos;s App.config / Web.config or DfpAppConfig instance..
        /// </summary>
        internal static string RequireValidApplicationName {
            get {
                return ResourceManager.GetString("RequireValidApplicationName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Signature should be a {0} instance..
        /// </summary>
        internal static string SignatureIsOfWrongType {
            get {
                return ResourceManager.GetString("SignatureIsOfWrongType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Authentication method is missing or not supported in this version..
        /// </summary>
        internal static string UnsupportedAuthorizationMethod {
            get {
                return ResourceManager.GetString("UnsupportedAuthorizationMethod", resourceCulture);
            }
        }
    }
}
