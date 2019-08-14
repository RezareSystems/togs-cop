using System.Threading.Tasks;

namespace Rezare.TogsCop.Integration.Toggl.Api
{
    public interface ITogglApiSettingsService
    {
        Task<TogglApiSettings> Get();
    }
}
