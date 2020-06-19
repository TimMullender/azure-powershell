namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Properties of Created Rule Name</summary>
    public partial class ReplicationRuleProperties
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
        /// Deserializes a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode"/> into an instance of Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleProperties.
        /// </summary>
        /// <param name="node">a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleProperties.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IReplicationRuleProperties FromJson(Wandisco.Fusion.Runtime.Json.JsonNode node)
        {
            return node is Wandisco.Fusion.Runtime.Json.JsonObject json ? new ReplicationRuleProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Wandisco.Fusion.Runtime.Json.JsonObject into a new instance of <see cref="ReplicationRuleProperties" />.
        /// </summary>
        /// <param name="json">A Wandisco.Fusion.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ReplicationRuleProperties(Wandisco.Fusion.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_migration = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonObject>("migration"), out var __jsonMigration) ? Wandisco.Fusion.Models.Api20190901Preview.Migration.FromJson(__jsonMigration) : Migration;}
            {_recentConsistencyReport = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonObject>("recentConsistencyReport"), out var __jsonRecentConsistencyReport) ? Wandisco.Fusion.Models.Api20190901Preview.ConsistencyReport.FromJson(__jsonRecentConsistencyReport) : RecentConsistencyReport;}
            {_path = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonString>("path"), out var __jsonPath) ? (string)__jsonPath : (string)Path;}
            {_pathMapping = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonArray>("pathMapping"), out var __jsonPathMapping) ? If( __jsonPathMapping as Wandisco.Fusion.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Wandisco.Fusion.Models.Api20190901Preview.IPathMapping[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Wandisco.Fusion.Models.Api20190901Preview.IPathMapping) (Wandisco.Fusion.Models.Api20190901Preview.PathMapping.FromJson(__u) )) ))() : null : PathMapping;}
            {_priorityZone = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonString>("priorityZone"), out var __jsonPriorityZone) ? (string)__jsonPriorityZone : (string)PriorityZone;}
            {_provisioningState = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_zoneNames = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonArray>("zoneNames"), out var __jsonZoneNames) ? If( __jsonZoneNames as Wandisco.Fusion.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Wandisco.Fusion.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : ZoneNames;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ReplicationRuleProperties" /> into a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Wandisco.Fusion.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Wandisco.Fusion.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ReplicationRuleProperties" /> as a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode" />.
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
                AddIf( null != this._migration ? (Wandisco.Fusion.Runtime.Json.JsonNode) this._migration.ToJson(null,serializationMode) : null, "migration" ,container.Add );
            }
            if (serializationMode.HasFlag(Wandisco.Fusion.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._recentConsistencyReport ? (Wandisco.Fusion.Runtime.Json.JsonNode) this._recentConsistencyReport.ToJson(null,serializationMode) : null, "recentConsistencyReport" ,container.Add );
            }
            AddIf( null != (((object)this._path)?.ToString()) ? (Wandisco.Fusion.Runtime.Json.JsonNode) new Wandisco.Fusion.Runtime.Json.JsonString(this._path.ToString()) : null, "path" ,container.Add );
            if (null != this._pathMapping)
            {
                var __w = new Wandisco.Fusion.Runtime.Json.XNodeArray();
                foreach( var __x in this._pathMapping )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("pathMapping",__w);
            }
            AddIf( null != (((object)this._priorityZone)?.ToString()) ? (Wandisco.Fusion.Runtime.Json.JsonNode) new Wandisco.Fusion.Runtime.Json.JsonString(this._priorityZone.ToString()) : null, "priorityZone" ,container.Add );
            if (serializationMode.HasFlag(Wandisco.Fusion.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Wandisco.Fusion.Runtime.Json.JsonNode) new Wandisco.Fusion.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            if (null != this._zoneNames)
            {
                var __r = new Wandisco.Fusion.Runtime.Json.XNodeArray();
                foreach( var __s in this._zoneNames )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (Wandisco.Fusion.Runtime.Json.JsonNode) new Wandisco.Fusion.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("zoneNames",__r);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}