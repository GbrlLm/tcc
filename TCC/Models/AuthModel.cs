using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    public class AuthModel
    {
        public int cd_auth { get; set; }
        public string cd_sessionId { get; set; }
        public int cd_usuario { get; set; }
    }
}
