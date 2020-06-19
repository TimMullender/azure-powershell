namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using Wandisco.Fusion.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(Components1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalpropertiesTypeConverter))]
    public partial class Components1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.Components1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Components1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalpropertiesInternal)this).ClientId = (string) content.GetValueForProperty("ClientId",((Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalpropertiesInternal)this).ClientId, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalpropertiesInternal)this).PrincipalId = (string) content.GetValueForProperty("PrincipalId",((Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalpropertiesInternal)this).PrincipalId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.Components1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Components1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalpropertiesInternal)this).ClientId = (string) content.GetValueForProperty("ClientId",((Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalpropertiesInternal)this).ClientId, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalpropertiesInternal)this).PrincipalId = (string) content.GetValueForProperty("PrincipalId",((Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalpropertiesInternal)this).PrincipalId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.Components1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties"
        /// />.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Components1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.Components1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties"
        /// />.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Components1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Components1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties"
        /// />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties FromJsonString(string jsonText) => FromJson(Wandisco.Fusion.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Wandisco.Fusion.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(Components1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalpropertiesTypeConverter))]
    public partial interface IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties

    {

    }
}