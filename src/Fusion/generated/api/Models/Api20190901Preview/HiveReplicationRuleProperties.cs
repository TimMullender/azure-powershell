namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Properties of Created Hive Rule Name</summary>
    public partial class HiveReplicationRuleProperties :
        Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleProperties,
        Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRulePropertiesInternal
    {

        /// <summary>Backing field for <see cref="DbNamePattern" /> property.</summary>
        private string _dbNamePattern;

        /// <summary>The simple pattern of the Database as a mapped path determined by Fusion.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string DbNamePattern { get => this._dbNamePattern; set => this._dbNamePattern = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Wandisco.Fusion.Support.ProvisioningState? _provisioningState;

        /// <summary>Provisioning State of resource</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="RecentConsistencyReport" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReport _recentConsistencyReport;

        /// <summary>A report of the most recent consistency check completed for this rule</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        internal Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReport RecentConsistencyReport { get => (this._recentConsistencyReport = this._recentConsistencyReport ?? new Wandisco.Fusion.Models.Api20190901Preview.HiveConsistencyReport()); }

        /// <summary>The number of database where consistency check status is CONSISTENT</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? RecentConsistencyReportConsistent { get => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)RecentConsistencyReport).Consistent; set => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)RecentConsistencyReport).Consistent = value; }

        /// <summary>The number of database where consistency check status is FAILED</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? RecentConsistencyReportFailed { get => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)RecentConsistencyReport).Failed; set => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)RecentConsistencyReport).Failed = value; }

        /// <summary>The number of database where consistency check status is INCONSISTENT</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? RecentConsistencyReportInconsistent { get => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)RecentConsistencyReport).Inconsistent; set => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)RecentConsistencyReport).Inconsistent = value; }

        /// <summary>The number of database where consistency check status is RUNNING</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? RecentConsistencyReportRunning { get => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)RecentConsistencyReport).Running; set => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)RecentConsistencyReport).Running = value; }

        /// <summary>The number of database where consistency check status is UNKNOWN</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? RecentConsistencyReportUnknown { get => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)RecentConsistencyReport).Unknown; set => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)RecentConsistencyReport).Unknown = value; }

        /// <summary>Backing field for <see cref="TableNamePattern" /> property.</summary>
        private string _tableNamePattern;

        /// <summary>The simple pattern of the Table Name as a mapped path as determined by Fusion.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string TableNamePattern { get => this._tableNamePattern; set => this._tableNamePattern = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Wandisco.Fusion.Support.ProvisioningState? Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRulePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for RecentConsistencyReport</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReport Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRulePropertiesInternal.RecentConsistencyReport { get => (this._recentConsistencyReport = this._recentConsistencyReport ?? new Wandisco.Fusion.Models.Api20190901Preview.HiveConsistencyReport()); set { {_recentConsistencyReport = value;} } }

        /// <summary>Creates an new <see cref="HiveReplicationRuleProperties" /> instance.</summary>
        public HiveReplicationRuleProperties()
        {

        }
    }
    /// Properties of Created Hive Rule Name
    public partial interface IHiveReplicationRuleProperties :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>The simple pattern of the Database as a mapped path determined by Fusion.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The simple pattern of the Database as a mapped path determined by Fusion.",
        SerializedName = @"dbNamePattern",
        PossibleTypes = new [] { typeof(string) })]
        string DbNamePattern { get; set; }
        /// <summary>Provisioning State of resource</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning State of resource",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Support.ProvisioningState) })]
        Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>The number of database where consistency check status is CONSISTENT</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of database where consistency check status is CONSISTENT",
        SerializedName = @"consistent",
        PossibleTypes = new [] { typeof(long) })]
        long? RecentConsistencyReportConsistent { get; set; }
        /// <summary>The number of database where consistency check status is FAILED</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of database where consistency check status is FAILED",
        SerializedName = @"failed",
        PossibleTypes = new [] { typeof(long) })]
        long? RecentConsistencyReportFailed { get; set; }
        /// <summary>The number of database where consistency check status is INCONSISTENT</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of database where consistency check status is INCONSISTENT",
        SerializedName = @"inconsistent",
        PossibleTypes = new [] { typeof(long) })]
        long? RecentConsistencyReportInconsistent { get; set; }
        /// <summary>The number of database where consistency check status is RUNNING</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of database where consistency check status is RUNNING",
        SerializedName = @"running",
        PossibleTypes = new [] { typeof(long) })]
        long? RecentConsistencyReportRunning { get; set; }
        /// <summary>The number of database where consistency check status is UNKNOWN</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of database where consistency check status is UNKNOWN",
        SerializedName = @"unknown",
        PossibleTypes = new [] { typeof(long) })]
        long? RecentConsistencyReportUnknown { get; set; }
        /// <summary>The simple pattern of the Table Name as a mapped path as determined by Fusion.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The simple pattern of the Table Name as a mapped path as determined by Fusion.",
        SerializedName = @"tableNamePattern",
        PossibleTypes = new [] { typeof(string) })]
        string TableNamePattern { get; set; }

    }
    /// Properties of Created Hive Rule Name
    internal partial interface IHiveReplicationRulePropertiesInternal

    {
        /// <summary>The simple pattern of the Database as a mapped path determined by Fusion.</summary>
        string DbNamePattern { get; set; }
        /// <summary>Provisioning State of resource</summary>
        Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>A report of the most recent consistency check completed for this rule</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReport RecentConsistencyReport { get; set; }
        /// <summary>The number of database where consistency check status is CONSISTENT</summary>
        long? RecentConsistencyReportConsistent { get; set; }
        /// <summary>The number of database where consistency check status is FAILED</summary>
        long? RecentConsistencyReportFailed { get; set; }
        /// <summary>The number of database where consistency check status is INCONSISTENT</summary>
        long? RecentConsistencyReportInconsistent { get; set; }
        /// <summary>The number of database where consistency check status is RUNNING</summary>
        long? RecentConsistencyReportRunning { get; set; }
        /// <summary>The number of database where consistency check status is UNKNOWN</summary>
        long? RecentConsistencyReportUnknown { get; set; }
        /// <summary>The simple pattern of the Table Name as a mapped path as determined by Fusion.</summary>
        string TableNamePattern { get; set; }

    }
}