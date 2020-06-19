namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Plugin Representation</summary>
    public partial class PluginRepresentation :
        Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentation,
        Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal
    {

        /// <summary>Backing field for <see cref="PluginKind" /> property.</summary>
        private Wandisco.Fusion.Support.PluginKind _pluginKind;

        /// <summary>The kind of Plugin.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Support.PluginKind PluginKind { get => this._pluginKind; set => this._pluginKind = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Wandisco.Fusion.Support.ProvisioningState? _provisioningState;

        /// <summary>Provisioning State of resource</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Wandisco.Fusion.Support.ProvisioningState? Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Creates an new <see cref="PluginRepresentation" /> instance.</summary>
        public PluginRepresentation()
        {

        }
    }
    /// Plugin Representation
    public partial interface IPluginRepresentation :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>The kind of Plugin.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The kind of Plugin.",
        SerializedName = @"pluginKind",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Support.PluginKind) })]
        Wandisco.Fusion.Support.PluginKind PluginKind { get; set; }
        /// <summary>Provisioning State of resource</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning State of resource",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Support.ProvisioningState) })]
        Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get;  }

    }
    /// Plugin Representation
    internal partial interface IPluginRepresentationInternal

    {
        /// <summary>The kind of Plugin.</summary>
        Wandisco.Fusion.Support.PluginKind PluginKind { get; set; }
        /// <summary>Provisioning State of resource</summary>
        Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get; set; }

    }
}