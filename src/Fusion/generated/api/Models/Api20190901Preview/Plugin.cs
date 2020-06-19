namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Plugin AzureZone subresource</summary>
    public partial class Plugin :
        Wandisco.Fusion.Models.Api20190901Preview.IPlugin,
        Wandisco.Fusion.Models.Api20190901Preview.IPluginInternal,
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

        /// <summary>The kind of Plugin.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Support.PluginKind PluginKind { get => ((Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal)Properties).PluginKind; set => ((Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal)Properties).PluginKind = value; }

        /// <summary>Backing field for <see cref="Properties" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentation _properties;

        /// <summary>Plugin Representation</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        internal Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentation Properties { get => (this._properties = this._properties ?? new Wandisco.Fusion.Models.Api20190901Preview.PluginRepresentation()); set => this._properties = value; }

        /// <summary>Provisioning State of resource</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get => ((Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal)Properties).ProvisioningState; }

        /// <summary>resource tags.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public Wandisco.Fusion.Models.Api20190901Preview.IResourceTags Tags { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Tags; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Tags = value; }

        /// <summary>Azure resource type.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string Type { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Type; }

        /// <summary>Internal Acessors for Properties</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentation Wandisco.Fusion.Models.Api20190901Preview.IPluginInternal.Properties { get => (this._properties = this._properties ?? new Wandisco.Fusion.Models.Api20190901Preview.PluginRepresentation()); set { {_properties = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Wandisco.Fusion.Support.ProvisioningState? Wandisco.Fusion.Models.Api20190901Preview.IPluginInternal.ProvisioningState { get => ((Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal)Properties).ProvisioningState; set => ((Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentationInternal)Properties).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal.Id { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Id; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal.Name { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Name; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal.Type { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Type; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Type = value; }

        /// <summary>Creates an new <see cref="Plugin" /> instance.</summary>
        public Plugin()
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
    /// Plugin AzureZone subresource
    public partial interface IPlugin :
        Wandisco.Fusion.Runtime.IJsonSerializable,
        Wandisco.Fusion.Models.Api20190901Preview.IResource
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
    /// Plugin AzureZone subresource
    internal partial interface IPluginInternal :
        Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal
    {
        /// <summary>The kind of Plugin.</summary>
        Wandisco.Fusion.Support.PluginKind PluginKind { get; set; }
        /// <summary>Plugin Representation</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IPluginRepresentation Properties { get; set; }
        /// <summary>Provisioning State of resource</summary>
        Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get; set; }

    }
}