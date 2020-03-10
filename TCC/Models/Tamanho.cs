using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    [Table("tamanho")]
    public class Tamanho
    {
        [Column("cd_tamanho")]
        public int id { get; set; }
        [Column("ds_tamanho")]
        public string tamanho { get; set; }
    }
}
