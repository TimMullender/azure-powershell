namespace Wandisco.Fusion.Models.Api20190901Preview
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>Hive Replication Rule</summary>
    public partial class HiveReplicationRule :
        Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRule,
        Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal,
        Wandisco.Fusion.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Wandisco.Fusion.Models.Api20190901Preview.IResource" />
        /// </summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IResource __resource = new Wandisco.Fusion.Models.Api20190901Preview.Resource();

        /// <summary>The simple pattern of the Database as a mapped path determined by Fusion.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string DbNamePattern { get => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRulePropertiesInternal)Properties).DbNamePattern; set => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRulePropertiesInternal)Properties).DbNamePattern = value; }

        /// <summary>Azure resource Id.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string Id { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Id; }

        /// <summary>Location of the resource.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string Location { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Location; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Location = value; }

        /// <summary>Azure resource name.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string Name { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Properties" /> property.</summary>
        private Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleProperties _properties;

        /// <summary>hive replication rule properties</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Owned)]
        internal Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleProperties Properties { get => (this._properties = this._properties ?? new Wandisco.Fusion.Models.Api20190901Preview.HiveReplicationRuleProperties()); set => this._properties = value; }

        /// <summary>Provisioning State of resource</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRulePropertiesInternal)Properties).ProvisioningState; }

        /// <summary>The number of database where consistency check status is CONSISTENT</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? RecentConsistencyReportConsistent { get => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRulePropertiesInternal)Properties).RecentConsistencyReportConsistent; set => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRulePropertiesInternal)Properties).RecentConsistencyReportConsistent = value; }

        /// <summary>The number of database where consistency check status is FAILED</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? RecentConsistencyReportFailed { get => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRulePropertiesInternal)Properties).RecentConsistencyReportFailed; set => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRulePropertiesInternal)Properties).RecentConsistencyReportFailed = value; }

        /// <summary>The number of database where consistency check status is INCONSISTENT</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? RecentConsistencyReportInconsistent { get => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRulePropertiesInternal)Properties).RecentConsistencyReportInconsistent; set => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRulePropertiesInternal)Properties).RecentConsistencyReportInconsistent = value; }

        /// <summary>The number of database where consistency check status is RUNNING</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? RecentConsistencyReportRunning { get => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRulePropertiesInternal)Properties).RecentConsistencyReportRunning; set => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRulePropertiesInternal)Properties).RecentConsistencyReportRunning = value; }

        /// <summary>The number of database where consistency check status is UNKNOWN</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public long? RecentConsistencyReportUnknown { get => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRulePropertiesInternal)Properties).RecentConsistencyReportUnknown; set => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRulePropertiesInternal)Properties).RecentConsistencyReportUnknown = value; }

        /// <summary>The simple pattern of the Table Name as a mapped path as determined by Fusion.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inlined)]
        public string TableNamePattern { get => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRulePropertiesInternal)Properties).TableNamePattern; set => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRulePropertiesInternal)Properties).TableNamePattern = value; }

        /// <summary>resource tags.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public Wandisco.Fusion.Models.Api20190901Preview.IResourceTags Tags { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Tags; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Tags = value; }

        /// <summary>Azure resource type.</summary>
        [Wandisco.Fusion.Origin(Wandisco.Fusion.PropertyOrigin.Inherited)]
        public string Type { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Type; }

        /// <summary>Internal Acessors for Properties</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleProperties Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal.Properties { get => (this._properties = this._properties ?? new Wandisco.Fusion.Models.Api20190901Preview.HiveReplicationRuleProperties()); set { {_properties = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Wandisco.Fusion.Support.ProvisioningState? Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal.ProvisioningState { get => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRulePropertiesInternal)Properties).ProvisioningState; set => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRulePropertiesInternal)Properties).ProvisioningState = value; }

        /// <summary>Internal Acessors for RecentConsistencyReport</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReport Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleInternal.RecentConsistencyReport { get => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRulePropertiesInternal)Properties).RecentConsistencyReport; set => ((Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRulePropertiesInternal)Properties).RecentConsistencyReport = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal.Id { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Id; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal.Name { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Name; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal.Type { get => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Type; set => ((Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal)__resource).Type = value; }

        /// <summary>Creates an new <see cref="HiveReplicationRule" /> instance.</summary>
        public HiveReplicationRule()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Wandisco.Fusion.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Wandisco.Fusion.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Hive Replication Rule
    public partial interface IHiveReplicationRule :
        Wandisco.Fusion.Runtime.IJsonSerializable,
        Wandisco.Fusion.Models.Api20190901Preview.IResource
    {
        /// <summary>The simple pattern of the Database as a mapped path determined by Fusion.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The simple pattern of the Database as a mapped path determined by Fusion.",
        SerializedName = @"dbNamePattern",
        PossibleTypes = new [] { typeof(string) })]
        string DbNamePattern { get; set; }
        /// <summary>Provisioning State of resource</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning State of resource",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Wandisco.Fusion.Support.ProvisioningState) })]
        Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>The number of database where consistency check status is CONSISTENT</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of database where consistency check status is CONSISTENT",
        SerializedName = @"consistent",
        PossibleTypes = new [] { typeof(long) })]
        long? RecentConsistencyReportConsistent { get; set; }
        /// <summary>The number of database where consistency check status is FAILED</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of database where consistency check status is FAILED",
        SerializedName = @"failed",
        PossibleTypes = new [] { typeof(long) })]
        long? RecentConsistencyReportFailed { get; set; }
        /// <summary>The number of database where consistency check status is INCONSISTENT</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of database where consistency check status is INCONSISTENT",
        SerializedName = @"inconsistent",
        PossibleTypes = new [] { typeof(long) })]
        long? RecentConsistencyReportInconsistent { get; set; }
        /// <summary>The number of database where consistency check status is RUNNING</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of database where consistency check status is RUNNING",
        SerializedName = @"running",
        PossibleTypes = new [] { typeof(long) })]
        long? RecentConsistencyReportRunning { get; set; }
        /// <summary>The number of database where consistency check status is UNKNOWN</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of database where consistency check status is UNKNOWN",
        SerializedName = @"unknown",
        PossibleTypes = new [] { typeof(long) })]
        long? RecentConsistencyReportUnknown { get; set; }
        /// <summary>The simple pattern of the Table Name as a mapped path as determined by Fusion.</summary>
        [Wandisco.Fusion.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The simple pattern of the Table Name as a mapped path as determined by Fusion.",
        SerializedName = @"tableNamePattern",
        PossibleTypes = new [] { typeof(string) })]
        string TableNamePattern { get; set; }

    }
    /// Hive Replication Rule
    internal partial interface IHiveReplicationRuleInternal :
        Wandisco.Fusion.Models.Api20190901Preview.IResourceInternal
    {
        /// <summary>The simple pattern of the Database as a mapped path determined by Fusion.</summary>
        string DbNamePattern { get; set; }
        /// <summary>hive replication rule properties</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IHiveReplicationRuleProperties Properties { get; set; }
        /// <summary>Provisioning State of resource</summary>
        Wandisco.Fusion.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>A report of the most recent consistency check completed for this rule</summary>
        Wandisco.Fusion.Models.Api20190901Preview.IHiveConsistencyReport RecentConsistencyReport { get; set; }
        /// <summary>The number of database where consistency check status is CONSISTENT</summary>
        long? RecentConsistencyReportConsistent { get; set; }
        /// <summary>The number of database where consistency check status is FAILED</summary>
        long? RecentConsistencyReportFailed { get; set; }
        /// <summary>The number of database where consistency check status is INCONSISTENT</summary>
        long? RecentConsistencyReportInconsistent { get; set; }
        /// <summary>The number of database where consistency check status is RUNNING</summary>
        long? RecentConsistencyReportRunning { get; set; }
        /// <summary>The number of database where consistency check status is UNKNOWN</summary>
        long? RecentConsistencyReportUnknown { get; set; }
        /// <summary>The simple pattern of the Table Name as a mapped path as determined by Fusion.</summary>
        string TableNamePattern { get; set; }

    }
}