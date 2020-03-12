using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    public class UsuarioModel
    {
        public int cd_usuario { get; set; }
        public string cd_senha { get; set; }
        public string nm_email { get; set; }
        public string cd_cpf { get; set; }
        public string nm_usuario { get; set; }
        public string nm_sobrenome { get; set; }
        public DateTime dt_nascimento { get; set; }
        public string ic_sexo { get; set; }
    }
}
