namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Resource tags</summary>
    public partial class TagsUpdate :
        Wandisco.Fusion.Models.Api20190901Preview.ITagsUpdate,
        Wandisco.Fusion.Models.Api20190901Preview.ITagsUpdateInternal
    {

        /// <summary>Backing field for <see cref="Tags" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.ITagsUpdateTags _tags;

        /// <summary>resource tags.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Models.Api20190901Preview.ITagsUpdateTags Tags { get => (this._tags = this._tags ?? new Wandisco.Fusion.Models.Api20190901Preview.TagsUpdateTags()); set => this._tags = value; }

        /// <summary>Creates an new <see cref="TagsUpdate" /> instance.</summary>
        public TagsUpdate()
        {

        }
    }
    /// Resource tags
    public partial interface ITagsUpdate :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>resource tags.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Models.Api20190901Preview.ITagsUpdateTags) })]
        Wandisco.Fusion.Models.Api20190901Preview.ITagsUpdateTags Tags { get; set; }

    }
    /// Resource tags
    internal partial interface ITagsUpdateInternal

    {
        /// <summary>resource tags.</summary>
        Wandisco.Fusion.Models.Api20190901Preview.ITagsUpdateTags Tags { get; set; }

    }
}