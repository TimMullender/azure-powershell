namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Details of a node in the zone</summary>
    public partial class NodeDetails :
        Wandisco.Fusion.Models.Api20190901Preview.INodeDetails,
        Wandisco.Fusion.Models.Api20190901Preview.INodeDetailsInternal
    {

        /// <summary>Backing field for <see cref="Fusion" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.INodeDetailsFusion _fusion;

        /// <summary>Details of the fusion server node.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        internal Wandisco.Fusion.Models.Api20190901Preview.INodeDetailsFusion Fusion { get => (this._fusion = this._fusion ?? new Wandisco.Fusion.Models.Api20190901Preview.NodeDetailsFusion()); set => this._fusion = value; }

        /// <summary>The name of the Fusion node</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string FusionNodeName { get => ((Wandisco.Fusion.Models.Api20190901Preview.INodeDetailsFusionInternal)Fusion).NodeName; set => ((Wandisco.Fusion.Models.Api20190901Preview.INodeDetailsFusionInternal)Fusion).NodeName = value; }

        /// <summary>The status of the node (Up/Down) or Unknown if the node is not responding</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Support.NodeStatus? FusionStatus { get => ((Wandisco.Fusion.Models.Api20190901Preview.INodeDetailsFusionInternal)Fusion).Status; set => ((Wandisco.Fusion.Models.Api20190901Preview.INodeDetailsFusionInternal)Fusion).Status = value; }

        /// <summary>Internal Acessors for Fusion</summary>
        Wandisco.Fusion.Models.Api20190901Preview.INodeDetailsFusion Wandisco.Fusion.Models.Api20190901Preview.INodeDetailsInternal.Fusion { get => (this._fusion = this._fusion ?? new Wandisco.Fusion.Models.Api20190901Preview.NodeDetailsFusion()); set { {_fusion = value;} } }

        /// <summary>Creates an new <see cref="NodeDetails" /> instance.</summary>
        public NodeDetails()
        {

        }
    }
    /// Details of a node in the zone
    public partial interface INodeDetails :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>The name of the Fusion node</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the Fusion node",
        SerializedName = @"nodeName",
        PossibleTypes = new [] { typeof(string) })]
        string FusionNodeName { get; set; }
        /// <summary>The status of the node (Up/Down) or Unknown if the node is not responding</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The status of the node (Up/Down) or Unknown if the node is not responding",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Support.NodeStatus) })]
        Wandisco.Fusion.Support.NodeStatus? FusionStatus { get; set; }

    }
    /// Details of a node in the zone
    internal partial interface INodeDetailsInternal

    {
        /// <summary>Details of the fusion server node.</summary>
        Wandisco.Fusion.Models.Api20190901Preview.INodeDetailsFusion Fusion { get; set; }
        /// <summary>The name of the Fusion node</summary>
        string FusionNodeName { get; set; }
        /// <summary>The status of the node (Up/Down) or Unknown if the node is not responding</summary>
        Wandisco.Fusion.Support.NodeStatus? FusionStatus { get; set; }

    }
}