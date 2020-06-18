// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Wandisco.Fusion.Cmdlets
{
    using static Wandisco.Fusion.Runtime.Extensions;

    /// <summary>List migrations in replication rule</summary>
    /// <remarks>
    /// [OpenAPI] Migrations_ListByReplicationRule=>GET:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Wandisco.Fusion/fusionGroups/{fusionGroupName}/replicationRules/{replicationRuleName}/migrations"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.Get, @"Migration_List")]
    [global::System.Management.Automation.OutputType(typeof(Wandisco.Fusion.Models.Api20190901Preview.IMigration))]
    [global::Wandisco.Fusion.Description(@"List migrations in replication rule")]
    [global::Wandisco.Fusion.Generated]
    public partial class GetMigration_List : global::System.Management.Automation.PSCmdlet,
        Wandisco.Fusion.Runtime.IEventListener
    {
        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Wandisco.Fusion.Category(global::Wandisco.Fusion.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public Wandisco.Fusion.WanDiscoFusion Client => Wandisco.Fusion.Module.Instance.ClientAPI;

        /// <summary>Backing field for <see cref="FusionGroupName" /> property.</summary>
        private string _fusionGroupName;

        /// <summary>The name of the fusionGroup resource.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the fusionGroup resource.")]
        [Wandisco.Fusion.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the fusionGroup resource.",
        SerializedName = @"fusionGroupName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Wandisco.Fusion.Category(global::Wandisco.Fusion.ParameterCategory.Path)]
        public string FusionGroupName { get => this._fusionGroupName; set => this._fusionGroupName = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Wandisco.Fusion.Category(global::Wandisco.Fusion.ParameterCategory.Runtime)]
        public Wandisco.Fusion.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Wandisco.Fusion.Category(global::Wandisco.Fusion.ParameterCategory.Runtime)]
        public Wandisco.Fusion.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Wandisco.Fusion.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Wandisco.Fusion.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// The instance of the <see cref="Wandisco.Fusion.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private Wandisco.Fusion.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Wandisco.Fusion.Category(global::Wandisco.Fusion.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Wandisco.Fusion.Category(global::Wandisco.Fusion.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Wandisco.Fusion.Category(global::Wandisco.Fusion.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>Backing field for <see cref="ReplicationRuleName" /> property.</summary>
        private string _replicationRuleName;

        /// <summary>The name of the replicationRule</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the replicationRule")]
        [Wandisco.Fusion.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the replicationRule",
        SerializedName = @"replicationRuleName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Wandisco.Fusion.Category(global::Wandisco.Fusion.ParameterCategory.Path)]
        public string ReplicationRuleName { get => this._replicationRuleName; set => this._replicationRuleName = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the resource group.")]
        [Wandisco.Fusion.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the resource group.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Wandisco.Fusion.Category(global::Wandisco.Fusion.ParameterCategory.Path)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The Azure subscription ID.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The Azure subscription ID.")]
        [Wandisco.Fusion.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The Azure subscription ID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        [global::Wandisco.Fusion.Category(global::Wandisco.Fusion.ParameterCategory.Path)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Wandisco.Fusion.Models.Api20190901Preview.IErrorResponse" /> from
        /// the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Wandisco.Fusion.Models.Api20190901Preview.IErrorResponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Wandisco.Fusion.Models.Api20190901Preview.IMigrationList" /> from
        /// the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Wandisco.Fusion.Models.Api20190901Preview.IMigrationList> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Wandisco.Fusion.Runtime.AttachDebugger.Break();
            }
            ((Wandisco.Fusion.Runtime.IEventListener)this).Signal(Wandisco.Fusion.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Wandisco.Fusion.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            ((Wandisco.Fusion.Runtime.IEventListener)this).Signal(Wandisco.Fusion.Runtime.Events.CmdletEndProcessing).Wait(); if( ((Wandisco.Fusion.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Intializes a new instance of the <see cref="GetMigration_List" /> cmdlet class.</summary>
        public GetMigration_List()
        {

        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task Wandisco.Fusion.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Wandisco.Fusion.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Wandisco.Fusion.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Wandisco.Fusion.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Wandisco.Fusion.Runtime.Events.Information:
                    {
                        var data = messageData();
                        WriteInformation(data, new[] { data.Message });
                        return ;
                    }
                    case Wandisco.Fusion.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Wandisco.Fusion.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Wandisco.Fusion.Runtime.IEventListener)this).Signal(Wandisco.Fusion.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Wandisco.Fusion.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            try
            {
                // work
                using( var asyncCommandRuntime = new Wandisco.Fusion.Runtime.PowerShell.AsyncCommandRuntime(this, ((Wandisco.Fusion.Runtime.IEventListener)this).Token) )
                {
                    asyncCommandRuntime.Wait( ProcessRecordAsync(),((Wandisco.Fusion.Runtime.IEventListener)this).Token);
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Wandisco.Fusion.Runtime.IEventListener)this).Signal(Wandisco.Fusion.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Wandisco.Fusion.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Wandisco.Fusion.Runtime.IEventListener)this).Signal(Wandisco.Fusion.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Wandisco.Fusion.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Wandisco.Fusion.Runtime.IEventListener)this).Signal(Wandisco.Fusion.Runtime.Events.CmdletProcessRecordEnd).Wait();
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
                await ((Wandisco.Fusion.Runtime.IEventListener)this).Signal(Wandisco.Fusion.Runtime.Events.CmdletProcessRecordAsyncStart); if( ((Wandisco.Fusion.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                await ((Wandisco.Fusion.Runtime.IEventListener)this).Signal(Wandisco.Fusion.Runtime.Events.CmdletGetPipeline); if( ((Wandisco.Fusion.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Wandisco.Fusion.Module.Instance.CreatePipeline(InvocationInformation, this.ParameterSetName);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Wandisco.Fusion.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Wandisco.Fusion.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Wandisco.Fusion.Runtime.IEventListener)this).Signal(Wandisco.Fusion.Runtime.Events.CmdletBeforeAPICall); if( ((Wandisco.Fusion.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    await this.Client.MigrationsListByReplicationRule(ResourceGroupName, SubscriptionId, FusionGroupName, ReplicationRuleName, onOk, onDefault, this, Pipeline);
                    await ((Wandisco.Fusion.Runtime.IEventListener)this).Signal(Wandisco.Fusion.Runtime.Events.CmdletAfterAPICall); if( ((Wandisco.Fusion.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Wandisco.Fusion.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  ResourceGroupName=ResourceGroupName,SubscriptionId=SubscriptionId,FusionGroupName=FusionGroupName,ReplicationRuleName=ReplicationRuleName})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Wandisco.Fusion.Runtime.IEventListener)this).Signal(Wandisco.Fusion.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Wandisco.Fusion.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Wandisco.Fusion.Models.Api20190901Preview.IErrorResponse" /> from
        /// the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Wandisco.Fusion.Models.Api20190901Preview.IErrorResponse> response)
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
                    var ex = new Wandisco.Fusion.Runtime.RestException<Wandisco.Fusion.Models.Api20190901Preview.IErrorResponse>(responseMessage, await response);
                    WriteError( new global::System.Management.Automation.ErrorRecord(ex, ex.Code, global::System.Management.Automation.ErrorCategory.InvalidOperation, new { ResourceGroupName=ResourceGroupName, SubscriptionId=SubscriptionId, FusionGroupName=FusionGroupName, ReplicationRuleName=ReplicationRuleName })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(ex.Message) { RecommendedAction = ex.Action }
                    });
                }
                else
                {
                    WriteError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception($"[{code}] : {message}"), code?.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { ResourceGroupName=ResourceGroupName, SubscriptionId=SubscriptionId, FusionGroupName=FusionGroupName, ReplicationRuleName=ReplicationRuleName })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(message) { RecommendedAction = global::System.String.Empty }
                    });
                }
            }
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Wandisco.Fusion.Models.Api20190901Preview.IMigrationList" /> from
        /// the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Wandisco.Fusion.Models.Api20190901Preview.IMigrationList> response)
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
                // response should be returning an array of some kind. +Pageable
                // pageable / value / nextLink
                var result = await response;
                WriteObject(result.Value,true);
                if (result.NextLink != null)
                {
                    if (responseMessage.RequestMessage is System.Net.Http.HttpRequestMessage requestMessage )
                    {
                        requestMessage = requestMessage.Clone(new global::System.Uri( result.NextLink ),Wandisco.Fusion.Runtime.Method.Get );
                        await ((Wandisco.Fusion.Runtime.IEventListener)this).Signal(Wandisco.Fusion.Runtime.Events.FollowingNextLink); if( ((Wandisco.Fusion.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                        await this.Client.MigrationsListByReplicationRule_Call(requestMessage, onOk, onDefault, this, Pipeline);
                    }
                }
            }
        }
    }
}