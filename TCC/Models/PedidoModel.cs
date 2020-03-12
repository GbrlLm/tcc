using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    public class PedidoModel
    {
        public int cd_pedido { get; set; }
        public int cd_usuario { get; set; }
        public int cd_status { get; set; }
        public int cd_endereco { get; set; }
    }
}
