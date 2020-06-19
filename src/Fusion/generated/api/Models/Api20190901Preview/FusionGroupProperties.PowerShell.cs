namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using Wandisco.Fusion.Runtime.PowerShell;

    /// <summary>fusion group properties</summary>
    [System.ComponentModel.TypeConverter(typeof(FusionGroupPropertiesTypeConverter))]
    public partial class FusionGroupProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.FusionGroupProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupProperties" />.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new FusionGroupProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.FusionGroupProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupProperties" />.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new FusionGroupProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="FusionGroupProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupProperties FromJsonString(string jsonText) => FromJson(Wandisco.Fusion.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.FusionGroupProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal FusionGroupProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)this).HealthStatus = (Wandisco.Fusion.Models.Api20190901Preview.IHealthStatus) content.GetValueForProperty("HealthStatus",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)this).HealthStatus, Wandisco.Fusion.Models.Api20190901Preview.HealthStatusTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)this).Label = (string) content.GetValueForProperty("Label",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)this).Label, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)this).ProvisioningState = (Wandisco.Fusion.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)this).ProvisioningState, Wandisco.Fusion.Support.ProvisioningState.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)this).HealthStatusDetails = (Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition[]) content.GetValueForProperty("HealthStatusDetails",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)this).HealthStatusDetails, __y => TypeConverterExtensions.SelectToArray<Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition>(__y, Wandisco.Fusion.Models.Api20190901Preview.ErrorDefinitionTypeConverter.ConvertFrom));
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)this).HealthStatusStatus = (Wandisco.Fusion.Support.HealthStatusSummary?) content.GetValueForProperty("HealthStatusStatus",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)this).HealthStatusStatus, Wandisco.Fusion.Support.HealthStatusSummary.CreateFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.FusionGroupProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal FusionGroupProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)this).HealthStatus = (Wandisco.Fusion.Models.Api20190901Preview.IHealthStatus) content.GetValueForProperty("HealthStatus",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)this).HealthStatus, Wandisco.Fusion.Models.Api20190901Preview.HealthStatusTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)this).Label = (string) content.GetValueForProperty("Label",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)this).Label, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)this).ProvisioningState = (Wandisco.Fusion.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)this).ProvisioningState, Wandisco.Fusion.Support.ProvisioningState.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)this).HealthStatusDetails = (Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition[]) content.GetValueForProperty("HealthStatusDetails",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)this).HealthStatusDetails, __y => TypeConverterExtensions.SelectToArray<Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition>(__y, Wandisco.Fusion.Models.Api20190901Preview.ErrorDefinitionTypeConverter.ConvertFrom));
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)this).HealthStatusStatus = (Wandisco.Fusion.Support.HealthStatusSummary?) content.GetValueForProperty("HealthStatusStatus",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)this).HealthStatusStatus, Wandisco.Fusion.Support.HealthStatusSummary.CreateFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Wandisco.Fusion.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// fusion group properties
    [System.ComponentModel.TypeConverter(typeof(FusionGroupPropertiesTypeConverter))]
    public partial interface IFusionGroupProperties

    {

    }
}