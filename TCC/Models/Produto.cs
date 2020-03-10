using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    [Table("produto")]
    public class Produto
    {
        [Column("cd_produto")]
        public int id { get; set; }
        [Column("cd_categoria")]
        public int categoriaId { get; set; }
        [Column("nm_produto")]
        public string produto { get; set; }
        [Column("ds_foto")]
        public string foto { get; set; }
        [Column("ds_produto")]
        public string descricao { get; set; }
        [Column("vl_produto")]
        public double valor { get; set; }
    }
}
