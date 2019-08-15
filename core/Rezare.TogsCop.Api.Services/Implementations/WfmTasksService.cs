using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rezare.TogsCop.Api.Services.Abstractions;
using Rezare.TogsCop.Api.Services.Models;
using Rezare.TogsCop.Integration.WorkFlowMax.Services;
using WorkFlowMaxIntegration = Rezare.TogsCop.Integration.WorkFlowMax;

namespace Rezare.TogsCop.Api.Services.Implementations
{
    public class WfmTasksService : IWfmTasksService
    {
        private readonly IWfmJobsService _apiService;
        private readonly IWfmTimesheetService _timeSheetService;

        public WfmTasksService(IWfmJobsService apiService, IWfmTimesheetService timeSheetService)
        {
            _apiService = apiService;
            _timeSheetService = timeSheetService;
        }

        public async Task<IEnumerable<WfmTask>> GetUserTasks(int wfmStaffId)
        {
            try
            {
                var jobs = await _apiService.GetUserJobs(wfmStaffId);
                var jobsList = jobs.Where(j => j.Assigned.Any(s => s.Id == wfmStaffId)).ToList();

                var query = from job in jobsList
                    from task in job.Tasks
                    from staff in task.Assigned
                    where staff.Id == wfmStaffId
                    select new WfmTask()
                    {
                        Id = task.Id,
                        JobName = job.Name,
                        TaskName =  task.Name
                    };

                var jobTaskList = query.ToList();
                return jobTaskList;
            }
            catch (Exception ex)
            {
                var x = ex;
                throw;
            }
        }

        public Task<WfmTask> GetUserTask(int wfmStaffId, string taskId)
        {
            //TODO : Call WFM API to Get an individual user task based on taskId
            throw new NotImplementedException();
        }

        public Task SendTimeRecords(TimeSheet timeSheets)
        {
            var apiTimeSheet = new WorkFlowMaxIntegration.Api.Models.TimeSheet
            {
                Id = timeSheets.Id,
                Staff = timeSheets.Staff,
                Job = timeSheets.Job,
                Task = timeSheets.Task,
                Date = timeSheets.Date,
                Minutes = timeSheets.Minutes,
                Note = timeSheets.Note
            };

            return _timeSheetService.SendTimeSheet(apiTimeSheet);
        }
    }
}
