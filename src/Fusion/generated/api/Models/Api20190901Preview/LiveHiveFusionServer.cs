namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Live Hive Proxy and Fusion Server Plugin</summary>
    public partial class LiveHiveFusionServer :
        Wandisco.Fusion.Models.Api20190901Preview.ILiveHiveFusionServer,
        Wandisco.Fusion.Models.Api20190901Preview.ILiveHiveFusionServerInternal,
        Wandisco.Fusion.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentation" />
        /// </summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentation __pluginRepresentation = new Wandisco.Fusion.Models.Api20190901Preview.PluginRepresentation();

        /// <summary>Backing field for <see cref="HiveMetastore" /> property.</summary>
        private string _hiveMetastore;

        /// <summary>Underlying Hive Metastore location</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string HiveMetastore { get => this._hiveMetastore; set => this._hiveMetastore = value; }

        /// <summary>The kind of Plugin.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public Wandisco.Fusion.Support.PluginKind PluginKind { get => ((Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal)__pluginRepresentation).PluginKind; set => ((Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal)__pluginRepresentation).PluginKind = value; }

        /// <summary>Provisioning State of resource</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get => ((Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal)__pluginRepresentation).ProvisioningState; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Wandisco.Fusion.Support.ProvisioningState? Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal.ProvisioningState { get => ((Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal)__pluginRepresentation).ProvisioningState; set => ((Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal)__pluginRepresentation).ProvisioningState = value; }

        /// <summary>Creates an new <see cref="LiveHiveFusionServer" /> instance.</summary>
        public LiveHiveFusionServer()
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
    /// Live Hive Proxy and Fusion Server Plugin
    public partial interface ILiveHiveFusionServer :
        Wandisco.Fusion.Runtime.IJsonSerializable,
        Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentation
    {
        /// <summary>Underlying Hive Metastore location</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Underlying Hive Metastore location",
        SerializedName = @"hiveMetastore",
        PossibleTypes = new [] { typeof(string) })]
        string HiveMetastore { get; set; }

    }
    /// Live Hive Proxy and Fusion Server Plugin
    internal partial interface ILiveHiveFusionServerInternal :
        Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal
    {
        /// <summary>Underlying Hive Metastore location</summary>
        string HiveMetastore { get; set; }

    }
}