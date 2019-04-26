using System.Collections.Generic;
using System.Threading.Tasks;
using Rezare.TogsCop.Integration.WorkFlowMax.Api.Models;

namespace Rezare.TogsCop.Integration.WorkFlowMax.Services
{
    public interface IStaffService
    {
        Task<List<Staff>> GetAll();
    }
}
