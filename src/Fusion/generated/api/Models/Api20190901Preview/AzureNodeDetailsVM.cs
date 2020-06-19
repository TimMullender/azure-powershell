namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>The VirtualMachine resource associated with this node</summary>
    public partial class AzureNodeDetailsVM :
        Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetailsVM,
        Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetailsVMInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>VM Resource Id</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for Id</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetailsVMInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Creates an new <see cref="AzureNodeDetailsVM" /> instance.</summary>
        public AzureNodeDetailsVM()
        {

        }
    }
    /// The VirtualMachine resource associated with this node
    public partial interface IAzureNodeDetailsVM :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>VM Resource Id</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"VM Resource Id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }

    }
    /// The VirtualMachine resource associated with this node
    internal partial interface IAzureNodeDetailsVMInternal

    {
        /// <summary>VM Resource Id</summary>
        string Id { get; set; }

    }
}