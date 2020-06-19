namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>
    /// Result of the request to list Resource Provider operations. It contains a list of operations and a URL link to get the
    /// next set of results.
    /// </summary>
    public partial class OperationListResult :
        Wandisco.Fusion.Models.Api20190901Preview.IOperationListResult,
        Wandisco.Fusion.Models.Api20190901Preview.IOperationListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URL to get the next set of operation list results if there are any.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IOperation[] _value;

        /// <summary>
        /// List of Resource Provider operations supported by the Resource Provider resource provider.
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Models.Api20190901Preview.IOperation[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="OperationListResult" /> instance.</summary>
        public OperationListResult()
        {

        }
    }
    /// Result of the request to list Resource Provider operations. It contains a list of operations and a URL link to get the
    /// next set of results.
    public partial interface IOperationListResult :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>URL to get the next set of operation list results if there are any.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URL to get the next set of operation list results if there are any.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>
        /// List of Resource Provider operations supported by the Resource Provider resource provider.
        /// </summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of Resource Provider operations supported by the Resource Provider resource provider.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Models.Api20190901Preview.IOperation) })]
        Wandisco.Fusion.Models.Api20190901Preview.IOperation[] Value { get; set; }

    }
    /// Result of the request to list Resource Provider operations. It contains a list of operations and a URL link to get the
    /// next set of results.
    internal partial interface IOperationListResultInternal

    {
        /// <summary>URL to get the next set of operation list results if there are any.</summary>
        string NextLink { get; set; }
        /// <summary>
        /// List of Resource Provider operations supported by the Resource Provider resource provider.
        /// </summary>
        Wandisco.Fusion.Models.Api20190901Preview.IOperation[] Value { get; set; }

    }
}