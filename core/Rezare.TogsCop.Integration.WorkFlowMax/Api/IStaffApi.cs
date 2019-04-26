using System.Threading.Tasks;
using Refit;
using Rezare.TogsCop.Integration.WorkFlowMax.Api.Responses;

namespace Rezare.TogsCop.Integration.WorkFlowMax.Api
{
    public interface IStaffApi : IWorkFlowMaxApi
    {
        [Get("/staff.api/list")]
        Task<StaffResponse> GetAll();
    }
}
