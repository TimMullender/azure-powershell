// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6246, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;

    /// <summary>HDI Fusion Client</summary>
    public partial class HdiFusionClient :
        Sample.API.Models.IHdiFusionClient,
        Sample.API.Models.IHdiFusionClientInternal,
        Sample.API.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Sample.API.Models.IPluginRepresentation" />
        /// </summary>
        private Sample.API.Models.IPluginRepresentation __pluginRepresentation = new Sample.API.Models.PluginRepresentation();

        /// <summary>Backing field for <see cref="HdiClusterId" /> property.</summary>
        private string _hdiClusterId;

        /// <summary>HDI Cluster resource ID</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        public string HdiClusterId { get => this._hdiClusterId; set => this._hdiClusterId = value; }

        /// <summary>The kind of Plugin.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inherited)]
        public Sample.API.Support.PluginKind PluginKind { get => ((Sample.API.Models.IPluginRepresentationInternal)__pluginRepresentation).PluginKind; set => ((Sample.API.Models.IPluginRepresentationInternal)__pluginRepresentation).PluginKind = value; }

        /// <summary>Provisioning State of resource</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inherited)]
        public Sample.API.Support.ProvisioningState? ProvisioningState { get => ((Sample.API.Models.IPluginRepresentationInternal)__pluginRepresentation).ProvisioningState; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Sample.API.Support.ProvisioningState? Sample.API.Models.IPluginRepresentationInternal.ProvisioningState { get => ((Sample.API.Models.IPluginRepresentationInternal)__pluginRepresentation).ProvisioningState; set => ((Sample.API.Models.IPluginRepresentationInternal)__pluginRepresentation).ProvisioningState = value; }

        /// <summary>Creates an new <see cref="HdiFusionClient" /> instance.</summary>
        public HdiFusionClient()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Sample.API.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Sample.API.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__pluginRepresentation), __pluginRepresentation);
            await eventListener.AssertObjectIsValid(nameof(__pluginRepresentation), __pluginRepresentation);
        }
    }
    /// HDI Fusion Client
    public partial interface IHdiFusionClient :
        Sample.API.Runtime.IJsonSerializable,
        Sample.API.Models.IPluginRepresentation
    {
        /// <summary>HDI Cluster resource ID</summary>
        [Sample.API.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"HDI Cluster resource ID",
        SerializedName = @"hdiClusterId",
        PossibleTypes = new [] { typeof(string) })]
        string HdiClusterId { get; set; }

    }
    /// HDI Fusion Client
    internal partial interface IHdiFusionClientInternal :
        Sample.API.Models.IPluginRepresentationInternal
    {
        /// <summary>HDI Cluster resource ID</summary>
        string HdiClusterId { get; set; }

    }
}