using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rezare.TogsCop.Api.Services;
using Rezare.TogsCop.Api.Services.Models;
using IStaffService = Rezare.TogsCop.Integration.WorkFlowMax.Services.IStaffService;
using TimeEntry = Rezare.TogsCop.Integration.Toggl.Api.Models.TimeEntry;

namespace Rezare.TogsCop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TogglController : BaseController
    {
        private readonly ITimeEntryService _timeEntryService;
        public TogglController(ITimeEntryService timeEntryService)
        {
            _timeEntryService = timeEntryService;
        }

        [HttpGet("time-records")]
        public Task<ActionResult<List<TimeEntry>>> GetTogglRecords([FromQuery] string apiKey, [FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            return WrapRequestAsync(() => _timeEntryService.GetTimeRecords(apiKey, startDate, endDate));
        }

    }
}