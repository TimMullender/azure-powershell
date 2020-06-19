namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>fusion group properties</summary>
    public partial class FusionGroupProperties :
        Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupProperties,
        Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal
    {

        /// <summary>Backing field for <see cref="HealthStatus" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IHealthStatus _healthStatus;

        /// <summary>The health of the Fusion Group</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        internal Wandisco.Fusion.Models.Api20190901Preview.IHealthStatus HealthStatus { get => (this._healthStatus = this._healthStatus ?? new Wandisco.Fusion.Models.Api20190901Preview.HealthStatus()); }

        /// <summary>
        /// An array indicating what errors, if any, occurred and what to do to resolve them
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition[] HealthStatusDetails { get => ((Wandisco.Fusion.Models.Api20190901Preview.IHealthStatusInternal)HealthStatus).Details; set => ((Wandisco.Fusion.Models.Api20190901Preview.IHealthStatusInternal)HealthStatus).Details = value; }

        /// <summary>Health Status</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Support.HealthStatusSummary? HealthStatusStatus { get => ((Wandisco.Fusion.Models.Api20190901Preview.IHealthStatusInternal)HealthStatus).Status; set => ((Wandisco.Fusion.Models.Api20190901Preview.IHealthStatusInternal)HealthStatus).Status = value; }

        /// <summary>Backing field for <see cref="Label" /> property.</summary>
        private string _label;

        /// <summary>Property type label</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Label { get => this._label; set => this._label = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Wandisco.Fusion.Support.ProvisioningState? _provisioningState;

        /// <summary>Provisioning State of resource</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Internal Acessors for HealthStatus</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IHealthStatus Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal.HealthStatus { get => (this._healthStatus = this._healthStatus ?? new Wandisco.Fusion.Models.Api20190901Preview.HealthStatus()); set { {_healthStatus = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Wandisco.Fusion.Support.ProvisioningState? Wandisco.Fusion.Models.Api20190901Preview.IFusionGroupPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Creates an new <see cref="FusionGroupProperties" /> instance.</summary>
        public FusionGroupProperties()
        {

        }
    }
    /// fusion group properties
    public partial interface IFusionGroupProperties :
        Wandisco.Fusion.Runtime.IJsonSerializable
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
        /// <summary>Health Status</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Health Status",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Support.HealthStatusSummary) })]
        Wandisco.Fusion.Support.HealthStatusSummary? HealthStatusStatus { get; set; }
        /// <summary>Property type label</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Property type label",
        SerializedName = @"label",
        PossibleTypes = new [] { typeof(string) })]
        string Label { get; set; }
        /// <summary>Provisioning State of resource</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning State of resource",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Support.ProvisioningState) })]
        Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get;  }

    }
    /// fusion group properties
    internal partial interface IFusionGroupPropertiesInternal

    {
        /// <summary>The health of the Fusion Group</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IHealthStatus HealthStatus { get; set; }
        /// <summary>
        /// An array indicating what errors, if any, occurred and what to do to resolve them
        /// </summary>
        Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition[] HealthStatusDetails { get; set; }
        /// <summary>Health Status</summary>
        Wandisco.Fusion.Support.HealthStatusSummary? HealthStatusStatus { get; set; }
        /// <summary>Property type label</summary>
        string Label { get; set; }
        /// <summary>Provisioning State of resource</summary>
        Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get; set; }

    }
}