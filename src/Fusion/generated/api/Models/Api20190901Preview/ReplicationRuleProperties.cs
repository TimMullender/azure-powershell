namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Properties of Created Rule Name</summary>
    public partial class ReplicationRuleProperties :
        Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleProperties,
        Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal
    {

        /// <summary>
        /// Date after which migration should occur. Required if overwritePolicy is SkipIfDateIsEarlier.
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public global::System.DateTime? DateAfterWhichToMigrate { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).DateAfterWhichToMigrate; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).DateAfterWhichToMigrate = value; }

        /// <summary>Backing field for <see cref="Migration" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IMigration _migration;

        /// <summary>The most recent migration for the replication rule</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        internal Wandisco.Fusion.Models.Api20190901Preview.IMigration Migration { get => (this._migration = this._migration ?? new Wandisco.Fusion.Models.Api20190901Preview.Migration()); }

        /// <summary>Azure resource Id.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string MigrationId { get => ((Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal)Migration).Id; }

        /// <summary>Azure resource name.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string MigrationName { get => ((Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal)Migration).Name; }

        /// <summary>Azure resource type.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string MigrationType { get => ((Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal)Migration).Type; }

        /// <summary>The overwrite policy for migration Clobber|SkipIfSizeMatch|SkipIfDateIsEarlier</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Support.LiveMigrationOverwritePolicy? OverwritePolicy { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).OverwritePolicy; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).OverwritePolicy = value; }

        /// <summary>Backing field for <see cref="Path" /> property.</summary>
        private string _path;

        /// <summary>
        /// The Filesystem Path to be used if a PathMapping is not defined for a certain zone.
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Path { get => this._path; set => this._path = value; }

        /// <summary>Backing field for <see cref="PathMapping" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IPathMapping[] _pathMapping;

        /// <summary>Path Mapping for a Replication Rule</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Models.Api20190901Preview.IPathMapping[] PathMapping { get => this._pathMapping; set => this._pathMapping = value; }

        /// <summary>Backing field for <see cref="PriorityZone" /> property.</summary>
        private string _priorityZone;

        /// <summary>
        /// The Zone that takes precedence for a quorum in a scenario where there is an even number of zones and an equivalent amount
        /// of nodes are down in each zone
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string PriorityZone { get => this._priorityZone; set => this._priorityZone = value; }

        /// <summary>Number of bytes excluded</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressBytesExcluded { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).ProgressBytesExcluded; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).ProgressBytesExcluded = value; }

        /// <summary>Number of bytes to migrate</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressBytesToMigrate { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).ProgressBytesToMigrate; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).ProgressBytesToMigrate = value; }

        /// <summary>Number of excluded directories</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressDirsExcluded { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).ProgressDirsExcluded; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).ProgressDirsExcluded = value; }

        /// <summary>Number of directories scanned</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressDirsSeen { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).ProgressDirsSeen; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).ProgressDirsSeen = value; }

        /// <summary>Number of directories to migrate</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressDirsToMigrate { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).ProgressDirsToMigrate; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).ProgressDirsToMigrate = value; }

        /// <summary>Duration of migration</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressDuration { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).ProgressDuration; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).ProgressDuration = value; }

        /// <summary>Number of excluded files</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressFilesExcluded { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).ProgressFilesExcluded; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).ProgressFilesExcluded = value; }

        /// <summary>Number of files scanned</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressFilesSeen { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).ProgressFilesSeen; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).ProgressFilesSeen = value; }

        /// <summary>Number of files to migrate</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressFilesToMigrate { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).ProgressFilesToMigrate; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).ProgressFilesToMigrate = value; }

        /// <summary>Size of the migration</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressSizeOfMigration { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).ProgressSizeOfMigration; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).ProgressSizeOfMigration = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Wandisco.Fusion.Support.ProvisioningState? _provisioningState;

        /// <summary>Provisioning State of resource</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="RecentConsistencyReport" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReport _recentConsistencyReport;

        /// <summary>A report of the most recent consistency check completed for this path</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        internal Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReport RecentConsistencyReport { get => (this._recentConsistencyReport = this._recentConsistencyReport ?? new Wandisco.Fusion.Models.Api20190901Preview.ConsistencyReport()); }

        /// <summary>
        /// The number of inconsistent files if the result of the consistency check is inconsistent
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? RecentConsistencyReportInconsistencyCount { get => ((Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReportInternal)RecentConsistencyReport).InconsistencyCount; set => ((Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReportInternal)RecentConsistencyReport).InconsistencyCount = value; }

        /// <summary>The timestamp from when this consistency check was completed</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public global::System.DateTime? RecentConsistencyReportLastCheck { get => ((Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReportInternal)RecentConsistencyReport).LastCheck; set => ((Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReportInternal)RecentConsistencyReport).LastCheck = value; }

        /// <summary>The result of the most recent consistency check available for this path</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Support.ConsistencyResult? RecentConsistencyReportResult { get => ((Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReportInternal)RecentConsistencyReport).Result; set => ((Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReportInternal)RecentConsistencyReport).Result = value; }

        /// <summary>The source zone for replication rule</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string Source { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).Source; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).Source = value; }

        /// <summary>Running state of the migration</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Support.LiveMigrationState? State { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).State; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).State = value; }

        /// <summary>The target zone for replication rule</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string Target { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).Target; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).Target = value; }

        /// <summary>Internal Acessors for Migration</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IMigration Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal.Migration { get => (this._migration = this._migration ?? new Wandisco.Fusion.Models.Api20190901Preview.Migration()); set { {_migration = value;} } }

        /// <summary>Internal Acessors for MigrationId</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal.MigrationId { get => ((Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal)Migration).Id; set => ((Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal)Migration).Id = value; }

        /// <summary>Internal Acessors for MigrationName</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal.MigrationName { get => ((Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal)Migration).Name; set => ((Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal)Migration).Name = value; }

        /// <summary>Internal Acessors for MigrationProperties</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IMigrationProperties Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal.MigrationProperties { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).Properties; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).Properties = value; }

        /// <summary>Internal Acessors for MigrationType</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal.MigrationType { get => ((Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal)Migration).Type; set => ((Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal)Migration).Type = value; }

        /// <summary>Internal Acessors for Progress</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgress Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal.Progress { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).Progress; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal)Migration).Progress = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Wandisco.Fusion.Support.ProvisioningState? Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for RecentConsistencyReport</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReport Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal.RecentConsistencyReport { get => (this._recentConsistencyReport = this._recentConsistencyReport ?? new Wandisco.Fusion.Models.Api20190901Preview.ConsistencyReport()); set { {_recentConsistencyReport = value;} } }

        /// <summary>Backing field for <see cref="ZoneNames" /> property.</summary>
        private string[] _zoneNames;

        /// <summary>The list of zones the replication rule applies to.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string[] ZoneNames { get => this._zoneNames; set => this._zoneNames = value; }

        /// <summary>Creates an new <see cref="ReplicationRuleProperties" /> instance.</summary>
        public ReplicationRuleProperties()
        {

        }
    }
    /// Properties of Created Rule Name
    public partial interface IReplicationRuleProperties :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Date after which migration should occur. Required if overwritePolicy is SkipIfDateIsEarlier.
        /// </summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Date after which migration should occur. Required if overwritePolicy is SkipIfDateIsEarlier.",
        SerializedName = @"dateAfterWhichToMigrate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? DateAfterWhichToMigrate { get; set; }
        /// <summary>Azure resource Id.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Azure resource Id.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string MigrationId { get;  }
        /// <summary>Azure resource name.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Azure resource name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string MigrationName { get;  }
        /// <summary>Azure resource type.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Azure resource type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string MigrationType { get;  }
        /// <summary>The overwrite policy for migration Clobber|SkipIfSizeMatch|SkipIfDateIsEarlier</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The overwrite policy for migration Clobber|SkipIfSizeMatch|SkipIfDateIsEarlier",
        SerializedName = @"overwritePolicy",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Support.LiveMigrationOverwritePolicy) })]
        Wandisco.Fusion.Support.LiveMigrationOverwritePolicy? OverwritePolicy { get; set; }
        /// <summary>
        /// The Filesystem Path to be used if a PathMapping is not defined for a certain zone.
        /// </summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The Filesystem Path to be used if a PathMapping is not defined for a certain zone.",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string Path { get; set; }
        /// <summary>Path Mapping for a Replication Rule</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Path Mapping for a Replication Rule",
        SerializedName = @"pathMapping",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Models.Api20190901Preview.IPathMapping) })]
        Wandisco.Fusion.Models.Api20190901Preview.IPathMapping[] PathMapping { get; set; }
        /// <summary>
        /// The Zone that takes precedence for a quorum in a scenario where there is an even number of zones and an equivalent amount
        /// of nodes are down in each zone
        /// </summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Zone that takes precedence for a quorum in a scenario where there is an even number of zones and an equivalent amount of nodes are down in each zone",
        SerializedName = @"priorityZone",
        PossibleTypes = new [] { typeof(string) })]
        string PriorityZone { get; set; }
        /// <summary>Number of bytes excluded</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of bytes excluded",
        SerializedName = @"bytesExcluded",
        PossibleTypes = new [] { typeof(long) })]
        long? ProgressBytesExcluded { get; set; }
        /// <summary>Number of bytes to migrate</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of bytes to migrate",
        SerializedName = @"bytesToMigrate",
        PossibleTypes = new [] { typeof(long) })]
        long? ProgressBytesToMigrate { get; set; }
        /// <summary>Number of excluded directories</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of excluded directories",
        SerializedName = @"dirsExcluded",
        PossibleTypes = new [] { typeof(long) })]
        long? ProgressDirsExcluded { get; set; }
        /// <summary>Number of directories scanned</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of directories scanned",
        SerializedName = @"dirsSeen",
        PossibleTypes = new [] { typeof(long) })]
        long? ProgressDirsSeen { get; set; }
        /// <summary>Number of directories to migrate</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of directories to migrate",
        SerializedName = @"dirsToMigrate",
        PossibleTypes = new [] { typeof(long) })]
        long? ProgressDirsToMigrate { get; set; }
        /// <summary>Duration of migration</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Duration of migration",
        SerializedName = @"duration",
        PossibleTypes = new [] { typeof(long) })]
        long? ProgressDuration { get; set; }
        /// <summary>Number of excluded files</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of excluded files",
        SerializedName = @"filesExcluded",
        PossibleTypes = new [] { typeof(long) })]
        long? ProgressFilesExcluded { get; set; }
        /// <summary>Number of files scanned</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of files scanned",
        SerializedName = @"filesSeen",
        PossibleTypes = new [] { typeof(long) })]
        long? ProgressFilesSeen { get; set; }
        /// <summary>Number of files to migrate</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of files to migrate",
        SerializedName = @"filesToMigrate",
        PossibleTypes = new [] { typeof(long) })]
        long? ProgressFilesToMigrate { get; set; }
        /// <summary>Size of the migration</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Size of the migration",
        SerializedName = @"sizeOfMigration",
        PossibleTypes = new [] { typeof(long) })]
        long? ProgressSizeOfMigration { get; set; }
        /// <summary>Provisioning State of resource</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning State of resource",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Support.ProvisioningState) })]
        Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>
        /// The number of inconsistent files if the result of the consistency check is inconsistent
        /// </summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of inconsistent files if the result of the consistency check is inconsistent",
        SerializedName = @"inconsistencyCount",
        PossibleTypes = new [] { typeof(long) })]
        long? RecentConsistencyReportInconsistencyCount { get; set; }
        /// <summary>The timestamp from when this consistency check was completed</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp from when this consistency check was completed",
        SerializedName = @"lastCheck",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RecentConsistencyReportLastCheck { get; set; }
        /// <summary>The result of the most recent consistency check available for this path</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The result of the most recent consistency check available for this path",
        SerializedName = @"result",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Support.ConsistencyResult) })]
        Wandisco.Fusion.Support.ConsistencyResult? RecentConsistencyReportResult { get; set; }
        /// <summary>The source zone for replication rule</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The source zone for replication rule",
        SerializedName = @"source",
        PossibleTypes = new [] { typeof(string) })]
        string Source { get; set; }
        /// <summary>Running state of the migration</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Running state of the migration",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Support.LiveMigrationState) })]
        Wandisco.Fusion.Support.LiveMigrationState? State { get; set; }
        /// <summary>The target zone for replication rule</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The target zone for replication rule",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get; set; }
        /// <summary>The list of zones the replication rule applies to.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of zones the replication rule applies to.",
        SerializedName = @"zoneNames",
        PossibleTypes = new [] { typeof(string) })]
        string[] ZoneNames { get; set; }

    }
    /// Properties of Created Rule Name
    internal partial interface IReplicationRulePropertiesInternal

    {
        /// <summary>
        /// Date after which migration should occur. Required if overwritePolicy is SkipIfDateIsEarlier.
        /// </summary>
        global::System.DateTime? DateAfterWhichToMigrate { get; set; }
        /// <summary>The most recent migration for the replication rule</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IMigration Migration { get; set; }
        /// <summary>Azure resource Id.</summary>
        string MigrationId { get; set; }
        /// <summary>Azure resource name.</summary>
        string MigrationName { get; set; }
        /// <summary>Migration properties</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IMigrationProperties MigrationProperties { get; set; }
        /// <summary>Azure resource type.</summary>
        string MigrationType { get; set; }
        /// <summary>The overwrite policy for migration Clobber|SkipIfSizeMatch|SkipIfDateIsEarlier</summary>
        Wandisco.Fusion.Support.LiveMigrationOverwritePolicy? OverwritePolicy { get; set; }
        /// <summary>
        /// The Filesystem Path to be used if a PathMapping is not defined for a certain zone.
        /// </summary>
        string Path { get; set; }
        /// <summary>Path Mapping for a Replication Rule</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IPathMapping[] PathMapping { get; set; }
        /// <summary>
        /// The Zone that takes precedence for a quorum in a scenario where there is an even number of zones and an equivalent amount
        /// of nodes are down in each zone
        /// </summary>
        string PriorityZone { get; set; }
        /// <summary>Migration status</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgress Progress { get; set; }
        /// <summary>Number of bytes excluded</summary>
        long? ProgressBytesExcluded { get; set; }
        /// <summary>Number of bytes to migrate</summary>
        long? ProgressBytesToMigrate { get; set; }
        /// <summary>Number of excluded directories</summary>
        long? ProgressDirsExcluded { get; set; }
        /// <summary>Number of directories scanned</summary>
        long? ProgressDirsSeen { get; set; }
        /// <summary>Number of directories to migrate</summary>
        long? ProgressDirsToMigrate { get; set; }
        /// <summary>Duration of migration</summary>
        long? ProgressDuration { get; set; }
        /// <summary>Number of excluded files</summary>
        long? ProgressFilesExcluded { get; set; }
        /// <summary>Number of files scanned</summary>
        long? ProgressFilesSeen { get; set; }
        /// <summary>Number of files to migrate</summary>
        long? ProgressFilesToMigrate { get; set; }
        /// <summary>Size of the migration</summary>
        long? ProgressSizeOfMigration { get; set; }
        /// <summary>Provisioning State of resource</summary>
        Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>A report of the most recent consistency check completed for this path</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReport RecentConsistencyReport { get; set; }
        /// <summary>
        /// The number of inconsistent files if the result of the consistency check is inconsistent
        /// </summary>
        long? RecentConsistencyReportInconsistencyCount { get; set; }
        /// <summary>The timestamp from when this consistency check was completed</summary>
        global::System.DateTime? RecentConsistencyReportLastCheck { get; set; }
        /// <summary>The result of the most recent consistency check available for this path</summary>
        Wandisco.Fusion.Support.ConsistencyResult? RecentConsistencyReportResult { get; set; }
        /// <summary>The source zone for replication rule</summary>
        string Source { get; set; }
        /// <summary>Running state of the migration</summary>
        Wandisco.Fusion.Support.LiveMigrationState? State { get; set; }
        /// <summary>The target zone for replication rule</summary>
        string Target { get; set; }
        /// <summary>The list of zones the replication rule applies to.</summary>
        string[] ZoneNames { get; set; }

    }
}