namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>The list of Azure Zones.</summary>
    public partial class AzureZoneList :
        Wandisco.Fusion.Models.Api20190901Preview.IAzureZoneList,
        Wandisco.Fusion.Models.Api20190901Preview.IAzureZoneListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link used to get the next page of Azure zones list.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IAzureZone[] _value;

        /// <summary>The list of zones.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Models.Api20190901Preview.IAzureZone[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="AzureZoneList" /> instance.</summary>
        public AzureZoneList()
        {

        }
    }
    /// The list of Azure Zones.
    public partial interface IAzureZoneList :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>The link used to get the next page of Azure zones list.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The link used to get the next page of Azure zones list.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of zones.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of zones.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Models.Api20190901Preview.IAzureZone) })]
        Wandisco.Fusion.Models.Api20190901Preview.IAzureZone[] Value { get; set; }

    }
    /// The list of Azure Zones.
    internal partial interface IAzureZoneListInternal

    {
        /// <summary>The link used to get the next page of Azure zones list.</summary>
        string NextLink { get; set; }
        /// <summary>The list of zones.</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IAzureZone[] Value { get; set; }

    }
}