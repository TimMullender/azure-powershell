namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Details of a node in an azure zone</summary>
    public partial class AzureNodeDetails :
        Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetails,
        Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetailsInternal,
        Wandisco.Fusion.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Wandisco.Fusion.Models.Api20190901Preview.INodeDetails" />
        /// </summary>
        private Wandisco.Fusion.Models.Api20190901Preview.INodeDetails __nodeDetails = new Wandisco.Fusion.Models.Api20190901Preview.NodeDetails();

        /// <summary>Details of the fusion server node.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public Wandisco.Fusion.Models.Api20190901Preview.INodeDetailsFusion Fusion { get => ((Wandisco.Fusion.Models.Api20190901Preview.INodeDetailsInternal)__nodeDetails).Fusion; set => ((Wandisco.Fusion.Models.Api20190901Preview.INodeDetailsInternal)__nodeDetails).Fusion = value; }

        /// <summary>The name of the Fusion node</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string FusionNodeName { get => ((Wandisco.Fusion.Models.Api20190901Preview.INodeDetailsInternal)__nodeDetails).FusionNodeName; set => ((Wandisco.Fusion.Models.Api20190901Preview.INodeDetailsInternal)__nodeDetails).FusionNodeName = value; }

        /// <summary>The status of the node (Up/Down) or Unknown if the node is not responding</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public Wandisco.Fusion.Support.NodeStatus? FusionStatus { get => ((Wandisco.Fusion.Models.Api20190901Preview.INodeDetailsInternal)__nodeDetails).FusionStatus; set => ((Wandisco.Fusion.Models.Api20190901Preview.INodeDetailsInternal)__nodeDetails).FusionStatus = value; }

        /// <summary>Backing field for <see cref="VM" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetailsVM _vM;

        /// <summary>The VirtualMachine resource associated with this node</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        internal Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetailsVM VM { get => (this._vM = this._vM ?? new Wandisco.Fusion.Models.Api20190901Preview.AzureNodeDetailsVM()); set => this._vM = value; }

        /// <summary>VM Resource Id</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string VMId { get => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetailsVMInternal)VM).Id; }

        /// <summary>Internal Acessors for VM</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetailsVM Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetailsInternal.VM { get => (this._vM = this._vM ?? new Wandisco.Fusion.Models.Api20190901Preview.AzureNodeDetailsVM()); set { {_vM = value;} } }

        /// <summary>Internal Acessors for VMId</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetailsInternal.VMId { get => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetailsVMInternal)VM).Id; set => ((Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetailsVMInternal)VM).Id = value; }

        /// <summary>Creates an new <see cref="AzureNodeDetails" /> instance.</summary>
        public AzureNodeDetails()
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
            await eventListener.AssertNotNull(nameof(__nodeDetails), __nodeDetails);
            await eventListener.AssertObjectIsValid(nameof(__nodeDetails), __nodeDetails);
        }
    }
    /// Details of a node in an azure zone
    public partial interface IAzureNodeDetails :
        Wandisco.Fusion.Runtime.IJsonSerializable,
        Wandisco.Fusion.Models.Api20190901Preview.INodeDetails
    {
        /// <summary>VM Resource Id</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"VM Resource Id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string VMId { get;  }

    }
    /// Details of a node in an azure zone
    internal partial interface IAzureNodeDetailsInternal :
        Wandisco.Fusion.Models.Api20190901Preview.INodeDetailsInternal
    {
        /// <summary>The VirtualMachine resource associated with this node</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetailsVM VM { get; set; }
        /// <summary>VM Resource Id</summary>
        string VMId { get; set; }

    }
}