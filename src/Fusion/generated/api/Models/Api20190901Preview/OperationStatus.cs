namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>operation status object</summary>
    public partial class OperationStatus :
        Wandisco.Fusion.Models.Api20190901Preview.IOperationStatus,
        Wandisco.Fusion.Models.Api20190901Preview.IOperationStatusInternal
    {

        /// <summary>
        /// An invariant error code used for error troubleshooting, aggregation, and analysis.
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string Code { get => ((Wandisco.Fusion.Models.Api20190901Preview.IOperationStatusErrorInternal)Error).Code; set => ((Wandisco.Fusion.Models.Api20190901Preview.IOperationStatusErrorInternal)Error).Code = value; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IOperationStatusError _error;

        /// <summary>Hdi cluster with Fusion client installed</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        internal Wandisco.Fusion.Models.Api20190901Preview.IOperationStatusError Error { get => (this._error = this._error ?? new Wandisco.Fusion.Models.Api20190901Preview.OperationStatusError()); set => this._error = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Operation Id</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>An actionable error message indicating what error occurred.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string Message { get => ((Wandisco.Fusion.Models.Api20190901Preview.IOperationStatusErrorInternal)Error).Message; set => ((Wandisco.Fusion.Models.Api20190901Preview.IOperationStatusErrorInternal)Error).Message = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Operation Status</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Internal Acessors for Error</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IOperationStatusError Wandisco.Fusion.Models.Api20190901Preview.IOperationStatusInternal.Error { get => (this._error = this._error ?? new Wandisco.Fusion.Models.Api20190901Preview.OperationStatusError()); set { {_error = value;} } }

        /// <summary>Creates an new <see cref="OperationStatus" /> instance.</summary>
        public OperationStatus()
        {

        }
    }
    /// operation status object
    public partial interface IOperationStatus :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>
        /// An invariant error code used for error troubleshooting, aggregation, and analysis.
        /// </summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An invariant error code used for error troubleshooting, aggregation, and analysis.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get; set; }
        /// <summary>Operation Id</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Operation Id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>An actionable error message indicating what error occurred.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An actionable error message indicating what error occurred.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>Operation Status</summary>
        [Wandisco.Fusion.Runtime.Info(
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
        Wandisco.Fusion.Models.Api20190901Preview.IOperationStatusError Error { get; set; }
        /// <summary>Operation Id</summary>
        string Id { get; set; }
        /// <summary>An actionable error message indicating what error occurred.</summary>
        string Message { get; set; }
        /// <summary>Operation Status</summary>
        string Status { get; set; }

    }
}