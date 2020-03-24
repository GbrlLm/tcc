using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TCC.Models;
using TCC.Models.temp;
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

        [HttpPost("Login")]
        public bool Login([FromBody] Login values)
        {
            return _usuarioServices.login(values.token, values.email, values.pass);
        }

        [HttpPost("Logout/{token}")]
        public IActionResult Logout(string token)
        {
            _usuarioServices.logout(token);
            return Ok();
        }

        [HttpPost("SignUp")]
        public IActionResult SignUp([FromBody] SignUp values)
        {
            return Ok(_usuarioServices.signUp(values));
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

