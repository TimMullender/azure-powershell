namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>azure zone properties</summary>
    public partial class AzureZoneProperties
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
        /// Deserializes a Wandisco.Fusion.Runtime.Json.JsonObject into a new instance of <see cref="AzureZoneProperties" />.
        /// </summary>
        /// <param name="json">A Wandisco.Fusion.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal AzureZoneProperties(Wandisco.Fusion.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_storageManagedIdentity = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonObject>("storageManagedIdentity"), out var __jsonStorageManagedIdentity) ? Wandisco.Fusion.Models.Api20190901Preview.VirtualMachineIdentity.FromJson(__jsonStorageManagedIdentity) : StorageManagedIdentity;}
            {_nodeCount = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonNumber>("nodeCount"), out var __jsonNodeCount) ? (int?)__jsonNodeCount : NodeCount;}
            {_nodes = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonArray>("nodes"), out var __jsonNodes) ? If( __jsonNodes as Wandisco.Fusion.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetails[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Wandisco.Fusion.Models.Api20190901Preview.IAzureNodeDetails) (Wandisco.Fusion.Models.Api20190901Preview.AzureNodeDetails.FromJson(__u) )) ))() : null : Nodes;}
            {_provisioningState = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_storageAccessKey = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonString>("storageAccessKey"), out var __jsonStorageAccessKey) ? (string)__jsonStorageAccessKey : (string)StorageAccessKey;}
            {_storageAccountId = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonString>("storageAccountId"), out var __jsonStorageAccountId) ? (string)__jsonStorageAccountId : (string)StorageAccountId;}
            {_storageContainer = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonString>("storageContainer"), out var __jsonStorageContainer) ? (string)__jsonStorageContainer : (string)StorageContainer;}
            {_subnet = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonString>("subnet"), out var __jsonSubnet) ? (string)__jsonSubnet : (string)Subnet;}
            {_virtualNetworkId = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonString>("virtualNetworkId"), out var __jsonVirtualNetworkId) ? (string)__jsonVirtualNetworkId : (string)VirtualNetworkId;}
            {_vMSize = If( json?.PropertyT<Wandisco.Fusion.Runtime.Json.JsonString>("vmSize"), out var __jsonVMSize) ? (string)__jsonVMSize : (string)VMSize;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode"/> into an instance of Wandisco.Fusion.Models.Api20190901Preview.IAzureZoneProperties.
        /// </summary>
        /// <param name="node">a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Wandisco.Fusion.Models.Api20190901Preview.IAzureZoneProperties.</returns>
        public static Wandisco.Fusion.Models.Api20190901Preview.IAzureZoneProperties FromJson(Wandisco.Fusion.Runtime.Json.JsonNode node)
        {
            return node is Wandisco.Fusion.Runtime.Json.JsonObject json ? new AzureZoneProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="AzureZoneProperties" /> into a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Wandisco.Fusion.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Wandisco.Fusion.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AzureZoneProperties" /> as a <see cref="Wandisco.Fusion.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._storageManagedIdentity ? (Wandisco.Fusion.Runtime.Json.JsonNode) this._storageManagedIdentity.ToJson(null,serializationMode) : null, "storageManagedIdentity" ,container.Add );
            AddIf( null != this._nodeCount ? (Wandisco.Fusion.Runtime.Json.JsonNode)new Wandisco.Fusion.Runtime.Json.JsonNumber((int)this._nodeCount) : null, "nodeCount" ,container.Add );
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
            AddIf( null != (((object)this._storageAccessKey)?.ToString()) ? (Wandisco.Fusion.Runtime.Json.JsonNode) new Wandisco.Fusion.Runtime.Json.JsonString(this._storageAccessKey.ToString()) : null, "storageAccessKey" ,container.Add );
            AddIf( null != (((object)this._storageAccountId)?.ToString()) ? (Wandisco.Fusion.Runtime.Json.JsonNode) new Wandisco.Fusion.Runtime.Json.JsonString(this._storageAccountId.ToString()) : null, "storageAccountId" ,container.Add );
            AddIf( null != (((object)this._storageContainer)?.ToString()) ? (Wandisco.Fusion.Runtime.Json.JsonNode) new Wandisco.Fusion.Runtime.Json.JsonString(this._storageContainer.ToString()) : null, "storageContainer" ,container.Add );
            AddIf( null != (((object)this._subnet)?.ToString()) ? (Wandisco.Fusion.Runtime.Json.JsonNode) new Wandisco.Fusion.Runtime.Json.JsonString(this._subnet.ToString()) : null, "subnet" ,container.Add );
            AddIf( null != (((object)this._virtualNetworkId)?.ToString()) ? (Wandisco.Fusion.Runtime.Json.JsonNode) new Wandisco.Fusion.Runtime.Json.JsonString(this._virtualNetworkId.ToString()) : null, "virtualNetworkId" ,container.Add );
            AddIf( null != (((object)this._vMSize)?.ToString()) ? (Wandisco.Fusion.Runtime.Json.JsonNode) new Wandisco.Fusion.Runtime.Json.JsonString(this._vMSize.ToString()) : null, "vmSize" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}