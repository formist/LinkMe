﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4918
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.Unity.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.Unity.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The provided string argument must not be empty..
        /// </summary>
        internal static string ArgumentMustNotBeEmpty {
            get {
                return ResourceManager.GetString("ArgumentMustNotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The method {0}.{1}({2}) is an open generic method. Open generic methods cannot be injected..
        /// </summary>
        internal static string CannotInjectGenericMethod {
            get {
                return ResourceManager.GetString("CannotInjectGenericMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property {0} on type {1} is an indexer. Indexed properties cannot be injected..
        /// </summary>
        internal static string CannotInjectIndexer {
            get {
                return ResourceManager.GetString("CannotInjectIndexer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The method {0}.{1}({2}) has at least one out parameter. Methods with out parameters cannot be injected..
        /// </summary>
        internal static string CannotInjectMethodWithOutParams {
            get {
                return ResourceManager.GetString("CannotInjectMethodWithOutParams", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The method {0}.{1}({2}) has at least one ref parameter.Methods with ref parameters cannot be injected..
        /// </summary>
        internal static string CannotInjectMethodWithRefParams {
            get {
                return ResourceManager.GetString("CannotInjectMethodWithRefParams", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The method {0}.{1}({2}) is static. Static methods cannot be injected..
        /// </summary>
        internal static string CannotInjectStaticMethod {
            get {
                return ResourceManager.GetString("CannotInjectStaticMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The lifetime manager is already registered. Lifetime managers cannot be reused, please create a new one..
        /// </summary>
        internal static string LifetimeManagerInUse {
            get {
                return ResourceManager.GetString("LifetimeManagerInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type {0} does not have a generic argument named &quot;{1}&quot;.
        /// </summary>
        internal static string NoMatchingGenericArgument {
            get {
                return ResourceManager.GetString("NoMatchingGenericArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type {0} does not have a constructor that takes the parameters ({1})..
        /// </summary>
        internal static string NoSuchConstructor {
            get {
                return ResourceManager.GetString("NoSuchConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type {0} does not have a public method named {1} that takes the parameters ({2})..
        /// </summary>
        internal static string NoSuchMethod {
            get {
                return ResourceManager.GetString("NoSuchMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type {0} does not contain a property named {1}..
        /// </summary>
        internal static string NoSuchProperty {
            get {
                return ResourceManager.GetString("NoSuchProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type {0} is not a generic type, and you are attempting to inject a generic parameter named &quot;{1}&quot;..
        /// </summary>
        internal static string NotAGenericType {
            get {
                return ResourceManager.GetString("NotAGenericType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type {0} is not an array type with rank 1, and you are attempting to use a [DependencyArray] attribute on a parameter or property with this type..
        /// </summary>
        internal static string NotAnArrayTypeWithRankOne {
            get {
                return ResourceManager.GetString("NotAnArrayTypeWithRankOne", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property {0} on type {1} is not settable..
        /// </summary>
        internal static string PropertyNotSettable {
            get {
                return ResourceManager.GetString("PropertyNotSettable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property {0} on type {1} is of type {2}, and cannot be injected with a value of type {3}..
        /// </summary>
        internal static string PropertyTypeMismatch {
            get {
                return ResourceManager.GetString("PropertyTypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resolution of the dependency failed, type = &quot;{0}&quot;, name = &quot;{1}&quot;. Exception message is: {2}.
        /// </summary>
        internal static string ResolutionFailed {
            get {
                return ResourceManager.GetString("ResolutionFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type {1} cannot be assigned to variables of type {0}..
        /// </summary>
        internal static string TypesAreNotAssignable {
            get {
                return ResourceManager.GetString("TypesAreNotAssignable", resourceCulture);
            }
        }
    }
}
