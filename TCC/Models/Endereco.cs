using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    [Table("endereco")]
    public class Endereco
    {
        [Column("cd_endereco")]
        public int id { get; set; }
        [Column("cd_usuario")]
        public int usuarioId { get; set; }
        [Column("ds_endereco")]
        public string endereco { get; set; }
        [Column("ds_complemento")]
        public string complemento { get; set; }
        [Column("nm_bairro")]
        public string bairro { get; set; }
        [Column("nm_cidade")]
        public string cidade { get; set; }
        [Column("nm_estado")]
        public string estado { get; set; }
    }
}
