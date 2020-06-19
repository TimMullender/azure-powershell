namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Replication Rule Mapping of a specific Zone</summary>
    public partial class PathMapping :
        Wandisco.Fusion.Models.Api20190901Preview.IPathMapping,
        Wandisco.Fusion.Models.Api20190901Preview.IPathMappingInternal
    {

        /// <summary>Backing field for <see cref="Path" /> property.</summary>
        private string _path;

        /// <summary>
        /// The Filesystem Path for which the zone defined by \'zone\' should replicate incoming Fusion requests to.
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Path { get => this._path; set => this._path = value; }

        /// <summary>Backing field for <see cref="Zone" /> property.</summary>
        private string _zone;

        /// <summary>Zone name</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Zone { get => this._zone; set => this._zone = value; }

        /// <summary>Creates an new <see cref="PathMapping" /> instance.</summary>
        public PathMapping()
        {

        }
    }
    /// Replication Rule Mapping of a specific Zone
    public partial interface IPathMapping :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The Filesystem Path for which the zone defined by \'zone\' should replicate incoming Fusion requests to.
        /// </summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Filesystem Path for which the zone defined by \'zone\' should replicate incoming Fusion requests to.",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string Path { get; set; }
        /// <summary>Zone name</summary>
        [Wandisco.Fusion.Runtime.Info(
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