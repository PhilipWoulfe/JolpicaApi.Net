using System.Threading.Tasks;
using JolpicaApi.Requests;
using JolpicaApi.Responses;

namespace JolpicaApi.Client
{
    public interface IJolpiClient
    {
        Task<T> GetResponseAsync<T>(JolpicaRequest<T> request) where T : JolpicaResponse;
    }
}