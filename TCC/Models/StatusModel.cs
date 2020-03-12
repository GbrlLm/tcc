using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    public class StatusModel
    {
        public int cd_status { get; set; }
        public string ds_status { get; set; }
    }
}
