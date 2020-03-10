using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    [Table("pedido")]
    public class Pedido
    {
        [Column("cd_pedido")]
        public int id { get; set; }
        [Column("cd_usuario")]
        public int usuarioId { get; set; }
        [Column("cd_status")]
        public int statusId { get; set; }
        [Column("cd_endereco")]
        public int enderecoInt { get; set; }
    }
}
