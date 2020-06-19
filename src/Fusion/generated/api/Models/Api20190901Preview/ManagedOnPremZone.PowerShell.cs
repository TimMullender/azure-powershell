namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using Wandisco.Fusion.Runtime.PowerShell;

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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.ManagedOnPremZone"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZone" />.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZone DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ManagedOnPremZone(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.ManagedOnPremZone"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZone" />.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZone DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ManagedOnPremZone(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ManagedOnPremZone" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZone FromJsonString(string jsonText) => FromJson(Wandisco.Fusion.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.ManagedOnPremZone"
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
            ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal)this).Properties = (Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneProperties) content.GetValueForProperty("Properties",((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal)this).Properties, Wandisco.Fusion.Models.Api20190901Preview.ManagedOnPremZonePropertiesTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Tags = (Wandisco.Fusion.Models.Api20190901Preview.IResourceTags) content.GetValueForProperty("Tags",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Tags, Wandisco.Fusion.Models.Api20190901Preview.ResourceTagsTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal)this).ProvisioningState = (Wandisco.Fusion.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal)this).ProvisioningState, Wandisco.Fusion.Support.ProvisioningState.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal)this).DeploymentType = (Wandisco.Fusion.Support.ManagedOnPremDeploymentType) content.GetValueForProperty("DeploymentType",((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal)this).DeploymentType, Wandisco.Fusion.Support.ManagedOnPremDeploymentType.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal)this).DownloadLocation = (string) content.GetValueForProperty("DownloadLocation",((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal)this).DownloadLocation, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal)this).ExternalIP = (string) content.GetValueForProperty("ExternalIP",((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal)this).ExternalIP, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal)this).Nodes = (Wandisco.Fusion.Models.Api20190901Preview.INodeDetails[]) content.GetValueForProperty("Nodes",((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal)this).Nodes, __y => TypeConverterExtensions.SelectToArray<Wandisco.Fusion.Models.Api20190901Preview.INodeDetails>(__y, Wandisco.Fusion.Models.Api20190901Preview.NodeDetailsTypeConverter.ConvertFrom));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.ManagedOnPremZone"
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
            ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal)this).Properties = (Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneProperties) content.GetValueForProperty("Properties",((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal)this).Properties, Wandisco.Fusion.Models.Api20190901Preview.ManagedOnPremZonePropertiesTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Tags = (Wandisco.Fusion.Models.Api20190901Preview.IResourceTags) content.GetValueForProperty("Tags",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Tags, Wandisco.Fusion.Models.Api20190901Preview.ResourceTagsTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal)this).ProvisioningState = (Wandisco.Fusion.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal)this).ProvisioningState, Wandisco.Fusion.Support.ProvisioningState.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal)this).DeploymentType = (Wandisco.Fusion.Support.ManagedOnPremDeploymentType) content.GetValueForProperty("DeploymentType",((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal)this).DeploymentType, Wandisco.Fusion.Support.ManagedOnPremDeploymentType.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal)this).DownloadLocation = (string) content.GetValueForProperty("DownloadLocation",((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal)this).DownloadLocation, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal)this).ExternalIP = (string) content.GetValueForProperty("ExternalIP",((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal)this).ExternalIP, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal)this).Nodes = (Wandisco.Fusion.Models.Api20190901Preview.INodeDetails[]) content.GetValueForProperty("Nodes",((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal)this).Nodes, __y => TypeConverterExtensions.SelectToArray<Wandisco.Fusion.Models.Api20190901Preview.INodeDetails>(__y, Wandisco.Fusion.Models.Api20190901Preview.NodeDetailsTypeConverter.ConvertFrom));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Wandisco.Fusion.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Managed OnPrem Zone
    [System.ComponentModel.TypeConverter(typeof(ManagedOnPremZoneTypeConverter))]
    public partial interface IManagedOnPremZone

    {

    }
}