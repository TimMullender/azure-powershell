namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>
    /// The list of user identities associated with the Virtual Machine. The user identity dictionary key references will be ARM
    /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    /// </summary>
    public partial class VirtualMachineIdentityUserAssignedIdentities :
        Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentityUserAssignedIdentities,
        Wandisco.Fusion.Models.Api20190901Preview.IVirtualMachineIdentityUserAssignedIdentitiesInternal
    {

        /// <summary>
        /// Creates an new <see cref="VirtualMachineIdentityUserAssignedIdentities" /> instance.
        /// </summary>
        public VirtualMachineIdentityUserAssignedIdentities()
        {

        }
    }
    /// The list of user identities associated with the Virtual Machine. The user identity dictionary key references will be ARM
    /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    public partial interface IVirtualMachineIdentityUserAssignedIdentities :
        Wandisco.Fusion.Runtime.IJsonSerializable,
        Wandisco.Fusion.Runtime.IAssociativeArray<Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties>
    {

    }
    /// The list of user identities associated with the Virtual Machine. The user identity dictionary key references will be ARM
    /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    internal partial interface IVirtualMachineIdentityUserAssignedIdentitiesInternal

    {

    }
}