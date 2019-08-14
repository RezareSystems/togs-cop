using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rezare.TogsCop.Api.Services;
using Rezare.TogsCop.Integration.Toggl.Api.Models;

namespace Rezare.TogsCop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeEntriesController : BaseController
    {
        private readonly ITimeEntryService _service;

        public TimeEntriesController(ITimeEntryService service) 
        {
            _service = service;
        }

        [HttpGet("{apiKey}")]
        public Task<ActionResult<List<TimeEntry>>> GetForDate(DateTimeOffset date, string apiKey) 
        {
            return WrapRequestAsync(() => _service.GetFromToggl(date, apiKey));
        }
    }
}