namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>
    /// Error response indicates that the service is not able to process the incoming request.
    /// </summary>
    public partial class ErrorResponse :
        Wandisco.Fusion.Models.Api20190901Preview.IErrorResponse,
        Wandisco.Fusion.Models.Api20190901Preview.IErrorResponseInternal
    {

        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string Code { get => ((Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinitionInternal)Error).Code; }

        /// <summary>Internal error details.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition[] Details { get => ((Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinitionInternal)Error).Details; set => ((Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinitionInternal)Error).Details = value; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition _error;

        /// <summary>The error details.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        internal Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition Error { get => (this._error = this._error ?? new Wandisco.Fusion.Models.Api20190901Preview.ErrorDefinition()); set => this._error = value; }

        /// <summary>Description of the error.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string Message { get => ((Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinitionInternal)Error).Message; }

        /// <summary>Internal Acessors for Code</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IErrorResponseInternal.Code { get => ((Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinitionInternal)Error).Code; set => ((Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinitionInternal)Error).Code = value; }

        /// <summary>Internal Acessors for Error</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition Wandisco.Fusion.Models.Api20190901Preview.IErrorResponseInternal.Error { get => (this._error = this._error ?? new Wandisco.Fusion.Models.Api20190901Preview.ErrorDefinition()); set { {_error = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IErrorResponseInternal.Message { get => ((Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinitionInternal)Error).Message; set => ((Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinitionInternal)Error).Message = value; }

        /// <summary>Creates an new <see cref="ErrorResponse" /> instance.</summary>
        public ErrorResponse()
        {

        }
    }
    /// Error response indicates that the service is not able to process the incoming request.
    public partial interface IErrorResponse :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Service specific error code which serves as the substatus for the HTTP error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>Internal error details.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Internal error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition) })]
        Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition[] Details { get; set; }
        /// <summary>Description of the error.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Description of the error.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }

    }
    /// Error response indicates that the service is not able to process the incoming request.
    internal partial interface IErrorResponseInternal

    {
        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        string Code { get; set; }
        /// <summary>Internal error details.</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition[] Details { get; set; }
        /// <summary>The error details.</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition Error { get; set; }
        /// <summary>Description of the error.</summary>
        string Message { get; set; }

    }
}