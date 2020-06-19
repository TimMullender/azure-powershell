namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Consistency Check Options Properties</summary>
    public partial class ConsistencyCheckOptionsProperties :
        Wandisco.Fusion.Models.Api20190901Preview.IConsistencyCheckOptionsProperties,
        Wandisco.Fusion.Models.Api20190901Preview.IConsistencyCheckOptionsPropertiesInternal
    {

        /// <summary>Backing field for <see cref="NonBlockingThreshold" /> property.</summary>
        private int? _nonBlockingThreshold;

        /// <summary>
        /// The threshold of dirty files which will cancel a non-blocking consistency check should it be met
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public int? NonBlockingThreshold { get => this._nonBlockingThreshold; set => this._nonBlockingThreshold = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Wandisco.Fusion.Support.Type? _type;

        /// <summary>The type of check, blocking will prevent client requests while running</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Support.Type? Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="ConsistencyCheckOptionsProperties" /> instance.</summary>
        public ConsistencyCheckOptionsProperties()
        {

        }
    }
    /// Consistency Check Options Properties
    public partial interface IConsistencyCheckOptionsProperties :
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
    /// Consistency Check Options Properties
    internal partial interface IConsistencyCheckOptionsPropertiesInternal

    {
        /// <summary>
        /// The threshold of dirty files which will cancel a non-blocking consistency check should it be met
        /// </summary>
        int? NonBlockingThreshold { get; set; }
        /// <summary>The type of check, blocking will prevent client requests while running</summary>
        Wandisco.Fusion.Support.Type? Type { get; set; }

    }
}