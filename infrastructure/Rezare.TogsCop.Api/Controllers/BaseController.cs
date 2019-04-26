using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Rezare.TogsCop.Api.Controllers
{
    public class BaseController : ControllerBase
    {
        protected async Task<ActionResult<T>> WrapRequestAsync<T>(Func<Task<T>> method)
        {
            try
            {
                var result = await method();

                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
