using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelo
{
    public class mdlCarrinhoRepository
    {
        public int idCarrinho { get; set; }
        public string dataPedido { get; set; }
        public string valorTotal { get; set; }
        public string statusPedido { get; set; }
        public string cliente { get; set; }
        public string produto { get; set; }
    }
}