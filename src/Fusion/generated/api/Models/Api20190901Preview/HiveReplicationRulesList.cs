namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>The list of Hive Replications Rules.</summary>
    public partial class HiveReplicationRulesList :
        Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRulesList,
        Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRulesListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link used to get the next page of Hive Replication Rules list.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRule[] _value;

        /// <summary>The list of hive replication rules</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRule[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="HiveReplicationRulesList" /> instance.</summary>
        public HiveReplicationRulesList()
        {

        }
    }
    /// The list of Hive Replications Rules.
    public partial interface IHiveReplicationRulesList :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>The link used to get the next page of Hive Replication Rules list.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The link used to get the next page of Hive Replication Rules list.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of hive replication rules</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of hive replication rules",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRule) })]
        Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRule[] Value { get; set; }

    }
    /// The list of Hive Replications Rules.
    internal partial interface IHiveReplicationRulesListInternal

    {
        /// <summary>The link used to get the next page of Hive Replication Rules list.</summary>
        string NextLink { get; set; }
        /// <summary>The list of hive replication rules</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRule[] Value { get; set; }

    }
}