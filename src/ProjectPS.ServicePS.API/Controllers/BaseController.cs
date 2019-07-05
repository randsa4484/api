using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPS.ServicePS.API.Controllers
{
    public abstract class BaseController : Controller
    {
      

        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Conflict(object value)
        {
            return this.StatusCode(StatusCodes.Status409Conflict, value);
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Error(object value)
        {
            return this.StatusCode(StatusCodes.Status500InternalServerError, value);
        }
        
    }
}
