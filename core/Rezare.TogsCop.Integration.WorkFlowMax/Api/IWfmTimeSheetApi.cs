using System.Net.Http;
using System.Threading.Tasks;
using Refit;
using Rezare.TogsCop.Integration.WorkFlowMax.Api.Models;
using Rezare.TogsCop.Integration.WorkFlowMax.Api.Responses;
using Task = System.Threading.Tasks.Task;

namespace Rezare.TogsCop.Integration.WorkFlowMax.Api
{
    public interface IWfmTimeSheetApi : IWorkFlowMaxApi
    {
        [Post("/time.api/add")]
        Task<TimeResult> SendTimeSheet(TimeSheet timeSheet);
    }
}
