namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Properties of fusion migration</summary>
    public partial class MigrationProperties :
        Wandisco.Fusion.Models.Api20190901Preview.IMigrationProperties,
        Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DateAfterWhichToMigrate" /> property.</summary>
        private global::System.DateTime? _dateAfterWhichToMigrate;

        /// <summary>
        /// Date after which migration should occur. Required if overwritePolicy is SkipIfDateIsEarlier.
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public global::System.DateTime? DateAfterWhichToMigrate { get => this._dateAfterWhichToMigrate; set => this._dateAfterWhichToMigrate = value; }

        /// <summary>Backing field for <see cref="OverwritePolicy" /> property.</summary>
        private Wandisco.Fusion.Support.LiveMigrationOverwritePolicy? _overwritePolicy;

        /// <summary>The overwrite policy for migration Clobber|SkipIfSizeMatch|SkipIfDateIsEarlier</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Support.LiveMigrationOverwritePolicy? OverwritePolicy { get => this._overwritePolicy; set => this._overwritePolicy = value; }

        /// <summary>Backing field for <see cref="Progress" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgress _progress;

        /// <summary>Migration status</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        internal Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgress Progress { get => (this._progress = this._progress ?? new Wandisco.Fusion.Models.Api20190901Preview.MigrationProgress()); set => this._progress = value; }

        /// <summary>Number of bytes excluded</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressBytesExcluded { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)Progress).BytesExcluded; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)Progress).BytesExcluded = value; }

        /// <summary>Number of bytes to migrate</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressBytesToMigrate { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)Progress).BytesToMigrate; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)Progress).BytesToMigrate = value; }

        /// <summary>Number of excluded directories</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressDirsExcluded { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)Progress).DirsExcluded; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)Progress).DirsExcluded = value; }

        /// <summary>Number of directories scanned</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressDirsSeen { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)Progress).DirsSeen; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)Progress).DirsSeen = value; }

        /// <summary>Number of directories to migrate</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressDirsToMigrate { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)Progress).DirsToMigrate; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)Progress).DirsToMigrate = value; }

        /// <summary>Duration of migration</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressDuration { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)Progress).Duration; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)Progress).Duration = value; }

        /// <summary>Number of excluded files</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressFilesExcluded { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)Progress).FilesExcluded; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)Progress).FilesExcluded = value; }

        /// <summary>Number of files scanned</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressFilesSeen { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)Progress).FilesSeen; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)Progress).FilesSeen = value; }

        /// <summary>Number of files to migrate</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressFilesToMigrate { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)Progress).FilesToMigrate; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)Progress).FilesToMigrate = value; }

        /// <summary>Size of the migration</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? ProgressSizeOfMigration { get => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)Progress).SizeOfMigration; set => ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)Progress).SizeOfMigration = value; }

        /// <summary>Backing field for <see cref="Source" /> property.</summary>
        private string _source;

        /// <summary>The source zone for replication rule</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Source { get => this._source; set => this._source = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private Wandisco.Fusion.Support.LiveMigrationState? _state;

        /// <summary>Running state of the migration</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Support.LiveMigrationState? State { get => this._state; set => this._state = value; }

        /// <summary>Backing field for <see cref="Target" /> property.</summary>
        private string _target;

        /// <summary>The target zone for replication rule</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Target { get => this._target; set => this._target = value; }

        /// <summary>Internal Acessors for Progress</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgress Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal.Progress { get => (this._progress = this._progress ?? new Wandisco.Fusion.Models.Api20190901Preview.MigrationProgress()); set { {_progress = value;} } }

        /// <summary>Creates an new <see cref="MigrationProperties" /> instance.</summary>
        public MigrationProperties()
        {

        }
    }
    /// Properties of fusion migration
    public partial interface IMigrationProperties :
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
    /// Properties of fusion migration
    internal partial interface IMigrationPropertiesInternal

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
        /// <summary>The source zone for replication rule</summary>
        string Source { get; set; }
        /// <summary>Running state of the migration</summary>
        Wandisco.Fusion.Support.LiveMigrationState? State { get; set; }
        /// <summary>The target zone for replication rule</summary>
        string Target { get; set; }

    }
}