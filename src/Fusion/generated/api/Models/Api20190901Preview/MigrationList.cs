namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>The list of Migrations.</summary>
    public partial class MigrationList :
        Wandisco.Fusion.Models.Api20190901Preview.IMigrationList,
        Wandisco.Fusion.Models.Api20190901Preview.IMigrationListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link used to get the next page of Migrations list.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IMigration[] _value;

        /// <summary>The list of migrations</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Models.Api20190901Preview.IMigration[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="MigrationList" /> instance.</summary>
        public MigrationList()
        {

        }
    }
    /// The list of Migrations.
    public partial interface IMigrationList :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>The link used to get the next page of Migrations list.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The link used to get the next page of Migrations list.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of migrations</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of migrations",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Models.Api20190901Preview.IMigration) })]
        Wandisco.Fusion.Models.Api20190901Preview.IMigration[] Value { get; set; }

    }
    /// The list of Migrations.
    internal partial interface IMigrationListInternal

    {
        /// <summary>The link used to get the next page of Migrations list.</summary>
        string NextLink { get; set; }
        /// <summary>The list of migrations</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IMigration[] Value { get; set; }

    }
}