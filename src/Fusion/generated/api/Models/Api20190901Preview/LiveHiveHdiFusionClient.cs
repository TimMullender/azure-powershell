namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Live Hive Attachment to HDI Cluster</summary>
    public partial class LiveHiveHdiFusionClient :
        Wandisco.Fusion.Models.Api20190901Preview.ILiveHiveHdiFusionClient,
        Wandisco.Fusion.Models.Api20190901Preview.ILiveHiveHdiFusionClientInternal,
        Wandisco.Fusion.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentation" />
        /// </summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentation __pluginRepresentation = new Wandisco.Fusion.Models.Api20190901Preview.PluginRepresentation();

        /// <summary>The kind of Plugin.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public Wandisco.Fusion.Support.PluginKind PluginKind { get => ((Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal)__pluginRepresentation).PluginKind; set => ((Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal)__pluginRepresentation).PluginKind = value; }

        /// <summary>Provisioning State of resource</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get => ((Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal)__pluginRepresentation).ProvisioningState; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Wandisco.Fusion.Support.ProvisioningState? Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal.ProvisioningState { get => ((Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal)__pluginRepresentation).ProvisioningState; set => ((Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal)__pluginRepresentation).ProvisioningState = value; }

        /// <summary>Creates an new <see cref="LiveHiveHdiFusionClient" /> instance.</summary>
        public LiveHiveHdiFusionClient()
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
            await eventListener.AssertNotNull(nameof(__pluginRepresentation), __pluginRepresentation);
            await eventListener.AssertObjectIsValid(nameof(__pluginRepresentation), __pluginRepresentation);
        }
    }
    /// Live Hive Attachment to HDI Cluster
    public partial interface ILiveHiveHdiFusionClient :
        Wandisco.Fusion.Runtime.IJsonSerializable,
        Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentation
    {

    }
    /// Live Hive Attachment to HDI Cluster
    internal partial interface ILiveHiveHdiFusionClientInternal :
        Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal
    {

    }
}