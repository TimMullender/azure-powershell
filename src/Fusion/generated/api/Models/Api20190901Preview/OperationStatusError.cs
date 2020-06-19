namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>operation status error</summary>
    public partial class OperationStatusError :
        Wandisco.Fusion.Models.Api20190901Preview.IOperationStatusError,
        Wandisco.Fusion.Models.Api20190901Preview.IOperationStatusErrorInternal
    {

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private string _code;

        /// <summary>
        /// An invariant error code used for error troubleshooting, aggregation, and analysis.
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Code { get => this._code; set => this._code = value; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>An actionable error message indicating what error occurred.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Creates an new <see cref="OperationStatusError" /> instance.</summary>
        public OperationStatusError()
        {

        }
    }
    /// operation status error
    public partial interface IOperationStatusError :
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
        /// <summary>An actionable error message indicating what error occurred.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An actionable error message indicating what error occurred.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }

    }
    /// operation status error
    internal partial interface IOperationStatusErrorInternal

    {
        /// <summary>
        /// An invariant error code used for error troubleshooting, aggregation, and analysis.
        /// </summary>
        string Code { get; set; }
        /// <summary>An actionable error message indicating what error occurred.</summary>
        string Message { get; set; }

    }
}