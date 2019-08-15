using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rezare.TogsCop.Api.Services;
using Rezare.TogsCop.Api.Services.Abstractions;
using Rezare.TogsCop.Api.Services.Models;

namespace Rezare.TogsCop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WfmController : BaseController
    {
        private readonly IStaffService _staffService;
        private readonly IWfmTasksService _wfmTasksService;

        public WfmController(IStaffService staffService, IWfmTasksService wfmTasksService)
        {
            _staffService = staffService;
            _wfmTasksService = wfmTasksService;
        }

        [HttpGet("staff")]
        public Task<ActionResult<List<Staff>>> GetAll()
        {
            return WrapRequestAsync(() => _staffService.GetAll());
        }

        [HttpGet("staff/{wfmStaffId}/tasks")]
        public Task<ActionResult<IEnumerable<WfmTask>>> GetWfmTasks(int wfmStaffId)
        {
            return WrapRequestAsync(() => _wfmTasksService.GetUserTasks(wfmStaffId));
        }

        //TODO : Implement POST
        [HttpPost("staff/{wfmStaffId}/time-records")]
        public Task<ActionResult> SendTimeRecords(int wfmStaffId, [FromBody]TimeSheet timeSheet)
        {
            return WrapRequestAsync(() =>
            {
                timeSheet.Staff = wfmStaffId;

                return _wfmTasksService.SendTimeRecords(timeSheet);
            });
        }
    }
}