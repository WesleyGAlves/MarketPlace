using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelo
{
    public class mdlProdutoVendedor
    {
        public int idProduto { get; set; }
        public string descricao { get; set; }
        public string preco { get; set; }
        public string imagem { get; set; }
        public string status { get; set; }
        public string vendedor_id { get; set; }
        public string categoria_id { get; set; }
    }
}