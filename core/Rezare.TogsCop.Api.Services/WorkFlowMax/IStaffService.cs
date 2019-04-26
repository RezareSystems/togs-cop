using System.Collections.Generic;
using System.Threading.Tasks;
using Rezare.TogsCop.Api.Services.Models;

namespace Rezare.TogsCop.Api.Services.WorkFlowMax
{
    public interface IStaffService
    {
        Task<List<Staff>> GetAll();
    }
}
