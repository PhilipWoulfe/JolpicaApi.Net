using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace JolpiApi.Abstractions
{
    /// <summary>
    /// Default implementation of the <see cref="IHttpClient"/> interface.
    /// </summary>
    public class DefaultHttpClient : IHttpClient
    {
        private HttpClient HttpClient { get; } = new HttpClient();

        /// <summary>
        /// Sends a GET request to the specified URI as an asynchronous operation.
        /// </summary>
        /// <param name="requestUri">The URI to which the request is sent.</param>
        /// <returns>The task object representing the asynchronous operation, containing the HTTP response message.</returns>
        public Task<HttpResponseMessage> GetAsync(string requestUri)
        {
            return HttpClient.GetAsync(requestUri);
        }

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="DefaultHttpClient"/> and optionally releases the managed resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="DefaultHttpClient"/> and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;

            HttpClient?.Dispose();
        }
    }
}
