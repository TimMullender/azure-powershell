namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>resource tags.</summary>
    public partial class TagsUpdateTags :
        Wandisco.Fusion.Models.Api20190901Preview.ITagsUpdateTags,
        Wandisco.Fusion.Models.Api20190901Preview.ITagsUpdateTagsInternal
    {

        /// <summary>Creates an new <see cref="TagsUpdateTags" /> instance.</summary>
        public TagsUpdateTags()
        {

        }
    }
    /// resource tags.
    public partial interface ITagsUpdateTags :
        Wandisco.Fusion.Runtime.IJsonSerializable,
        Wandisco.Fusion.Runtime.IAssociativeArray<string>
    {

    }
    /// resource tags.
    internal partial interface ITagsUpdateTagsInternal

    {

    }
}