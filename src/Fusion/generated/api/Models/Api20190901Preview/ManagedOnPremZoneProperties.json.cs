namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Managed OnPrem zone properties</summary>
    public partial class ManagedOnPremZoneProperties
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
        /// Deserializes a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode"/> into an instance of Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneProperties.
        /// </summary>
        /// <param name="node">a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneProperties.
        /// </returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IManagedOnPremZoneProperties FromJson(Wandisco.Fusion.Runtime.Json.JsonNode node)
        {
            return node is Wandisco.Fusion.Runtime.Json.JsonObject json ? new ManagedOnPremZoneProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Wandisco.Fusion.Runtime.Json.JsonObject into a new instance of <see cref="ManagedOnPremZoneProperties" />.
        /// </summary>
        /// <param name="json">A Wandisco.Fusion.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ManagedOnPremZoneProperties(Wandisco.Fusion.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_deploymentType = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonString>("deploymentType"), out var __jsonDeploymentType) ? (string)__jsonDeploymentType : (string)DeploymentType;}
            {_downloadLocation = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonString>("downloadLocation"), out var __jsonDownloadLocation) ? (string)__jsonDownloadLocation : (string)DownloadLocation;}
            {_externalIP = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonString>("externalIp"), out var __jsonExternalIP) ? (string)__jsonExternalIP : (string)ExternalIP;}
            {_nodes = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonArray>("nodes"), out var __jsonNodes) ? If( __jsonNodes as Wandisco.Fusion.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Wandisco.Fusion.Models.Api20190901Preview.INodeDetails[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Wandisco.Fusion.Models.Api20190901Preview.INodeDetails) (Wandisco.Fusion.Models.Api20190901Preview.NodeDetails.FromJson(__u) )) ))() : null : Nodes;}
            {_provisioningState = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ManagedOnPremZoneProperties" /> into a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Wandisco.Fusion.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Wandisco.Fusion.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ManagedOnPremZoneProperties" /> as a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._deploymentType)?.ToString()) ? (Wandisco.Fusion.Runtime.Json.JsonNode) new Wandisco.Fusion.Runtime.Json.JsonString(this._deploymentType.ToString()) : null, "deploymentType" ,container.Add );
            if (serializationMode.HasFlag(Wandisco.Fusion.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._downloadLocation)?.ToString()) ? (Wandisco.Fusion.Runtime.Json.JsonNode) new Wandisco.Fusion.Runtime.Json.JsonString(this._downloadLocation.ToString()) : null, "downloadLocation" ,container.Add );
            }
            AddIf( null != (((object)this._externalIP)?.ToString()) ? (Wandisco.Fusion.Runtime.Json.JsonNode) new Wandisco.Fusion.Runtime.Json.JsonString(this._externalIP.ToString()) : null, "externalIp" ,container.Add );
            if (serializationMode.HasFlag(Wandisco.Fusion.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._nodes)
                {
                    var __w = new Wandisco.Fusion.Runtime.Json.XNodeArray();
                    foreach( var __x in this._nodes )
                    {
                        AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                    }
                    container.Add("nodes",__w);
                }
            }
            if (serializationMode.HasFlag(Wandisco.Fusion.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Wandisco.Fusion.Runtime.Json.JsonNode) new Wandisco.Fusion.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}