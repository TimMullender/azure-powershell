namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>REST API operation</summary>
    public partial class Operation :
        Wandisco.Fusion.Models.Api20190901Preview.IOperation,
        Wandisco.Fusion.Models.Api20190901Preview.IOperationInternal
    {

        /// <summary>Backing field for <see cref="Display" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IOperationDisplay _display;

        /// <summary>The object that represents the operation.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        internal Wandisco.Fusion.Models.Api20190901Preview.IOperationDisplay Display { get => (this._display = this._display ?? new Wandisco.Fusion.Models.Api20190901Preview.OperationDisplay()); set => this._display = value; }

        /// <summary>Operation type: Read, write, delete, etc.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string DisplayOperation { get => ((Wandisco.Fusion.Models.Api20190901Preview.IOperationDisplayInternal)Display).Operation; set => ((Wandisco.Fusion.Models.Api20190901Preview.IOperationDisplayInternal)Display).Operation = value; }

        /// <summary>Service provider: Microsoft.ResourceProvider</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string DisplayProvider { get => ((Wandisco.Fusion.Models.Api20190901Preview.IOperationDisplayInternal)Display).Provider; set => ((Wandisco.Fusion.Models.Api20190901Preview.IOperationDisplayInternal)Display).Provider = value; }

        /// <summary>Resource on which the operation is performed: Profile, endpoint, etc.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string DisplayResource { get => ((Wandisco.Fusion.Models.Api20190901Preview.IOperationDisplayInternal)Display).Resource; set => ((Wandisco.Fusion.Models.Api20190901Preview.IOperationDisplayInternal)Display).Resource = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Operation name: {provider}/{resource}/{operation}</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Internal Acessors for Display</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IOperationDisplay Wandisco.Fusion.Models.Api20190901Preview.IOperationInternal.Display { get => (this._display = this._display ?? new Wandisco.Fusion.Models.Api20190901Preview.OperationDisplay()); set { {_display = value;} } }

        /// <summary>Creates an new <see cref="Operation" /> instance.</summary>
        public Operation()
        {

        }
    }
    /// REST API operation
    public partial interface IOperation :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>Operation type: Read, write, delete, etc.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Operation type: Read, write, delete, etc.",
        SerializedName = @"operation",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayOperation { get; set; }
        /// <summary>Service provider: Microsoft.ResourceProvider</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Service provider: Microsoft.ResourceProvider",
        SerializedName = @"provider",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayProvider { get; set; }
        /// <summary>Resource on which the operation is performed: Profile, endpoint, etc.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource on which the operation is performed: Profile, endpoint, etc.",
        SerializedName = @"resource",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayResource { get; set; }
        /// <summary>Operation name: {provider}/{resource}/{operation}</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Operation name: {provider}/{resource}/{operation}",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// REST API operation
    internal partial interface IOperationInternal

    {
        /// <summary>The object that represents the operation.</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IOperationDisplay Display { get; set; }
        /// <summary>Operation type: Read, write, delete, etc.</summary>
        string DisplayOperation { get; set; }
        /// <summary>Service provider: Microsoft.ResourceProvider</summary>
        string DisplayProvider { get; set; }
        /// <summary>Resource on which the operation is performed: Profile, endpoint, etc.</summary>
        string DisplayResource { get; set; }
        /// <summary>Operation name: {provider}/{resource}/{operation}</summary>
        string Name { get; set; }

    }
}