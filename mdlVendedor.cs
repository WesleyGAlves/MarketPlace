using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelo
{
    public class mdlVendedor
    {
        public int idVendedor { get; set; }
        public string razaosocial { get; set; }
        public string nomefantasia { get; set; }
        public string emailvendedor { get; set; }
        public string senhavendedor { get; set; }
        public string cnpj { get; set; }
        public string comissao { get; set; }
        public int endereco_id { get; set;}
    }
}
