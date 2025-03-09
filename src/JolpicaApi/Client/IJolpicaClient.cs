using System.Threading.Tasks;
using JolpicaApi.Requests;
using JolpicaApi.Responses;

namespace JolpicaApi.Client
{
    /// <summary>
    /// Interface for Jolpica API client.
    /// </summary>
    public interface IJolpicaClient
    {
        /// <summary>
        /// Sends a request to the Jolpica API and gets the response asynchronously.
        /// </summary>
        /// <typeparam name="T">The type of the response.</typeparam>
        /// <param name="request">The request to send.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response.</returns>
        Task<T> GetResponseAsync<T>(JolpicaRequest<T> request) where T : JolpicaResponse;
    }
}