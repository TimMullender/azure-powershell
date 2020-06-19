namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Details of the fusion server node.</summary>
    public partial class NodeDetailsFusion :
        Wandisco.Fusion.Models.Api20190901Preview.INodeDetailsFusion,
        Wandisco.Fusion.Models.Api20190901Preview.INodeDetailsFusionInternal
    {

        /// <summary>Backing field for <see cref="NodeName" /> property.</summary>
        private string _nodeName;

        /// <summary>The name of the Fusion node</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string NodeName { get => this._nodeName; set => this._nodeName = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Wandisco.Fusion.Support.NodeStatus? _status;

        /// <summary>The status of the node (Up/Down) or Unknown if the node is not responding</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Support.NodeStatus? Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="NodeDetailsFusion" /> instance.</summary>
        public NodeDetailsFusion()
        {

        }
    }
    /// Details of the fusion server node.
    public partial interface INodeDetailsFusion :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>The name of the Fusion node</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the Fusion node",
        SerializedName = @"nodeName",
        PossibleTypes = new [] { typeof(string) })]
        string NodeName { get; set; }
        /// <summary>The status of the node (Up/Down) or Unknown if the node is not responding</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The status of the node (Up/Down) or Unknown if the node is not responding",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Support.NodeStatus) })]
        Wandisco.Fusion.Support.NodeStatus? Status { get; set; }

    }
    /// Details of the fusion server node.
    internal partial interface INodeDetailsFusionInternal

    {
        /// <summary>The name of the Fusion node</summary>
        string NodeName { get; set; }
        /// <summary>The status of the node (Up/Down) or Unknown if the node is not responding</summary>
        Wandisco.Fusion.Support.NodeStatus? Status { get; set; }

    }
}