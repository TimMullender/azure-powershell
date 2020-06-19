namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using Wandisco.Fusion.Runtime.PowerShell;

    /// <summary>Hive Replication Rule</summary>
    [System.ComponentModel.TypeConverter(typeof(HiveReplicationRuleTypeConverter))]
    public partial class HiveReplicationRule
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.HiveReplicationRule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRule" />.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRule DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new HiveReplicationRule(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.HiveReplicationRule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRule" />.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRule DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new HiveReplicationRule(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="HiveReplicationRule" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRule FromJsonString(string jsonText) => FromJson(Wandisco.Fusion.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.HiveReplicationRule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal HiveReplicationRule(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).Properties = (Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleProperties) content.GetValueForProperty("Properties",((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).Properties, Wandisco.Fusion.Models.Api20190901Preview.HiveReplicationRulePropertiesTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Tags = (Wandisco.Fusion.Models.Api20190901Preview.IResourceTags) content.GetValueForProperty("Tags",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Tags, Wandisco.Fusion.Models.Api20190901Preview.ResourceTagsTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).ProvisioningState = (Wandisco.Fusion.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).ProvisioningState, Wandisco.Fusion.Support.ProvisioningState.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).RecentConsistencyReport = (Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReport) content.GetValueForProperty("RecentConsistencyReport",((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).RecentConsistencyReport, Wandisco.Fusion.Models.Api20190901Preview.HiveConsistencyReportTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).DbNamePattern = (string) content.GetValueForProperty("DbNamePattern",((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).DbNamePattern, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).TableNamePattern = (string) content.GetValueForProperty("TableNamePattern",((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).TableNamePattern, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).RecentConsistencyReportConsistent = (long?) content.GetValueForProperty("RecentConsistencyReportConsistent",((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).RecentConsistencyReportConsistent, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).RecentConsistencyReportFailed = (long?) content.GetValueForProperty("RecentConsistencyReportFailed",((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).RecentConsistencyReportFailed, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).RecentConsistencyReportInconsistent = (long?) content.GetValueForProperty("RecentConsistencyReportInconsistent",((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).RecentConsistencyReportInconsistent, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).RecentConsistencyReportRunning = (long?) content.GetValueForProperty("RecentConsistencyReportRunning",((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).RecentConsistencyReportRunning, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).RecentConsistencyReportUnknown = (long?) content.GetValueForProperty("RecentConsistencyReportUnknown",((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).RecentConsistencyReportUnknown, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.HiveReplicationRule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal HiveReplicationRule(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).Properties = (Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleProperties) content.GetValueForProperty("Properties",((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).Properties, Wandisco.Fusion.Models.Api20190901Preview.HiveReplicationRulePropertiesTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Tags = (Wandisco.Fusion.Models.Api20190901Preview.IResourceTags) content.GetValueForProperty("Tags",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Tags, Wandisco.Fusion.Models.Api20190901Preview.ResourceTagsTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).ProvisioningState = (Wandisco.Fusion.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).ProvisioningState, Wandisco.Fusion.Support.ProvisioningState.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).RecentConsistencyReport = (Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReport) content.GetValueForProperty("RecentConsistencyReport",((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).RecentConsistencyReport, Wandisco.Fusion.Models.Api20190901Preview.HiveConsistencyReportTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).DbNamePattern = (string) content.GetValueForProperty("DbNamePattern",((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).DbNamePattern, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).TableNamePattern = (string) content.GetValueForProperty("TableNamePattern",((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).TableNamePattern, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).RecentConsistencyReportConsistent = (long?) content.GetValueForProperty("RecentConsistencyReportConsistent",((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).RecentConsistencyReportConsistent, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).RecentConsistencyReportFailed = (long?) content.GetValueForProperty("RecentConsistencyReportFailed",((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).RecentConsistencyReportFailed, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).RecentConsistencyReportInconsistent = (long?) content.GetValueForProperty("RecentConsistencyReportInconsistent",((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).RecentConsistencyReportInconsistent, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).RecentConsistencyReportRunning = (long?) content.GetValueForProperty("RecentConsistencyReportRunning",((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).RecentConsistencyReportRunning, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).RecentConsistencyReportUnknown = (long?) content.GetValueForProperty("RecentConsistencyReportUnknown",((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal)this).RecentConsistencyReportUnknown, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Wandisco.Fusion.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Hive Replication Rule
    [System.ComponentModel.TypeConverter(typeof(HiveReplicationRuleTypeConverter))]
    public partial interface IHiveReplicationRule

    {

    }
}