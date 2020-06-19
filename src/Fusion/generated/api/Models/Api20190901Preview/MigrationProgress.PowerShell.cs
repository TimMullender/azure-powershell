namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using Wandisco.Fusion.Runtime.PowerShell;

    /// <summary>Status of fusion migration</summary>
    [System.ComponentModel.TypeConverter(typeof(MigrationProgressTypeConverter))]
    public partial class MigrationProgress
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.MigrationProgress"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgress" />.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgress DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MigrationProgress(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.MigrationProgress"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgress" />.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgress DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MigrationProgress(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MigrationProgress" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgress FromJsonString(string jsonText) => FromJson(Wandisco.Fusion.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.MigrationProgress"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MigrationProgress(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).BytesExcluded = (long?) content.GetValueForProperty("BytesExcluded",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).BytesExcluded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).BytesToMigrate = (long?) content.GetValueForProperty("BytesToMigrate",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).BytesToMigrate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).DirsExcluded = (long?) content.GetValueForProperty("DirsExcluded",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).DirsExcluded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).DirsSeen = (long?) content.GetValueForProperty("DirsSeen",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).DirsSeen, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).DirsToMigrate = (long?) content.GetValueForProperty("DirsToMigrate",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).DirsToMigrate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).Duration = (long?) content.GetValueForProperty("Duration",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).Duration, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).FilesExcluded = (long?) content.GetValueForProperty("FilesExcluded",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).FilesExcluded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).FilesSeen = (long?) content.GetValueForProperty("FilesSeen",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).FilesSeen, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).FilesToMigrate = (long?) content.GetValueForProperty("FilesToMigrate",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).FilesToMigrate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).SizeOfMigration = (long?) content.GetValueForProperty("SizeOfMigration",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).SizeOfMigration, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.MigrationProgress"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MigrationProgress(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).BytesExcluded = (long?) content.GetValueForProperty("BytesExcluded",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).BytesExcluded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).BytesToMigrate = (long?) content.GetValueForProperty("BytesToMigrate",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).BytesToMigrate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).DirsExcluded = (long?) content.GetValueForProperty("DirsExcluded",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).DirsExcluded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).DirsSeen = (long?) content.GetValueForProperty("DirsSeen",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).DirsSeen, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).DirsToMigrate = (long?) content.GetValueForProperty("DirsToMigrate",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).DirsToMigrate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).Duration = (long?) content.GetValueForProperty("Duration",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).Duration, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).FilesExcluded = (long?) content.GetValueForProperty("FilesExcluded",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).FilesExcluded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).FilesSeen = (long?) content.GetValueForProperty("FilesSeen",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).FilesSeen, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).FilesToMigrate = (long?) content.GetValueForProperty("FilesToMigrate",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).FilesToMigrate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).SizeOfMigration = (long?) content.GetValueForProperty("SizeOfMigration",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgressInternal)this).SizeOfMigration, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Wandisco.Fusion.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Status of fusion migration
    [System.ComponentModel.TypeConverter(typeof(MigrationProgressTypeConverter))]
    public partial interface IMigrationProgress

    {

    }
}