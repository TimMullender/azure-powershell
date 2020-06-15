// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6246, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Sample.API.Models
{
    using Sample.API.Runtime.PowerShell;

    /// <summary>Azure Zone</summary>
    [System.ComponentModel.TypeConverter(typeof(AzureZoneTypeConverter))]
    public partial class AzureZone
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Sample.API.Models.AzureZone"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AzureZone(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Sample.API.Models.IAzureZoneInternal)this).Properties = (Sample.API.Models.IAzureZoneProperties) content.GetValueForProperty("Properties",((Sample.API.Models.IAzureZoneInternal)this).Properties, Sample.API.Models.AzureZonePropertiesTypeConverter.ConvertFrom);
            ((Sample.API.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Sample.API.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Sample.API.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Sample.API.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Sample.API.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Sample.API.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Sample.API.Models.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Sample.API.Models.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Sample.API.Models.IResourceInternal)this).Tags = (Sample.API.Models.IResourceTags) content.GetValueForProperty("Tags",((Sample.API.Models.IResourceInternal)this).Tags, Sample.API.Models.ResourceTagsTypeConverter.ConvertFrom);
            ((Sample.API.Models.IAzureZoneInternal)this).ProvisioningState = (Sample.API.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Sample.API.Models.IAzureZoneInternal)this).ProvisioningState, Sample.API.Support.ProvisioningState.CreateFrom);
            ((Sample.API.Models.IAzureZoneInternal)this).VMSize = (Sample.API.Support.VMSize?) content.GetValueForProperty("VMSize",((Sample.API.Models.IAzureZoneInternal)this).VMSize, Sample.API.Support.VMSize.CreateFrom);
            ((Sample.API.Models.IAzureZoneInternal)this).StorageContainer = (string) content.GetValueForProperty("StorageContainer",((Sample.API.Models.IAzureZoneInternal)this).StorageContainer, global::System.Convert.ToString);
            ((Sample.API.Models.IAzureZoneInternal)this).StorageManagedIdentity = (Sample.API.Models.IVirtualMachineIdentity) content.GetValueForProperty("StorageManagedIdentity",((Sample.API.Models.IAzureZoneInternal)this).StorageManagedIdentity, Sample.API.Models.VirtualMachineIdentityTypeConverter.ConvertFrom);
            ((Sample.API.Models.IAzureZoneInternal)this).StorageAccessKey = (string) content.GetValueForProperty("StorageAccessKey",((Sample.API.Models.IAzureZoneInternal)this).StorageAccessKey, global::System.Convert.ToString);
            ((Sample.API.Models.IAzureZoneInternal)this).StorageAccountId = (string) content.GetValueForProperty("StorageAccountId",((Sample.API.Models.IAzureZoneInternal)this).StorageAccountId, global::System.Convert.ToString);
            ((Sample.API.Models.IAzureZoneInternal)this).NodeCount = (int?) content.GetValueForProperty("NodeCount",((Sample.API.Models.IAzureZoneInternal)this).NodeCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Sample.API.Models.IAzureZoneInternal)this).Subnet = (string) content.GetValueForProperty("Subnet",((Sample.API.Models.IAzureZoneInternal)this).Subnet, global::System.Convert.ToString);
            ((Sample.API.Models.IAzureZoneInternal)this).VirtualNetworkId = (string) content.GetValueForProperty("VirtualNetworkId",((Sample.API.Models.IAzureZoneInternal)this).VirtualNetworkId, global::System.Convert.ToString);
            ((Sample.API.Models.IAzureZoneInternal)this).Nodes = (Sample.API.Models.IAzureNodeDetails[]) content.GetValueForProperty("Nodes",((Sample.API.Models.IAzureZoneInternal)this).Nodes, __y => TypeConverterExtensions.SelectToArray<Sample.API.Models.IAzureNodeDetails>(__y, Sample.API.Models.AzureNodeDetailsTypeConverter.ConvertFrom));
            ((Sample.API.Models.IAzureZoneInternal)this).StorageManagedIdentityType = (Sample.API.Support.ResourceIdentityType?) content.GetValueForProperty("StorageManagedIdentityType",((Sample.API.Models.IAzureZoneInternal)this).StorageManagedIdentityType, Sample.API.Support.ResourceIdentityType.CreateFrom);
            ((Sample.API.Models.IAzureZoneInternal)this).StorageManagedIdentityUserAssignedIdentities = (Sample.API.Models.IVirtualMachineIdentityUserAssignedIdentities) content.GetValueForProperty("StorageManagedIdentityUserAssignedIdentities",((Sample.API.Models.IAzureZoneInternal)this).StorageManagedIdentityUserAssignedIdentities, Sample.API.Models.VirtualMachineIdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Sample.API.Models.AzureZone"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AzureZone(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Sample.API.Models.IAzureZoneInternal)this).Properties = (Sample.API.Models.IAzureZoneProperties) content.GetValueForProperty("Properties",((Sample.API.Models.IAzureZoneInternal)this).Properties, Sample.API.Models.AzureZonePropertiesTypeConverter.ConvertFrom);
            ((Sample.API.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Sample.API.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Sample.API.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Sample.API.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Sample.API.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Sample.API.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Sample.API.Models.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Sample.API.Models.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Sample.API.Models.IResourceInternal)this).Tags = (Sample.API.Models.IResourceTags) content.GetValueForProperty("Tags",((Sample.API.Models.IResourceInternal)this).Tags, Sample.API.Models.ResourceTagsTypeConverter.ConvertFrom);
            ((Sample.API.Models.IAzureZoneInternal)this).ProvisioningState = (Sample.API.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Sample.API.Models.IAzureZoneInternal)this).ProvisioningState, Sample.API.Support.ProvisioningState.CreateFrom);
            ((Sample.API.Models.IAzureZoneInternal)this).VMSize = (Sample.API.Support.VMSize?) content.GetValueForProperty("VMSize",((Sample.API.Models.IAzureZoneInternal)this).VMSize, Sample.API.Support.VMSize.CreateFrom);
            ((Sample.API.Models.IAzureZoneInternal)this).StorageContainer = (string) content.GetValueForProperty("StorageContainer",((Sample.API.Models.IAzureZoneInternal)this).StorageContainer, global::System.Convert.ToString);
            ((Sample.API.Models.IAzureZoneInternal)this).StorageManagedIdentity = (Sample.API.Models.IVirtualMachineIdentity) content.GetValueForProperty("StorageManagedIdentity",((Sample.API.Models.IAzureZoneInternal)this).StorageManagedIdentity, Sample.API.Models.VirtualMachineIdentityTypeConverter.ConvertFrom);
            ((Sample.API.Models.IAzureZoneInternal)this).StorageAccessKey = (string) content.GetValueForProperty("StorageAccessKey",((Sample.API.Models.IAzureZoneInternal)this).StorageAccessKey, global::System.Convert.ToString);
            ((Sample.API.Models.IAzureZoneInternal)this).StorageAccountId = (string) content.GetValueForProperty("StorageAccountId",((Sample.API.Models.IAzureZoneInternal)this).StorageAccountId, global::System.Convert.ToString);
            ((Sample.API.Models.IAzureZoneInternal)this).NodeCount = (int?) content.GetValueForProperty("NodeCount",((Sample.API.Models.IAzureZoneInternal)this).NodeCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Sample.API.Models.IAzureZoneInternal)this).Subnet = (string) content.GetValueForProperty("Subnet",((Sample.API.Models.IAzureZoneInternal)this).Subnet, global::System.Convert.ToString);
            ((Sample.API.Models.IAzureZoneInternal)this).VirtualNetworkId = (string) content.GetValueForProperty("VirtualNetworkId",((Sample.API.Models.IAzureZoneInternal)this).VirtualNetworkId, global::System.Convert.ToString);
            ((Sample.API.Models.IAzureZoneInternal)this).Nodes = (Sample.API.Models.IAzureNodeDetails[]) content.GetValueForProperty("Nodes",((Sample.API.Models.IAzureZoneInternal)this).Nodes, __y => TypeConverterExtensions.SelectToArray<Sample.API.Models.IAzureNodeDetails>(__y, Sample.API.Models.AzureNodeDetailsTypeConverter.ConvertFrom));
            ((Sample.API.Models.IAzureZoneInternal)this).StorageManagedIdentityType = (Sample.API.Support.ResourceIdentityType?) content.GetValueForProperty("StorageManagedIdentityType",((Sample.API.Models.IAzureZoneInternal)this).StorageManagedIdentityType, Sample.API.Support.ResourceIdentityType.CreateFrom);
            ((Sample.API.Models.IAzureZoneInternal)this).StorageManagedIdentityUserAssignedIdentities = (Sample.API.Models.IVirtualMachineIdentityUserAssignedIdentities) content.GetValueForProperty("StorageManagedIdentityUserAssignedIdentities",((Sample.API.Models.IAzureZoneInternal)this).StorageManagedIdentityUserAssignedIdentities, Sample.API.Models.VirtualMachineIdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Sample.API.Models.AzureZone"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Sample.API.Models.IAzureZone" />.</returns>
        public static Sample.API.Models.IAzureZone DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AzureZone(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Sample.API.Models.AzureZone"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Sample.API.Models.IAzureZone" />.</returns>
        public static Sample.API.Models.IAzureZone DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AzureZone(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AzureZone" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IAzureZone FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Azure Zone
    [System.ComponentModel.TypeConverter(typeof(AzureZoneTypeConverter))]
    public partial interface IAzureZone

    {

    }
}