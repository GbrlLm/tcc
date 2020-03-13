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

        [HttpPost("Login")]
        public bool Post([FromBody] string[] credentials)
        {
            string user, pass;
            try
            {
                user = credentials[0];
                pass = credentials[1];
            }
            catch (Exception e) 
            { 
                return false; 
            }

            return _usuarioServices.login(user,pass);
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

