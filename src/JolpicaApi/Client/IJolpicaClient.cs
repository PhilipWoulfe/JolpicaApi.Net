using System.Threading.Tasks;
using JolpiApi.Requests;
using JolpiApi.Responses;

namespace JolpiApi.Client
{
    public interface IJolpiClient
    {
        Task<T> GetResponseAsync<T>(JolpiRequest<T> request) where T : JolpiResponse;
    }
}