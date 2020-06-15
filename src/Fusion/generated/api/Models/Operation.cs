// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6246, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;

    /// <summary>REST API operation</summary>
    public partial class Operation :
        Sample.API.Models.IOperation,
        Sample.API.Models.IOperationInternal
    {

        /// <summary>Backing field for <see cref="Display" /> property.</summary>
        private Sample.API.Models.IOperationDisplay _display;

        /// <summary>The object that represents the operation.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        internal Sample.API.Models.IOperationDisplay Display { get => (this._display = this._display ?? new Sample.API.Models.OperationDisplay()); set => this._display = value; }

        /// <summary>Operation type: Read, write, delete, etc.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public string DisplayOperation { get => ((Sample.API.Models.IOperationDisplayInternal)Display).Operation; set => ((Sample.API.Models.IOperationDisplayInternal)Display).Operation = value; }

        /// <summary>Service provider: Microsoft.ResourceProvider</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public string DisplayProvider { get => ((Sample.API.Models.IOperationDisplayInternal)Display).Provider; set => ((Sample.API.Models.IOperationDisplayInternal)Display).Provider = value; }

        /// <summary>Resource on which the operation is performed: Profile, endpoint, etc.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public string DisplayResource { get => ((Sample.API.Models.IOperationDisplayInternal)Display).Resource; set => ((Sample.API.Models.IOperationDisplayInternal)Display).Resource = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Operation name: {provider}/{resource}/{operation}</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Internal Acessors for Display</summary>
        Sample.API.Models.IOperationDisplay Sample.API.Models.IOperationInternal.Display { get => (this._display = this._display ?? new Sample.API.Models.OperationDisplay()); set { {_display = value;} } }

        /// <summary>Creates an new <see cref="Operation" /> instance.</summary>
        public Operation()
        {

        }
    }
    /// REST API operation
    public partial interface IOperation :
        Sample.API.Runtime.IJsonSerializable
    {
        /// <summary>Operation type: Read, write, delete, etc.</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Operation type: Read, write, delete, etc.",
        SerializedName = @"operation",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayOperation { get; set; }
        /// <summary>Service provider: Microsoft.ResourceProvider</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Service provider: Microsoft.ResourceProvider",
        SerializedName = @"provider",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayProvider { get; set; }
        /// <summary>Resource on which the operation is performed: Profile, endpoint, etc.</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource on which the operation is performed: Profile, endpoint, etc.",
        SerializedName = @"resource",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayResource { get; set; }
        /// <summary>Operation name: {provider}/{resource}/{operation}</summary>
        [Sample.API.Runtime.Info(
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
        Sample.API.Models.IOperationDisplay Display { get; set; }
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