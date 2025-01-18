using JolpiApi.Requests;

namespace JolpiApi.Client
{
    public interface IUrlBuilder
    {
        string Build(IJolpiRequest request);
    }
}