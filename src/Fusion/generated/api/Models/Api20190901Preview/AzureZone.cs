namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Azure Zone</summary>
    public partial class AzureZone :
        Wandisco.Fusion.Models.Api20190901Preview.IAzureZone,
        Wandisco.Fusion.Models.Api20190901Preview.IAzureZoneInternal,
        Wandisco.Fusion.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Wandisco.Fusion.Models.Api20190901Preview.IResource" />
        /// </summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IResource __resource = new Wandisco.Fusion.Models.Api20190901Preview.Resource();

        /// <summary>Azure resource Id.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string Id { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Id; }

        /// <summary>Location of the resource.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string Location { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Location; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Location = value; }

        /// <summary>Azure resource name.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string Name { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Name; }

        /// <summary>The number of nodes in the zone</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public int? NodeCount { get => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).NodeCount; set => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).NodeCount = value; }

        /// <summary>List of NodeDetails for each node in the zone</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetails[] Nodes { get => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).Nodes; }

        /// <summary>Backing field for <see cref="Properties" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IAzureZoneProperties _properties;

        /// <summary>azure zone resource properties</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        internal Wandisco.Fusion.Models.Api20190901Preview.IAzureZoneProperties Properties { get => (this._properties = this._properties ?? new Wandisco.Fusion.Models.Api20190901Preview.AzureZoneProperties()); set => this._properties = value; }

        /// <summary>Provisioning State of resource</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).ProvisioningState; }

        /// <summary>Access Key for storage (use either key or identity)</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string StorageAccessKey { get => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).StorageAccessKey; set => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).StorageAccessKey = value; }

        /// <summary>Resource ID of ADLS Gen 2 account to replicate to</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string StorageAccountId { get => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).StorageAccountId; set => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).StorageAccountId = value; }

        /// <summary>Container to replicate</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string StorageContainer { get => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).StorageContainer; set => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).StorageContainer = value; }

        /// <summary>The type of identity used for the virtual machine.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Support.ResourceIdentityType? StorageManagedIdentityType { get => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).StorageManagedIdentityType; set => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).StorageManagedIdentityType = value; }

        /// <summary>
        /// The list of user identities associated with the Virtual Machine. The user identity dictionary key references will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentityUserAssignedIdentities StorageManagedIdentityUserAssignedIdentities { get => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).StorageManagedIdentityUserAssignedIdentities; set => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).StorageManagedIdentityUserAssignedIdentities = value; }

        /// <summary>Resource ID of Subnet to connect VMs to</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string Subnet { get => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).Subnet; set => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).Subnet = value; }

        /// <summary>resource tags.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public Wandisco.Fusion.Models.Api20190901Preview.IResourceTags Tags { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Tags; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Tags = value; }

        /// <summary>Azure resource type.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string Type { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Type; }

        /// <summary>Size of VM</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Support.VMSize? VMSize { get => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).VMSize; set => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).VMSize = value; }

        /// <summary>Resource ID of virtual network to attach the VMs to</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string VirtualNetworkId { get => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).VirtualNetworkId; set => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).VirtualNetworkId = value; }

        /// <summary>Internal Acessors for Nodes</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetails[] Wandisco.Fusion.Models.Api20190901Preview.IAzureZoneInternal.Nodes { get => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).Nodes; set => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).Nodes = value; }

        /// <summary>Internal Acessors for Properties</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IAzureZoneProperties Wandisco.Fusion.Models.Api20190901Preview.IAzureZoneInternal.Properties { get => (this._properties = this._properties ?? new Wandisco.Fusion.Models.Api20190901Preview.AzureZoneProperties()); set { {_properties = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Wandisco.Fusion.Support.ProvisioningState? Wandisco.Fusion.Models.Api20190901Preview.IAzureZoneInternal.ProvisioningState { get => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).ProvisioningState; set => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).ProvisioningState = value; }

        /// <summary>Internal Acessors for StorageManagedIdentity</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentity Wandisco.Fusion.Models.Api20190901Preview.IAzureZoneInternal.StorageManagedIdentity { get => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).StorageManagedIdentity; set => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal)Properties).StorageManagedIdentity = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal.Id { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Id; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal.Name { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Name; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal.Type { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Type; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Type = value; }

        /// <summary>Creates an new <see cref="AzureZone" /> instance.</summary>
        public AzureZone()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Wandisco.Fusion.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Wandisco.Fusion.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Azure Zone
    public partial interface IAzureZone :
        Wandisco.Fusion.Runtime.IJsonSerializable,
        Wandisco.Fusion.Models.Api20190901Preview.IResource
    {
        /// <summary>The number of nodes in the zone</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of nodes in the zone",
        SerializedName = @"nodeCount",
        PossibleTypes = new [] { typeof(int) })]
        int? NodeCount { get; set; }
        /// <summary>List of NodeDetails for each node in the zone</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of NodeDetails for each node in the zone",
        SerializedName = @"nodes",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetails) })]
        Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetails[] Nodes { get;  }
        /// <summary>Provisioning State of resource</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning State of resource",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Support.ProvisioningState) })]
        Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>Access Key for storage (use either key or identity)</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Access Key for storage (use either key or identity)",
        SerializedName = @"storageAccessKey",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccessKey { get; set; }
        /// <summary>Resource ID of ADLS Gen 2 account to replicate to</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Resource ID of ADLS Gen 2 account to replicate to",
        SerializedName = @"storageAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountId { get; set; }
        /// <summary>Container to replicate</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Container to replicate",
        SerializedName = @"storageContainer",
        PossibleTypes = new [] { typeof(string) })]
        string StorageContainer { get; set; }
        /// <summary>The type of identity used for the virtual machine.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity used for the virtual machine.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Support.ResourceIdentityType) })]
        Wandisco.Fusion.Support.ResourceIdentityType? StorageManagedIdentityType { get; set; }
        /// <summary>
        /// The list of user identities associated with the Virtual Machine. The user identity dictionary key references will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of user identities associated with the Virtual Machine. The user identity dictionary key references will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentityUserAssignedIdentities) })]
        Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentityUserAssignedIdentities StorageManagedIdentityUserAssignedIdentities { get; set; }
        /// <summary>Resource ID of Subnet to connect VMs to</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Resource ID of Subnet to connect VMs to",
        SerializedName = @"subnet",
        PossibleTypes = new [] { typeof(string) })]
        string Subnet { get; set; }
        /// <summary>Size of VM</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Size of VM",
        SerializedName = @"vmSize",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Support.VMSize) })]
        Wandisco.Fusion.Support.VMSize? VMSize { get; set; }
        /// <summary>Resource ID of virtual network to attach the VMs to</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Resource ID of virtual network to attach the VMs to",
        SerializedName = @"virtualNetworkId",
        PossibleTypes = new [] { typeof(string) })]
        string VirtualNetworkId { get; set; }

    }
    /// Azure Zone
    internal partial interface IAzureZoneInternal :
        Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal
    {
        /// <summary>The number of nodes in the zone</summary>
        int? NodeCount { get; set; }
        /// <summary>List of NodeDetails for each node in the zone</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetails[] Nodes { get; set; }
        /// <summary>azure zone resource properties</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IAzureZoneProperties Properties { get; set; }
        /// <summary>Provisioning State of resource</summary>
        Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Access Key for storage (use either key or identity)</summary>
        string StorageAccessKey { get; set; }
        /// <summary>Resource ID of ADLS Gen 2 account to replicate to</summary>
        string StorageAccountId { get; set; }
        /// <summary>Container to replicate</summary>
        string StorageContainer { get; set; }
        /// <summary>Managed identity of storage account (use either key or identity)</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentity StorageManagedIdentity { get; set; }
        /// <summary>The type of identity used for the virtual machine.</summary>
        Wandisco.Fusion.Support.ResourceIdentityType? StorageManagedIdentityType { get; set; }
        /// <summary>
        /// The list of user identities associated with the Virtual Machine. The user identity dictionary key references will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentityUserAssignedIdentities StorageManagedIdentityUserAssignedIdentities { get; set; }
        /// <summary>Resource ID of Subnet to connect VMs to</summary>
        string Subnet { get; set; }
        /// <summary>Size of VM</summary>
        Wandisco.Fusion.Support.VMSize? VMSize { get; set; }
        /// <summary>Resource ID of virtual network to attach the VMs to</summary>
        string VirtualNetworkId { get; set; }

    }
}