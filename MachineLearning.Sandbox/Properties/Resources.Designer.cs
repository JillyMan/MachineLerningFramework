﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MachineLearning.Sandbox.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MachineLearning.Sandbox.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to ../../../Data/CarEvaluationDataSet/car.attr.meta.json.
        /// </summary>
        internal static string CarAttrMetaInfo {
            get {
                return ResourceManager.GetString("CarAttrMetaInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ../../../Data/CarEvaluationDataSet/car.data.csv.
        /// </summary>
        internal static string CarDataCsv {
            get {
                return ResourceManager.GetString("CarDataCsv", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ..\..\..\Data\DecisionTree\data.csv.
        /// </summary>
        internal static string CsvLearnDataPath {
            get {
                return ResourceManager.GetString("CsvLearnDataPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ..\..\..\Data\DecisionTree\metaInfo.json.
        /// </summary>
        internal static string MetaInfoOfLearnSet {
            get {
                return ResourceManager.GetString("MetaInfoOfLearnSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ..\..\..\Data\DecisionTree\training_set.json.
        /// </summary>
        internal static string PlayTennisJsonLearnDataPath {
            get {
                return ResourceManager.GetString("PlayTennisJsonLearnDataPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ..\..\..\Data\DecisionTree\test_case.json.
        /// </summary>
        internal static string TestCaseDecisionTree {
            get {
                return ResourceManager.GetString("TestCaseDecisionTree", resourceCulture);
            }
        }
    }
}
