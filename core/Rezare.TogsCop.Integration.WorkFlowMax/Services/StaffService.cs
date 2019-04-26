using System.Collections.Generic;
using System.Threading.Tasks;
using Rezare.TogsCop.Integration.WorkFlowMax.Api;
using Rezare.TogsCop.Integration.WorkFlowMax.Api.Models;

namespace Rezare.TogsCop.Integration.WorkFlowMax.Services
{
    public class StaffService : IStaffService
    {
        private readonly IWorkFlowMaxApiFactory _apiFactory;

        public StaffService(IWorkFlowMaxApiFactory apiFactory)
        {
            _apiFactory = apiFactory;
        }

        public async Task<List<Staff>> GetAll()
        {
            var api = await _apiFactory.Create<IStaffApi>();
            var response = await api.GetAll();

            return response.StaffList;
        }
    }
}
