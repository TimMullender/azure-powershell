namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using Wandisco.Fusion.Runtime.PowerShell;

    /// <summary>Replication Rule</summary>
    [System.ComponentModel.TypeConverter(typeof(ReplicationRuleTypeConverter))]
    public partial class ReplicationRule
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.ReplicationRule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.IReplicationRule" />.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IReplicationRule DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ReplicationRule(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.ReplicationRule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.IReplicationRule" />.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IReplicationRule DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ReplicationRule(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ReplicationRule" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IReplicationRule FromJsonString(string jsonText) => FromJson(Wandisco.Fusion.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.ReplicationRule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ReplicationRule(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).Properties = (Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleProperties) content.GetValueForProperty("Properties",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).Properties, Wandisco.Fusion.Models.Api20190901Preview.ReplicationRulePropertiesTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Tags = (Wandisco.Fusion.Models.Api20190901Preview.IResourceTags) content.GetValueForProperty("Tags",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Tags, Wandisco.Fusion.Models.Api20190901Preview.ResourceTagsTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).Migration = (Wandisco.Fusion.Models.Api20190901Preview.IMigration) content.GetValueForProperty("Migration",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).Migration, Wandisco.Fusion.Models.Api20190901Preview.MigrationTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProvisioningState = (Wandisco.Fusion.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProvisioningState, Wandisco.Fusion.Support.ProvisioningState.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).Path = (string) content.GetValueForProperty("Path",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).Path, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).PathMapping = (Wandisco.Fusion.Models.Api20190901Preview.IPathMapping[]) content.GetValueForProperty("PathMapping",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).PathMapping, __y => TypeConverterExtensions.SelectToArray<Wandisco.Fusion.Models.Api20190901Preview.IPathMapping>(__y, Wandisco.Fusion.Models.Api20190901Preview.PathMappingTypeConverter.ConvertFrom));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).PriorityZone = (string) content.GetValueForProperty("PriorityZone",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).PriorityZone, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ZoneNames = (string[]) content.GetValueForProperty("ZoneNames",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ZoneNames, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).MigrationProperties = (Wandisco.Fusion.Models.Api20190901Preview.IMigrationProperties) content.GetValueForProperty("MigrationProperties",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).MigrationProperties, Wandisco.Fusion.Models.Api20190901Preview.MigrationPropertiesTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).RecentConsistencyReport = (Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReport) content.GetValueForProperty("RecentConsistencyReport",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).RecentConsistencyReport, Wandisco.Fusion.Models.Api20190901Preview.ConsistencyReportTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).MigrationName = (string) content.GetValueForProperty("MigrationName",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).MigrationName, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).MigrationId = (string) content.GetValueForProperty("MigrationId",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).MigrationId, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).RecentConsistencyReportResult = (Wandisco.Fusion.Support.ConsistencyResult?) content.GetValueForProperty("RecentConsistencyReportResult",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).RecentConsistencyReportResult, Wandisco.Fusion.Support.ConsistencyResult.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).RecentConsistencyReportLastCheck = (global::System.DateTime?) content.GetValueForProperty("RecentConsistencyReportLastCheck",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).RecentConsistencyReportLastCheck, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).RecentConsistencyReportInconsistencyCount = (long?) content.GetValueForProperty("RecentConsistencyReportInconsistencyCount",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).RecentConsistencyReportInconsistencyCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).Source = (string) content.GetValueForProperty("Source",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).Source, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).MigrationType = (string) content.GetValueForProperty("MigrationType",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).MigrationType, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).Target = (string) content.GetValueForProperty("Target",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).Target, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).DateAfterWhichToMigrate = (global::System.DateTime?) content.GetValueForProperty("DateAfterWhichToMigrate",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).DateAfterWhichToMigrate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).OverwritePolicy = (Wandisco.Fusion.Support.LiveMigrationOverwritePolicy?) content.GetValueForProperty("OverwritePolicy",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).OverwritePolicy, Wandisco.Fusion.Support.LiveMigrationOverwritePolicy.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).Progress = (Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgress) content.GetValueForProperty("Progress",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).Progress, Wandisco.Fusion.Models.Api20190901Preview.MigrationProgressTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).State = (Wandisco.Fusion.Support.LiveMigrationState?) content.GetValueForProperty("State",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).State, Wandisco.Fusion.Support.LiveMigrationState.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressDirsSeen = (long?) content.GetValueForProperty("ProgressDirsSeen",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressDirsSeen, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressDirsToMigrate = (long?) content.GetValueForProperty("ProgressDirsToMigrate",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressDirsToMigrate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressDuration = (long?) content.GetValueForProperty("ProgressDuration",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressDuration, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressFilesExcluded = (long?) content.GetValueForProperty("ProgressFilesExcluded",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressFilesExcluded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressFilesSeen = (long?) content.GetValueForProperty("ProgressFilesSeen",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressFilesSeen, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressFilesToMigrate = (long?) content.GetValueForProperty("ProgressFilesToMigrate",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressFilesToMigrate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressDirsExcluded = (long?) content.GetValueForProperty("ProgressDirsExcluded",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressDirsExcluded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressBytesToMigrate = (long?) content.GetValueForProperty("ProgressBytesToMigrate",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressBytesToMigrate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressSizeOfMigration = (long?) content.GetValueForProperty("ProgressSizeOfMigration",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressSizeOfMigration, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressBytesExcluded = (long?) content.GetValueForProperty("ProgressBytesExcluded",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressBytesExcluded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.ReplicationRule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ReplicationRule(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).Properties = (Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleProperties) content.GetValueForProperty("Properties",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).Properties, Wandisco.Fusion.Models.Api20190901Preview.ReplicationRulePropertiesTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Tags = (Wandisco.Fusion.Models.Api20190901Preview.IResourceTags) content.GetValueForProperty("Tags",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Tags, Wandisco.Fusion.Models.Api20190901Preview.ResourceTagsTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).Migration = (Wandisco.Fusion.Models.Api20190901Preview.IMigration) content.GetValueForProperty("Migration",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).Migration, Wandisco.Fusion.Models.Api20190901Preview.MigrationTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProvisioningState = (Wandisco.Fusion.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProvisioningState, Wandisco.Fusion.Support.ProvisioningState.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).Path = (string) content.GetValueForProperty("Path",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).Path, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).PathMapping = (Wandisco.Fusion.Models.Api20190901Preview.IPathMapping[]) content.GetValueForProperty("PathMapping",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).PathMapping, __y => TypeConverterExtensions.SelectToArray<Wandisco.Fusion.Models.Api20190901Preview.IPathMapping>(__y, Wandisco.Fusion.Models.Api20190901Preview.PathMappingTypeConverter.ConvertFrom));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).PriorityZone = (string) content.GetValueForProperty("PriorityZone",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).PriorityZone, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ZoneNames = (string[]) content.GetValueForProperty("ZoneNames",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ZoneNames, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).MigrationProperties = (Wandisco.Fusion.Models.Api20190901Preview.IMigrationProperties) content.GetValueForProperty("MigrationProperties",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).MigrationProperties, Wandisco.Fusion.Models.Api20190901Preview.MigrationPropertiesTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).RecentConsistencyReport = (Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReport) content.GetValueForProperty("RecentConsistencyReport",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).RecentConsistencyReport, Wandisco.Fusion.Models.Api20190901Preview.ConsistencyReportTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).MigrationName = (string) content.GetValueForProperty("MigrationName",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).MigrationName, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).MigrationId = (string) content.GetValueForProperty("MigrationId",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).MigrationId, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).RecentConsistencyReportResult = (Wandisco.Fusion.Support.ConsistencyResult?) content.GetValueForProperty("RecentConsistencyReportResult",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).RecentConsistencyReportResult, Wandisco.Fusion.Support.ConsistencyResult.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).RecentConsistencyReportLastCheck = (global::System.DateTime?) content.GetValueForProperty("RecentConsistencyReportLastCheck",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).RecentConsistencyReportLastCheck, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).RecentConsistencyReportInconsistencyCount = (long?) content.GetValueForProperty("RecentConsistencyReportInconsistencyCount",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).RecentConsistencyReportInconsistencyCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).Source = (string) content.GetValueForProperty("Source",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).Source, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).MigrationType = (string) content.GetValueForProperty("MigrationType",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).MigrationType, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).Target = (string) content.GetValueForProperty("Target",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).Target, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).DateAfterWhichToMigrate = (global::System.DateTime?) content.GetValueForProperty("DateAfterWhichToMigrate",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).DateAfterWhichToMigrate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).OverwritePolicy = (Wandisco.Fusion.Support.LiveMigrationOverwritePolicy?) content.GetValueForProperty("OverwritePolicy",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).OverwritePolicy, Wandisco.Fusion.Support.LiveMigrationOverwritePolicy.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).Progress = (Wandisco.Fusion.Models.Api20190901Preview.IMigrationProgress) content.GetValueForProperty("Progress",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).Progress, Wandisco.Fusion.Models.Api20190901Preview.MigrationProgressTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).State = (Wandisco.Fusion.Support.LiveMigrationState?) content.GetValueForProperty("State",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).State, Wandisco.Fusion.Support.LiveMigrationState.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressDirsSeen = (long?) content.GetValueForProperty("ProgressDirsSeen",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressDirsSeen, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressDirsToMigrate = (long?) content.GetValueForProperty("ProgressDirsToMigrate",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressDirsToMigrate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressDuration = (long?) content.GetValueForProperty("ProgressDuration",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressDuration, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressFilesExcluded = (long?) content.GetValueForProperty("ProgressFilesExcluded",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressFilesExcluded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressFilesSeen = (long?) content.GetValueForProperty("ProgressFilesSeen",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressFilesSeen, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressFilesToMigrate = (long?) content.GetValueForProperty("ProgressFilesToMigrate",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressFilesToMigrate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressDirsExcluded = (long?) content.GetValueForProperty("ProgressDirsExcluded",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressDirsExcluded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressBytesToMigrate = (long?) content.GetValueForProperty("ProgressBytesToMigrate",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressBytesToMigrate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressSizeOfMigration = (long?) content.GetValueForProperty("ProgressSizeOfMigration",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressSizeOfMigration, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressBytesExcluded = (long?) content.GetValueForProperty("ProgressBytesExcluded",((Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleInternal)this).ProgressBytesExcluded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Wandisco.Fusion.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Replication Rule
    [System.ComponentModel.TypeConverter(typeof(ReplicationRuleTypeConverter))]
    public partial interface IReplicationRule

    {

    }
}