// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6246, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Sample.API.Models
{
    using Sample.API.Runtime.PowerShell;

    /// <summary>Managed OnPrem Zone</summary>
    [System.ComponentModel.TypeConverter(typeof(ManagedOnPremZoneTypeConverter))]
    public partial class ManagedOnPremZone
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Sample.API.Models.ManagedOnPremZone"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Sample.API.Models.IManagedOnPremZone" />.</returns>
        public static Sample.API.Models.IManagedOnPremZone DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ManagedOnPremZone(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Sample.API.Models.ManagedOnPremZone"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Sample.API.Models.IManagedOnPremZone" />.</returns>
        public static Sample.API.Models.IManagedOnPremZone DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ManagedOnPremZone(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ManagedOnPremZone" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IManagedOnPremZone FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Sample.API.Models.ManagedOnPremZone"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ManagedOnPremZone(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Sample.API.Models.IManagedOnPremZoneInternal)this).Properties = (Sample.API.Models.IManagedOnPremZoneProperties) content.GetValueForProperty("Properties",((Sample.API.Models.IManagedOnPremZoneInternal)this).Properties, Sample.API.Models.ManagedOnPremZonePropertiesTypeConverter.ConvertFrom);
            ((Sample.API.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Sample.API.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Sample.API.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Sample.API.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Sample.API.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Sample.API.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Sample.API.Models.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Sample.API.Models.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Sample.API.Models.IResourceInternal)this).Tags = (Sample.API.Models.IResourceTags) content.GetValueForProperty("Tags",((Sample.API.Models.IResourceInternal)this).Tags, Sample.API.Models.ResourceTagsTypeConverter.ConvertFrom);
            ((Sample.API.Models.IManagedOnPremZoneInternal)this).ProvisioningState = (Sample.API.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Sample.API.Models.IManagedOnPremZoneInternal)this).ProvisioningState, Sample.API.Support.ProvisioningState.CreateFrom);
            ((Sample.API.Models.IManagedOnPremZoneInternal)this).DeploymentType = (Sample.API.Support.ManagedOnPremDeploymentType) content.GetValueForProperty("DeploymentType",((Sample.API.Models.IManagedOnPremZoneInternal)this).DeploymentType, Sample.API.Support.ManagedOnPremDeploymentType.CreateFrom);
            ((Sample.API.Models.IManagedOnPremZoneInternal)this).DownloadLocation = (string) content.GetValueForProperty("DownloadLocation",((Sample.API.Models.IManagedOnPremZoneInternal)this).DownloadLocation, global::System.Convert.ToString);
            ((Sample.API.Models.IManagedOnPremZoneInternal)this).ExternalIP = (string) content.GetValueForProperty("ExternalIP",((Sample.API.Models.IManagedOnPremZoneInternal)this).ExternalIP, global::System.Convert.ToString);
            ((Sample.API.Models.IManagedOnPremZoneInternal)this).Nodes = (Sample.API.Models.INodeDetails[]) content.GetValueForProperty("Nodes",((Sample.API.Models.IManagedOnPremZoneInternal)this).Nodes, __y => TypeConverterExtensions.SelectToArray<Sample.API.Models.INodeDetails>(__y, Sample.API.Models.NodeDetailsTypeConverter.ConvertFrom));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Sample.API.Models.ManagedOnPremZone"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ManagedOnPremZone(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Sample.API.Models.IManagedOnPremZoneInternal)this).Properties = (Sample.API.Models.IManagedOnPremZoneProperties) content.GetValueForProperty("Properties",((Sample.API.Models.IManagedOnPremZoneInternal)this).Properties, Sample.API.Models.ManagedOnPremZonePropertiesTypeConverter.ConvertFrom);
            ((Sample.API.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Sample.API.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Sample.API.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Sample.API.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Sample.API.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Sample.API.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Sample.API.Models.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Sample.API.Models.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Sample.API.Models.IResourceInternal)this).Tags = (Sample.API.Models.IResourceTags) content.GetValueForProperty("Tags",((Sample.API.Models.IResourceInternal)this).Tags, Sample.API.Models.ResourceTagsTypeConverter.ConvertFrom);
            ((Sample.API.Models.IManagedOnPremZoneInternal)this).ProvisioningState = (Sample.API.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Sample.API.Models.IManagedOnPremZoneInternal)this).ProvisioningState, Sample.API.Support.ProvisioningState.CreateFrom);
            ((Sample.API.Models.IManagedOnPremZoneInternal)this).DeploymentType = (Sample.API.Support.ManagedOnPremDeploymentType) content.GetValueForProperty("DeploymentType",((Sample.API.Models.IManagedOnPremZoneInternal)this).DeploymentType, Sample.API.Support.ManagedOnPremDeploymentType.CreateFrom);
            ((Sample.API.Models.IManagedOnPremZoneInternal)this).DownloadLocation = (string) content.GetValueForProperty("DownloadLocation",((Sample.API.Models.IManagedOnPremZoneInternal)this).DownloadLocation, global::System.Convert.ToString);
            ((Sample.API.Models.IManagedOnPremZoneInternal)this).ExternalIP = (string) content.GetValueForProperty("ExternalIP",((Sample.API.Models.IManagedOnPremZoneInternal)this).ExternalIP, global::System.Convert.ToString);
            ((Sample.API.Models.IManagedOnPremZoneInternal)this).Nodes = (Sample.API.Models.INodeDetails[]) content.GetValueForProperty("Nodes",((Sample.API.Models.IManagedOnPremZoneInternal)this).Nodes, __y => TypeConverterExtensions.SelectToArray<Sample.API.Models.INodeDetails>(__y, Sample.API.Models.NodeDetailsTypeConverter.ConvertFrom));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Managed OnPrem Zone
    [System.ComponentModel.TypeConverter(typeof(ManagedOnPremZoneTypeConverter))]
    public partial interface IManagedOnPremZone

    {

    }
}