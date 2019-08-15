using System.Threading.Tasks;
using Refit;
using Rezare.TogsCop.Integration.WorkFlowMax.Api.Responses;

namespace Rezare.TogsCop.Integration.WorkFlowMax.Api
{
    public interface IWfmJobsApi : IWorkFlowMaxApi
    {
        [Get("/job.api/current?detailed=true")]
        Task<JobResponse> GetAllJobs();
    }
}
