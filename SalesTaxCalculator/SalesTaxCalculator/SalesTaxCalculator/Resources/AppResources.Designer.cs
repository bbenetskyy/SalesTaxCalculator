﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalesTaxCalculator.Resources {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AppResources {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppResources() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("SalesTaxCalculator.Resources.AppResources", typeof(AppResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string TaxTabTitle {
            get {
                return ResourceManager.GetString("TaxTabTitle", resourceCulture);
            }
        }
        
        internal static string RateTabTitle {
            get {
                return ResourceManager.GetString("RateTabTitle", resourceCulture);
            }
        }
        
        internal static string ZipPlaceholder {
            get {
                return ResourceManager.GetString("ZipPlaceholder", resourceCulture);
            }
        }
        
        internal static string CountryPlaceholder {
            get {
                return ResourceManager.GetString("CountryPlaceholder", resourceCulture);
            }
        }
        
        internal static string CityPlaceholder {
            get {
                return ResourceManager.GetString("CityPlaceholder", resourceCulture);
            }
        }
        
        internal static string CalculateRateButton {
            get {
                return ResourceManager.GetString("CalculateRateButton", resourceCulture);
            }
        }
        
        internal static string RequiredFieldMessage {
            get {
                return ResourceManager.GetString("RequiredFieldMessage", resourceCulture);
            }
        }
        
        internal static string OkButton {
            get {
                return ResourceManager.GetString("OkButton", resourceCulture);
            }
        }
        
        internal static string ValidationFailedMessage {
            get {
                return ResourceManager.GetString("ValidationFailedMessage", resourceCulture);
            }
        }
    }
}