// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6246, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;

    /// <summary>Details of a node in the zone</summary>
    public partial class NodeDetails :
        Sample.API.Models.INodeDetails,
        Sample.API.Models.INodeDetailsInternal
    {

        /// <summary>Backing field for <see cref="Fusion" /> property.</summary>
        private Sample.API.Models.INodeDetailsFusion _fusion;

        /// <summary>Details of the fusion server node.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        internal Sample.API.Models.INodeDetailsFusion Fusion { get => (this._fusion = this._fusion ?? new Sample.API.Models.NodeDetailsFusion()); set => this._fusion = value; }

        /// <summary>The name of the Fusion node</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public string FusionNodeName { get => ((Sample.API.Models.INodeDetailsFusionInternal)Fusion).NodeName; set => ((Sample.API.Models.INodeDetailsFusionInternal)Fusion).NodeName = value; }

        /// <summary>The status of the node (Up/Down) or Unknown if the node is not responding</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public Sample.API.Support.NodeStatus? FusionStatus { get => ((Sample.API.Models.INodeDetailsFusionInternal)Fusion).Status; set => ((Sample.API.Models.INodeDetailsFusionInternal)Fusion).Status = value; }

        /// <summary>Internal Acessors for Fusion</summary>
        Sample.API.Models.INodeDetailsFusion Sample.API.Models.INodeDetailsInternal.Fusion { get => (this._fusion = this._fusion ?? new Sample.API.Models.NodeDetailsFusion()); set { {_fusion = value;} } }

        /// <summary>Creates an new <see cref="NodeDetails" /> instance.</summary>
        public NodeDetails()
        {

        }
    }
    /// Details of a node in the zone
    public partial interface INodeDetails :
        Sample.API.Runtime.IJsonSerializable
    {
        /// <summary>The name of the Fusion node</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the Fusion node",
        SerializedName = @"nodeName",
        PossibleTypes = new [] { typeof(string) })]
        string FusionNodeName { get; set; }
        /// <summary>The status of the node (Up/Down) or Unknown if the node is not responding</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The status of the node (Up/Down) or Unknown if the node is not responding",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Sample.API.Support.NodeStatus) })]
        Sample.API.Support.NodeStatus? FusionStatus { get; set; }

    }
    /// Details of a node in the zone
    internal partial interface INodeDetailsInternal

    {
        /// <summary>Details of the fusion server node.</summary>
        Sample.API.Models.INodeDetailsFusion Fusion { get; set; }
        /// <summary>The name of the Fusion node</summary>
        string FusionNodeName { get; set; }
        /// <summary>The status of the node (Up/Down) or Unknown if the node is not responding</summary>
        Sample.API.Support.NodeStatus? FusionStatus { get; set; }

    }
}