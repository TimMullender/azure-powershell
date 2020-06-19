namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>resource tags.</summary>
    public partial class ResourceTags :
        Wandisco.Fusion.Models.Api20190901Preview.IResourceTags,
        Wandisco.Fusion.Models.Api20190901Preview.IResourceTagsInternal
    {

        /// <summary>Creates an new <see cref="ResourceTags" /> instance.</summary>
        public ResourceTags()
        {

        }
    }
    /// resource tags.
    public partial interface IResourceTags :
        Wandisco.Fusion.Runtime.IJsonSerializable,
        Wandisco.Fusion.Runtime.IAssociativeArray<string>
    {

    }
    /// resource tags.
    internal partial interface IResourceTagsInternal

    {

    }
}