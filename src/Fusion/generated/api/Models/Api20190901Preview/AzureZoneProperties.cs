namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>azure zone properties</summary>
    public partial class AzureZoneProperties :
        Wandisco.Fusion.Models.Api20190901Preview.IAzureZoneProperties,
        Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal
    {

        /// <summary>Backing field for <see cref="NodeCount" /> property.</summary>
        private int? _nodeCount;

        /// <summary>The number of nodes in the zone</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public int? NodeCount { get => this._nodeCount; set => this._nodeCount = value; }

        /// <summary>Backing field for <see cref="Nodes" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetails[] _nodes;

        /// <summary>List of NodeDetails for each node in the zone</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetails[] Nodes { get => this._nodes; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Wandisco.Fusion.Support.ProvisioningState? _provisioningState;

        /// <summary>Provisioning State of resource</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="StorageAccessKey" /> property.</summary>
        private string _storageAccessKey;

        /// <summary>Access Key for storage (use either key or identity)</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string StorageAccessKey { get => this._storageAccessKey; set => this._storageAccessKey = value; }

        /// <summary>Backing field for <see cref="StorageAccountId" /> property.</summary>
        private string _storageAccountId;

        /// <summary>Resource ID of ADLS Gen 2 account to replicate to</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string StorageAccountId { get => this._storageAccountId; set => this._storageAccountId = value; }

        /// <summary>Backing field for <see cref="StorageContainer" /> property.</summary>
        private string _storageContainer;

        /// <summary>Container to replicate</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string StorageContainer { get => this._storageContainer; set => this._storageContainer = value; }

        /// <summary>Backing field for <see cref="StorageManagedIdentity" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentity _storageManagedIdentity;

        /// <summary>Managed identity of storage account (use either key or identity)</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        internal Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentity StorageManagedIdentity { get => (this._storageManagedIdentity = this._storageManagedIdentity ?? new Wandisco.Fusion.Models.Api20190901Preview.VirtualMachineIdentity()); set => this._storageManagedIdentity = value; }

        /// <summary>The type of identity used for the virtual machine.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Support.ResourceIdentityType? StorageManagedIdentityType { get => ((Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentityInternal)StorageManagedIdentity).Type; set => ((Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentityInternal)StorageManagedIdentity).Type = value; }

        /// <summary>
        /// The list of user identities associated with the Virtual Machine. The user identity dictionary key references will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentityUserAssignedIdentities StorageManagedIdentityUserAssignedIdentities { get => ((Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentityInternal)StorageManagedIdentity).UserAssignedIdentities; set => ((Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentityInternal)StorageManagedIdentity).UserAssignedIdentities = value; }

        /// <summary>Backing field for <see cref="Subnet" /> property.</summary>
        private string _subnet;

        /// <summary>Resource ID of Subnet to connect VMs to</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Subnet { get => this._subnet; set => this._subnet = value; }

        /// <summary>Backing field for <see cref="VMSize" /> property.</summary>
        private Wandisco.Fusion.Support.VMSize? _vMSize;

        /// <summary>Size of VM</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Support.VMSize? VMSize { get => this._vMSize; set => this._vMSize = value; }

        /// <summary>Backing field for <see cref="VirtualNetworkId" /> property.</summary>
        private string _virtualNetworkId;

        /// <summary>Resource ID of virtual network to attach the VMs to</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string VirtualNetworkId { get => this._virtualNetworkId; set => this._virtualNetworkId = value; }

        /// <summary>Internal Acessors for Nodes</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetails[] Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal.Nodes { get => this._nodes; set { {_nodes = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Wandisco.Fusion.Support.ProvisioningState? Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for StorageManagedIdentity</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentity Wandisco.Fusion.Models.Api20190901Preview.IAzureZonePropertiesInternal.StorageManagedIdentity { get => (this._storageManagedIdentity = this._storageManagedIdentity ?? new Wandisco.Fusion.Models.Api20190901Preview.VirtualMachineIdentity()); set { {_storageManagedIdentity = value;} } }

        /// <summary>Creates an new <see cref="AzureZoneProperties" /> instance.</summary>
        public AzureZoneProperties()
        {

        }
    }
    /// azure zone properties
    public partial interface IAzureZoneProperties :
        Wandisco.Fusion.Runtime.IJsonSerializable
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
    /// azure zone properties
    internal partial interface IAzureZonePropertiesInternal

    {
        /// <summary>The number of nodes in the zone</summary>
        int? NodeCount { get; set; }
        /// <summary>List of NodeDetails for each node in the zone</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetails[] Nodes { get; set; }
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