using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    [Table("usuario")]
    public class Usuario
    {
        [Column("cd_usuario")]
        public int id { get; set; }
        [Column("cd_senha")]
        public string senha { get; set; }
        [Column("nm_email")]
        public string email { get; set; }
        [Column("cd_cpf")]
        public string cpf { get; set; }
        [Column("nm_usuario")]
        public string nome { get; set; }
        [Column("nm_sobrenome")]
        public string sobrenome { get; set; }
        [Column("dt_nascimento")]
        public DateTime nascimento { get; set; }
        [Column("ic_sexo")]
        public string sexo { get; set; }
    }
}
