using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TCC.Models;
using TCC.Services.Usuario;

namespace TCC.Controllers.Usuario
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioServices _usuarioServices;

        public UsuarioController(IUsuarioServices usuarioServices)
        {
            _usuarioServices = usuarioServices;
        }


        [HttpGet]
        public void Get()
        {
        }

        [HttpPost("Login/{token}")]
        public bool Post(string token, [FromForm] string user, [FromForm] string pass)
        {
            return _usuarioServices.login(token,user,pass);
        }

        [HttpPost("Logout/{token}")]
        public IActionResult Post(string token)
        {
            _usuarioServices.logout(token);
            return Ok();
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

