using System.Threading.Tasks;
using JolpiApi.Requests;
using JolpiApi.Responses;

namespace JolpiApi.Client
{
    public interface IErgastClient
    {
        Task<T> GetResponseAsync<T>(ErgastRequest<T> request) where T : ErgastResponse;
    }
}