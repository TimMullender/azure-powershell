namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>An Azure resource.</summary>
    public partial class Resource :
        Wandisco.Fusion.Models.Api20190901Preview.IResource,
        Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Azure resource Id.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>Location of the resource.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Azure resource name.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Tags" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IResourceTags _tags;

        /// <summary>resource tags.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Models.Api20190901Preview.IResourceTags Tags { get => (this._tags = this._tags ?? new Wandisco.Fusion.Models.Api20190901Preview.ResourceTags()); set => this._tags = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Azure resource type.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Internal Acessors for Id</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Creates an new <see cref="Resource" /> instance.</summary>
        public Resource()
        {

        }
    }
    /// An Azure resource.
    public partial interface IResource :
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
        /// <summary>Location of the resource.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Location of the resource.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>Azure resource name.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Azure resource name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>resource tags.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Models.Api20190901Preview.IResourceTags) })]
        Wandisco.Fusion.Models.Api20190901Preview.IResourceTags Tags { get; set; }
        /// <summary>Azure resource type.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Azure resource type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// An Azure resource.
    internal partial interface IResourceInternal

    {
        /// <summary>Azure resource Id.</summary>
        string Id { get; set; }
        /// <summary>Location of the resource.</summary>
        string Location { get; set; }
        /// <summary>Azure resource name.</summary>
        string Name { get; set; }
        /// <summary>resource tags.</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IResourceTags Tags { get; set; }
        /// <summary>Azure resource type.</summary>
        string Type { get; set; }

    }
}