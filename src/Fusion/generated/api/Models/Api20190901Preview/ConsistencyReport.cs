namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>ConsistencyReport Results for path</summary>
    public partial class ConsistencyReport :
        Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReport,
        Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReportInternal
    {

        /// <summary>Backing field for <see cref="InconsistencyCount" /> property.</summary>
        private long? _inconsistencyCount;

        /// <summary>
        /// The number of inconsistent files if the result of the consistency check is inconsistent
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public long? InconsistencyCount { get => this._inconsistencyCount; set => this._inconsistencyCount = value; }

        /// <summary>Backing field for <see cref="LastCheck" /> property.</summary>
        private global::System.DateTime? _lastCheck;

        /// <summary>The timestamp from when this consistency check was completed</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public global::System.DateTime? LastCheck { get => this._lastCheck; set => this._lastCheck = value; }

        /// <summary>Backing field for <see cref="Result" /> property.</summary>
        private Wandisco.Fusion.Support.ConsistencyResult? _result;

        /// <summary>The result of the most recent consistency check available for this path</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Support.ConsistencyResult? Result { get => this._result; set => this._result = value; }

        /// <summary>Creates an new <see cref="ConsistencyReport" /> instance.</summary>
        public ConsistencyReport()
        {

        }
    }
    /// ConsistencyReport Results for path
    public partial interface IConsistencyReport :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The number of inconsistent files if the result of the consistency check is inconsistent
        /// </summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of inconsistent files if the result of the consistency check is inconsistent",
        SerializedName = @"inconsistencyCount",
        PossibleTypes = new [] { typeof(long) })]
        long? InconsistencyCount { get; set; }
        /// <summary>The timestamp from when this consistency check was completed</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp from when this consistency check was completed",
        SerializedName = @"lastCheck",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastCheck { get; set; }
        /// <summary>The result of the most recent consistency check available for this path</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The result of the most recent consistency check available for this path",
        SerializedName = @"result",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Support.ConsistencyResult) })]
        Wandisco.Fusion.Support.ConsistencyResult? Result { get; set; }

    }
    /// ConsistencyReport Results for path
    internal partial interface IConsistencyReportInternal

    {
        /// <summary>
        /// The number of inconsistent files if the result of the consistency check is inconsistent
        /// </summary>
        long? InconsistencyCount { get; set; }
        /// <summary>The timestamp from when this consistency check was completed</summary>
        global::System.DateTime? LastCheck { get; set; }
        /// <summary>The result of the most recent consistency check available for this path</summary>
        Wandisco.Fusion.Support.ConsistencyResult? Result { get; set; }

    }
}