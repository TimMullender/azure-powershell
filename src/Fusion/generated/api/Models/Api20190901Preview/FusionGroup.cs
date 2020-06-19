namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Fusion Group details</summary>
    public partial class FusionGroup :
        Wandisco.Fusion.Models.Api20190901Preview.IFusionGroup,
        Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal,
        Wandisco.Fusion.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Wandisco.Fusion.Models.Api20190901Preview.IResource" />
        /// </summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IResource __resource = new Wandisco.Fusion.Models.Api20190901Preview.Resource();

        /// <summary>
        /// An array indicating what errors, if any, occurred and what to do to resolve them
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition[] HealthStatusDetails { get => ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)Properties).HealthStatusDetails; set => ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)Properties).HealthStatusDetails = value; }

        /// <summary>Azure resource Id.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string Id { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Id; }

        /// <summary>Property type label</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string Label { get => ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)Properties).Label; set => ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)Properties).Label = value; }

        /// <summary>Location of the resource.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string Location { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Location; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Location = value; }

        /// <summary>Azure resource name.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string Name { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Plan" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IPlan _plan;

        /// <summary>Plan to use for Store purchase</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        internal Wandisco.Fusion.Models.Api20190901Preview.IPlan Plan { get => (this._plan = this._plan ?? new Wandisco.Fusion.Models.Api20190901Preview.Plan()); set => this._plan = value; }

        /// <summary>A user defined name of the 3rd Party Artifact that is being procured.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string PlanName { get => ((Wandisco.Fusion.Models.Api20190901Preview.IPlanInternal)Plan).Name; set => ((Wandisco.Fusion.Models.Api20190901Preview.IPlanInternal)Plan).Name = value; }

        /// <summary>
        /// The 3rd Party artifact that is being procured. E.g. NewRelic. Product maps to the OfferID specified for the artifact at
        /// the time of Data Market onboarding.
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string PlanProduct { get => ((Wandisco.Fusion.Models.Api20190901Preview.IPlanInternal)Plan).Product; set => ((Wandisco.Fusion.Models.Api20190901Preview.IPlanInternal)Plan).Product = value; }

        /// <summary>
        /// A publisher provided promotion code as provisioned in Data Market for the said product/artifact.
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string PlanPromotionCode { get => ((Wandisco.Fusion.Models.Api20190901Preview.IPlanInternal)Plan).PromotionCode; set => ((Wandisco.Fusion.Models.Api20190901Preview.IPlanInternal)Plan).PromotionCode = value; }

        /// <summary>The publisher of the 3rd Party Artifact that is being bought. E.g. NewRelic</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string PlanPublisher { get => ((Wandisco.Fusion.Models.Api20190901Preview.IPlanInternal)Plan).Publisher; set => ((Wandisco.Fusion.Models.Api20190901Preview.IPlanInternal)Plan).Publisher = value; }

        /// <summary>The version of the desired product/artifact.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string PlanVersion { get => ((Wandisco.Fusion.Models.Api20190901Preview.IPlanInternal)Plan).Version; set => ((Wandisco.Fusion.Models.Api20190901Preview.IPlanInternal)Plan).Version = value; }

        /// <summary>Backing field for <see cref="Properties" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupProperties _properties;

        /// <summary>fusion group properties</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        internal Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupProperties Properties { get => (this._properties = this._properties ?? new Wandisco.Fusion.Models.Api20190901Preview.FusionGroupProperties()); set => this._properties = value; }

        /// <summary>Health Status</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Support.HealthStatusSummary? PropertiesHealthStatusStatus { get => ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)Properties).HealthStatusStatus; set => ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)Properties).HealthStatusStatus = value; }

        /// <summary>Provisioning State of resource</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get => ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)Properties).ProvisioningState; }

        /// <summary>resource tags.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public Wandisco.Fusion.Models.Api20190901Preview.IResourceTags Tags { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Tags; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Tags = value; }

        /// <summary>Azure resource type.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string Type { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Type; }

        /// <summary>Internal Acessors for Plan</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IPlan Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal.Plan { get => (this._plan = this._plan ?? new Wandisco.Fusion.Models.Api20190901Preview.Plan()); set { {_plan = value;} } }

        /// <summary>Internal Acessors for Properties</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupProperties Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal.Properties { get => (this._properties = this._properties ?? new Wandisco.Fusion.Models.Api20190901Preview.FusionGroupProperties()); set { {_properties = value;} } }

        /// <summary>Internal Acessors for PropertiesHealthStatus</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IHealthStatus Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal.PropertiesHealthStatus { get => ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)Properties).HealthStatus; set => ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)Properties).HealthStatus = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Wandisco.Fusion.Support.ProvisioningState? Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupInternal.ProvisioningState { get => ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)Properties).ProvisioningState; set => ((Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal)Properties).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal.Id { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Id; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal.Name { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Name; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal.Type { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Type; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Type = value; }

        /// <summary>Creates an new <see cref="FusionGroup" /> instance.</summary>
        public FusionGroup()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Wandisco.Fusion.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Wandisco.Fusion.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Fusion Group details
    public partial interface IFusionGroup :
        Wandisco.Fusion.Runtime.IJsonSerializable,
        Wandisco.Fusion.Models.Api20190901Preview.IResource
    {
        /// <summary>
        /// An array indicating what errors, if any, occurred and what to do to resolve them
        /// </summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An array indicating what errors, if any, occurred and what to do to resolve them",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition) })]
        Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition[] HealthStatusDetails { get; set; }
        /// <summary>Property type label</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Property type label",
        SerializedName = @"label",
        PossibleTypes = new [] { typeof(string) })]
        string Label { get; set; }
        /// <summary>A user defined name of the 3rd Party Artifact that is being procured.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"A user defined name of the 3rd Party Artifact that is being procured.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string PlanName { get; set; }
        /// <summary>
        /// The 3rd Party artifact that is being procured. E.g. NewRelic. Product maps to the OfferID specified for the artifact at
        /// the time of Data Market onboarding.
        /// </summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The 3rd Party artifact that is being procured. E.g. NewRelic. Product maps to the OfferID specified for the artifact at the time of Data Market onboarding. ",
        SerializedName = @"product",
        PossibleTypes = new [] { typeof(string) })]
        string PlanProduct { get; set; }
        /// <summary>
        /// A publisher provided promotion code as provisioned in Data Market for the said product/artifact.
        /// </summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A publisher provided promotion code as provisioned in Data Market for the said product/artifact.",
        SerializedName = @"promotionCode",
        PossibleTypes = new [] { typeof(string) })]
        string PlanPromotionCode { get; set; }
        /// <summary>The publisher of the 3rd Party Artifact that is being bought. E.g. NewRelic</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The publisher of the 3rd Party Artifact that is being bought. E.g. NewRelic",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string PlanPublisher { get; set; }
        /// <summary>The version of the desired product/artifact.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of the desired product/artifact.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string PlanVersion { get; set; }
        /// <summary>Health Status</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Health Status",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Support.HealthStatusSummary) })]
        Wandisco.Fusion.Support.HealthStatusSummary? PropertiesHealthStatusStatus { get; set; }
        /// <summary>Provisioning State of resource</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning State of resource",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Support.ProvisioningState) })]
        Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get;  }

    }
    /// Fusion Group details
    internal partial interface IFusionGroupInternal :
        Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal
    {
        /// <summary>
        /// An array indicating what errors, if any, occurred and what to do to resolve them
        /// </summary>
        Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition[] HealthStatusDetails { get; set; }
        /// <summary>Property type label</summary>
        string Label { get; set; }
        /// <summary>Plan to use for Store purchase</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IPlan Plan { get; set; }
        /// <summary>A user defined name of the 3rd Party Artifact that is being procured.</summary>
        string PlanName { get; set; }
        /// <summary>
        /// The 3rd Party artifact that is being procured. E.g. NewRelic. Product maps to the OfferID specified for the artifact at
        /// the time of Data Market onboarding.
        /// </summary>
        string PlanProduct { get; set; }
        /// <summary>
        /// A publisher provided promotion code as provisioned in Data Market for the said product/artifact.
        /// </summary>
        string PlanPromotionCode { get; set; }
        /// <summary>The publisher of the 3rd Party Artifact that is being bought. E.g. NewRelic</summary>
        string PlanPublisher { get; set; }
        /// <summary>The version of the desired product/artifact.</summary>
        string PlanVersion { get; set; }
        /// <summary>fusion group properties</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupProperties Properties { get; set; }
        /// <summary>The health of the Fusion Group</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IHealthStatus PropertiesHealthStatus { get; set; }
        /// <summary>Health Status</summary>
        Wandisco.Fusion.Support.HealthStatusSummary? PropertiesHealthStatusStatus { get; set; }
        /// <summary>Provisioning State of resource</summary>
        Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get; set; }

    }
}