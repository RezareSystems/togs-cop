using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Rezare.TogsCop.Integration.WorkFlowMax.Api.Models;
using Task = System.Threading.Tasks.Task;

namespace Rezare.TogsCop.Integration.WorkFlowMax.Services
{
    public interface IWfmTimesheetService
    {
        Task SendTimeSheet(TimeSheet timeSheet);
    }
}
