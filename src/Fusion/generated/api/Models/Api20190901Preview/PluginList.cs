namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>The list of Plugins.</summary>
    public partial class PluginList :
        Wandisco.Fusion.Models.Api20190901Preview.IPluginList,
        Wandisco.Fusion.Models.Api20190901Preview.IPluginListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link used to get the next page of Plugin list.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IPlugin[] _value;

        /// <summary>The list of Plugins.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        public Wandisco.Fusion.Models.Api20190901Preview.IPlugin[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PluginList" /> instance.</summary>
        public PluginList()
        {

        }
    }
    /// The list of Plugins.
    public partial interface IPluginList :
        Wandisco.Fusion.Runtime.IJsonSerializable
    {
        /// <summary>The link used to get the next page of Plugin list.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The link used to get the next page of Plugin list.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of Plugins.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of Plugins.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Models.Api20190901Preview.IPlugin) })]
        Wandisco.Fusion.Models.Api20190901Preview.IPlugin[] Value { get; set; }

    }
    /// The list of Plugins.
    internal partial interface IPluginListInternal

    {
        /// <summary>The link used to get the next page of Plugin list.</summary>
        string NextLink { get; set; }
        /// <summary>The list of Plugins.</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IPlugin[] Value { get; set; }

    }
}