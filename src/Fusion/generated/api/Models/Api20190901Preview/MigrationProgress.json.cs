namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Status of fusion migration</summary>
    public partial class MigrationProgress
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Wandisco.Fusion.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Wandisco.Fusion.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Wandisco.Fusion.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Wandisco.Fusion.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Wandisco.Fusion.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode"/> into an instance of Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgress.
        /// </summary>
        /// <param name="node">a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgress.</returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgress FromJson(Wandisco.Fusion.Runtime.Json.JsonNode node)
        {
            return node is Wandisco.Fusion.Runtime.Json.JsonObject json ? new MigrationProgress(json) : null;
        }

        /// <summary>
        /// Deserializes a Wandisco.Fusion.Runtime.Json.JsonObject into a new instance of <see cref="MigrationProgress" />.
        /// </summary>
        /// <param name="json">A Wandisco.Fusion.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MigrationProgress(Wandisco.Fusion.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_bytesExcluded = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonNumber>("bytesExcluded"), out var __jsonBytesExcluded) ? (long?)__jsonBytesExcluded : BytesExcluded;}
            {_bytesToMigrate = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonNumber>("bytesToMigrate"), out var __jsonBytesToMigrate) ? (long?)__jsonBytesToMigrate : BytesToMigrate;}
            {_dirsExcluded = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonNumber>("dirsExcluded"), out var __jsonDirsExcluded) ? (long?)__jsonDirsExcluded : DirsExcluded;}
            {_dirsSeen = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonNumber>("dirsSeen"), out var __jsonDirsSeen) ? (long?)__jsonDirsSeen : DirsSeen;}
            {_dirsToMigrate = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonNumber>("dirsToMigrate"), out var __jsonDirsToMigrate) ? (long?)__jsonDirsToMigrate : DirsToMigrate;}
            {_duration = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonNumber>("duration"), out var __jsonDuration) ? (long?)__jsonDuration : Duration;}
            {_filesExcluded = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonNumber>("filesExcluded"), out var __jsonFilesExcluded) ? (long?)__jsonFilesExcluded : FilesExcluded;}
            {_filesSeen = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonNumber>("filesSeen"), out var __jsonFilesSeen) ? (long?)__jsonFilesSeen : FilesSeen;}
            {_filesToMigrate = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonNumber>("filesToMigrate"), out var __jsonFilesToMigrate) ? (long?)__jsonFilesToMigrate : FilesToMigrate;}
            {_sizeOfMigration = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonNumber>("sizeOfMigration"), out var __jsonSizeOfMigration) ? (long?)__jsonSizeOfMigration : SizeOfMigration;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="MigrationProgress" /> into a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Wandisco.Fusion.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Wandisco.Fusion.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MigrationProgress" /> as a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode" />.
        /// </returns>
        public Wandisco.Fusion.Runtime.Json.JsonNode ToJson(Wandisco.Fusion.Runtime.Json.JsonObject container, Wandisco.Fusion.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Wandisco.Fusion.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._bytesExcluded ? (Wandisco.Fusion.Runtime.Json.JsonNode)new Wandisco.Fusion.Runtime.Json.JsonNumber((long)this._bytesExcluded) : null, "bytesExcluded" ,container.Add );
            AddIf( null != this._bytesToMigrate ? (Wandisco.Fusion.Runtime.Json.JsonNode)new Wandisco.Fusion.Runtime.Json.JsonNumber((long)this._bytesToMigrate) : null, "bytesToMigrate" ,container.Add );
            AddIf( null != this._dirsExcluded ? (Wandisco.Fusion.Runtime.Json.JsonNode)new Wandisco.Fusion.Runtime.Json.JsonNumber((long)this._dirsExcluded) : null, "dirsExcluded" ,container.Add );
            AddIf( null != this._dirsSeen ? (Wandisco.Fusion.Runtime.Json.JsonNode)new Wandisco.Fusion.Runtime.Json.JsonNumber((long)this._dirsSeen) : null, "dirsSeen" ,container.Add );
            AddIf( null != this._dirsToMigrate ? (Wandisco.Fusion.Runtime.Json.JsonNode)new Wandisco.Fusion.Runtime.Json.JsonNumber((long)this._dirsToMigrate) : null, "dirsToMigrate" ,container.Add );
            AddIf( null != this._duration ? (Wandisco.Fusion.Runtime.Json.JsonNode)new Wandisco.Fusion.Runtime.Json.JsonNumber((long)this._duration) : null, "duration" ,container.Add );
            AddIf( null != this._filesExcluded ? (Wandisco.Fusion.Runtime.Json.JsonNode)new Wandisco.Fusion.Runtime.Json.JsonNumber((long)this._filesExcluded) : null, "filesExcluded" ,container.Add );
            AddIf( null != this._filesSeen ? (Wandisco.Fusion.Runtime.Json.JsonNode)new Wandisco.Fusion.Runtime.Json.JsonNumber((long)this._filesSeen) : null, "filesSeen" ,container.Add );
            AddIf( null != this._filesToMigrate ? (Wandisco.Fusion.Runtime.Json.JsonNode)new Wandisco.Fusion.Runtime.Json.JsonNumber((long)this._filesToMigrate) : null, "filesToMigrate" ,container.Add );
            AddIf( null != this._sizeOfMigration ? (Wandisco.Fusion.Runtime.Json.JsonNode)new Wandisco.Fusion.Runtime.Json.JsonNumber((long)this._sizeOfMigration) : null, "sizeOfMigration" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}