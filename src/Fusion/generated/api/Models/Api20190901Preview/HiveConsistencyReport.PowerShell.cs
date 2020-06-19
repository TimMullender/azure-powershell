namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using Wandisco.Fusion.Runtime.PowerShell;

    /// <summary>HiveConsistencyReport Results for rule</summary>
    [System.ComponentModel.TypeConverter(typeof(HiveConsistencyReportTypeConverter))]
    public partial class HiveConsistencyReport
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.HiveConsistencyReport"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReport" />.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReport DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new HiveConsistencyReport(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.HiveConsistencyReport"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReport" />.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReport DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new HiveConsistencyReport(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="HiveConsistencyReport" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReport FromJsonString(string jsonText) => FromJson(Wandisco.Fusion.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.HiveConsistencyReport"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal HiveConsistencyReport(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)this).Consistent = (long?) content.GetValueForProperty("Consistent",((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)this).Consistent, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)this).Failed = (long?) content.GetValueForProperty("Failed",((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)this).Failed, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)this).Inconsistent = (long?) content.GetValueForProperty("Inconsistent",((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)this).Inconsistent, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)this).Running = (long?) content.GetValueForProperty("Running",((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)this).Running, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)this).Unknown = (long?) content.GetValueForProperty("Unknown",((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)this).Unknown, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.HiveConsistencyReport"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal HiveConsistencyReport(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)this).Consistent = (long?) content.GetValueForProperty("Consistent",((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)this).Consistent, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)this).Failed = (long?) content.GetValueForProperty("Failed",((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)this).Failed, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)this).Inconsistent = (long?) content.GetValueForProperty("Inconsistent",((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)this).Inconsistent, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)this).Running = (long?) content.GetValueForProperty("Running",((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)this).Running, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)this).Unknown = (long?) content.GetValueForProperty("Unknown",((Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReportInternal)this).Unknown, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Wandisco.Fusion.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// HiveConsistencyReport Results for rule
    [System.ComponentModel.TypeConverter(typeof(HiveConsistencyReportTypeConverter))]
    public partial interface IHiveConsistencyReport

    {

    }
}