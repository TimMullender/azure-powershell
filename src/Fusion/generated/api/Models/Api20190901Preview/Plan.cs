namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Plan for the resource.</summary>
    public partial class Plan :
        Wandisco.Fusion.Models.Api20190901Preview.IPlan,
        Wandisco.Fusion.Models.Api20190901Preview.IPlanInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>A user defined name of the 3rd Party Artifact that is being procured.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Product" /> property.</summary>
        private string _product;

        /// <summary>
        /// The 3rd Party artifact that is being procured. E.g. NewRelic. Product maps to the OfferID specified for the artifact at
        /// the time of Data Market onboarding.
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Product { get => this._product; set => this._product = value; }

        /// <summary>Backing field for <see cref="PromotionCode" /> property.</summary>
        private string _promotionCode;

        /// <summary>
        /// A publisher provided promotion code as provisioned in Data Market for the said product/artifact.
        /// </summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string PromotionCode { get => this._promotionCode; set => this._promotionCode = value; }

        /// <summary>Backing field for <see cref="Publisher" /> property.</summary>
        private string _publisher;

        /// <summary>The publisher of the 3rd Party Artifact that is being bought. E.g. NewRelic</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Publisher { get => this._publisher; set => this._publisher = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>The version of the desired product/artifact.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="Plan" /> instance.</summary>
        public Plan()
        {

        }
    }
    /// Plan for the resource.
    public partial interface IPlan :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>A user defined name of the 3rd Party Artifact that is being procured.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"A user defined name of the 3rd Party Artifact that is being procured.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// The 3rd Party artifact that is being procured. E.g. NewRelic. Product maps to the OfferID specified for the artifact at
        /// the time of Data Market onboarding.
        /// </summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The 3rd Party artifact that is being procured. E.g. NewRelic. Product maps to the OfferID specified for the artifact at the time of Data Market onboarding. ",
        SerializedName = @"product",
        PossibleTypes = new [] { typeof(string) })]
        string Product { get; set; }
        /// <summary>
        /// A publisher provided promotion code as provisioned in Data Market for the said product/artifact.
        /// </summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A publisher provided promotion code as provisioned in Data Market for the said product/artifact.",
        SerializedName = @"promotionCode",
        PossibleTypes = new [] { typeof(string) })]
        string PromotionCode { get; set; }
        /// <summary>The publisher of the 3rd Party Artifact that is being bought. E.g. NewRelic</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The publisher of the 3rd Party Artifact that is being bought. E.g. NewRelic",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string Publisher { get; set; }
        /// <summary>The version of the desired product/artifact.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of the desired product/artifact.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// Plan for the resource.
    internal partial interface IPlanInternal

    {
        /// <summary>A user defined name of the 3rd Party Artifact that is being procured.</summary>
        string Name { get; set; }
        /// <summary>
        /// The 3rd Party artifact that is being procured. E.g. NewRelic. Product maps to the OfferID specified for the artifact at
        /// the time of Data Market onboarding.
        /// </summary>
        string Product { get; set; }
        /// <summary>
        /// A publisher provided promotion code as provisioned in Data Market for the said product/artifact.
        /// </summary>
        string PromotionCode { get; set; }
        /// <summary>The publisher of the 3rd Party Artifact that is being bought. E.g. NewRelic</summary>
        string Publisher { get; set; }
        /// <summary>The version of the desired product/artifact.</summary>
        string Version { get; set; }

    }
}