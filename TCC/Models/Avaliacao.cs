using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    [Table("avaliacao")]
    public class Avaliacao
    {
        [Column("cd_avaliacao")]
        public int id { get; set; }
        [Column("cd_usuario")]
        public int usuarioId { get; set; }
        [Column("cd_produto")]
        public int produtoId { get; set; }
        [Column("ds_avaliacao")]
        public string avalicao { get; set; }
        [Column("dt_avaliacao")]
        public DateTime data { get; set; }
    }
}
