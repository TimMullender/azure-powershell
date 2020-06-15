// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6246, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;

    /// <summary>operation status object</summary>
    public partial class OperationStatus :
        Sample.API.Models.IOperationStatus,
        Sample.API.Models.IOperationStatusInternal
    {

        /// <summary>
        /// An invariant error code used for error troubleshooting, aggregation, and analysis.
        /// </summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public string Code { get => ((Sample.API.Models.IOperationStatusErrorInternal)Error).Code; set => ((Sample.API.Models.IOperationStatusErrorInternal)Error).Code = value; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Sample.API.Models.IOperationStatusError _error;

        /// <summary>Hdi cluster with Fusion client installed</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        internal Sample.API.Models.IOperationStatusError Error { get => (this._error = this._error ?? new Sample.API.Models.OperationStatusError()); set => this._error = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Operation Id</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>An actionable error message indicating what error occurred.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public string Message { get => ((Sample.API.Models.IOperationStatusErrorInternal)Error).Message; set => ((Sample.API.Models.IOperationStatusErrorInternal)Error).Message = value; }

        /// <summary>Internal Acessors for Error</summary>
        Sample.API.Models.IOperationStatusError Sample.API.Models.IOperationStatusInternal.Error { get => (this._error = this._error ?? new Sample.API.Models.OperationStatusError()); set { {_error = value;} } }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Operation Status</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="OperationStatus" /> instance.</summary>
        public OperationStatus()
        {

        }
    }
    /// operation status object
    public partial interface IOperationStatus :
        Sample.API.Runtime.IJsonSerializable
    {
        /// <summary>
        /// An invariant error code used for error troubleshooting, aggregation, and analysis.
        /// </summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An invariant error code used for error troubleshooting, aggregation, and analysis.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get; set; }
        /// <summary>Operation Id</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Operation Id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>An actionable error message indicating what error occurred.</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An actionable error message indicating what error occurred.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>Operation Status</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Operation Status",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }

    }
    /// operation status object
    internal partial interface IOperationStatusInternal

    {
        /// <summary>
        /// An invariant error code used for error troubleshooting, aggregation, and analysis.
        /// </summary>
        string Code { get; set; }
        /// <summary>Hdi cluster with Fusion client installed</summary>
        Sample.API.Models.IOperationStatusError Error { get; set; }
        /// <summary>Operation Id</summary>
        string Id { get; set; }
        /// <summary>An actionable error message indicating what error occurred.</summary>
        string Message { get; set; }
        /// <summary>Operation Status</summary>
        string Status { get; set; }

    }
}