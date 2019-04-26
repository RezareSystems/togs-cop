using System.Threading.Tasks;

namespace Rezare.TogsCop.Integration.WorkFlowMax.Api
{
    public interface IWorkFlowMaxSettingsService
    {
        Task<WorkFlowMaxApiSettings> Get();
    }
}
