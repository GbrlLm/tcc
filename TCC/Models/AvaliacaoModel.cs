using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    public class AvaliacaoModel
    {
        public int cd_avaliacao { get; set; }
        public int cd_usuario { get; set; }
        public int cd_produto { get; set; }
        public string ds_avaliacao { get; set; }
        public DateTime dt_avaliacao { get; set; }
    }
}
