// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6246, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;

    /// <summary>Properties of Created Hive Rule Name</summary>
    public partial class HiveReplicationRuleProperties :
        Sample.API.Models.IHiveReplicationRuleProperties,
        Sample.API.Models.IHiveReplicationRulePropertiesInternal
    {

        /// <summary>Backing field for <see cref="DbNamePattern" /> property.</summary>
        private string _dbNamePattern;

        /// <summary>The simple pattern of the Database as a mapped path determined by Fusion.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        public string DbNamePattern { get => this._dbNamePattern; set => this._dbNamePattern = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Sample.API.Support.ProvisioningState? _provisioningState;

        /// <summary>Provisioning State of resource</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        public Sample.API.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="RecentConsistencyReport" /> property.</summary>
        private Sample.API.Models.IHiveConsistencyReport _recentConsistencyReport;

        /// <summary>A report of the most recent consistency check completed for this rule</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        internal Sample.API.Models.IHiveConsistencyReport RecentConsistencyReport { get => (this._recentConsistencyReport = this._recentConsistencyReport ?? new Sample.API.Models.HiveConsistencyReport()); }

        /// <summary>The number of database where consistency check status is CONSISTENT</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public long? RecentConsistencyReportConsistent { get => ((Sample.API.Models.IHiveConsistencyReportInternal)RecentConsistencyReport).Consistent; set => ((Sample.API.Models.IHiveConsistencyReportInternal)RecentConsistencyReport).Consistent = value; }

        /// <summary>The number of database where consistency check status is FAILED</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public long? RecentConsistencyReportFailed { get => ((Sample.API.Models.IHiveConsistencyReportInternal)RecentConsistencyReport).Failed; set => ((Sample.API.Models.IHiveConsistencyReportInternal)RecentConsistencyReport).Failed = value; }

        /// <summary>The number of database where consistency check status is INCONSISTENT</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public long? RecentConsistencyReportInconsistent { get => ((Sample.API.Models.IHiveConsistencyReportInternal)RecentConsistencyReport).Inconsistent; set => ((Sample.API.Models.IHiveConsistencyReportInternal)RecentConsistencyReport).Inconsistent = value; }

        /// <summary>The number of database where consistency check status is RUNNING</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public long? RecentConsistencyReportRunning { get => ((Sample.API.Models.IHiveConsistencyReportInternal)RecentConsistencyReport).Running; set => ((Sample.API.Models.IHiveConsistencyReportInternal)RecentConsistencyReport).Running = value; }

        /// <summary>The number of database where consistency check status is UNKNOWN</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Inlined)]
        public long? RecentConsistencyReportUnknown { get => ((Sample.API.Models.IHiveConsistencyReportInternal)RecentConsistencyReport).Unknown; set => ((Sample.API.Models.IHiveConsistencyReportInternal)RecentConsistencyReport).Unknown = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Sample.API.Support.ProvisioningState? Sample.API.Models.IHiveReplicationRulePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for RecentConsistencyReport</summary>
        Sample.API.Models.IHiveConsistencyReport Sample.API.Models.IHiveReplicationRulePropertiesInternal.RecentConsistencyReport { get => (this._recentConsistencyReport = this._recentConsistencyReport ?? new Sample.API.Models.HiveConsistencyReport()); set { {_recentConsistencyReport = value;} } }

        /// <summary>Backing field for <see cref="TableNamePattern" /> property.</summary>
        private string _tableNamePattern;

        /// <summary>The simple pattern of the Table Name as a mapped path as determined by Fusion.</summary>
        [Sample.API.Origin(Sample.API.PropertyOrigin.Owned)]
        public string TableNamePattern { get => this._tableNamePattern; set => this._tableNamePattern = value; }

        /// <summary>Creates an new <see cref="HiveReplicationRuleProperties" /> instance.</summary>
        public HiveReplicationRuleProperties()
        {

        }
    }
    /// Properties of Created Hive Rule Name
    public partial interface IHiveReplicationRuleProperties :
        Sample.API.Runtime.IJsonSerializable
    {
        /// <summary>The simple pattern of the Database as a mapped path determined by Fusion.</summary>
        [Sample.API.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The simple pattern of the Database as a mapped path determined by Fusion.",
        SerializedName = @"dbNamePattern",
        PossibleTypes = new [] { typeof(string) })]
        string DbNamePattern { get; set; }
        /// <summary>Provisioning State of resource</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning State of resource",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Sample.API.Support.ProvisioningState) })]
        Sample.API.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>The number of database where consistency check status is CONSISTENT</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of database where consistency check status is CONSISTENT",
        SerializedName = @"consistent",
        PossibleTypes = new [] { typeof(long) })]
        long? RecentConsistencyReportConsistent { get; set; }
        /// <summary>The number of database where consistency check status is FAILED</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of database where consistency check status is FAILED",
        SerializedName = @"failed",
        PossibleTypes = new [] { typeof(long) })]
        long? RecentConsistencyReportFailed { get; set; }
        /// <summary>The number of database where consistency check status is INCONSISTENT</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of database where consistency check status is INCONSISTENT",
        SerializedName = @"inconsistent",
        PossibleTypes = new [] { typeof(long) })]
        long? RecentConsistencyReportInconsistent { get; set; }
        /// <summary>The number of database where consistency check status is RUNNING</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of database where consistency check status is RUNNING",
        SerializedName = @"running",
        PossibleTypes = new [] { typeof(long) })]
        long? RecentConsistencyReportRunning { get; set; }
        /// <summary>The number of database where consistency check status is UNKNOWN</summary>
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of database where consistency check status is UNKNOWN",
        SerializedName = @"unknown",
        PossibleTypes = new [] { typeof(long) })]
        long? RecentConsistencyReportUnknown { get; set; }
        /// <summary>The simple pattern of the Table Name as a mapped path as determined by Fusion.</summary>
        [Sample.API.Runtime.Info(
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
        Sample.API.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>A report of the most recent consistency check completed for this rule</summary>
        Sample.API.Models.IHiveConsistencyReport RecentConsistencyReport { get; set; }
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