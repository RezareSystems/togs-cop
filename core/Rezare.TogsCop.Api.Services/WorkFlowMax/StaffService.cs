using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rezare.TogsCop.Api.Services.Models;
using WorkFlowMaxIntegration = Rezare.TogsCop.Integration.WorkFlowMax;

namespace Rezare.TogsCop.Api.Services.WorkFlowMax
{
    public class StaffService : IStaffService
    {
        private readonly WorkFlowMaxIntegration.Services.IStaffService _apiService;

        public StaffService(WorkFlowMaxIntegration.Services.IStaffService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<Staff>> GetAll()
        {
            var wfmStaff = await _apiService.GetAll();

            return wfmStaff.Select(s => new Staff
            {
                WorkFlowMaxId = s.Id,
                Name = s.Name
            }).ToList();
        }
    }
}
