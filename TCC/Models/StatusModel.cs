using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    [Table("status")]
    public class StatusModel
    {
        [Column("cd_status")]
        public int cd_status { get; set; }
        [Column("ds_status")]
        public string ds_status { get; set; }
    }
}
