﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4918
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.Unity.Configuration.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.Unity.Configuration.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Can only convert to and from strings, not type {0}.
        /// </summary>
        internal static string ConversionNotSupported {
            get {
                return ResourceManager.GetString("ConversionNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value element named &lt;{1}&gt; is not available with generic arrays in the property or parameter named &quot;{0}&quot;..
        /// </summary>
        internal static string GenericParameterArrayNotSupported {
            get {
                return ResourceManager.GetString("GenericParameterArrayNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value element named &lt;{1}&gt; is not available with generic parameters in the property or parameter named &quot;{0}&quot;..
        /// </summary>
        internal static string GenericParameterNotSupported {
            get {
                return ResourceManager.GetString("GenericParameterNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration that leads to the current state is invalid and should have been checked during deserialization..
        /// </summary>
        internal static string InvalidConfiguration {
            get {
                return ResourceManager.GetString("InvalidConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration file does not specify a &lt;value&gt; or &lt;dependency&gt; element for the property or parameter named &quot;{0}&quot;. You must specify one of them but not both..
        /// </summary>
        internal static string MustGiveValueOrDependency {
            get {
                return ResourceManager.GetString("MustGiveValueOrDependency", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration file specifies both a &lt;value&gt; and a &lt;dependency&gt;element for the property or parameter named &quot;{0}&quot;. You must specify only one of these..
        /// </summary>
        internal static string MustHaveOnlyOneOfValueOrDependency {
            get {
                return ResourceManager.GetString("MustHaveOnlyOneOfValueOrDependency", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration file includes a &lt;dependency&gt; element that specifies a type for the generic parameter &quot;{0}&quot;..
        /// </summary>
        internal static string MustNotProvideATypeForDependencyIfBelongsToGeneric {
            get {
                return ResourceManager.GetString("MustNotProvideATypeForDependencyIfBelongsToGeneric", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration file must include a value for one of &quot;parameterType&quot; and &quot;genericParameterName&quot; for the property or parameter named &quot;{0}&quot;..
        /// </summary>
        internal static string NeitherParameterTypeNorGenericParameterNameSpecified {
            get {
                return ResourceManager.GetString("NeitherParameterTypeNorGenericParameterNameSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration file includes values for more than one of &quot;parameterType&quot; and &quot;genericParameterName&quot; for the property or parameter named &quot;{0}&quot;. You must specify only one of these..
        /// </summary>
        internal static string OnlyOneOfParameterTypeAndGenericParameterNameAllowed {
            get {
                return ResourceManager.GetString("OnlyOneOfParameterTypeAndGenericParameterNameAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration file includes more than one value element for the property or parameter named &quot;{0}&quot;..
        /// </summary>
        internal static string OnlyOneValueElementAllowed {
            get {
                return ResourceManager.GetString("OnlyOneValueElementAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration file includes a property or parameter which is configured with an array value but has type {0} which is not an array type. ({1} line {2}).
        /// </summary>
        internal static string ParameterTypeIsNotArray {
            get {
                return ResourceManager.GetString("ParameterTypeIsNotArray", resourceCulture);
            }
        }
    }
}
