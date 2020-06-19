namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>HiveConsistencyReport Results for rule</summary>
    public partial class HiveConsistencyReport :
        Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReport,
        Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal
    {

        /// <summary>Backing field for <see cref="Consistent" /> property.</summary>
        private long? _consistent;

        /// <summary>The number of database where consistency check status is CONSISTENT</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public long? Consistent { get => this._consistent; set => this._consistent = value; }

        /// <summary>Backing field for <see cref="Failed" /> property.</summary>
        private long? _failed;

        /// <summary>The number of database where consistency check status is FAILED</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public long? Failed { get => this._failed; set => this._failed = value; }

        /// <summary>Backing field for <see cref="Inconsistent" /> property.</summary>
        private long? _inconsistent;

        /// <summary>The number of database where consistency check status is INCONSISTENT</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public long? Inconsistent { get => this._inconsistent; set => this._inconsistent = value; }

        /// <summary>Backing field for <see cref="Running" /> property.</summary>
        private long? _running;

        /// <summary>The number of database where consistency check status is RUNNING</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public long? Running { get => this._running; set => this._running = value; }

        /// <summary>Backing field for <see cref="Unknown" /> property.</summary>
        private long? _unknown;

        /// <summary>The number of database where consistency check status is UNKNOWN</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public long? Unknown { get => this._unknown; set => this._unknown = value; }

        /// <summary>Creates an new <see cref="HiveConsistencyReport" /> instance.</summary>
        public HiveConsistencyReport()
        {

        }
    }
    /// HiveConsistencyReport Results for rule
    public partial interface IHiveConsistencyReport :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>The number of database where consistency check status is CONSISTENT</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of database where consistency check status is CONSISTENT",
        SerializedName = @"consistent",
        PossibleTypes = new [] { typeof(long) })]
        long? Consistent { get; set; }
        /// <summary>The number of database where consistency check status is FAILED</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of database where consistency check status is FAILED",
        SerializedName = @"failed",
        PossibleTypes = new [] { typeof(long) })]
        long? Failed { get; set; }
        /// <summary>The number of database where consistency check status is INCONSISTENT</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of database where consistency check status is INCONSISTENT",
        SerializedName = @"inconsistent",
        PossibleTypes = new [] { typeof(long) })]
        long? Inconsistent { get; set; }
        /// <summary>The number of database where consistency check status is RUNNING</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of database where consistency check status is RUNNING",
        SerializedName = @"running",
        PossibleTypes = new [] { typeof(long) })]
        long? Running { get; set; }
        /// <summary>The number of database where consistency check status is UNKNOWN</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of database where consistency check status is UNKNOWN",
        SerializedName = @"unknown",
        PossibleTypes = new [] { typeof(long) })]
        long? Unknown { get; set; }

    }
    /// HiveConsistencyReport Results for rule
    internal partial interface IHiveConsistencyReportInternal

    {
        /// <summary>The number of database where consistency check status is CONSISTENT</summary>
        long? Consistent { get; set; }
        /// <summary>The number of database where consistency check status is FAILED</summary>
        long? Failed { get; set; }
        /// <summary>The number of database where consistency check status is INCONSISTENT</summary>
        long? Inconsistent { get; set; }
        /// <summary>The number of database where consistency check status is RUNNING</summary>
        long? Running { get; set; }
        /// <summary>The number of database where consistency check status is UNKNOWN</summary>
        long? Unknown { get; set; }

    }
}