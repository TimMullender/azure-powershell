namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Instance of a fusion migration</summary>
    public partial class Migration :
        Wandisco.Fusion.Models.Api20190901Preview.IMigration,
        Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal,
        Wandisco.Fusion.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Wandisco.Fusion.Models.Api20190901Preview.IProxyResource" />
        /// </summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IProxyResource __proxyResource = new Wandisco.Fusion.Models.Api20190901Preview.ProxyResource();

        /// <summary>
        /// Date after which migration should occur. Required if overwritePolicy is SkipIfDateIsEarlier.
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public global::System.DateTime? DateAfterWhichToMigrate { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).DateAfterWhichToMigrate; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).DateAfterWhichToMigrate = value; }

        /// <summary>Azure resource Id.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string Id { get => ((Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal)__proxyResource).Id; }

        /// <summary>Azure resource name.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string Name { get => ((Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal)__proxyResource).Name; }

        /// <summary>The overwrite policy for migration Clobber|SkipIfSizeMatch|SkipIfDateIsEarlier</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Support.LiveMigrationOverwritePolicy? OverwritePolicy { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).OverwritePolicy; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).OverwritePolicy = value; }

        /// <summary>Number of bytes excluded</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressBytesExcluded { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).ProgressBytesExcluded; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).ProgressBytesExcluded = value; }

        /// <summary>Number of bytes to migrate</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressBytesToMigrate { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).ProgressBytesToMigrate; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).ProgressBytesToMigrate = value; }

        /// <summary>Number of excluded directories</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressDirsExcluded { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).ProgressDirsExcluded; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).ProgressDirsExcluded = value; }

        /// <summary>Number of directories scanned</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressDirsSeen { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).ProgressDirsSeen; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).ProgressDirsSeen = value; }

        /// <summary>Number of directories to migrate</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressDirsToMigrate { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).ProgressDirsToMigrate; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).ProgressDirsToMigrate = value; }

        /// <summary>Duration of migration</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressDuration { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).ProgressDuration; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).ProgressDuration = value; }

        /// <summary>Number of excluded files</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressFilesExcluded { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).ProgressFilesExcluded; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).ProgressFilesExcluded = value; }

        /// <summary>Number of files scanned</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressFilesSeen { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).ProgressFilesSeen; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).ProgressFilesSeen = value; }

        /// <summary>Number of files to migrate</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressFilesToMigrate { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).ProgressFilesToMigrate; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).ProgressFilesToMigrate = value; }

        /// <summary>Size of the migration</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressSizeOfMigration { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).ProgressSizeOfMigration; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).ProgressSizeOfMigration = value; }

        /// <summary>Backing field for <see cref="Properties" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IMigrationProperties _properties;

        /// <summary>Migration properties</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        internal Wandisco.Fusion.Models.Api20190901Preview.IMigrationProperties Properties { get => (this._properties = this._properties ?? new Wandisco.Fusion.Models.Api20190901Preview.MigrationProperties()); set => this._properties = value; }

        /// <summary>The source zone for replication rule</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string Source { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).Source; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).Source = value; }

        /// <summary>Running state of the migration</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Support.LiveMigrationState? State { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).State; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).State = value; }

        /// <summary>The target zone for replication rule</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string Target { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).Target; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).Target = value; }

        /// <summary>Azure resource type.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string Type { get => ((Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal)__proxyResource).Type; }

        /// <summary>Internal Acessors for Progress</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgress Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal.Progress { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).Progress; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)Properties).Progress = value; }

        /// <summary>Internal Acessors for Properties</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IMigrationProperties Wandisco.Fusion.Models.Api20190901Preview.IMigrationInternal.Properties { get => (this._properties = this._properties ?? new Wandisco.Fusion.Models.Api20190901Preview.MigrationProperties()); set { {_properties = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal.Id { get => ((Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal)__proxyResource).Id; set => ((Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal)__proxyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal.Name { get => ((Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal)__proxyResource).Name; set => ((Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal)__proxyResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal.Type { get => ((Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal)__proxyResource).Type; set => ((Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal)__proxyResource).Type = value; }

        /// <summary>Creates an new <see cref="Migration" /> instance.</summary>
        public Migration()
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
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// Instance of a fusion migration
    public partial interface IMigration :
        Wandisco.Fusion.Runtime.IJsonSerializable,
        Wandisco.Fusion.Models.Api20190901Preview.IProxyResource
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
        /// <summary>The overwrite policy for migration Clobber|SkipIfSizeMatch|SkipIfDateIsEarlier</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The overwrite policy for migration Clobber|SkipIfSizeMatch|SkipIfDateIsEarlier",
        SerializedName = @"overwritePolicy",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Support.LiveMigrationOverwritePolicy) })]
        Wandisco.Fusion.Support.LiveMigrationOverwritePolicy? OverwritePolicy { get; set; }
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

    }
    /// Instance of a fusion migration
    internal partial interface IMigrationInternal :
        Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal
    {
        /// <summary>
        /// Date after which migration should occur. Required if overwritePolicy is SkipIfDateIsEarlier.
        /// </summary>
        global::System.DateTime? DateAfterWhichToMigrate { get; set; }
        /// <summary>The overwrite policy for migration Clobber|SkipIfSizeMatch|SkipIfDateIsEarlier</summary>
        Wandisco.Fusion.Support.LiveMigrationOverwritePolicy? OverwritePolicy { get; set; }
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
        /// <summary>Migration properties</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IMigrationProperties Properties { get; set; }
        /// <summary>The source zone for replication rule</summary>
        string Source { get; set; }
        /// <summary>Running state of the migration</summary>
        Wandisco.Fusion.Support.LiveMigrationState? State { get; set; }
        /// <summary>The target zone for replication rule</summary>
        string Target { get; set; }

    }
}