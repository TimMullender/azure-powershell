namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>The list of Managed OnPrem Zones.</summary>
    public partial class ManagedOnPremZoneList :
        Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneList,
        Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link used to get the next page of managed onPrem zones list.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZone[] _value;

        /// <summary>The list of zones.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZone[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ManagedOnPremZoneList" /> instance.</summary>
        public ManagedOnPremZoneList()
        {

        }
    }
    /// The list of Managed OnPrem Zones.
    public partial interface IManagedOnPremZoneList :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>The link used to get the next page of managed onPrem zones list.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The link used to get the next page of managed onPrem zones list.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of zones.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of zones.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZone) })]
        Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZone[] Value { get; set; }

    }
    /// The list of Managed OnPrem Zones.
    internal partial interface IManagedOnPremZoneListInternal

    {
        /// <summary>The link used to get the next page of managed onPrem zones list.</summary>
        string NextLink { get; set; }
        /// <summary>The list of zones.</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZone[] Value { get; set; }

    }
}