// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6246, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;

    /// <summary>Replication Rule Mapping of a specific Zone</summary>
    public partial class PathMapping :
        Sample.API.Models.IPathMapping,
        Sample.API.Models.IPathMappingInternal
    {

        /// <summary>Backing field for <see cref="Path" /> property.</summary>
        private string _path;

        /// <summary>
        /// The Filesystem Path for which the zone defined by \'zone\' should replicate incoming Fusion requests to.
        /// </summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        public string Path { get => this._path; set => this._path = value; }

        /// <summary>Backing field for <see cref="Zone" /> property.</summary>
        private string _zone;

        /// <summary>Zone name</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        public string Zone { get => this._zone; set => this._zone = value; }

        /// <summary>Creates an new <see cref="PathMapping" /> instance.</summary>
        public PathMapping()
        {

        }
    }
    /// Replication Rule Mapping of a specific Zone
    public partial interface IPathMapping :
        Sample.API.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The Filesystem Path for which the zone defined by \'zone\' should replicate incoming Fusion requests to.
        /// </summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Filesystem Path for which the zone defined by \'zone\' should replicate incoming Fusion requests to.",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string Path { get; set; }
        /// <summary>Zone name</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Zone name",
        SerializedName = @"zone",
        PossibleTypes = new [] { typeof(string) })]
        string Zone { get; set; }

    }
    /// Replication Rule Mapping of a specific Zone
    internal partial interface IPathMappingInternal

    {
        /// <summary>
        /// The Filesystem Path for which the zone defined by \'zone\' should replicate incoming Fusion requests to.
        /// </summary>
        string Path { get; set; }
        /// <summary>Zone name</summary>
        string Zone { get; set; }

    }
}