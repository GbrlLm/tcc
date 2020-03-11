using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    [Table("produto_produto")]
    public class ProdutoVendaModel
    {
        [Column("cd_produto_produto")]
        public int id { get; set; }
        [Column("cd_produto")]
        public int produtoId { get; set; }
        [Column("cd_tamanho")]
        public int tamanhoId { get; set; }
        [Column("cd_cor")]
        public int corId { get; set; }
        [Column("qt_produto")]
        public int quantidade { get; set; }
    }
}
