using System.Threading.Tasks;

namespace Rezare.TogsCop.Integration.Toggl.Api
{
    public interface ITogglApiFactory
    {
        Task<T> Create<T>(string apiKey) where T : ITogglApi;
    }
}
