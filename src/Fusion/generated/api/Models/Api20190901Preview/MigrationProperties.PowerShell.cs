namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using Wandisco.Fusion.Runtime.PowerShell;

    /// <summary>Properties of fusion migration</summary>
    [System.ComponentModel.TypeConverter(typeof(MigrationPropertiesTypeConverter))]
    public partial class MigrationProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.MigrationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.IMigrationProperties" />.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IMigrationProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MigrationProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.MigrationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.IMigrationProperties" />.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IMigrationProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MigrationProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MigrationProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IMigrationProperties FromJsonString(string jsonText) => FromJson(Wandisco.Fusion.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.MigrationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MigrationProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).Progress = (Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgress) content.GetValueForProperty("Progress",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).Progress, Wandisco.Fusion.Models.Api20190901Preview.MigrationProgressTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).DateAfterWhichToMigrate = (global::System.DateTime?) content.GetValueForProperty("DateAfterWhichToMigrate",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).DateAfterWhichToMigrate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).OverwritePolicy = (Wandisco.Fusion.Support.LiveMigrationOverwritePolicy?) content.GetValueForProperty("OverwritePolicy",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).OverwritePolicy, Wandisco.Fusion.Support.LiveMigrationOverwritePolicy.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).Source = (string) content.GetValueForProperty("Source",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).Source, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).State = (Wandisco.Fusion.Support.LiveMigrationState?) content.GetValueForProperty("State",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).State, Wandisco.Fusion.Support.LiveMigrationState.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).Target = (string) content.GetValueForProperty("Target",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).Target, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressBytesExcluded = (long?) content.GetValueForProperty("ProgressBytesExcluded",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressBytesExcluded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressBytesToMigrate = (long?) content.GetValueForProperty("ProgressBytesToMigrate",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressBytesToMigrate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressDirsExcluded = (long?) content.GetValueForProperty("ProgressDirsExcluded",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressDirsExcluded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressDirsSeen = (long?) content.GetValueForProperty("ProgressDirsSeen",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressDirsSeen, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressDirsToMigrate = (long?) content.GetValueForProperty("ProgressDirsToMigrate",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressDirsToMigrate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressDuration = (long?) content.GetValueForProperty("ProgressDuration",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressDuration, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressFilesExcluded = (long?) content.GetValueForProperty("ProgressFilesExcluded",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressFilesExcluded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressFilesSeen = (long?) content.GetValueForProperty("ProgressFilesSeen",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressFilesSeen, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressFilesToMigrate = (long?) content.GetValueForProperty("ProgressFilesToMigrate",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressFilesToMigrate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressSizeOfMigration = (long?) content.GetValueForProperty("ProgressSizeOfMigration",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressSizeOfMigration, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.MigrationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MigrationProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).Progress = (Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgress) content.GetValueForProperty("Progress",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).Progress, Wandisco.Fusion.Models.Api20190901Preview.MigrationProgressTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).DateAfterWhichToMigrate = (global::System.DateTime?) content.GetValueForProperty("DateAfterWhichToMigrate",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).DateAfterWhichToMigrate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).OverwritePolicy = (Wandisco.Fusion.Support.LiveMigrationOverwritePolicy?) content.GetValueForProperty("OverwritePolicy",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).OverwritePolicy, Wandisco.Fusion.Support.LiveMigrationOverwritePolicy.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).Source = (string) content.GetValueForProperty("Source",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).Source, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).State = (Wandisco.Fusion.Support.LiveMigrationState?) content.GetValueForProperty("State",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).State, Wandisco.Fusion.Support.LiveMigrationState.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).Target = (string) content.GetValueForProperty("Target",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).Target, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressBytesExcluded = (long?) content.GetValueForProperty("ProgressBytesExcluded",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressBytesExcluded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressBytesToMigrate = (long?) content.GetValueForProperty("ProgressBytesToMigrate",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressBytesToMigrate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressDirsExcluded = (long?) content.GetValueForProperty("ProgressDirsExcluded",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressDirsExcluded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressDirsSeen = (long?) content.GetValueForProperty("ProgressDirsSeen",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressDirsSeen, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressDirsToMigrate = (long?) content.GetValueForProperty("ProgressDirsToMigrate",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressDirsToMigrate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressDuration = (long?) content.GetValueForProperty("ProgressDuration",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressDuration, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressFilesExcluded = (long?) content.GetValueForProperty("ProgressFilesExcluded",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressFilesExcluded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressFilesSeen = (long?) content.GetValueForProperty("ProgressFilesSeen",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressFilesSeen, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressFilesToMigrate = (long?) content.GetValueForProperty("ProgressFilesToMigrate",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressFilesToMigrate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressSizeOfMigration = (long?) content.GetValueForProperty("ProgressSizeOfMigration",((Wandisco.Fusion.Models.Api20190901Preview.IMigrationPropertiesInternal)this).ProgressSizeOfMigration, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Wandisco.Fusion.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Properties of fusion migration
    [System.ComponentModel.TypeConverter(typeof(MigrationPropertiesTypeConverter))]
    public partial interface IMigrationProperties

    {

    }
}