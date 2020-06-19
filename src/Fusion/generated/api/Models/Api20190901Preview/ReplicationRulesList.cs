namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>The list of Replications Rules.</summary>
    public partial class ReplicationRulesList :
        Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulesList,
        Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulesListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link used to get the next page of Replication Rules list.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IReplicationRule[] _value;

        /// <summary>The list of replication rules</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Models.Api20190901Preview.IReplicationRule[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ReplicationRulesList" /> instance.</summary>
        public ReplicationRulesList()
        {

        }
    }
    /// The list of Replications Rules.
    public partial interface IReplicationRulesList :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>The link used to get the next page of Replication Rules list.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The link used to get the next page of Replication Rules list.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of replication rules</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of replication rules",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Models.Api20190901Preview.IReplicationRule) })]
        Wandisco.Fusion.Models.Api20190901Preview.IReplicationRule[] Value { get; set; }

    }
    /// The list of Replications Rules.
    internal partial interface IReplicationRulesListInternal

    {
        /// <summary>The link used to get the next page of Replication Rules list.</summary>
        string NextLink { get; set; }
        /// <summary>The list of replication rules</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IReplicationRule[] Value { get; set; }

    }
}