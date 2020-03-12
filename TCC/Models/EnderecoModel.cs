using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    public class EnderecoModel
    {
        public int cd_endereco { get; set; }
        public int cd_usuario { get; set; }
        public string ds_endereco { get; set; }
        public string ds_complemento { get; set; }
        public string nm_bairro { get; set; }
        public string nm_cidade { get; set; }
        public string nm_estado { get; set; }
    }
}
