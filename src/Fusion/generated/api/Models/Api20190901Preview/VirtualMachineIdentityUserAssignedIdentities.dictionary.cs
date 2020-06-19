namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    public partial class VirtualMachineIdentityUserAssignedIdentities :
        Wandisco.Fusion.Runtime.IAssociativeArray<Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties>
    {
        protected global::System.Collections.Generic.Dictionary<global::System.String,Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties> __additionalProperties = new global::System.Collections.Generic.Dictionary<global::System.String,Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties>();

        global::System.Collections.Generic.IDictionary<global::System.String,Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties> Wandisco.Fusion.Runtime.IAssociativeArray<Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties>.AdditionalProperties { get => __additionalProperties; }

        int Wandisco.Fusion.Runtime.IAssociativeArray<Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties>.Count { get => __additionalProperties.Count; }

        global::System.Collections.Generic.IEnumerable<global::System.String> Wandisco.Fusion.Runtime.IAssociativeArray<Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties>.Keys { get => __additionalProperties.Keys; }

        global::System.Collections.Generic.IEnumerable<Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties> Wandisco.Fusion.Runtime.IAssociativeArray<Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties>.Values { get => __additionalProperties.Values; }

        public Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties this[global::System.String index] { get => __additionalProperties[index]; set => __additionalProperties[index] = value; }

        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(global::System.String key, Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties value) => __additionalProperties.Add( key, value);

        public void Clear() => __additionalProperties.Clear();

        /// <param name="key"></param>
        public bool ContainsKey(global::System.String key) => __additionalProperties.ContainsKey( key);

        /// <param name="source"></param>
        public void CopyFrom(global::System.Collections.IDictionary source)
        {
            if (null != source)
            {
                foreach( var property in  Wandisco.Fusion.Runtime.PowerShell.TypeConverterExtensions.GetFilteredProperties(source, new global::System.Collections.Generic.HashSet<global::System.String>() {  } ) )
                {
                    if ((null != property.Key && null != property.Value))
                    {
                        this.__additionalProperties.Add(property.Key.ToString(), global::System.Management.Automation.LanguagePrimitives.ConvertTo<Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties>( property.Value));
                    }
                }
            }
        }

        /// <param name="source"></param>
        public void CopyFrom(global::System.Management.Automation.PSObject source)
        {
            if (null != source)
            {
                foreach( var property in  Wandisco.Fusion.Runtime.PowerShell.TypeConverterExtensions.GetFilteredProperties(source, new global::System.Collections.Generic.HashSet<global::System.String>() {  } ) )
                {
                    if ((null != property.Key && null != property.Value))
                    {
                        this.__additionalProperties.Add(property.Key.ToString(), global::System.Management.Automation.LanguagePrimitives.ConvertTo<Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties>( property.Value));
                    }
                }
            }
        }

        /// <param name="key"></param>
        public bool Remove(global::System.String key) => __additionalProperties.Remove( key);

        /// <param name="key"></param>
        /// <param name="value"></param>
        public bool TryGetValue(global::System.String key, out Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties value) => __additionalProperties.TryGetValue( key, out value);

        /// <param name="source"></param>

        public static implicit operator global::System.Collections.Generic.Dictionary<global::System.String,Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties>(Wandisco.Fusion.Models.Api20190901Preview.VirtualMachineIdentityUserAssignedIdentities source) => source.__additionalProperties;
    }
}