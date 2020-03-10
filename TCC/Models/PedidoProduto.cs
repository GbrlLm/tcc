using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    [Table("pedido_produto")]
    public class PedidoProduto
    {
        [Column("cd_pedido")]
        public int id { get; set; }
        [Column("cd_produto_venda")]
        public int produtoVendaId { get; set; }
        [Column("qt_produto")]
        public int quantidade { get; set; }
    }
}
