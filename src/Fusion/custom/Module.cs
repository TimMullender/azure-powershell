namespace Wandisco.Fusion
{
    using Microsoft.Azure.Commands.Common.Authentication;
    using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
    using Runtime;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;


    /// <summary>A class that contains the module-common code and data.</summary>
    /// <notes>
    /// This class is where you can add things to modify the module.
    /// As long as it's in the 'custom' folder, it won't get deleted
    /// when you use --clear-output-folder in autorest.
    /// </notes>
    public partial class Module
    {
        partial void CustomInit()
        {
            // we need to add a step at the end of the pipeline 
            // to attach the API key 

            // once for the regular pipeline
            this._pipeline.Append(AddToken);

            // once for the pipeline that supports a proxy
            this._pipelineWithProxy.Append(AddToken);
        }

        protected async Task<HttpResponseMessage> AddToken(HttpRequestMessage request, IEventListener callback, ISendAsync next)
        {
            // TODO This is a hack at getting auth working, it needs checks added and defaults looked at for cancellation and creds URL
            IAzureContext context = AzureRmProfileProvider.Instance.Profile.DefaultContext;
            var credentials = AzureSession.Instance.AuthenticationFactory.GetServiceClientCredentials(context);
            await credentials.ProcessHttpRequestAsync(request, default(CancellationToken)).ConfigureAwait(false);
            return await next.SendAsync(request, callback);
        }
    }
}