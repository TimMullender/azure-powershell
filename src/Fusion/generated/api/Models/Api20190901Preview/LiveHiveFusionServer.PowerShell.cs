namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using Wandisco.Fusion.Runtime.PowerShell;

    /// <summary>Live Hive Proxy and Fusion Server Plugin</summary>
    [System.ComponentModel.TypeConverter(typeof(LiveHiveFusionServerTypeConverter))]
    public partial class LiveHiveFusionServer
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.LiveHiveFusionServer"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.ILiveHiveFusionServer" />.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.ILiveHiveFusionServer DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new LiveHiveFusionServer(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.LiveHiveFusionServer"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.ILiveHiveFusionServer" />.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.ILiveHiveFusionServer DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new LiveHiveFusionServer(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="LiveHiveFusionServer" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.ILiveHiveFusionServer FromJsonString(string jsonText) => FromJson(Wandisco.Fusion.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.LiveHiveFusionServer"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal LiveHiveFusionServer(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Wandisco.Fusion.Models.Api20190901Preview.ILiveHiveFusionServerInternal)this).HiveMetastore = (string) content.GetValueForProperty("HiveMetastore",((Wandisco.Fusion.Models.Api20190901Preview.ILiveHiveFusionServerInternal)this).HiveMetastore, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal)this).PluginKind = (Wandisco.Fusion.Support.PluginKind) content.GetValueForProperty("PluginKind",((Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal)this).PluginKind, Wandisco.Fusion.Support.PluginKind.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal)this).ProvisioningState = (Wandisco.Fusion.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal)this).ProvisioningState, Wandisco.Fusion.Support.ProvisioningState.CreateFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.LiveHiveFusionServer"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal LiveHiveFusionServer(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Wandisco.Fusion.Models.Api20190901Preview.ILiveHiveFusionServerInternal)this).HiveMetastore = (string) content.GetValueForProperty("HiveMetastore",((Wandisco.Fusion.Models.Api20190901Preview.ILiveHiveFusionServerInternal)this).HiveMetastore, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal)this).PluginKind = (Wandisco.Fusion.Support.PluginKind) content.GetValueForProperty("PluginKind",((Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal)this).PluginKind, Wandisco.Fusion.Support.PluginKind.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal)this).ProvisioningState = (Wandisco.Fusion.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal)this).ProvisioningState, Wandisco.Fusion.Support.ProvisioningState.CreateFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Wandisco.Fusion.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Live Hive Proxy and Fusion Server Plugin
    [System.ComponentModel.TypeConverter(typeof(LiveHiveFusionServerTypeConverter))]
    public partial interface ILiveHiveFusionServer

    {

    }
}