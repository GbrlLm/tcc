using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    [Table("categoria")]
    public class CategoriaModel
    {
        [Column("cd_categoria")]
        public int id { get; set; }
        [Column("ds_categoria")]
        public string categoria { get; set; }
    }
}
