using JolpicaApi.Requests;

namespace JolpicaApi.Client
{
    /// <summary>
    /// Interface for building URLs based on Jolpica requests.
    /// </summary>
    public interface IUrlBuilder
    {
        /// <summary>
        /// Builds a URL based on the provided Jolpica request.
        /// </summary>
        /// <param name="request">The Jolpica request containing parameters for the URL.</param>
        /// <returns>A string representing the built URL.</returns>
        string Build(IJolpicaRequest request);
    }
}