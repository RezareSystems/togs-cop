using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Rezare.TogsCop.Api.Services.Models;

namespace Rezare.TogsCop.Api.Services.Abstractions
{
    public interface IWfmTasksService
    {
        Task<IEnumerable<WfmTask>> GetUserTasks(int wfmStaffId);

        Task<WfmTask> GetUserTask(int wfmStaffId, string taskId);
    }
}
