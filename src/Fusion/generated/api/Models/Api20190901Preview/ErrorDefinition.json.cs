namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Error definition.</summary>
    public partial class ErrorDefinition
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
        /// Deserializes a Wandisco.Fusion.Runtime.Json.JsonObject into a new instance of <see cref="ErrorDefinition" />.
        /// </summary>
        /// <param name="json">A Wandisco.Fusion.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ErrorDefinition(Wandisco.Fusion.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_code = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonString>("code"), out var __jsonCode) ? (string)__jsonCode : (string)Code;}
            {_message = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonString>("message"), out var __jsonMessage) ? (string)__jsonMessage : (string)Message;}
            {_details = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonArray>("details"), out var __jsonDetails) ? If( __jsonDetails as Wandisco.Fusion.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition) (Wandisco.Fusion.Models.Api20190901Preview.ErrorDefinition.FromJson(__u) )) ))() : null : Details;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode"/> into an instance of Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition.
        /// </summary>
        /// <param name="node">a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition.</returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IErrorDefinition FromJson(Wandisco.Fusion.Runtime.Json.JsonNode node)
        {
            return node is Wandisco.Fusion.Runtime.Json.JsonObject json ? new ErrorDefinition(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ErrorDefinition" /> into a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Wandisco.Fusion.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Wandisco.Fusion.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ErrorDefinition" /> as a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode" />.
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
            if (serializationMode.HasFlag(Wandisco.Fusion.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._code)?.ToString()) ? (Wandisco.Fusion.Runtime.Json.JsonNode) new Wandisco.Fusion.Runtime.Json.JsonString(this._code.ToString()) : null, "code" ,container.Add );
            }
            if (serializationMode.HasFlag(Wandisco.Fusion.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._message)?.ToString()) ? (Wandisco.Fusion.Runtime.Json.JsonNode) new Wandisco.Fusion.Runtime.Json.JsonString(this._message.ToString()) : null, "message" ,container.Add );
            }
            if (null != this._details)
            {
                var __w = new Wandisco.Fusion.Runtime.Json.XNodeArray();
                foreach( var __x in this._details )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("details",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}