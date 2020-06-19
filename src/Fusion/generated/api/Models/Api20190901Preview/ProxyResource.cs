namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>An azure proxy resource</summary>
    public partial class ProxyResource :
        Wandisco.Fusion.Models.Api20190901Preview.IProxyResource,
        Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Azure resource Id.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Azure resource name.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Azure resource type.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Internal Acessors for Id</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IProxyResourceInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Creates an new <see cref="ProxyResource" /> instance.</summary>
        public ProxyResource()
        {

        }
    }
    /// An azure proxy resource
    public partial interface IProxyResource :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>Azure resource Id.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Azure resource Id.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>Azure resource name.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Azure resource name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>Azure resource type.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Azure resource type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// An azure proxy resource
    internal partial interface IProxyResourceInternal

    {
        /// <summary>Azure resource Id.</summary>
        string Id { get; set; }
        /// <summary>Azure resource name.</summary>
        string Name { get; set; }
        /// <summary>Azure resource type.</summary>
        string Type { get; set; }

    }
}