using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rezare.TogsCop.Integration.WorkFlowMax.Api;
using Rezare.TogsCop.Integration.WorkFlowMax.Api.Models;

namespace Rezare.TogsCop.Integration.WorkFlowMax.Services
{
    public class WfmJobsService : IWfmJobsService
    {
        private readonly IWorkFlowMaxApiFactory _apiFactory;

        public WfmJobsService(IWorkFlowMaxApiFactory apiFactory)
        {
            _apiFactory = apiFactory;
        }

        public async Task<IEnumerable<Job>> GetUserJobs(int wfmStaffId)
        {
            var api = await _apiFactory.Create<IWfmJobsApi>();

            var response = await api.GetAllJobs();

            return response.Jobs;
        }
    }
}
