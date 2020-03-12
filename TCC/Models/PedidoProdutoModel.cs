using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    public class PedidoProdutoModel
    {
        public int cd_pedido { get; set; }
        public int cd_produto_venda { get; set; }
        public int qt_produto { get; set; }
    }
}
