using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcUserServer.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        } 
        
       
         [HttpGet("/CC/DD/FF/{id}/{id2}")] 
        public async Task<IActionResult> Index(int Id)
        {
            var context = HttpContext;

            return await Task.FromResult(Content("Success" + Id));
        }

        public async Task<IActionResult> GetUserInfo()
        { 
            return await Task.FromResult(Content("Success"));
        }

    } 
 
}
