namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Replication Rule</summary>
    public partial class ReplicationRule :
        Wandisco.Fusion.Models.Api20190901Preview.IReplicationRule,
        Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal,
        Wandisco.Fusion.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Wandisco.Fusion.Models.Api20190901Preview.IResource" />
        /// </summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IResource __resource = new Wandisco.Fusion.Models.Api20190901Preview.Resource();

        /// <summary>
        /// Date after which migration should occur. Required if overwritePolicy is SkipIfDateIsEarlier.
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public global::System.DateTime? DateAfterWhichToMigrate { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).DateAfterWhichToMigrate; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).DateAfterWhichToMigrate = value; }

        /// <summary>Azure resource Id.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string Id { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Id; }

        /// <summary>Location of the resource.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string Location { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Location; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Location = value; }

        /// <summary>Azure resource Id.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string MigrationId { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).MigrationId; }

        /// <summary>Azure resource name.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string MigrationName { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).MigrationName; }

        /// <summary>Azure resource type.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string MigrationType { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).MigrationType; }

        /// <summary>Azure resource name.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string Name { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Name; }

        /// <summary>The overwrite policy for migration Clobber|SkipIfSizeMatch|SkipIfDateIsEarlier</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Support.LiveMigrationOverwritePolicy? OverwritePolicy { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).OverwritePolicy; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).OverwritePolicy = value; }

        /// <summary>
        /// The Filesystem Path to be used if a PathMapping is not defined for a certain zone.
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string Path { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).Path; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).Path = value; }

        /// <summary>Path Mapping for a Replication Rule</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Models.Api20190901Preview.IPathMapping[] PathMapping { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).PathMapping; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).PathMapping = value; }

        /// <summary>
        /// The Zone that takes precedence for a quorum in a scenario where there is an even number of zones and an equivalent amount
        /// of nodes are down in each zone
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string PriorityZone { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).PriorityZone; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).PriorityZone = value; }

        /// <summary>Number of bytes excluded</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressBytesExcluded { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ProgressBytesExcluded; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ProgressBytesExcluded = value; }

        /// <summary>Number of bytes to migrate</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressBytesToMigrate { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ProgressBytesToMigrate; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ProgressBytesToMigrate = value; }

        /// <summary>Number of excluded directories</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressDirsExcluded { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ProgressDirsExcluded; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ProgressDirsExcluded = value; }

        /// <summary>Number of directories scanned</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressDirsSeen { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ProgressDirsSeen; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ProgressDirsSeen = value; }

        /// <summary>Number of directories to migrate</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressDirsToMigrate { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ProgressDirsToMigrate; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ProgressDirsToMigrate = value; }

        /// <summary>Duration of migration</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressDuration { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ProgressDuration; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ProgressDuration = value; }

        /// <summary>Number of excluded files</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressFilesExcluded { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ProgressFilesExcluded; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ProgressFilesExcluded = value; }

        /// <summary>Number of files scanned</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressFilesSeen { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ProgressFilesSeen; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ProgressFilesSeen = value; }

        /// <summary>Number of files to migrate</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressFilesToMigrate { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ProgressFilesToMigrate; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ProgressFilesToMigrate = value; }

        /// <summary>Size of the migration</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressSizeOfMigration { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ProgressSizeOfMigration; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ProgressSizeOfMigration = value; }

        /// <summary>Backing field for <see cref="Properties" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleProperties _properties;

        /// <summary>replication rule properties</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        internal Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleProperties Properties { get => (this._properties = this._properties ?? new Wandisco.Fusion.Models.Api20190901Preview.ReplicationRuleProperties()); set => this._properties = value; }

        /// <summary>Provisioning State of resource</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ProvisioningState; }

        /// <summary>
        /// The number of inconsistent files if the result of the consistency check is inconsistent
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? RecentConsistencyReportInconsistencyCount { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).RecentConsistencyReportInconsistencyCount; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).RecentConsistencyReportInconsistencyCount = value; }

        /// <summary>The timestamp from when this consistency check was completed</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public global::System.DateTime? RecentConsistencyReportLastCheck { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).RecentConsistencyReportLastCheck; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).RecentConsistencyReportLastCheck = value; }

        /// <summary>The result of the most recent consistency check available for this path</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Support.ConsistencyResult? RecentConsistencyReportResult { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).RecentConsistencyReportResult; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).RecentConsistencyReportResult = value; }

        /// <summary>The source zone for replication rule</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string Source { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).Source; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).Source = value; }

        /// <summary>Running state of the migration</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Support.LiveMigrationState? State { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).State; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).State = value; }

        /// <summary>resource tags.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public Wandisco.Fusion.Models.Api20190901Preview.IResourceTags Tags { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Tags; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Tags = value; }

        /// <summary>The target zone for replication rule</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string Target { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).Target; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).Target = value; }

        /// <summary>Azure resource type.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string Type { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Type; }

        /// <summary>Internal Acessors for Migration</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IMigration Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal.Migration { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).Migration; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).Migration = value; }

        /// <summary>Internal Acessors for MigrationId</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal.MigrationId { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).MigrationId; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).MigrationId = value; }

        /// <summary>Internal Acessors for MigrationName</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal.MigrationName { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).MigrationName; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).MigrationName = value; }

        /// <summary>Internal Acessors for MigrationProperties</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IMigrationProperties Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal.MigrationProperties { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).MigrationProperties; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).MigrationProperties = value; }

        /// <summary>Internal Acessors for MigrationType</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal.MigrationType { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).MigrationType; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).MigrationType = value; }

        /// <summary>Internal Acessors for Progress</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgress Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal.Progress { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).Progress; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).Progress = value; }

        /// <summary>Internal Acessors for Properties</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleProperties Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal.Properties { get => (this._properties = this._properties ?? new Wandisco.Fusion.Models.Api20190901Preview.ReplicationRuleProperties()); set { {_properties = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Wandisco.Fusion.Support.ProvisioningState? Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal.ProvisioningState { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ProvisioningState; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ProvisioningState = value; }

        /// <summary>Internal Acessors for RecentConsistencyReport</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReport Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal.RecentConsistencyReport { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).RecentConsistencyReport; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).RecentConsistencyReport = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal.Id { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Id; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal.Name { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Name; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal.Type { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Type; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Type = value; }

        /// <summary>The list of zones the replication rule applies to.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string[] ZoneNames { get => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ZoneNames; set => ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRulePropertiesInternal)Properties).ZoneNames = value; }

        /// <summary>Creates an new <see cref="ReplicationRule" /> instance.</summary>
        public ReplicationRule()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Wandisco.Fusion.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Wandisco.Fusion.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Replication Rule
    public partial interface IReplicationRule :
        Wandisco.Fusion.Runtime.IJsonSerializable,
        Wandisco.Fusion.Models.Api20190901Preview.IResource
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
    /// Replication Rule
    internal partial interface IReplicationRuleInternal :
        Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal
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
        /// <summary>replication rule properties</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleProperties Properties { get; set; }
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