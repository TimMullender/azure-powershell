namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Managed OnPrem zone properties</summary>
    public partial class ManagedOnPremZoneProperties :
        Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneProperties,
        Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZonePropertiesInternal
    {

        /// <summary>Backing field for <see cref="DeploymentType" /> property.</summary>
        private Wandisco.Fusion.Support.ManagedOnPremDeploymentType _deploymentType;

        /// <summary>The deployment type of the Managed OnPrem zone</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Support.ManagedOnPremDeploymentType DeploymentType { get => this._deploymentType; set => this._deploymentType = value; }

        /// <summary>Backing field for <see cref="DownloadLocation" /> property.</summary>
        private string _downloadLocation;

        /// <summary>The location for downloading deployment files</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string DownloadLocation { get => this._downloadLocation; }

        /// <summary>Backing field for <see cref="ExternalIP" /> property.</summary>
        private string _externalIP;

        /// <summary>The external IP of the managed OnPrem fusion server</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string ExternalIP { get => this._externalIP; set => this._externalIP = value; }

        /// <summary>Backing field for <see cref="Nodes" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.INodeDetails[] _nodes;

        /// <summary>List of NodeDetails for each node in the zone</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Models.Api20190901Preview.INodeDetails[] Nodes { get => this._nodes; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Wandisco.Fusion.Support.ProvisioningState? _provisioningState;

        /// <summary>Provisioning State of resource</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Internal Acessors for DownloadLocation</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZonePropertiesInternal.DownloadLocation { get => this._downloadLocation; set { {_downloadLocation = value;} } }

        /// <summary>Internal Acessors for Nodes</summary>
        Wandisco.Fusion.Models.Api20190901Preview.INodeDetails[] Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZonePropertiesInternal.Nodes { get => this._nodes; set { {_nodes = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Wandisco.Fusion.Support.ProvisioningState? Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZonePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Creates an new <see cref="ManagedOnPremZoneProperties" /> instance.</summary>
        public ManagedOnPremZoneProperties()
        {

        }
    }
    /// Managed OnPrem zone properties
    public partial interface IManagedOnPremZoneProperties :
        Wandisco.Fusion.Runtime.IJsonSerializable
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
    /// Managed OnPrem zone properties
    internal partial interface IManagedOnPremZonePropertiesInternal

    {
        /// <summary>The deployment type of the Managed OnPrem zone</summary>
        Wandisco.Fusion.Support.ManagedOnPremDeploymentType DeploymentType { get; set; }
        /// <summary>The location for downloading deployment files</summary>
        string DownloadLocation { get; set; }
        /// <summary>The external IP of the managed OnPrem fusion server</summary>
        string ExternalIP { get; set; }
        /// <summary>List of NodeDetails for each node in the zone</summary>
        Wandisco.Fusion.Models.Api20190901Preview.INodeDetails[] Nodes { get; set; }
        /// <summary>Provisioning State of resource</summary>
        Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get; set; }

    }
}