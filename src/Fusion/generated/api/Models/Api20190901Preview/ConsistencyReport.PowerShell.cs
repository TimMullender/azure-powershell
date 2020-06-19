namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using Wandisco.Fusion.Runtime.PowerShell;

    /// <summary>ConsistencyReport Results for path</summary>
    [System.ComponentModel.TypeConverter(typeof(ConsistencyReportTypeConverter))]
    public partial class ConsistencyReport
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.ConsistencyReport"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ConsistencyReport(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReportInternal)this).InconsistencyCount = (long?) content.GetValueForProperty("InconsistencyCount",((Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReportInternal)this).InconsistencyCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReportInternal)this).LastCheck = (global::System.DateTime?) content.GetValueForProperty("LastCheck",((Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReportInternal)this).LastCheck, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReportInternal)this).Result = (Wandisco.Fusion.Support.ConsistencyResult?) content.GetValueForProperty("Result",((Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReportInternal)this).Result, Wandisco.Fusion.Support.ConsistencyResult.CreateFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.ConsistencyReport"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ConsistencyReport(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReportInternal)this).InconsistencyCount = (long?) content.GetValueForProperty("InconsistencyCount",((Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReportInternal)this).InconsistencyCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReportInternal)this).LastCheck = (global::System.DateTime?) content.GetValueForProperty("LastCheck",((Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReportInternal)this).LastCheck, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReportInternal)this).Result = (Wandisco.Fusion.Support.ConsistencyResult?) content.GetValueForProperty("Result",((Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReportInternal)this).Result, Wandisco.Fusion.Support.ConsistencyResult.CreateFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.ConsistencyReport"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReport" />.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReport DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ConsistencyReport(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.ConsistencyReport"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReport" />.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReport DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ConsistencyReport(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ConsistencyReport" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IConsistencyReport FromJsonString(string jsonText) => FromJson(Wandisco.Fusion.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Wandisco.Fusion.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// ConsistencyReport Results for path
    [System.ComponentModel.TypeConverter(typeof(ConsistencyReportTypeConverter))]
    public partial interface IConsistencyReport

    {

    }
}