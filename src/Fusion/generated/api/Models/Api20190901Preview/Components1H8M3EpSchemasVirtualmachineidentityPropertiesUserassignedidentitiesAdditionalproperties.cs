namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    public partial class Components1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties :
        Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties,
        Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalpropertiesInternal
    {

        /// <summary>Backing field for <see cref="ClientId" /> property.</summary>
        private string _clientId;

        /// <summary>The client id of user assigned identity.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string ClientId { get => this._clientId; }

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>The principal id of user assigned identity.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; }

        /// <summary>Internal Acessors for ClientId</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalpropertiesInternal.ClientId { get => this._clientId; set { {_clientId = value;} } }

        /// <summary>Internal Acessors for PrincipalId</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalpropertiesInternal.PrincipalId { get => this._principalId; set { {_principalId = value;} } }

        /// <summary>
        /// Creates an new <see cref="Components1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties"
        /// /> instance.
        /// </summary>
        public Components1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties()
        {

        }
    }
    public partial interface IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>The client id of user assigned identity.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The client id of user assigned identity.",
        SerializedName = @"clientId",
        PossibleTypes = new [] { typeof(string) })]
        string ClientId { get;  }
        /// <summary>The principal id of user assigned identity.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The principal id of user assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get;  }

    }
    internal partial interface IComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalpropertiesInternal

    {
        /// <summary>The client id of user assigned identity.</summary>
        string ClientId { get; set; }
        /// <summary>The principal id of user assigned identity.</summary>
        string PrincipalId { get; set; }

    }
}