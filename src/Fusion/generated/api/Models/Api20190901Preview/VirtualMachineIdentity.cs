namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Identity for the virtual machine.</summary>
    public partial class VirtualMachineIdentity :
        Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentity,
        Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentityInternal
    {

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Wandisco.Fusion.Support.ResourceIdentityType? _type;

        /// <summary>The type of identity used for the virtual machine.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Support.ResourceIdentityType? Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="UserAssignedIdentities" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentityUserAssignedIdentities _userAssignedIdentities;

        /// <summary>
        /// The list of user identities associated with the Virtual Machine. The user identity dictionary key references will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentityUserAssignedIdentities UserAssignedIdentities { get => (this._userAssignedIdentities = this._userAssignedIdentities ?? new Wandisco.Fusion.Models.Api20190901Preview.VirtualMachineIdentityUserAssignedIdentities()); set => this._userAssignedIdentities = value; }

        /// <summary>Creates an new <see cref="VirtualMachineIdentity" /> instance.</summary>
        public VirtualMachineIdentity()
        {

        }
    }
    /// Identity for the virtual machine.
    public partial interface IVirtualMachineIdentity :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>The type of identity used for the virtual machine.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity used for the virtual machine.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Support.ResourceIdentityType) })]
        Wandisco.Fusion.Support.ResourceIdentityType? Type { get; set; }
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
        Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentityUserAssignedIdentities UserAssignedIdentities { get; set; }

    }
    /// Identity for the virtual machine.
    internal partial interface IVirtualMachineIdentityInternal

    {
        /// <summary>The type of identity used for the virtual machine.</summary>
        Wandisco.Fusion.Support.ResourceIdentityType? Type { get; set; }
        /// <summary>
        /// The list of user identities associated with the Virtual Machine. The user identity dictionary key references will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentityUserAssignedIdentities UserAssignedIdentities { get; set; }

    }
}