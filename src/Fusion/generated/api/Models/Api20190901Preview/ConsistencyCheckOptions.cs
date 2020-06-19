namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Consistency Check Options</summary>
    public partial class ConsistencyCheckOptions :
        Wandisco.Fusion.Models.Api20190901Preview.IConsistencyCheckOptions,
        Wandisco.Fusion.Models.Api20190901Preview.IConsistencyCheckOptionsInternal
    {

        /// <summary>
        /// The threshold of dirty files which will cancel a non-blocking consistency check should it be met
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public int? NonBlockingThreshold { get => ((Wandisco.Fusion.Models.Api20190901Preview.IConsistencyCheckOptionsPropertiesInternal)Properties).NonBlockingThreshold; set => ((Wandisco.Fusion.Models.Api20190901Preview.IConsistencyCheckOptionsPropertiesInternal)Properties).NonBlockingThreshold = value; }

        /// <summary>Backing field for <see cref="Properties" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IConsistencyCheckOptionsProperties _properties;

        /// <summary>Consistency Check Options properties</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        internal Wandisco.Fusion.Models.Api20190901Preview.IConsistencyCheckOptionsProperties Properties { get => (this._properties = this._properties ?? new Wandisco.Fusion.Models.Api20190901Preview.ConsistencyCheckOptionsProperties()); set => this._properties = value; }

        /// <summary>The type of check, blocking will prevent client requests while running</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Support.Type? Type { get => ((Wandisco.Fusion.Models.Api20190901Preview.IConsistencyCheckOptionsPropertiesInternal)Properties).Type; set => ((Wandisco.Fusion.Models.Api20190901Preview.IConsistencyCheckOptionsPropertiesInternal)Properties).Type = value; }

        /// <summary>Internal Acessors for Properties</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IConsistencyCheckOptionsProperties Wandisco.Fusion.Models.Api20190901Preview.IConsistencyCheckOptionsInternal.Properties { get => (this._properties = this._properties ?? new Wandisco.Fusion.Models.Api20190901Preview.ConsistencyCheckOptionsProperties()); set { {_properties = value;} } }

        /// <summary>Creates an new <see cref="ConsistencyCheckOptions" /> instance.</summary>
        public ConsistencyCheckOptions()
        {

        }
    }
    /// Consistency Check Options
    public partial interface IConsistencyCheckOptions :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The threshold of dirty files which will cancel a non-blocking consistency check should it be met
        /// </summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The threshold of dirty files which will cancel a non-blocking consistency check should it be met",
        SerializedName = @"nonBlockingThreshold",
        PossibleTypes = new [] { typeof(int) })]
        int? NonBlockingThreshold { get; set; }
        /// <summary>The type of check, blocking will prevent client requests while running</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of check, blocking will prevent client requests while running",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Support.Type) })]
        Wandisco.Fusion.Support.Type? Type { get; set; }

    }
    /// Consistency Check Options
    internal partial interface IConsistencyCheckOptionsInternal

    {
        /// <summary>
        /// The threshold of dirty files which will cancel a non-blocking consistency check should it be met
        /// </summary>
        int? NonBlockingThreshold { get; set; }
        /// <summary>Consistency Check Options properties</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IConsistencyCheckOptionsProperties Properties { get; set; }
        /// <summary>The type of check, blocking will prevent client requests while running</summary>
        Wandisco.Fusion.Support.Type? Type { get; set; }

    }
}