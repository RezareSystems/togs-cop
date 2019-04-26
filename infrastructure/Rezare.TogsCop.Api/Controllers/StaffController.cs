using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rezare.TogsCop.Api.Services.Models;
using Rezare.TogsCop.Api.Services.WorkFlowMax;

namespace Rezare.TogsCop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : BaseController
    {
        private readonly IStaffService _service;

        public StaffController(IStaffService service)
        {
            _service = service;
        }

        public Task<ActionResult<List<Staff>>> GetAll()
        {
            return WrapRequestAsync(() => _service.GetAll());
        }
    }
}