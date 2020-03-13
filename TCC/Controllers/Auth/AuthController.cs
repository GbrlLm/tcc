using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TCC.Models;
using TCC.Services.Auth;

namespace TCC.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthServices _authServices;
        
        public AuthController(IAuthServices authServices)
        {
            _authServices = authServices;
        }


        [HttpGet("GetSessionId")]
        public string Get()
        {
            return _authServices.generateSessionId();
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
