namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>The list of Fusion Groups.</summary>
    public partial class FusionGroupList :
        Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupList,
        Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link used to get the next page of Fusion Groups list.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IFusionGroup[] _value;

        /// <summary>The list of groups</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Models.Api20190901Preview.IFusionGroup[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="FusionGroupList" /> instance.</summary>
        public FusionGroupList()
        {

        }
    }
    /// The list of Fusion Groups.
    public partial interface IFusionGroupList :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>The link used to get the next page of Fusion Groups list.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The link used to get the next page of Fusion Groups list.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of groups</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of groups",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Models.Api20190901Preview.IFusionGroup) })]
        Wandisco.Fusion.Models.Api20190901Preview.IFusionGroup[] Value { get; set; }

    }
    /// The list of Fusion Groups.
    internal partial interface IFusionGroupListInternal

    {
        /// <summary>The link used to get the next page of Fusion Groups list.</summary>
        string NextLink { get; set; }
        /// <summary>The list of groups</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IFusionGroup[] Value { get; set; }

    }
}