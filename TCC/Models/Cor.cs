using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    [Table("cor")]
    public class Cor
    {
        [Column("cd_cor")]
        public int id { get; set; }
        [Column("ds_cor")]
        public string cor { get; set; }
    }
}
