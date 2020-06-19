namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Managed OnPrem Zone</summary>
    public partial class ManagedOnPremZone :
        Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZone,
        Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal,
        Wandisco.Fusion.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Wandisco.Fusion.Models.Api20190901Preview.IResource" />
        /// </summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IResource __resource = new Wandisco.Fusion.Models.Api20190901Preview.Resource();

        /// <summary>The deployment type of the Managed OnPrem zone</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Support.ManagedOnPremDeploymentType DeploymentType { get => ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZonePropertiesInternal)Properties).DeploymentType; set => ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZonePropertiesInternal)Properties).DeploymentType = value; }

        /// <summary>The location for downloading deployment files</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string DownloadLocation { get => ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZonePropertiesInternal)Properties).DownloadLocation; }

        /// <summary>The external IP of the managed OnPrem fusion server</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string ExternalIP { get => ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZonePropertiesInternal)Properties).ExternalIP; set => ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZonePropertiesInternal)Properties).ExternalIP = value; }

        /// <summary>Azure resource Id.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string Id { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Id; }

        /// <summary>Location of the resource.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string Location { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Location; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Location = value; }

        /// <summary>Azure resource name.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string Name { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Name; }

        /// <summary>List of NodeDetails for each node in the zone</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Models.Api20190901Preview.INodeDetails[] Nodes { get => ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZonePropertiesInternal)Properties).Nodes; }

        /// <summary>Backing field for <see cref="Properties" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneProperties _properties;

        /// <summary>Managed OnPrem zone resource properties</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        internal Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneProperties Properties { get => (this._properties = this._properties ?? new Wandisco.Fusion.Models.Api20190901Preview.ManagedOnPremZoneProperties()); set => this._properties = value; }

        /// <summary>Provisioning State of resource</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get => ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZonePropertiesInternal)Properties).ProvisioningState; }

        /// <summary>resource tags.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public Wandisco.Fusion.Models.Api20190901Preview.IResourceTags Tags { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Tags; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Tags = value; }

        /// <summary>Azure resource type.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string Type { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Type; }

        /// <summary>Internal Acessors for DownloadLocation</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal.DownloadLocation { get => ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZonePropertiesInternal)Properties).DownloadLocation; set => ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZonePropertiesInternal)Properties).DownloadLocation = value; }

        /// <summary>Internal Acessors for Nodes</summary>
        Wandisco.Fusion.Models.Api20190901Preview.INodeDetails[] Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal.Nodes { get => ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZonePropertiesInternal)Properties).Nodes; set => ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZonePropertiesInternal)Properties).Nodes = value; }

        /// <summary>Internal Acessors for Properties</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneProperties Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal.Properties { get => (this._properties = this._properties ?? new Wandisco.Fusion.Models.Api20190901Preview.ManagedOnPremZoneProperties()); set { {_properties = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Wandisco.Fusion.Support.ProvisioningState? Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneInternal.ProvisioningState { get => ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZonePropertiesInternal)Properties).ProvisioningState; set => ((Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZonePropertiesInternal)Properties).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal.Id { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Id; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal.Name { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Name; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal.Type { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Type; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Type = value; }

        /// <summary>Creates an new <see cref="ManagedOnPremZone" /> instance.</summary>
        public ManagedOnPremZone()
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
    /// Managed OnPrem Zone
    public partial interface IManagedOnPremZone :
        Wandisco.Fusion.Runtime.IJsonSerializable,
        Wandisco.Fusion.Models.Api20190901Preview.IResource
    {
        /// <summary>The deployment type of the Managed OnPrem zone</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The deployment type of the Managed OnPrem zone",
        SerializedName = @"deploymentType",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Support.ManagedOnPremDeploymentType) })]
        Wandisco.Fusion.Support.ManagedOnPremDeploymentType DeploymentType { get; set; }
        /// <summary>The location for downloading deployment files</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The location for downloading deployment files",
        SerializedName = @"downloadLocation",
        PossibleTypes = new [] { typeof(string) })]
        string DownloadLocation { get;  }
        /// <summary>The external IP of the managed OnPrem fusion server</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The external IP of the managed OnPrem fusion server",
        SerializedName = @"externalIp",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalIP { get; set; }
        /// <summary>List of NodeDetails for each node in the zone</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of NodeDetails for each node in the zone",
        SerializedName = @"nodes",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Models.Api20190901Preview.INodeDetails) })]
        Wandisco.Fusion.Models.Api20190901Preview.INodeDetails[] Nodes { get;  }
        /// <summary>Provisioning State of resource</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning State of resource",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Support.ProvisioningState) })]
        Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get;  }

    }
    /// Managed OnPrem Zone
    internal partial interface IManagedOnPremZoneInternal :
        Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal
    {
        /// <summary>The deployment type of the Managed OnPrem zone</summary>
        Wandisco.Fusion.Support.ManagedOnPremDeploymentType DeploymentType { get; set; }
        /// <summary>The location for downloading deployment files</summary>
        string DownloadLocation { get; set; }
        /// <summary>The external IP of the managed OnPrem fusion server</summary>
        string ExternalIP { get; set; }
        /// <summary>List of NodeDetails for each node in the zone</summary>
        Wandisco.Fusion.Models.Api20190901Preview.INodeDetails[] Nodes { get; set; }
        /// <summary>Managed OnPrem zone resource properties</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneProperties Properties { get; set; }
        /// <summary>Provisioning State of resource</summary>
        Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get; set; }

    }
}