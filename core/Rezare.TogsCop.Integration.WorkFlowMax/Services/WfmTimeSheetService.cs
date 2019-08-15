using Rezare.TogsCop.Integration.WorkFlowMax.Api;
using Rezare.TogsCop.Integration.WorkFlowMax.Api.Models;
using Rezare.TogsCop.Integration.WorkFlowMax.Api.Responses;
using Task = System.Threading.Tasks.Task;

namespace Rezare.TogsCop.Integration.WorkFlowMax.Services
{
    public class WfmTimeSheetService : IWfmTimesheetService
    {
        private readonly IWorkFlowMaxApiFactory _apiFactory;

        public WfmTimeSheetService(IWorkFlowMaxApiFactory apiFactory)
        {
            _apiFactory = apiFactory;
        }

        public async Task SendTimeSheet(TimeSheet timeSheet)
        {
            var api = await _apiFactory.Create<IWfmTimeSheetApi>();

            var response = await api.SendTimeSheet(timeSheet);

            return;
        }
    }
}
