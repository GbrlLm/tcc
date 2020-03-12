using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    public class ProdutoVendaModel
    {
        public int cd_produto_venda { get; set; }
        public int cd_produto { get; set; }
        public int cd_tamanho { get; set; }
        public int cd_cor { get; set; }
        public int qt_produto { get; set; }
    }
}
