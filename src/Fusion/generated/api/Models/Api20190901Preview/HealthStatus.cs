namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>health status object</summary>
    public partial class HealthStatus :
        Wandisco.Fusion.Models.Api20190901Preview.IHealthStatus,
        Wandisco.Fusion.Models.Api20190901Preview.IHealthStatusInternal
    {

        /// <summary>Backing field for <see cref="Details" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition[] _details;

        /// <summary>
        /// An array indicating what errors, if any, occurred and what to do to resolve them
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition[] Details { get => this._details; set => this._details = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Wandisco.Fusion.Support.HealthStatusSummary? _status;

        /// <summary>Health Status</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Support.HealthStatusSummary? Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="HealthStatus" /> instance.</summary>
        public HealthStatus()
        {

        }
    }
    /// health status object
    public partial interface IHealthStatus :
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
        Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition[] Details { get; set; }
        /// <summary>Health Status</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Health Status",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Support.HealthStatusSummary) })]
        Wandisco.Fusion.Support.HealthStatusSummary? Status { get; set; }

    }
    /// health status object
    internal partial interface IHealthStatusInternal

    {
        /// <summary>
        /// An array indicating what errors, if any, occurred and what to do to resolve them
        /// </summary>
        Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition[] Details { get; set; }
        /// <summary>Health Status</summary>
        Wandisco.Fusion.Support.HealthStatusSummary? Status { get; set; }

    }
}