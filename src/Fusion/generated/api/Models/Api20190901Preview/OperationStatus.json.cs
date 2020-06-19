namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>operation status object</summary>
    public partial class OperationStatus
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
        /// Deserializes a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode"/> into an instance of Wandisco.Fusion.Models.Api20190901Preview.IOperationStatus.
        /// </summary>
        /// <param name="node">a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Wandisco.Fusion.Models.Api20190901Preview.IOperationStatus.</returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IOperationStatus FromJson(Wandisco.Fusion.Runtime.Json.JsonNode node)
        {
            return node is Wandisco.Fusion.Runtime.Json.JsonObject json ? new OperationStatus(json) : null;
        }

        /// <summary>
        /// Deserializes a Wandisco.Fusion.Runtime.Json.JsonObject into a new instance of <see cref="OperationStatus" />.
        /// </summary>
        /// <param name="json">A Wandisco.Fusion.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal OperationStatus(Wandisco.Fusion.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_error = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonObject>("error"), out var __jsonError) ? Wandisco.Fusion.Models.Api20190901Preview.OperationStatusError.FromJson(__jsonError) : Error;}
            {_id = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            {_status = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)Status;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="OperationStatus" /> into a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Wandisco.Fusion.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Wandisco.Fusion.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="OperationStatus" /> as a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._error ? (Wandisco.Fusion.Runtime.Json.JsonNode) this._error.ToJson(null,serializationMode) : null, "error" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (Wandisco.Fusion.Runtime.Json.JsonNode) new Wandisco.Fusion.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            AddIf( null != (((object)this._status)?.ToString()) ? (Wandisco.Fusion.Runtime.Json.JsonNode) new Wandisco.Fusion.Runtime.Json.JsonString(this._status.ToString()) : null, "status" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}