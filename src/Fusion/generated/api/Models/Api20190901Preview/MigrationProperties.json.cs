namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Properties of fusion migration</summary>
    public partial class MigrationProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Wandisco.Fusion.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Wandisco.Fusion.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Wandisco.Fusion.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Wandisco.Fusion.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Wandisco.Fusion.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode"/> into an instance of Wandisco.Fusion.Models.Api20190901Preview.IMigrationProperties.
        /// </summary>
        /// <param name="node">a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Wandisco.Fusion.Models.Api20190901Preview.IMigrationProperties.</returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IMigrationProperties FromJson(Wandisco.Fusion.Runtime.Json.JsonNode node)
        {
            return node is Wandisco.Fusion.Runtime.Json.JsonObject json ? new MigrationProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Wandisco.Fusion.Runtime.Json.JsonObject into a new instance of <see cref="MigrationProperties" />.
        /// </summary>
        /// <param name="json">A Wandisco.Fusion.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MigrationProperties(Wandisco.Fusion.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_progress = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonObject>("progress"), out var __jsonProgress) ? Wandisco.Fusion.Models.Api20190901Preview.MigrationProgress.FromJson(__jsonProgress) : Progress;}
            {_dateAfterWhichToMigrate = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonString>("dateAfterWhichToMigrate"), out var __jsonDateAfterWhichToMigrate) ? global::System.DateTime.TryParse((string)__jsonDateAfterWhichToMigrate, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonDateAfterWhichToMigrateValue) ? __jsonDateAfterWhichToMigrateValue : DateAfterWhichToMigrate : DateAfterWhichToMigrate;}
            {_overwritePolicy = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonString>("overwritePolicy"), out var __jsonOverwritePolicy) ? (string)__jsonOverwritePolicy : (string)OverwritePolicy;}
            {_source = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonString>("source"), out var __jsonSource) ? (string)__jsonSource : (string)Source;}
            {_state = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonString>("state"), out var __jsonState) ? (string)__jsonState : (string)State;}
            {_target = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonString>("target"), out var __jsonTarget) ? (string)__jsonTarget : (string)Target;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="MigrationProperties" /> into a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Wandisco.Fusion.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Wandisco.Fusion.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MigrationProperties" /> as a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode" />.
        /// </returns>
        public Wandisco.Fusion.Runtime.Json.JsonNode ToJson(Wandisco.Fusion.Runtime.Json.JsonObject container, Wandisco.Fusion.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Wandisco.Fusion.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._progress ? (Wandisco.Fusion.Runtime.Json.JsonNode) this._progress.ToJson(null,serializationMode) : null, "progress" ,container.Add );
            AddIf( null != this._dateAfterWhichToMigrate ? (Wandisco.Fusion.Runtime.Json.JsonNode) new Wandisco.Fusion.Runtime.Json.JsonString(this._dateAfterWhichToMigrate?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "dateAfterWhichToMigrate" ,container.Add );
            AddIf( null != (((object)this._overwritePolicy)?.ToString()) ? (Wandisco.Fusion.Runtime.Json.JsonNode) new Wandisco.Fusion.Runtime.Json.JsonString(this._overwritePolicy.ToString()) : null, "overwritePolicy" ,container.Add );
            AddIf( null != (((object)this._source)?.ToString()) ? (Wandisco.Fusion.Runtime.Json.JsonNode) new Wandisco.Fusion.Runtime.Json.JsonString(this._source.ToString()) : null, "source" ,container.Add );
            AddIf( null != (((object)this._state)?.ToString()) ? (Wandisco.Fusion.Runtime.Json.JsonNode) new Wandisco.Fusion.Runtime.Json.JsonString(this._state.ToString()) : null, "state" ,container.Add );
            AddIf( null != (((object)this._target)?.ToString()) ? (Wandisco.Fusion.Runtime.Json.JsonNode) new Wandisco.Fusion.Runtime.Json.JsonString(this._target.ToString()) : null, "target" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}