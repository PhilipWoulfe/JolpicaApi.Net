using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ErgastApi.Abstractions
{
    /// <summary>
    /// Represents an HTTP client for sending HTTP requests and receiving HTTP responses.
    /// </summary>
    public interface IHttpClient : IDisposable
    {
        /// <summary>
        /// Sends a GET request to the specified URI as an asynchronous operation.
        /// </summary>
        /// <param name="requestUri">The URI to which the request is sent.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the HTTP response message.</returns>
        Task<HttpResponseMessage> GetAsync(string requestUri);
    }
}