// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6246, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Sample.API.Cmdlets
{
    using static Sample.API.Runtime.Extensions;

    /// <summary>Create or update fusionGroup resource.</summary>
    /// <remarks>
    /// [OpenAPI] FusionGroups_CreateOrUpdate=>PUT:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Wandisco.Fusion/fusionGroups/{fusionGroupName}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.New, @"FusionGroup_CreateExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Sample.API.Models.IFusionGroup))]
    [global::Sample.API.Description(@"Create or update fusionGroup resource.")]
    [global::Sample.API.Generated]
    public partial class NewFusionGroup_CreateExpanded : global::System.Management.Automation.PSCmdlet,
        Sample.API.Runtime.IEventListener
    {
        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>when specified, runs this cmdlet as a PowerShell job</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command as a job")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter AsJob { get; set; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public Sample.API.WanDiscoFusion Client => Sample.API.Module.Instance.ClientAPI;

        /// <summary>Backing field for <see cref="FusionGroupBody" /> property.</summary>
        private Sample.API.Models.IFusionGroup _fusionGroupBody= new Sample.API.Models.FusionGroup();

        /// <summary>Fusion Group details</summary>
        private Sample.API.Models.IFusionGroup FusionGroupBody { get => this._fusionGroupBody; set => this._fusionGroupBody = value; }

        /// <summary>Backing field for <see cref="FusionGroupName" /> property.</summary>
        private string _fusionGroupName;

        /// <summary>The name of the fusionGroup resource.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the fusionGroup resource.")]
        [Sample.API.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the fusionGroup resource.",
        SerializedName = @"fusionGroupName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Path)]
        public string FusionGroupName { get => this._fusionGroupName; set => this._fusionGroupName = value; }

        /// <summary>
        /// An array indicating what errors, if any, occurred and what to do to resolve them
        /// </summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "An array indicating what errors, if any, occurred and what to do to resolve them")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An array indicating what errors, if any, occurred and what to do to resolve them",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Sample.API.Models.IErrorDefinition) })]
        public Sample.API.Models.IErrorDefinition[] HealthStatusDetails { get => FusionGroupBody.HealthStatusDetails ?? null /* arrayOf */; set => FusionGroupBody.HealthStatusDetails = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Runtime)]
        public Sample.API.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Runtime)]
        public Sample.API.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>Property type label</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Property type label")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Property type label",
        SerializedName = @"label",
        PossibleTypes = new [] { typeof(string) })]
        public string Label { get => FusionGroupBody.Label ?? null; set => FusionGroupBody.Label = value; }

        /// <summary>Location of the resource.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Location of the resource.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Location of the resource.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        public string Location { get => FusionGroupBody.Location ?? null; set => FusionGroupBody.Location = value; }

        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Sample.API.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Sample.API.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// when specified, will make the remote call, and return an AsyncOperationResponse, letting the remote operation continue
        /// asynchronously.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command asynchronously")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter NoWait { get; set; }

        /// <summary>
        /// The instance of the <see cref="Sample.API.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private Sample.API.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>A user defined name of the 3rd Party Artifact that is being procured.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "A user defined name of the 3rd Party Artifact that is being procured.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A user defined name of the 3rd Party Artifact that is being procured.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        public string PlanName { get => FusionGroupBody.PlanName ?? null; set => FusionGroupBody.PlanName = value; }

        /// <summary>
        /// The 3rd Party artifact that is being procured. E.g. NewRelic. Product maps to the OfferID specified for the artifact at
        /// the time of Data Market onboarding.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The 3rd Party artifact that is being procured. E.g. NewRelic. Product maps to the OfferID specified for the artifact at the time of Data Market onboarding. ")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The 3rd Party artifact that is being procured. E.g. NewRelic. Product maps to the OfferID specified for the artifact at the time of Data Market onboarding. ",
        SerializedName = @"product",
        PossibleTypes = new [] { typeof(string) })]
        public string PlanProduct { get => FusionGroupBody.PlanProduct ?? null; set => FusionGroupBody.PlanProduct = value; }

        /// <summary>
        /// A publisher provided promotion code as provisioned in Data Market for the said product/artifact.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "A publisher provided promotion code as provisioned in Data Market for the said product/artifact.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A publisher provided promotion code as provisioned in Data Market for the said product/artifact.",
        SerializedName = @"promotionCode",
        PossibleTypes = new [] { typeof(string) })]
        public string PlanPromotionCode { get => FusionGroupBody.PlanPromotionCode ?? null; set => FusionGroupBody.PlanPromotionCode = value; }

        /// <summary>The publisher of the 3rd Party Artifact that is being bought. E.g. NewRelic</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The publisher of the 3rd Party Artifact that is being bought. E.g. NewRelic")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The publisher of the 3rd Party Artifact that is being bought. E.g. NewRelic",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        public string PlanPublisher { get => FusionGroupBody.PlanPublisher ?? null; set => FusionGroupBody.PlanPublisher = value; }

        /// <summary>The version of the desired product/artifact.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The version of the desired product/artifact.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of the desired product/artifact.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        public string PlanVersion { get => FusionGroupBody.PlanVersion ?? null; set => FusionGroupBody.PlanVersion = value; }

        /// <summary>Health Status</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Health Status")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Health Status",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Sample.API.Support.HealthStatusSummary) })]
        [global::System.Management.Automation.ArgumentCompleter(typeof(Sample.API.Support.HealthStatusSummary))]
        public Sample.API.Support.HealthStatusSummary PropertiesHealthStatusStatus { get => FusionGroupBody.PropertiesHealthStatusStatus ?? ((Sample.API.Support.HealthStatusSummary)""); set => FusionGroupBody.PropertiesHealthStatusStatus = value; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the resource group.")]
        [Sample.API.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the resource group.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Path)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The Azure subscription ID.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The Azure subscription ID.")]
        [Sample.API.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The Azure subscription ID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Path)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>resource tags.</summary>
        [global::Sample.API.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "resource tags.")]
        [global::Sample.API.Category(global::Sample.API.ParameterCategory.Body)]
        [Sample.API.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Sample.API.Models.IResourceTags) })]
        public Sample.API.Models.IResourceTags Tags { get => FusionGroupBody.Tags ?? null /* object */; set => FusionGroupBody.Tags = value; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Sample.API.Models.IErrorResponse" /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Sample.API.Models.IErrorResponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Sample.API.Models.IFusionGroup" /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Sample.API.Models.IFusionGroup> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Sample.API.Runtime.AttachDebugger.Break();
            }
            ((Sample.API.Runtime.IEventListener)this).Signal(Sample.API.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Sample.API.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Creates a duplicate instance of this cmdlet (via JSON serialization).</summary>
        /// <returns>a duplicate instance of NewFusionGroup_CreateExpanded</returns>
        public Sample.API.Cmdlets.NewFusionGroup_CreateExpanded Clone()
        {
            var clone = new NewFusionGroup_CreateExpanded();
            clone.InvocationInformation = this.InvocationInformation;
            clone.Proxy = this.Proxy;
            clone.Pipeline = this.Pipeline;
            clone.AsJob = this.AsJob;
            clone.Break = this.Break;
            clone.ProxyCredential = this.ProxyCredential;
            clone.ProxyUseDefaultCredentials = this.ProxyUseDefaultCredentials;
            clone.HttpPipelinePrepend = this.HttpPipelinePrepend;
            clone.HttpPipelineAppend = this.HttpPipelineAppend;
            clone.FusionGroupBody = this.FusionGroupBody;
            clone.ResourceGroupName = this.ResourceGroupName;
            clone.SubscriptionId = this.SubscriptionId;
            clone.FusionGroupName = this.FusionGroupName;
            return clone;
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            ((Sample.API.Runtime.IEventListener)this).Signal(Sample.API.Runtime.Events.CmdletEndProcessing).Wait(); if( ((Sample.API.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task Sample.API.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Sample.API.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Sample.API.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Sample.API.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Sample.API.Runtime.Events.Information:
                    {
                        // When an operation supports asjob, Information messages must go thru verbose.
                        WriteVerbose($"INFORMATION: {(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Sample.API.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Sample.API.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                    case Sample.API.Runtime.Events.DelayBeforePolling:
                    {
                        if (true == MyInvocation?.BoundParameters?.ContainsKey("NoWait"))
                        {
                            var data = messageData();
                            if (data.ResponseMessage is System.Net.Http.HttpResponseMessage response)
                            {
                                var asyncOperation = response.GetFirstHeader(@"Azure-AsyncOperation");
                                var location = response.GetFirstHeader(@"Location");
                                var uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? response.RequestMessage.RequestUri.AbsoluteUri : location : asyncOperation;
                                WriteObject(new Sample.API.Runtime.PowerShell.AsyncOperationResponse { Target = uri });
                                // do nothing more.
                                data.Cancel();
                                return;
                            }
                        }
                        break;
                    }
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="NewFusionGroup_CreateExpanded" /> cmdlet class.
        /// </summary>
        public NewFusionGroup_CreateExpanded()
        {

        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Sample.API.Runtime.IEventListener)this).Signal(Sample.API.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Sample.API.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            try
            {
                // work
                if (ShouldProcess($"Call remote 'FusionGroupsCreateOrUpdate' operation"))
                {
                    if (true == MyInvocation?.BoundParameters?.ContainsKey("AsJob"))
                    {
                        var instance = this.Clone();
                        var job = new Sample.API.Runtime.PowerShell.AsyncJob(instance, this.MyInvocation.Line, this.MyInvocation.MyCommand.Name, this._cancellationTokenSource.Token, this._cancellationTokenSource.Cancel);
                        JobRepository.Add(job);
                        var task = instance.ProcessRecordAsync();
                        job.Monitor(task);
                        WriteObject(job);
                    }
                    else
                    {
                        using( var asyncCommandRuntime = new Sample.API.Runtime.PowerShell.AsyncCommandRuntime(this, ((Sample.API.Runtime.IEventListener)this).Token) )
                        {
                            asyncCommandRuntime.Wait( ProcessRecordAsync(),((Sample.API.Runtime.IEventListener)this).Token);
                        }
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Sample.API.Runtime.IEventListener)this).Signal(Sample.API.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Sample.API.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Sample.API.Runtime.IEventListener)this).Signal(Sample.API.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Sample.API.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Sample.API.Runtime.IEventListener)this).Signal(Sample.API.Runtime.Events.CmdletProcessRecordEnd).Wait();
            }
        }

        /// <summary>Performs execution of the command, working asynchronously if required.</summary>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        protected async global::System.Threading.Tasks.Task ProcessRecordAsync()
        {
            using( NoSynchronizationContext )
            {
                await ((Sample.API.Runtime.IEventListener)this).Signal(Sample.API.Runtime.Events.CmdletProcessRecordAsyncStart); if( ((Sample.API.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                await ((Sample.API.Runtime.IEventListener)this).Signal(Sample.API.Runtime.Events.CmdletGetPipeline); if( ((Sample.API.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Sample.API.Module.Instance.CreatePipeline(InvocationInformation, this.ParameterSetName);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Sample.API.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Sample.API.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Sample.API.Runtime.IEventListener)this).Signal(Sample.API.Runtime.Events.CmdletBeforeAPICall); if( ((Sample.API.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    await this.Client.FusionGroupsCreateOrUpdate(ResourceGroupName, SubscriptionId, FusionGroupName, FusionGroupBody, onOk, onDefault, this, Pipeline);
                    await ((Sample.API.Runtime.IEventListener)this).Signal(Sample.API.Runtime.Events.CmdletAfterAPICall); if( ((Sample.API.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Sample.API.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  ResourceGroupName=ResourceGroupName,SubscriptionId=SubscriptionId,FusionGroupName=FusionGroupName,body=FusionGroupBody})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Sample.API.Runtime.IEventListener)this).Signal(Sample.API.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Sample.API.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Sample.API.Models.IErrorResponse" /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Sample.API.Models.IErrorResponse> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnDefault(responseMessage, response, ref _returnNow);
                // if overrideOnDefault has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // Error Response : default
                var code = (await response)?.Code;
                var message = (await response)?.Message;
                if ((null == code || null == message))
                {
                    // Unrecognized Response. Create an error record based on what we have.
                    var ex = new Sample.API.Runtime.RestException<Sample.API.Models.IErrorResponse>(responseMessage, await response);
                    WriteError( new global::System.Management.Automation.ErrorRecord(ex, ex.Code, global::System.Management.Automation.ErrorCategory.InvalidOperation, new { ResourceGroupName=ResourceGroupName, SubscriptionId=SubscriptionId, FusionGroupName=FusionGroupName, body=FusionGroupBody })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(ex.Message) { RecommendedAction = ex.Action }
                    });
                }
                else
                {
                    WriteError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception($"[{code}] : {message}"), code?.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { ResourceGroupName=ResourceGroupName, SubscriptionId=SubscriptionId, FusionGroupName=FusionGroupName, body=FusionGroupBody })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(message) { RecommendedAction = global::System.String.Empty }
                    });
                }
            }
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Sample.API.Models.IFusionGroup" /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Sample.API.Models.IFusionGroup> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnOk(responseMessage, response, ref _returnNow);
                // if overrideOnOk has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onOk - response for 200 / application/json
                // (await response) // should be Sample.API.Models.IFusionGroup
                WriteObject((await response));
            }
        }
    }
}