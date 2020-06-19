namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Error definition.</summary>
    public partial class ErrorDefinition :
        Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition,
        Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinitionInternal
    {

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private string _code;

        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Code { get => this._code; }

        /// <summary>Backing field for <see cref="Details" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition[] _details;

        /// <summary>Internal error details.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition[] Details { get => this._details; set => this._details = value; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>Description of the error.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Message { get => this._message; }

        /// <summary>Internal Acessors for Code</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinitionInternal.Code { get => this._code; set { {_code = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinitionInternal.Message { get => this._message; set { {_message = value;} } }

        /// <summary>Creates an new <see cref="ErrorDefinition" /> instance.</summary>
        public ErrorDefinition()
        {

        }
    }
    /// Error definition.
    public partial interface IErrorDefinition :
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
    /// Error definition.
    internal partial interface IErrorDefinitionInternal

    {
        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        string Code { get; set; }
        /// <summary>Internal error details.</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition[] Details { get; set; }
        /// <summary>Description of the error.</summary>
        string Message { get; set; }

    }
}