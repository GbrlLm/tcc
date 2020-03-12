using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    public class ProdutoModel
    {
        public int cd_produto { get; set; }
        public int cd_categoria { get; set; }
        public string nm_produto { get; set; }
        public string ds_foto { get; set; }
        public string ds_produto { get; set; }
        public double vl_produto { get; set; }
    }
}
