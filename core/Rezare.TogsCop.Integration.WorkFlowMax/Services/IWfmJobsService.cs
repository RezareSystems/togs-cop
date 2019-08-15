using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rezare.TogsCop.Integration.WorkFlowMax.Services
{
    public interface IWfmJobsService
    {
        Task<IEnumerable<Api.Models.Job>> GetUserJobs(int wfmStaffId);
    }
}
