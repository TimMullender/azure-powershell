namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using Wandisco.Fusion.Runtime.PowerShell;

    /// <summary>Fusion Group details</summary>
    [System.ComponentModel.TypeConverter(typeof(FusionGroupTypeConverter))]
    public partial class FusionGroup
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.FusionGroup"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.IFusionGroup" />.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IFusionGroup DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new FusionGroup(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.FusionGroup"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.IFusionGroup" />.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IFusionGroup DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new FusionGroup(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="FusionGroup" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IFusionGroup FromJsonString(string jsonText) => FromJson(Wandisco.Fusion.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.FusionGroup"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal FusionGroup(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).Plan = (Wandisco.Fusion.Models.Api20190901Preview.IPlan) content.GetValueForProperty("Plan",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).Plan, Wandisco.Fusion.Models.Api20190901Preview.PlanTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).Properties = (Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupProperties) content.GetValueForProperty("Properties",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).Properties, Wandisco.Fusion.Models.Api20190901Preview.FusionGroupPropertiesTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Tags = (Wandisco.Fusion.Models.Api20190901Preview.IResourceTags) content.GetValueForProperty("Tags",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Tags, Wandisco.Fusion.Models.Api20190901Preview.ResourceTagsTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PlanName, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PlanProduct = (string) content.GetValueForProperty("PlanProduct",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PlanProduct, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PlanPromotionCode = (string) content.GetValueForProperty("PlanPromotionCode",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PlanPromotionCode, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PlanPublisher = (string) content.GetValueForProperty("PlanPublisher",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PlanPublisher, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PlanVersion = (string) content.GetValueForProperty("PlanVersion",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PlanVersion, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PropertiesHealthStatus = (Wandisco.Fusion.Models.Api20190901Preview.IHealthStatus) content.GetValueForProperty("PropertiesHealthStatus",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PropertiesHealthStatus, Wandisco.Fusion.Models.Api20190901Preview.HealthStatusTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).ProvisioningState = (Wandisco.Fusion.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).ProvisioningState, Wandisco.Fusion.Support.ProvisioningState.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).Label = (string) content.GetValueForProperty("Label",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).Label, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).HealthStatusDetails = (Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition[]) content.GetValueForProperty("HealthStatusDetails",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).HealthStatusDetails, __y => TypeConverterExtensions.SelectToArray<Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition>(__y, Wandisco.Fusion.Models.Api20190901Preview.ErrorDefinitionTypeConverter.ConvertFrom));
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PropertiesHealthStatusStatus = (Wandisco.Fusion.Support.HealthStatusSummary?) content.GetValueForProperty("PropertiesHealthStatusStatus",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PropertiesHealthStatusStatus, Wandisco.Fusion.Support.HealthStatusSummary.CreateFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Wandisco.Fusion.Models.Api20190901Preview.FusionGroup"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal FusionGroup(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).Plan = (Wandisco.Fusion.Models.Api20190901Preview.IPlan) content.GetValueForProperty("Plan",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).Plan, Wandisco.Fusion.Models.Api20190901Preview.PlanTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).Properties = (Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupProperties) content.GetValueForProperty("Properties",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).Properties, Wandisco.Fusion.Models.Api20190901Preview.FusionGroupPropertiesTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Tags = (Wandisco.Fusion.Models.Api20190901Preview.IResourceTags) content.GetValueForProperty("Tags",((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)this).Tags, Wandisco.Fusion.Models.Api20190901Preview.ResourceTagsTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PlanName, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PlanProduct = (string) content.GetValueForProperty("PlanProduct",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PlanProduct, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PlanPromotionCode = (string) content.GetValueForProperty("PlanPromotionCode",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PlanPromotionCode, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PlanPublisher = (string) content.GetValueForProperty("PlanPublisher",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PlanPublisher, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PlanVersion = (string) content.GetValueForProperty("PlanVersion",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PlanVersion, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PropertiesHealthStatus = (Wandisco.Fusion.Models.Api20190901Preview.IHealthStatus) content.GetValueForProperty("PropertiesHealthStatus",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PropertiesHealthStatus, Wandisco.Fusion.Models.Api20190901Preview.HealthStatusTypeConverter.ConvertFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).ProvisioningState = (Wandisco.Fusion.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).ProvisioningState, Wandisco.Fusion.Support.ProvisioningState.CreateFrom);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).Label = (string) content.GetValueForProperty("Label",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).Label, global::System.Convert.ToString);
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).HealthStatusDetails = (Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition[]) content.GetValueForProperty("HealthStatusDetails",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).HealthStatusDetails, __y => TypeConverterExtensions.SelectToArray<Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition>(__y, Wandisco.Fusion.Models.Api20190901Preview.ErrorDefinitionTypeConverter.ConvertFrom));
            ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PropertiesHealthStatusStatus = (Wandisco.Fusion.Support.HealthStatusSummary?) content.GetValueForProperty("PropertiesHealthStatusStatus",((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal)this).PropertiesHealthStatusStatus, Wandisco.Fusion.Support.HealthStatusSummary.CreateFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Wandisco.Fusion.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Fusion Group details
    [System.ComponentModel.TypeConverter(typeof(FusionGroupTypeConverter))]
    public partial interface IFusionGroup

    {

    }
}