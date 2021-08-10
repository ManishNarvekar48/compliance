using compliance.Database;
using compliance.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace compliance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUservices _uservices;
        public UserController(IUservices uservices)
        {
            _uservices = uservices;
        }
        [HttpGet]
        [Route("GetUserDetails")]
        public IActionResult GetUserDetails()
        {
            return Ok(_uservices.GetUserDetails());
        }

        
    }
}
