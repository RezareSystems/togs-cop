using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rezare.TogsCop.Integration.WorkFlowMax.Api
{
    internal class AuthenticatedHttpClientHandler : DelegatingHandler
    {
        private readonly Func<Task<WorkFlowMaxApiSettings>> _getSettings;

        public AuthenticatedHttpClientHandler(HttpClientHandler nestedHandler, Func<Task<WorkFlowMaxApiSettings>> getSettings)
        {
            _getSettings = getSettings;
            InnerHandler = nestedHandler;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var settings = await _getSettings().ConfigureAwait(false);
            request.RequestUri = GetUri(request.RequestUri, settings);

            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }

        private Uri GetUri(Uri requestUri, WorkFlowMaxApiSettings settings)
        {
            var requestUriBuilder = new StringBuilder(requestUri.ToString());
            var separator = "&";

            if (string.IsNullOrEmpty(requestUri.Query))
            {
                separator = "?";
            }

            requestUriBuilder.Append($"{separator}apiKey={settings.ApiKey}&accountKey={settings.AccountKey}");

            return new Uri(requestUriBuilder.ToString());
        }
    }
}
