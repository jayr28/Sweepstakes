﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HumaneSociety.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.;Initial Catalog=HumaneSociety;Integrated Security=True;Encrypt=Fals" +
            "e;TrustServerCertificate=True")]
        public string HumaneSocietyConnectionString {
            get {
                return ((string)(this["HumaneSocietyConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HumaneSociety;Integrated Secur" +
            "ity=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True")]
        public string HumaneSocietyConnectionString1 {
            get {
                return ((string)(this["HumaneSocietyConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=aspnet-SuperHeroRegistry-20180" +
            "610103656;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerC" +
            "ertificate=False")]
        public string aspnet_SuperHeroRegistry_20180610103656ConnectionString {
            get {
                return ((string)(this["aspnet_SuperHeroRegistry_20180610103656ConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=MSI;Initial Catalog=HumaneSociety;Integrated Security=True;Connect Ti" +
            "meout=30;Encrypt=False;TrustServerCertificate=False")]
        public string HumaneSocietyConnectionString2 {
            get {
                return ((string)(this["HumaneSocietyConnectionString2"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-KSBFPDD;Initial Catalog=HumanSoceity;Integrated Security=True" +
            ";Connect Timeout=30;Encrypt=False;TrustServerCertificate=False")]
        public string HumanSoceityConnectionString {
            get {
                return ((string)(this["HumanSoceityConnectionString"]));
            }
        }
    }
}
