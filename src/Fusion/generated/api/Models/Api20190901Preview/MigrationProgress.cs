namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Status of fusion migration</summary>
    public partial class MigrationProgress :
        Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgress,
        Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal
    {

        /// <summary>Backing field for <see cref="BytesExcluded" /> property.</summary>
        private long? _bytesExcluded;

        /// <summary>Number of bytes excluded</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public long? BytesExcluded { get => this._bytesExcluded; set => this._bytesExcluded = value; }

        /// <summary>Backing field for <see cref="BytesToMigrate" /> property.</summary>
        private long? _bytesToMigrate;

        /// <summary>Number of bytes to migrate</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public long? BytesToMigrate { get => this._bytesToMigrate; set => this._bytesToMigrate = value; }

        /// <summary>Backing field for <see cref="DirsExcluded" /> property.</summary>
        private long? _dirsExcluded;

        /// <summary>Number of excluded directories</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public long? DirsExcluded { get => this._dirsExcluded; set => this._dirsExcluded = value; }

        /// <summary>Backing field for <see cref="DirsSeen" /> property.</summary>
        private long? _dirsSeen;

        /// <summary>Number of directories scanned</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public long? DirsSeen { get => this._dirsSeen; set => this._dirsSeen = value; }

        /// <summary>Backing field for <see cref="DirsToMigrate" /> property.</summary>
        private long? _dirsToMigrate;

        /// <summary>Number of directories to migrate</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public long? DirsToMigrate { get => this._dirsToMigrate; set => this._dirsToMigrate = value; }

        /// <summary>Backing field for <see cref="Duration" /> property.</summary>
        private long? _duration;

        /// <summary>Duration of migration</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public long? Duration { get => this._duration; set => this._duration = value; }

        /// <summary>Backing field for <see cref="FilesExcluded" /> property.</summary>
        private long? _filesExcluded;

        /// <summary>Number of excluded files</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public long? FilesExcluded { get => this._filesExcluded; set => this._filesExcluded = value; }

        /// <summary>Backing field for <see cref="FilesSeen" /> property.</summary>
        private long? _filesSeen;

        /// <summary>Number of files scanned</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public long? FilesSeen { get => this._filesSeen; set => this._filesSeen = value; }

        /// <summary>Backing field for <see cref="FilesToMigrate" /> property.</summary>
        private long? _filesToMigrate;

        /// <summary>Number of files to migrate</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public long? FilesToMigrate { get => this._filesToMigrate; set => this._filesToMigrate = value; }

        /// <summary>Backing field for <see cref="SizeOfMigration" /> property.</summary>
        private long? _sizeOfMigration;

        /// <summary>Size of the migration</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public long? SizeOfMigration { get => this._sizeOfMigration; set => this._sizeOfMigration = value; }

        /// <summary>Creates an new <see cref="MigrationProgress" /> instance.</summary>
        public MigrationProgress()
        {

        }
    }
    /// Status of fusion migration
    public partial interface IMigrationProgress :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>Number of bytes excluded</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of bytes excluded",
        SerializedName = @"bytesExcluded",
        PossibleTypes = new [] { typeof(long) })]
        long? BytesExcluded { get; set; }
        /// <summary>Number of bytes to migrate</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of bytes to migrate",
        SerializedName = @"bytesToMigrate",
        PossibleTypes = new [] { typeof(long) })]
        long? BytesToMigrate { get; set; }
        /// <summary>Number of excluded directories</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of excluded directories",
        SerializedName = @"dirsExcluded",
        PossibleTypes = new [] { typeof(long) })]
        long? DirsExcluded { get; set; }
        /// <summary>Number of directories scanned</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of directories scanned",
        SerializedName = @"dirsSeen",
        PossibleTypes = new [] { typeof(long) })]
        long? DirsSeen { get; set; }
        /// <summary>Number of directories to migrate</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of directories to migrate",
        SerializedName = @"dirsToMigrate",
        PossibleTypes = new [] { typeof(long) })]
        long? DirsToMigrate { get; set; }
        /// <summary>Duration of migration</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Duration of migration",
        SerializedName = @"duration",
        PossibleTypes = new [] { typeof(long) })]
        long? Duration { get; set; }
        /// <summary>Number of excluded files</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of excluded files",
        SerializedName = @"filesExcluded",
        PossibleTypes = new [] { typeof(long) })]
        long? FilesExcluded { get; set; }
        /// <summary>Number of files scanned</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of files scanned",
        SerializedName = @"filesSeen",
        PossibleTypes = new [] { typeof(long) })]
        long? FilesSeen { get; set; }
        /// <summary>Number of files to migrate</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of files to migrate",
        SerializedName = @"filesToMigrate",
        PossibleTypes = new [] { typeof(long) })]
        long? FilesToMigrate { get; set; }
        /// <summary>Size of the migration</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Size of the migration",
        SerializedName = @"sizeOfMigration",
        PossibleTypes = new [] { typeof(long) })]
        long? SizeOfMigration { get; set; }

    }
    /// Status of fusion migration
    internal partial interface IMigrationProgressInternal

    {
        /// <summary>Number of bytes excluded</summary>
        long? BytesExcluded { get; set; }
        /// <summary>Number of bytes to migrate</summary>
        long? BytesToMigrate { get; set; }
        /// <summary>Number of excluded directories</summary>
        long? DirsExcluded { get; set; }
        /// <summary>Number of directories scanned</summary>
        long? DirsSeen { get; set; }
        /// <summary>Number of directories to migrate</summary>
        long? DirsToMigrate { get; set; }
        /// <summary>Duration of migration</summary>
        long? Duration { get; set; }
        /// <summary>Number of excluded files</summary>
        long? FilesExcluded { get; set; }
        /// <summary>Number of files scanned</summary>
        long? FilesSeen { get; set; }
        /// <summary>Number of files to migrate</summary>
        long? FilesToMigrate { get; set; }
        /// <summary>Size of the migration</summary>
        long? SizeOfMigration { get; set; }

    }
}