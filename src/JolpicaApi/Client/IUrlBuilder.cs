using JolpicaApi.Requests;

namespace JolpicaApi.Client
{
    public interface IUrlBuilder
    {
        string Build(IJolpiRequest request);
    }
}