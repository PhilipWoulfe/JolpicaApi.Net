using System.Threading.Tasks;
using JolpicaApi.Requests;
using JolpicaApi.Responses;

namespace JolpicaApi.Client
{
    public interface IJolpiClient
    {
        Task<T> GetResponseAsync<T>(JolpiRequest<T> request) where T : JolpiResponse;
    }
}