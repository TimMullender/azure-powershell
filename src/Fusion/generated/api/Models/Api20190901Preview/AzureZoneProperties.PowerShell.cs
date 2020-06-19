namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using Wandisco.Fusion.Runtime.PowerShell;

    /// <summary>azure zone properties</summary>
    [System.ComponentModel.TypeConverter(typeof(AzureZonePropertiesTypeConverter))]
    public partial class AzureZoneProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.AzureZoneProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AzureZoneProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).StorageManagedIdentity = (Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentity) content.GetValueForProperty("StorageManagedIdentity",((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).StorageManagedIdentity, Wandisco.Fusion.Models.Api20190901Preview.VirtualMachineIdentityTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).NodeCount = (int?) content.GetValueForProperty("NodeCount",((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).NodeCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).Nodes = (Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetails[]) content.GetValueForProperty("Nodes",((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).Nodes, __y => TypeConverterExtensions.SelectToArray<Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetails>(__y, Wandisco.Fusion.Models.Api20190901Preview.AzureNodeDetailsTypeConverter.ConvertFrom));
            ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).ProvisioningState = (Wandisco.Fusion.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).ProvisioningState, Wandisco.Fusion.Support.ProvisioningState.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).StorageAccessKey = (string) content.GetValueForProperty("StorageAccessKey",((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).StorageAccessKey, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).StorageAccountId = (string) content.GetValueForProperty("StorageAccountId",((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).StorageAccountId, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).StorageContainer = (string) content.GetValueForProperty("StorageContainer",((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).StorageContainer, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).Subnet = (string) content.GetValueForProperty("Subnet",((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).Subnet, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).VirtualNetworkId = (string) content.GetValueForProperty("VirtualNetworkId",((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).VirtualNetworkId, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).VMSize = (Wandisco.Fusion.Support.VMSize?) content.GetValueForProperty("VMSize",((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).VMSize, Wandisco.Fusion.Support.VMSize.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).StorageManagedIdentityType = (Wandisco.Fusion.Support.ResourceIdentityType?) content.GetValueForProperty("StorageManagedIdentityType",((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).StorageManagedIdentityType, Wandisco.Fusion.Support.ResourceIdentityType.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).StorageManagedIdentityUserAssignedIdentities = (Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentityUserAssignedIdentities) content.GetValueForProperty("StorageManagedIdentityUserAssignedIdentities",((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).StorageManagedIdentityUserAssignedIdentities, Wandisco.Fusion.Models.Api20190901Preview.VirtualMachineIdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.AzureZoneProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AzureZoneProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).StorageManagedIdentity = (Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentity) content.GetValueForProperty("StorageManagedIdentity",((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).StorageManagedIdentity, Wandisco.Fusion.Models.Api20190901Preview.VirtualMachineIdentityTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).NodeCount = (int?) content.GetValueForProperty("NodeCount",((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).NodeCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).Nodes = (Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetails[]) content.GetValueForProperty("Nodes",((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).Nodes, __y => TypeConverterExtensions.SelectToArray<Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetails>(__y, Wandisco.Fusion.Models.Api20190901Preview.AzureNodeDetailsTypeConverter.ConvertFrom));
            ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).ProvisioningState = (Wandisco.Fusion.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).ProvisioningState, Wandisco.Fusion.Support.ProvisioningState.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).StorageAccessKey = (string) content.GetValueForProperty("StorageAccessKey",((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).StorageAccessKey, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).StorageAccountId = (string) content.GetValueForProperty("StorageAccountId",((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).StorageAccountId, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).StorageContainer = (string) content.GetValueForProperty("StorageContainer",((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).StorageContainer, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).Subnet = (string) content.GetValueForProperty("Subnet",((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).Subnet, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).VirtualNetworkId = (string) content.GetValueForProperty("VirtualNetworkId",((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).VirtualNetworkId, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).VMSize = (Wandisco.Fusion.Support.VMSize?) content.GetValueForProperty("VMSize",((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).VMSize, Wandisco.Fusion.Support.VMSize.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).StorageManagedIdentityType = (Wandisco.Fusion.Support.ResourceIdentityType?) content.GetValueForProperty("StorageManagedIdentityType",((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).StorageManagedIdentityType, Wandisco.Fusion.Support.ResourceIdentityType.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).StorageManagedIdentityUserAssignedIdentities = (Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentityUserAssignedIdentities) content.GetValueForProperty("StorageManagedIdentityUserAssignedIdentities",((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)this).StorageManagedIdentityUserAssignedIdentities, Wandisco.Fusion.Models.Api20190901Preview.VirtualMachineIdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.AzureZoneProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.IAzureZoneProperties" />.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IAzureZoneProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AzureZoneProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.AzureZoneProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.IAzureZoneProperties" />.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IAzureZoneProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AzureZoneProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AzureZoneProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IAzureZoneProperties FromJsonString(string jsonText) => FromJson(Wandisco.Fusion.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Wandisco.Fusion.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// azure zone properties
    [System.ComponentModel.TypeConverter(typeof(AzureZonePropertiesTypeConverter))]
    public partial interface IAzureZoneProperties

    {

    }
}